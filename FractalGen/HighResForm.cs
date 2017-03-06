using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using FractalGenLib;

namespace FractalGen
{
	public partial class HighResForm : Form
	{
		FractalLocation mLocation;
		int mIterations, mColours;
		bool mRepeatColours;
		ColourScheme mColourScheme;

		public HighResForm()
		{
			InitializeComponent();
		}

		public void SetValues(FractalLocation location, int iterations, int colours, ColourScheme cs, float colourShift, bool repeatColours)
		{
			mLocation = location;
			mIterations = iterations;
			mColours = colours;
			mColourScheme = cs;
			mRepeatColours = repeatColours;

			lblLeft.Text = "Left: " + location.Left.ToString();
			lblRight.Text = "Right: " + location.Right.ToString();
			lblTop.Text = "Top: " + location.Top.ToString();
			lblBottom.Text = "Bottom: " + location.Bottom.ToString();
			txtMaxIterations.Text = iterations.ToString();

			txtThreads.Text = (Environment.ProcessorCount * 4).ToString();
			txtImageWidth.Text = "4500";
			UpdateImageSize();

			nudColourShift.Value = Convert.ToDecimal(colourShift * 100.0f);

			txtPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\fractals\\fractal 1";
		}

		private void UpdateImageSize()
		{
			if (txtImageWidth.TextLength == 0)
				return;

			int width = Convert.ToInt32(txtImageWidth.Text);
			int height = GetHeightFromWidth(width);

			lblImageHeight.Text = "x " + height;
		}

		private int GetHeightFromWidth(int width)
		{
			return (int)((float)width / 35.0f * 23.0f);
		}

		private void txtImageWidth_TextChanged(object sender, EventArgs e)
		{
			UpdateImageSize();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.SelectedPath = txtPath.Text;
			if (dialog.ShowDialog() == DialogResult.OK) {
				txtPath.Text = dialog.SelectedPath;
			}
		}

		private void btnCalculateFractal_Click(object sender, EventArgs e)
		{
			if (FractalExists(txtPath.Text)) {
				MessageBox.Show("Fractal files already exist! Delete or move these if you want to calculate new ones.");
				return;
			}

			if (!Directory.Exists(txtPath.Text))
				Directory.CreateDirectory(txtPath.Text);

			string inputPath = Path.Combine(txtPath.Text, "input.dat");

			SaveFractalConfig(inputPath);

			string consolePath = ConsoleFilename;
			ProcessStartInfo psi = new ProcessStartInfo(consolePath, String.Format("-g \"{0}\"", inputPath));
			Process.Start(psi);
		}

		private void btnRenderFractal_Click(object sender, EventArgs e)
		{
			if (!FractalExists(txtPath.Text)) {
				MessageBox.Show("No fractal files found.");
				return;
			}

			string inputPath = Path.Combine(txtPath.Text, "colours.dat");
			SaveColourConfig(inputPath);

			string consolePath = ConsoleFilename;
			ProcessStartInfo psi = new ProcessStartInfo(consolePath, String.Format("-r \"{0}\" {1} {2:0.00} {3}", inputPath, Convert.ToInt32(txtMaxIterations.Text), nudColourShift.Value / 100, (mRepeatColours ? "-r" : "-nr")));
			Process.Start(psi);
		}

		private bool FractalExists(string path)
		{
			string filename = Path.Combine(txtPath.Text, "f.dat");
			return File.Exists(filename);
		}

		private void SaveFractalConfig(string path)
		{
			FileStream fs = new FileStream(path, FileMode.Create);
			BinaryWriter bw = new BinaryWriter(fs);

			bw.Write(mLocation.Left);
			bw.Write(mLocation.Right);
			bw.Write(mLocation.Top);
			bw.Write(mLocation.Bottom);

			bw.Write(Convert.ToInt32(txtMaxIterations.Text));
			bw.Write(Convert.ToInt32(mColours));
			bw.Write(Convert.ToInt32(txtThreads.Text));
			bw.Write(Convert.ToInt32(txtImageWidth.Text));
			bw.Write(Convert.ToInt32(GetHeightFromWidth(Convert.ToInt32(txtImageWidth.Text))));

			bw.Close();
			fs.Close();
		}

		private void SaveColourConfig(string path)
		{
			mColourScheme.Save(path);
		}

		private void btnCustomColours_Click(object sender, EventArgs e)
		{
			ColourSchemeForm csf = new ColourSchemeForm();
			csf.ColourScheme = mColourScheme;
			if (csf.ShowDialog() == DialogResult.OK) {
				mColourScheme = csf.ColourScheme;
				pnlSpectrum.Invalidate();
			}
		}

		private void btnRandomColours_Click(object sender, EventArgs e)
		{
			mColourScheme = ColourScheme.GetRandom(12);
			pnlSpectrum.Invalidate();
		}

		private void pnlSpectrum_Paint(object sender, PaintEventArgs e)
		{
			float numColours = (float)mColourScheme.Colours.Count;
			float width = (float)pnlSpectrum.Width;

			float cInc = numColours / width;

			for (int i = 0; i < width; i++) {
				e.Graphics.DrawLine(new Pen(mColourScheme.Colours[(int)(cInc * i)]), i, 0, i, pnlSpectrum.Height);
			}
		}

		private string ConsoleFilename
		{
			get
			{
				string inAppDir = Application.StartupPath + "\\FractalGenConsole.exe";
				if (!File.Exists(inAppDir)) {
					return @"C:\Users\Ted\Documents\Programming\Projects\Software\FractalGen\FractalGenConsole\bin\Debug\FractalGenConsole.exe";
				} else {
					return inAppDir;
				}
			}
		}
	}
}

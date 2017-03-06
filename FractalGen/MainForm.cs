using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FractalGenConsole;
using System.Threading;
using FractalGenLib;

namespace FractalGen
{
	public partial class MainForm : Form
	{
		FractalLocation mLocation;

		byte[] mFractalPattern;

		bool mResizeDraw = false;

		List<Color> mColours = new List<Color>();
		int mIterations = 16;
		float mColourShift = 0.0f;

		bool mSmooth = true;
		bool mRepeatColours = false;

		List<ColourScheme> mColourSchemes = new List<ColourScheme>();
		ColourScheme mColourScheme;

		FractalGenerator mFGen;
		Thread mWorkingThread;

		public MainForm()
		{
			InitializeComponent();

			LoadLocations();
			LoadColourSchemes();
			SelectColourScheme(mColourSchemes[0]);

			ClientSize = new Size(350, 230);

			ResetLocation();

			mResizeDraw = true;

			PatternChanged();
		}

		private void ResetLocation()
		{
			ChangeLocation(-0.75, 0.0, 4.0, 3);
			mIterations = 16;

			PatternChanged();
		}

		private void LoadColourSchemes()
		{
			mColourSchemes.AddRange(ColourScheme.GetSamples());

			foreach (ColourScheme cs in mColourSchemes) {
				ToolStripMenuItem item = new ToolStripMenuItem(String.Format("{0} ({1})", cs.Name, cs.Colours.Count));
				item.Tag = cs;
				item.Click += new EventHandler(item_Click);
				coloursToolStripMenuItem.DropDownItems.Add(item);
			}
		}

		private bool CheckColourScheme(ColourScheme cs)
		{
			if (mRepeatColours)
				return true;

			if (cs.Colours.Count == mIterations)
				return true;

			return false;
		}

		private void SelectColourScheme(ColourScheme cs)
		{
			foreach (ToolStripMenuItem item in coloursToolStripMenuItem.DropDownItems) {
				if ((ColourScheme)item.Tag == cs)
					item.Checked = true;
				else
					item.Checked = false;
			}

			mColourScheme = cs;
			mColours = cs.Colours;
			testToolStripStatusLabel.Invalidate();

			//if (!CheckColourScheme(cs))
			//    PatternChanged();
			//else
				RenderFractal();
		}

		void item_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem item = (ToolStripMenuItem)sender;
			ColourScheme cs = (ColourScheme)item.Tag;

			SelectColourScheme(cs);

			//if (CheckColourScheme(cs))
			//    SelectColourScheme(cs);
			//else {
			//    DialogResult result = MessageBox.Show("As repeat colours were not on, would you like to re-calculate the fractal?", "Colour Scheme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			//    if (result == DialogResult.OK)
			//        SelectColourScheme(cs);
			//}
		}

		private void RenderFractal()
		{
			List<Color> newColourList = new List<Color>();
			
			if (mRepeatColours) {
				newColourList.AddRange(mColours.ToArray());
				int iterations = mIterations;
				if (mColours.Count < iterations) {
					int numToAdd = iterations - mColours.Count;
					if (mColours.Count >= numToAdd) {
						newColourList.AddRange(mColours.GetRange(0, numToAdd));
					} else {
						int batchesToAdd = numToAdd / mColours.Count;
						for (int i = 0; i < batchesToAdd; i++)
							newColourList.AddRange(mColours.ToArray());
						int remainder = numToAdd % mColours.Count;
						newColourList.AddRange(mColours.GetRange(0, remainder));
					}
				}
			} else {
				float ratio = (float)mColours.Count / (float)mIterations;
				for (int i = 0; i < mIterations; i++) {
					int rounded = (int)Math.Round(i * ratio);
					rounded = Math.Min(mColours.Count - 1, rounded);
					newColourList.Add(mColours[rounded]);
				}
			}

			//Shift colours
			int shiftCount = (int)Math.Round((float)newColourList.Count * mColourShift);
			newColourList.AddRange(newColourList.GetRange(0, shiftCount));
			newColourList.RemoveRange(0, shiftCount);

			FractalRenderer renderer = new FractalRenderer();
			renderer.ImageSize = GetFractalImageSize();
			renderer.Iterations = mIterations;
			renderer.Colours = newColourList.ToArray();

			renderer.RenderFractal(mFractalPattern);
			pnlFractal.BackgroundImage = renderer.GetImage();
		}

		private void PatternChanged()
		{
			iterationsToolStripStatusLabel.Text = "Iterations: " + mIterations;

			if (GetFractalImageSize() == Size.Empty)
				return;

			if (mWorkingThread != null) {
				if (mWorkingThread.ThreadState == ThreadState.Running)
					return;
			}

			mWorkingThread = new Thread(new ThreadStart(ThreadedGenerateFractal));
			mWorkingThread.Start();
		}

		private void ThreadedGenerateFractal()
		{
			mFGen = new FractalGenerator(new MandelbrotStrategy());
			mFGen.Iterations = mIterations;
			mFGen.ImageSize = GetFractalImageSize();
			mFGen.Smooth = mSmooth;
			mFGen.Colours = mIterations;
			mFGen.Location = mLocation;
			mFGen.Threads = Environment.ProcessorCount * 8;

			mFractalPattern = mFGen.GenerateFractal();
			RenderFractal();
		}

		private void SaveFractalInputConfig(string path)
		{
			FileStream fs = new FileStream(path, FileMode.Create);
			BinaryWriter bw = new BinaryWriter(fs);

			bw.Write(mLocation.Left);
			bw.Write(mLocation.Right);
			bw.Write(mLocation.Top);
			bw.Write(mLocation.Bottom);

			bw.Close();
			fs.Close();
		}

		private Size GetFractalImageSize()
		{
			float width = (float)pnlFractal.Width;
			float height = (float)pnlFractal.Height;

			height = width / 35.0f * 23.0f;

			return new Size((int)width, (int)height);

			//float multiplier = 1.0f;

			//float width = (float)pnlFractal.Width * multiplier;
			//float height = (float)pnlFractal.Height * multiplier;

			//return new Size((int)width, (int)height);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (e.KeyCode == Keys.OemMinus) {
				lessToolStripMenuItem_Click(this, EventArgs.Empty);
			}

			if (e.KeyCode == Keys.Oemplus) {
				moreToolStripMenuItem_Click(this, EventArgs.Empty);	
			}
		}

		private void resetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ResetLocation();
		}

		private void saveConfigToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "FractalGen Input Config (*.fc)|*.fc";
			if (dialog.ShowDialog() == DialogResult.OK) {
				SaveFractalInputConfig(dialog.FileName);
				MessageBox.Show("Saved Successfully!");
			}
		}

		private void lessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (mIterations > 1) {
				mIterations /= 2;
				PatternChanged();
			}
		}

		private void moreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			mIterations *= 2;
			PatternChanged();
		}

		private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
		{
			mSmooth = smoothToolStripMenuItem.Checked;
			PatternChanged();
		}

		private void pnlFractal_Resize(object sender, EventArgs e)
		{
			if (!mResizeDraw)
				return;

			//PatternChanged();
		}

		private void pnlFractal_MouseDown(object sender, MouseEventArgs e)
		{
			double xRange = mLocation.Width;
			double yRange = mLocation.Height;

			double newOriginX = (xRange / ClientSize.Width) * e.X + mLocation.Left;
			double newOriginY = (yRange / ClientSize.Height) * e.Y + mLocation.Top;

			if (e.Button == MouseButtons.Left) {
				ChangeLocation(newOriginX, newOriginY, 0.50);
			} else {
				if (mLocation.Width > 6)
					return;
				ChangeLocation(newOriginX, newOriginY, 2.0);
			}

			PatternChanged();
		}

		private void ChangeLocation(double x, double y, double rangeMultiplier)
		{
			double xRange = mLocation.Width * rangeMultiplier;
			double yRange = mLocation.Height * rangeMultiplier;
			ChangeLocation(x, y, xRange, yRange);
		}

		private void ChangeLocation(double x, double y, double xRange, double yRange)
		{
			mLocation.SetOriginAndRange(x, y, xRange, yRange);
		}

		private void customToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InputForm form = new InputForm("Custom Iterations", "Enter the maximum number of iterations.", mIterations.ToString());
			if (form.ShowDialog() == DialogResult.OK) {
				mIterations = Convert.ToInt32(form.InputText);
				PatternChanged();
			}
		}

		private void repeatColoursToolStripMenuItem_Click(object sender, EventArgs e)
		{
			mRepeatColours = repeatColoursToolStripMenuItem.Checked;
			RenderFractal();
			//PatternChanged();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void saveLocationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InputForm form = new InputForm("Save Location", "Enter the name of this location.", "");
			if (form.ShowDialog() == DialogResult.OK) {
				SaveLocation(form.InputText);
			}
		}

		private void LoadLocations()
		{
			savedLocationsToolStripMenuItem.DropDownItems.Clear();

			string[] files = Directory.GetFiles("locations");
			foreach (string file in files) {
				string name = GetLocationName(file);
				ToolStripMenuItem item = new ToolStripMenuItem(name);
				item.Tag = file;
				item.Click += new EventHandler(location_Click);
				savedLocationsToolStripMenuItem.DropDownItems.Add(item);
			}
		}

		void location_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem item = (ToolStripMenuItem)sender;
			string file = (string)item.Tag;

			SetLocation(file);
			PatternChanged();
		}

		private void SaveLocation(string name)
		{
			if (!Directory.Exists("locations"))
				Directory.CreateDirectory("locations");

			string fn;
			int index = -1;
			do {
				index++;
				fn = "locations\\location" + index + ".dat";
			} while (File.Exists(fn));

			FileStream fs = new FileStream(fn, FileMode.Create);
			BinaryWriter bw = new BinaryWriter(fs);

			bw.Write(name);
			bw.Write(mLocation.Left);
			bw.Write(mLocation.Right);
			bw.Write(mLocation.Top);
			bw.Write(mLocation.Bottom);
			bw.Write(mIterations);

			bw.Close();
			fs.Close();

			LoadLocations();
		}

		private string GetLocationName(string path)
		{
			FileStream fs = new FileStream(path, FileMode.Open);
			BinaryReader br = new BinaryReader(fs);

			string name = br.ReadString();

			br.Close();
			fs.Close();

			return name;
		}

		private void SetLocation(string path)
		{
			FileStream fs = new FileStream(path, FileMode.Open);
			BinaryReader br = new BinaryReader(fs);

			string name = br.ReadString();
			mLocation.Left = br.ReadDouble();
			mLocation.Right = br.ReadDouble();
			mLocation.Top = br.ReadDouble();
			mLocation.Bottom = br.ReadDouble();
			mIterations = br.ReadInt32();

			br.Close();
			fs.Close();
		}

		private void testToolStripStatusLabel_Paint(object sender, PaintEventArgs e)
		{
			float numColours = (float)mColours.Count;
			float width = (float)testToolStripStatusLabel.Width;
			float height = (float)testToolStripStatusLabel.Height;

			float cInc = numColours / width;

			for (int i = 0; i < width; i++) {
				e.Graphics.DrawLine(new Pen(mColours[(int)(cInc * i)]), i, 0, i, testToolStripStatusLabel.Height);
			}

			e.Graphics.FillRectangle(Brushes.Black, mColourShift * width, 0, 4, height);
			e.Graphics.FillRectangle(Brushes.White, mColourShift * width + 1, 1, 2, height - 2);
		}

		private void randomColoursToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SelectColourScheme(ColourScheme.GetRandom(12));
		}

		private void setColoursToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColourSchemeForm csf = new ColourSchemeForm();
			csf.ColourScheme = mColourScheme;
			if (csf.ShowDialog() == DialogResult.OK) {
				SelectColourScheme(csf.ColourScheme);
			}
		}

		private void tmrUpdate_Tick(object sender, EventArgs e)
		{
			if (mWorkingThread != null) {
				if (mWorkingThread.ThreadState == ThreadState.Running) {
					progressToolStripProgressBar.Visible = true;
					progressToolStripProgressBar.Minimum = 0;
					progressToolStripProgressBar.Maximum = mFGen.ImageSize.Height;
					progressToolStripProgressBar.Value = mFGen.LinesDone;
					return;
				}
			}

			progressToolStripProgressBar.Visible = false;
		}

		private void highResolutionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HighResForm form = new HighResForm();
			form.SetValues(mLocation, mIterations, (mRepeatColours ? mIterations : mColours.Count), mColourScheme, mColourShift, mRepeatColours);
			form.ShowDialog();
		}

		private void MainForm_ResizeEnd(object sender, EventArgs e)
		{
			PatternChanged();
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg == 0x0112) // WM_SYSCOMMAND
            {
				if (m.WParam == new IntPtr(0xF030)) // SC_MAXIMIZE
                {
					PatternChanged();
				} else if (m.WParam == new IntPtr(0xF120)) // SC_RESTORE
				{
					PatternChanged();
				}
				m.Result = new IntPtr(0);
			} 
		}

		private void testToolStripStatusLabel_MouseDown(object sender, MouseEventArgs e)
		{
			testToolStripStatusLabel_MouseMove(sender, e);
		}

		private void testToolStripStatusLabel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) {
				mColourShift = (float)e.X / (float)testToolStripStatusLabel.Width;
				RenderFractal();
				testToolStripStatusLabel.Invalidate();
			}
		}

		private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetImage(pnlFractal.BackgroundImage);
		}
	}
}

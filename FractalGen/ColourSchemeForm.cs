using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FractalGenLib;

namespace FractalGen
{
	partial class ColourSchemeForm : Form
	{
		private ColourScheme mColourScheme;
		private List<Color> mSelectedColours = new List<Color>();

		public ColourSchemeForm()
		{
			InitializeComponent();

			btnAddColour.Enabled = btnRemoveLastColour.Enabled = true;
		}

		public ColourScheme ColourScheme
		{
			get
			{
				return mColourScheme;
			}
			set
			{
				mColourScheme = value;
				mSelectedColours = mColourScheme.CreationColours;
				nudTransition.Value = mColourScheme.DefaultGradientLength;
			}
		}

		private void pnlSpectrum_Paint(object sender, PaintEventArgs e)
		{
			lblNumColours.Text = "Colours: " + mColourScheme.Colours.Count;

			if (mColourScheme.Colours.Count == 0) {
				return;
			}

			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

			double cx = pnlSpectrum.Width / 2;
			double cy = pnlSpectrum.Height / 2;
			double radius = pnlSpectrum.Width / 2 - 5;
			double innerRadius = 1;

			double numColours = mColourScheme.Colours.Count;
			double cInc = numColours / (Math.PI * 2);

			for (double a = 0; a < Math.PI * 2; a += 0.005) {
				Color c = mColourScheme.Colours[(int)(cInc * a)];

				double x = Math.Cos(a) * radius + cx;
				double y = Math.Sin(a) * radius + cy;
				double ix = Math.Cos(a) * innerRadius + cx;
				double iy = Math.Sin(a) * innerRadius + cy;

				e.Graphics.DrawLine(new Pen(c), (float)ix, (float)iy, (float)x, (float)y);
			}
		}

		private void btnRandom_Click(object sender, EventArgs e)
		{
			mColourScheme = ColourScheme.GetRandom((int)nudRandomColours.Value, (int)nudTransition.Value);
			mSelectedColours = mColourScheme.CreationColours;
			
			pnlSpectrum.Invalidate();
			pnlSelectedColours.Invalidate();

			//btnAddColour.Enabled = btnRemoveLastColour.Enabled = false;
		}

		private void CreateColourScheme()
		{
			mColourScheme = new ColourScheme();
			mColourScheme.DefaultGradientLength = (int)nudTransition.Value;

			if (mSelectedColours.Count > 0) {
				mColourScheme.Add(mSelectedColours[0]);
				for (int i = 1; i < mSelectedColours.Count; i++) {
					mColourScheme.AddGradient(mSelectedColours[i], -1);
				}
				//mColourScheme.AddGradient(mSelectedColours[0], -1);
			}

			pnlSpectrum.Invalidate();
			pnlSelectedColours.Invalidate();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			mSelectedColours.Clear();
			CreateColourScheme();

			btnAddColour.Enabled = btnRemoveLastColour.Enabled = true;
		}

		private void btnAddColour_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK) {
				mSelectedColours.Add(dialog.Color);
				CreateColourScheme();
			}
		}

		private void btnRemoveLastColour_Click(object sender, EventArgs e)
		{
			if (mSelectedColours.Count > 0) {
				mSelectedColours.RemoveAt(mSelectedColours.Count - 1);
				CreateColourScheme();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void pnlSelectedColours_Paint(object sender, PaintEventArgs e)
		{
			float bWidth = (float)pnlSelectedColours.Width;
			float sWidth = 4;
			float nCPR = 6;

			float cWidth = (bWidth - (6 * sWidth)) / nCPR;

			int numRows = (int)Math.Ceiling(mSelectedColours.Count / nCPR);

			for (float yy = 0; yy < numRows; yy++) {
				for (float xx = 0; xx < nCPR; xx++) {
					int index = (int)(yy * nCPR + xx);
					if (mSelectedColours.Count - 1 < index)
						break;

					float x = (cWidth * xx) + (sWidth * xx);
					float y = (cWidth * yy) + (sWidth * yy);

					SolidBrush brush = new SolidBrush(mSelectedColours[index]);

					e.Graphics.DrawRectangle(Pens.DarkGray, (int)x, (int)y, (int)cWidth - 1, (int)cWidth - 1);
					e.Graphics.DrawRectangle(Pens.White, (int)x + 1, (int)y + 1, (int)cWidth - 3, (int)cWidth - 3);
					e.Graphics.FillRectangle(brush, (int)x + 2, (int)y + 2, (int)cWidth - 4, (int)cWidth - 4);
				}
			}
		}

		private void nudTransition_ValueChanged(object sender, EventArgs e)
		{
			CreateColourScheme();
		}
	}
}

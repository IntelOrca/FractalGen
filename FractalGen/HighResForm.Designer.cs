namespace FractalGen
{
	partial class HighResForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpLocation = new System.Windows.Forms.GroupBox();
			this.lblBottom = new System.Windows.Forms.Label();
			this.lblRight = new System.Windows.Forms.Label();
			this.lblTop = new System.Windows.Forms.Label();
			this.lblLeft = new System.Windows.Forms.Label();
			this.grpAppearance = new System.Windows.Forms.GroupBox();
			this.lblImageHeight = new System.Windows.Forms.Label();
			this.txtImageWidth = new System.Windows.Forms.TextBox();
			this.lblImageSize = new System.Windows.Forms.Label();
			this.txtThreads = new System.Windows.Forms.TextBox();
			this.lblThreads = new System.Windows.Forms.Label();
			this.txtMaxIterations = new System.Windows.Forms.TextBox();
			this.lblMaxIterations = new System.Windows.Forms.Label();
			this.grpPath = new System.Windows.Forms.GroupBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnRenderFractal = new System.Windows.Forms.Button();
			this.btnCalculateFractal = new System.Windows.Forms.Button();
			this.btnCustomColours = new System.Windows.Forms.Button();
			this.grpColours = new System.Windows.Forms.GroupBox();
			this.pnlSpectrum = new System.Windows.Forms.Panel();
			this.btnRandomColours = new System.Windows.Forms.Button();
			this.nudColourShift = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.grpLocation.SuspendLayout();
			this.grpAppearance.SuspendLayout();
			this.grpPath.SuspendLayout();
			this.grpColours.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudColourShift)).BeginInit();
			this.SuspendLayout();
			// 
			// grpLocation
			// 
			this.grpLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpLocation.Controls.Add(this.lblBottom);
			this.grpLocation.Controls.Add(this.lblRight);
			this.grpLocation.Controls.Add(this.lblTop);
			this.grpLocation.Controls.Add(this.lblLeft);
			this.grpLocation.Location = new System.Drawing.Point(12, 12);
			this.grpLocation.Name = "grpLocation";
			this.grpLocation.Size = new System.Drawing.Size(316, 65);
			this.grpLocation.TabIndex = 0;
			this.grpLocation.TabStop = false;
			this.grpLocation.Text = "Location";
			// 
			// lblBottom
			// 
			this.lblBottom.AutoSize = true;
			this.lblBottom.Location = new System.Drawing.Point(157, 40);
			this.lblBottom.Name = "lblBottom";
			this.lblBottom.Size = new System.Drawing.Size(43, 13);
			this.lblBottom.TabIndex = 3;
			this.lblBottom.Text = "Bottom:";
			// 
			// lblRight
			// 
			this.lblRight.AutoSize = true;
			this.lblRight.Location = new System.Drawing.Point(157, 19);
			this.lblRight.Name = "lblRight";
			this.lblRight.Size = new System.Drawing.Size(35, 13);
			this.lblRight.TabIndex = 2;
			this.lblRight.Text = "Right:";
			// 
			// lblTop
			// 
			this.lblTop.AutoSize = true;
			this.lblTop.Location = new System.Drawing.Point(9, 40);
			this.lblTop.Name = "lblTop";
			this.lblTop.Size = new System.Drawing.Size(29, 13);
			this.lblTop.TabIndex = 1;
			this.lblTop.Text = "Top:";
			// 
			// lblLeft
			// 
			this.lblLeft.AutoSize = true;
			this.lblLeft.Location = new System.Drawing.Point(9, 19);
			this.lblLeft.Name = "lblLeft";
			this.lblLeft.Size = new System.Drawing.Size(28, 13);
			this.lblLeft.TabIndex = 0;
			this.lblLeft.Text = "Left:";
			// 
			// grpAppearance
			// 
			this.grpAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpAppearance.Controls.Add(this.lblImageHeight);
			this.grpAppearance.Controls.Add(this.txtImageWidth);
			this.grpAppearance.Controls.Add(this.lblImageSize);
			this.grpAppearance.Controls.Add(this.txtThreads);
			this.grpAppearance.Controls.Add(this.lblThreads);
			this.grpAppearance.Controls.Add(this.txtMaxIterations);
			this.grpAppearance.Controls.Add(this.lblMaxIterations);
			this.grpAppearance.Location = new System.Drawing.Point(12, 83);
			this.grpAppearance.Name = "grpAppearance";
			this.grpAppearance.Size = new System.Drawing.Size(316, 76);
			this.grpAppearance.TabIndex = 1;
			this.grpAppearance.TabStop = false;
			this.grpAppearance.Text = "Appearance";
			// 
			// lblImageHeight
			// 
			this.lblImageHeight.AutoSize = true;
			this.lblImageHeight.Location = new System.Drawing.Point(198, 48);
			this.lblImageHeight.Name = "lblImageHeight";
			this.lblImageHeight.Size = new System.Drawing.Size(12, 13);
			this.lblImageHeight.TabIndex = 6;
			this.lblImageHeight.Text = "x";
			// 
			// txtImageWidth
			// 
			this.txtImageWidth.Location = new System.Drawing.Point(92, 45);
			this.txtImageWidth.Name = "txtImageWidth";
			this.txtImageWidth.Size = new System.Drawing.Size(100, 20);
			this.txtImageWidth.TabIndex = 5;
			this.txtImageWidth.TextChanged += new System.EventHandler(this.txtImageWidth_TextChanged);
			// 
			// lblImageSize
			// 
			this.lblImageSize.AutoSize = true;
			this.lblImageSize.Location = new System.Drawing.Point(9, 48);
			this.lblImageSize.Name = "lblImageSize";
			this.lblImageSize.Size = new System.Drawing.Size(62, 13);
			this.lblImageSize.TabIndex = 4;
			this.lblImageSize.Text = "Image Size:";
			// 
			// txtThreads
			// 
			this.txtThreads.Location = new System.Drawing.Point(253, 19);
			this.txtThreads.Name = "txtThreads";
			this.txtThreads.Size = new System.Drawing.Size(54, 20);
			this.txtThreads.TabIndex = 3;
			// 
			// lblThreads
			// 
			this.lblThreads.AutoSize = true;
			this.lblThreads.Location = new System.Drawing.Point(198, 22);
			this.lblThreads.Name = "lblThreads";
			this.lblThreads.Size = new System.Drawing.Size(49, 13);
			this.lblThreads.TabIndex = 2;
			this.lblThreads.Text = "Threads:";
			// 
			// txtMaxIterations
			// 
			this.txtMaxIterations.Location = new System.Drawing.Point(92, 19);
			this.txtMaxIterations.Name = "txtMaxIterations";
			this.txtMaxIterations.Size = new System.Drawing.Size(100, 20);
			this.txtMaxIterations.TabIndex = 1;
			// 
			// lblMaxIterations
			// 
			this.lblMaxIterations.AutoSize = true;
			this.lblMaxIterations.Location = new System.Drawing.Point(9, 22);
			this.lblMaxIterations.Name = "lblMaxIterations";
			this.lblMaxIterations.Size = new System.Drawing.Size(79, 13);
			this.lblMaxIterations.TabIndex = 0;
			this.lblMaxIterations.Text = "Max. Iterations:";
			// 
			// grpPath
			// 
			this.grpPath.Controls.Add(this.btnBrowse);
			this.grpPath.Controls.Add(this.txtPath);
			this.grpPath.Location = new System.Drawing.Point(12, 165);
			this.grpPath.Name = "grpPath";
			this.grpPath.Size = new System.Drawing.Size(316, 50);
			this.grpPath.TabIndex = 2;
			this.grpPath.TabStop = false;
			this.grpPath.Text = "Path";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(280, 18);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(27, 20);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.Location = new System.Drawing.Point(12, 19);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(262, 20);
			this.txtPath.TabIndex = 0;
			// 
			// btnRenderFractal
			// 
			this.btnRenderFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRenderFractal.Location = new System.Drawing.Point(142, 305);
			this.btnRenderFractal.Name = "btnRenderFractal";
			this.btnRenderFractal.Size = new System.Drawing.Size(124, 23);
			this.btnRenderFractal.TabIndex = 3;
			this.btnRenderFractal.Text = "Render Fractal";
			this.btnRenderFractal.UseVisualStyleBackColor = true;
			this.btnRenderFractal.Click += new System.EventHandler(this.btnRenderFractal_Click);
			// 
			// btnCalculateFractal
			// 
			this.btnCalculateFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCalculateFractal.Location = new System.Drawing.Point(12, 305);
			this.btnCalculateFractal.Name = "btnCalculateFractal";
			this.btnCalculateFractal.Size = new System.Drawing.Size(124, 23);
			this.btnCalculateFractal.TabIndex = 4;
			this.btnCalculateFractal.Text = "Calculate Fractal";
			this.btnCalculateFractal.UseVisualStyleBackColor = true;
			this.btnCalculateFractal.Click += new System.EventHandler(this.btnCalculateFractal_Click);
			// 
			// btnCustomColours
			// 
			this.btnCustomColours.Location = new System.Drawing.Point(6, 19);
			this.btnCustomColours.Name = "btnCustomColours";
			this.btnCustomColours.Size = new System.Drawing.Size(75, 23);
			this.btnCustomColours.TabIndex = 5;
			this.btnCustomColours.Text = "Custom";
			this.btnCustomColours.UseVisualStyleBackColor = true;
			this.btnCustomColours.Click += new System.EventHandler(this.btnCustomColours_Click);
			// 
			// grpColours
			// 
			this.grpColours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpColours.Controls.Add(this.label1);
			this.grpColours.Controls.Add(this.nudColourShift);
			this.grpColours.Controls.Add(this.pnlSpectrum);
			this.grpColours.Controls.Add(this.btnRandomColours);
			this.grpColours.Controls.Add(this.btnCustomColours);
			this.grpColours.Location = new System.Drawing.Point(12, 221);
			this.grpColours.Name = "grpColours";
			this.grpColours.Size = new System.Drawing.Size(316, 78);
			this.grpColours.TabIndex = 6;
			this.grpColours.TabStop = false;
			this.grpColours.Text = "Colours";
			// 
			// pnlSpectrum
			// 
			this.pnlSpectrum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSpectrum.Location = new System.Drawing.Point(168, 19);
			this.pnlSpectrum.Name = "pnlSpectrum";
			this.pnlSpectrum.Size = new System.Drawing.Size(139, 23);
			this.pnlSpectrum.TabIndex = 7;
			this.pnlSpectrum.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSpectrum_Paint);
			// 
			// btnRandomColours
			// 
			this.btnRandomColours.Location = new System.Drawing.Point(87, 19);
			this.btnRandomColours.Name = "btnRandomColours";
			this.btnRandomColours.Size = new System.Drawing.Size(75, 23);
			this.btnRandomColours.TabIndex = 6;
			this.btnRandomColours.Text = "Random";
			this.btnRandomColours.UseVisualStyleBackColor = true;
			this.btnRandomColours.Click += new System.EventHandler(this.btnRandomColours_Click);
			// 
			// nudColourShift
			// 
			this.nudColourShift.Location = new System.Drawing.Point(94, 48);
			this.nudColourShift.Name = "nudColourShift";
			this.nudColourShift.Size = new System.Drawing.Size(75, 20);
			this.nudColourShift.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Colour Shift (%)";
			// 
			// HighResForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 340);
			this.Controls.Add(this.grpColours);
			this.Controls.Add(this.btnCalculateFractal);
			this.Controls.Add(this.btnRenderFractal);
			this.Controls.Add(this.grpPath);
			this.Controls.Add(this.grpAppearance);
			this.Controls.Add(this.grpLocation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HighResForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "High Res.";
			this.grpLocation.ResumeLayout(false);
			this.grpLocation.PerformLayout();
			this.grpAppearance.ResumeLayout(false);
			this.grpAppearance.PerformLayout();
			this.grpPath.ResumeLayout(false);
			this.grpPath.PerformLayout();
			this.grpColours.ResumeLayout(false);
			this.grpColours.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudColourShift)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpLocation;
		private System.Windows.Forms.Label lblBottom;
		private System.Windows.Forms.Label lblRight;
		private System.Windows.Forms.Label lblTop;
		private System.Windows.Forms.Label lblLeft;
		private System.Windows.Forms.GroupBox grpAppearance;
		private System.Windows.Forms.Label lblMaxIterations;
		private System.Windows.Forms.TextBox txtMaxIterations;
		private System.Windows.Forms.TextBox txtThreads;
		private System.Windows.Forms.Label lblThreads;
		private System.Windows.Forms.Label lblImageHeight;
		private System.Windows.Forms.TextBox txtImageWidth;
		private System.Windows.Forms.Label lblImageSize;
		private System.Windows.Forms.GroupBox grpPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnRenderFractal;
		private System.Windows.Forms.Button btnCalculateFractal;
		private System.Windows.Forms.Button btnCustomColours;
		private System.Windows.Forms.GroupBox grpColours;
		private System.Windows.Forms.Button btnRandomColours;
		private System.Windows.Forms.Panel pnlSpectrum;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudColourShift;
	}
}
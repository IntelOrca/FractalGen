namespace FractalGen
{
	partial class ColourSchemeForm
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
			this.btnRandom = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.nudRandomColours = new System.Windows.Forms.NumericUpDown();
			this.pnlSpectrum = new System.Windows.Forms.Panel();
			this.lblNumColours = new System.Windows.Forms.Label();
			this.btnAddColour = new System.Windows.Forms.Button();
			this.btnRemoveLastColour = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pnlSelectedColours = new System.Windows.Forms.Panel();
			this.nudTransition = new System.Windows.Forms.NumericUpDown();
			this.lblTransition = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudRandomColours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTransition)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRandom
			// 
			this.btnRandom.Location = new System.Drawing.Point(12, 18);
			this.btnRandom.Name = "btnRandom";
			this.btnRandom.Size = new System.Drawing.Size(94, 23);
			this.btnRandom.TabIndex = 1;
			this.btnRandom.Text = "Random";
			this.btnRandom.UseVisualStyleBackColor = true;
			this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(12, 47);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(137, 23);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// nudRandomColours
			// 
			this.nudRandomColours.Location = new System.Drawing.Point(112, 21);
			this.nudRandomColours.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.nudRandomColours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudRandomColours.Name = "nudRandomColours";
			this.nudRandomColours.Size = new System.Drawing.Size(37, 20);
			this.nudRandomColours.TabIndex = 3;
			this.nudRandomColours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// pnlSpectrum
			// 
			this.pnlSpectrum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSpectrum.Location = new System.Drawing.Point(155, 18);
			this.pnlSpectrum.Name = "pnlSpectrum";
			this.pnlSpectrum.Size = new System.Drawing.Size(200, 200);
			this.pnlSpectrum.TabIndex = 0;
			this.pnlSpectrum.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSpectrum_Paint);
			// 
			// lblNumColours
			// 
			this.lblNumColours.AutoSize = true;
			this.lblNumColours.Location = new System.Drawing.Point(152, 228);
			this.lblNumColours.Name = "lblNumColours";
			this.lblNumColours.Size = new System.Drawing.Size(54, 13);
			this.lblNumColours.TabIndex = 4;
			this.lblNumColours.Text = "Colours: 0";
			// 
			// btnAddColour
			// 
			this.btnAddColour.Enabled = false;
			this.btnAddColour.Location = new System.Drawing.Point(12, 76);
			this.btnAddColour.Name = "btnAddColour";
			this.btnAddColour.Size = new System.Drawing.Size(137, 23);
			this.btnAddColour.TabIndex = 5;
			this.btnAddColour.Text = "Add Colour";
			this.btnAddColour.UseVisualStyleBackColor = true;
			this.btnAddColour.Click += new System.EventHandler(this.btnAddColour_Click);
			// 
			// btnRemoveLastColour
			// 
			this.btnRemoveLastColour.Enabled = false;
			this.btnRemoveLastColour.Location = new System.Drawing.Point(12, 105);
			this.btnRemoveLastColour.Name = "btnRemoveLastColour";
			this.btnRemoveLastColour.Size = new System.Drawing.Size(137, 23);
			this.btnRemoveLastColour.TabIndex = 6;
			this.btnRemoveLastColour.Text = "Remove Last Colour";
			this.btnRemoveLastColour.UseVisualStyleBackColor = true;
			this.btnRemoveLastColour.Click += new System.EventHandler(this.btnRemoveLastColour_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(280, 267);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(199, 267);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pnlSelectedColours
			// 
			this.pnlSelectedColours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectedColours.Location = new System.Drawing.Point(12, 133);
			this.pnlSelectedColours.Name = "pnlSelectedColours";
			this.pnlSelectedColours.Size = new System.Drawing.Size(137, 137);
			this.pnlSelectedColours.TabIndex = 9;
			this.pnlSelectedColours.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSelectedColours_Paint);
			// 
			// nudTransition
			// 
			this.nudTransition.Location = new System.Drawing.Point(298, 224);
			this.nudTransition.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this.nudTransition.Name = "nudTransition";
			this.nudTransition.Size = new System.Drawing.Size(57, 20);
			this.nudTransition.TabIndex = 10;
			this.nudTransition.ValueChanged += new System.EventHandler(this.nudTransition_ValueChanged);
			// 
			// lblTransition
			// 
			this.lblTransition.AutoSize = true;
			this.lblTransition.Location = new System.Drawing.Point(236, 227);
			this.lblTransition.Name = "lblTransition";
			this.lblTransition.Size = new System.Drawing.Size(56, 13);
			this.lblTransition.TabIndex = 11;
			this.lblTransition.Text = "Transition:";
			// 
			// ColourSchemeForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(367, 302);
			this.Controls.Add(this.lblTransition);
			this.Controls.Add(this.nudTransition);
			this.Controls.Add(this.pnlSelectedColours);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnRemoveLastColour);
			this.Controls.Add(this.btnAddColour);
			this.Controls.Add(this.lblNumColours);
			this.Controls.Add(this.nudRandomColours);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnRandom);
			this.Controls.Add(this.pnlSpectrum);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ColourSchemeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Colour Scheme";
			((System.ComponentModel.ISupportInitialize)(this.nudRandomColours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudTransition)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRandom;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.NumericUpDown nudRandomColours;
		private System.Windows.Forms.Panel pnlSpectrum;
		private System.Windows.Forms.Label lblNumColours;
		private System.Windows.Forms.Button btnAddColour;
		private System.Windows.Forms.Button btnRemoveLastColour;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel pnlSelectedColours;
		private System.Windows.Forms.NumericUpDown nudTransition;
		private System.Windows.Forms.Label lblTransition;
	}
}
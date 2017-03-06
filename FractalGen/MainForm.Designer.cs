namespace FractalGen
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.pnlFractal = new System.Windows.Forms.Panel();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.progressToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.iterationsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.testToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fractalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highResolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savedLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.appearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iterationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.smoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.repeatColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.coloursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.randomColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutFractalGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
			this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlFractal
			// 
			this.pnlFractal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pnlFractal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlFractal.Location = new System.Drawing.Point(0, 0);
			this.pnlFractal.Name = "pnlFractal";
			this.pnlFractal.Size = new System.Drawing.Size(459, 418);
			this.pnlFractal.TabIndex = 1;
			this.pnlFractal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFractal_MouseDown);
			this.pnlFractal.Resize += new System.EventHandler(this.pnlFractal_Resize);
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlFractal);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(459, 418);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(459, 464);
			this.toolStripContainer1.TabIndex = 3;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressToolStripProgressBar,
            this.iterationsToolStripStatusLabel,
            this.testToolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(459, 22);
			this.statusStrip.TabIndex = 3;
			this.statusStrip.Text = "statusStrip";
			// 
			// progressToolStripProgressBar
			// 
			this.progressToolStripProgressBar.Name = "progressToolStripProgressBar";
			this.progressToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
			// 
			// iterationsToolStripStatusLabel
			// 
			this.iterationsToolStripStatusLabel.Name = "iterationsToolStripStatusLabel";
			this.iterationsToolStripStatusLabel.Size = new System.Drawing.Size(64, 17);
			this.iterationsToolStripStatusLabel.Text = "{iterations}";
			// 
			// testToolStripStatusLabel
			// 
			this.testToolStripStatusLabel.Name = "testToolStripStatusLabel";
			this.testToolStripStatusLabel.Size = new System.Drawing.Size(278, 17);
			this.testToolStripStatusLabel.Spring = true;
			this.testToolStripStatusLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.testToolStripStatusLabel_MouseDown);
			this.testToolStripStatusLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.testToolStripStatusLabel_MouseMove);
			this.testToolStripStatusLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.testToolStripStatusLabel_Paint);
			// 
			// menuStrip
			// 
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fractalToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.appearanceToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(459, 24);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip";
			// 
			// fractalToolStripMenuItem
			// 
			this.fractalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConfigToolStripMenuItem,
            this.highResolutionToolStripMenuItem,
            this.toolStripSeparator2,
            this.copyToClipboardToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
			this.fractalToolStripMenuItem.Name = "fractalToolStripMenuItem";
			this.fractalToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.fractalToolStripMenuItem.Text = "Fractal";
			// 
			// saveConfigToolStripMenuItem
			// 
			this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
			this.saveConfigToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.saveConfigToolStripMenuItem.Text = "Save config...";
			this.saveConfigToolStripMenuItem.Click += new System.EventHandler(this.saveConfigToolStripMenuItem_Click);
			// 
			// highResolutionToolStripMenuItem
			// 
			this.highResolutionToolStripMenuItem.Name = "highResolutionToolStripMenuItem";
			this.highResolutionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.highResolutionToolStripMenuItem.Text = "High Resolution...";
			this.highResolutionToolStripMenuItem.Click += new System.EventHandler(this.highResolutionToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// locationToolStripMenuItem
			// 
			this.locationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savedLocationsToolStripMenuItem,
            this.saveLocationToolStripMenuItem,
            this.toolStripSeparator3,
            this.resetToolStripMenuItem});
			this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
			this.locationToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.locationToolStripMenuItem.Text = "Location";
			// 
			// savedLocationsToolStripMenuItem
			// 
			this.savedLocationsToolStripMenuItem.Name = "savedLocationsToolStripMenuItem";
			this.savedLocationsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.savedLocationsToolStripMenuItem.Text = "Saved Locations";
			// 
			// saveLocationToolStripMenuItem
			// 
			this.saveLocationToolStripMenuItem.Name = "saveLocationToolStripMenuItem";
			this.saveLocationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.saveLocationToolStripMenuItem.Text = "Save Location";
			this.saveLocationToolStripMenuItem.Click += new System.EventHandler(this.saveLocationToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(156, 6);
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			this.resetToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.resetToolStripMenuItem.Text = "Reset";
			this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
			// 
			// appearanceToolStripMenuItem
			// 
			this.appearanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iterationsToolStripMenuItem,
            this.smoothToolStripMenuItem,
            this.repeatColoursToolStripMenuItem,
            this.setColoursToolStripMenuItem,
            this.coloursToolStripMenuItem,
            this.randomColoursToolStripMenuItem});
			this.appearanceToolStripMenuItem.Name = "appearanceToolStripMenuItem";
			this.appearanceToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.appearanceToolStripMenuItem.Text = "Appearance";
			// 
			// iterationsToolStripMenuItem
			// 
			this.iterationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lessToolStripMenuItem,
            this.moreToolStripMenuItem,
            this.toolStripSeparator1,
            this.customToolStripMenuItem});
			this.iterationsToolStripMenuItem.Name = "iterationsToolStripMenuItem";
			this.iterationsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.iterationsToolStripMenuItem.Text = "Iterations";
			// 
			// lessToolStripMenuItem
			// 
			this.lessToolStripMenuItem.Name = "lessToolStripMenuItem";
			this.lessToolStripMenuItem.ShortcutKeyDisplayString = "-";
			this.lessToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.lessToolStripMenuItem.Text = "Less";
			this.lessToolStripMenuItem.Click += new System.EventHandler(this.lessToolStripMenuItem_Click);
			// 
			// moreToolStripMenuItem
			// 
			this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
			this.moreToolStripMenuItem.ShortcutKeyDisplayString = "+";
			this.moreToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.moreToolStripMenuItem.Text = "More";
			this.moreToolStripMenuItem.Click += new System.EventHandler(this.moreToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
			// 
			// customToolStripMenuItem
			// 
			this.customToolStripMenuItem.Name = "customToolStripMenuItem";
			this.customToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.customToolStripMenuItem.Text = "Custom...";
			this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
			// 
			// smoothToolStripMenuItem
			// 
			this.smoothToolStripMenuItem.Checked = true;
			this.smoothToolStripMenuItem.CheckOnClick = true;
			this.smoothToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
			this.smoothToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.smoothToolStripMenuItem.Text = "Smooth";
			this.smoothToolStripMenuItem.Click += new System.EventHandler(this.smoothToolStripMenuItem_Click);
			// 
			// repeatColoursToolStripMenuItem
			// 
			this.repeatColoursToolStripMenuItem.CheckOnClick = true;
			this.repeatColoursToolStripMenuItem.Name = "repeatColoursToolStripMenuItem";
			this.repeatColoursToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.repeatColoursToolStripMenuItem.Text = "Repeat Colours";
			this.repeatColoursToolStripMenuItem.Click += new System.EventHandler(this.repeatColoursToolStripMenuItem_Click);
			// 
			// setColoursToolStripMenuItem
			// 
			this.setColoursToolStripMenuItem.Name = "setColoursToolStripMenuItem";
			this.setColoursToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.setColoursToolStripMenuItem.Text = "Set Colours...";
			this.setColoursToolStripMenuItem.Click += new System.EventHandler(this.setColoursToolStripMenuItem_Click);
			// 
			// coloursToolStripMenuItem
			// 
			this.coloursToolStripMenuItem.Name = "coloursToolStripMenuItem";
			this.coloursToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.coloursToolStripMenuItem.Text = "Colours";
			// 
			// randomColoursToolStripMenuItem
			// 
			this.randomColoursToolStripMenuItem.Name = "randomColoursToolStripMenuItem";
			this.randomColoursToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.randomColoursToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.randomColoursToolStripMenuItem.Text = "Random Colours";
			this.randomColoursToolStripMenuItem.Click += new System.EventHandler(this.randomColoursToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutFractalGenToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutFractalGenToolStripMenuItem
			// 
			this.aboutFractalGenToolStripMenuItem.Name = "aboutFractalGenToolStripMenuItem";
			this.aboutFractalGenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.aboutFractalGenToolStripMenuItem.Text = "About FractalGen...";
			// 
			// tmrUpdate
			// 
			this.tmrUpdate.Enabled = true;
			this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
			// 
			// copyToClipboardToolStripMenuItem
			// 
			this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
			this.copyToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.copyToClipboardToolStripMenuItem.Text = "Copy to clipboard";
			this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 464);
			this.Controls.Add(this.toolStripContainer1);
			this.DoubleBuffered = true;
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FractalGen";
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlFractal;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel iterationsToolStripStatusLabel;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fractalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveConfigToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem appearanceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iterationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lessToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem smoothToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem repeatColoursToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setColoursToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem coloursToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutFractalGenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem savedLocationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveLocationToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripStatusLabel testToolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem randomColoursToolStripMenuItem;
		private System.Windows.Forms.ToolStripProgressBar progressToolStripProgressBar;
		private System.Windows.Forms.Timer tmrUpdate;
		private System.Windows.Forms.ToolStripMenuItem highResolutionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

	}
}


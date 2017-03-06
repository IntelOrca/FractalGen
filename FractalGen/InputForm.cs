using System;
using System.Drawing;
using System.Windows.Forms;

namespace FractalGen
{
	class InputForm : Form
	{
		TextBox txtInput;

		public InputForm(string title, string caption, string defaultText)
		{
			Text = title;
			ShowIcon = false;
			Size = new Size(251, 141);
			StartPosition = FormStartPosition.CenterScreen;
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			MaximizeBox = false;
			ControlBox = false;

			Label lblCaption = new Label();
			lblCaption.Name = "lblCaption";
			lblCaption.Location = new Point(12, 9);
			lblCaption.Text = caption;
			lblCaption.AutoSize = true;

			txtInput = new TextBox();
			txtInput.Name = "txtInput";
			txtInput.Location = new Point(15, 41);
			txtInput.Size = new Size(205, 20);
			txtInput.Text = defaultText;
			txtInput.Select(txtInput.TextLength, 0);
			txtInput.Focus();

			Button btnOK = new Button();
			btnOK.Name = "btnOK";
			btnOK.Location = new Point(145, 70);
			btnOK.Size = new Size(75, 23);
			btnOK.Text = "OK";
			btnOK.Click += new EventHandler(btnOK_Click);

			Button btnCancel = new Button();
			btnCancel.Name = "btnCancel";
			btnCancel.Location = new Point(64, 70);
			btnCancel.Size = new Size(75, 23);
			btnCancel.Text = "Cancel";
			btnCancel.Click += new EventHandler(btnCancel_Click);

			AcceptButton = btnOK;
			CancelButton = btnCancel;

			Controls.Add(lblCaption);
			Controls.Add(txtInput);
			Controls.Add(btnOK);
			Controls.Add(btnCancel);
		}

		void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		public string InputText
		{
			get
			{
				return txtInput.Text;
			}
		}

		public static string Show(string title, string caption, string defaultText)
		{
			InputForm frm = new InputForm(title, caption, defaultText);
			if (frm.ShowDialog() == DialogResult.OK) {
				return frm.InputText;
			} else {
				return defaultText;
			}
		}
	}
}

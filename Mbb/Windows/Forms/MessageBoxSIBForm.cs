using System;
using System.Drawing;

namespace Mbb.Windows.Forms
{
	public partial class MessageBoxSIBForm : Form
	{
		#region Properties
		public string Caption
		{
			get
			{
				return captionLabel.Text;
			}
			set
			{
				captionLabel.Text = value;
			}
		}
		public new System.Drawing.Image Icon
		{
			get
			{
				return iconPicturBox.Image;
			}
			set
			{
				iconPicturBox.Image = value;
			}
		}
		private string message;
		public string Message
		{
			get
			{
				return messageLabel.Text;
			}
			set
			{
				messageLabel.Text = value;
			}
		}	
		public System.Drawing.Color OKBackColor
		{
			get
			{
				return okButton.BackColor;
			}
			set
			{
				okButton.BackColor = value;
			}
		}
		public string OKName
		{
			get
			{
				return okButton.Name;
			}
			set
			{
				okButton.Name = value;
			}
		}
		#endregion /Properties

		public MessageBoxSIBForm()
		{
			InitializeComponent();
		}

		//----------Beginning of the code!----------

		#region MessageBoxSIBForm_Load
		private void MessageBoxSIBForm_Load(object sender, EventArgs e)
		{
			message = messageLabel.Text;

			using (Graphics g = CreateGraphics())
			{
				SizeF size = g.MeasureString(message, messageLabel.Font, messageLabel.Width);
				messageLabel.Height = (int)Math.Ceiling(size.Height);
				messageLabel.Text = message;
			}
			this.Height = messageLabel.Height + 110;
		}
		#endregion /MessageBoxSIBForm_Load
	}
}

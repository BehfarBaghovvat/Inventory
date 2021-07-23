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
			showFormAnimateWindow.Start();
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

		#region OkButton_Click
		private void OkButton_Click(object sender, EventArgs e)
		{
			closeFormTimer.Start();
		}
		#endregion /OkButton_Click

		#region CloseFormTimer_Tick
		private void CloseFormTimer_Tick(object sender, EventArgs e)
		{
			this.Opacity -= 0.1;

			if (this.Opacity <= 0.0)
			{
				closeFormTimer.Stop();
				this.Dispose();
			}
		}


		#endregion /CloseFormTimer_Tick	

		#region ShowFaideTimer_Tick
		private void ShowFaideTimer_Tick(object sender, EventArgs e)
		{

		}
		#endregion /ShowFaideTimer_Tick
	}
}

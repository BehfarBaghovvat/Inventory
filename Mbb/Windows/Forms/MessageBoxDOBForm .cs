namespace Mbb.Windows.Forms
{
	public partial class MessageBoxDOBForm : Form
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
		public System.Drawing.Color YesBackColor
		{
			get
			{
				return yesButton.BackColor;
			}
			set
			{
				yesButton.BackColor = value;
			}
		}
		public string YesName
		{
			get
			{
				return yesButton.Text;
			}
			set
			{
				yesButton.Text = value;
			}
		}
		public System.Drawing.Color NoBackColor
		{
			get
			{
				return noButton.BackColor;
			}
			set
			{
				noButton.BackColor = value;
			}
		}
		public string NoName
		{
			get
			{
				return noButton.Text;
			}
			set
			{
				noButton.Text = value;
			}

		}
		#endregion /Properties

		public MessageBoxDOBForm()
		{
			InitializeComponent();

			showFormAnimateWindow.Start();
		}

		//----------Beginning of the code!----------

		#region MessageBoxDOBForm_Load
		private void MessageBoxDOBForm_Load(object sender, System.EventArgs e)
		{
			message = messageLabel.Text;

			using (System.Drawing.Graphics g = CreateGraphics())
			{
				System.Drawing.SizeF size = g.MeasureString(message, messageLabel.Font, messageLabel.Width);
				messageLabel.Height = (int)System.Math.Ceiling(size.Height);
				messageLabel.Text = message;
			}
			this.Height = messageLabel.Height + 110;
		}
		#endregion /MessageBoxDOBForm_Load

		#region NoButton_Click
		private void NoButton_Click(object sender, System.EventArgs e)
		{
			closeFormTimer.Start();
		}
		#endregion /NoButton_Click

		#region YesButton_Click
		private void YesButton_Click(object sender, System.EventArgs e)
		{
			closeFormTimer.Start();
		}
		#endregion /YesButton_Click

		#region CloseFormTimer_Tick
		private void CloseFormTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.1;

			if (this.Opacity <= 0.0)
			{
				closeFormTimer.Stop();
				this.Dispose();
			}
		}
		#endregion /CloseFormTimer_Tick
	}
}



namespace Mbb.Windows.Forms
{
	public partial class MessageBoxSIBForm : Form
	{
		#region Properties

		private int x, y;
		private enum Action
		{
			Show,
			Dispose,
		}

		private Action action;

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
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		}

		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


		//----------Beginning of the code!----------

		#region MessageBoxSIBForm_Load
		private void MessageBoxSIBForm_Load(object sender, System.EventArgs e)
		{
			action = Action.Show;
			this.Opacity = 0.0;
			SetCenterScreen();
			fadeTimer.Start();

			message = messageLabel.Text;

			using (System.Drawing.Graphics g = CreateGraphics())
			{
				System.Drawing.SizeF size = g.MeasureString(message, messageLabel.Font, messageLabel.Width);
				messageLabel.Height = (int)System.Math.Ceiling(size.Height);
				messageLabel.Text = message;
			}
			this.Height = messageLabel.Height + 110;
		}
		#endregion /MessageBoxSIBForm_Load

		#region OkButton_Click
		private void OkButton_Click(object sender, System.EventArgs e)
		{
			action = Action.Dispose;

			fadeTimer.Start();
		}
		#endregion /OkButton_Click

		#region FadeTimer_Tick
		private void FadeTimer_Tick(object sender, System.EventArgs e)
		{
			Fade(fadeTimer, action);
		}
		#endregion /FadeTimer_Tick

		#region Fade
		private void Fade(System.Windows.Forms.Timer timer, Action _action)
		{
			timer.Interval = 1;

			switch (_action)
			{
				case Action.Show:
					this.Opacity += 0.055;
					if (this.Location.X > x)
					{
						//this.Location = new System.Drawing.Point(x: this.Location.X - 16, y);
						this.Left -= 20;
					}
					else
					{
						action = Action.Dispose;
						timer.Stop();

					}
					break;
				case Action.Dispose:
					this.Opacity -= 0.05;
					if (this.Location.X > x - 450)
					{
						//this.Location = new System.Drawing.Point(x: this.Location.X - 16, y);
						this.Left += 5;

					}
					else
					{
						timer.Stop();
						this.Dispose();
					}
					break;
				default:
					break;
			}
		}
		#endregion /Fade

		#region SetCenterScreen
		private void SetCenterScreen()
		{
			x = this.Location.X;
			y = this.Location.Y;
			this.Location = new System.Drawing.Point(x: x + 250, y: y);
		}
		
		#endregion /SetCenterScreen

		#region CaptionLabel_MouseDown
		private void CaptionLabel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /CaptionLabel_MouseDown

		#region MessageLabel_MouseDown
		private void MessageLabel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /MessageLabel_MouseDown
	}
}
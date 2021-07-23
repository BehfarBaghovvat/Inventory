namespace Mbb.Windows.Forms
{
	public partial class PopupNotificationWindows : Form
	{

		#region Properties
		public enum Action
		{
			wait,
			start,
			close,
		}
		public enum Caption
		{
			موفقیت,
			اخطار,
			خطا,
			اطلاع,
		}
		private Action action;
		private int x, y;
		#endregion /Properties


		public PopupNotificationWindows()
		{
			InitializeComponent();
		}

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			action = Action.close;
			fadeTimer.Start();
		}
		#endregion /CloseButton_Click

		#region FadeTimer_Tick
		private void FadeTimer_Tick(object sender, System.EventArgs e)
		{
			switch (this.action)
			{
				case Action.wait:
					fadeTimer.Interval = 5000;
					action = Action.close;
					break;

				case Action.start:
					fadeTimer.Interval = 1;
					Opacity += 0.1;
					if (x < Location.X)
					{
						Left--;
					}
					else
					{
						if (Opacity == 1.0)
						{
							action = Action.wait;
						}
					}
					break;

				case Action.close:
					fadeTimer.Interval = 1;
					Opacity -= 0.1;
					Left -= 3;

					if (Opacity == 0.0)
					{
						base.Close();
					}
					break;
			}
		}
		#endregion /FadeTimer_Tick

		#region Method
		//================

		#region ShowAlert
		/// <summary>
		/// A function that displays a notification with three message inputs, caption, and photos.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		/// <param name="picture"></param>
		public void ShowAlert(string message, Caption caption, string picture)
		{
			objectPictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
			objectPictureBox.BordrSize = 2;
			objectPictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
			this.Opacity = 0.0;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;

			string name;

			for (int i = 1; i < 10; i++)
			{
				name = "alert" + i.ToString();

				PopupNotificationWindows popupNotification = (PopupNotificationWindows)System.Windows.Forms.Application.OpenForms[name];

				if (popupNotification == null)
				{
					this.Name = name;
					this.x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
					this.y = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
					this.Location = new System.Drawing.Point(this.x, this.y);
					break;
				}
			}

			this.x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

			switch (caption)
			{
				case Caption.موفقیت:
					notificationStatusPicturBox.Image = Properties.Resources.succes_512;
					BackColor = System.Drawing.Color.SeaGreen;
					break;

				case Caption.اخطار:
					notificationStatusPicturBox.Image = Properties.Resources.warning_512;
					BackColor = System.Drawing.Color.DarkOrange;
					break;

				case Caption.خطا:
					notificationStatusPicturBox.Image = Properties.Resources.error_512;
					BackColor = System.Drawing.Color.DarkRed;
					break;

				case Caption.اطلاع:
					notificationStatusPicturBox.Image = Properties.Resources.info_512;
					BackColor = System.Drawing.Color.RoyalBlue;
					break;
			}
			this.objectPictureBox.Image = System.Drawing.Image.FromFile(picture);
			this.messageLabel.Text = message;

			this.Show();
			this.action = Action.start;
			this.fadeTimer.Interval = 1;
			this.fadeTimer.Start();
		}
		#endregion /ShowAlert

		#region ShowAlert
		/// <summary>
		/// A function that displays a notification with three message inputs, caption, and photos.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		/// <param name="picture"></param>
		public void ShowAlert(string message, Caption caption, byte[] picture)
		{
			objectPictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
			objectPictureBox.BordrSize = 2;
			objectPictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
			this.Opacity = 0.0;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;

			string name;

			for (int i = 1; i < 10; i++)
			{
				name = "alert" + i.ToString();

				PopupNotificationWindows popupNotification = (PopupNotificationWindows)System.Windows.Forms.Application.OpenForms[name];

				if (popupNotification == null)
				{
					this.Name = name;
					this.x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
					this.y = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
					this.Location = new System.Drawing.Point(this.x, this.y);
					break;
				}
			}

			this.x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

			switch (caption)
			{
				case Caption.موفقیت:
					notificationStatusPicturBox.Image = Properties.Resources.succes_512;
					BackColor = System.Drawing.Color.SeaGreen;
					break;

				case Caption.اخطار:
					notificationStatusPicturBox.Image = Properties.Resources.warning_512;
					BackColor = System.Drawing.Color.DarkOrange;
					break;

				case Caption.خطا:
					notificationStatusPicturBox.Image = Properties.Resources.error_512;
					BackColor = System.Drawing.Color.DarkRed;
					break;

				case Caption.اطلاع:
					notificationStatusPicturBox.Image = Properties.Resources.info_512;
					BackColor = System.Drawing.Color.RoyalBlue;
					break;
			}

			using (System.IO.MemoryStream ms = new System.IO.MemoryStream(picture))
			{
				this.objectPictureBox.Image = System.Drawing.Image.FromStream(ms);
			}
			this.messageLabel.Text = message;

			this.Show();
			this.action = Action.start;
			this.fadeTimer.Interval = 1;
			this.fadeTimer.Start();
		}
		#endregion /ShowAlert

		#region ShowAlert
		/// <summary>
		/// A function that displays the message and caption of a notification with two descriptions.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		public void ShowAlert(string message, Caption caption)
		{
			objectPictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
			objectPictureBox.BordrSize = 0;
			objectPictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
			this.Opacity = 0.0;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;

			string name;

			for (int i = 1; i < 10; i++)
			{
				name = "alert" + i.ToString();

				PopupNotificationWindows popupNotification = (PopupNotificationWindows)System.Windows.Forms.Application.OpenForms[name];

				if (popupNotification == null)
				{
					this.Name = name;
					this.x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
					this.y = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
					this.Location = new System.Drawing.Point(this.x, this.y);
					break;
				}
			}

			this.x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

			switch (caption)
			{
				case Caption.موفقیت:
					notificationStatusPicturBox.Image = Properties.Resources.succes_512;
					BackColor = System.Drawing.Color.SeaGreen;
					break;

				case Caption.اخطار:
					notificationStatusPicturBox.Image = Properties.Resources.warning_512;
					BackColor = System.Drawing.Color.DarkOrange;
					break;

				case Caption.خطا:
					notificationStatusPicturBox.Image = Properties.Resources.error_512;
					BackColor = System.Drawing.Color.DarkRed;
					break;

				case Caption.اطلاع:
					notificationStatusPicturBox.Image = Properties.Resources.info_512;
					BackColor = System.Drawing.Color.RoyalBlue;
					break;
			}
			this.messageLabel.Text = message;

			this.Show();
			this.action = Action.start;
			this.fadeTimer.Interval = 1;
			this.fadeTimer.Start();
		}
		#endregion /ShowAlert
		//================
		#endregion /Method


	}
}

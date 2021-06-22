using System.Linq;

namespace StartPage
{
	public partial class LoginForm : Infrastructure.BaseForm
	{
		public int Hour { get; set; }
		public string LoginTime { get; private set; }
		public string LogOutTime { get; private set; }

		int[] targetColor = { 255, 215, 0 }; //Golden Color
		int[] fadeColor = new int[3];
		public LoginForm()
		{

			InitializeComponent();
			InputSettingsControls();
		}

		//-----Begining of codes!

		#region LoginForm_Load
		private void LoginForm_Load(object sender, System.EventArgs e)
		{
			messageBoxLabel.Text = DayDivision();

			this.Opacity = 0.0;
			fadeFormTimer.Start();
		}
		#endregion /LoginForm_Load

		#region UsernameTextBox_Enter
		private void UsernameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
		}
		#endregion /UsernameTextBox_Enter

		#region UsernameTextBox_KeyPress
		private void UsernameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /UsernameTextBox_KeyPress

		#region UsernameTextBox_TextChanged
		private void UsernameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
			{
				return;
			}
			else
			{
				//System.Windows.Forms.MessageBox.Show($"{usernameTextBox.Text}");

				Models.DataBaseContext dataBaseContext =
					new Models.DataBaseContext();

				if (ApprovalUsername(username: usernameTextBox.Text) == false)
				{
					Models.User foundedUser =
							GetUserByUsername(usernameTextBox.Text);

					GetImageByUser(null);
					return;
				}
				else
				{
					Models.User foundedUser =
							GetUserByUsername(usernameTextBox.Text);

					GetImageByUser(foundedUser);

					Models.User user =
						dataBaseContext.Users
						.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
						.FirstOrDefault();

					if (string.Compare(user.Password, passwordTextBox.Text, true) != 0)
					{
						return;
					}
					else if (string.Compare(user.Password, passwordTextBox.Text, true) == 0)
					{
						if (user.IsActive == false)
						{
							System.Windows.Forms.MessageBox.Show("User Locked", "error", buttons: System.Windows.Forms.MessageBoxButtons.OK, icon: System.Windows.Forms.MessageBoxIcon.Error);
							return;
						}
						else
						{
							this.Hide();
							Inventory.Program.AuthenticatedUser = user;
							SaveLoginHistory(user);

							WelcomeUserForm welComeUserForm =
								new WelcomeUserForm();

							welComeUserForm.Show();
							//Program.PrimeShow();
						}
					}
				}
			}
		}
		#endregion /UsernameTextBox_TextChanged

		#region PasswordTextBox_KeyPress
		private void PasswordTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			passwordTextBox.UseSystemPasswordChar = true;
		}
		#endregion /PasswordTextBox_KeyPress

		#region PasswordTextBox_TextChanged
		private void PasswordTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				return;
			}
			else
			{
				Models.DataBaseContext dataBaseContext =
					new Models.DataBaseContext();

				if (ApprovalUsername(username: usernameTextBox.Text) == false)
				{
					return;
				}
				else if (ApprovalUsername(username: usernameTextBox.Text) == true)
				{
					Models.User user =
						dataBaseContext.Users
						.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
						.FirstOrDefault();

					if (string.Compare(user.Password, passwordTextBox.Text, true) != 0)
					{
						return;
					}
					else if (string.Compare(user.Password, passwordTextBox.Text, true) == 0)
					{
						if (user.IsActive == false)
						{
							System.Windows.Forms.MessageBox.Show("User Locked", "error", buttons: System.Windows.Forms.MessageBoxButtons.OK, icon: System.Windows.Forms.MessageBoxIcon.Error);
							return;
						}
						else
						{
							this.Hide();
							Inventory.Program.AuthenticatedUser = user;
							SaveLoginHistory(user);

							WelcomeUserForm welComeUserForm =
								new WelcomeUserForm();

							welComeUserForm.Show();
							//Program.PrimeShow();
						}
					}
				}
			}
		}
		#endregion /PasswordTextBox_TextChanged





















		#region FadeFormTimer_Tick
		private void FadeFormTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity += 0.05;

			if (this.Opacity >= 0.9)
			{
				fadeFormTimer.Stop();
				fadeInMessageBoxLabelTimer.Start();
			}
		}
		#endregion /FadeFormTimer_Tick

		#region FadeInMessageBoxLabelTimer_Tick
		private void FadeInMessageBoxLabelTimer_Tick(object sender, System.EventArgs e)
		{
			FadeIn();
		}
		#endregion /FadeInMessageBoxLabelTimer_Tick

		//-----End of codes!

		#region Founctions

		#region ApprovalUsername
		private bool ApprovalUsername(string username)
		{
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
				new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Username, username, true) == 0)
				.FirstOrDefault();

			if (user != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion /ApprovalUsername

		#region DayDivision
		private string DayDivision()
		{
			Hour = System.DateTime.Now.Hour;
			string message = null;
			if (Hour >= 00 && Hour < 04)
			{
				message = "بامداد بخیر کاربر گرامی";
			}
			else if (Hour >= 04 && Hour < 10)
			{
				message = "صبح بخیر کاربر گرامی";
			}
			else if (Hour >= 10 && Hour < 12)
			{
				message = "روز بخیر کاربر گرامی";
			}
			else if (Hour >= 12 && Hour < 16)
			{
				message = "ظهر بخیر کاربر گرامی";
			}
			else if (Hour >= 16 && Hour < 19)
			{
				message = "عصر بخیر کاربر گرامی";
			}
			else if (Hour >= 19 && Hour < 00)
			{
				message = "شب بخیر کاربر گرامی";
			}

			return message;
		}
		#endregion /DayDivision

		#region InputSettingsControls
		private void InputSettingsControls()
		{
			userImagePicturBox.Location = new System.Drawing.Point(540, 20);
			userImagePicturBox.Size = new System.Drawing.Size(200, 200);
			usernameTextBox.Location = new System.Drawing.Point(515, 240);
			passwordTextBox.Location = new System.Drawing.Point(515, 295);
			messageBoxLabel.Location = new System.Drawing.Point(75, 200);
			messageBoxLabel.ForeColor = System.Drawing.Color.SlateBlue;
			userImagePicturBox.BorderRadius = 100;
		}
		#endregion /InputSettingsControls

		#region FadeIn
		private void FadeIn()
		{
			fadeColor[0] = messageBoxLabel.ForeColor.R;
			fadeColor[1] = messageBoxLabel.ForeColor.G;
			fadeColor[2] = messageBoxLabel.ForeColor.B;

			if (fadeColor[0] > targetColor[0])
				fadeColor[0]--;
			else if (fadeColor[0] < targetColor[0])
				fadeColor[0]++;
			if (fadeColor[1] > targetColor[1])
				fadeColor[1]--;
			else if (fadeColor[1] < targetColor[1])
				fadeColor[1]++;
			if (fadeColor[2] > targetColor[2])
				fadeColor[2]--;
			else if (fadeColor[2] < targetColor[2])
				fadeColor[2]++;

			if (fadeColor[0] == targetColor[0] && fadeColor[1] == targetColor[1] && fadeColor[2] == targetColor[2])
			{
				fadeInMessageBoxLabelTimer.Stop();
			}

			messageBoxLabel.ForeColor = System.Drawing.Color.FromArgb(fadeColor[0], fadeColor[1], fadeColor[2]);
		}






		#endregion /FadeIn

		#region GetImageByUser
		//----برای نشان دادن تصویر کاربر
		private void GetImageByUser(Models.User user)
		{
			if (user == null)
			{
				userImagePicturBox.Image = Inventory.Properties.Resources.new_user_1080_Light_Gray;
			}
			else
			{
				var byteImage = user.User_Image;
				using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
				{
					userImagePicturBox.Image = System.Drawing.Image.FromStream(ms);
				}
			}
		}
		#endregion /GetImageByUser

		#region GetUserByUsername
		//----- برای بررسی شناسه کاربری 
		private Models.User GetUserByUsername(string username)
		{

			Models.DataBaseContext dataBaseContext = null;

			dataBaseContext =
				new Models.DataBaseContext();
			Models.User users =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Username, username, true) == 0)
				.FirstOrDefault();

			if (users != null)
			{
				return users;
			}
			else
			{
				return null;
			}
		}
		#endregion /GetUserByUsername

		#region SaveLoginHistory
		private void SaveLoginHistory(Models.User user)
		{
			LoginTime = $"{Infrastructure.Utility.ShowTime()} - {Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";

			LogOutTime = $"-";

			string fullName;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				if (string.IsNullOrWhiteSpace(user.First_Name) && string.IsNullOrWhiteSpace(user.Last_Name))
				{
					fullName = "-";
				}
				else
				{
					fullName = $"{user.First_Name} {user.First_Name}";
				}

				dataBaseContext =
					new Models.DataBaseContext();
				Models.LogHistory logHistory =
					dataBaseContext.LogHistories
					.OrderBy(current => current.Login_Time)
					.FirstOrDefault();

				logHistory =
					new Models.LogHistory
					{
						Full_Name = fullName,
						Username = user.Username,
						Login_Time = LoginTime,
						Logout_Time = LogOutTime,
					};

				dataBaseContext.LogHistories.Add(logHistory);
				dataBaseContext.SaveChanges();

				Inventory.Program.AutenticatLogHistory = logHistory;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			if (dataBaseContext != null)
			{
				dataBaseContext.Dispose();
				dataBaseContext = null;
			}
		}


		#endregion /SaveLoginHistory

		#endregion /Founctions

		


	}
}

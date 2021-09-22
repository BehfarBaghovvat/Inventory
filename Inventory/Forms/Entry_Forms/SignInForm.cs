using System.Linq;

namespace Entry_Forms
{
	public partial class SingInForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties
		public string LoginTime { get; set; }
		public string LogoutTime { get; private set; }
		public string Username { get; set; }
		public string Password { get; set; }
		private Models.DataBaseContext dataBaseContext = new Models.DataBaseContext();
		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public SingInForm()
		{
			InitializeComponent();

			Initialize();
		}

		//-----------------------------------------------------------------------------------------------     Events Controls

		

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		#endregion /CloseButton_Click

		#region ShowPasswordPictureBox_MouseDown
		private void ShowPasswordPictureBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordTextBox.UseSystemPasswordChar = false;
			showPasswordPictureBox.Image =  Inventory.Properties.Resources.hide_512;
		}
		#endregion /ShowPasswordPictureBox_MouseDown

		#region ShowPasswordPictureBox_MouseUp
		private void ShowPasswordPictureBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordTextBox.UseSystemPasswordChar = true;
			showPasswordPictureBox.Image = Inventory.Properties.Resources.show_512;
		}
		#endregion /ShowPasswordPictureBox_MouseUp

		#region SingUpButton_Click
		private void SingUpButton_Click(object sender, System.EventArgs e)
		{
			fadeOutForSingUpTimer.Start();

		}
		#endregion /SingUpButton_Click

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

		#region UsernameTextBox_TextChange
		private void UsernameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
			{
				Username = null;
				return;
			}
			else
			{
				if (!ApprovalUsername(username: usernameTextBox.Text))
				{
					Models.User foundedUser =
							GetUserByUsername(usernameTextBox.Text);

					GetImageByUser(null);

					return;
				}
				else if (ApprovalUsername(usernameTextBox.Text))
				{
					Models.DataBaseContext dataBaseContext =
						new Models.DataBaseContext();

					Username = usernameTextBox.Text;

					Models.User foundeUser = GetUserByUsername(Username);

					GetImageByUser(foundeUser);

					Models.User user =
						dataBaseContext.Users
						.Where(current => string.Compare(current.Username,Username,true) == 0)
						.FirstOrDefault();
					if (string.Compare(user.Password,passwordTextBox.Text, true)==0)
					{
						if (!user.Is_Active)
						{
							Mbb.Windows.Forms.MessageBox.Show
								(text: "عدم دسترسی به حساب کاربری!",
								caption: "قفل حساب",
								icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
								button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
							return;
						}
						else
						{
							Inventory.Program.UserAuthentication = user;
							if (string.Compare(user.Username, "admin") == 0)
							{
								fadeOutSingInFormTimer.Start();
							}
							else
							{
								SaveLoginHistory(user);
								fadeOutSingInFormTimer.Start();
							}
						}
					}
					else
					{
						return;
					}
				}
			}
		}
		#endregion /UsernameTextBox_TextChange

		#region PasswordTextBox_TextChange
		private void PasswordTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				passwordTextBox.UseSystemPasswordChar = false;
				Password = null;
				return;
			}
			else
			{
				passwordTextBox.UseSystemPasswordChar = true;
				if (!ApprovalUsername(username: usernameTextBox.Text))
				{
					return;
				}
				else if (ApprovalUsername(username: usernameTextBox.Text))
				{
					Models.DataBaseContext dataBaseContext =
						new Models.DataBaseContext();

					Password = passwordTextBox.Text;

					Models.User user =
							dataBaseContext.Users
							.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
							.FirstOrDefault();

					if (string.Compare(user.Password, Password, true) != 0)
					{
						return;
					}
					else if (string.Compare(user.Password, Password, true) == 0)
					{
						if (!user.Is_Active)
						{
							Mbb.Windows.Forms.MessageBox.Show
								(text: "عدم دسترسی به حساب کاربری!",
								caption: "قفل حساب",
								icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
								button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

							return;
						}
						else
						{
							Inventory.Program.UserAuthentication = user;

							if (string.Compare(user.Username,"admin") == 0)
							{
								fadeOutSingInFormTimer.Start();
							}
							else
							{
								SaveLoginHistory(user);
								fadeOutSingInFormTimer.Start();
							}
						}
					}

				}
			}
		}
		#endregion /PasswordTextBox_TextChange

		#region FadeInSingInFormTimer_Tick
		private void FadeInSingInFormTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity += 0.01;

			if (this.Opacity >= 0.9)
			{
				fadeInSingInFormTimer.Stop();
			}
		}
		#endregion /FadeInSingInFormTimer_Tick

		#region FadeOutSingInFormTimer_Tick
		private void FadeOutSingInFormTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.01;

			if (this.Opacity <= 0.0)
			{
				this.Dispose();
				fadeOutSingInFormTimer.Stop();
				LoadingUserAccountForm loadingUserAccountForm = new LoadingUserAccountForm();
				loadingUserAccountForm.Show();
			}
		}
		#endregion /FadeOutSingInFormTimer_Tick

		#region FadeOutForSingUpTimer_Tick
		private void FadeOutForSingUpTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.01;
			if (this.Opacity <= 0.0)
			{
				fadeOutSingInFormTimer.Stop();
				Inventory.Program.SingUpLoaded();
				this.Dispose();
				
			}
		}
		#endregion /FadeOutForSingUpTimer_Tick

		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Functions
		//===============
		#region ApprovalUsername
		private bool ApprovalUsername(string username)
		{
			dataBaseContext =
				new Models.DataBaseContext();

			try
			{
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
			catch (System.Exception ex)
			{

				Infrastructure.Utility.ExceptionShow(ex);
				return false;
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /ApprovalUsername

		#region GetImageByUser
		/// <summary>
		/// چهت بازگرداندن تصویر کاربر
		/// </summary>
		/// <param name="user"></param>
		private void GetImageByUser(Models.User user)
		{
			if (user == null)
			{
				userImagePictureBox.Image = Inventory.Properties.Resources.circled_user_male_skin_type_3_512px;
			}
			else
			{
				if (user.User_Image == null)
				{
					userImagePictureBox.Image = Inventory.Properties.Resources.circled_user_male_skin_type_3_512px;
				}
				else
				{
					var byteImage = user.User_Image;
					using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
					{
						userImagePictureBox.Image = System.Drawing.Image.FromStream(ms);
					}
				}
			}
		}
		#endregion /GetImageByUser

		#region GetUserByUsername
		/// <summary>
		/// بررسی شناسه کاربری جهت شناساسی کاربر
		/// </summary>
		/// <param name="username"></param>
		/// <returns></returns>
		private Models.User GetUserByUsername(string username)
		{
			try
			{
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
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
				return null;
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /GetUserByUsername

		#region Initialize
		private void Initialize()
		{
			this.Opacity = 0.0;
			fadeInSingInFormTimer.Start();
		}
		#endregion /Initialize

		#region SaveLoginHistory
		private void SaveLoginHistory(Models.User user)
		{
			LoginTime = $"{Infrastructure.Utility.ShowTime()} - {Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";

			LogoutTime = null;

			string fullName;
			try
			{
				if (string.IsNullOrWhiteSpace(user.Full_Name))
				{
					fullName = null;
				}
				else
				{
					fullName = $"{user.Full_Name}";
				}

				dataBaseContext =
					new Models.DataBaseContext();
				Models.LoginHistory logHistory =
					dataBaseContext.LoginHistories
					.OrderBy(current => current.Login_Time)
					.FirstOrDefault();

				logHistory =
					new Models.LoginHistory
					{
						Full_Name = fullName,
						Username = user.Username,
						Login_Time = LoginTime,
						Logout_Time = LogoutTime,
					};

				dataBaseContext.LoginHistories.Add(logHistory);
				dataBaseContext.SaveChanges();

				Inventory.Program.SavaLogHistory = logHistory;
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
		//===================
		#endregion /Functions
	}
}

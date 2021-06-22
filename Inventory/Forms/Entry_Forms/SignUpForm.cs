using System.Linq;

namespace Entry_Forms
{
	public partial class SingUpForm : Infrastructure.BaseForm
	{
		#region Properties
		public enum AccessLeve
		{
			مدیریت,
			معاونت,
			کارمند,
			نیروی_خدماتی,
			کاربر_ساده,
		}

		private Models.User _userAccount = null;

		public Models.User UserAccount
		{
			get 
			{
				if (_userAccount == null)
				{
					_userAccount =
						new Models.User();
				}
				return _userAccount;
			}
			set { _userAccount = value; }
		}


		#endregion /Properties
		public SingUpForm()
		{
			InitializeComponent();

			RefreshData();
		}

		//----------Beginning of the code!----------

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
			if (usernameTextBox.Text.Length <= 0)
			{
				usernameTextBox.Font =
				Infrastructure.Utility.SegoeUI(emSize: 10);
				usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
			else
			{
				usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				usernameTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(emSize: 10);
			}
		}
		#endregion /UsernameTextBox_KeyPress

		#region UsernameTextBox_TextChange
		private void UsernameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
			{
				usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				usernameTextBox.Font =
				Infrastructure.Utility.SegoeUI(emSize: 10);
				UserAccount.Username = null;
				usernameCheckPictureBox.Visible = false;
				return;
			}
			else
			{
				usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				usernameTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(emSize: 10);

				if (Infrastructure.Utility.UserCheck2(usernameTextBox.Text) == false)
				{
					usernameCheckPictureBox.Visible = false;
					UserAccount.Username = null;
					return;
				}
				else
				{
					if (!UsernameConfirmation(usernameTextBox.Text))
					{
						usernameCheckPictureBox.Visible = false;
						UserAccount.Username = null;
						return;
					}
					else
					{
						usernameCheckPictureBox.Image = Inventory.Properties.Resources.Tik_True;
						usernameCheckPictureBox.Visible = true;
						UserAccount.Username = usernameTextBox.Text;
					}
				}
			}

		}
		#endregion /UsernameTextBox_TextChange

		#region UsernameTextBox_Validated
		private void UsernameTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
			{
				return;
			}
			else
			{
				Infrastructure.Utility.UserCheck2(usernameTextBox.Text);
			}
		}
		#endregion /UsernameTextBox_Validated

		#region PasswordTextBox_TextChange
		private void PasswordTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				passwordTextBox.UseSystemPasswordChar = false;
			}
			else
			{
				passwordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordTextBox_TextChange

		#region PasswordTextBox_Validated
		private void PasswordTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text) && string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
			{
				return;
			}
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text) == false && string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
			{
				return;
			}
			else
			{
				if (Infrastructure.Utility.PasswordSet(password: passwordTextBox.Text, passwordConfirm: confirmPasswordTextBox.Text) == true)
				{
					UserAccount.Password = passwordTextBox.Text;
					return;
				}
				else
				{
					Mbb.Windows.Forms.MessageBox.Show
						(text: "رمز انتخابی یکسان نمی باشد! \n لطافا مجدد تلاش نمایید.",
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					passwordTextBox.Focus();
					return;
				}
			}
		}
		#endregion /PasswordTextBox_Validated

		#region VisiblePictureBox1_MouseDown
		private void VisiblePictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordTextBox.UseSystemPasswordChar = false;
			visiblePictureBox1.Image = Inventory.Properties.Resources.hide_512;
		}
		#endregion /VisiblePictureBox1_MouseDown

		#region VisiblePictureBox1_MouseUp
		private void VisiblePictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordTextBox.UseSystemPasswordChar = true;
			visiblePictureBox1.Image = Inventory.Properties.Resources.show_512;
		}
		#endregion /VisiblePictureBox1_MouseUp

		#region ConfirmPasswordTextBox_TextChange
		private void ConfirmPasswordTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
			{
				confirmPasswordTextBox.UseSystemPasswordChar = false;
			}
			else
			{
				confirmPasswordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /ConfirmPasswordTextBox_TextChange

		#region ConfirmPasswordTextBox_Validated
		private void ConfirmPasswordTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text) && string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
			{
				return;
			}
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text) && string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text) == false)
			{
				return;
			}
			else
			{
				if (Infrastructure.Utility.PasswordSet(password: passwordTextBox.Text, passwordConfirm: confirmPasswordTextBox.Text) == true)
				{
					UserAccount.Password = passwordTextBox.Text;
					return;
				}
				else
				{
					System.Windows.Forms.DialogResult dialogResult = Mbb.Windows.Forms.MessageBox.Show
						(text: "رمز انتخابی یکسان نمی باشد! \n لطافا مجدد تلاش نمایید.",
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);


					if (dialogResult == System.Windows.Forms.DialogResult.OK)
					{
						passwordTextBox.Focus();
						return;
					}
				}

			}
		}
		#endregion /ConfirmPasswordTextBox_Validated

		#region VisiblePictureBox2_MouseDown
		private void VisiblePictureBox2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			confirmPasswordTextBox.UseSystemPasswordChar = false;
			visiblePictureBox2.Image = Inventory.Properties.Resources.hide_512;
		}
		#endregion /VisiblePictureBox2_MouseDown

		#region VisiblePictureBox2_MouseUp
		private void VisiblePictureBox2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			confirmPasswordTextBox.UseSystemPasswordChar = true;
			visiblePictureBox2.Image = Inventory.Properties.Resources.show_512;
		}
		#endregion /VisiblePictureBox2_MouseUp

		#region FullNameTextBox_Enter
		private void FullNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /FullNameTextBox_Enter

		#region FullNameTextBox_KeyPress
		private void FullNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /FullNameTextBox_KeyPress

		#region FullNameTextBox_TextChange
		private void FullNameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
			{
				UserAccount.Full_Name = null;
			}
			else
			{
				UserAccount.Full_Name = fullNameTextBox.Text;
			}
		}
		#endregion /FullNameTextBox_TextChange

		#region UserImagePictureBox_MouseDoubleClick
		private void UserImagePictureBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPG (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load user picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				userImagePictureBox.Image =
				System.Drawing.Image.FromFile(openFileDialog.FileName);
				UserAccount.User_Image = System.IO.File.ReadAllBytes(openFileDialog.FileName);
				deleteImageButton.Visible = true;
			}
			else
			{
				UserAccount.User_Image = null;
				deleteImageButton.Visible = false;
			}
		}
		#endregion /UserImagePictureBox_MouseDoubleClick

		#region DeleteImageButton_Click
		private void DeleteImageButton_Click(object sender, System.EventArgs e)
		{
			UserAccount.User_Image = null;
			userImagePictureBox.Image = Inventory.Properties.Resources.circled_user_male_skin_type_3_512px;
			deleteImageButton.Visible = false;
		}
		#endregion /DeleteImageButton_Click

		#region SinginButton_Click
		private void SinginButton_Click(object sender, System.EventArgs e)
		{
			fadeOutTimer.Start();
		}
		#endregion /SinginButton_Click

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if (string.Compare(saveButton.Text, "ثبت") == 0)
			{
				if (UserVlidation(UserAccount))
				{
					SaveAccount(UserAccount);

					RefreshData();
				}
				else
				{
					return;
				}
			}
			else if (string.Compare(saveButton.Text, "ویرایش") == 0)
			{
				UserAccount.Edit_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
				UserAccount.Edit_Time = Infrastructure.Utility.ShowTime();
				EditAccount(UserAccount);
				RefreshData();
			}
		}
		#endregion /SaveButton_Click

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			AllClear();
		}
		#endregion /ResetButton_Click

		#region FadeInFormTimer_Tick
		private void FadeInFormTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity += 0.01;
			if (this.Opacity >= 0.95)
			{
				fadeInFormTimer.Stop();
			}
		}
		#endregion /FadeInFormTimer_Tick

		#region FadeOutTimer_Tick
		private void FadeOutTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.01;
			if (this.Opacity <= 0.0)
			{
				fadeOutTimer.Stop();
				Inventory.Program.SingInLoaded();
				this.Dispose();
			}
		}
		#endregion /FadeOutTimer_Tick

		//----------End of code!----------

		#region Functions
		//==============

		#region AllClear
		private void AllClear()
		{
			UserAccount = null;

			usernameTextBox.Clear();
			passwordTextBox.Clear();
			confirmPasswordTextBox.Clear();
			userImagePictureBox.Image =
				Inventory.Properties.Resources.circled_user_male_skin_type_3_512px;
			deleteImageButton.Visible = false;
			fullNameTextBox.Clear();
		}

		#endregion /AllClear

		#region UsernameConfirmation
		private bool UsernameConfirmation(string username)
		{
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Username, username) == 0)
				.FirstOrDefault();

			if (user == null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion /UsernameConfirmation

		#region EditAccount
		public void EditAccount(Models.User userAccount)
		{
			bool status;
			status = Infrastructure.Utility.EditAccount(userAccount);
			if (status == true)
			{
				string successMessage =
					$"اطلاعات کاربر {UserAccount.Username} با موفقیت ویرایش گردید!";

				if (UserAccount.User_Image == null)
				{
					Infrastructure.Utility.WindowsNotification
					(message: successMessage,
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				}
				else
				{
					Infrastructure.Utility.WindowsNotification
					(message: successMessage,
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
					picture: UserAccount.User_Image);
				}

				AllClear();
				RefreshData();
			}
			else
			{
				string successMessage =
					$"عملیات ویرایش انجام نگردید!";

				Infrastructure.Utility.WindowsNotification
					(message: successMessage,
					caption: Infrastructure.PopupNotificationForm.Caption.خطا);
			}
		}
		#endregion /EditAccount

		#region RefreshData
		public void RefreshData()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.User> users = null;

				users =
					dataBaseContext.Users
					.OrderBy(currnet => currnet.Username)
					.ToList();

				userListDataGridView.DataSource = users;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
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
		#endregion /RefreshData

		#region SaveAccount
		public void SaveAccount(Models.User userAccount)
		{
			bool status;
			status = Infrastructure.Utility.RegisterAccount(userAccount);

			if (status)
			{
				string successMessage =
							$"اطلاعات کاربر {UserAccount.Username} با موفقیت ذخیره گردید!";

				if (UserAccount.User_Image == null)
				{
					Infrastructure.Utility.WindowsNotification
					(message: successMessage,
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				}
				else
				{
					Infrastructure.Utility.WindowsNotification
					(message: successMessage,
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
					picture: UserAccount.User_Image);
				}
				AllClear();
				RefreshData();
			}
			else
			{
				string successMessage =
					$"عملیات ذخیره سازی انجام نگردید!";

				Infrastructure.Utility.WindowsNotification
					(message: successMessage,
					caption: Infrastructure.PopupNotificationForm.Caption.خطا);
			}
		}
		#endregion /SaveAccount

		#region UserVlidation
		private bool UserVlidation(Models.User userAccount)
		{
			string messageErrore = string.Empty;
			if (string.IsNullOrEmpty(userAccount.Username) || usernameCheckPictureBox.Image == Inventory.Properties.Resources.Tik_False)
			{
				messageErrore = $"لطفا فیلد شناسه کاربری را تکمیل نمایید و یا به درستی تکمیل نمایید.";
			}
			if (string.IsNullOrEmpty(userAccount.Password))
			{
				if (string.IsNullOrEmpty(messageErrore) == false)
				{
					messageErrore +=
						System.Environment.NewLine;
				}
				messageErrore +=
					$"لطفا فیلد رمز عبور را تکمیل نمایید.";
			}
			if (string.IsNullOrEmpty(userAccount.Full_Name))
			{
				if (string.IsNullOrEmpty(messageErrore) == false)
				{
					messageErrore +=
						System.Environment.NewLine;
				}
				messageErrore +=
					$"لطفا فیلد نام و نام خانوادگی را تکمیل نمایید.";
			}
			//if (UserAccount.User_Image == null)
			//{
			//	UserAccount.User_Image = null;
			//}
			//else
			//{
			//	UserAccount.User_Image = System.IO.File.ReadAllBytes(userImagePictureBox.Image.ToString());
			//}

			//=====================================================
			if (!string.IsNullOrEmpty(messageErrore))
			{
				if (string.IsNullOrEmpty(userAccount.Username))
				{
					usernameTextBox.Focus();
				}
				else if (string.IsNullOrEmpty(userAccount.Password))
				{
					passwordTextBox.Focus();
				}
				else if (string.IsNullOrEmpty(userAccount.Full_Name))
				{
					fullNameTextBox.Focus();
				}
				Mbb.Windows.Forms.MessageBox.Show
						(text: messageErrore,
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				return false;
			}
			if (string.IsNullOrEmpty(messageErrore))
			{

				UserAccount.Username = usernameTextBox.Text;
				UserAccount.Password = passwordTextBox.Text;
				UserAccount.Registration_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
				UserAccount.Registration_Time = Infrastructure.Utility.ShowTime();
				UserAccount.Is_Active = true;
				UserAccount.Access_Level = Models.User.AccessLeve.کاربر_ساده;
				UserAccount.Edit_Date = null;
				UserAccount.Edit_Time = null;
				return true;
				
			}
			else
			{
				Mbb.Windows.Forms.MessageBox.Show
					(text: messageErrore,
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				messageErrore = null;
				return false;
			}

		}
		#endregion UserVlidation

		//===================
		#endregion /Functions
	}
}

using System.Linq;

namespace Manegment_Setting
{
	public partial class UserSettingUC : System.Windows.Forms.UserControl
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		private Models.EventLog _eventLog;
		public Models.EventLog EventLog
		{
			get
			{
				if (_eventLog == null)
				{
					_eventLog =
						new Models.EventLog();
				}
				return _eventLog;
			}
			set
			{
				_eventLog = value;
			}
		}


		private Models.User _user_FirstLoading;
		public Models.User User_FirstLoading
		{
			get
			{
				if (_user_FirstLoading == null)
				{
					_user_FirstLoading =
						new Models.User();
				}
				return _user_FirstLoading;
			}
			set
			{
				_user_FirstLoading = value;
			}
		}

		private Models.User _user_GetData;
		public Models.User User_GetData
		{
			get
			{
				if (_user_GetData == null)
				{
					_user_GetData =
						new Models.User();
				}
				return _user_GetData;
			}
			set
			{
				_user_GetData = value;
			}
		}

		private Models.User _user_NewData;
		public Models.User User_NewData
		{
			get
			{
				if (_user_NewData == null)
				{
					_user_NewData =
						new Models.User();
				}
				return _user_NewData;
			}
			set
			{
				_user_NewData = value;
			}
		}

		#endregion /Properties


		//-----------------------------------------------------------------------------------------------     Constracture

		public UserSettingUC()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region UserSettingUC_Load
		private void UserSettingUC_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /UserSettingUC_Load

		#region UserListDataGridView_CellDoubleClick
		private void UserListDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex <= -1)
			{
				return;
			}
			if (e.ColumnIndex <= -1)
			{
				return;
			}

			User_FirstLoading.Username = userListDataGridView.CurrentRow.Cells[2].Value.ToString();

			if (string.Compare(User_FirstLoading.Username, "administrator") == 0 || string.Compare(User_FirstLoading.Username, Inventory.Program.UserAuthentication.Username) == 0)
			{
				return;
			}
			else
			{
				ShowInformations(foundedUsername: User_FirstLoading.Username);
				updateButton.Enabled = true;
			}

			ShowInformations(foundedUsername: User_FirstLoading.Username);
			updateButton.Enabled = true;

		}
		#endregion /UserListDataGridView_CellDoubleClick

		#region UsenameLabel_TextChanged
		private void UsernameLabel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(usernameLabel.Text, "شناسه کاربری") != 0)
			{
				usernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
				usernameLabel.Font = Infrastructure.Utility.CenturyGothicFont(emSize: 8);
				User_NewData.Username = usernameLabel.Text;

			}
			else
			{
				usernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				usernameLabel.Font = Infrastructure.Utility.IranSansFont(emSize: 8);
				usernameLabel.Text = "شناسه کاربری";
				User_NewData.Username = null;
			}
		}
		#endregion /UsenameLabel_TextChanged

		#region AdministratorRadioButton_CheckedChanged
		private void AdministratorRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			User_GetData.Access_Level = Models.User.AccessLeve.مدیریت;
		}
		#endregion /AdministratorRadioButton_CheckedChanged

		#region AdministratorLabel_Click
		private void AdministratorLabel_Click(object sender, System.EventArgs e)
		{
			administratorRadioButton.Checked = true;
		}
		#endregion /AdministratorLabel_Click

		#region AssistanceRadioButton_CheckedChanged
		private void AssistanceRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			User_GetData.Access_Level = Models.User.AccessLeve.معاونت;
		}
		#endregion /AssistanceRadioButton_CheckedChanged

		#region AssistanceLabel_Click
		private void AssistanceLabel_Click(object sender, System.EventArgs e)
		{
			assistanceRadioButton.Checked = true;
		}
		#endregion /AssistanceLabel_Click

		#region EmployeedRadioButton_CheckedChanged
		private void EmployeedRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			User_GetData.Access_Level = Models.User.AccessLeve.کارمند;
		}
		#endregion /EmployeedRadioButton_CheckedChanged

		#region EmployeedLabel_Click
		private void EmployeedLabel_Click(object sender, System.EventArgs e)
		{
			employeedRadioButton.Checked = true;
		}
		#endregion /EmployeedLabel_Click

		#region SimpleUserRadioButton_CheckedChanged
		private void SimpleUserRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			User_GetData.Access_Level = Models.User.AccessLeve.کاربر_ساده;
		}
		#endregion /SimpleUserRadioButton_CheckedChanged

		#region SimpleUserLabel_Click
		private void SimpleUserLabel_Click(object sender, System.EventArgs e)
		{
			simpleUserRadioButton.Checked = true;
		}
		#endregion /SimpleUserLabel_Click

		#region ActivationCheckBox_CheckedChanged
		private void ActivationUserCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			User_GetData.Is_Active = activationUserCheckBox.Checked;
		}
		#endregion /ActivationCheckBox_CheckedChanged

		#region ActivationUserLabel_Click
		private void ActivationUserLabel_Click(object sender, System.EventArgs e)
		{
			if (activationUserCheckBox.Checked)
			{
				activationUserCheckBox.Checked = false;
			}
			else
			{
				activationUserCheckBox.Checked = true;
			}
		}
		#endregion /ActivationUserLabel_Click

		#region UpdateButton_Click
		private void UpdateButton_Click(object sender, System.EventArgs e)
		{
			if (UpdateUserAccess(User_FirstLoading, User_GetData))
			{
				Infrastructure.Utility.WindowsNotification(message: $"وضعیت {usernameLabel.Text} به روز رسانی گردید!", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				updateButton.Enabled = false;
				AllClear();
			}
			else
			{
				Infrastructure.Utility.WindowsNotification(message: "عدم به روز رسانی", caption: Infrastructure.PopupNotificationForm.Caption.خطا);
				updateButton.Enabled = false;
				AllClear();
			}
		}
		#endregion /UpdateButton_Click

		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founctions

		#region AllClear
		/// <summary>
		/// حالت اولیه کنترل ها
		/// </summary>
		private void AllClear()
		{
			User_FirstLoading = null;
			User_GetData = null;
			User_NewData = null;

			userImagePictureBox.Image = null;
			usernameLabel.Text = "شناسه کاربری";
			usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

			activationUserCheckBox.Checked = false;
			administratorRadioButton.Checked = false;
			assistanceRadioButton.Checked = false;
			employeedRadioButton.Checked = false;
			simpleUserRadioButton.Checked = false;
			updateButton.Enabled = false;
		}
		#endregion /AllClear

		#region GetUserList
		/// <summary>
		/// بارگذاری لیست کاربران
		/// </summary>
		public void GetUserList()
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


		#endregion /GetUserList

		#region Initialize
		/// <summary>
		/// تنظمیمات ورودی اولیه
		/// </summary>
		public void Initialize()
		{
			AllClear();
			GetUserList();
		}
		#endregion /Initialize

		#region SetEventLog
		private void SetEventLog()
		{
			string descriptionLog = null;

			if (User_FirstLoading.Access_Level != User_GetData.Access_Level)
			{
				descriptionLog =
					$"سطح دسترسی کاربر از {User_FirstLoading.Access_Level} به {User_GetData.Access_Level} تغییر یافت";
			}
			if (User_FirstLoading.Is_Active != User_GetData.Is_Active)
			{
				if (descriptionLog != null)
				{
					descriptionLog +=
						System.Environment.NewLine;
				}
				descriptionLog +=
					$"فعال بودن کاربر از {User_FirstLoading.Is_Active} به {User_GetData.Is_Active} تغییر یافت";
			}

			if (descriptionLog == null)
			{
				return;
			}
			else
			{
				EventLog.Username = Inventory.Program.UserAuthentication.Username;
				EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
				EventLog.Description = descriptionLog;
				EventLog.Event_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
				EventLog.Event_Time = Infrastructure.Utility.ShowTime();

				Infrastructure.Utility.EventLog(EventLog);
			}
		}
		#endregion /SetEventLog

		#region UpdateUserAccess
		/// <summary>
		/// به روز رسانی وضعیت کاربر
		/// </summary>
		/// <returns></returns>
		private bool UpdateUserAccess(Models.User _user_FirstLoading, Models.User _user_GetData)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				if (User_FirstLoading.Access_Level == User_GetData.Access_Level)
				{
					User_NewData.Access_Level = User_FirstLoading.Access_Level;
				}
				else
				{
					User_NewData.Access_Level = User_GetData.Access_Level;
				}

				if (User_FirstLoading.Is_Active == User_GetData.Is_Active)
				{
					User_NewData.Is_Active = User_FirstLoading.Is_Active;
				}
				else
				{
					User_NewData.Is_Active = User_GetData.Is_Active;
				}

				Models.User user =
					dataBaseContext.Users
					.Where(current => string.Compare(current.Username, User_FirstLoading.Username) == 0)
					.FirstOrDefault();

				if (user == null)
				{
					return false;
				}
				else
				{
					user.Is_Active = User_NewData.Is_Active;
					user.Access_Level = User_NewData.Access_Level;
				}

				dataBaseContext.SaveChanges();
				GetUserList();

				#region  -----------------------------------------    SetEventLog     -----------------------------------------
				if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
				{
					SetEventLog();
				}
				#endregion / -----------------------------------------     SetEventLog     -----------------------------------------

				return true;

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
		#endregion /UpdateUserAccess

		#region ShowInformations
		/// <summary>
		/// بازگردانی اطلاعات کاربر
		/// </summary>
		/// <param name="foundedUsername"></param>
		private void ShowInformations(string foundedUsername)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.User user =
					dataBaseContext.Users
					.Where(current => string.Compare(current.Username, foundedUsername) == 0)
					.FirstOrDefault();

				if (user != null)
				{
					usernameLabel.Text = user.Username;
					User_FirstLoading.Username = user.Username;
					User_FirstLoading.Access_Level = user.Access_Level;
					User_GetData.Access_Level = user.Access_Level;

					switch (User_FirstLoading.Access_Level)
					{
						case Models.User.AccessLeve.مدیریت:
						administratorRadioButton.Checked = true;
						break;

						case Models.User.AccessLeve.معاونت:
						assistanceRadioButton.Checked = true;
						
						break;

						case Models.User.AccessLeve.کارمند:
						employeedRadioButton.Checked = true;
						break;

						case Models.User.AccessLeve.کاربر_ساده:
						simpleUserRadioButton.Checked = true;
						break;

						default:
						break;
					}

					User_FirstLoading.Is_Active = user.Is_Active;
					activationUserCheckBox.Checked = user.Is_Active;

					if (user.User_Image != null)
					{
						var byteImage = user.User_Image;
						using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
						{
							userImagePictureBox.Image = System.Drawing.Image.FromStream(ms);
						}
					}

					updateButton.Enabled = false;
				}
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
		#endregion /ShowInformations

		#endregion /Founctions
	}
}

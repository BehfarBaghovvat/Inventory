﻿using System.Linq;

namespace Setting_Forms
{
	public partial class BackupSettingForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		bool check;

		Models.BackupSetting _backupSetting = null;
		Models.BackupSetting BackupSetting
		{
			get
			{
				if (_backupSetting == null)
				{
					_backupSetting =
						new Models.BackupSetting();
				}
				return _backupSetting;
			}
			set
			{
				_backupSetting = value;
			}
		}

		public Models.EventLog EventLog { get; set; }

		System.Data.SqlClient.SqlConnection sqlConnection =
			new System.Data.SqlClient.SqlConnection(Inventory.Properties.Settings.Default.INVENTORYConnectionString);

		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public BackupSettingForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region BackupSettingForm_Load
		private void BackupSettingForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /BackupSettingForm_Load

		#region AutoBackupCheckBox_CheckedChanged
		private void AutoBackupCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			check = true;
			ActiveAutoBackup(autoBackupCheckBox.Checked);
			saveButton.Enabled = true;
		}
		#endregion /AutoBackupCheckBox_CheckedChanged

		#region TimeIntervalComboBox_SelectedIndexChanged
		private void TimeIntervalComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (timeIntervalComboBox.SelectedIndex == 0)
			{
				setTimeBackupGroupBox.BringToFront();
				dayOfWeekGroupBox.SendToBack();
				dayOfMonthGroupBox.SendToBack();

				BackupSetting.Days_Of_Week = null;
				BackupSetting.Day_Of_Month = null;


				BackupSetting.Time_Interval = $"{Models.BackupSetting.TimeInterval.روزانه}";
			}
			else if (timeIntervalComboBox.SelectedIndex == 1)
			{
				dayOfWeekGroupBox.BringToFront();
				setTimeBackupGroupBox.SendToBack();
				dayOfMonthGroupBox.SendToBack();

				BackupSetting.Minutes = null;
				BackupSetting.Houre = null;
				BackupSetting.Day_Of_Month = null;

				BackupSetting.Time_Interval = $"{Models.BackupSetting.TimeInterval.هفتگی}"; ;
			}
			else if (timeIntervalComboBox.SelectedIndex == 2)
			{
				dayOfMonthGroupBox.BringToFront();
				dayOfWeekGroupBox.SendToBack();
				setTimeBackupGroupBox.SendToBack();

				BackupSetting.Minutes = null;
				BackupSetting.Houre = null;
				BackupSetting.Days_Of_Week = null;

				BackupSetting.Time_Interval = $"{Models.BackupSetting.TimeInterval.ماهیانه}";
			}
		}
		#endregion /TimeIntervalComboBox_SelectedIndexChanged

		#region MinutesNumericUpDown_ValueChanged
		private void MinutesNumericUpDown_ValueChanged(object sender, System.EventArgs e)
		{
			if (minutesNumericUpDown.Value < 0 || minutesNumericUpDown.Value > 59)
			{
				return;
			}
			else
			{
				_backupSetting.Minutes = int.Parse(minutesNumericUpDown.Value.ToString());
			}
			
		}
		#endregion /MinutesNumericUpDown_ValueChanged

		#region HoureNumericUpDown_ValueChanged
		private void HoureNumericUpDown_ValueChanged(object sender, System.EventArgs e)
		{
			if (houreNumericUpDown.Value < 0 || houreNumericUpDown.Value > 23)
			{
				return;
			}
			else
			{
				_backupSetting.Houre = int.Parse(houreNumericUpDown.Value.ToString());
			}
		}
		#endregion /HoureNumericUpDown_ValueChanged

		#region DayOfWeekComboBox_SelectedIndexChanged
		private void DayOfWeekComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int index = dayOfWeekComboBox.SelectedIndex;
			switch (index)
			{
				case 0:
				_backupSetting.Days_Of_Week = $"{ Models.BackupSetting.DaysOfWeek.شنبه}";
				break;
				case 1:
				_backupSetting.Days_Of_Week = $"{ Models.BackupSetting.DaysOfWeek.یکشنبه}";
				break;
				case 2:
				_backupSetting.Days_Of_Week = $"{ Models.BackupSetting.DaysOfWeek.دوشنبه}";
				break;
				case 3:
				_backupSetting.Days_Of_Week = $"{ Models.BackupSetting.DaysOfWeek.سه_شنبه}";
				break;
				case 4:
				_backupSetting.Days_Of_Week = $"{ Models.BackupSetting.DaysOfWeek.چهارشنبه}";
				break;
				case 5:
				_backupSetting.Days_Of_Week = $"{ Models.BackupSetting.DaysOfWeek.پنج_شنبه}";
				break;
				case 6:
				_backupSetting.Days_Of_Week = $"{ Models.BackupSetting.DaysOfWeek.جمعه}";
				break;
			}
		}
		#endregion /DayOfWeekComboBox_SelectedIndexChanged

		#region DayOfMonthNumericUpDown_ValueChanged
		private void DayOfMonthNumericUpDown_ValueChanged(object sender, System.EventArgs e)
		{
			if (dayOfMonthNumericUpDown.Value == 0)
			{
				_backupSetting.Day_Of_Month = 0;
			}
			else
			{
				_backupSetting.Day_Of_Month = int.Parse(dayOfMonthNumericUpDown.Value.ToString());
			}
		}
		#endregion /DayOfMonthNumericUpDown_ValueChanged

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
		
			if (SetDataBackupSetting(BackupSetting))
			{
				Infrastructure.Utility.WindowsNotification(message: "تنظیمات ثبت گردید", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت); ;
				check = false;
				saveButton.Enabled = false;
			}
		}
		#endregion /SaveButton_Click

		#region BackupButton_Click
		private void BackupButton_Click(object sender, System.EventArgs e)
		{
			string dataBase = sqlConnection.Database.ToString();
			try
			{
				if (string.IsNullOrWhiteSpace(savePathTextBox.Text) || string.Compare(savePathTextBox.Text, "Save Path...") == 0)
				{
					Mbb.Windows.Forms.MessageBox.Show(
						text: "لطفا برای ذخیره یک مسیر انتخاب نمایید.",
						caption: "",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					selectSavePathButton.Focus();
				}
				else
				{
					string command = $"Backup Database [{dataBase}] To Disk='{savePathTextBox.Text}\\Database-{System.DateTime.Now:yyyy-MM-dd--HH-mm-ss}.bak'";
					this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
					System.Data.SqlClient.SqlConnection sqlConnection = null;
					System.Data.SqlClient.SqlCommand sqlCommand = null;

					sqlConnection = new System.Data.SqlClient.SqlConnection($"Data Source=.;Initial Catalog={dataBase}; Integrated Security=True");

					if (sqlConnection.State != System.Data.ConnectionState.Open)
					{
						sqlConnection.Open();
					}

					sqlCommand = new System.Data.SqlClient.SqlCommand(command, sqlConnection);
					sqlCommand.ExecuteNonQuery();
					this.Cursor = System.Windows.Forms.Cursors.Default;
					Mbb.Windows.Forms.MessageBox.Show(text: "پشتیبان گیری انجام شد.", caption: "تکمیل عملیات", icon: Mbb.Windows.Forms.MessageBoxIcon.Success, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					savePathTextBox.Text = "Save Path...";
					savePathTextBox.ForeColor = Infrastructure.Utility.GrayColor();

					#region EventLog
					EventLog.Username = Inventory.Program.UserAuthentication.Username;
					EventLog.Full_Name = $"{Inventory.Program.UserAuthentication.Full_Name}";
					EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
					EventLog.Description = $"تهیه نسخه پشتیبان";

					Infrastructure.Utility.EventLog(EventLog);
					#endregion /EventLog
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /BackupButton_Click

		#region SelectSavePathButton_Click
		private void SelectSavePathButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				savePathTextBox.Text = folderBrowserDialog.SelectedPath;
				savePathTextBox.ForeColor = Infrastructure.Utility.WhiteColor();
			}
			else
			{
				savePathTextBox.Text = "Save Path...";
				savePathTextBox.ForeColor = Infrastructure.Utility.GrayColor();
			}
		}
		#endregion /SelectSavePathButton_Click

		#region RestorBackupButton_Click
		private void RestorBackupButton_Click(object sender, System.EventArgs e)
		{
			string dataBase = sqlConnection.Database.ToString();
			try
			{
				string command = $"ALTER DATABASE {dataBase}  SET SINGLE_USER with ROLLBACK IMMEDIATE  USE master RESTORE DATABASE {dataBase} FROM DISK='{loadPathTextBox.Text}' WITH REPLACE";

				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
				System.Data.SqlClient.SqlCommand ocommand = null;
				System.Data.SqlClient.SqlConnection oconnection = null;
				oconnection = new System.Data.SqlClient.SqlConnection($"Data Source=.;Initial Catalog={dataBase}; Integrated Security=True");

				if (oconnection.State != System.Data.ConnectionState.Open)

					oconnection.Open();

				ocommand = new System.Data.SqlClient.SqlCommand(command, oconnection);

				ocommand.ExecuteNonQuery();

				Mbb.Windows.Forms.MessageBox.Show(text: "!بازیابی اطلاعات انجام شد", caption: "تکمیل اعملیات", icon: Mbb.Windows.Forms.MessageBoxIcon.Success, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				loadPathTextBox.Text = "Load Path...";
				loadPathTextBox.ForeColor = Infrastructure.Utility.GrayColor();
				sqlConnection.Close();
				this.Cursor = System.Windows.Forms.Cursors.Default;

				#region EventLog
				EventLog.Username = Inventory.Program.UserAuthentication.Username;
				EventLog.Full_Name = $"{Inventory.Program.UserAuthentication.Full_Name}";
				EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
				EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
				EventLog.Description = $"بازگردانی نسخه {loadPathTextBox.Text}";

				Infrastructure.Utility.EventLog(EventLog);
				#endregion /EventLog
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /RestorBackupButton_Click

		#region SelectLoadPathButton_Click
		private void SelectLoadPathButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
			openFileDialog.Filter = "SQL SERVER database backup files | *.bak";
			openFileDialog.Title = "SQL SERVER Backup Restor";

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				loadPathTextBox.Text = openFileDialog.FileName;
				loadPathTextBox.ForeColor = Infrastructure.Utility.WhiteColor();
			}
			else
			{
				loadPathTextBox.Text = "Load Path...";
				loadPathTextBox.ForeColor = Infrastructure.Utility.GrayColor();
			}
		}
		#endregion /SelectLoadPathButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founcitons

		#region ActiveAutoBackup
		/// <summary>
		/// فعال سازی بخش پشتیبان گیری خودکار
		/// </summary>
		/// <param name="_autoBackup"></param>
		private void ActiveAutoBackup(bool _autoBackup)
		{
			if (_autoBackup)
			{
				BackupSetting.Auto_Backup = true;
				timeIntervalComboBox.Enabled = true;

				setTimeBackupGroupBox.Enabled = true;
				dayOfMonthGroupBox.Enabled = true;
				dayOfWeekGroupBox.Enabled = true;

				backupPanel.Enabled = false;
				restorePanel.Enabled = false;
			}
			else
			{
				BackupSetting.Auto_Backup = false;
				timeIntervalComboBox.Enabled = false;

				setTimeBackupGroupBox.Enabled = false;
				dayOfMonthGroupBox.Enabled = false;
				dayOfWeekGroupBox.Enabled = false;

				backupPanel.Enabled = true;
				restorePanel.Enabled = true;
			}
		}
		#endregion /ActiveAutoBackup

		#region GetBackupSetting
		/// <summary>
		/// بارگزاری اطلاعات تنظیمات پشتیبان گیری
		/// </summary>
		/// <returns>dataBaseContext</returns>
		private bool GetBackupSetting()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.BackupSetting backupSetting =
					dataBaseContext.BackupSettings
					.Where(current => current.Id == 1)
					.FirstOrDefault();
				if (backupSetting == null)
				{
					return false;
				}
				else
				{
					BackupSetting = backupSetting;
					return true;
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
		#endregion /GetBackupSetting

		#region Initialize
		/// <summary>
		/// تنظمیات ورود اولیه
		/// </summary>
		public void Initialize()
		{
			check = false;
			saveButton.Enabled = false;
			if (!GetBackupSetting())
			{
				return;
			}
			else
			{
				if (BackupSetting.Auto_Backup)
				{
					ActiveAutoBackup(BackupSetting.Auto_Backup);

					autoBackupCheckBox.Checked = BackupSetting.Auto_Backup;

					switch (BackupSetting.Time_Interval)
					{
						case "روزانه":
						timeIntervalComboBox.SelectedIndex = timeIntervalComboBox.FindString(BackupSetting.Time_Interval.ToString());
						setTimeBackupGroupBox.BringToFront();
						dayOfWeekGroupBox.SendToBack();
						dayOfMonthGroupBox.SendToBack();
						minutesNumericUpDown.Value = decimal.Parse(BackupSetting.Minutes.ToString());
						houreNumericUpDown.Value = decimal.Parse(BackupSetting.Houre.ToString());
						break;

						case "هفتگی":
						timeIntervalComboBox.SelectedIndex = timeIntervalComboBox.FindString(BackupSetting.Time_Interval);
						dayOfWeekGroupBox.BringToFront();
						setTimeBackupGroupBox.SendToBack();
						dayOfMonthGroupBox.SendToBack();
						dayOfWeekComboBox.SelectedIndex = dayOfWeekComboBox.FindString(BackupSetting.Days_Of_Week);
						break;

						case "ماهیانه":
						timeIntervalComboBox.SelectedIndex = timeIntervalComboBox.FindString(BackupSetting.Time_Interval.ToString());
						dayOfMonthGroupBox.BringToFront();
						dayOfWeekGroupBox.SendToBack();
						setTimeBackupGroupBox.SendToBack();
						dayOfMonthNumericUpDown.Value = decimal.Parse(BackupSetting.Day_Of_Month.ToString());

						break;
					}
				}
				else
				{
					ActiveAutoBackup(BackupSetting.Auto_Backup);
					autoBackupCheckBox.Checked = BackupSetting.Auto_Backup;
				}
			}
		}
		#endregion /Initialize

		#region SetDataBackupSetting
		/// <summary>
		/// ذخیره اطلاعات تنظیمات پشتیبان گیری خودکار
		/// </summary>
		/// <param name="_backupSetting"></param>
		/// <returns>tru Or false</returns>
		private bool SetDataBackupSetting( Models.BackupSetting _backupSetting)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.BackupSetting backupSetting =
					dataBaseContext.BackupSettings
					.Where(currnet => currnet.Id == 1)
					.FirstOrDefault();

				if (backupSetting == null)
				{
					backupSetting =
						new Models.BackupSetting()
						{
							Auto_Backup = _backupSetting.Auto_Backup,
							Days_Of_Week = _backupSetting.Days_Of_Week,
							Day_Of_Month = _backupSetting.Day_Of_Month,
							Houre = _backupSetting.Houre,
							Minutes = _backupSetting.Minutes,
							Time_Interval = _backupSetting.Time_Interval,
						};

					dataBaseContext.BackupSettings.Add(backupSetting);
					dataBaseContext.SaveChanges();
				}
				else
				{
					backupSetting.Auto_Backup = _backupSetting.Auto_Backup;
					backupSetting.Days_Of_Week = _backupSetting.Days_Of_Week;
					backupSetting.Day_Of_Month = _backupSetting.Day_Of_Month;
					backupSetting.Houre = _backupSetting.Houre;
					backupSetting.Minutes = _backupSetting.Minutes;
					backupSetting.Time_Interval = _backupSetting.Time_Interval;

					dataBaseContext.SaveChanges();
				}
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

		#endregion /SetDataBackupSetting

		#endregion /Founcitons

	
	}
}

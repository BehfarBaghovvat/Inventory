
using System.Linq;

namespace Inventory
{
	public partial class PrimeForm : Infrastructure.BaseForm
	{

		#region Properties
		public string AccesseLevel { get; private set; }
		public string AccountName { get; set; }
		public bool FocusHome { get; private set; }
		public bool FocusWarehouse { get; private set; }
		public bool FocusFinancial { get; private set; }
		public bool FocusReport { get; private set; }
		public bool FocusSetting { get; private set; }
		public string LoginTime { get; private set; }
		public string LogOutTime { get; private set; }
		public string Username { get; private set; }
		#endregion /Properties

		public PrimeForm()
		{
			InitializeComponent();
			FocusHome = true;
			solarCalenderLabel.Text = Infrastructure.Utility.PersianCalendar();
			gregorianCalendarLabel.Text = Infrastructure.Utility.ADCalendar();
		}

		//----------Beginning of the code!

		#region PrimeForm_Load
		private void PrimeForm_Load(object sender, System.EventArgs e)
		{
			secondsLabel.Text =
				System.DateTime.Now.Second.ToString().PadLeft(2, '0');

			minutesLabel.Text =
				System.DateTime.Now.Minute.ToString().PadLeft(2, '0');

			hoursLabel.Text =
				System.DateTime.Now.Hour.ToString().PadLeft(2, '0');

			clockTimer.Start();
			this.Opacity = 0.0;
			fadeInPrimeFormTimer.Start();
			AccountLoaded();
		}
		#endregion /PrimeForm_Load

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult =
				Mbb.Windows.Forms.MessageBox.Show(text: "قصد خروج دارید؟", caption: "خروج از برنامه", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				Infrastructure.Utility.SaveLogOutTime(Program.AutenticatLogHistory);
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /CloseButton_Click

		#region MinimizedButton_Click
		private void MinimizedButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizedButton_Click

		#region HomeButton_Click
		private void HomeButton_Click(object sender, System.EventArgs e)
		{
			if (FocusHome == true)
			{
				return;
			}
			else
			{
				FocusHome = true;
				FocusWarehouse = false;
				FocusFinancial = false;
				FocusReport = false;
				FocusSetting = false;

				homePanel.Visible = false;
				homeButton.Checked = true;
				warehouseButton.Checked = false;
				financialButton.Checked = false;
				reportsButton.Checked = false;
				settinigsButton.Checked = false;
				edgePictureBox.Location = new System.Drawing.Point(x: 0, y: 165);

				this.menuPanel.Controls.Clear();
				this.menuPanel.Controls.Add(homePanel);
				Transition1.Show(homePanel);
			}
		}
		#endregion /HomeButton_Click

		#region WarehouseButton_Click
		private void WarehouseButton_Click(object sender, System.EventArgs e)
		{
			if (FocusWarehouse == true)
			{
				return;
			}
			else
			{
				FocusHome = false;
				FocusWarehouse = true;
				FocusFinancial = false;
				FocusReport = false;
				FocusSetting = false;

				homeButton.Checked = false;
				warehouseButton.Checked = true;
				financialButton.Checked = false;
				reportsButton.Checked = false;
				settinigsButton.Checked = false;
				edgePictureBox.Location = new System.Drawing.Point(x: 0, y: 237);

				this.menuPanel.Controls.Clear();
			}
		}
		#endregion /WarehouseButton_Click

		#region FinancialButton_Click
		private void FinancialButton_Click(object sender, System.EventArgs e)
		{
			if (FocusFinancial == true)
			{
				return;
			}
			else
			{
				FocusHome = false;
				FocusWarehouse = false;
				FocusFinancial = true;
				FocusReport = false;
				FocusSetting = false;

				homeButton.Checked = false;
				warehouseButton.Checked = false;
				financialButton.Checked = true;
				reportsButton.Checked = false;
				settinigsButton.Checked = false;
				edgePictureBox.Location = new System.Drawing.Point(x: 0, y: 311);
			}
		}
		#endregion /FinancialButton_Click

		#region ReportsButton_Click
		private void ReportsButton_Click(object sender, System.EventArgs e)
		{
			if (FocusReport == true)
			{
				return;
			}
			else
			{
				FocusHome = false;
				FocusWarehouse = false;
				FocusFinancial = false;
				FocusReport = true;
				FocusSetting = false;

				homeButton.Checked = false;
				warehouseButton.Checked = false;
				financialButton.Checked = false;
				reportsButton.Checked = true;
				settinigsButton.Checked = false;
				edgePictureBox.Location = new System.Drawing.Point(x: 0, y: 386);

				this.menuPanel.Controls.Clear();
			}
		}
		#endregion /ReportsButton_Click

		#region SetinigsButton_Click
		private void SettinigsButton_Click(object sender, System.EventArgs e)
		{
			if (FocusSetting == true)
			{
				return;
			}
			else
			{
				FocusHome = false;
				FocusWarehouse = false;
				FocusFinancial = false;
				FocusReport = false;
				FocusSetting = true;

				homeButton.Checked = false;
				warehouseButton.Checked = false;
				financialButton.Checked = false;
				reportsButton.Checked = false;
				settinigsButton.Checked = true;
				edgePictureBox.Location = new System.Drawing.Point(x: 0, y: 462);

				this.menuPanel.Controls.Clear();
			}
		}
		#endregion /SetinigsButton_Click

		#region ClockTimer_Tick
		private void ClockTimer_Tick(object sender, System.EventArgs e)
		{
			string second, minute, hour;
			string finalSecond, finalMinute, finalHour;
			int month, day;

			second = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
			secondsLabel.Text = second;

			minute = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			minutesLabel.Text = minute;

			hour = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
			hoursLabel.Text = hour;

			finalSecond = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
			finalMinute = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			finalHour = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');

			System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

			month = persianCalendar.GetMonth(System.DateTime.Now);
			day = persianCalendar.GetDayOfMonth(System.DateTime.Now);
		}
		#endregion /ClockTimer_Tick

		#region ExitButton_Click
		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult =
				Mbb.Windows.Forms.MessageBox.Show(text: "قصد خروج دارید؟", caption: "خروج از برنامه", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				Infrastructure.Utility.SaveLogOutTime(Program.AutenticatLogHistory);
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /ExitButton_Click

		#region FadeInPrimeFormTimer_Tick
		private void FadeInPrimeFormTimer_Tick(object sender, System.EventArgs e)
		{
			FadeInPrimeForm();
		}
		#endregion /FadeInPrimeFormTimer_Tick

		//----------End of code!

		#region Functions
		//-----
		#region AccountLoaded
		private void AccountLoaded()
		{
			AccountName = $"{Program.AuthenticatedUser.First_Name} {Program.AuthenticatedUser.Last_Name}";
			accountNameLabel.Text = AccountName.Trim();
			accountTypeTextBox.Text = Program.AuthenticatedUser.Access_Level;
			emailTextBox.Text = Program.AuthenticatedUser.Email;
			timeEntryTextbox.Text = $"{Infrastructure.Utility.ShowTime(format: "H:mm")}";

			var byteImage = Program.AuthenticatedUser.User_Image;

			if (byteImage.Length != 0)
			{
				using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
				{
					userImagePictureBox.Image = System.Drawing.Image.FromStream(ms);
				}
			}
			else
			{
				userImagePictureBox.Image = Properties.Resources.new_user_1080_Light_Gray;
			}

			AccesseLevel = Program.AuthenticatedUser.Access_Level;
			switch (AccesseLevel)
			{
				case "مدیریت":
					homeButton.Enabled = true;
					warehouseButton.Enabled = true;
					financialButton.Enabled = true;
					reportsButton.Enabled = true;
					settinigsButton.Enabled = true;
					break;

				case "کارمند":
					homeButton.Enabled = true;
					warehouseButton.Enabled = true;
					financialButton.Enabled = true;
					reportsButton.Enabled = true;
					settinigsButton.Enabled = true;
					break;

				case "نیروی خدمات":
					homeButton.Enabled = true;
					warehouseButton.Enabled = true;
					financialButton.Enabled = false;
					reportsButton.Enabled = true;
					settinigsButton.Enabled = false;
					break;

				case "کاربر ساده":
					homeButton.Enabled = true;
					warehouseButton.Enabled = true;
					financialButton.Enabled = false;
					reportsButton.Enabled = false;
					settinigsButton.Enabled = false;
					break;

				default:
					break;
			}
			SaveLoginHistory(Program.AuthenticatedUser);
		}
		#endregion /AccountLoaded

		#region FadeInPrimeForm
		private void FadeInPrimeForm()
		{
			this.Opacity += 0.05;

			if (this.Opacity == 0.9)
			{
				fadeInPrimeFormTimer.Stop();
			}
		}
		#endregion /FadeInPrimeForm

		#region SaveLoginHistory
		private void SaveLoginHistory(Models.User user)
		{
			LoginTime = $"{Infrastructure.Utility.ShowTime()} - {Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";

			LogOutTime = $"Null";

			string fullName;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				if (string.IsNullOrWhiteSpace(user.First_Name) && string.IsNullOrWhiteSpace(user.Last_Name))
				{
					fullName = "Null";
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

				Program.AutenticatLogHistory = logHistory;
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

		#region SaveLogOutTime
		private void SaveLogOutTime(Models.LogHistory log)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.LogHistory logHistory =
					dataBaseContext.LogHistories
					.Where(current => string.Compare(current.Username, log.Username) == 0)
					.OrderByDescending(current => current.Login_Time)
					.SingleOrDefault(current => current.Id == log.Id);

				if (logHistory != null)
				{
					LogOutTime = $"{Infrastructure.Utility.ShowTime()}" +
						$"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} ";

					logHistory.Logout_Time = LogOutTime;

					dataBaseContext.SaveChanges();
				}
				else
				{
					return;
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
		#endregion /SaveLogOutTime
		//-----
		#endregion /Functions

		
	}
}

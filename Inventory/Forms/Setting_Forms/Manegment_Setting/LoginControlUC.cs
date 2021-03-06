using System.Linq;

namespace Manegment_Setting
{
	public partial class LoginControlUC : System.Windows.Forms.UserControl
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Layer
		/// <summary>
		/// ایتم های مربوط به گزارش 
		/// ورود و خروج کاربران
		/// </summary>
		private class LogItem
		{
			public int Id { get; set; }
			public string Full_Name { get; set; }
			public string Login_Time { get; set; }
			public string Logout_Time { get; set; }
		}

		private Manegment_Setting.PrintReportForm _printReportForm;
		public Manegment_Setting.PrintReportForm PrintReportForm
		{
			get
			{
				if (_printReportForm == null || _printReportForm.IsDisposed == true)
				{
					_printReportForm =
						new PrintReportForm();
				}
				return _printReportForm;
			}
			set
			{
				_printReportForm = value;
			}
		}

		#endregion /Layer

		private Models.LoginHistory _loginHistory;
		public Models.LoginHistory LoginHistory
		{
			get
			{
				if (_loginHistory == null)
				{
					_loginHistory =
						new Models.LoginHistory();
				}
				return _loginHistory;
			}
			set
			{
				_loginHistory = value;
			}
		}
		#endregion /Properties


		//-----------------------------------------------------------------------------------------------     Events Controls

		public LoginControlUC()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls
		
		#region LoginControlUC_Load
		private void LoginControlUC_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /LoginControlUC_Load

		#region UserSearchTextBox_Enter
		private void UserSearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
		}
		#endregion /UserSearchTextBox_Enter

		#region UserSearchTextBox_KeyPress
		private void UserSearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /UserSearchTextBox_KeyPress

		#region UserSearchTextBox_TextChange
		private void UserSearchTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(userSearchTextBox.Text))
			{
				userSearchTextBox.Font = Infrastructure.Utility.IRANSansXFaNumFont(8);
				userSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

				LoginHistory.Username = null;

				return;
			}
			else
			{
				userSearchTextBox.Font = Infrastructure.Utility.CenturyGothicFont(10);
				userSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

				LoginHistory.Username = userSearchTextBox.Text;

				if (GetUserLoginHistory(LoginHistory))
				{
					printButton.Enabled = true;
				}
				else
				{
					printButton.Enabled = false;
				}
			}
		}
		#endregion /UserSearchTextBox_TextChange

		#region PrintButton_Click
		private void PrintButton_Click(object sender, System.EventArgs e)
		{
			PrintLogHistory();
		}
		#endregion /PrintButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founcitons

		#region GetLogHistory
		/// <summary>
		/// بارگزاری لیست ورود و خروج کاربران
		/// </summary>
		private void GetLogHistory()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.LoginHistory> listLoginHistories = new System.Collections.Generic.List<Models.LoginHistory>();

				listLoginHistories =
					dataBaseContext.LoginHistories
					.OrderBy(current => current.Id)
					.ToList();

				if (listLoginHistories.Count == 0)
				{
					return;
				}
				else
				{
					listLogHistoryDataGridView.DataSource = listLoginHistories;
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
		#endregion /GetLogHistory

		#region GetUserLoginHistory
		/// <summary>
		/// جستجوی نام کاربر جهت
		/// نمایش وضعیت ورود و خروج
		/// </summary>
		/// <param name="_loginHistory"></param>
		private bool GetUserLoginHistory(Models.LoginHistory _loginHistory)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.LoginHistory> listLoginHistories = null;

				if (string.IsNullOrEmpty(_loginHistory.Username))
				{
					listLoginHistories =
						dataBaseContext.LoginHistories
						.OrderBy(current => current.Id)
						.ToList();

					listLogHistoryDataGridView.DataSource = listLoginHistories;

					return false;
				}
				else
				{
					listLoginHistories =
						dataBaseContext.LoginHistories
						.Where(current => current.Username.Contains(_loginHistory.Username))
						.OrderByDescending(current => current.Login_Time)
						.ToList();

					if (listLoginHistories == null)
					{
						listLogHistoryDataGridView.DataSource = null;
						return false;
					}
					else
					{
						listLogHistoryDataGridView.DataSource = listLoginHistories;
						return true;
					}
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
		#endregion /GetUserLoginHistory

		#region Initialize
		/// <summary>
		/// تنظمیات ورود اولیه
		/// </summary>
		public void Initialize()
		{
			GetLogHistory();
		}




		#endregion /Initialize

		#region PrintLogHistory
		/// <summary>
		/// چاپ گزارش ورود و خروج
		/// </summary>
		private void PrintLogHistory()
		{
			if (string.IsNullOrWhiteSpace(userSearchTextBox.Text))
			{
				try
				{
					System.Collections.Generic.List<LogItem> listLogReportItems = new System.Collections.Generic.List<LogItem>();

					foreach (System.Windows.Forms.DataGridViewRow rows in listLogHistoryDataGridView.Rows)
					{
						LogItem _logItemReportItems = new LogItem
						{
							Id = int.Parse(rows.Cells[0].Value.ToString()),
							Full_Name = rows.Cells[2].Value.ToString(),
							Login_Time = rows.Cells[3].Value.ToString(),
							Logout_Time = (rows.Cells[4].Value.ToString()),
						};
						listLogReportItems.Add(_logItemReportItems);
					}

					Stimulsoft.Report.StiReport printInvoice = new Stimulsoft.Report.StiReport();

					printInvoice.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\AllLogHistoryReport.mrt");
					printInvoice.RegBusinessObject("LogHistory", listLogReportItems);

					(printInvoice.GetComponentByName("dateOfPrintTextBox") as Stimulsoft.Report.Components.StiText).Text = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} - {Infrastructure.Utility.ShowTime()}";
					(printInvoice.GetComponentByName("usernameTextBox") as Stimulsoft.Report.Components.StiText).Text = string.Empty;
					(printInvoice.GetComponentByName("fullNameTextBox") as Stimulsoft.Report.Components.StiText).Text = string.Empty;

					printInvoice.Render(true);
					PrintReportForm.printReportStiRibbonViewerControl.Report = printInvoice;
					PrintReportForm.ShowDialog();
				}
				catch (System.Exception ex)
				{
					Infrastructure.Utility.ExceptionShow(ex);
				}
			}
			else
			{
				try
				{
					System.Collections.Generic.List<LogItem> listLogReportItems = new System.Collections.Generic.List<LogItem>();

					foreach (System.Windows.Forms.DataGridViewRow rows in listLogHistoryDataGridView.Rows)
					{
						LogItem _logItemReportItems = new LogItem
						{
							Id = int.Parse(rows.Cells[0].Value.ToString()),
							Login_Time = rows.Cells[3].Value.ToString(),
							Logout_Time = (rows.Cells[4].Value.ToString()),
						};
						listLogReportItems.Add(_logItemReportItems);
					}

					Stimulsoft.Report.StiReport printInvoice = new Stimulsoft.Report.StiReport();

					printInvoice.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\LogHistoryReport.mrt");
					printInvoice.RegBusinessObject("LogHistory", listLogReportItems);

					(printInvoice.GetComponentByName("dateOfPrintTextBox") as Stimulsoft.Report.Components.StiText).Text = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} - {Infrastructure.Utility.ShowTime()}";
					(printInvoice.GetComponentByName("usernameTextBox") as Stimulsoft.Report.Components.StiText).Text = listLogHistoryDataGridView.Rows[0].Cells[1].Value.ToString();
					(printInvoice.GetComponentByName("fullNameTextBox") as Stimulsoft.Report.Components.StiText).Text = listLogHistoryDataGridView.Rows[0].Cells[2].Value.ToString();

					printInvoice.Render(true);
					PrintReportForm.printReportStiRibbonViewerControl.Report = printInvoice;
					PrintReportForm.ShowDialog();
				}
				catch (System.Exception ex)
				{
					Infrastructure.Utility.ExceptionShow(ex);
				}
			}
		}
		#endregion /PrintLogHistory

		#endregion /Founcitons
	}
}

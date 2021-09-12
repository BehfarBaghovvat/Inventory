using System.Linq;

namespace Manegment_Setting
{
	public partial class EventLogUC : System.Windows.Forms.UserControl
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Layer
		/// <summary>
		/// ایتم های مربوط به گزارش 
		/// ورود و خروج کاربران
		/// </summary>
		private class EventItem
		{
			public int Id { get; set; }
			public string Description { get; set; }
			public string Event_Date { get; set; }
			public string Event_Time { get; set; }
			public string Full_Name { get; set; }
		}


		private Manegment_Setting.PrintLogHistoryForm _printLogHistoryForm;
		public Manegment_Setting.PrintLogHistoryForm PrintLogHistoryForm
		{
			get
			{
				if (_printLogHistoryForm == null || _printLogHistoryForm.IsDisposed == true)
				{
					_printLogHistoryForm =
						new PrintLogHistoryForm();
				}
				return _printLogHistoryForm;
			}
			set
			{
				_printLogHistoryForm = value;
			}
		}

		#endregion /Layer

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
		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Events Controls

		public EventLogUC()
		{
			InitializeComponent();
			Initialize();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

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

				EventLog.Username = null;

				return;
			}
			else
			{
				userSearchTextBox.Font = Infrastructure.Utility.CenturyGothicFont(10);
				userSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

				EventLog.Username = userSearchTextBox.Text;

				if (GetUserEventLog(EventLog))
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
			PrintEventLog();
		}
		#endregion /PrintButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founcitons

		#region GetEventLog
		/// <summary>
		/// بارگزاری لیست فعالیت کاربران
		/// </summary>
		private void GetEventLog()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.EventLog> listEventLogs = new System.Collections.Generic.List<Models.EventLog>();

				listEventLogs =
					dataBaseContext.EventLogs
					.OrderBy(current => current.Id)
					.ToList();

				if (listEventLogs.Count == 0)
				{
					return;
				}
				else
				{
					listEventLogDataGridView.DataSource = listEventLogs;
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
		#endregion /GetEventLog

		#region GetUserEventLog
		/// <summary>
		/// جستجوی نام کاربر جهت
		/// نمایش فعالیت های صورت گرفته
		/// </summary>
		/// <param name="_loginHistory"></param>
		private bool GetUserEventLog(Models.EventLog _eventLog)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.EventLog> listEventLogs = null;

				if (string.IsNullOrEmpty(_eventLog.Username))
				{
					listEventLogs =
						dataBaseContext.EventLogs
						.OrderBy(current => current.Id)
						.ToList();

					listEventLogDataGridView.DataSource = listEventLogs;

					return false;
				}
				else
				{
					listEventLogs =
						dataBaseContext.EventLogs
						.Where(current => current.Username.Contains(_eventLog.Username))
						.OrderByDescending(current => current.Event_Date)
						.ToList();

					if (listEventLogs == null)
					{
						listEventLogDataGridView.DataSource = null;
						return false;
					}
					else
					{
						listEventLogDataGridView.DataSource = listEventLogs;
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
		#endregion /GetUserEventLog

		#region Initialize
		/// <summary>
		/// تنظمیات ورود اولیه
		/// </summary>
		private void Initialize()
		{
			GetEventLog();
		}
		#endregion /Initialize

		#region PrintEventLog
		/// <summary>
		/// چاپ گزارش فعالیت کاربران
		/// </summary>
		private void PrintEventLog()
		{
			try
			{
				System.Collections.Generic.List<EventItem> listEventReportItems = new System.Collections.Generic.List<EventItem>();

				foreach (System.Windows.Forms.DataGridViewRow rows in listEventLogDataGridView.Rows)
				{
					EventItem _eventItemReportItems = new EventItem
					{
						Id = int.Parse(rows.Cells[0].Value.ToString()),
						Full_Name = rows.Cells[1].Value.ToString(),
						Description = rows.Cells[2].Value.ToString(),
						Event_Date = rows.Cells[3].Value.ToString(),
						Event_Time = rows.Cells[4].Value.ToString(),
					};
					listEventReportItems.Add(_eventItemReportItems);
				}

				Stimulsoft.Report.StiReport printInvoice = new Stimulsoft.Report.StiReport();

				printInvoice.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\EventLogReport.mrt");
				printInvoice.RegBusinessObject("BillSale", listEventReportItems);

				(printInvoice.GetComponentByName("dateOfPrintTextBox") as Stimulsoft.Report.Components.StiText).Text = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} - {Infrastructure.Utility.ShowTime()}";
				(printInvoice.GetComponentByName("usernameTextBox") as Stimulsoft.Report.Components.StiText).Text = userSearchTextBox.Text;
				(printInvoice.GetComponentByName("fullNameTextBox") as Stimulsoft.Report.Components.StiText).Text = listEventLogDataGridView.Rows[0].Cells[2].Value.ToString();

				printInvoice.Render(true);
				PrintLogHistoryForm.listLogHistoryStiRibbonViewerControl.Report = printInvoice;
				PrintLogHistoryForm.ShowDialog();
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /PrintEventLog

		#endregion /Founcitons
	}
}

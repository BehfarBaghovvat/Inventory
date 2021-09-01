using System.Linq;
using static Inventory_Forms.BillBuyReportForm;

namespace Financial_Form
{
	public partial class SafeBoxForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Layers		

		private Models.CapitalFund _capitalFund;
		public Models.CapitalFund CapitalFund
		{
			get
			{
				if (_capitalFund == null)
				{
					_capitalFund =
						new Models.CapitalFund();
				}
				return _capitalFund;
			}
			set
			{
				_capitalFund = value;
			}
		}

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

		#endregion /Layers



		public decimal? Amount { get; set; }
		public decimal? OldCash { get; set; }
		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public SafeBoxForm()
		{
			InitializeComponent();
			Initialize();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region SafeBoxForm_Load
		private void SafeBoxForm_Load(object sender, System.EventArgs e)
		{
			LoadingFund();
		}
		#endregion /SafeBoxForm_Load

		#region EntryFuneTextBox_Enter
		private void EntryFuneTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			entryFuneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

			entryFuneTextBox.Text = "0 تومان";

			entryFuneTextBox.Select(0, entryFuneTextBox.Text.Length - 6);

			if (string.IsNullOrWhiteSpace(entryFuneTextBox.Text))
			{
				CapitalFund.Capital_Fund = null;
				Amount = null;
			}
			else if (entryFuneTextBox.Text.Contains("تومان"))
			{
				return;
			}
		}
		#endregion /EntryFuneTextBox_Enter

		#region EntryFuneTextBox_KeyPress
		private void EntryFuneTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /EntryFuneTextBox_KeyPress

		#region EntryFuneTextBox_Leave
		private void EntryFuneTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(entryFuneTextBox.Text) ||
			   string.Compare(entryFuneTextBox.Text, "0 تومان") == 0 ||
			   string.Compare(entryFuneTextBox.Text, " تومان") == 0 ||
			   string.Compare(entryFuneTextBox.Text, "تومان") == 0 ||
			   string.Compare(entryFuneTextBox.Text, "توما") == 0 ||
			   string.Compare(entryFuneTextBox.Text, "توم") == 0 ||
			   string.Compare(entryFuneTextBox.Text, "تو") == 0 ||
			   string.Compare(entryFuneTextBox.Text, "ت") == 0)
			{
				acceptButton.Enabled = false;
				entryFuneTextBox.Text = "0 تومان";
				CapitalFund.Capital_Fund = null;
				Amount = null;
				return;
			}
			else
			{
				Amount = decimal.Parse(entryFuneTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				entryFuneTextBox.Text = $"{Amount:#,0} تومان";
				CapitalFund.Capital_Fund = $"{Amount:#,0} تومان";
			}
		}
		#endregion /EntryFuneTextBox_Leave

		#region EntryFuneTextBox_TextChange
		private void EntryFuneTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(entryFuneTextBox.Text) ||
				string.Compare(entryFuneTextBox.Text, "0 تومان") == 0 ||
				string.Compare(entryFuneTextBox.Text, " تومان") == 0 ||
				string.Compare(entryFuneTextBox.Text, "تومان") == 0 ||
				string.Compare(entryFuneTextBox.Text, "توما") == 0 ||
				string.Compare(entryFuneTextBox.Text, "توم") == 0 ||
				string.Compare(entryFuneTextBox.Text, "تو") == 0 ||
				string.Compare(entryFuneTextBox.Text, "ت") == 0)
			{
				acceptButton.Enabled = false;
				CapitalFund.Capital_Fund = null;
				Amount = null;
				return;
			}
			else
			{
				acceptButton.Enabled = true;
			}
		}
		#endregion /EntryFuneTextBox_TextChange

		#region AcceptButton_Click
		private void AcceptButton_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(entryFuneTextBox.Text))
			{
				return;
			}
			else
			{
				if (SetInCapitalFund(CapitalFund, OldCash))
				{
					AllClear();
					Infrastructure.Utility.WindowsNotification(message: "مبلغ واریز شد.", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				}
				else
				{
					Infrastructure.Utility.WindowsNotification(message: $"{Inventory.Properties.Resources.Operation_Defect}", caption: Infrastructure.PopupNotificationForm.Caption.خطا);
				}
			}
			
		}
		#endregion /AcceptButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Function

		#region AllClear
		/// <summary>
		/// پاک کردن تمام محتوای متغییرها و کنترلها
		/// </summary>
		private void AllClear()
		{
			Amount = null;
			CapitalFund = null;
			EventLog = null;
			entryFuneTextBox.Clear();
		}
		#endregion /AllClear

		#region Initialize
		/// <summary>
		/// مقدار دهی اولیه
		/// </summary>
		private void Initialize()
		{
			OldCash = LoadingFund();
			funeLabel.Text = $"{OldCash:#,0} تومان";
		}
		#endregion /Initialize

		#region LoadingFund
		/// <summary>
		/// بارگزاری موجودی صندوق
		/// </summary>
		/// <returns></returns>
		private long LoadingFund()
		{
			long fund;
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.FirstOrDefault();

				if (capitalFund == null)
				{
					fund = 0;

					return fund;
				}
				else
				{
					fund = long.Parse(capitalFund.Capital_Fund
						.Replace("تومان", string.Empty)
						.Replace(",", string.Empty)
						.Trim());

					return fund;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
				return 0;
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
		#endregion /LoadingFund

		#region SetInCapitalFund
		/// <summary>
		/// واریز کردن مبلغ وارد شده توسط کاربر به صندوق
		/// </summary>
		/// <param name="_capitalFund"></param>
		/// <param name="_oldCahsh"></param>
		/// <returns></returns>
		private bool SetInCapitalFund(Models.CapitalFund _capitalFund, decimal? _oldCahsh)
		{
			decimal? _newCahsh;
			decimal _amount = long.Parse(_capitalFund.Capital_Fund
				.Replace("تومان", string.Empty)
				.Replace(",", string.Empty)
				.Trim());

			_newCahsh = _amount + _oldCahsh;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.FirstOrDefault();
				if (capitalFund == null)
				{
					_newCahsh = 0;
					capitalFund.Capital_Fund = $"{_newCahsh} تومان";
				}
				else
				{
					capitalFund.Capital_Fund = $"{_newCahsh:#,0} تومان";
				}
				
				dataBaseContext.SaveChanges();

				OldCash = _newCahsh;
				funeLabel.Text =  $"{_newCahsh:#,0} تومان";
				Inventory.Program.MainForm.fundsNotificationTextBox.Text = $"{_newCahsh:#,0} تومان";



				#region -----------------------------------------     Save Event Log     -----------------------------------------
				if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
				{
					EventLog.Username = Inventory.Program.UserAuthentication.Username;
					EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
					EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
					EventLog.Description = $"واریز مبلغ {_capitalFund.Capital_Fund} به صندوق، موجودی صندوق {_newCahsh:#,0} تومان می باشد ";
					Infrastructure.Utility.EventLog(EventLog);
				}

				#endregion /-----------------------------------------     Save Event Log     -----------------------------------------

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
		#endregion /SetInCapitalFund

		#endregion /Function
	}
}

using Models;
using System.Linq;

namespace Financial_Form
{
	public partial class AncillaryCostsForm : Infrastructure.EmptyForm
	{
		//--------------------------------------------------------------------------------------------------    Properties
		#region Properties
		public int? AmountPayment { get; set; }

		private Models.AncillaryCosts _ancillaryCosts = null;
		public Models.AncillaryCosts AncillaryCosts
		{
			get
			{
				if (_ancillaryCosts == null)
				{
					_ancillaryCosts =
						new AncillaryCosts();
				};
				return _ancillaryCosts;
			}
			set
			{
				_ancillaryCosts = value;
			}
		}
		public Models.CapitalFund CapitalFund { get; set; }
		public long CapitalFundLong { get; set; }

		private Models.EventLog _eventLog;
		public Models.EventLog EventLog
		{
			get
			{
				if (_eventLog == null)
				{
					_eventLog =
						new EventLog();
				}
				return _eventLog;
			}
			set
			{
				_eventLog = value;
			}
		}

		#endregion /Properties

		//--------------------------------------------------------------------------------------------------    Constracture
		public AncillaryCostsForm()
		{
			InitializeComponent();
			CapitalFundLong = LoadFund();
		}

		//--------------------------------------------------------------------------------------------------    Envent Controls

		#region AncillaryCostsForm_Load
		private void AncillaryCostsForm_Load(object sender, System.EventArgs e)
		{

		}
		#endregion /AncillaryCostsForm_Load

		#region AmountPaymentTextBox_Enter
		private void AmountPaymentTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			amountPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			amountPaymentTextBox.Text = "0 تومان";

			amountPaymentTextBox.Select(0, amountPaymentTextBox.Text.Length - 6);

			if (string.IsNullOrWhiteSpace(amountPaymentTextBox.Text))
			{
				AncillaryCosts.Amount_Payment = null;
				AmountPayment = null;
			}
			else if (amountPaymentTextBox.Text.Contains("تومان"))
			{
				return;
			}
		}
		#endregion /AmountPaymentTextBox_Enter

		#region AmountPaymentTextBox_KeyPress
		private void AmountPaymentTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /AmountPaymentTextBox_KeyPress

		#region AmountPaymentTextBox_Leave
		private void AmountPaymentTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(amountPaymentTextBox.Text) ||
			   string.Compare(amountPaymentTextBox.Text, "0 تومان") == 0 ||
			   string.Compare(amountPaymentTextBox.Text, " تومان") == 0 ||
			   string.Compare(amountPaymentTextBox.Text, "تومان") == 0 ||
			   string.Compare(amountPaymentTextBox.Text, "توما") == 0 ||
			   string.Compare(amountPaymentTextBox.Text, "توم") == 0 ||
			   string.Compare(amountPaymentTextBox.Text, "تو") == 0 ||
			   string.Compare(amountPaymentTextBox.Text, "ت") == 0)
			{
				amountPaymentTextBox.Clear();
				AncillaryCosts.Amount_Payment = null;
				amountPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				AmountPayment = null;
				return;
			}
			else
			{
				AmountPayment = int.Parse(amountPaymentTextBox.Text.Replace("تومان", string.Empty)
					.Replace(",", string.Empty).Trim());
				amountPaymentTextBox.Text = $"{AmountPayment:#,0} تومان";
				AncillaryCosts.Amount_Payment = $"{AmountPayment:#,0} تومان";
			}
		}
		#endregion /AmountPaymentTextBox_Leave

		#region AmountPaymentTextBox_TextChange
		private void AmountPaymentTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(amountPaymentTextBox.Text) ||
				string.Compare(amountPaymentTextBox.Text, "0 تومان") == 0 ||
				string.Compare(amountPaymentTextBox.Text, " تومان") == 0 ||
				string.Compare(amountPaymentTextBox.Text, "تومان") == 0 ||
				string.Compare(amountPaymentTextBox.Text, "توما") == 0 ||
				string.Compare(amountPaymentTextBox.Text, "توم") == 0 ||
				string.Compare(amountPaymentTextBox.Text, "تو") == 0 ||
				string.Compare(amountPaymentTextBox.Text, "ت") == 0)
			{
				AncillaryCosts.Amount_Payment = null;
				AmountPayment = null;
				return;
			}
		}
		#endregion /AmountPaymentTextBox_TextChange

		#region ListExpensesComboBox_SelectedIndexChanged
		private void ListExpensesComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (listExpensesComboBox.SelectedIndex < 1)
			{
				AncillaryCosts.Cost_Name = null;
				listExpensesComboBox.ForeColor = System.Drawing.Color.Gray;
				return;
			}
			else
			{
				listExpensesComboBox.ForeColor = System.Drawing.Color.White;
				AncillaryCosts.Cost_Name = listExpensesComboBox.SelectedItem.ToString();
				System.Windows.Forms.MessageBox.Show($"{AncillaryCosts.Cost_Name}");
			}
		}
		#endregion /ListExpensesComboBox_SelectedIndexChanged

		private void PaymentButton_Click(object sender, System.EventArgs e)
		{
			if (ValidationData(AncillaryCosts))
			{
				if (SetDataInDatabase(AncillaryCosts))
				{
					PaymentCost(AmountPayment, CapitalFundLong);
					SetEventLog(AncillaryCosts);

					Infrastructure.Utility.WindowsNotification
						($"{Inventory.Properties.Resources.Complete_Operation}",
						Infrastructure.PopupNotificationForm.Caption.موفقیت);
				}
			}
			else
			{
				Infrastructure.Utility.WindowsNotification
						($"{Inventory.Properties.Resources.Operation_Defect}",
						Infrastructure.PopupNotificationForm.Caption.خطا);
				return;
			}
		}


		//--------------------------------------------------------------------------------------------------    Private Methods

		#region SetEventLog
		private void SetEventLog(Models.AncillaryCosts _ancillaryCosts)
		{
			DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext = 
					new DataBaseContext();

				Models.EventLog eventLog =
					dataBaseContext.EventLogs
					.FirstOrDefault();

				eventLog =
					new EventLog()
					{
						Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}",
						Event_Time = $"{Infrastructure.Utility.ShowTime()}",
						Description = $"مبلغ {_ancillaryCosts.Amount_Payment} بابت  {_ancillaryCosts.Cost_Name} پرداخت گردید",
						Full_Name = Inventory.Program.UserAuthentication.Full_Name,
						Username = Inventory.Program.UserAuthentication.Username,
					};

				dataBaseContext.EventLogs.Add(eventLog);
				dataBaseContext.SaveChanges();
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
		#endregion /SetEventLog

		#region PaymentCost
		private void PaymentCost(int? _amountPayment, long? _capitalFund)
		{
			_capitalFund -= _amountPayment;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.FirstOrDefault();

				capitalFund =
					new CapitalFund()
					{
						Capital_Fund = $"{_capitalFund:#,0} تومان",
					};

				dataBaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				if (dataBaseContext!= null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /PaymentCost

		#region LoadFund
		private long LoadFund()
		{
			long _capitalFund;
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.FirstOrDefault();
				if (capitalFund != null)
					return _capitalFund = long.Parse
						(capitalFund.Capital_Fund.Replace("تومان", string.Empty)
						.Replace(",", string.Empty).Trim());
				else
					return 0;
			}
			catch (System.Exception ex)
			{
				Mbb.Windows.Forms.Utility.ExceptionShow(ex);
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
		#endregion /LoadFund

		#region SetDataInDatabase
		private bool SetDataInDatabase(Models.AncillaryCosts _ancillaryCosts)
		{

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new DataBaseContext();

				Models.AncillaryCosts ancillaryCosts =
					dataBaseContext.AncillaryCosts
					.FirstOrDefault();

				ancillaryCosts =
					new AncillaryCosts()
					{
						Name_Payer = Inventory.Program.UserAuthentication.Full_Name,
						Cost_Name = _ancillaryCosts.Cost_Name,
						Amount_Payment = _ancillaryCosts.Amount_Payment,
						Registration_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}",
						Registration_Time = $"{Infrastructure.Utility.ShowTime()}",
					};

				dataBaseContext.AncillaryCosts.Add(ancillaryCosts);
				dataBaseContext.SaveChanges();
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
		#endregion /SetDataInDatabase

		#region ValidationData
		private bool ValidationData(Models.AncillaryCosts _ancillaryCosts)
		{
			string _errorMessage = null;
			if (string.IsNullOrEmpty(_ancillaryCosts.Amount_Payment))
			{
				_errorMessage = "لطفا مبلغ هزینه شده را وارد نمایید.";
			}
			if (string.IsNullOrEmpty(_ancillaryCosts.Cost_Name))
			{
				if (!string.IsNullOrEmpty(_errorMessage))
				{
					_errorMessage +=
						System.Environment.NewLine;
				}
				_errorMessage += "لطفا نام هزینه را قید بفرمایید";
			}

			if (!string.IsNullOrEmpty(_errorMessage))
			{
				if (string.IsNullOrEmpty(_ancillaryCosts.Amount_Payment))
				{
					amountPaymentTextBox.Focus();
				}
				else if (string.IsNullOrEmpty(_ancillaryCosts.Cost_Name))
				{
					listExpensesComboBox.Focus();
				}
				return false;
			}
			else
			{
				return true;
			}
		}
		#endregion /ValidationData
	}
}

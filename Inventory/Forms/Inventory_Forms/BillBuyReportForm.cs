using System.Linq;

namespace Inventory_Forms
{
	public partial class BillBuyReportForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Layer

		/// <summary>
		/// ساخت کلاس حسابرسی
		/// </summary>
		public class AuditItem
		{
			public decimal Amount
			{
				get; set;
			}
			public decimal Amount_Paid
			{
				get; set;
			}
			public decimal Capital_Fund
			{
				get; set;
			}
			public string Carrier_Name
			{
				get; set;
			}
			public Models.AccountsPayment.FinantialSituationAccountPaymetn FinantialSituation
			{
				get; set;
			}
			public string InvoiceSerialNumber
			{
				get; set;
			}
			public decimal Total_Sum_Price
			{
				get; set;
			}
			public string Recipient_Name
			{
				get; set;
			}
			public string Register_Date
			{
				get; set;
			}
			public string Register_Time
			{
				get; set;
			}
			public decimal Amount_Remaining
			{
				get; set;
			}
			public string Sender_Name
			{
				get; set;
			}
			public Models.PurchaseInvoice.PurchasePaymentType Purchase_Payment_Type
			{
				get; set;
			}
		}

		/// <summary>
		/// ساخت کلاس صورت حساب
		/// </summary>
		private class Bill
		{
			public string Product_Name
			{
				get; set;
			}
			public int? Product_Quantity
			{
				get; set;
			}
			public string Product_Unit
			{
				get; set;
			}
			public string Product_Price
			{
				get; set;
			}
			public string Total_Amount
			{
				get; set;
			}
		}

		private Inventory.MainForm _mainForm;
		public Inventory.MainForm MainForm
		{
			get
			{
				if (_mainForm == null || _mainForm.IsDisposed == true)
				{
					_mainForm =
						new Inventory.MainForm();
				}
				return _mainForm;
			}
			set
			{
				_mainForm = value;
			}
		}

		private static AuditItem auditItem;

		public ProductBuyForm MyProductBuyForm
		{
			get; set;
		}

		private PrintReportForm _printReportForm;
		public PrintReportForm PrintReportForm
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
		}

		public bool Purchase_Operations
		{
			get; set;
		}

		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public BillBuyReportForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region BillBuyReportForm_Load
		private void BillBuyReportForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /BillBuyReportForm_Load

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			if (Purchase_Operations)
			{
				AllClear();
				closeFormTimer.Start();
			}
			else
			{
				if (productListDataGridView.Rows.Count > 0)
				{
					if (Mbb.Windows.Forms.MessageBox.Show(
						text: "آیا فاکتور جاری حذف گردد؟",
						caption: "حذف فاکتور",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
						button: Mbb.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
					{
						AllClear();
						closeFormTimer.Start();
					}
					else
					{
						closeFormTimer.Start();
					}
				}
				else
				{
					closeFormTimer.Start();
				}
			}
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizeButton_Click

		#region PaymentCashLabel_Click
		private void PaymentCashLabel_Click(object sender, System.EventArgs e)
		{
			paymentCashRadioButton.Checked = true;
		}
		#endregion /PaymentCashLabel_Click

		#region PaymentCashRadioButton_CheckedChanged
		private void PaymentCashRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			amountPaidTextBox.ReadOnly = false;
			auditItem.Purchase_Payment_Type = Models.PurchaseInvoice.PurchasePaymentType.نقد;
		}
		#endregion /PaymentCashRadioButton_CheckedChanged

		#region PaymentChequeLabel_Click
		private void PaymentChequeLabel_Click(object sender, System.EventArgs e)
		{
			paymentChequeRadioButton.Checked = true;
		}
		#endregion /PaymentChequeLabel_Click

		#region PaymentChequeRadioButton_CheckedChanged
		private void PaymentChequeRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			amountPaidTextBox.ReadOnly = true;
			auditItem.Purchase_Payment_Type = Models.PurchaseInvoice.PurchasePaymentType.چک;
		}
		#endregion /PaymentChequeRadioButton_CheckedChanged 

		#region PrintButton_Click
		private void PrintButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Collections.Generic.List<Bill> billBuyReportsList = new System.Collections.Generic.List<Bill>();

				foreach (System.Windows.Forms.DataGridViewRow rows in productListDataGridView.Rows)
				{
					Bill billBuy = new Bill
					{
						Product_Name = rows.Cells[0].Value.ToString(),
						Product_Price = rows.Cells[1].Value.ToString(),
						Product_Quantity = int.Parse(rows.Cells[2].Value.ToString()),
						Product_Unit = rows.Cells[3].Value.ToString(),
						Total_Amount = rows.Cells[4].Value.ToString(),
					};
					billBuyReportsList.Add(billBuy);
				}
				string receipDate = $"{Infrastructure.Utility.ShowTime()} - {Infrastructure.Utility.PersianCalendar(dateTime: System.DateTime.Now)}";
				Stimulsoft.Report.StiReport reportReceip = new Stimulsoft.Report.StiReport();

				reportReceip.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\BillBuyReport.mrt");
				reportReceip.RegBusinessObject("BillBuy", billBuyReportsList);

				(reportReceip.GetComponentByName("dateOfPrintTextBox") as Stimulsoft.Report.Components.StiText).Text = receipDate;
				(reportReceip.GetComponentByName("invoiceSerialNumberTextBox") as Stimulsoft.Report.Components.StiText).Text = invoiceSerialNumberTextBox.Text;
				(reportReceip.GetComponentByName("transferNameTextBox") as Stimulsoft.Report.Components.StiText).Text = Inventory.Program.UserAuthentication.Full_Name;
				(reportReceip.GetComponentByName("senderNameTextBox") as Stimulsoft.Report.Components.StiText).Text = senderNameTextBox.Text;
				(reportReceip.GetComponentByName("carrierNameTextBox") as Stimulsoft.Report.Components.StiText).Text = carrierNameTextBox.Text;
				(reportReceip.GetComponentByName("totalSumPriceTextBox") as Stimulsoft.Report.Components.StiText).Text = totalSumPriceTextBox.Text;
				(reportReceip.GetComponentByName("amountPaymentTextBox") as Stimulsoft.Report.Components.StiText).Text = amountPaidTextBox.Text;
				(reportReceip.GetComponentByName("remainingAmountTextBox") as Stimulsoft.Report.Components.StiText).Text = remainingAmountTextBox.Text;

				reportReceip.Render();
				PrintReportForm.printReportStiViewerControl.Report = null;
				PrintReportForm.printReportStiViewerControl.Report = reportReceip;
				PrintReportForm.ShowDialog();
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /PrintButton_Click

		#region PaymentButton_Click
		private void PaymentButton_Click(object sender, System.EventArgs e)
		{
			Payment(auditItem);
		}
		#endregion /PaymentButton_Click

		#region TotalSumPriceTextBox_TextChanged
		private void TotalSumPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalSumPriceLable.Text, "0 تومان") == 0)
			{
				auditItem.Total_Sum_Price = 0;
				auditItem.Amount_Remaining = 0;
				remainingAmountTextBox.Text = $"{auditItem.Amount_Remaining:#,0} تومان";
				return;
			}
			else
			{
				auditItem.Total_Sum_Price =
					decimal.Parse(totalSumPriceTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

				auditItem.Amount_Remaining = auditItem.Amount_Paid - auditItem.Total_Sum_Price;
				remainingAmountTextBox.Text = $"{auditItem.Amount_Remaining:#,0} تومان";
			}
		}
		#endregion /TotalSumPriceTextBox_TextChanged

		#region AmountPaidTextBox_Enter
		private void AmountPaidTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (string.IsNullOrWhiteSpace(amountPaidTextBox.Text))
			{
				auditItem.Amount_Paid = 0;
			}
			else if (amountPaidTextBox.Text.Contains("تومان"))
			{
				return;
			}
		}
		#endregion /AmountPaidTextBox_Enter

		#region AmountPaidTextBox_KeyPress
		private void AmountPaidTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /AmountPaidTextBox_KeyPress

		#region AmountPaidTextBox_Leave
		private void AmountPaidTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(amountPaidTextBox.Text) || amountPaidTextBox.Text.Length <= 7)
			{
				amountPaidTextBox.Text = "0 تومان";
				auditItem.Amount_Paid = 0;
				return;
			}
			else
			{
				auditItem.Amount_Paid = decimal.Parse(amountPaidTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				amountPaidTextBox.Text = $"{auditItem.Amount_Paid:#,0} تومان";
			}
		}
		#endregion /AmountPaidTextBox_Leave

		#region AmountPaidTextBox_TextChange
		private void AmountPaidTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(amountPaidTextBox.Text))
			{
				paymentButton.Enabled = false;
				auditItem.Amount_Paid = 0;
				auditItem.Amount_Remaining = auditItem.Amount_Paid - auditItem.Total_Sum_Price;
				remainingAmountTextBox.Text = $"{auditItem.Amount_Remaining:#,0} تومان";
				return;
			}
			else if (amountPaidTextBox.Text.Length <= 7)
			{
				paymentButton.Enabled = false;
				auditItem.Amount_Paid = 0;
				auditItem.Amount_Remaining = auditItem.Amount_Paid - auditItem.Total_Sum_Price;
				remainingAmountTextBox.Text = $"{auditItem.Amount_Remaining:#,0} تومان";

				if (auditItem.Total_Sum_Price == 0)
				{
					remainingAmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					remainingAmountTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					remainingAmountTextBox.Text = $"0 تومان";
					return;
				}
				else
				{
					remainingAmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					remainingAmountTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					remainingAmountTextBox.Text = $"{auditItem.Amount_Remaining:#,0} تومان";
				}
				return;
			}
			else
			{
				paymentButton.Enabled = true;
				auditItem.Amount_Paid =
					decimal.Parse(amountPaidTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

				auditItem.Amount_Remaining = auditItem.Amount_Paid - auditItem.Total_Sum_Price;
				if (auditItem.Total_Sum_Price == 0)
				{
					remainingAmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					remainingAmountTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					remainingAmountTextBox.Text = $"0 تومان";
					return;
				}
				else
				{
					remainingAmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
					remainingAmountTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					remainingAmountTextBox.Text = $"{auditItem.Amount_Remaining:#,0} تومان";
				}
			}
		}
		#endregion /AmountPaidTextBox_TextChange

		#region RemainingAmountTextBox_TextChanged
		private void RemainingAmountTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (auditItem.Amount_Remaining < 0)
			{
				auditItem.FinantialSituation = Models.AccountsPayment.FinantialSituationAccountPaymetn.بدهکار;
			}
			else if (auditItem.Amount_Remaining == 0)
			{
				auditItem.FinantialSituation = Models.AccountsPayment.FinantialSituationAccountPaymetn.تسویه;
			}
			else
			{
				auditItem.FinantialSituation = Models.AccountsPayment.FinantialSituationAccountPaymetn.طلبکار;
			}
		}
		#endregion /RemainingAmountTextBox_TextChanged

		#region CloseFormTimer_Tick
		private void CloseFormTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.1;
			if (this.Opacity <= 0.0)
			{
				closeFormTimer.Stop();
				this.Dispose();
			}
		}
		#endregion /CloseFormTimer_Tick



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Function

		#region AllClear
		private void AllClear()
		{
			MyProductBuyForm.RemoveBill();
			totalSumPriceTextBox.Text = "0 تومان";
			amountPaidTextBox.Clear();
			remainingAmountTextBox.Text = "0 تومان";
			productListDataGridView.Rows.Clear();
			auditItem = null;

		}
		#endregion /AllClear

		#region CalculatePurchaseAmount
		/// <summary>
		/// محاسبه مبلغ خرید
		/// </summary>
		public void CalculatePurchaseAmount()
		{
			if (productListDataGridView.RowCount >= 1)
			{
				foreach (System.Windows.Forms.DataGridViewRow row in productListDataGridView.Rows)
				{
					auditItem.Total_Sum_Price +=
						int.Parse(row.Cells[4].Value.ToString()
						.Replace("تومان", string.Empty)
						.Replace(",", string.Empty)
						.Trim());

					totalSumPriceTextBox.Text = $"{auditItem.Total_Sum_Price:#,0} تومان";
					remainingAmountTextBox.Text = $"{auditItem.Total_Sum_Price:#,0} تومان";
				}
			}
			else
			{
				return;
			}
		}
		#endregion /CalculatePurchaseAmount	

		#region GetCapitalFund
		/// <summary>
		/// به روز رسانی و بارگزاری صندوق سرمایه
		/// </summary>
		/// <returns></returns>
		private decimal GetCapitalFund()
		{
			decimal capital_Fund;
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
					capital_Fund = 0;
				}
				else
				{
					if (string.IsNullOrEmpty(capitalFund.Capital_Fund))
					{
						capital_Fund = 0;
					}
					else if (capitalFund.Capital_Fund.Length <= 9)
					{
						capital_Fund = decimal.Parse(capitalFund.Capital_Fund.Replace("تومان", string.Empty).Trim());

						Inventory.Program.MainForm.cashCapitalTextBox.Text = $"{capital_Fund} تومان ";
					}
					else
					{
						capital_Fund = decimal.Parse(capitalFund.Capital_Fund.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						Inventory.Program.MainForm.cashCapitalTextBox.Text = $"{capital_Fund:#,0} تومان ";
					}
				}

				return capital_Fund;

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
		#endregion /GetCapitalFund

		#region GetInvoiceSerialNumber
		/// <summary>
		/// ساخت شماره فاکتور
		/// </summary>
		/// <returns></returns>
		private string GetInvoiceSerialNumber()
		{
			string getSerial = null,
				serialNumber = null;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				do
				{
					serialNumber = Infrastructure.Utility.GeneratInvoiceSerialNumber(int.Parse("2"));
					dataBaseContext =
					new Models.DataBaseContext();

					Models.ServiceInvoice invoiceSerialNumber =
						dataBaseContext.ServiceInvoices
						.Where(current => string.Compare(current.Invoice_Serial_Number, serialNumber) == 0)
						.FirstOrDefault();
					if (invoiceSerialNumber == null)
					{
						getSerial = serialNumber;
					}
					else
					{
						serialNumber = null;
					}
				} while (string.IsNullOrEmpty(serialNumber));

				return getSerial;
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
		#endregion /GetInvoiceSerialNumber

		#region Harvest
		/// <summary>
		/// برداشت از صندوق
		/// </summary>
		/// <param name="_auditItem"></param>
		/// <returns></returns>
		private bool Harvest(AuditItem _auditItem)
		{
			#region Validation
			if (_auditItem.Capital_Fund < _auditItem.Amount_Paid)
			{
				Mbb.Windows.Forms.MessageBox.Show
					(text: Inventory.Properties.Resources.Financial_Error,
					caption: "خطای موجودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				return false;
			}
			else
			{
				_auditItem.Capital_Fund -= _auditItem.Amount_Paid;
			}
			#endregion /Validation

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.FirstOrDefault();

				capitalFund.Capital_Fund = $"{_auditItem.Capital_Fund: #,0} تومان";

				dataBaseContext.SaveChanges();

				auditItem.Capital_Fund = GetCapitalFund();

				Inventory.Program.MainForm.GetNon_CashCapital();

				Inventory.Program.MainForm.GetTotalCapital();

				#region -----------------------------------------     Save Event Log     -----------------------------------------
				if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
				{
					EventLog.Username = Inventory.Program.UserAuthentication.Username;
					EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
					EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
					if (_auditItem.Amount_Remaining < 1000)
					{
						EventLog.Description =
						$"پرداخت هزینه به مبلغ {_auditItem.Amount_Paid: #,0}" +
						$" تومان و باقیمانده {_auditItem.Amount_Remaining} تومان";
					}
					else
					{
						EventLog.Description =
						$"پرداخت هزینه به مبلغ {_auditItem.Amount_Paid: #,0}" +
						$" تومان و باقیمانده {_auditItem.Amount_Remaining:#,0} تومان";
					}
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
		#endregion /Harvest

		#region Initialize
		/// <summary>
		/// تنظیم ورودی اولیه
		/// </summary>
		private void Initialize()
		{
			auditItem =
				new AuditItem();
			Purchase_Operations = false;
			dateOfPrintTextBox.Text = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} - {Infrastructure.Utility.ShowTime()}";
			auditItem.Register_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
			auditItem.Register_Time = $"{Infrastructure.Utility.ShowTime()}";
			auditItem.Capital_Fund = GetCapitalFund();

			recipientNameTextBox.Text = Inventory.Program.UserAuthentication.Full_Name;
			auditItem.Recipient_Name = Inventory.Program.UserAuthentication.Full_Name;
			invoiceSerialNumberTextBox.Text = auditItem.InvoiceSerialNumber = GetInvoiceSerialNumber();

			auditItem.Carrier_Name = carrierNameTextBox.Text;
			auditItem.Sender_Name = senderNameTextBox.Text;

			CalculatePurchaseAmount();
		}
		#endregion /Initialize

		#region Payment
		/// <summary>
		/// پرداخت فاکتور خرید کالا
		/// </summary>
		/// <param name="_auditItem"></param>
		private void Payment(AuditItem _auditItem)
		{
			if (_auditItem.Purchase_Payment_Type == Models.PurchaseInvoice.PurchasePaymentType.نقد)
			{
				if (Harvest(auditItem) && SetAccountPayable(auditItem) && SetPurchaseProduct(auditItem) && SetJournal(auditItem))
				{
					SetDailyFinancialReport(auditItem);
					MyProductBuyForm.RemoveBill();

					paymentButton.Enabled = false;

					Infrastructure.Utility.WindowsNotification(
						message: "عملیات ثبت و پرداخت انجام گردید.",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
					Purchase_Operations = true;
				}
				else
				{
					Purchase_Operations = false;
					return;
				}
			}
			else if (_auditItem.Purchase_Payment_Type == Models.PurchaseInvoice.PurchasePaymentType.چک)
			{
				if (SetAccountPayable(auditItem) && SetPurchaseProduct(auditItem) && SetJournal(auditItem))
				{
					SetDailyFinancialReport(auditItem);
					MyProductBuyForm.RemoveBill();

					paymentButton.Enabled = false;

					Infrastructure.Utility.WindowsNotification(
						message: "عملیات ثبت و پرداخت انجام گردید.",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
					Purchase_Operations = true;

					Mbb.Windows.Forms.MessageBox.Show(
						text: "توجه: \n بعد از انجام خرید حتما به واحد چک \n جهت صدور چک مراجعه نمایید.",
						caption: "اعلان چک",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Information, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				}
				else
				{
					Purchase_Operations = false;
					return;
				}
			}


		}
		#endregion Payment

		#region SetAccountPayable
		/// <summary>
		/// ثبت در دفتر معین
		/// </summary>
		/// <param name="auditItem"></param>
		/// <returns></returns>
		private bool SetAccountPayable(AuditItem auditItem)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.AccountsPayment accountsPayable =
					new Models.AccountsPayment
					{
						Amount_Paid = $"{auditItem.Amount_Paid:#,0} تومان",
						Amount_Payable = $"{auditItem.Total_Sum_Price:#,0} تومان",
						Amount_Remaininig = $"{auditItem.Amount_Remaining:#,0} تومان",
						Description = $"خرید کالا یا لوازم",
						Finantial_Situation = auditItem.FinantialSituation,
						Registration_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}",
						Registration_Time = $"{Infrastructure.Utility.ShowTime()}",
						Seller_Name = auditItem.Sender_Name,
					};
				dataBaseContext.AccountsPayments.Add(accountsPayable);
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
		#endregion /SetAccountPayable

		#region SetBillInDataGridView
		public void SetBillInDataGridView(System.Collections.Generic.List<ProductBuyForm.BillBuyReportItems> billList)
		{
			foreach (var item in billList)
			{
				productListDataGridView.Rows.Add
					(item.Product_Name,
					item.Product_Price,
					item.Product_Quantity.ToString(),
					item.Product_Unit,
					item.Total_Price);
			}
		}
		#endregion SetBillInDataGridView

		#region SetDailyFinancialReport
		/// <summary>
		/// تابع ثبت گزارش مالی روزانه
		/// </summary>
		/// <param name="auditItem"></param>
		private void SetDailyFinancialReport(AuditItem auditItem)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.DailyFinancialReport dailyFinancialReport =
					new Models.DailyFinancialReport()
					{
						Amounts_Paid = $"{auditItem.Amount_Paid:#,0} تومان",
						Amounts_Payment = $"{auditItem.Total_Sum_Price} تومان",
						Amounts_Received = $"0 تومان",
						Amounts_Remaining = $"{auditItem.Amount_Remaining} تومان",
						Register_Date = $"{auditItem.Register_Date}",
						Register_Time = $"{auditItem.Register_Time}",

						Year = int.Parse(auditItem.Register_Date.Substring(0, 4)),
						Month = int.Parse(auditItem.Register_Date.Substring(5, 2)),
						Day = int.Parse(auditItem.Register_Date.Substring(8, 2)),

						Hour = int.Parse(auditItem.Register_Time.Substring(0, 2)),
						Minute = int.Parse(auditItem.Register_Time.Substring(3, 2)),
						Second = int.Parse(auditItem.Register_Time.Substring(6, 2)),
					};
				dataBaseContext.DailyFinancialReports.Add(dailyFinancialReport);
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
		#endregion SetDailyFinancialReport

		#region SetPurchaseProduct
		/// <summary>
		/// ثبت خرید کالا
		/// </summary>
		/// <param name="auditItem"></param>
		/// <returns>true or false</returns>
		private bool SetPurchaseProduct(AuditItem auditItem)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				//---- ثبت در جدول فاکتور خرید کالا
				#region PurchaseInvoice
				Models.PurchaseInvoice purchaseInvoice =
					new Models.PurchaseInvoice
					{
						Carrier_Name = auditItem.Carrier_Name,
						Invoice_Serial_Numvber = auditItem.InvoiceSerialNumber,
						Purchase_Payment_Type = auditItem.Purchase_Payment_Type,
						Recipient_Name = auditItem.Recipient_Name,
						Purchase_Date = auditItem.Register_Date,
						Purchase_Time = auditItem.Register_Time,
						Sender_Name = auditItem.Sender_Name,
						Total_Sum_Price = $"{auditItem.Total_Sum_Price:#,0} تومان",
					};
				dataBaseContext.PurchaseInvoices.Add(purchaseInvoice);
				dataBaseContext.SaveChanges();
				#endregion /SetPurchaseProduct

				//---- ثبت در جدول خرید کالا
				#region ListPurchaseProduct
				foreach (System.Windows.Forms.DataGridViewRow row in productListDataGridView.Rows)
				{
					Models.ListPurchaseProduct listPurchaseProduct =
					new Models.ListPurchaseProduct()
					{
						Invoice_Serial_Numvber = auditItem.InvoiceSerialNumber,
						Product_Name = row.Cells[0].Value.ToString(),
						Product_Price = row.Cells[1].Value.ToString(),
						Product_Quantity = int.Parse(row.Cells[2].Value.ToString()),
						Product_Unit = row.Cells[3].Value.ToString(),
					};
					dataBaseContext.ListPurchaseProducts.Add(listPurchaseProduct);
					dataBaseContext.SaveChanges();
				}
				#endregion /ListPurchaseProduct

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
		#endregion /GetPurchaseProduct

		#region SetJournal
		/// <summary>
		/// ثبت اطلاعات در دفتر روزنامه
		/// </summary>
		/// <param name="_auditItem"></param>
		/// <returns>true or false</returns>
		private bool SetJournal(AuditItem _auditItem)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				Models.Journal journal =
					 new Models.Journal
					 {
						 Amount_Paid = $"{auditItem.Amount_Paid:#,0} تومان",
						 Amount_Received = $"0 تومان",
						 Description = $"خرید کالا یا لوازم",
						 Invoice_Serial_Numvber = auditItem.InvoiceSerialNumber,
						 Registration_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}",
						 Registration_Time = $"{Infrastructure.Utility.ShowTime()}",
					 };

				dataBaseContext.Journals.Add(journal);
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

		#endregion /SetJournal

		#endregion /Function
	}
}

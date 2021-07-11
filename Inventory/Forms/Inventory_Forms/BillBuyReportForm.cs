using System.Linq;

namespace Inventory_Forms
{
	public partial class BillBuyReportForm : Infrastructure.EmptyForm
	{
		#region Properties

		#region Layer
		public class AuditItem
		{
			public int Amount { get; set; }
			public int Amount_Paid { get; set; }
			public long Capital_Fund { get; set; }
			public string Carrier_Name { get; set; }
			public string InvoiceSerialNumber { get; set; }
			public int Total_Sum_Price { get; set; }
			public string Recipient_Name { get; set; }
			public string Register_Date { get; set; }
			public int Remaining_Amount { get; set; }

			public string Sender_Name { get; set; }
		}
		private class Bill
		{
			public string Product_Name { get; set; }
			public int? Product_Quantity { get; set; }
			public string Product_Unit { get; set; }
			public string Product_Price { get; set; }
			public string Total_Amount { get; set; }
		}

		private BillBuyPrintForm _billBuyPrintForm;
		public BillBuyPrintForm BillBuyPrintForm
		{
			get
			{
				if (_billBuyPrintForm == null || _billBuyPrintForm.IsDisposed == true)
				{
					_billBuyPrintForm =
						new BillBuyPrintForm();
				}
				return _billBuyPrintForm;
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
		}
		#endregion /Layer

		public static AuditItem auditItem = new AuditItem();

		public ProductBuyForm MyProductBuyForm { get; set; }
		
		#endregion /Properties

		public BillBuyReportForm()
		{
			InitializeComponent();
			Initialize();
		}

		//----------Beginning of the code!----------

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			if (productListDataGridView.Rows.Count > 0)
			{
				if (Mbb.Windows.Forms.MessageBox.Show(text: "آیا رسید جاری حذف گردد؟", caption: "حذف رسید", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
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
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizeButton_Click

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
				(reportReceip.GetComponentByName("transferNameTextBox") as Stimulsoft.Report.Components.StiText).Text = Inventory.Program.UserAuthentication.Full_Name;
				(reportReceip.GetComponentByName("senderNameTextBox") as Stimulsoft.Report.Components.StiText).Text = auditItem.Sender_Name;
				(reportReceip.GetComponentByName("carrierNameTextBox") as Stimulsoft.Report.Components.StiText).Text = auditItem.Carrier_Name;
				(reportReceip.GetComponentByName("totalSumPriceTextBox") as Stimulsoft.Report.Components.StiText).Text = totalSumPriceTextBox.Text;
				(reportReceip.GetComponentByName("amountPaymentTextBox") as Stimulsoft.Report.Components.StiText).Text = amountPaidTextBox.Text;
				(reportReceip.GetComponentByName("remainingAmountTextBox") as Stimulsoft.Report.Components.StiText).Text = remainingAmountTextBox.Text;

				reportReceip.Render();
				BillBuyPrintForm.receiptStiViewerControl.Report = reportReceip;
				BillBuyPrintForm.ShowDialog();
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
			if (Harvest(auditItem) && SetAccountPayable(auditItem) && InvoiceRegister(auditItem))
			{
				Infrastructure.Utility.WindowsNotification(message: "عملیات ثبت و پرداخت انجام گردید.", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

				auditItem.Capital_Fund = LoadingCapitalFund();
				capitalFundTextBox.Text = $"{auditItem.Capital_Fund:#,0} تومان";
				MyProductBuyForm.RemoveBill();
				paymentButton.Enabled = false;
				//if (true)     بعدا حتما به گزینه ها اضافه گردد.
				//{
				//	Capital_Fund = LoadingCapitalFund();
				//	Mbb.Windows.Forms.MessageBox.Show(text: $"موجودی صندوق \n {Capital_Fund:#,0} تومان می باشد.",
				//		caption:"گزارش",
				//		icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
				//		button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				//}
			}
			else
			{
				return;
			}
		}
		#endregion /PaymentButton_Click

		#region TotalSumPriceTextBox_TextChanged
		private void TotalSumPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{
			remainingAmountTextBox.Text = totalSumPriceTextBox.Text;
			auditItem.Total_Sum_Price = int.Parse(totalSumPriceTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
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
			if (string.IsNullOrWhiteSpace(amountPaidTextBox.Text) ||
			   string.Compare(amountPaidTextBox.Text, "0 تومان") == 0 ||
			   string.Compare(amountPaidTextBox.Text, " تومان") == 0 ||
			   string.Compare(amountPaidTextBox.Text, "تومان") == 0 ||
			   string.Compare(amountPaidTextBox.Text, "توما") == 0 ||
			   string.Compare(amountPaidTextBox.Text, "توم") == 0 ||
			   string.Compare(amountPaidTextBox.Text, "تو") == 0 ||
			   string.Compare(amountPaidTextBox.Text, "ت") == 0)
			{
				amountPaidTextBox.Text = "0 تومان";
				auditItem.Amount_Paid = 0;
				return;
			}
			else
			{
				auditItem.Amount_Paid = int.Parse(amountPaidTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				amountPaidTextBox.Text = $"{auditItem.Amount_Paid:#,0} تومان";
			}
		}
		#endregion /AmountPaidTextBox_Leave

		#region AmountPaidTextBox_TextChange
		private void AmountPaidTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(amountPaidTextBox.Text) ||
				string.Compare(amountPaidTextBox.Text, "0 تومان") == 0 ||
				string.Compare(amountPaidTextBox.Text, " تومان") == 0 ||
				string.Compare(amountPaidTextBox.Text, "تومان") == 0 ||
				string.Compare(amountPaidTextBox.Text, "توما") == 0 ||
				string.Compare(amountPaidTextBox.Text, "توم") == 0 ||
				string.Compare(amountPaidTextBox.Text, "تو") == 0 ||
				string.Compare(amountPaidTextBox.Text, "ت") == 0)
			{
				paymentButton.Enabled = false;
				auditItem.Amount_Paid = 0;
				auditItem.Remaining_Amount = auditItem.Total_Sum_Price - auditItem.Amount_Paid;
				remainingAmountTextBox.Text = $"{auditItem.Remaining_Amount:#,0} تومان";
				return;
			}
			else
			{
				paymentButton.Enabled = true;
				auditItem.Amount_Paid = int.Parse(amountPaidTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				auditItem.Remaining_Amount = auditItem.Total_Sum_Price - auditItem.Amount_Paid;
				remainingAmountTextBox.Text = $"{auditItem.Remaining_Amount:#,0} تومان";
			}
		}
		#endregion /AmountPaidTextBox_TextChange

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

		//----------End of code!----------

		#region Function

		#region AllClear
		private void AllClear()
		{
			MyProductBuyForm.RemoveBill();
			auditItem = null;

			totalSumPriceTextBox.Text = "0 تومان";
			amountPaidTextBox.Clear();
			remainingAmountTextBox.Text = "0 تومان";
			productListDataGridView.Rows.Clear();
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
						int.Parse(row.Cells[4].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					totalSumPriceTextBox.Text = $"{auditItem.Total_Sum_Price:#,0} تومان";
				}
			}
			else
			{
				return;
			}
		}
		#endregion /CalculatePurchaseAmount

		#region Harvest
		/// <summary>
		/// برداشت از صندوق
		/// </summary>
		/// <param name="auditItem"></param>
		/// <returns></returns>
		private bool Harvest(AuditItem auditItem)
		{
			#region Validation
			if (auditItem.Capital_Fund < auditItem.Amount_Paid)
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
				auditItem.Capital_Fund -= auditItem.Amount_Paid;
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

				capitalFund.Capital_Fund = $"{auditItem.Capital_Fund: #,0} تومان";
				dataBaseContext.SaveChanges();

				#region -----------------------------------------     Save Event Log     -----------------------------------------
				if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
				{
					EventLog.Username = Inventory.Program.UserAuthentication.Username;
					EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
					EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
					EventLog.Description = $"پرداخت هزینه به مبلغ {auditItem.Amount_Paid: #,0} تومان و باقیمانده {auditItem.Remaining_Amount:#,0} تومان";
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
		private void Initialize()
		{
			auditItem.Total_Sum_Price = 0;
			showGunaAnimateWindow.Interval = 200;
			showGunaAnimateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
			showGunaAnimateWindow.Start();
			dateOfPrintTextBox.Text = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} - {Infrastructure.Utility.ShowTime()}";
			auditItem.Register_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} - {Infrastructure.Utility.ShowTime()}";

			auditItem.Capital_Fund = LoadingCapitalFund();
			capitalFundTextBox.Text = $"{auditItem.Capital_Fund:#,0} تومان";

			senderNameTextBox.Text = auditItem.Sender_Name;
			recipientNameTextBox.Text = Inventory.Program.UserAuthentication.Full_Name;
			auditItem.Recipient_Name = Inventory.Program.UserAuthentication.Full_Name;
			carrierNameTextBox.Text = auditItem.Carrier_Name;

			invoiceSerialNumberTextBox.Text = SetInvoiceSerialNumber();
			auditItem.InvoiceSerialNumber = SetInvoiceSerialNumber();

		}
		#endregion /Initialize

		#region InvoiceRegister
		/// <summary>
		/// ثبت فاکتور
		/// </summary>
		/// <param name="auditItem"></param>
		/// <returns></returns>
		private bool InvoiceRegister(AuditItem auditItem)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				//---- ثبت در جدول شماره فاکتور
				#region SetInvoiceSerialNumber
				Models.InvoiceSerialNumber invoiceSerialNumber =
					new Models.InvoiceSerialNumber
					{
						Invoice_Serial_Numvber = auditItem.InvoiceSerialNumber,
						Registration_Date = auditItem.Register_Date,
					};
				dataBaseContext.InvoiceSerialNumbers.Add(invoiceSerialNumber);
				dataBaseContext.SaveChanges();
				#endregion /SetInvoiceSerialNumber

				//---- ثبت در جدول فاکتور خرید کالا
				#region SetPurchaseInvoice
				Models.PurchaseInvoice purchaseInvoice =
					new Models.PurchaseInvoice();

				foreach (System.Windows.Forms.DataGridViewRow row in productListDataGridView.Rows)
				{
					purchaseInvoice.Sender_Name = auditItem.Sender_Name;
					purchaseInvoice.Carrier_Name = auditItem.Carrier_Name;
					purchaseInvoice.Recipient_Name = auditItem.Recipient_Name;
					purchaseInvoice.Invoice_Serial_Numvber = auditItem.InvoiceSerialNumber;

					purchaseInvoice.Product_Name = row.Cells[0].Value.ToString();
					purchaseInvoice.Product_Price = row.Cells[1].Value.ToString();
					purchaseInvoice.Product_Quantity = int.Parse(row.Cells[2].Value.ToString());
					purchaseInvoice.Product_Unit = row.Cells[3].Value.ToString();
					purchaseInvoice.Total_Sum_Price = row.Cells[4].Value.ToString();
				}

				dataBaseContext.PurchaseInvoices.Add(purchaseInvoice);
				dataBaseContext.SaveChanges();

				#endregion /SetPurchaseInvoice

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
		#endregion /InvoiceRegister

		#region LoadingCapitalFund
		private long LoadingCapitalFund()
		{
			long capital_Fund;
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
					return 0;
				}
				else
				{
					capital_Fund = long.Parse(capitalFund.Capital_Fund.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					return capital_Fund;
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
		#endregion /LoadingCapitalFund

		#region SetAccountPayable
		/// <summary>
		/// ثبت در دفتر معین برداشت از صندوق
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

				Models.AccountsPayable accountsPayable =
					new Models.AccountsPayable
					{
						Amount_Paid = $"{auditItem.Amount_Paid:#,0} تومان",
						Amount_Payable = $"{auditItem.Total_Sum_Price:#,0} تومان",
						Description = string.Empty,
						Remaininig_Amount = $"{auditItem.Remaining_Amount:#,0} تومان",
						Registration_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}",
						Registration_Time = $"{Infrastructure.Utility.ShowTime()}",
						Seller_Name = auditItem.Sender_Name,
					};
				dataBaseContext.AccountsPayables.Add(accountsPayable);
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
		public void SetBillInDataGridView(System.Collections.Generic.List<ProductBuyForm.Bill> billList)
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

		#region SetInvoiceSerialNumber
		/// <summary>
		/// ساخت شماره فاکتور
		/// </summary>
		/// <returns></returns>
		private string SetInvoiceSerialNumber()
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

					Models.InvoiceSerialNumber invoiceSerialNumber =
						dataBaseContext.InvoiceSerialNumbers
						.Where(current => string.Compare(current.Invoice_Serial_Numvber, serialNumber) == 0)
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
		#endregion /SetInvoiceSerialNumber

		#endregion /Function
	}
}
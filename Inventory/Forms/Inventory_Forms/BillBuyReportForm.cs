using System.Linq;

namespace Inventory_Forms
{
	public partial class BillBuyReportForm : Infrastructure.EmptyForm
	{
		#region Properties

		#region Layer
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

		public int Amount { get; set; }
		public int Amount_Payment { get; set; }
		public long Capital_Fund { get; set; }
		public string Carrier_Name { get; set; }

		public ProductBuyForm MyProductBuyForm { get; set; }
		public int Total_Sum_Price { get; set; }
		public int Remaining_Amount { get; set; }
		public string Sender_Name { get; set; }
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
				(reportReceip.GetComponentByName("senderNameTextBox") as Stimulsoft.Report.Components.StiText).Text = Sender_Name;
				(reportReceip.GetComponentByName("carrierNameTextBox") as Stimulsoft.Report.Components.StiText).Text = Carrier_Name;
				(reportReceip.GetComponentByName("totalSumPriceTextBox") as Stimulsoft.Report.Components.StiText).Text = totalSumPriceTextBox.Text;
				(reportReceip.GetComponentByName("amountPaymentTextBox") as Stimulsoft.Report.Components.StiText).Text = amountPaymentTextBox.Text;
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
			if (Harvest(Amount_Payment) && SetAccountPayable(Amount_Payment, Total_Sum_Price, Remaining_Amount))
			{
				Infrastructure.Utility.WindowsNotification(message: "عملیات ثبت و پرداخت انجام گردید.", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

				Capital_Fund = LoadingCapitalFund();
				capitalFundTextBox.Text = $"{Capital_Fund:#,0} تومان";

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

		#region ProductListDataGridView_RowsAdded
		private void ProductListDataGridView_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
		{
			//if (e.RowIndex != -1)
			//{
			//	if (productListDataGridView.RowCount > 0)
			//	{
			//		foreach (System.Windows.Forms.DataGridViewRow row in productListDataGridView.Rows)
			//		{
			//			TotalSumPrice +=
			//				int.Parse(row.Cells[4].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
			//		}
			//		totalSumPriceTextBox.Text = $"{TotalSumPrice:#,0} تومان"; ;
			//	}
			//	else
			//	{
			//		return;
			//	}
			//}
			//else
			//{
			//	return;
			//}
		}
		#endregion /ProductListDataGridView_RowsAdded

		#region TotalSumPriceTextBox_TextChanged
		private void TotalSumPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{
			remainingAmountTextBox.Text = totalSumPriceTextBox.Text;
			Total_Sum_Price = int.Parse(totalSumPriceTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
		}
		#endregion /TotalSumPriceTextBox_TextChanged

		#region AmountPaymentTextBox_Enter
		private void AmountPaymentTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (string.IsNullOrWhiteSpace(amountPaymentTextBox.Text))
			{
				Amount_Payment = 0;
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
				amountPaymentTextBox.Text = "0 تومان";
				Amount_Payment = 0;
				return;
			}
			else
			{
				Amount_Payment = int.Parse(amountPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				amountPaymentTextBox.Text = $"{Amount_Payment:#,0} تومان";
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
				Amount_Payment = 0;
				Remaining_Amount = Total_Sum_Price - Amount_Payment;
				remainingAmountTextBox.Text = $"{Remaining_Amount:#,0} تومان";
				return;
			}
			else
			{
				Amount_Payment = int.Parse(amountPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				Remaining_Amount = Total_Sum_Price - Amount_Payment;
				remainingAmountTextBox.Text = $"{Remaining_Amount:#,0} تومان";
			}
		}
		#endregion /AmountPaymentTextBox_TextChange

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
			Amount = 0;
			Amount_Payment = 0;
			Carrier_Name = null;
			Total_Sum_Price = 0;
			Remaining_Amount = 0;
			Sender_Name = null;

			totalSumPriceTextBox.Text = "0 تومان";
			amountPaymentTextBox.Clear();
			remainingAmountTextBox.Text = "0 تومان";
			productListDataGridView.Rows.Clear();
		}
		#endregion /AllClear

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

		#region CalculatePurchaseAmount
		public void CalculatePurchaseAmount()
		{
			if (productListDataGridView.RowCount >= 1)
			{
				foreach (System.Windows.Forms.DataGridViewRow row in productListDataGridView.Rows)
				{
					Total_Sum_Price +=
						int.Parse(row.Cells[4].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					totalSumPriceTextBox.Text = $"{Total_Sum_Price:#,0} تومان";
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
		/// تابع برداشت از صندوق
		/// </summary>
		/// <param name="amountPayment"></param>
		private bool Harvest(int amountPayment)
		{
			Capital_Fund -= amountPayment;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.FirstOrDefault();

				capitalFund.Capital_Fund = $"{Capital_Fund: #,0} تومان";

				dataBaseContext.SaveChanges();

				#region -----------------------------------------     Save Event Log     -----------------------------------------
				if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
				{
					EventLog.Username = Inventory.Program.UserAuthentication.Username;
					EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
					EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
					EventLog.Description = $"پرداخت هزینه به مبلغ {amountPayment: #,0} تومان و باقیمانده {Remaining_Amount:#,0} تومان";
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
			Total_Sum_Price = 0;
			showGunaAnimateWindow.Interval = 200;
			showGunaAnimateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
			showGunaAnimateWindow.Start();
			dateOfPrintTextBox.Text = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} - {Infrastructure.Utility.ShowTime()}";
			Capital_Fund = LoadingCapitalFund();
			capitalFundTextBox.Text = $"{Capital_Fund:#,0} تومان";

			senderNameTextBox.Text = Sender_Name;
			//transferNameTextBox.Text = Inventory.Program.UserAuthentication.Full_Name;
			carrierNameTextBox.Text = Carrier_Name;

		}
		#endregion /Initialize

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
		private bool SetAccountPayable(int amountPayment, int totalSumprice, int remainingAmount)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.AccountsPayable accountsPayable =
					new Models.AccountsPayable
					{
						Amount_Paid = $"{amountPayment:#,0} تومان",
						Amount_Payable = $"{totalSumprice:#,0} تومان",
						Description = string.Empty,
						Remaininig_Amount = $"{remainingAmount:#,0} تومان",
						Registration_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}",
						Registration_Time = $"{Infrastructure.Utility.ShowTime()}",
						Seller_Name = Sender_Name,
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

		#endregion /Function
	}
}
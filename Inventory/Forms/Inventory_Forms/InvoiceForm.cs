using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory_Forms
{
	public partial class InvoiceForm : Infrastructure.EmptyForm
	{

		#region Properties

		#region Layer

		public class BillSaleReport
		{
			public string Product_Name { get; set; }
			public int? Product_Quantity { get; set; }
			public string Product_Unit { get; set; }
			public string Product_Price { get; set; }
			public string Total_Price { get; set; }
		}

		private BillSaleReportForm _billSaleReportForm = null;
		public BillSaleReportForm BillSaleReportForm
		{
			get
			{
				if (_billSaleReportForm == null || _billSaleReportForm.IsDisposed == true)
				{
					_billSaleReportForm =
						new BillSaleReportForm();
				}
				return _billSaleReportForm;
			}
		}

		private class Invoice
		{
			public string Product_Name { get; set; }
			public int? Product_Quantity { get; set; }
			public string Product_Unit { get; set; }
			public string Product_Price { get; set; }
			public string Total_Price { get; set; }
		}
		#endregion /Layer

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

		private Models.FinancialFundInput _financialFundInput;
		public Models.FinancialFundInput FinancialFundInput
		{
			get
			{
				if (_financialFundInput == null)
				{
					_financialFundInput =
						new Models.FinancialFundInput();
				}
				return _financialFundInput;
			}
			set
			{
				_financialFundInput = value;
			}
		}


		public int? AmountPayable { get; set; }
		public int? AmountPayment { get; set; }
		public int? CashPaymentAmount { get; set; }
		public int? Amount { get; set; }
		public int? PosePaymentAmount { get; set; }
		public int? TaxAmount { get; set; }
		public int? TaxPercent { get; set; }
		public int? TotalSumPrice { get; set; }

		#endregion /Properties

		public InvoiceForm()
		{
			InitializeComponent();
			TaxAmount = 0;
			AmountPayable = 0;
			AmountPayment = 0;
			dateSetInvoiceTextBox.Text = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} - {Infrastructure.Utility.ShowTime()}";
		}

		//----------Beginning of the code!----------

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			if (listWareDataGridView.RowCount >= 1)
			{
				if (Mbb.Windows.Forms.MessageBox.Show(text: "آیا فاکتور جاری حذف گردد؟", caption: "حذف فاکتور", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					ResetAllControl();
					this.Close();
				}
				else
				{
					this.Close();
				}
			}
			else
			{
				this.Close();
			}
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizeButton_Click

		#region ListWareDataGridView_RowsAdded
		private void ListWareDataGridView_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
		{
			AddRowRevice(e);
		}
		#endregion /ListWareDataGridView_RowsAdded

		#region TotalSumPriceTextBox_TextAlignChanged
		private void TotalSumPriceTextBox_TextAlignChanged(object sender, System.EventArgs e)
		{
			remainingAmountTextBox.Text = totalSumPriceTextBox.Text;
		}
		#endregion /TotalSumPriceTextBox_TextAlignChanged

		#region TaxRateTextBox_Enter
		private void TaxRateTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (string.IsNullOrWhiteSpace(taxRateTextBox.Text))
			{
				TaxPercent = 0;
				taxRateTextBox.Text = "% 0";
				taxRateTextBox.Select(2, 1);
			}
			else if (taxRateTextBox.Text.Contains("%"))
			{
				taxRateTextBox.Select(2, taxRateTextBox.Text.Length - 2);
				return;
			}
		}
		#endregion /TaxRateTextBox_Enter

		#region TaxRateTextBox_KeyPress
		private void TaxRateTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /TaxRateTextBox_KeyPress

		#region TaxRateTextBox_TextChange
		private void TaxRateTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(taxRateTextBox.Text) || (string.Compare(taxRateTextBox.Text, "% 0") == 0 || (string.Compare(taxRateTextBox.Text, "% ") == 0 || string.Compare(taxRateTextBox.Text, "%") == 0)))
			{
				return;
			}
			else
			{
				if (AmountPayment == 0 || AmountPayment == null)
				{
					TaxPercent = int.Parse(taxRateTextBox.Text.Replace("تومان", string.Empty).Trim());
					TaxAmount = (TotalSumPrice / 100) * TaxPercent;
					AmountPayable = TaxAmount + TotalSumPrice;
					remainingAmountTextBox.Text = $"{AmountPayable:#,0} تومان";
				}
				else
				{
					TaxPercent = int.Parse(taxRateTextBox.Text.Replace("%", string.Empty).Trim());
					TaxAmount = (TotalSumPrice / 100) * TaxPercent;
					AmountPayable = TaxAmount + TotalSumPrice + AmountPayment;
					remainingAmountTextBox.Text = $"{AmountPayable:#,0} تومان";
				}
			}
		}
		#endregion /TaxRateTextBox_TextChange

		#region AmountPaymentTextBox_TextChanged
		private void AmountPaymentTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(amountPaymentTextBox.Text , "0 تومان")==0 ||
				string.Compare(amountPaymentTextBox.Text, " تومان") == 0 ||
				string.Compare(amountPaymentTextBox.Text, "ومان") == 0 ||
				string.Compare(amountPaymentTextBox.Text, "مان") == 0 ||
				string.Compare(amountPaymentTextBox.Text, "ان") == 0 ||
				string.Compare(amountPaymentTextBox.Text, "ن") == 0 ||
				string.IsNullOrWhiteSpace(amountPaymentTextBox.Text))
			{
				return;
			}
			else
			{
				if (TaxAmount <= 0 || TaxAmount == null)
				{
					//TaxPercent = int.Parse(taxRateTextBox.Text.Replace("%", string.Empty).Trim());
					//TaxAmount = (TotalSumPrice / 100) * TaxPercent;
					AmountPayable = AmountPayment + TotalSumPrice;
					remainingAmountTextBox.Text = $"{AmountPayable:#,0} تومان";
				}
				else
				{
					TaxPercent = int.Parse(taxRateTextBox.Text.Replace("%", string.Empty).Trim());
					TaxAmount = (TotalSumPrice / 100) * TaxPercent;
					AmountPayable = TaxAmount + TotalSumPrice + AmountPayment;
					remainingAmountTextBox.Text = $"{AmountPayable:#,0} تومان";
				}
			}
		}
		#endregion /AmountPaymentTextBox_TextChanged

		#region PrintButton_Click
		private void PrintButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Collections.Generic.List<Invoice> InvoicesList = new System.Collections.Generic.List<Invoice>();

				foreach (System.Windows.Forms.DataGridViewRow rows in listWareDataGridView.Rows)
				{
					Invoice iserviceItem = new Invoice
					{
						Product_Name = rows.Cells[0].Value.ToString(),
						Product_Quantity = int.Parse(rows.Cells[1].Value.ToString()),
						Product_Unit = rows.Cells[2].Value.ToString(),
						Product_Price = rows.Cells[3].Value.ToString(),
						Total_Price = rows.Cells[4].Value.ToString(),
					};
					InvoicesList.Add(iserviceItem);
				}

				Stimulsoft.Report.StiReport printInvoice = new Stimulsoft.Report.StiReport();

				printInvoice.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\BillSaleReport.mrt");
				printInvoice.RegBusinessObject("BillSale", InvoicesList);

				(printInvoice.GetComponentByName("dateOfPrintTextBox") as Stimulsoft.Report.Components.StiText).Text = dateSetInvoiceTextBox.Text;
				(printInvoice.GetComponentByName("sellerNameTextBox") as Stimulsoft.Report.Components.StiText).Text = Inventory.Program.UserAuthentication.Full_Name;
				(printInvoice.GetComponentByName("clientNameTextBox") as Stimulsoft.Report.Components.StiText).Text = clientNameTextBox.Text;
				(printInvoice.GetComponentByName("carrierNameTextBox") as Stimulsoft.Report.Components.StiText).Text = carrierNameTextBox.Text;
				(printInvoice.GetComponentByName("totalSumPriceTextBox") as Stimulsoft.Report.Components.StiText).Text = totalSumPriceTextBox.Text;
				(printInvoice.GetComponentByName("taxRateTextBox") as Stimulsoft.Report.Components.StiText).Text = taxRateTextBox.Text;
				(printInvoice.GetComponentByName("amountPaymentTextBox") as Stimulsoft.Report.Components.StiText).Text = amountPaymentTextBox.Text;
				(printInvoice.GetComponentByName("remainingAmountTextBox") as Stimulsoft.Report.Components.StiText).Text = remainingAmountTextBox.Text;

				printInvoice.Render(true);
				BillSaleReportForm.billsaleStiRibbonViewerControl.Report = printInvoice;
				BillSaleReportForm.ShowDialog();
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /PrintButton_Click

		#region CashRegisterButton_Click
		private void CashRegisterButton_Click(object sender, System.EventArgs e)
		{
			FinancialFundInput.Client_Name = clientNameTextBox.Text;
			FinancialFundInput.Amount_Payable = totalSumPriceTextBox.Text;
			FinancialFundInput.Amount_Paid = amountPaymentTextBox.Text;
			FinancialFundInput.Remaininig_Amount = remainingAmountTextBox.Text;
		}
		#endregion /CashRegisterButton_Click

		#region CashPaymentTextBox_Enter
		private void CashPaymentTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (cachPaymentRadioButton.Checked == true || cachAndPosPaymentRadioButton.Checked == true)
			{
				cashPaymentTextBox.ReadOnly = false;
				if (string.IsNullOrWhiteSpace(cashPaymentTextBox.Text))
				{
					Amount = null;
					cashPaymentTextBox.Text = "0 تومان";
					cashPaymentTextBox.Select(0, 1);

					cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				}
				else if (cashPaymentTextBox.Text.Contains("تومان"))
				{
					return;
				}
			}
			else
			{
				cashPaymentTextBox.ReadOnly = true;
				return;
			}
		}
		#endregion /CashPaymentTextBox_Enter

		#region CashPaymentTextBox_KeyPress
		private void CashPaymentTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /CashPaymentTextBox_KeyPress

		#region CashPaymentTextBox_Leave
		private void CashPaymentTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cashPaymentTextBox.Text))
			{
				cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else if (string.Compare(cashPaymentTextBox.Text, "0 تومان") == 0)
			{
				cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				cashPaymentTextBox.Clear();
				return;
			}
			else if (string.Compare(cashPaymentTextBox.Text, " تومان") == 0 || string.Compare(cashPaymentTextBox.Text, "تومان") == 0 || string.Compare(cashPaymentTextBox.Text, "توما") == 0 || string.Compare(cashPaymentTextBox.Text, "توم") == 0 || string.Compare(cashPaymentTextBox.Text, "تو") == 0 || string.Compare(cashPaymentTextBox.Text, "ت") == 0)
			{
				cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				cashPaymentTextBox.Clear();
				Amount = null;
				return;
			}
			else
			{
				cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				Amount = int.Parse(cashPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				cashPaymentTextBox.Text = $"{Amount:#,0} تومان";
			}
		}
		#endregion /CashPaymentTextBox_Leave

		#region CashPaymentTextBox_TextChange
		private void CashPaymentTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cashPaymentTextBox.Text) || string.Compare(cashPaymentTextBox.Text, "0 تومان") == 0 || string.Compare(cashPaymentTextBox.Text, " تومان") == 0 || string.Compare(cashPaymentTextBox.Text, "تومان") == 0 || string.Compare(cashPaymentTextBox.Text, "توما") == 0 || string.Compare(cashPaymentTextBox.Text, "توم") == 0 || string.Compare(cashPaymentTextBox.Text, "تو") == 0 || string.Compare(cashPaymentTextBox.Text, "ت") == 0)
			{
				CashPaymentAmount = 0;
				AmountPayment = CashPaymentAmount + PosePaymentAmount;
				amountPaymentTextBox.Text = $"{AmountPayment: #,0} تومان";
				return;
			}
			else
			{
				CashPaymentAmount = int.Parse(cashPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				if (PosePaymentAmount == 0 || PosePaymentAmount == null)
				{
					AmountPayment = CashPaymentAmount;
					amountPaymentTextBox.Text = $"{CashPaymentAmount: #,0} تومان";
				}
				else
				{
					AmountPayment = CashPaymentAmount + PosePaymentAmount;
					amountPaymentTextBox.Text = $"{AmountPayment: #,0} تومان";
				}
			}
		}
		#endregion /CashPaymentTextBox_TextChange

		#region PosPaymentTextBox_Enter
		private void PosPaymentTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			if (posPaymentRadioButton.Checked == true || cachAndPosPaymentRadioButton.Checked == true)
			{
				posPaymentTextBox.ReadOnly = false;
				if (string.IsNullOrWhiteSpace(posPaymentTextBox.Text))
				{
					Amount = null;
					posPaymentTextBox.Text = "0 تومان";
					posPaymentTextBox.Select(0, 1);
					posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				}
				else if (posPaymentTextBox.Text.Contains("تومان"))
				{
					return;
				}
			}
			else
			{
				posPaymentTextBox.ReadOnly = true;
				return;
			}
		}
		#endregion /PosPaymentTextBox_Enter

		#region PosPaymentTextBox_KeyPress
		private void PosPaymentTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /PosPaymentTextBox_KeyPress

		#region PosPaymentTextBox_Leave
		private void PosPaymentTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(posPaymentTextBox.Text))
			{
				posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else if (string.Compare(posPaymentTextBox.Text, "0 تومان") == 0)
			{
				posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				posPaymentTextBox.Clear();
				return;
			}
			else if (string.Compare(posPaymentTextBox.Text, " تومان") == 0 || string.Compare(posPaymentTextBox.Text, "تومان") == 0 || string.Compare(posPaymentTextBox.Text, "توما") == 0 || string.Compare(posPaymentTextBox.Text, "توم") == 0 || string.Compare(posPaymentTextBox.Text, "تو") == 0 || string.Compare(posPaymentTextBox.Text, "ت") == 0)
			{
				posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				posPaymentTextBox.Clear();
				return;
			}
			else
			{
				posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				Amount = int.Parse(posPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				posPaymentTextBox.Text = $"{Amount:#,0} تومان";
			}
		}
		#endregion /PosPaymentTextBox_Leave

		#region PosPaymentTextBox_TextChange
		private void PosPaymentTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(posPaymentTextBox.Text) || string.Compare(posPaymentTextBox.Text, "0 تومان") == 0 || string.Compare(posPaymentTextBox.Text, " تومان") == 0 || string.Compare(posPaymentTextBox.Text, "تومان") == 0 || string.Compare(posPaymentTextBox.Text, "توما") == 0 || string.Compare(posPaymentTextBox.Text, "توم") == 0 || string.Compare(posPaymentTextBox.Text, "تو") == 0 || string.Compare(posPaymentTextBox.Text, "ت") == 0)
			{
				PosePaymentAmount = 0;
				AmountPayment = CashPaymentAmount + PosePaymentAmount;
				amountPaymentTextBox.Text = $"{AmountPayment: #,0} تومان";
				return;
			}
			else
			{
				PosePaymentAmount = int.Parse(posPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				if (CashPaymentAmount == 0 || CashPaymentAmount == null)
				{
					AmountPayment = PosePaymentAmount;
					amountPaymentTextBox.Text = $"{PosePaymentAmount: #,0} تومان";
				}
				else
				{
					AmountPayment = CashPaymentAmount + PosePaymentAmount;
					amountPaymentTextBox.Text = $"{AmountPayment: #,0} تومان";
				}
			}
		}
		#endregion /PosPaymentTextBox_TextChange

		#region CachPaymentRadioButton_CheckedChanged
		private void CachPaymentRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			cashPaymentTextBox.Clear();
			posPaymentTextBox.Clear();

			CashPaymentAmount = 0;
			PosePaymentAmount = 0;
			AmountPayment = 0;

			amountPaymentTextBox.Text = "0 تومان";
		}
		#endregion /CachPaymentRadioButton_CheckedChanged

		#region CachPaymentLabel_Click
		private void CachPaymentLabel_Click(object sender, System.EventArgs e)
		{
			cachPaymentRadioButton.Checked = true;
		}
		#endregion /CachPaymentLabel_Click

		#region PosPaymentRadioButton_CheckedChanged
		private void PosPaymentRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			cashPaymentTextBox.Clear();
			posPaymentTextBox.Clear();

			CashPaymentAmount = 0;
			PosePaymentAmount = 0;
			AmountPayment = 0;

			amountPaymentTextBox.Text = "0 تومان";
		}
		#endregion /PosPaymentRadioButton_CheckedChanged

		#region PosPaymentLabel_Click
		private void PosPaymentLabel_Click(object sender, System.EventArgs e)
		{
			posPaymentRadioButton.Checked = true;
		}
		#endregion /PosPaymentLabel_Click

		#region CachAndPosPaymentRadioButton_CheckedChanged
		private void CachAndPosPaymentRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			cashPaymentTextBox.Clear();
			posPaymentTextBox.Clear();

			CashPaymentAmount = 0;
			PosePaymentAmount = 0;
			AmountPayment = 0;

			amountPaymentTextBox.Text = "0 تومان";
		}
		#endregion /CachAndPosPaymentRadioButton_CheckedChanged

		#region CachAndPosPaymentLabel_Click
		private void CachAndPosPaymentLabel_Click(object sender, System.EventArgs e)
		{
			cachAndPosPaymentRadioButton.Checked = true;
		}
		#endregion /CachAndPosPaymentLabel_Click

		#region DebtorRadioButton_CheckedChanged
		private void DebtorRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			cashPaymentTextBox.Clear();
			posPaymentTextBox.Clear();

			CashPaymentAmount = 0;
			PosePaymentAmount = 0;
			AmountPayment = 0;

			amountPaymentTextBox.Text = "0 تومان";
		}
		#endregion /DebtorRadioButton_CheckedChanged

		#region DebtorLabel_Click
		private void DebtorLabel_Click(object sender, System.EventArgs e)
		{
			debtorRadioButton.Checked = true;
		}
		#endregion /DebtorLabel_Click

		//----------End of code!----------

		#region Function

		#region AddRowRevice
		private void AddRowRevice(System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
		{
			string value;
			int newPrice;
			int totalSumPrice = 0;
			if (e.RowIndex != -1)
			{
				if (listWareDataGridView.RowCount >= 1)
				{
					for (int i = 0; i < listWareDataGridView.Rows.Count; i++)
					{
						value = listWareDataGridView.Rows[i].Cells[4].Value.ToString().Replace("تومان", string.Empty).Trim();
						newPrice = int.Parse(value.Replace(",", string.Empty).Trim());
						totalSumPrice += newPrice;
					}
					value =
						$"{totalSumPrice:#,0} تومان";
					TotalSumPrice = totalSumPrice;
					totalSumPriceTextBox.Text = value;
				}
				else
				{
					return;
				}
			}
			else
			{
				return;
			}
		}
		#endregion /AddRowRevice

		#region ReciveListWare
		public void ReciveListWare(System.Collections.Generic.List<BillSaleReport> inputListWare, TransactionFactors transactionFactors)//ایا میتوان کلاس خصوصی تعریف کرد که بتوان از آن بعنوان  یک پارامتر ورودی در یک تابع استفاده نمود؟
		{
			for (int i = 0; i < inputListWare.Count; i++)
			{
				listWareDataGridView.DataSource = inputListWare;
			}
			sellerNameTextBox.Text = transactionFactors.Seller_Name;
			clientNameTextBox.Text = transactionFactors.Client_Name;
			carrierNameTextBox.Text = transactionFactors.Carrier_Name;
		}
		#endregion ReciveListWare

		#region ResetAllControl
		private void ResetAllControl()
		{
			sellerNameTextBox.Text = "نام فروشنده";
			clientNameTextBox.Text = "نام مشتری";
			carrierNameTextBox.Text = "نام حامل کالا";
			listWareDataGridView.DataSource = null;
			TotalSumPrice = 0;
			TaxPercent = 0;
			TaxAmount = 0;
			AmountPayable = 0;
			cashPaymentTextBox.Clear();
			cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			posPaymentTextBox.Clear();
			posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			cachPaymentRadioButton.Checked = false;
			posPaymentRadioButton.Checked = false;
			cachAndPosPaymentRadioButton.Checked = false;
			debtorRadioButton.Checked = false;
		}
		#endregion ResetAllControl

		#region Inbox
		/// <summary>
		/// تمام پرداختی به صندوق سرمایه انتقال می بابد.
		/// </summary>
		/// <param name="capitalFund"></param>
		private void CapitalFundInputFunction(Models.CapitalFund capitalFundEntry)
		{

		}
		#endregion /Inbox

		#region FinancialOfficeInput
		/// <summary>
		/// وضعیت مالی را در هنگام پرداخت ثبت میکند.
		/// </summary>
		/// <param name="financialFundInput"></param>
		private void FinancialFundInputFunction(Models.FinancialFundInput financialFundEntry)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.FinancialFundInput financialFundInput =
					dataBaseContext.FinancialFundInputs
					.FirstOrDefault();

				financialFundInput =
					new Models.FinancialFundInput
					{

					};
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

		#endregion /FinancialOfficeInput

		#endregion /Function

		
	}
}

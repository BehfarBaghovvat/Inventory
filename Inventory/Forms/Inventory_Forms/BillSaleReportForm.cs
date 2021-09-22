using Inventory;
using System.Linq;

namespace Inventory_Forms
{
	public partial class BillSaleReportForm : Infrastructure.EmptyForm
	{

		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Layer
		private class AuditItem
		{
			public decimal? Amount { get; set; }
			public decimal? Amounts_Payment { get; set; }
			public decimal? Amount_Paid { get; set; }
			public decimal? Amount_Remaininig { get; set; }
			public decimal? Capital_Fund { get; set; }
			public string Client_Name { get; set; }
			public string Carrier_Name { get; set; }
			public decimal? Cash_Payment_Amount { get; set; }
			public int Final_Quantity { get; set; }
			public Models.ListFinancialClient.FinantialSituation Finantial_Situation { get; set; }
			public int First_Quantity { get; set; }
			public string InvoiceSerialNumber { get; set; }
			public Models.SalesInvoice.SalesPaymentType Sales_Payment_Type { get; set; }
			public Models.SalesInvoice.PaymentCachType Payment_Cach_Type { get; set; }
			public string Phone_Number { get; set; }
			public decimal Product_Price { get; set; }
			public decimal? Pose_Payment_Amount { get; set; }
			public int Second_Quantity { get; set; }
			public string Register_Date { get; set; }
			public string Register_Time { get; set; }
			public string Seller_Name { get; set; }
			public decimal? Tax_Amount { get; set; }
			public int? Tax_Percent { get; set; }
			public decimal Total_Sum_Price { get; set; }
		}
		private class BillItems
		{
			public string Product_Name { get; set; }
			public int? Product_Quantity { get; set; }
			public string Product_Unit { get; set; }
			public string Product_Price { get; set; }
			public string Total_Price { get; set; }
		}

		private Models.AccountsReceivable _accountsReceivable;
		public Models.AccountsReceivable AccountsReceivable
		{
			get
			{
				if (_accountsReceivable == null)
				{
					_accountsReceivable =
						new Models.AccountsReceivable();
				}
				return _accountsReceivable;
			}
			set
			{ _accountsReceivable = value; }
		}

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
		}

		private Inventory.MainForm _mainForm;
		public Inventory.MainForm MainForm
		{
			get
			{
				if (_mainForm == null || _mainForm.IsDisposed == true)
				{

				}
				return _mainForm;
			}
			set
			{
				_mainForm = value;
			}
		}

		private ProcutSalesForm _myProcutSalesForm;
		public ProcutSalesForm MyProcutSalesForm
		{
			get
			{
				if (_myProcutSalesForm == null || _myProcutSalesForm.IsDisposed == true)
				{
					_myProcutSalesForm =
						new ProcutSalesForm();
				}
				return _myProcutSalesForm;
			}
			set
			{
				_myProcutSalesForm = value;
			}
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

		private AuditItem auditItem = new AuditItem();
		public Models.Client Client { get; set; }
		public bool Purchase_Operations { get; set; }

		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public BillSaleReportForm()
		{
			InitializeComponent();

		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region BillSaleReportForm_Load
		private void BillSaleReportForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /BillSaleReportForm_Load

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			if (Purchase_Operations)
			{
				ResetAllControl();
				closeFormTimer.Start();
			}
			if (productsListDataGridView.RowCount >= 1)
			{
				if (Mbb.Windows.Forms.MessageBox.Show(
					text: "آیا فاکتور جاری حذف گردد؟",
					caption: "حذف فاکتور",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					ResetAllControl();
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

		#region ProductsListDataGridView_CellDoubleClick
		private void ProductsListDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if ((e.ColumnIndex == 1 && e.RowIndex >= 0) || (e.ColumnIndex == 2 && e.RowIndex >= 0))
			{
				auditItem.First_Quantity =int.Parse(productsListDataGridView.CurrentRow.Cells[2].Value.ToString());
				productsListDataGridView.CurrentCell.ReadOnly = false;
				return;
			}
			else
			{
				productsListDataGridView.CurrentCell.ReadOnly = true;
				return;
			}
		}
		#endregion /ProductsListDataGridView_CellDoubleClick

		#region ProductsListDataGridView_CellValueChanged
		private void ProductsListDataGridView_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			int _productQuantity;
			decimal _productPrice,
				_sumPrice,
				_totalSumPrice = 0;

			if ((e.ColumnIndex == 1 && e.RowIndex >= 0))
			{
				_productPrice =
					decimal.Parse(productsListDataGridView.CurrentRow.Cells[e.ColumnIndex].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				
				_productQuantity =
					int.Parse(productsListDataGridView.CurrentRow.Cells[e.ColumnIndex + 1].Value.ToString());
				
				_sumPrice = (_productPrice * _productQuantity);
				productsListDataGridView.CurrentRow.Cells[4].Value = $"{_sumPrice:#,0} تومان";
				productsListDataGridView.CurrentRow.Cells[e.ColumnIndex].Value = $"{_productPrice:#,0} تومان";

				foreach (System.Windows.Forms.DataGridViewRow row in productsListDataGridView.Rows)
				{
					_totalSumPrice += 
						decimal.Parse(row.Cells[4].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					

					if (string.IsNullOrWhiteSpace(taxRateTextBox.Text) || string.Compare(taxRateTextBox.Text,"0 %")==0)
					{
						amountPayableTextBox.Text = $"{_totalSumPrice:#,0} تومان";
						amountRemainingTextBox.Text = $"{_totalSumPrice:#,0} تومان";
					}
					else
					{
						if (auditItem.Amount_Paid == 0 || auditItem.Amount_Paid == null)
						{
							auditItem.Amounts_Payment =
								decimal.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

							auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
							auditItem.Amounts_Payment = (auditItem.Tax_Amount + auditItem.Amounts_Payment);
							amountRemainingTextBox.Text = $"{auditItem.Amounts_Payment:#,0} تومان";
							auditItem.Amount_Remaininig = auditItem.Amounts_Payment;
							taxRateTextBox.Text = $"% {auditItem.Tax_Percent}";
						}
						else
						{
							auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
							auditItem.Amounts_Payment = auditItem.Amount_Paid - (auditItem.Tax_Amount + auditItem.Amounts_Payment);
							amountRemainingTextBox.Text = $"{auditItem.Amounts_Payment:#,0} تومان";
							auditItem.Amount_Remaininig = auditItem.Amounts_Payment;
							taxRateTextBox.Text = $"% {auditItem.Tax_Percent}";
						}
					}
				}

				EditBill();

				

				return;
			}
			else if ((e.ColumnIndex == 2 && e.RowIndex >= 0))
			{
				_productPrice =
					decimal.Parse(productsListDataGridView.CurrentRow.Cells[e.ColumnIndex - 1].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				
				_productQuantity =
					int.Parse(productsListDataGridView.CurrentRow.Cells[e.ColumnIndex].Value.ToString());
				
				auditItem.Second_Quantity = _productQuantity;

				auditItem.Final_Quantity = auditItem.First_Quantity - auditItem.Second_Quantity;
				
				_sumPrice = (_productPrice * _productQuantity);
				productsListDataGridView.CurrentRow.Cells[4].Value = $"{_sumPrice:#,0} تومان";
				foreach (System.Windows.Forms.DataGridViewRow row in productsListDataGridView.Rows)
				{
					_totalSumPrice +=
						decimal.Parse(row.Cells[4].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					if (string.IsNullOrWhiteSpace(taxRateTextBox.Text) || string.Compare(taxRateTextBox.Text, "0 %") == 0)
					{
						amountPayableTextBox.Text = $"{_totalSumPrice:#,0} تومان";
						amountRemainingTextBox.Text = $"{_totalSumPrice:#,0} تومان";
					}
					else
					{
						if (auditItem.Amount_Paid == 0 || auditItem.Amount_Paid == null)
						{
							amountPayableTextBox.Text = $"{_totalSumPrice:#,0} تومان";

							auditItem.Amounts_Payment =
								decimal.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

							auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
							auditItem.Amounts_Payment = (auditItem.Tax_Amount + auditItem.Amounts_Payment);
							amountRemainingTextBox.Text = $"{auditItem.Amounts_Payment:#,0} تومان";
							auditItem.Amount_Remaininig = auditItem.Amounts_Payment;
							taxRateTextBox.Text = $"% {auditItem.Tax_Percent}";
						}
						else
						{
							amountPayableTextBox.Text = $"{_totalSumPrice:#,0} تومان";

							auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
							auditItem.Amounts_Payment = auditItem.Amount_Paid - (auditItem.Tax_Amount + auditItem.Amounts_Payment);
							amountRemainingTextBox.Text = $"{auditItem.Amounts_Payment:#,0} تومان";
							auditItem.Amount_Remaininig = auditItem.Amounts_Payment;
							taxRateTextBox.Text = $"% {auditItem.Tax_Percent}";
						}
					}
				}

				EditBill();

				return;
			}
			else
			{
				return;
			}
		}
		#endregion /ProductsListDataGridView_CellValueChanged

		#region AmountPayableTextBox_TextAlignChanged
		private void AmountPayableTextBox_TextAlignChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(amountPaidTextBox.Text, "0 تومان") == 0)
			{
				auditItem.Amounts_Payment = 0;
				auditItem.Amount_Remaininig = 0;
				amountRemainingTextBox.Text = $"{auditItem.Amount_Remaininig:#,0} تومان";
				return;
			}
			else
			{
				if (auditItem.Tax_Percent == 0 || auditItem.Tax_Percent == null)
				{
					auditItem.Amounts_Payment =
						decimal.Parse(amountPaidTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					auditItem.Amount_Remaininig = auditItem.Amount_Paid - auditItem.Amounts_Payment;
					amountRemainingTextBox.Text = $"{auditItem.Amount_Remaininig:#,0} تومان";
				}
				else
				{
					auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
					auditItem.Amounts_Payment = (auditItem.Tax_Amount + auditItem.Amounts_Payment);
					amountRemainingTextBox.Text = $"{auditItem.Amounts_Payment:#,0} تومان";
					auditItem.Amount_Remaininig = auditItem.Amounts_Payment;
				}
			}
		}
		#endregion /AmountPayableTextBox_TextAlignChanged

		#region TaxRateTextBox_Enter
		private void TaxRateTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (string.IsNullOrWhiteSpace(taxRateTextBox.Text))
			{
				auditItem.Tax_Percent = 0;
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
			EnterTaxPercentage(taxRateTextBox.Text);
		}
		#endregion /TaxRateTextBox_TextChange

		#region AmountPaidTextBox_TextChanged
		private void AmountPaidTextBox_TextChanged(object sender, System.EventArgs e)
		{
			AmountPaid(amountPaidTextBox.Text);
		}
		#endregion /AmountPaidTextBox_TextChanged

		#region PrintButton_Click
		private void PrintButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Collections.Generic.List<BillItems> billSaleReportItemsList = new System.Collections.Generic.List<BillItems>();

				foreach (System.Windows.Forms.DataGridViewRow rows in productsListDataGridView.Rows)
				{
					BillItems billSaleReportItems = new BillItems
					{
						Product_Name = rows.Cells[0].Value.ToString(),
						Product_Price = rows.Cells[1].Value.ToString(),
						Product_Quantity = int.Parse(rows.Cells[2].Value.ToString()),
						Product_Unit = rows.Cells[3].Value.ToString(),
						Total_Price = rows.Cells[4].Value.ToString(),
					};
					billSaleReportItemsList.Add(billSaleReportItems);
				}

				Stimulsoft.Report.StiReport printInvoice = new Stimulsoft.Report.StiReport();

				printInvoice.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\BillSaleReport.mrt");
				printInvoice.RegBusinessObject("BillSale", billSaleReportItemsList);

				(printInvoice.GetComponentByName("dateOfPrintTextBox") as Stimulsoft.Report.Components.StiText).Text = dateSetInvoiceTextBox.Text;
				(printInvoice.GetComponentByName("sellerNameTextBox") as Stimulsoft.Report.Components.StiText).Text = "admin"; //Inventory.Program.UserAuthentication.Full_Name;
				(printInvoice.GetComponentByName("clientNameTextBox") as Stimulsoft.Report.Components.StiText).Text = clientNameTextBox.Text;
				(printInvoice.GetComponentByName("carrierNameTextBox") as Stimulsoft.Report.Components.StiText).Text = carrierNameTextBox.Text;
				(printInvoice.GetComponentByName("totalSumPriceTextBox") as Stimulsoft.Report.Components.StiText).Text = amountPayableTextBox.Text;
				(printInvoice.GetComponentByName("taxRateTextBox") as Stimulsoft.Report.Components.StiText).Text = taxRateTextBox.Text;
				(printInvoice.GetComponentByName("amountPaymentTextBox") as Stimulsoft.Report.Components.StiText).Text = amountPaidTextBox.Text;
				(printInvoice.GetComponentByName("remainingAmountTextBox") as Stimulsoft.Report.Components.StiText).Text = amountRemainingTextBox.Text;

				printInvoice.Render(true);
				PrintReportForm.printReportStiViewerControl.Report = printInvoice;
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

		#region PaymentCachRadioButton_CheckedChanged
		private void PaymentCachRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			paymentCachTypeGroupBox.Enabled = true;
			auditItem.Sales_Payment_Type = Models.SalesInvoice.SalesPaymentType.نقد;
			auditItem.Pose_Payment_Amount = 0;
			auditItem.Cash_Payment_Amount = 0;
			auditItem.Amount_Paid = 0;

		}
		#endregion /PaymentCachRadioButton_CheckedChanged

		#region PaymentCachLabel_Click
		private void PaymentCachLabel_Click(object sender, System.EventArgs e)
		{
			paymentCachRadioButton.Checked = true;
		}
		#endregion /PaymentCachLabel_Click

		#region PaymentChequeRadioButton_CheckedChanged
		private void PaymentChequeRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			paymentCachTypeGroupBox.Enabled = false;
			paymentButton.Enabled = true;
			auditItem.Sales_Payment_Type = Models.SalesInvoice.SalesPaymentType.چک;
			auditItem.Payment_Cach_Type = Models.SalesInvoice.PaymentCachType.غیرنقد;
		}
		#endregion /PaymentChequeRadioButton_CheckedChanged

		#region PaymentChequeLabel_Click
		private void PaymentChequeLabel_Click(object sender, System.EventArgs e)
		{
			paymentChequeRadioButton.Checked = true;
		}
		#endregion /PaymentChequeLabel_Click

		#region CashPaymentTextBox_Enter
		private void CashPaymentTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (cachPaymentRadioButton.Checked == true || cachAndPosPaymentRadioButton.Checked == true)
			{
				cashPaymentTextBox.ReadOnly = false;
				if (string.IsNullOrWhiteSpace(cashPaymentTextBox.Text))
				{
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
			else if (cashPaymentTextBox.Text.Length < 7)
			{
				cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				cashPaymentTextBox.Clear();
				auditItem.Amount = null;
				return;
			}
			else
			{
				cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				auditItem.Amount = int.Parse(cashPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				cashPaymentTextBox.Text = $"{auditItem.Amount:#,0} تومان";
			}
		}
		#endregion /CashPaymentTextBox_Leave

		#region CashPaymentTextBox_TextChange
		private void CashPaymentTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cashPaymentTextBox.Text) || cashPaymentTextBox.Text.Length < 7)
			{
				auditItem.Cash_Payment_Amount = 0;
				auditItem.Amount_Paid = auditItem.Cash_Payment_Amount + auditItem.Pose_Payment_Amount;
				amountPaidTextBox.Text = $"{auditItem.Amount_Paid: #,0} تومان";
				return;
			}
			else if (string.Compare(cashPaymentTextBox.Text, "0 تومان") == 0)
			{
				return;
			}
			else
			{
				auditItem.Cash_Payment_Amount =
					decimal.Parse(cashPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

				if (auditItem.Pose_Payment_Amount == 0 || auditItem.Pose_Payment_Amount == null)
				{
					auditItem.Amount_Paid = auditItem.Cash_Payment_Amount;
					amountPaidTextBox.Text = $"{auditItem.Amount_Paid: #,0} تومان";
				}
				else
				{
					auditItem.Amount_Paid = auditItem.Cash_Payment_Amount + auditItem.Pose_Payment_Amount;
					amountPaidTextBox.Text = $"{auditItem.Amount_Paid: #,0} تومان";
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
					posPaymentTextBox.Text = "0 تومان";
					posPaymentTextBox.Select(0, 1);
					posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

					if (auditItem.Cash_Payment_Amount == 0 || auditItem.Cash_Payment_Amount == null)
					{
						auditItem.Amount_Paid = 0;
						amountPaidTextBox.Text = $"{auditItem.Amount_Paid: #,0} تومان";
					}
					else
					{
						auditItem.Amount_Paid = auditItem.Cash_Payment_Amount + 0;
						amountPaidTextBox.Text = $"{auditItem.Amount_Paid: #,0} تومان";
					}
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
			else if (posPaymentTextBox.Text.Length < 7)
			{
				posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				posPaymentTextBox.Clear();
				return;
			}
			else
			{
				posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				auditItem.Amount = int.Parse(posPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				posPaymentTextBox.Text = $"{auditItem.Amount:#,0} تومان";
			}
		}
		#endregion /PosPaymentTextBox_Leave

		#region PosPaymentTextBox_TextChange
		private void PosPaymentTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(posPaymentTextBox.Text) || posPaymentTextBox.Text.Length < 7)
			{
				auditItem.Pose_Payment_Amount = 0;
				auditItem.Amount_Paid = auditItem.Cash_Payment_Amount + auditItem.Pose_Payment_Amount;
				amountPaidTextBox.Text = $"{auditItem.Amount_Paid: #,0} تومان";
				return;
			}
			else if (string.Compare(posPaymentTextBox.Text, "0 تومان") == 0)
			{
				return;
			}
			else
			{
				auditItem.Pose_Payment_Amount =
					decimal.Parse(posPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

				if (auditItem.Cash_Payment_Amount == 0 || auditItem.Cash_Payment_Amount == null)
				{
					auditItem.Amount_Paid = auditItem.Pose_Payment_Amount;
					amountPaidTextBox.Text = $"{auditItem.Amount_Paid: #,0} تومان";
				}
				else
				{
					auditItem.Amount_Paid = auditItem.Cash_Payment_Amount + auditItem.Pose_Payment_Amount;
					amountPaidTextBox.Text = $"{auditItem.Amount_Paid: #,0} تومان";
				}
			}
		}
		#endregion /PosPaymentTextBox_TextChange

		#region CachPaymentRadioButton_CheckedChanged
		private void CachPaymentRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			cashPaymentTextBox.Clear();
			cashPaymentTextBox.ReadOnly = true;
			posPaymentTextBox.Clear();
			posPaymentTextBox.ReadOnly = false;

			auditItem.Cash_Payment_Amount = 0;
			auditItem.Pose_Payment_Amount = 0;
			auditItem.Amount_Paid = 0;

			amountPaidTextBox.Text = "0 تومان";
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
			cashPaymentTextBox.ReadOnly = false;
			posPaymentTextBox.Clear();
			posPaymentTextBox.ReadOnly = true;

			auditItem.Cash_Payment_Amount = 0;
			auditItem.Pose_Payment_Amount = 0;
			auditItem.Amount_Paid = 0;

			amountPaidTextBox.Text = "0 تومان";
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
			cashPaymentTextBox.ReadOnly = true;
			posPaymentTextBox.Clear();
			posPaymentTextBox.ReadOnly = true;

			auditItem.Cash_Payment_Amount = 0;
			auditItem.Pose_Payment_Amount = 0;
			auditItem.Amount_Paid = 0;

			amountPaidTextBox.Text = "0 تومان";
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
			cashPaymentTextBox.ReadOnly = false;
			posPaymentTextBox.Clear();
			posPaymentTextBox.ReadOnly = false;

			auditItem.Cash_Payment_Amount = 0;
			auditItem.Pose_Payment_Amount = 0;
			auditItem.Amount_Paid = 0;

			amountPaidTextBox.Text = "0 تومان";
		}
		#endregion /DebtorRadioButton_CheckedChanged

		#region DebtorLabel_Click
		private void DebtorLabel_Click(object sender, System.EventArgs e)
		{
			debtorRadioButton.Checked = true;
		}
		#endregion /DebtorLabel_Click

		#region DeleteProductToolStripMenuItem_Click
		private void DeleteProductToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (productsListDataGridView.Rows.Count > 0)
			{
				if (Mbb.Windows.Forms.MessageBox.Show(text: $"{productsListDataGridView.CurrentRow.Cells[0].Value} از فاکتور حذف گردد؟", caption: "حذف کالا", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					productsListDataGridView.Rows.Remove(productsListDataGridView.CurrentRow);
					RefreshCalculator();
					EditBill();
				}
				else
				{
					return;
				}
			}
			else
			{
				this.Dispose();
			}

		}
		#endregion /DeleteProductToolStripMenuItem_Click

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

		#region AccountRecivedBook
		/// <summary>
		/// ثبت در دفتر معین واریزی
		/// </summary>
		/// <param name="_accountsReceivable"></param>
		private bool SetAccountPayable(AuditItem _auditItem)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.AccountsReceivable accountsReceivable =
					dataBaseContext.AccountsReceivables
					.FirstOrDefault();

				accountsReceivable =
					new Models.AccountsReceivable
					{
						Amount_Paid = $"{auditItem.Amount_Paid:#,0} تومان",
						Amount_Payable = $"{auditItem.Amounts_Payment:#,0} تومان",
						Client_Name = _auditItem.Client_Name,
						Description = "فروش کالا",
						Registration_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}",
						Registration_Time = $"{Infrastructure.Utility.ShowTime()}",
						Tax_Percent = $"{_auditItem.Tax_Percent}%",
					};

				dataBaseContext.AccountsReceivables.Add(accountsReceivable);
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

		#endregion /AccountRecivedBook

		#region AddNewClient
		/// <summary>
		/// اضافه کردن مشتری به سیستم
		/// </summary>
		/// <param name="_auditItem"></param>
		private void AddNewClient(AuditItem _auditItem)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Client client =
					new Models.Client()
					{
						Client_Name = _auditItem.Client_Name,
						License_Plate = string.Empty,
						Phone_Number = _auditItem.Phone_Number,
					};
				dataBaseContext.Clients.Add(client);
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
		#endregion /AddNewClient

		#region AmountPaid
		/// <summary>
		/// پرداخت مبلغ 
		/// و محاسبات مربوطه
		/// </summary>
		/// <param name="_amountPaid"></param>
		private void AmountPaid(string _amountPaid)
		{
			if (amountPaidTextBox.Text.Length < 7 || string.IsNullOrWhiteSpace(amountPaidTextBox.Text))
			{
				paymentButton.Enabled = false;
				return;
			}
			else if (string.Compare(amountPaidTextBox.Text, "0 تومان") == 0 || auditItem.Amount_Paid == 0)
			{
				paymentButton.Enabled = false;

				if (auditItem.Tax_Amount == 0 || auditItem.Tax_Amount == null)
				{
					auditItem.Amounts_Payment =
					decimal.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					auditItem.Amount_Remaininig = auditItem.Amount_Paid - auditItem.Amounts_Payment;
					amountRemainingTextBox.Text = $"{auditItem.Amount_Remaininig:#,0} تومان";
				}
				else
				{
					auditItem.Amounts_Payment =
					decimal.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					auditItem.Tax_Percent = int.Parse(taxRateTextBox.Text.Replace("%", string.Empty).Trim());
					auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
					auditItem.Amount_Remaininig = auditItem.Amount_Paid - (auditItem.Tax_Amount + auditItem.Amounts_Payment);
					amountRemainingTextBox.Text = $"{auditItem.Amount_Remaininig:#,0} تومان";
				}
			}
			else
			{
				paymentButton.Enabled = true;

				if (auditItem.Tax_Amount == 0 || auditItem.Tax_Amount == null)
				{
					auditItem.Amounts_Payment =
					decimal.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					auditItem.Amount_Remaininig = auditItem.Amount_Paid - auditItem.Amounts_Payment;
					amountRemainingTextBox.Text = $"{auditItem.Amount_Remaininig:#,0} تومان";
				}
				else
				{
					auditItem.Amounts_Payment =
					decimal.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					auditItem.Tax_Percent = int.Parse(taxRateTextBox.Text.Replace("%", string.Empty).Trim());
					auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
					auditItem.Amount_Remaininig = auditItem.Amount_Paid - (auditItem.Tax_Amount + auditItem.Amounts_Payment);
					amountRemainingTextBox.Text = $"{auditItem.Amount_Remaininig:#,0} تومان";
				}
			}
		}
		#endregion /AmountPaid

		#region CalculatePurchaseAmount
		public void CalculatePurchaseAmount()
		{
			if (productsListDataGridView.RowCount >= 1)
			{
				foreach (System.Windows.Forms.DataGridViewRow row in productsListDataGridView.Rows)
				{
					auditItem.Amounts_Payment +=
						decimal.Parse(row.Cells[4].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					amountPayableTextBox.Text = $"{auditItem.Amounts_Payment:#,0} تومان";

					auditItem.Amount_Remaininig = auditItem.Amount_Paid - auditItem.Amounts_Payment;
					amountRemainingTextBox.Text = $"{auditItem.Amount_Remaininig:#,0} تومان";
				}
			}
			else
			{
				return;
			}
		}
		#endregion /CalculatePurchaseAmount

		#region Deposit
		/// <summary>
		/// تابع سپرده گزاری
		/// </summary>
		/// <returns></returns>
		private bool Deposit(AuditItem auditItem)
		{
			auditItem.Capital_Fund += auditItem.Amount_Paid;

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
					EventLog.Description = $"خرید توسط {auditItem.Client_Name} به مبلغ {auditItem.Amount_Paid: #,0} تومان و باقیمانده {auditItem.Amount_Remaininig}";
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
		#endregion /Deposit

		#region EditBill
		private void EditBill()
		{
			System.Collections.Generic.List<ProcutSalesForm.BillSaleReportItems> billSaleReportItemsList = new System.Collections.Generic.List<ProcutSalesForm.BillSaleReportItems>();

			foreach (System.Windows.Forms.DataGridViewRow rows in productsListDataGridView.Rows)
			{
				ProcutSalesForm.BillSaleReportItems billSaleReportItems = new ProcutSalesForm.BillSaleReportItems
				{
					Product_Name = rows.Cells[0].Value.ToString(),
					Product_Price = rows.Cells[1].Value.ToString(),
					Product_Quantity = int.Parse(rows.Cells[2].Value.ToString()),
					Product_Unit = rows.Cells[3].Value.ToString(),
					Total_Price = rows.Cells[4].Value.ToString(),
				};
				billSaleReportItemsList.Add(billSaleReportItems);
			}
			MyProcutSalesForm.listBillSaleReports.Clear();
			MyProcutSalesForm.listBillSaleReports = billSaleReportItemsList.ToList();
			MyProcutSalesForm.listBillSaleReports.TrimExcess();
		}
		#endregion /EditBill

		#region EnterTaxPercentage
		/// <summary>
		/// وارد کردن درصد مالیات
		/// و محاسبه مالیات فروش کالا
		/// </summary>
		/// <param name="_taxPercentage"></param>
		private void EnterTaxPercentage(string _taxPercentage)
		{
			if (string.IsNullOrWhiteSpace(taxRateTextBox.Text) || taxRateTextBox.Text.Length < 3)
			{
				auditItem.Tax_Amount = 0;
				auditItem.Tax_Percent = 0;

				auditItem.Amounts_Payment =
					decimal.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());


				if (auditItem.Amount_Paid == 0 || auditItem.Amount_Paid == null)
				{
					auditItem.Amounts_Payment =
						decimal.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
					auditItem.Amounts_Payment = (auditItem.Tax_Amount + auditItem.Amounts_Payment);
					amountRemainingTextBox.Text = $"{auditItem.Amounts_Payment:#,0} تومان";
					auditItem.Amount_Remaininig = auditItem.Amounts_Payment;
					taxRateTextBox.Text = $"% {auditItem.Tax_Percent}";
				}
				else
				{
					auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
					auditItem.Amounts_Payment = auditItem.Amount_Paid - (auditItem.Tax_Amount + auditItem.Amounts_Payment);
					amountRemainingTextBox.Text = $"{auditItem.Amounts_Payment:#,0} تومان";
					auditItem.Amount_Remaininig = auditItem.Amounts_Payment;
					taxRateTextBox.Text = $"% {auditItem.Tax_Percent}";
				}
			}
			else if (string.Compare(taxRateTextBox.Text, "0 %") == 0)
			{
				auditItem.Tax_Percent = 0;
				auditItem.Tax_Amount = 0;
				auditItem.Amounts_Payment =
					int.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

				if (auditItem.Amount_Paid == 0 || auditItem.Amount_Paid == null)
				{
					auditItem.Amounts_Payment =
						decimal.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
					auditItem.Amounts_Payment = (auditItem.Tax_Amount + auditItem.Amounts_Payment);
					amountRemainingTextBox.Text = $"{auditItem.Amounts_Payment:#,0} تومان";
					auditItem.Amount_Remaininig = auditItem.Amounts_Payment;
					taxRateTextBox.Text = $"% {auditItem.Tax_Percent}";
				}
				else
				{
					auditItem.Amounts_Payment =
						decimal.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
					auditItem.Amounts_Payment = auditItem.Amount_Paid - (auditItem.Tax_Amount + auditItem.Amounts_Payment);
					amountRemainingTextBox.Text = $"{auditItem.Amounts_Payment:#,0} تومان";
					auditItem.Amount_Remaininig = auditItem.Amounts_Payment;
					taxRateTextBox.Text = $"% {auditItem.Tax_Percent}";
				}
			}
			else
			{
				if (auditItem.Amount_Paid == 0 || auditItem.Amount_Paid == null)
				{
					auditItem.Tax_Percent = int.Parse(taxRateTextBox.Text.Replace("%", string.Empty).Trim());
					if (auditItem.Tax_Percent > 10)
					{
						Mbb.Windows.Forms.MessageBox.Show
						(text: "بیشتر از 10% امکان دریافت مالیات وجود ندارد.",
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

						auditItem.Tax_Percent = 0;
						taxRateTextBox.Text = "% 0";
						taxRateTextBox.Select(2, 1);
						return;
					}
					else
					{
						auditItem.Amounts_Payment =
							decimal.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
						auditItem.Amounts_Payment = (auditItem.Tax_Amount + auditItem.Amounts_Payment);
						amountRemainingTextBox.Text = $"{auditItem.Amounts_Payment:#,0} تومان";
						auditItem.Amount_Remaininig = auditItem.Amounts_Payment;
						taxRateTextBox.Text = $"% {auditItem.Tax_Percent}";
					}
					return;
				}
				else
				{
					auditItem.Tax_Percent = int.Parse(taxRateTextBox.Text.Replace("%", string.Empty).Trim());
					if (auditItem.Tax_Percent > 10)
					{
						Mbb.Windows.Forms.MessageBox.Show
						(text: "بیشتر از 10% امکان دریافت مالیات وجود ندارد.",
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

						auditItem.Tax_Percent = 0;
						taxRateTextBox.Text = "% 0";
						taxRateTextBox.Select(2, 1);
						return;
					}
					else
					{
						auditItem.Amounts_Payment =
							decimal.Parse(amountPayableTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						auditItem.Tax_Percent = int.Parse(taxRateTextBox.Text.Replace("%", string.Empty).Trim());
						auditItem.Tax_Amount = (auditItem.Amounts_Payment / 100) * auditItem.Tax_Percent;
						auditItem.Amounts_Payment = auditItem.Amount_Paid - (auditItem.Tax_Amount + auditItem.Amounts_Payment);
						amountRemainingTextBox.Text = $"{auditItem.Amounts_Payment:#,0} تومان";
						auditItem.Amount_Remaininig = auditItem.Amounts_Payment;
						taxRateTextBox.Text = $"% {auditItem.Tax_Percent}";
					}
					return;
				}
			}
		}
		#endregion /EnterTaxPercentage

		#region FindClient
		/// <summary>
		/// بررسی وجود مشتری در سیستم
		/// </summary>
		/// <param name="_auditItem"></param>
		/// <returns>true Or false</returns>
		private bool FindClient(AuditItem _auditItem)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Client client =
					dataBaseContext.Clients
					.Where(current => string.Compare(current.Phone_Number, _auditItem.Phone_Number) == 0)
					.FirstOrDefault();

				if (client == null)
				{
					return false;
				}
				else
				{
					return true;
				}

			}
			catch (System.Exception ex)
			{

				throw;
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
		#endregion /FindClient

		#region Initialize
		/// <summary>
		/// تنظیمات ورود اولیه
		/// </summary>
		private void Initialize()
		{
			auditItem.Capital_Fund = GetCapitalFund();
			auditItem.InvoiceSerialNumber = SetInvoiceSerialNumber();
			invoiceSerialNumberTextBox.Text = auditItem.InvoiceSerialNumber;
			showFormAnimateWindow.Interval = 200;
			showFormAnimateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
			showFormAnimateWindow.Start();
			auditItem.Tax_Amount = 0;
			auditItem.Amounts_Payment = 0;
			auditItem.Amount_Paid = 0;
			auditItem.Register_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
			auditItem.Register_Time = Infrastructure.Utility.ShowTime();
			dateSetInvoiceTextBox.Text = $"{auditItem.Register_Date} - {auditItem.Register_Time}";




			CalculatePurchaseAmount();

			if (FindClient(auditItem))
			{
				return;
			}
			else
			{
				AddNewClient(auditItem);
			}
		}
		#endregion /Initialize

		#region GetCapitalFund
		/// <summary>
		/// به روز رسانی صندوق
		/// </summary>
		/// <returns></returns>
		private decimal? GetCapitalFund()
		{
			decimal? capital_Fund;
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

						Inventory.Program.MainForm.fundsNotificationTextBox.Text = $"{capital_Fund} تومان ";
					}
					else
					{
						capital_Fund = decimal.Parse(capitalFund.Capital_Fund.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						Inventory.Program.MainForm.fundsNotificationTextBox.Text = $"{capital_Fund:#,0} تومان ";
					}
				}

				return capital_Fund;

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
		#endregion /GetCapitalFund

		#region Payment
		private void Payment(AuditItem _auditItem)
		{
			_auditItem.Client_Name = clientNameTextBox.Text;

			if (_auditItem.Sales_Payment_Type == Models.SalesInvoice.SalesPaymentType.نقد)
			{
				if (Deposit(_auditItem) && SetSalesProduct(_auditItem) && SetAccountPayable(_auditItem) && SetDailyOffice(_auditItem))
				{
					SetDailyFinancialReport(auditItem);

					Infrastructure.Utility.WindowsNotification
						(message: "عملیات با موفقیت انجام گردید.",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

					Purchase_Operations = true;
					return;
				}
				else
				{
					Purchase_Operations = false;
					return;
				}
			}
			else if (_auditItem.Sales_Payment_Type == Models.SalesInvoice.SalesPaymentType.چک)
			{
				if (SetSalesProduct(_auditItem) && SetAccountPayable(_auditItem) && SetDailyOffice(_auditItem))
				{
					SetDailyFinancialReport(auditItem);

					Infrastructure.Utility.WindowsNotification
						(message: "عملیات با موفقیت انجام گردید.",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

					Purchase_Operations = true;

					Mbb.Windows.Forms.MessageBox.Show(
						text: "توجه: \n بعد از انجام خرید حتما به واحد چک \n جهت صدور چک مراجعه نمایید.",
						caption: "اعلان چک",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Information, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					return;
				}
				else
				{
					Purchase_Operations = false;
					return;
				}
			}
		}
		#endregion /Payment

		#region RefreshCalculator
		private void RefreshCalculator()
		{
			int amountPayable = 0;
			if (productsListDataGridView.RowCount >= 1)
			{
				foreach (System.Windows.Forms.DataGridViewRow row in productsListDataGridView.Rows)
				{
					amountPayable +=
						int.Parse(row.Cells[4].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					amountPayableTextBox.Text = $"{amountPayable:#,0} تومان";
					amountRemainingTextBox.Text = $"{amountPayable:#,0} تومان";
				}
			}
			else
			{
				return;
			}
		}
		#endregion /RefreshCalculator

		#region ResetAllControl
		private void ResetAllControl()
		{
			MyProcutSalesForm.RemoveBill();

			sellerNameTextBox.Text = "نام فروشنده";
			clientNameTextBox.Text = "نام مشتری";
			carrierNameTextBox.Text = "نام حامل کالا";
			productsListDataGridView.DataSource = null;
			auditItem.Tax_Percent = 0;
			auditItem.Tax_Amount = 0;
			auditItem.Amounts_Payment = 0;
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

		#region SetDailyFinancialReport
		/// <summary>
		/// ثبت گزارش مالی روزانه
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
						Amounts_Paid = $"0 تومان",
						Amounts_Payment = $"{auditItem.Amounts_Payment} تومان",
						Amounts_Received = $"{auditItem.Amount_Paid:#,0} تومان",
						Amounts_Remaining = $"{auditItem.Amount_Remaininig} تومان",
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

		#region SetDailyOffice
		/// <summary>
		/// ثبت تمام هزینه ها در دفتر روزنامه
		/// </summary>
		/// <param name="auditItem"></param>
		private bool SetDailyOffice(AuditItem auditItem)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Journal dailyOffice =
				new Models.Journal
				{
					Amount_Received = $"{auditItem.Amount_Paid: #,0} تومان",
					Amount_Paid = "0 تومان",
					Description = $"فروش لوازم یدکی",
					Invoice_Serial_Numvber = auditItem.InvoiceSerialNumber,
					Registration_Date = auditItem.Register_Date,
					Registration_Time = auditItem.Register_Time,
				};

				dataBaseContext.Journals.Add(dailyOffice);
				dataBaseContext.SaveChanges();

				return true;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
				return false;
			}
		}
		#endregion /SetDailyOffice

		#region SetFinancialClient
		/// <summary>
		/// ثبت در لیست مالی مشتریان
		/// </summary>
		/// <param name="_auditItem"></param>
		private void SetFinancialClient(AuditItem _auditItem)
		{
			if (_auditItem.Amount_Remaininig == 0)
			{
				_auditItem.Finantial_Situation = Models.ListFinancialClient.FinantialSituation.تسویه;
			}
			else if (_auditItem.Amount_Remaininig > 0)
			{
				_auditItem.Finantial_Situation = Models.ListFinancialClient.FinantialSituation.طلبکار;
			}
			else
			{
				_auditItem.Finantial_Situation = Models.ListFinancialClient.FinantialSituation.بدهکار;
			}

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ListFinancialClient listFinancialClient =
					new Models.ListFinancialClient()
					{
						Amount_Paid = $"{ _auditItem.Amount_Paid} تومان",
						Amounts_Payment = $"{ _auditItem.Amounts_Payment} تومان",
						Amount_Remaininig = $"{ _auditItem.Amount_Remaininig} تومان",
						Client_Name = _auditItem.Client_Name,
						Finantial_Situation = auditItem.Finantial_Situation,
						License_Plate = null,
						Phone_Number = _auditItem.Phone_Number,
						Registration_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}",
						Registration_Time = $"{Infrastructure.Utility.ShowTime()}",
						Tax_Percent = $"{_auditItem.Tax_Percent} %"
					};

				dataBaseContext.ListFinancialClients.Add(listFinancialClient);
				dataBaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{

				throw;
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
		#endregion /SetFinancialClient

		#region SetItemsBillSale
		public void SetItemsBillSale(System.Collections.Generic.List<ProcutSalesForm.BillSaleReportItems> billSaleReportItems, ProcutSalesForm.TransactionFactorsItems transactionFactorsItems)
		{
			foreach (var item in billSaleReportItems)
			{
				productsListDataGridView.Rows.Add
					(item.Product_Name,
					item.Product_Price,
					item.Product_Quantity.ToString(),
					item.Product_Unit,
					item.Total_Price);
			}
			sellerNameTextBox.Text = transactionFactorsItems.Seller_Name;
			auditItem.Seller_Name = transactionFactorsItems.Seller_Name;
			clientNameTextBox.Text = transactionFactorsItems.Client_Name;
			auditItem.Client_Name = transactionFactorsItems.Client_Name;
			carrierNameTextBox.Text = transactionFactorsItems.Carrier_Name;
			auditItem.Carrier_Name = transactionFactorsItems.Carrier_Name;
			auditItem.Phone_Number = transactionFactorsItems.Phone_Number;
		}
		#endregion /SetItemsBillSale

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

					Models.ServiceInvoice invoiceSerialNumber =
						dataBaseContext.ServiceInvoices
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

		#region SetPurchaseProduct
		/// <summary>
		/// ثبت خرید کالا
		/// </summary>
		/// <param name="_auditItem"></param>
		/// <returns>true or false</returns>
		private bool SetSalesProduct(AuditItem _auditItem)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				//---- ثبت در جدول فاکتور فروش کالا
				#region PurchaseInvoice
				Models.SalesInvoice salesInvoice =
					new Models.SalesInvoice
					{
						Carrier_Name = _auditItem.Carrier_Name,
						Client_Name = _auditItem.Client_Name,
						Invoice_Serial_Numvber = _auditItem.InvoiceSerialNumber,
						Sales_Payment_Type = _auditItem.Sales_Payment_Type,
						Payment_Cach_Type = _auditItem.Payment_Cach_Type,
						Sales_Date = _auditItem.Register_Date,
						Sales_Time = _auditItem.Register_Time,
						Seller_Name = _auditItem.Seller_Name,
						Total_Sum_Price = $"{_auditItem.Amounts_Payment:#,0} تومان",
					};
				dataBaseContext.SalesInvoices.Add(salesInvoice);
				dataBaseContext.SaveChanges();
				#endregion /SetPurchaseProduct

				//---- ثبت در جدول فروش کالا
				#region ListPurchaseProduct
				foreach (System.Windows.Forms.DataGridViewRow row in productsListDataGridView.Rows)
				{
					Models.ListSalesProduct listSalesProduct =
					new Models.ListSalesProduct()
					{
						Invoice_Serial_Numvber = _auditItem.InvoiceSerialNumber,
						Product_Name = row.Cells[0].Value.ToString(),
						Product_Price = row.Cells[1].Value.ToString(),
						Product_Quantity = int.Parse(row.Cells[2].Value.ToString()),
						Product_Unit = row.Cells[3].Value.ToString(),
					};
					dataBaseContext.ListSalesProducts.Add(listSalesProduct);
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

		#endregion /Function


	}
}

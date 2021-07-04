using System.Linq;

namespace Inventory_Forms
{
	public partial class BillSaleReportForm : Infrastructure.EmptyForm
	{
		#region Properties

		#region Layer
		private class AuditItem
		{
			public int? Amount { get; set; }
			public int? Amount_Payable { get; set; }
			public int? Amount_Payment { get; set; }
			public string Client_Name { get; set; }
			public string Carrier_Name { get; set; }
			public int? Cash_Payment_Amount { get; set; }
			public string InvoiceSerialNumber { get; set; }
			public int Product_Price { get; set; }
			public int? Pose_Payment_Amount { get; set; }
			public string Seller_Name { get; set; }
			public int? Tax_Amount { get; set; }
			public int? Tax_Percent { get; set; }
		}

		private class BillItems
		{
			public string Product_Name { get; set; }
			public int? Product_Quantity { get; set; }
			public string Product_Unit { get; set; }
			public string Product_Price { get; set; }
			public string Total_Price { get; set; }
		}

		private BillSalePrintForm _billSalePrintForm = null;
		public BillSalePrintForm BillSalePrintForm
		{
			get
			{
				if (_billSalePrintForm == null || _billSalePrintForm.IsDisposed == true)
				{
					_billSalePrintForm =
						new BillSalePrintForm();
				}
				return _billSalePrintForm;
			}
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

		private Models.AccountsReceivable _financialFundInput;
		public Models.AccountsReceivable FinancialFundInput
		{
			get
			{
				if (_financialFundInput == null)
				{
					_financialFundInput =
						new Models.AccountsReceivable();
				}
				return _financialFundInput;
			}
			set
			{
				_financialFundInput = value;
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

		#endregion /Layer

		private AuditItem auditItem = new AuditItem();

		#endregion /Properties

		public BillSaleReportForm()
		{
			InitializeComponent();

			auditItem.InvoiceSerialNumber = SetInvoiceSerialNumber();
			invoiceSerialNumberTextBox.Text = auditItem.InvoiceSerialNumber;

			gunaAnimateWindow.Interval = 200;
			gunaAnimateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
			gunaAnimateWindow.Start();

			auditItem.Tax_Amount = 0;
			auditItem.Amount_Payable = 0;
			auditItem.Amount_Payment = 0;
			dateSetInvoiceTextBox.Text = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} - {Infrastructure.Utility.ShowTime()}";
		}

		//----------Beginning of the code!----------

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			if (productsListDataGridView.RowCount >= 1)
			{
				if (Mbb.Windows.Forms.MessageBox.Show(text: "آیا فاکتور جاری حذف گردد؟", caption: "حذف فاکتور", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
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
			int _productPrice,
				_productQuantity,
				_sumPrice,
				_totalSumPrice = 0; 

			if ((e.ColumnIndex == 1 && e.RowIndex >= 0))
			{
				_productPrice = int.Parse(productsListDataGridView.CurrentRow.Cells[e.ColumnIndex].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());				
				_productQuantity = int.Parse(productsListDataGridView.CurrentRow.Cells[e.ColumnIndex+1].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				_sumPrice = (_productPrice * _productQuantity);
				productsListDataGridView.CurrentRow.Cells[4].Value = $"{_sumPrice:#,0} تومان";
				productsListDataGridView.CurrentRow.Cells[e.ColumnIndex].Value = $"{_productPrice:#,0} تومان";

				foreach (System.Windows.Forms.DataGridViewRow row in productsListDataGridView.Rows)
				{
					_totalSumPrice += int.Parse(row.Cells[4].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					amountPayableTextBox.Text = $"{_totalSumPrice:#,0} تومان";
				}

				EditBill();

				return;
			}
			else if ((e.ColumnIndex == 2 && e.RowIndex >= 0))
			{
				_productPrice = int.Parse(productsListDataGridView.CurrentRow.Cells[e.ColumnIndex-1].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				_productQuantity = int.Parse(productsListDataGridView.CurrentRow.Cells[e.ColumnIndex].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				_sumPrice = (_productPrice * _productQuantity);
				productsListDataGridView.CurrentRow.Cells[4].Value = $"{_sumPrice:#,0} تومان";
				foreach (System.Windows.Forms.DataGridViewRow row in productsListDataGridView.Rows)
				{
					_totalSumPrice += int.Parse(row.Cells[4].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					amountPayableTextBox.Text = $"{_totalSumPrice:#,0} تومان";
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
			remainingAmountTextBox.Text = amountPayableTextBox.Text;
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
				taxRateTextBox.Select(2,1);
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
			if (string.IsNullOrWhiteSpace(taxRateTextBox.Text) ||
				(string.Compare(taxRateTextBox.Text, "% 0") == 0 ||
				(string.Compare(taxRateTextBox.Text, "% ") == 0 ||
				string.Compare(taxRateTextBox.Text, "%") == 0)))
			{
				auditItem.Tax_Percent = 0;
				taxRateTextBox.Clear();
				return;
			}
			else
			{
				if (auditItem.Amount_Payment == 0 || auditItem.Amount_Payment == null)
				{
					auditItem.Tax_Percent = int.Parse(taxRateTextBox.Text.Replace("%", string.Empty).Trim());
					if (auditItem.Tax_Percent > 5)
					{
						Mbb.Windows.Forms.MessageBox.Show
						(text: "بیشتر از 5% امکان دریافت مالیات وجود ندارد.",
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
						auditItem.Tax_Amount = (auditItem.Amount_Payable / 100) * auditItem.Tax_Percent;
						auditItem.Amount_Payable = (auditItem.Tax_Amount + auditItem.Amount_Payable);
						remainingAmountTextBox.Text = $"{auditItem.Amount_Payable:#,0} تومان";
						taxRateTextBox.Text = $"% {auditItem.Tax_Percent}";
					}
					return;
				}
				else
				{
					auditItem.Tax_Percent = int.Parse(taxRateTextBox.Text.Replace("%", string.Empty).Trim());
					if (auditItem.Tax_Percent > 5)
					{
						Mbb.Windows.Forms.MessageBox.Show
						(text: "بیشتر از 5% امکان دریافت مالیات وجود ندارد.",
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
						auditItem.Tax_Percent = int.Parse(taxRateTextBox.Text.Replace("%", string.Empty).Trim());
						auditItem.Tax_Amount = (auditItem.Amount_Payable / 100) * auditItem.Tax_Percent;
						auditItem.Amount_Payable = (auditItem.Tax_Amount + auditItem.Amount_Payable) - auditItem.Amount_Payment;
						remainingAmountTextBox.Text = $"{auditItem.Amount_Payable:#,0} تومان";
						taxRateTextBox.Text = $"% {auditItem.Tax_Percent}";
					}
					return;
				}
			}
		}
		#endregion /TaxRateTextBox_TextChange

		#region AmountPaymentTextBox_TextChanged
		private void AmountPaymentTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(amountPaymentTextBox.Text, "0 تومان") == 0 ||
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
				if (auditItem.Tax_Amount == 0 || auditItem.Tax_Amount == null)
				{
					auditItem.Amount_Payable = auditItem.Amount_Payment - auditItem.Amount_Payable;
					remainingAmountTextBox.Text = $"{auditItem.Amount_Payable:#,0} تومان";
				}
				else
				{
					auditItem.Tax_Percent = int.Parse(taxRateTextBox.Text.Replace("%", string.Empty).Trim());
					auditItem.Tax_Amount = (auditItem.Amount_Payable / 100) * auditItem.Tax_Percent;
					auditItem.Amount_Payable = (auditItem.Tax_Amount + auditItem.Amount_Payable) - auditItem.Amount_Payment;
					remainingAmountTextBox.Text = $"{auditItem.Amount_Payable:#,0} تومان";
				}
			}
		}
		#endregion /AmountPaymentTextBox_TextChanged

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
				(printInvoice.GetComponentByName("amountPaymentTextBox") as Stimulsoft.Report.Components.StiText).Text = amountPaymentTextBox.Text;
				(printInvoice.GetComponentByName("remainingAmountTextBox") as Stimulsoft.Report.Components.StiText).Text = remainingAmountTextBox.Text;

				printInvoice.Render(true);
				BillSalePrintForm.billsaleStiRibbonViewerControl.Report = printInvoice;
				BillSalePrintForm.ShowDialog();
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
			FinancialFundInput.Amount_Payable = amountPayableTextBox.Text;
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
					auditItem.Amount = null;
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
			if (string.IsNullOrWhiteSpace(cashPaymentTextBox.Text) || string.Compare(cashPaymentTextBox.Text, "0 تومان") == 0 || string.Compare(cashPaymentTextBox.Text, " تومان") == 0 || string.Compare(cashPaymentTextBox.Text, "تومان") == 0 || string.Compare(cashPaymentTextBox.Text, "توما") == 0 || string.Compare(cashPaymentTextBox.Text, "توم") == 0 || string.Compare(cashPaymentTextBox.Text, "تو") == 0 || string.Compare(cashPaymentTextBox.Text, "ت") == 0)
			{
				auditItem.Cash_Payment_Amount = 0;
				auditItem.Amount_Payment = auditItem.Cash_Payment_Amount + auditItem.Pose_Payment_Amount;
				amountPaymentTextBox.Text = $"{auditItem.Amount_Payment: #,0} تومان";
				return;
			}
			else
			{
				auditItem.Cash_Payment_Amount = int.Parse(cashPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				if (auditItem.Pose_Payment_Amount == 0 || auditItem.Pose_Payment_Amount == null)
				{
					auditItem.Amount_Payment = auditItem.Cash_Payment_Amount;
					amountPaymentTextBox.Text = $"{auditItem.Cash_Payment_Amount: #,0} تومان";
				}
				else
				{
					auditItem.Amount_Payment = auditItem.Cash_Payment_Amount + auditItem.Pose_Payment_Amount;
					amountPaymentTextBox.Text = $"{auditItem.Amount_Payment: #,0} تومان";
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
					auditItem.Amount = null;
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
				auditItem.Amount = int.Parse(posPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				posPaymentTextBox.Text = $"{auditItem.Amount:#,0} تومان";
			}
		}
		#endregion /PosPaymentTextBox_Leave

		#region PosPaymentTextBox_TextChange
		private void PosPaymentTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(posPaymentTextBox.Text) || string.Compare(posPaymentTextBox.Text, "0 تومان") == 0 || string.Compare(posPaymentTextBox.Text, " تومان") == 0 || string.Compare(posPaymentTextBox.Text, "تومان") == 0 || string.Compare(posPaymentTextBox.Text, "توما") == 0 || string.Compare(posPaymentTextBox.Text, "توم") == 0 || string.Compare(posPaymentTextBox.Text, "تو") == 0 || string.Compare(posPaymentTextBox.Text, "ت") == 0)
			{
				auditItem.Pose_Payment_Amount = 0;
				auditItem.Amount_Payment = auditItem.Cash_Payment_Amount + auditItem.Pose_Payment_Amount;
				amountPaymentTextBox.Text = $"{auditItem.Amount_Payment: #,0} تومان";
				return;
			}
			else
			{
				auditItem.Pose_Payment_Amount = int.Parse(posPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				if (auditItem.Cash_Payment_Amount == 0 || auditItem.Cash_Payment_Amount == null)
				{
					auditItem.Amount_Payment = auditItem.Pose_Payment_Amount;
					amountPaymentTextBox.Text = $"{auditItem.Pose_Payment_Amount: #,0} تومان";
				}
				else
				{
					auditItem.Amount_Payment = auditItem.Cash_Payment_Amount + auditItem.Pose_Payment_Amount;
					amountPaymentTextBox.Text = $"{auditItem.Amount_Payment: #,0} تومان";
				}
			}
		}
		#endregion /PosPaymentTextBox_TextChange

		#region CachPaymentRadioButton_CheckedChanged
		private void CachPaymentRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			cashPaymentTextBox.Clear();
			posPaymentTextBox.Clear();

			auditItem.Cash_Payment_Amount = 0;
			auditItem.Pose_Payment_Amount = 0;
			auditItem.Amount_Payment = 0;

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

			auditItem.Cash_Payment_Amount = 0;
			auditItem.Pose_Payment_Amount = 0;
			auditItem.Amount_Payment = 0;

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

			auditItem.Cash_Payment_Amount = 0;
			auditItem.Pose_Payment_Amount = 0;
			auditItem.Amount_Payment = 0;

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

			auditItem.Cash_Payment_Amount = 0;
			auditItem.Pose_Payment_Amount = 0;
			auditItem.Amount_Payment = 0;

			amountPaymentTextBox.Text = "0 تومان";
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

		//----------End of code!----------

		#region Function

		#region CalculatePurchaseAmount
		public void CalculatePurchaseAmount()
		{
			if (productsListDataGridView.RowCount >= 1)
			{
				foreach (System.Windows.Forms.DataGridViewRow row in productsListDataGridView.Rows)
				{
					auditItem.Amount_Payable +=
						int.Parse(row.Cells[4].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					amountPayableTextBox.Text = $"{auditItem.Amount_Payable:#,0} تومان";
					remainingAmountTextBox.Text = $"{auditItem.Amount_Payable:#,0} تومان";
				}
			}
			else
			{
				return;
			}
		}
		#endregion /CalculatePurchaseAmount

		#region EditBill
		private	void EditBill()
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
			MyProcutSalesForm.billSaleReportsList.Clear();
			MyProcutSalesForm.billSaleReportsList = billSaleReportItemsList.ToList();
			MyProcutSalesForm.billSaleReportsList.TrimExcess();
		}
		#endregion /EditBill

		#region RefreshCalculator
		private	void RefreshCalculator()
		{
			int amountPayable = 0;
			if (productsListDataGridView.RowCount >= 1)
			{
				foreach (System.Windows.Forms.DataGridViewRow row in productsListDataGridView.Rows)
				{
					amountPayable +=
						int.Parse(row.Cells[4].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					amountPayableTextBox.Text = $"{amountPayable:#,0} تومان";
					remainingAmountTextBox.Text = $"{amountPayable:#,0} تومان";
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
			MyProcutSalesForm.billSaleReportsList.Clear();
			MyProcutSalesForm.transactionFactorsItems = null;

			sellerNameTextBox.Text = "نام فروشنده";
			clientNameTextBox.Text = "نام مشتری";
			carrierNameTextBox.Text = "نام حامل کالا";
			productsListDataGridView.DataSource = null;
			auditItem.Tax_Percent = 0;
			auditItem.Tax_Amount = 0;
			auditItem.Amount_Payable = 0;
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
		}
		#endregion /SetItemsBillSale

		#region SetInvoiceSerialNumber
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
		/// ثبت داده های مالی در دفتر معین پرداختی
		/// </summary>
		/// <param name="_accountsReceivable"></param>
		private void RecivedAccountBook(Models.AccountsReceivable _accountsReceivable)
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

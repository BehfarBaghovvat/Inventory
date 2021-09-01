namespace ChequaBank
{
	public partial class IssuanceChequaUC : System.Windows.Forms.UserControl
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers
		#region Properties
		public Models.ChequeSection ChequeSection { get; set; }
		#endregion /Properties

		public IssuanceChequaUC()
		{
			InitializeComponent();
		}

		private void DataReceiptTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}

		private void DataReceiptTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}

		private void DataReceiptTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(dataReceiptTextBox.Text))
			{
				ChequeSection.Data_Receipt = null;
				return;
			}
			else if (dataReceiptTextBox.Text.Length < 8)
			{
				dataReceiptTextBox.Focus();
				ChequeSection.Data_Receipt = null;
				return;
			}
			else
			{
				ChequeSection.Data_Receipt = dataReceiptTextBox.Text.Insert(4, "/").Insert(7, "/");
			}
		}

		private void NumberChequaTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}

		private void NumberChequaTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
			if (dataReceiptTextBox.Text.Length > 16)
			{
				Mbb.Windows.Forms.MessageBox.Show(
					   text: ".شماره وارد شده از 16 رقم بیشتر می باشد \n .لطفا مجدد تلاش نمایید",
					   caption: "خطای ورودی",
					   icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					   button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				e.Handled = true;
				return;
			}
		}

		private void NumberChequaTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(dataReceiptTextBox.Text))
			{
				ChequeSection.Number_Chequa = null;
				return;
			}
			else if (dataReceiptTextBox.Text.Length < 16)
			{
				Mbb.Windows.Forms.MessageBox.Show(
					text: ".شماره وارد شده از 16 رقم کمتر می باشد \n .لطفا مجدد تلاش نمایید",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				numberChequaLabel.Focus();
				ChequeSection.Number_Chequa = null;
				return;
			}
			else
			{
				ChequeSection.Number_Chequa = numberChequaTextBox.Text;
			}
		}

		private void AmountWordsTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}

		private void AmountWordsTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		private void AmountWordsTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(amountWordsTextBox.Text))
			{
				ChequeSection.Amount_Words_Paid = null;
				return;
			}
			else
			{
				ChequeSection.Amount_Words_Paid = amountWordsTextBox.Text;
			}
		}

		private void PayToTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}

		private void PayToTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		private void PayToTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(payToTextBox.Text))
			{
				ChequeSection.Pay_To = null;
				return;
			}
			else
			{
				ChequeSection.Pay_To = payToTextBox.Text;
			}
		}

		private void NationalCodeTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}

		private void NationalCodeTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
			if (nationalCodeTextBox.Text.Length > 10)
			{
				Mbb.Windows.Forms.MessageBox.Show(
					text: ".کد ملی وارد شده از 10 رقم بیشتر می باشد \n .لطفا مجدد تلاش نمایید",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				e.Handled = true;
				return;
			}
		}

		private void NationalCodeTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nationalCodeTextBox.Text))
			{
				ChequeSection.Number_Chequa = null;
				return;
			}
			else if (nationalCodeTextBox.Text.Length < 10)
			{
				nationalCodeTextBox.Focus();
				ChequeSection.Number_Chequa = null;
				return;
			}
			else
			{
				ChequeSection.Number_Chequa = nationalCodeTextBox.Text.Insert(3,"-").Insert(10,"-");
			}
		}

		private void AmountNumberTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}

		private void AmountNumberTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}

		private void AmountNumberTextBox_Leave(object sender, System.EventArgs e)
		{

		}

		private void AmountNumberTextBox_TextChange(object sender, System.EventArgs e)
		{

		}

		
	}
}

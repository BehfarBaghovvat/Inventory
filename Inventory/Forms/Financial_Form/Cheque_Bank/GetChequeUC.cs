namespace Chequa_Bank
{
	public partial class GetChequaUC : System.Windows.Forms.UserControl
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties
		private Models.ChequeSection _chequeSection;
		public Models.ChequeSection ChequeSection 
		{ 
			get
			{
				if (_chequeSection == null)
				{
					_chequeSection =
						new Models.ChequeSection();
				}
				return _chequeSection;
			}

			set
			{
				_chequeSection = value;
			}
		}
		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public GetChequaUC()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region GetChequaUC_Load
		private void GetChequaUC_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /GetChequaUC_Load

		#region DataReceiptTextBox_Enter
		private void DataReceiptTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /DataReceiptTextBox_Enter

		#region DataReceiptTextBox_KeyPress
		private void DataReceiptTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /DataReceiptTextBox_KeyPress

		#region DataReceiptTextBox_Leave
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
		#endregion /DataReceiptTextBox_Leave

		#region SerialChequeTextBox_Enter
		private void SerialChequeTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /SerialChequeTextBox_Enter

		#region SerialChequeTextBox_KeyPress
		private void SerialChequeTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
		#endregion /SerialChequeTextBox_KeyPress

		#region SerialChequeTextBox_Leave
		private void SerialChequeTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(dataReceiptTextBox.Text))
			{
				ChequeSection.Serial_Cheque = null;
				return;
			}
			else if (dataReceiptTextBox.Text.Length < 16 || dataReceiptTextBox.Text.Length > 16)
			{
				Mbb.Windows.Forms.MessageBox.Show(
					text: ".اندازه شماره وارد شده از صحیح نمی باشد \n .لطفا مجدد تلاش نمایید",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				numberChequaLabel.Focus();
				ChequeSection.Serial_Cheque = null;
				return;
			}
			else
			{
				ChequeSection.Serial_Cheque = serialChequeTextBox.Text;
			}
		}
		#endregion /SerialChequeTextBox_Leave

		#region AmountWordsTextBox_Enter
		private void AmountWordsTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /AmountWordsTextBox_Enter

		#region AmountWordsTextBox_KeyPress
		private void AmountWordsTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /AmountWordsTextBox_KeyPress

		#region AmountWordsTextBox_TextChange
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
		#endregion /AmountWordsTextBox_TextChange

		#region NationalCodeTextBox_Enter
		private void NationalCodeTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion NationalCodeTextBox_Enter

		#region NationalCodeTextBox_KeyPress
		private void NationalCodeTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /NationalCodeTextBox_KeyPress

		#region NationalCodeTextBox_Leave
		private void NationalCodeTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nationalCodeTextBox.Text))
			{
				ChequeSection.National_Code = null;
				return;
			}
			else if (nationalCodeTextBox.Text.Length < 10 || nationalCodeTextBox.Text.Length > 10)
			{
				Mbb.Windows.Forms.MessageBox.Show(
					text: ".اندازه کد ملی وارد شده از صحیح نمی باشد \n .لطفا مجدد تلاش نمایید",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				nationalCodeTextBox.Focus();
				ChequeSection.National_Code = null;
				return;
			}
			else
			{
				ChequeSection.National_Code = nationalCodeTextBox.Text.Insert(3, "-").Insert(10, "-");
			}
		}
		#endregion /NationalCodeTextBox_Leave

		#region NameAccountHolderTextBox_Enter
		private void NameAccountHolderTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /NameAccountHolderTextBox_Enter

		#region NameAccountHolderTextBox_KeyPress
		private void NameAccountHolderTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /NameAccountHolderTextBox_KeyPress

		#region NameAccountHolderTextBox_TextChange
		private void NameAccountHolderTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nameAccountHolderTextBox.Text))
			{
				ChequeSection.Name_Account_Holder = null;
				return;
			}
			else
			{
				ChequeSection.Name_Account_Holder = nameAccountHolderTextBox.Text;
			}
		}
		#endregion /NameAccountHolderTextBox_TextChange

		#region AmountNumberTextBox_Enter
		private void AmountNumberTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			amountNumberTextBox.Text = "0 تومان";

			amountNumberTextBox.Select(0, amountNumberTextBox.Text.Length - 6);

			if (amountNumberTextBox.Text.Contains("تومان"))
			{
				return;
			}

		}
		#endregion /AmountNumberTextBox_Enter

		#region AmountNumberTextBox_KeyPress
		private void AmountNumberTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /AmountNumberTextBox_KeyPress

		#region AmountNumberTextBox_Leave
		private void AmountNumberTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(amountNumberTextBox.Text) || string.Compare(amountNumberTextBox.Text, "0 تومان") == 0 || amountNumberTextBox.Text.Length <= 6)
			{
				amountNumberTextBox.Clear();
				ChequeSection.Amount_Number_Paid = null;
				return;
			}
			else

			{
				ChequeSection.Amount_Number_Paid = amountNumberTextBox.Text;
				return;
			}
		}
		#endregion /AmountNumberTextBox_Leave

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if (ValidationData(ChequeSection))
			{
				if (SetDataToChequeBank(ChequeSection))
				{
					Infrastructure.Utility.WindowsNotification(message: "ثبت چک با موفقیت انجام گردید", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
					return;
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
		#endregion /SaveButton_Click

		#region CancelButton_Click
		private void CancelButton_Click(object sender, System.EventArgs e)
		{
			AllClear();
		}
		#endregion /CancelButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Function

		#region AllClear
		/// <summary>
		/// پاک کردن اطلاعات داخل کنترل ها
		/// </summary>
		public void AllClear()
		{
			ChequeSection = null;
			dataReceiptTextBox.Clear();
			serialChequeTextBox.Clear();
			amountWordsTextBox.Clear();
			nationalCodeTextBox.Clear();
			nameAccountHolderTextBox.Clear();
			amountNumberTextBox.Clear();
		}
		#endregion /AllClear

		#region Initialize
		/// <summary>
		/// تنظیمات ورودی اولیه
		/// </summary>
		private void Initialize()
		{
			ChequeSection.Pay_To = payToTextBox.Text;
		}
		#endregion /Initialize

		#region ValidationData
		/// <summary>
		/// صحت ورودی اطلاعات بررسی می گردد
		/// </summary>
		/// <param name="_chequeSection"></param>
		/// <returns>true or false</returns>
		private bool ValidationData(Models.ChequeSection _chequeSection)
		{
			string errorMessage = null;

			if (string.IsNullOrWhiteSpace(_chequeSection.Data_Receipt))
			{
				errorMessage = $".لطفا تاریخ چک را وارد نمایید";
			}
			else if (string.IsNullOrWhiteSpace(_chequeSection.Serial_Cheque))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += $".لطفا شناسه 16 رقمی صیاد را وارد نمایید";
			}
			else if (string.IsNullOrWhiteSpace(_chequeSection.Amount_Words_Paid))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += $".لطفا مبلغ چک را به حروف وارد نمایید";
			}
			else if (string.IsNullOrWhiteSpace(_chequeSection.Pay_To))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += $".لطفا تعیین فرمایید چک در وجه چه کسی است";
			}
			else if (string.IsNullOrWhiteSpace(_chequeSection.National_Code))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += $".لطفا کد ملی را وارد نمایید";
			}
			else if (string.IsNullOrWhiteSpace(_chequeSection.Amount_Words_Paid))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += $".لطفا مبلغ چک را به عدد وارد نمایید";
			}

			if (!string.IsNullOrEmpty(errorMessage))
			{
				if (string.IsNullOrEmpty(_chequeSection.Data_Receipt))
				{
					dataReceiptTextBox.Focus();
				}
				if (string.IsNullOrEmpty(_chequeSection.Serial_Cheque))
				{
					serialChequeTextBox.Focus();
				}
				if (string.IsNullOrEmpty(_chequeSection.Amount_Words_Paid))
				{
					amountWordsTextBox.Focus();
				}
				if (string.IsNullOrEmpty(_chequeSection.Pay_To))
				{
					payToTextBox.Focus();
				}
				if (string.IsNullOrEmpty(_chequeSection.National_Code))
				{
					nationalCodeTextBox.Focus();
				}
				if (string.IsNullOrEmpty(_chequeSection.Amount_Number_Paid))
				{
					amountNumberTextBox.Focus();
				}

				Mbb.Windows.Forms.MessageBox.Show(
					text: errorMessage,
					caption: "",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				return false;
			}
			else
			{
				return true;
			}
		}
		#endregion /ValidationData

		#region SetDataToChequeBank
		/// <summary>
		/// ثبت در جدول چکهای بانکی
		/// </summary>
		/// <param name="_chequeSection"></param>
		/// <returns>true or false</returns>
		private bool SetDataToChequeBank(Models.ChequeSection _chequeSection)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ChequeSection chequeSection =
					new Models.ChequeSection()
					{
						Amount_Number_Paid = " 0 تومان",
						Amount_Words_Paid = "صفر تومان", 
						Amount_Number_Received = _chequeSection.Amount_Number_Paid,
						Amount_Words_Received = _chequeSection.Amount_Words_Paid,
						Data_Receipt = _chequeSection.Data_Receipt,
						Name_Account_Holder = _chequeSection.Name_Account_Holder,
						National_Code = _chequeSection.National_Code,
						Pay_To = _chequeSection.Pay_To,
						Serial_Cheque = _chequeSection.Serial_Cheque,
						Status_Chequa = Models.ChequeSection.StatusChequa.نامشخص,
					};

				dataBaseContext.ChequeSections.Add(chequeSection);
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
		#endregion /SetDataToChequeBank

		#endregion /Function

		
	}
}

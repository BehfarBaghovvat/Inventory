using System.Linq;

namespace Inventory_Forms
{
	public partial class ServiceForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Layer
		/// <summary>
		/// کلاس حسابرسی
		/// </summary>
		private class AuditItem
		{
			public decimal? Amounts_Payment { get; set; }
			public decimal? Amount_Paid { get; set; }
			public decimal? Amount_Remaininig { get; set; }
			public decimal? Capital_Fund { get; set; }
			public decimal? Cash_Payment_Amount { get; set; }
			public string  Client_Name { get; set; }
			public Models.ListFinancialClient.FinantialSituationClient Finantial_Situation { get; set; }
			public string Invoice_Serial_Number { get; set; }
			public string License_Plate { get; set; }
			public string Phone_Number { get; set; }
			public decimal? Pose_Payment_Amount { get; set; }
			public decimal? Price { get; set; }
			public string Register_Date { get; set; }
			public string Register_Time { get; set; }
		}

		/// <summary>
		/// این کلاس به همراه خصوصیات آن جهت انتقال اطلاعات به داخل گزارش
		/// تهیه گردیده است.
		/// </summary>
		private class ServiceItem
		{
			//نکته: به یاد داشته باشید که نام پراپرتیز ها باید هم نام با عناصر داخل گزارش باشد
			// در غیر این صورت داده ها انتقال پیدا نمیکند.
			public string Service_Name { get; set; }
			public string Description { get; set; }
			public string Service_Price { get; set; }
			public int Service_Number { get; set; }
			public string TotalPrice { get; set; }
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

		private Inventory_Forms.ServiceReportForm _serviceReportForm;
		public Inventory_Forms.ServiceReportForm ServiceReportForm
		{
			get 
			{
				if (_serviceReportForm == null || _serviceReportForm.IsDisposed == true)
				{
					_serviceReportForm =
						new ServiceReportForm();
				}
				return _serviceReportForm;
			}
			set 
			{ 
				_serviceReportForm = value;
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

		private AuditItem _auditItem = new AuditItem();

		private Models.AccountsReceivable _accountsReceivable = null;
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

		private Models.EventLog _eventLog = null;
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
			set { _eventLog = value; }
		}	

		private Models.ServiceInvoice _serviceInvoice = null;
		public Models.ServiceInvoice ServiceInvoice
		{
			get
			{
				if (_serviceInvoice == null)
				{
					_serviceInvoice =
						new Models.ServiceInvoice();
				}
				return _serviceInvoice;
			}
			set
			{
				_serviceInvoice = value;
			}
		}

		private Models.ListService _listService = null;
		public Models.ListService ListService
		{
			get
			{
				if (_listService == null)
				{
					_listService =
						new Models.ListService();
				}
				return _listService;
			}
			set { _listService = value; }
		}

		public bool Client_Availability { get; set; }

		long currentKM, nextKM;

		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public ServiceForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region ServiceForm_Load
		private void ServiceForm_Load(object sender, System.EventArgs e)
		{

		}
		#endregion /ServiceForm_Load

		#region ClientNameTextBox_Enter
		private void ClientNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /ClientNameTextBox_Enter

		#region ClientNameTextBox_KeyPress
		private void ClientNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /ClientNameTextBox_KeyPress

		#region ClientNameTextBox_TextChange
		private void ClientNameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientNameTextBox.Text))
			{
				ServiceInvoice.Client_Name = null;
				_auditItem.Client_Name = null;
				return;
			}
			else
			{
				ServiceInvoice.Client_Name = clientNameTextBox.Text;
				_auditItem.Client_Name = clientNameTextBox.Text;
			}
		}
		#endregion /ClientNameTextBox_TextChange

		#region LicensePlateGroupBox_Leave
		private void LicensePlateGroupBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(numTextBox1.Text) || string.IsNullOrWhiteSpace(numTextBox2.Text) || string.IsNullOrWhiteSpace(numTextBox3.Text))
			{
				_auditItem.License_Plate = null;
				return;
			}
			else
			{
				_auditItem.License_Plate =
					$"{numTextBox3.Text}{iranLabel.Text} - {numTextBox2.Text}{alphabetComboBox.SelectedItem} - {numTextBox1.Text}";
			}
		}
		#endregion /LicensePlateGroupBox_Leave

		#region PhoneNumberTextBox_Enter
		private void PhoneNumberTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /PhoneNumberTextBox_Enter

		#region PhoneNumberTextBox_KeyPress
		private void PhoneNumberTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /PhoneNumberTextBox_KeyPress

		#region PhoneNumberTextBox_Leave
		private void PhoneNumberTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
			{
				phoneNumberTextBox.Clear();
				phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else if (!phoneNumberTextBox.Text.StartsWith("09"))
			{
				Mbb.Windows.Forms.MessageBox.Show(
				text: "فرمت شماره تلفن همراه صحیح نمی باشد. \n لطفا مجدد تلاش نمایید.",
				caption: "خطای ورودی",
				icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
				button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				phoneNumberTextBox.SelectAll();
				phoneNumberTextBox.Focus();
				return;
			}
			else if (phoneNumberTextBox.Text.Length < 11)
			{
				Mbb.Windows.Forms.MessageBox.Show(
					text: "تعداد ارقام وارد شده کمتر از 11 رقم می باشد. \n لطفا مجدد تلاش نمایید.",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				phoneNumberTextBox.Focus();
				return;
			}
			else if (phoneNumberTextBox.Text.Length == 11)
			{
				phoneNumberTextBox.Text = phoneNumberTextBox.Text.Insert(4, "-");
			}
			else if (phoneNumberTextBox.Text.Length >= 12 && !phoneNumberTextBox.Text.Contains('-'))
			{
				Mbb.Windows.Forms.MessageBox.Show(
				text: "تعداد ارقام وارد شده بیشتر از 11 رقم می باشد. \n لطفا مجدد تلاش نمایید.",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				phoneNumberTextBox.SelectAll();
				phoneNumberTextBox.Focus();
				return;
			}
		}
		#endregion /PhoneNumberTextBox_Leave

		#region PhoneNumberTextBox_TextChange
		private void PhoneNumberTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
			{
				phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
			else
			{
				phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				GetClientName(phoneNumberTextBox.Text);
			}
		}
		#endregion /PhoneNumberTextBox_TextChange

		#region ServceNameComboBox_SelectionChangeCommitted
		private void ServiceNameComboBox_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			SetServicePrice();
		}
		#endregion /ServceNameComboBox_SelectionChangeCommitted

		#region ServicePriceTextBox_Enter
		private void ServicePriceTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (string.IsNullOrWhiteSpace(servicePriceTextBox.Text))
			{
				_auditItem.Price = null;
				servicePriceTextBox.Text = "0 تومان";
				servicePriceTextBox.Select(0, 1);
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
			else if (servicePriceTextBox.Text.Contains("تومان"))
			{
				return;
			}
		}
		#endregion /ServicePriceTextBox_Enter

		#region ServicePriceTextBox_KeyPress
		private void ServicePriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /ServicePriceTextBox_KeyPress

		#region ServicePriceTextBox_Leave
		private void ServicePriceTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(servicePriceTextBox.Text))
			{
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				ListService.Service_Price = null;
				return;
			}
			else if (string.Compare(servicePriceTextBox.Text, "0 تومان") == 0)
			{
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				servicePriceTextBox.Clear();
				_auditItem.Price = null;
				ListService.Service_Price = null;
				return;

			}
			else if (string.Compare(servicePriceTextBox.Text, " تومان") == 0 ||
				string.Compare(servicePriceTextBox.Text, "تومان") == 0 ||
				string.Compare(servicePriceTextBox.Text, "توما") == 0 ||
				string.Compare(servicePriceTextBox.Text, "توم") == 0 ||
				string.Compare(servicePriceTextBox.Text, "تو") == 0 ||
				string.Compare(servicePriceTextBox.Text, "ت") == 0)
			{
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				servicePriceTextBox.Clear();
				_auditItem.Price = null;
				ListService.Service_Price = null;
				return;
			}
			else
			{
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				ListService.Service_Price = servicePriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				_auditItem.Price = int.Parse(ListService.Service_Price.Replace(",", string.Empty).Trim());
				servicePriceTextBox.Text = $"{_auditItem.Price:#,0} تومان";
				ListService.Service_Price = servicePriceTextBox.Text;
			}
		}
		#endregion /ServicePriceTextBox_Leave

		#region ServiceNameComboBox_TextChanged
		private void ServiceNameComboBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(servicePriceTextBox.Text))
			{
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			}
			else
			{
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /ServiceNameComboBox_TextChanged

		#region ServiceNumberTextBox_Enter
		private void ServiceNumberTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /ServiceNumberTextBox_Enter

		#region ServiceNumberTextBox_KeyPress
		private void ServiceNumberTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /ServiceNumberTextBox_KeyPress

		#region ServiceNumberTextBox_TextChange
		private void ServiceNumberTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(serviceNumberTextBox.Text) || string.Compare(serviceNumberTextBox.Text, "0") == 0)
			{
				ListService.Service_Number = null;
				return;
			}
			else
			{
				ListService.Service_Number = byte.Parse(serviceNumberTextBox.Text);
			}
		}
		#endregion /ServiceNumberTextBox_TextChange

		#region RepairmanNameTextBox_Enter
		private void RepairmanNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /RepairmanNameTextBox_Enter

		#region RepairmanNameTextBox_KeyPress
		private void RepairmanNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /RepairmanNameTextBox_KeyPress

		#region RepairmanNameTextBox_TextChange
		private void RepairmanNameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(repairmanNameTextBox.Text))
			{
				ListService.Repairman_Name = null;
				return;
			}
			else
			{
				ListService.Repairman_Name = repairmanNameTextBox.Text;
			}
		}
		#endregion /RepairmanNameTextBox_TextChange

		#region DescriptionTextBox_Enter
		private void DescriptionTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /DescriptionTextBox_Enter

		#region DescriptionTextBox_KeyPress
		private void DescriptionTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /DescriptionTextBox_KeyPress

		#region DescriptionTextBox_TextChange
		private void DescriptionTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
			{
				ListService.Description = null;
				return;
			}
			else
			{
				ListService.Description = descriptionTextBox.Text;
			}
		}
		#endregion /DescriptionTextBox_TextChange

		#region CurrerntKilometerTextBox_Enter
		private void CurrerntKilometerTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (string.IsNullOrWhiteSpace(currerntKilometerTextBox.Text))
			{
				currerntKilometerTextBox.Text = "0 کیلومتر";
				currerntKilometerTextBox.Select(0, 1);
				currerntKilometerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
			else if (currerntKilometerTextBox.Text.Contains("کیلومتر"))
			{
				return;
			}
		}
		#endregion /CurrerntKilometerTextBox_Enter

		#region CurrerntKilometerTextBox_KeyPress
		private void CurrerntKilometerTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /CurrerntKilometerTextBox_KeyPress

		#region CurrerntKilometerTextBox_Leave
		private void CurrerntKilometerTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(currerntKilometerTextBox.Text) || currerntKilometerTextBox.Text.Length < 8)
			{
				currerntKilometerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				ServiceInvoice.Current_Kilometer = "0 کیلومتر";
				return;
			}
			else if (string.Compare(currerntKilometerTextBox.Text, "0 تومان") == 0)
			{
				currerntKilometerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				currerntKilometerTextBox.Clear();
				ServiceInvoice.Current_Kilometer = "0 کیلومتر";
				return;
			}
			else
			{
				currerntKilometerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				currentKM = long.Parse(currerntKilometerTextBox.Text.Replace("کیلومتر", string.Empty).Replace(",",string.Empty).Trim());
				ServiceInvoice.Current_Kilometer = $"{currentKM:#,0} کیلومتر";
				currerntKilometerTextBox.Text = $"{currentKM:#,0} کیلومتر";
			}
		}
		#endregion /CurrerntKilometerTextBox_Leave

		#region CurrerntKilometerTextBox_TextChange
		private void CurrerntKilometerTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(currerntKilometerTextBox.Text))
			{
				currerntKilometerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

			}
			else
			{
				currerntKilometerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /CurrerntKilometerTextBox_TextChange

		#region NextKilometerTextBox_Enter
		private void NextKilometerTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (string.IsNullOrWhiteSpace(nextKilometerTextBox.Text))
			{
				nextKilometerTextBox.Text = "0 کیلومتر";
				nextKilometerTextBox.Select(0, 1);
				nextKilometerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
			else if (currerntKilometerTextBox.Text.Contains("کیلومتر"))
			{
				return;
			}
		}
		#endregion /NextKilometerTextBox_Enter

		#region NextKilometerTextBox_KeyPress
		private void NextKilometerTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /NextKilometerTextBox_KeyPress

		#region NextKilometerTextBox_Leave
		private void NextKilometerTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nextKilometerTextBox.Text) || nextKilometerTextBox.Text.Length < 8)
			{
				nextKilometerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				ServiceInvoice.Next_Kilometer = "0 کیلومتر";
				return;
			}
			else if (string.Compare(nextKilometerTextBox.Text, "0 تومان") == 0)
			{
				nextKilometerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				nextKilometerTextBox.Clear();
				ServiceInvoice.Next_Kilometer = "0 کیلومتر";
				return;
			}
			else
			{
				nextKilometerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				nextKM = long.Parse(nextKilometerTextBox.Text.Replace("کیلومتر", string.Empty).Replace(",", string.Empty).Trim());

				if (nextKM <= currentKM)
				{
					Mbb.Windows.Forms.MessageBox.Show(
						text: " کیلومتر بعدی نباید از کیلومتر جاری کوچکتر یا مساوی باشد. \n لطفا مجددا تلاش نمایید. ",
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					nextKilometerTextBox.Focus();
					return;
				}
				else
				{
					ServiceInvoice.Next_Kilometer = $"{nextKM:#,0} کیلومتر";
					nextKilometerTextBox.Text = $"{nextKM:#,0} کیلومتر";
				}
			}
		}
		#endregion /NextKilometerTextBox_Leave

		#region NextKilometerTextBox_TextChange
		private void NextKilometerTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nextKilometerTextBox.Text))
			{
				nextKilometerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

			}
			else
			{
				nextKilometerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /NextKilometerTextBox_TextChange

		#region AddServiceButton_Click
		private void AddServiceButton_Click(object sender, System.EventArgs e)
		{
			AddService(ListService);
		}
		#endregion /AddServiceButton_Click

		#region ReductionServiceButton_Click
		private void ReductionServiceButton_Click(object sender, System.EventArgs e)
		{
			ReductionService();
		}
		#endregion /ReductionServiceButton_Click

		#region NewServiceButton_Click
		private void NewServiceButton_Click(object sender, System.EventArgs e)
		{
			NewService();
		}
		#endregion /NewServiceButton_Click

		#region ShowReportServiceButton_Click
		private void ShowReportServiceButton_Click(object sender, System.EventArgs e)
		{
			ServiceReportForm.ShowDialog();
		}
		#endregion /ShowReportServiceButton_Click

		#region ServiceInvoiceButton_Click
		private void ServiceInvoiceButton_Click(object sender, System.EventArgs e)
		{
			PrintServiceInvoice();
		}
		#endregion /ServiceInvoiceButton_Click

		#region ListServiceDataGridView_RowsAdded
		private void ListServiceDataGridView_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
		{
			AddRowRevice(e);
		}
		#endregion /ListServiceDataGridView_RowsAdded

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			RegisterService();
		}
		#endregion /SaveButton_Click

		#region SumPriceTextBox_TextChanged
		private void SumPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{
			_auditItem.Amounts_Payment = int.Parse(sumPriceTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
			remainingTextBox.Text = sumPriceTextBox.Text;
		}
		#endregion /SumPriceTextBox_TextChanged

		#region AmountPaidTextBox_TextChanged
		private void AmountPaidTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(amountPaidTextBox.Text, "0 تومان") == 0)
				saveButton.Enabled = false;
			else
				saveButton.Enabled = true;


			_auditItem.Amount_Remaininig = _auditItem.Amounts_Payment - _auditItem.Amount_Paid;

			if (_auditItem.Amount_Remaininig < 0)
			{
				_auditItem.Finantial_Situation = Models.ListFinancialClient.FinantialSituationClient.بدهکار;
			}
			else if (_auditItem.Amount_Remaininig == 0)
			{
				_auditItem.Finantial_Situation = Models.ListFinancialClient.FinantialSituationClient.تسویه;
			}
			else
			{
				_auditItem.Finantial_Situation = Models.ListFinancialClient.FinantialSituationClient.طلبکار;
			}

			remainingTextBox.Text = $"{_auditItem.Amount_Remaininig:#,0} تومان";
		}
		#endregion /AmountPaidTextBox_TextChanged

		#region CashPaymentTextBox_Enter
		private void CashPaymentTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (cachPaymentRadioButton.Checked == true || cachAndPosPaymentRadioButton.Checked == true)
			{
				cashPaymentTextBox.ReadOnly = false;
				if (string.IsNullOrWhiteSpace(cashPaymentTextBox.Text))
				{
					_auditItem.Price = null;
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
				_auditItem.Price = null;
				return;
			}
			else
			{
				cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				_auditItem.Price = int.Parse(cashPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				cashPaymentTextBox.Text = $"{_auditItem.Price:#,0} تومان";
			}
		}
		#endregion /CashPaymentTextBox_Leave

		#region CashPaymentTextBox_TextChange
		private void CashPaymentTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cashPaymentTextBox.Text) ||
				string.Compare(cashPaymentTextBox.Text, "0 تومان") == 0 ||
				string.Compare(cashPaymentTextBox.Text, " تومان") == 0 ||
				string.Compare(cashPaymentTextBox.Text, "تومان") == 0 ||
				string.Compare(cashPaymentTextBox.Text, "توما") == 0 ||
				string.Compare(cashPaymentTextBox.Text, "توم") == 0 ||
				string.Compare(cashPaymentTextBox.Text, "تو") == 0 ||
				string.Compare(cashPaymentTextBox.Text, "ت") == 0)
			{
				_auditItem.Cash_Payment_Amount = 0;
				_auditItem.Amount_Paid = _auditItem.Cash_Payment_Amount + _auditItem.Pose_Payment_Amount;
				amountPaidTextBox.Text = $"{_auditItem.Amount_Paid: #,0} تومان";
				return;
			}
			else
			{
				_auditItem.Cash_Payment_Amount = int.Parse(cashPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				if (_auditItem.Pose_Payment_Amount == 0 || _auditItem.Pose_Payment_Amount == null)
				{
					_auditItem.Amount_Paid = _auditItem.Cash_Payment_Amount;
					amountPaidTextBox.Text = $"{_auditItem.Cash_Payment_Amount: #,0} تومان";
				}
				else
				{
					_auditItem.Amount_Paid = _auditItem.Cash_Payment_Amount + _auditItem.Pose_Payment_Amount;
					amountPaidTextBox.Text = $"{_auditItem.Amount_Paid: #,0} تومان";
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
					_auditItem.Price = null;
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
				_auditItem.Price = int.Parse(posPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				posPaymentTextBox.Text = $"{_auditItem.Price:#,0} تومان";
			}
		}
		#endregion /PosPaymentTextBox_Leave

		#region PosPaymentTextBox_TextChange
		private void PosPaymentTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(posPaymentTextBox.Text) || string.Compare(posPaymentTextBox.Text, "0 تومان") == 0 || string.Compare(posPaymentTextBox.Text, " تومان") == 0 || string.Compare(posPaymentTextBox.Text, "تومان") == 0 || string.Compare(posPaymentTextBox.Text, "توما") == 0 || string.Compare(posPaymentTextBox.Text, "توم") == 0 || string.Compare(posPaymentTextBox.Text, "تو") == 0 || string.Compare(posPaymentTextBox.Text, "ت") == 0)
			{
				_auditItem.Pose_Payment_Amount = 0;
				_auditItem.Amount_Paid = _auditItem.Cash_Payment_Amount + _auditItem.Pose_Payment_Amount;
				amountPaidTextBox.Text = $"{_auditItem.Amount_Paid: #,0} تومان";

				return;
			}
			else
			{
				_auditItem.Pose_Payment_Amount = int.Parse(posPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				if (_auditItem.Cash_Payment_Amount == 0 || _auditItem.Cash_Payment_Amount == null)
				{
					_auditItem.Amount_Paid = _auditItem.Pose_Payment_Amount;
					amountPaidTextBox.Text = $"{_auditItem.Pose_Payment_Amount: #,0} تومان";
				}
				else
				{
					_auditItem.Amount_Paid = _auditItem.Cash_Payment_Amount + _auditItem.Pose_Payment_Amount;
					amountPaidTextBox.Text = $"{_auditItem.Amount_Paid: #,0} تومان";
				}
			}
		}
		#endregion /PosPaymentTextBox_TextChange

		#region CachPaymentRadioButton_CheckedChanged
		private void CachPaymentRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			cashPaymentTextBox.Clear();
			posPaymentTextBox.Clear();

			_auditItem.Cash_Payment_Amount = 0;
			_auditItem.Pose_Payment_Amount = 0;
			_auditItem.Amount_Paid = 0;

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
			posPaymentTextBox.Clear();

			_auditItem.Cash_Payment_Amount = 0;
			_auditItem.Pose_Payment_Amount = 0;
			_auditItem.Amount_Paid = 0;

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
			posPaymentTextBox.Clear();

			_auditItem.Cash_Payment_Amount = 0;
			_auditItem.Pose_Payment_Amount = 0;
			_auditItem.Amount_Paid = 0;

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
			posPaymentTextBox.Clear();

			_auditItem.Cash_Payment_Amount = 0;
			_auditItem.Pose_Payment_Amount = 0;
			_auditItem.Amount_Paid = 0;

			amountPaidTextBox.Text = "0 تومان";
		}
		#endregion /DebtorRadioButton_CheckedChanged

		#region DebtorLabel_Click
		private void DebtorLabel_Click(object sender, System.EventArgs e)
		{
			debtorRadioButton.Checked = true;
		}
		#endregion /DebtorLabel_Click

		#region EditServiceToolStripMenuItem_Click
		private void EditServiceToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			EditService();
		}
		#endregion /EditServiceToolStripMenuItem_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Function

		#region AllClear
		/// <summary>
		/// حالت اولیه فرم
		/// </summary>
		private void AllClear()
		{
			//_auditItem = null;
			AccountsReceivable = null;
			EventLog = null;
			ServiceInvoice = null;
			ListService = null;

			clientNameTextBox.Clear();
			phoneNumberTextBox.Clear();
			serviceNameComboBox.SelectedIndex = 0;
			servicePriceTextBox.Clear();
			serviceNumberTextBox.Clear();
			repairmanNameTextBox.Clear();
			descriptionTextBox.Clear();
			currerntKilometerTextBox.Clear();
			nextKilometerTextBox.Clear();
			listServiceDataGridView.Rows.Clear();
		}
		#endregion /AllClear

		#region AccountRecivedBook
		/// <summary>
		/// ثبت در دفتر معین واریزی
		/// </summary>
		/// <param name="_accountsReceivable"></param>
		private bool AccountRecivedBook(Models.AccountsReceivable _accountsReceivable)
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
						Amount_Paid = _accountsReceivable.Amount_Paid,
						Amount_Payable = _accountsReceivable.Amount_Payable,
						Client_Name = _accountsReceivable.Client_Name,
						Description = _accountsReceivable.Description,
						Registration_Date = _accountsReceivable.Registration_Date,
						Registration_Time = _accountsReceivable.Registration_Time,
						Tax_Percent = _accountsReceivable.Tax_Percent,
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

		#region AddClient
		/// <summary>
		/// طبق روند برنامه اگر شماره تماس مشتری
		/// در سیستم وجود نداشته باشد، به صورت خودکار
		/// اطلاعات مشتری در لیست مشتریان ثبت میگردد.
		/// </summary>
		/// <param name="_auditItem"></param>
		/// <returns></returns>
		private void AddClient(AuditItem _auditItem)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Client client =
					new Models.Client();

				client.Client_Name = _auditItem.Client_Name;
				client.License_Plate = _auditItem.License_Plate;
				client.Phone_Number = _auditItem.Phone_Number;
				client.Registration_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
				client.Registration_Time = $"{Infrastructure.Utility.ShowTime()}";

				dataBaseContext.Clients.Add(client);
				dataBaseContext.SaveChanges();

				SetFinancialClient(_auditItem);

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
		#endregion /AddClient

		#region AddService
		/// <summary>
		/// اضافه کردن سرویس
		/// </summary>
		/// <param name="service"></param>
		private void AddService(Models.ListService service)
		{
			int servicePice = int.Parse(service.Service_Price.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
			int? price = service.Service_Number * servicePice;

			string sumPrice = $"{price:#,0} تومان";

			if (string.IsNullOrEmpty(service.Description))
			{
				service.Description = "توضیحات ندارد";
			}

			listServiceDataGridView.Rows.Add(service.Service_Name, service.Description, service.Service_Price, service.Service_Number, sumPrice);

			ContinueRegisterService();
		}
		#endregion /AddService

		#region AddRowRevice
		private void AddRowRevice(System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
		{
			string value;
			int newPrice;
			int totalSumPrice = 0;
			if (e.RowIndex != -1)
			{
				if (listServiceDataGridView.RowCount >= 1)
				{
					newServiceButton.Enabled = true;
					showReportServiceButton.Enabled = true;
					editServiceToolStripMenuItem.Enabled = true;
					saveButton.Enabled = true;
					reductionServiceButton.Enabled = true;
					for (int i = 0; i < listServiceDataGridView.Rows.Count; i++)
					{
						value = listServiceDataGridView.Rows[i].Cells[4].Value.ToString().Replace("تومان", string.Empty).Trim();
						newPrice = int.Parse(value.Replace(",", string.Empty).Trim());
						totalSumPrice += newPrice;
					}
					sumPriceTextBox.Text = $"{totalSumPrice:#,0} تومان";
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

		#region ContinueRegisterService
		/// <summary>
		/// برای ادامه ثبت سرویس این تابع اطلاعات سرویس 
		/// قبلی را حذف و منتظر دریافت اطلاعات جدید میگردد.
		/// </summary>
		private void ContinueRegisterService()
		{
			ListService.Service_Name = null;
			ListService.Service_Price = null;
			ListService.Service_Number = null;
			ListService.Description = null;

			serviceNameComboBox.StartIndex = 0;
			servicePriceTextBox.Clear();
			servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			serviceNumberTextBox.Clear();
			descriptionTextBox.Clear();
		}
		#endregion ContinueRegisterService

		#region Deposit
		/// <summary>
		/// تابع واریز پول به صندوق مالی
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

		#region EditService
		/// <summary>
		/// ویرایش سرویس
		/// </summary>
		private void EditService()
		{
			if (listServiceDataGridView.Rows.Count >= 1)
			{
				addServiceButton.Text = "ویرایش سرویس";

				serviceNameComboBox.SelectedIndex = serviceNameComboBox.FindString(listServiceDataGridView.CurrentRow.Cells[0].Value.ToString());
				descriptionTextBox.Text = listServiceDataGridView.CurrentRow.Cells[1].Value.ToString();
				servicePriceTextBox.Text = listServiceDataGridView.CurrentRow.Cells[2].Value.ToString();
				serviceNumberTextBox.Text = listServiceDataGridView.CurrentRow.Cells[3].Value.ToString();
			}
		}
		#endregion

		#region GetCapitalFund
		/// <summary>
		/// به روز رسانی و بارگزاری صندوق سرمایه
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
						Inventory.Program.MainForm.capitalFundsNotificationTextBox.Text = $"{capital_Fund} تومان ";
					}
					else
					{
						capital_Fund = decimal.Parse(capitalFund.Capital_Fund.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						Inventory.Program.MainForm.capitalFundsNotificationTextBox.Text = $"{capital_Fund:#,0} تومان ";
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

		#region GetClientName
		/// <summary>
		/// با وارد کردن شماره همراه
		/// در صورت موجود بودن در سیستم
		/// نام مشتری برگشت داده میشود.
		/// </summary>
		/// <param name="_client"></param>
		/// <returns></returns>
		private void GetClientName(string _clientPhone)
		{
			string _phoneNumber = _clientPhone.Replace("-", string.Empty).Trim();

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Client client =
					dataBaseContext.Clients
					.Where(current => string.Compare(current.Phone_Number, _phoneNumber) == 0)
					.FirstOrDefault();

				if (client != null)
				{
					Client_Availability = true;
					clientNameTextBox.Text = client.Client_Name;
					numTextBox3.Text = client.License_Plate.Substring(0, 2);
					alphabetComboBox.SelectedIndex = alphabetComboBox.FindString(client.License_Plate.Substring(13, 1));
					numTextBox2.Text = client.License_Plate.Substring(10, 3);
					numTextBox1.Text = client.License_Plate.Substring(17, 2);

					ServiceInvoice.License_Plate =
					$"{client.License_Plate.Substring(0, 2)}{iranLabel.Text} - {client.License_Plate.Substring(10, 3)}{client.License_Plate.Substring(13, 1)} - {client.License_Plate.Substring(17, 2)}";
				}
				else
				{
					Client_Availability = false;
					clientNameTextBox.Clear();
					numTextBox3.Clear();
					alphabetComboBox.SelectedIndex = 0;
					numTextBox2.Clear();
					numTextBox1.Clear();
				}
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
		#endregion /GetClientName

		#region GetServiceName
		/// <summary>
		/// بارگذاری لیست اسامی سرویسها از دیتابیس به داخل برنامه
		/// </summary>
		private void GetServiceName()
		{
			serviceNameComboBox.Items.Add("...انتخاب سرویس");

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					 new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ListServiceName> listTypesService =
					new System.Collections.Generic.List<Models.ListServiceName>();

				listTypesService =
					dataBaseContext.ListServiceNames
					.OrderBy(current => current.Id)
					.ToList();

				for (int i = 0; i < listTypesService.Count; i++)
				{
					serviceNameComboBox.Items.Add(listTypesService.ElementAt(index: i));
					serviceNameComboBox.ValueMember = "Service_Name";
					serviceNameComboBox.DisplayMember = "Service_Name";
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /GetServiceName

		#region Initialize
		/// <summary>
		/// مقداردهی اولیه
		/// </summary>
		public void Initialize()
		{
			this.Focus();

			AllClear();
			GetServiceName();
			serviceNameComboBox.SelectedIndex = 0;

			_auditItem.Capital_Fund = GetCapitalFund();
			inventorySerialNumberTextBox.Text = ListService.Invoice_Serial_Numvber = ServiceInvoice.Invoice_Serial_Number = SetInvoiceSerialNumber();
			_auditItem.Register_Date = ListService.Service_Date =
				Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
			_auditItem.Register_Time = ListService.Service_Time =
				   Infrastructure.Utility.ShowTime();
			serviceDateTextBox.Text =
				$"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
			serviceTimeTextBox.Text =
				$"{Infrastructure.Utility.ShowTime()}";
		}
		#endregion /Initialize

		#region InputValidation
		/// <summary>
		/// اعتبار سنچی ورودی اطلاعات
		/// </summary>
		/// <param name="_service"></param>
		/// <param name="_invoiceSerialNumber"></param>
		/// <returns>true or false</returns>
		private bool InputValidation(Models.ListService _service, Models.ServiceInvoice _serviceInvoice)
		{
			string errorMessage = null;

			if (string.IsNullOrEmpty(_serviceInvoice.Client_Name))
			{
				errorMessage = "لطفا نام مشتری را وارد نمایید.";
			}
			if (string.IsNullOrEmpty(_serviceInvoice.License_Plate))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += "لطفا شماره پلاک وسیله نقلیه را وارد نمایید.";
			}
			if (string.IsNullOrEmpty(_service.Repairman_Name))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += "لطفا نام تعمیرکار را وارد نمایید.";
			}
			if (string.IsNullOrEmpty(_serviceInvoice.Current_Kilometer))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += "لطفا کیلومتر فعلی را وارد نمایید.";
			}
			if (string.IsNullOrEmpty(_serviceInvoice.Next_Kilometer))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += "لطفا کیلومتر بعدی وارد نماییید.";
			}
			if (listServiceDataGridView.Rows.Count <= 0)
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += "حداقل یک سرویس ثبت نمایید.";
			}

			if (!string.IsNullOrEmpty(errorMessage))
			{
				if (string.IsNullOrEmpty(_serviceInvoice.Client_Name))
				{
					clientNameTextBox.Focus();
				}
				else if (string.IsNullOrEmpty(_serviceInvoice.License_Plate))
				{
					phoneNumberTextBox.Focus();
				}
				
				else if (string.IsNullOrEmpty(_service.Repairman_Name))
				{
					repairmanNameTextBox.Focus();
				}
				else if (string.IsNullOrEmpty(_serviceInvoice.Current_Kilometer))
				{
					currerntKilometerTextBox.Focus();
				}
				else if (string.IsNullOrEmpty(_serviceInvoice.Next_Kilometer))
				{
					nextKilometerTextBox.Focus();
				}
				else if (listServiceDataGridView.Rows.Count <= 0)
				{
					serviceNameComboBox.Focus();
				}

				Mbb.Windows.Forms.MessageBox.Show
					(text: errorMessage, caption: "خطای ورودی", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				return false;
			}
			else
			{
				return true;
			}
		}
		#endregion /InputValidation

		#region NewService
		/// <summary>
		/// سرویس جدید
		/// </summary>
		private void NewService()
		{
			ListService = null;

			clientNameTextBox.Clear();
			serviceNameComboBox.StartIndex = 0;
			serviceNumberTextBox.Clear();
			serviceDateTextBox.Text =
				$"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
			serviceTimeTextBox.Text =
				$"{Infrastructure.Utility.ShowTime()}";
			inventorySerialNumberTextBox.Clear();
			repairmanNameTextBox.Clear();
			descriptionTextBox.Clear();

			cashPaymentTextBox.Clear();
			posPaymentTextBox.Clear();

			_auditItem = null;

			cachAndPosPaymentRadioButton.Checked = false;
			posPaymentRadioButton.Checked = false;
			cachAndPosPaymentRadioButton.Checked = false;
			debtorRadioButton.Checked = false;

			sumPriceTextBox.Text = "0 تومان";
			amountPaidTextBox.Text = "0 تومان";
			remainingTextBox.Text = "0 تومان";
		}
		#endregion

		#region PrintServiceInvoice
		/// <summary>
		/// چاپ رسید سرویس ماشین
		/// </summary>
		private void PrintServiceInvoice()
		{
			if (InputValidation(ListService, ServiceInvoice))
			{
				System.Collections.Generic.List<ServiceItem> serviceItemLists = new System.Collections.Generic.List<ServiceItem>();

				foreach (System.Windows.Forms.DataGridViewRow rows in listServiceDataGridView.Rows)
				{
					ServiceItem iserviceItem = new ServiceItem
					{
						Service_Name = rows.Cells[0].Value.ToString(),
						Description = rows.Cells[1].Value.ToString(),
						Service_Price = rows.Cells[2].Value.ToString(),
						Service_Number = int.Parse(rows.Cells[3].Value.ToString()),
						TotalPrice = rows.Cells[4].Value.ToString(),
					};
					serviceItemLists.Add(iserviceItem);
				}

				Stimulsoft.Report.StiReport serviceReport = new Stimulsoft.Report.StiReport();

				serviceReport.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\ServicReport.mrt");
				serviceReport.RegBusinessObject("Service", serviceItemLists);

				(serviceReport.GetComponentByName("dateOfPrintTextBox") as Stimulsoft.Report.Components.StiText).Text = $"{ListService.Service_Date} - {ListService.Service_Time}";
				(serviceReport.GetComponentByName("invoiceSerialNumberTextBox") as Stimulsoft.Report.Components.StiText).Text = ListService.Invoice_Serial_Numvber;
				(serviceReport.GetComponentByName("repairmanNameTextBox") as Stimulsoft.Report.Components.StiText).Text = ListService.Repairman_Name;
				(serviceReport.GetComponentByName("clientNameTextBox") as Stimulsoft.Report.Components.StiText).Text = ServiceInvoice.Client_Name;
				(serviceReport.GetComponentByName("sumPriceTextBox") as Stimulsoft.Report.Components.StiText).Text = sumPriceTextBox.Text;
				(serviceReport.GetComponentByName("amountPaymentTextBox") as Stimulsoft.Report.Components.StiText).Text = amountPaidTextBox.Text;
				(serviceReport.GetComponentByName("remainingTexBox") as Stimulsoft.Report.Components.StiText).Text = remainingTextBox.Text;

				serviceReport.Render(true);
				PrintReportForm.printReportStiViewerControl.Report = serviceReport;
				PrintReportForm.ShowDialog();
			}
			else
			{
				return;
			}
		}
		#endregion PrintServiceInvoice

		#region ReductionService
		/// <summary>
		/// سرویس انجام شده را از لیست اجرای سرویس کاهش میدهد.
		/// </summary>
		private void ReductionService()
		{
			if (listServiceDataGridView.Rows.Count >= 1)
			{
				int value = int.Parse(listServiceDataGridView.CurrentRow.Cells[3].Value.ToString());

				if (value <= 1)
				{
					#region Validate
					string amountPayable =
									this.sumPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
					string WarePrice =
						listServiceDataGridView.CurrentRow.Cells[2].Value.ToString().Replace("تومان", string.Empty).Trim();

					int itemTotalPrice =
						int.Parse(amountPayable.Replace(",", string.Empty).Trim());
					int itemPrice =
							int.Parse(WarePrice.Replace(",", string.Empty).Trim());

					itemTotalPrice -= itemPrice;
					value--;
					listServiceDataGridView.CurrentRow.Cells[3].Value = value;

					#region ===========================================================================          EventLog          ===========================================================================
					EventLog.Username = Inventory.Program.UserAuthentication.Username;
					EventLog.Full_Name = $"{Inventory.Program.UserAuthentication.Full_Name}";
					EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
					EventLog.Description = $"سفارش {listServiceDataGridView.CurrentRow.Cells[1].Value} حذف گردید!";

					Infrastructure.Utility.EventLog(EventLog);
					#endregion /===========================================================================          EventLog          ===========================================================================

					int SumPriceItem =
							itemPrice * value;
					WarePrice =
						$"{SumPriceItem:#,0} تومان";

					listServiceDataGridView.CurrentRow.Cells[2].Value = WarePrice;

					if (itemTotalPrice == 0)
					{
						this.sumPriceTextBox.Text =
							"0 تومان";
					}
					else
					{
						amountPayable =
							$"{itemTotalPrice:#,0} تومان";
						this.sumPriceTextBox.Text = amountPayable;
					}
					#endregion /Validate

					foreach (System.Windows.Forms.DataGridViewRow row in this.listServiceDataGridView.SelectedRows)
					{
						listServiceDataGridView.Rows.RemoveAt(row.Index);

						if (listServiceDataGridView.Rows.Count == 0)
						{
							reductionServiceButton.Enabled = false;
							newServiceButton.Enabled = false;
							showReportServiceButton.Enabled = false;
							editServiceToolStripMenuItem.Enabled = false;
							saveButton.Enabled = false;
							reductionServiceButton.Enabled = false;
							return;
						}
					}
					return;
				}
				else
				{
					string amountPayable =
						this.sumPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
					string WarePrice =
						listServiceDataGridView.CurrentRow.Cells[2].Value.ToString().Replace("تومان", string.Empty).Trim();

					int itemTotalPrice =
						int.Parse(amountPayable.Replace(",", string.Empty).Trim());
					int itemPrice =
							int.Parse(WarePrice.Replace(",", string.Empty).Trim());

					itemTotalPrice -= itemPrice;
					value--;
					listServiceDataGridView.CurrentRow.Cells[3].Value = value;

					#region ===========================================================================          EventLog          ===========================================================================
					EventLog.Username = Inventory.Program.UserAuthentication.Username;
					EventLog.Full_Name = $"{Inventory.Program.UserAuthentication.Full_Name}";
					EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
					EventLog.Description = $"کاهش سرویس {listServiceDataGridView.CurrentRow.Cells[1].Value}";

					Infrastructure.Utility.EventLog(EventLog);
					#endregion /===========================================================================          EventLog          ===========================================================================

					int SumPriceItem =
							itemPrice * value;
					WarePrice =
						$"{SumPriceItem:#,0} تومان";

					listServiceDataGridView.CurrentRow.Cells[4].Value = WarePrice;

					if (itemTotalPrice == 0)
					{
						this.sumPriceTextBox.Text =
							"0 تومان";
					}
					else
					{
						amountPayable =
							$"{itemTotalPrice:#,0} تومان";
						this.sumPriceTextBox.Text = amountPayable;
					}
					return;
				}
			}

		}
		#endregion /ReductionService

		#region RegisterService
		/// <summary>
		/// ثبت سرویس در جدول مربوطه به سرویسها
		/// </summary>
		private void RegisterService()
		{
			if (Client_Availability)
			{
				if (SetListService(ListService, ServiceInvoice) && Deposit(_auditItem) && SetDailyOffice(_auditItem) && AccountRecivedBook(AccountsReceivable))
				{
					SetDailyFinancialReport(_auditItem);
					SetFinancialClient(_auditItem);

					Infrastructure.Utility.WindowsNotification
						(message: Inventory.Properties.Resources.Service_Register, caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

					return;
				}
				else
				{
					Infrastructure.Utility.WindowsNotification
						(message: Inventory.Properties.Resources.Service_Register_Error, caption: Infrastructure.PopupNotificationForm.Caption.خطا);
				}
			}
			else
			{
				AddClient(_auditItem);

				if (SetListService(ListService, ServiceInvoice) && Deposit(_auditItem) && SetDailyOffice(_auditItem) && AccountRecivedBook(AccountsReceivable))
				{
					SetDailyFinancialReport(_auditItem);
					SetFinancialClient(_auditItem);

					Infrastructure.Utility.WindowsNotification
						(message: Inventory.Properties.Resources.Service_Register, caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

					return;
				}
				else
				{
					Infrastructure.Utility.WindowsNotification
						(message: Inventory.Properties.Resources.Service_Register_Error, caption: Infrastructure.PopupNotificationForm.Caption.خطا);
				}
			}
		}
		#endregion RegisterService	

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

				Models.Journal journal =
				new Models.Journal
				{
					Amount_Received = $"{auditItem.Amount_Paid: #,0} تومان",
					Amount_Paid = "0 تومان",
					Description = $"سرویس خودرو",
					Invoice_Serial_Numvber = auditItem.Invoice_Serial_Number,
					Registration_Date = auditItem.Register_Date,
					Registration_Time = auditItem.Register_Time,
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
		}
		#endregion /SetDailyOffice

		#region SetFinancialClient
		/// <summary>
		/// ثبت در حساب مالی مشتری
		/// </summary>
		/// <param name="_auditItem"></param>
		private void SetFinancialClient(AuditItem _auditItem)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ListFinancialClient listFinancialClient =
					new Models.ListFinancialClient();

				listFinancialClient.Amounts_Payment =$"{_auditItem.Amounts_Payment:#,0} تومان";
				listFinancialClient.Amount_Paid = $"{_auditItem.Amount_Paid:#,0} تومان";
				listFinancialClient.Amount_Remaininig = $"{_auditItem.Amount_Remaininig:#,0} تومان";
				listFinancialClient.Client_Name = _auditItem.Client_Name;
				listFinancialClient.Finantial_Situation = _auditItem.Finantial_Situation;
				listFinancialClient.License_Plate = _auditItem.License_Plate;
				listFinancialClient.Phone_Number = _auditItem.Phone_Number;
				listFinancialClient.Registration_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
				listFinancialClient.Registration_Time = $"{Infrastructure.Utility.ShowTime()}";
				listFinancialClient.Tax_Percent = "0 %";

				dataBaseContext.ListFinancialClients.Add(listFinancialClient);
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
		#endregion SetFinancialClient

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
		#endregion /SetInvoiceSerialNumber

		#region SetService
		/// <summary>
		/// ثبت سرویس های صورت گرفته در جدول لیست سرویس
		/// </summary>
		/// <param name="_listService"></param>
		/// <returns>true or false</returns>
		private bool SetListService(Models.ListService _listService, Models.ServiceInvoice _serviceInvoice)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				//---- ثبت در جدول فاکتور سرویس
				#region PurchaseInvoice

				Models.ServiceInvoice serviceInvoice =
					new Models.ServiceInvoice
					{
						Client_Name = _serviceInvoice.Client_Name,
						Current_Kilometer = _serviceInvoice.Current_Kilometer,
						Invoice_Serial_Number = _serviceInvoice.Invoice_Serial_Number,
						License_Plate = _serviceInvoice.License_Plate,
						Next_Kilometer = _serviceInvoice.Next_Kilometer,
						Phone_Number = _serviceInvoice.Phone_Number,
						Service_Date = _serviceInvoice.Service_Date,
						Service_Time = _serviceInvoice.Service_Time,
					};
				dataBaseContext.ServiceInvoices.Add(serviceInvoice);
				dataBaseContext.SaveChanges();

				#endregion /PurchaseInvoice

				#region ListService
				Models.ListService listService =
							new Models.ListService();

				foreach (System.Windows.Forms.DataGridViewRow row in listServiceDataGridView.Rows)
				{
					listService.Service_Date = _listService.Service_Date;
					listService.Service_Time = _listService.Service_Time;
					listService.Invoice_Serial_Numvber = _listService.Invoice_Serial_Numvber;
					listService.Repairman_Name = _listService.Repairman_Name;
					listService.Service_Name = $"{row.Cells[0].Value}";
					listService.Description = $"{row.Cells[1].Value}";
					listService.Service_Price = $"{row.Cells[2].Value}";
					listService.Service_Number = byte.Parse($"{row.Cells[3].Value}");
					listService.Total_Sum_Price = $"{row.Cells[4].Value}";
				}

				dataBaseContext.ListServices.Add(listService);
				dataBaseContext.SaveChanges();
				#endregion ListService

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
		#endregion	

		#region SetServicePrice
		/// <summary>
		/// .با دریافت نام سرویس قیمت آن را به نمایش در می آورد
		/// </summary>
		/// <param name="serviceName"></param>
		/// <returns></returns>
		private void SetServicePrice()
		{
			if (serviceNameComboBox.SelectedIndex <= 1)
			{
				ListService.Service_Name = null;
				ListService.Service_Price = null;
				servicePriceTextBox.Clear();
				servicePriceTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Right;

				Mbb.Windows.Forms.MessageBox.Show
					(text: "لطفا یکی از سرویس های موجود را انتخاب کنید",
					caption: "تصحیح انتخاب",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				return;
			}
			else
			{
				Models.ListServiceName typesService =
					serviceNameComboBox.SelectedItem as Models.ListServiceName;

				if (typesService != null)
				{

					ListService.Service_Name = typesService.Service_Name;
					ListService.Service_Price = typesService.Service_Price;
					servicePriceTextBox.Text = typesService.Service_Price;
					servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				}
			}
		}

		#endregion /SetServicePrice

		#region TelConfirmation
		/// <summary>
		/// بررسی وجود شماره همراه در سیستم
		/// </summary>
		/// <param name="tel"></param>
		/// <returns></returns>
		private bool TelConfirmation(string _phoneNumber)
		{
			bool status;
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.Client client =
				dataBaseContext.Clients
				.Where(current => string.Compare(current.Phone_Number, _phoneNumber) == 0)
				.FirstOrDefault();

			if (client == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}
			return status;
		}
		#endregion /TelConfirmation

		#endregion /Function
	}
}

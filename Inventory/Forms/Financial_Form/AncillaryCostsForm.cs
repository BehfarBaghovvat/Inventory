using System.Linq;

namespace Financial_Form
{
	public partial class AncillaryCostsForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Layers

		private Models.AncillaryCosts _ancillaryCosts;
		public Models.AncillaryCosts AncillaryCosts
		{
			get
			{
				if (_ancillaryCosts == null)
				{
					_ancillaryCosts =
						new Models.AncillaryCosts();
				};
				return _ancillaryCosts;
			}
			set
			{
				_ancillaryCosts = value;
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

		#endregion /Layers

		public decimal? AmountPayment { get; set; }
		public decimal? Capital_Fund { get; set; }
		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public AncillaryCostsForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region AncillaryCostsForm_Load
		private void AncillaryCostsForm_Load(object sender, System.EventArgs e)
		{
			//Initialize();
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
				amountPaymentTextBox.Text.Length < 7)
			{
				amountPaymentTextBox.Clear();
				AncillaryCosts.Amount_Payment = null;
				amountPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else
			{
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
				amountPaymentTextBox.Text.Length < 7)
			{
				AmountPayment = null;
				return;
			}
			else
			{
				AmountPayment = 
					decimal.Parse(amountPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
			}

		}
		#endregion /AmountPaymentTextBox_TextChange

		#region ListExpensesComboBox_SelectedIndexChanged
		private void ListExpensesComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (listExpensesComboBox.SelectedIndex == 0)
			{
				AncillaryCosts.Cost_Name = null;
				listExpensesComboBox.ForeColor = System.Drawing.Color.DimGray;
				return;
			}
			else
			{
				listExpensesComboBox.ForeColor = System.Drawing.Color.White;
				AncillaryCosts.Cost_Name = $"{listExpensesComboBox.Text}";
			}
		}
		#endregion /ListExpensesComboBox_SelectedIndexChanged

		#region PaymentButton_Click
		private void PaymentButton_Click(object sender, System.EventArgs e)
		{
			if (ValidationData(AncillaryCosts))
			{
				if (SetToAncillaryCosts(AncillaryCosts))
				{
					PaymentCost(AmountPayment);

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
		#endregion /PaymentButton_Click



		//--------------------------------------------------------------------------------------------------    Private Methods

		#region Function

		#region AllClear
		private void AllClear()
		{
			amountPaymentTextBox.Clear();
			amountPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			listExpensesComboBox.SelectedIndex = 0;
			AncillaryCosts = null;
		}
		#endregion /AllClear

		#region GetAncillaryCosts
		/// <summary>
		/// لیت کامل هزینه های صورت گرفته را بر میگرداند
		/// </summary>
		private void GetListAncillaryCosts()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.AncillaryCosts> listAncillaryCosts =
					new System.Collections.Generic.List<Models.AncillaryCosts>();

				listAncillaryCosts =
					dataBaseContext.AncillaryCosts
					.OrderBy(current => current.Id)
					.ToList();

				ancillaryCostsDataGridView.DataSource = listAncillaryCosts;
				
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
		#endregion /GetAncillaryCosts

		#region GetCapitalFund
		/// <summary>
		/// به روز رسانی صندوق
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
						MainForm.cashCapitalTextBox.Text = $"{capital_Fund} تومان";
					}
					else
					{
						capital_Fund = decimal.Parse(capitalFund.Capital_Fund.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						MainForm.cashCapitalTextBox.Text = $"{capital_Fund:#,0} تومان";
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

		#region GetListIncidentalExpenses
		/// <summary>
		/// بارگذاری لیست اسامی هزینه ها از دیتابیس به داخل برنامه
		/// </summary>
		private void GetListIncidentalExpenses()
		{
			listExpensesComboBox.Items.Add("...انتخاب هزینه");

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					 new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ListIncidentalExpensesName> listIncidentalExpenses =
					new System.Collections.Generic.List<Models.ListIncidentalExpensesName>();

				listIncidentalExpenses =
					dataBaseContext.ListIncidentalExpensesNames
					.OrderBy(current => current.Id)
					.ToList();

				for (int i = 0; i < listIncidentalExpenses.Count; i++)
				{
					listExpensesComboBox.Items.Add(listIncidentalExpenses.ElementAt(i));
					listExpensesComboBox.ValueMember = "Id";
					listExpensesComboBox.DisplayMember = "Cost_Name";
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /GetListIncidentalExpenses

		#region Initialize
		/// <summary>
		/// مقداردهی اولیه
		/// </summary>
		public void Initialize()
		{
			this.Focus();
			GetListIncidentalExpenses();
			GetListAncillaryCosts();

			listExpensesComboBox.SelectedIndex = 0;
		}
		#endregion /Initialize

		#region PaymentCost
		/// <summary>
		/// کم کردن هزینه از صندوق
		/// </summary>
		/// <param name="_amountPayment"></param>
		/// <param name="_capitalFund"></param>
		private void PaymentCost(decimal? _amountPayment)
		{
			decimal? _capitalFund = GetCapitalFund();
			decimal? _remainding = _capitalFund - _amountPayment;





			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
						dataBaseContext.CapitalFunds
						.FirstOrDefault();

				capitalFund.Capital_Fund = $"{_remainding:#,0} تومان";

				dataBaseContext.SaveChanges();

				RefreshCapitalFund();

				AllClear();
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
		#endregion /PaymentCost		

		#region RefreshCapitalFund
		/// <summary>
		/// تازه سازی صندوق سرمایه
		/// </summary>
		private void RefreshCapitalFund()
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
		#endregion /RefreshCapitalFund

		#region SetEventLog
		private void SetEventLog(Models.AncillaryCosts _ancillaryCosts)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.EventLog eventLog =
					dataBaseContext.EventLogs
					.FirstOrDefault();

				eventLog =
					new Models.EventLog()
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

		#region SetToAncillaryCosts
		/// <summary>
		/// ثبت هزینه جانبی در دیتابیس
		/// </summary>
		/// <param name="_ancillaryCosts"></param>
		/// <returns></returns>
		private bool SetToAncillaryCosts(Models.AncillaryCosts _ancillaryCosts)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.AncillaryCosts ancillaryCosts = null;

				ancillaryCosts =
					new Models.AncillaryCosts();

				ancillaryCosts.Name_Payer = Inventory.Program.UserAuthentication.Full_Name;
				ancillaryCosts.Cost_Name = _ancillaryCosts.Cost_Name;
				ancillaryCosts.Amount_Payment = _ancillaryCosts.Amount_Payment;
				ancillaryCosts.Registration_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
				ancillaryCosts.Registration_Time = $"{Infrastructure.Utility.ShowTime()}";
					

				dataBaseContext.AncillaryCosts.Add(ancillaryCosts);
				dataBaseContext.SaveChanges();

				GetListAncillaryCosts();

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
		#endregion /SetToAncillaryCosts

		#region ValidationData
		/// <summary>
		/// اعتبار سنجی داده های وارد شده توسط کاربر
		/// </summary>
		/// <param name="_ancillaryCosts"></param>
		/// <returns></returns>
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

		#endregion /Function
	}
}

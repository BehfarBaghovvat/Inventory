using System.Linq;
using System;

namespace Client_Forms
{
	public partial class ClientFinancialSituationForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Layers
		public enum FinantialSituation
		{
			بستانکار,
			تسویه,
			بدهکار,
		}

		private class Audit
		{
			public decimal? Amount { get; set; }
			public decimal? Amount_Paid { get; set; }
			public decimal? Capital_Fund { get; set; }
			public string Search_Client { get; set; }
			public int? Situation { get; set; }
			public decimal? Sum_Amount { get; set; }
			public int Select_Count { get; set; }
			public bool Select_Row { get; set; }
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

		private Audit _audit = new Audit();

		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public ClientFinancialSituationForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region ClientFinancialSituationForm_Load
		private void ClientFinancialSituationForm_Load(object sender, EventArgs e)
		{
			
		}
		#endregion /ClientFinancialSituationForm_Load

		#region SearchClientTextBox_Enter
		private void SearchClientTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /SearchClientTextBox_Enter

		#region SearchClientTextBox_KeyPress
		private void SearchClientTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /SearchClientTextBox_KeyPress

		#region SearchClientTextBox_TextChange
		private void SearchClientTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchClientTextBox.Text))
			{
				searchClientTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				_audit.Search_Client = null;
				return;
			}
			else
			{
				searchClientTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

				_audit.Search_Client = searchClientTextBox.Text;

				SearchClient(_audit.Search_Client);
			}
		}
		#endregion /SearchClientTextBox_TextChange

		#region ListFinantioalClientDataGridView_CellContentClick
		private void ListFinantioalClientDataGridView_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{

			if (e.ColumnIndex <=-1 || e.RowIndex <= -1 )
			{
				return;
			}

			if ((e.ColumnIndex == 1 && e.RowIndex >= 0))
			{
				if ((string.Compare(listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString(), FinantialSituation.تسویه.ToString()) == 0))
				{
					listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[1].Value = false;
					listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[1].ReadOnly = true;
					return;
				}
				else
				{
					listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[1].ReadOnly = false;

					//این بخش از کد، بعد از بررسی کردن کنترل چک باکس
					// مقادیر نام مشتری، شماره پلاک وسیله نقلیه و شماره همراه را 
					//به کنترلهای مربوطه انتقال میدهد.
					if (listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[1].Value != null && (bool)listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[1].Value == false)
					{
						listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[1].Value = true;

						clientNameTextBox.Text = listFinantioalClientDataGridView.CurrentRow.Cells[7].Value.ToString();
						numTextBox3.Text = listFinantioalClientDataGridView.CurrentRow.Cells[8].Value.ToString().Substring(0, 2);
						alphabetTextBox.Text = listFinantioalClientDataGridView.CurrentRow.Cells[8].Value.ToString().Substring(13, 1);
						numTextBox2.Text = listFinantioalClientDataGridView.CurrentRow.Cells[8].Value.ToString().Substring(10, 3);
						numTextBox1.Text = listFinantioalClientDataGridView.CurrentRow.Cells[8].Value.ToString().Substring(17, 2);
						phoneNumberTextBox.Text = listFinantioalClientDataGridView.CurrentRow.Cells[9].Value.ToString().Insert(4, "-");
						phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

						////در این قسمت بعد از اینکه اطلاعات مربوطه منتقل گردید، بررسی میکند
						//// ایا مقدار نام مشتری تیک خورده با نام مشتری موجود در کنترل جعبه متن 
						//// یکی می باشد یا خیر. اگر نتیجه درست بود ادامه عملیات
						//// در غیر این صورت از انتخاب ردیف جاری جلو گیری به عمل می آورد.
						if (string.Compare(listFinantioalClientDataGridView.CurrentRow.Cells[7].Value.ToString(), clientNameTextBox.Text) == 0)
						{
							_audit.Select_Count++;
							_audit.Amount +=
								decimal.Parse(listFinantioalClientDataGridView.CurrentRow.Cells[3].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

							_audit.Sum_Amount = _audit.Amount;
						}
						else
						{
							listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[1].Value = false;
						}
					}
					else if (listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[1].Value != null && (bool)listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[1].Value == true)
					{
						listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[1].Value = false;

						_audit.Select_Count--;

						_audit.Amount -=
							decimal.Parse(listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						_audit.Sum_Amount = _audit.Amount;

						if (_audit.Select_Count <= 0)
						{
							RestAllControl();
						}
					}
				}
			}
			else
			{
				listFinantioalClientDataGridView.Rows[e.RowIndex].Cells[1].Value = false;
				listFinantioalClientDataGridView.CurrentCell.ReadOnly = true;
				return;
			}

			if (_audit.Amount == 0)
			{
				totalAmountTextBox.Clear();
				totalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			}
			else
			{
				totalAmountTextBox.Text = $"{_audit.Amount:#,0} تومان";
				totalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}

			_audit.Situation = CheckSituation(_audit.Amount);
		}
		#endregion /ListFinantioalClientDataGridView_CellContentClick

		#region PaymentButton_Click
		private void PaymentButton_Click(object sender, System.EventArgs e)
		{
			if (Payment(_audit) && (UpdateListFinancialClient()))
			{
				Infrastructure.Utility.WindowsNotification(message: "عملیات تسویه انجام گردید.", caption: Infrastructure.PopupNotificationForm.Caption.اطلاع);
			}
		}
		#endregion /PaymentButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Function

		#region CheckSituation
		/// <summary>
		/// بررسی باقیمانده حساب
		/// </summary>
		/// <param name="_amount"></param>
		private int CheckSituation(decimal? _amount)
		{
			if (_amount > 0)
			{
				financialSituationLabel.Text = "بدهکار";
				financialSituationLabel.ForeColor = System.Drawing.Color.LightGreen;
				paymentButton.Enabled = true;
				return -1;
			}
			else if (_amount == 0)
			{
				financialSituationLabel.Text = "تسویه";
				financialSituationLabel.ForeColor = System.Drawing.Color.White;
				paymentButton.Enabled = false;
				return 0;
			}
			else
			{
				financialSituationLabel.Text = "بستانکار";
				financialSituationLabel.ForeColor = System.Drawing.Color.LightPink;
				paymentButton.Enabled = true;
				return 1;
			}
		}

		#endregion CheckSituation

		#region Initialize
		/// <summary>
		/// تنظیمات و مقدار دهی اولیه
		/// </summary>
		public void Initialize()
		{
			RestAllControl();
			searchClientTextBox.Clear();
			GetListFinantialClient();
			_audit.Capital_Fund = GetCapitalFund();

			foreach (System.Windows.Forms.DataGridViewRow row in listFinantioalClientDataGridView.Rows)
			{
				row.Cells[1].Value = false;

				if (string.Compare(row.Cells[6].Value.ToString(), FinantialSituation.بدهکار.ToString()) == 0)
				{
					row.Cells[6].Style.BackColor = System.Drawing.Color.LightPink;
				}
				else if (string.Compare(row.Cells[6].Value.ToString(), FinantialSituation.تسویه.ToString()) == 0)
				{
					row.Cells[6].Style.BackColor = System.Drawing.Color.LightGreen;
				}
				else if (string.Compare(row.Cells[6].Value.ToString(), FinantialSituation.بستانکار.ToString()) == 0)
				{
					row.Cells[6].Style.BackColor = System.Drawing.Color.LightGreen;
				}
			}
		}
		#endregion /Initialize

		#region GetCapitalFund
		/// <summary>
		/// بارگذاری مبلغ سرمایه صندوق
		/// </summary>
		/// <returns>amount of 0</returns>
		private decimal GetCapitalFund()
		{
			decimal _capitalFund;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					new Models.CapitalFund();

				if (capitalFund == null)
				{
					return 0;
				}
				else
				{
					if (string.IsNullOrEmpty(capitalFund.Capital_Fund))
					{
						_capitalFund = 0;
					}
					else if (capitalFund.Capital_Fund.Length < 9)
					{
						_capitalFund = decimal.Parse(capitalFund.Capital_Fund.Replace("توان", string.Empty).Trim());
					}
					else
					{
						_capitalFund = decimal.Parse(capitalFund.Capital_Fund.Replace("توان", string.Empty).Replace(",", string.Empty).Trim());
					}
				}

				MainForm.capitalFundsNotificationTextBox.Text = $"{_capitalFund:#,0} تومان";

				return _capitalFund;
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

		#region GetListFinantialClient
		/// <summary>
		/// بارگذاری لیست مالی مشتریان
		/// </summary>
		private void GetListFinantialClient()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ListFinancialClient> listFinancialClients = new System.Collections.Generic.List<Models.ListFinancialClient>();

				listFinancialClients =
						dataBaseContext.ListFinancialClients
						.OrderBy(current => current.Id)
						.ToList();

				if (listFinancialClients == null)
				{
					return;
				}
				else
				{
					listFinantioalClientDataGridView.DataSource = listFinancialClients;
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
		#endregion GetListFinantialClient

		#region Payment
		/// <summary>
		/// تابع پرداخت صورت حساب
		/// </summary>
		/// <param name="_amountPayment"></param>
		/// <param name="_capitalFund"></param>
		/// <returns>True Or False</returns>
		private bool Payment(Audit _audit)
		{
			decimal _returnCapitalFund = 0;
			decimal? _remainingCapitalFund = _audit.Capital_Fund + (_audit.Sum_Amount);

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.Where(current => current.Id == 1)
					.FirstOrDefault();

				if (capitalFund == null)
				{
					capitalFund = 
						new Models.CapitalFund
						{
							Capital_Fund = $"{_remainingCapitalFund:#,0} تومان",
						};
					dataBaseContext.CapitalFunds.Add(capitalFund);
				}
				else
				{
					capitalFund.Capital_Fund = $"{_remainingCapitalFund:#,0} تومان";
				}

				dataBaseContext.SaveChanges();

				_returnCapitalFund = GetCapitalFund();

				Inventory.Program.MainForm.capitalFundsNotificationTextBox.Text = $"{_returnCapitalFund:#,0} تومان";

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
		#endregion /Payment

		#region RestAllControl
		/// <summary>
		/// حالت اولیه کنترل ها
		/// </summary>
		private void RestAllControl()
		{
			clientNameTextBox.Clear();
			numTextBox3.Clear();
			alphabetTextBox.Clear();
			numTextBox2.Clear();
			numTextBox1.Clear();
			phoneNumberTextBox.Clear();
			phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

			_audit.Amount = 0;

			_audit.Select_Count = 0;
		}
		#endregion /RestAllControl

		#region SearchClient
		/// <summary>
		/// جستجوی مشتری بر اساس 
		/// شماره پلاک یا شماره تماس
		/// </summary>
		/// <param name="_searchClient"></param>
		private void SearchClient(string _searchClient)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ListFinancialClient> listFinancialClients = null;

				if (string.IsNullOrEmpty(_searchClient))
				{
					listFinancialClients =
						dataBaseContext.ListFinancialClients
						.OrderByDescending(current => current.Registration_Date)
						.ToList();
				}
				else if (_searchClient.StartsWith("09"))
				{
					listFinancialClients =
						dataBaseContext.ListFinancialClients
						.Where(current => current.Phone_Number.Contains(_searchClient))
						.OrderByDescending(current => current.Registration_Date)
						.ToList();
				}
				else
				{
					listFinancialClients =
						dataBaseContext.ListFinancialClients
						.Where(current => current.License_Plate.Contains(_searchClient))
						.OrderByDescending(current => current.Registration_Date)
						.ToList();
				}

				//listFinantioalClientDataGridView.DataSource = listFinancialClients;
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

		#endregion /SearchClient

		#region UpdateListFinancialClient
		/// <summary>
		/// به روز شدن حساب مشترک
		/// </summary>
		/// <returns>True Or False</returns>
		private bool UpdateListFinancialClient()
		{
			int id;
			decimal _amountRemaining, _amountPaid, _result;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				foreach (System.Windows.Forms.DataGridViewRow row in listFinantioalClientDataGridView.Rows)
				{
					if (row.Cells[1].Value != null || (bool)row.Cells[1].Value == true)
					{

						_amountRemaining = decimal.Parse(row.Cells[6].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						_amountPaid = decimal.Parse(row.Cells[5].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						_result = _amountPaid -(_amountRemaining);

						id = int.Parse(row.Cells[0].Value.ToString());

						Models.ListFinancialClient listFinancialClient =
							dataBaseContext.ListFinancialClients
							.Where(current => current.Id == id)
							.FirstOrDefault();

							listFinancialClient.Amount_Paid = $"{_result:#,0} تومان";
							listFinancialClient.Amount_Remaininig = $"0 تومان";
							listFinancialClient.Finantial_Situation = Models.ListFinancialClient.FinantialSituationClient.تسویه;
						
						dataBaseContext.SaveChanges();
					}
				}
				GetListFinantialClient();
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




		#endregion /UpdateListFinancialClient

		#endregion /Function
	}
}

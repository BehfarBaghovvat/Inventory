using System.Linq;

namespace Chequa_Bank
{
	public partial class ListChequasBankUC : System.Windows.Forms.UserControl
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties
		#region Layer

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









		#endregion /Layer

		private decimal _chequePid = 0;
		public decimal _chequeRecived = 0;

		public decimal Capital_Fund { get; set; }
		public Models.ChequeSection ChequeSection { get; set; }

		

		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public ListChequasBankUC()
		{
			InitializeComponent();
			Initialize();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region SearchSerialChequeTextBox_Enter
		private void SearchSerialChequeTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /SearchSerialChequeTextBox_Enter

		#region SearchSerialChequeTextBox_KeyPress
		private void SearchSerialChequeTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /SearchSerialChequeTextBox_KeyPress

		#region SearchSerialChequeTextBox_TextChange
		private void SearchSerialChequeTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchSerialChequeTextBox.Text))
			{
				return;
			}
			else
			{
				ChequeSection.Serial_Cheque = searchSerialChequeTextBox.Text;

				SearchSerialCheque(ChequeSection);
			}
		}
		#endregion /SearchSerialChequeTextBox_TextChange

		#region ChequePaymentButton_Click
		private void ChequePaymentButton_Click(object sender, System.EventArgs e)
		{
			if (ChequePayment())
			{
				Infrastructure.Utility.WindowsNotification(message: ".عملیات پرداخت چک انجام گردید", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
			}
			else
			{
				Infrastructure.Utility.WindowsNotification(message: ".خطا در انجام عملیات", caption: Infrastructure.PopupNotificationForm.Caption.خطا);
			}
		}
		#endregion /ChequePaymentButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Funciton

		#region ChequePayment
		/// <summary>
		/// پرداخت چکهای ثبت شده
		/// </summary>
		private bool ChequePayment()
		{
			try
			{
				foreach (System.Windows.Forms.DataGridViewRow row in listChequasDataGridView.Rows)
				{
					if (row.Cells[1].Value != null && (bool)row.Cells[1].Value == true)
					{
						_chequePid += decimal.Parse(row.Cells[5].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						_chequeRecived += decimal.Parse(row.Cells[6].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
				}
				Harvest(_chequePid);
				Deposit(_chequeRecived);
				Capital_Fund = GetCapitalFund();
				return true;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
				return false;
			}
		}
		#endregion /ChequePayment

		#region Deposit
		/// <summary>
		/// واریز چکهای دریافت شده از مشتریان
		/// </summary>
		/// <param name="_chequeRecived"></param>
		private void Deposit(decimal _chequeRecived)
		{
			Capital_Fund -= _chequeRecived;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					new Models.CapitalFund
					{
						Capital_Fund = $"{Capital_Fund:#,0} تومان",
					};
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
		#endregion /Deposit

		#region GetCapitalFund
		/// <summary>
		/// به روز رسانی و بارگزاری صندوق سرمایه
		/// </summary>
		/// <returns>capital_Fund</returns>
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
						capital_Fund = decimal.Parse(capitalFund.Capital_Fund.Replace("توان", string.Empty).Trim());
						MainForm.fundsNotificationTextBox.Text = $"{capital_Fund} تومان";
					}
					else
					{
						capital_Fund = decimal.Parse(capitalFund.Capital_Fund.Replace("توان", string.Empty).Replace(",", string.Empty).Trim());
						MainForm.fundsNotificationTextBox.Text = $"{capital_Fund:#,0} تومان";
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

		#region GetDataFormChequeSection
		/// <summary>
		/// بارگزاری لیست چکها
		/// </summary>
		private void GetDataFormChequeSection()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ChequeSection> _listChequeSections = new System.Collections.Generic.List<Models.ChequeSection>();

				_listChequeSections =
					dataBaseContext.ChequeSections
					.OrderBy(current => current.Data_Receipt)
					.ToList();

				listChequasDataGridView.DataSource = _listChequeSections;


				foreach (System.Windows.Forms.DataGridViewRow row in listChequasDataGridView.Rows)
				{
					if (string.Compare(row.Cells[7].Value.ToString(), "عدم_وصول_چک") == 0 )
					{
						listChequasDataGridView.CurrentRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
					}
					else if (string.Compare(row.Cells[7].Value.ToString(), "وصول_شد") == 0)
					{
						listChequasDataGridView.CurrentRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
					}
					else
					{
						listChequasDataGridView.CurrentRow.DefaultCellStyle.BackColor = System.Drawing.Color.White;
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
		#endregion /GetDataFormChequeSection

		#region Harvest
		/// <summary>
		/// پرداخت چک های صادر شده به فروشندگان
		/// </summary>
		/// <param name="_chequePid"></param>
		private void Harvest(decimal _chequePid)
		{
			Capital_Fund -= _chequePid;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					new Models.CapitalFund
					{
						Capital_Fund = $"{Capital_Fund:#,0} تومان",
					};
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
		#endregion /Harvest

		#region Initialize
		/// <summary>
		/// تنظیمات ورودی اولیه
		/// </summary>
		private void Initialize()
		{
			Capital_Fund = GetCapitalFund();

			GetDataFormChequeSection();
		}
		#endregion /Initialize

		#region SearchSerialCheque
		/// <summary>
		/// جستجوی سریال 16 رقمی صیاد 
		/// </summary>
		/// <param name="chequeSection"></param>
		private void SearchSerialCheque(Models.ChequeSection chequeSection)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ChequeSection> _listChequeSections = new System.Collections.Generic.List<Models.ChequeSection>();

				if (string.IsNullOrEmpty(chequeSection.Serial_Cheque))
				{
					_listChequeSections =
					dataBaseContext.ChequeSections
					.OrderBy(current => current.Data_Receipt)
					.ToList();
				}
				else
				{
					_listChequeSections =
					dataBaseContext.ChequeSections
					.Where(current => current.Serial_Cheque.Contains(chequeSection.Serial_Cheque))
					.OrderByDescending(current => current.Data_Receipt)
					.ToList();
				}

				listChequasDataGridView.DataSource = _listChequeSections;
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
		#endregion /SearchSerialCheque

		#endregion /Function
	}
}

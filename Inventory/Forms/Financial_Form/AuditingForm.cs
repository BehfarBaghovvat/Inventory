using System.Linq;

namespace Financial_Form
{
	public partial class AuditingForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Layer

		public enum FinantialSituation
		{
			بستانکار,
			تسویه,
			بدهکار,
		}

		public enum SearchType
		{
			تاریخ_ثبت,
			نام_فروشنده,
		}


		private class Audit
		{
			public decimal? Amount { get; set; }
			public decimal? Amount_Payment { get; set; }
			public decimal? Capital_Fund { get; set; }
			public string Object_Search { get; set; }
			public SearchType Search_Type { get; set; }
			public int? Select_Count { get; set; }
			public decimal? Sum_Amount { get; set; }
		}
		#endregion /Layer

		private Audit _audit = new Audit();

		#endregion /Properties


		//-----------------------------------------------------------------------------------------------     Constracture

		public AuditingForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region AuditingForm_Load
		private void AuditingForm_Load(object sender, System.EventArgs e)
		{

		}
		#endregion /AuditingForm_Load

		#region SearchTextBox_Enter
		private void SearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /SearchTextBox_Enter

		#region SearchTextBox_KeyPress
		private void SearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			switch (_audit.Search_Type)
			{
				case SearchType.تاریخ_ثبت:
				Infrastructure.Utility.InsertOnlyNumber(e, searchTextBox.Text);
				break;
				case SearchType.نام_فروشنده:
				Infrastructure.Utility.PersianTyping(e);
				break;
			}
		}
		#endregion /SearchTextBox_KeyPress

		#region SearchTextBox_TextChange
		private void SearchTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchTextBox.Text))
			{
				_audit.Object_Search = null;
			}
			else
			{
				_audit.Object_Search = searchTextBox.Text;
			}
		}
		#endregion /SearchTextBox_TextChange

		#region SellerNameRadioButton_CheckedChanged
		private void SellerNameRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			_audit.Search_Type = SearchType.نام_فروشنده;
		}
		#endregion /SellerNameRadioButton_CheckedChanged

		#region SellerNameLabel_Click
		private void SellerNameLabel_Click(object sender, System.EventArgs e)
		{
			sellerNameRadioButton.Checked = true;
		}
		#endregion /SellerNameLabel_Click

		#region RegisterDateRadioButton_CheckedChanged
		private void RegisterDateRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			_audit.Search_Type = SearchType.تاریخ_ثبت;
		}
		#endregion /RegisterDateRadioButton_CheckedChanged

		#region RegisterDateLabel_Click
		private void RegisterDateLabel_Click(object sender, System.EventArgs e)
		{
			registerDateRadioButton.Checked = true;
		}
		#endregion /RegisterDateLabel_Click

		#region AccountsPayableDataGridView_CellContentClick
		private void AccountsPayableDataGridView_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if ((e.ColumnIndex == 1 && e.RowIndex >= 0))
			{
				//این قسمت از کد زمانی که کاربر سطری را نتخاب میکنید 
				//بررسی میشود سطر انتخاب شده از نظر وضعیت مالی به چه صورت است.
				//اگر وضعیت بدهکار یا بستانکار باشد چک باکس انتخاب می شود. درغیر این صورت از انتخاب آن جلو گیری به عمل می آید.

				if ((string.Compare(accountsPayableDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString(), FinantialSituation.تسویه.ToString()) == 0))
				{
					accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].Value = false;
					accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].ReadOnly = true;
					return;
				}
				else
				{
					accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].ReadOnly = false;

					//این قسمت از کد هم با انتخاب شدن چک باکس،
					//ستون باقی مانده هر سطر محاسبه گردیده و نمایش داده میشود.  
					if (accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].Value != null && (bool)accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].Value == false)
					{
						accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].Value = true;

						_audit.Select_Count++;
						_audit.Amount +=
							decimal.Parse(accountsPayableDataGridView.CurrentRow.Cells[6].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						_audit.Amount_Payment = _audit.Amount;
					}
					else if (accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].Value != null && (bool)accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].Value == true)
					{
						accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].Value = false;

						_audit.Select_Count--;

						_audit.Amount -=
							decimal.Parse(accountsPayableDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						_audit.Amount_Payment = _audit.Amount;

						if (_audit.Select_Count <= 0)
						{
							_audit.Amount = 0;
							_audit.Select_Count = 0;
						}
					}
				}
			}
			else
			{
				accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].Value = false;
				accountsPayableDataGridView.CurrentCell.ReadOnly = true;
				return;
			}

			if (_audit.Amount == 0)
			{
				amountPaidTextBox.Clear();
				amountPaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

				paymentButton.Enabled = false;
			}
			else
			{
				amountPaidTextBox.Text = $"{_audit.Amount:#,0} تومان";
				amountPaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

				paymentButton.Enabled = true;
			}
		}
		#endregion /AccountsPayableDataGridView_CellContentClick

		#region PaymentButton_Click
		private void PaymentButton_Click(object sender, System.EventArgs e)
		{
			if (Payment(_audit) && UpdateAccountPayment())
			{
				Infrastructure.Utility.WindowsNotification(
					message: "عملیات پرداخت انجام شد.",
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

				ResetAllControl();
			}
			else
			{
				Infrastructure.Utility.WindowsNotification(
					message: "خطا در انجام عملیات", 
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				ResetAllControl();
			}
		}
		#endregion /PaymentButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods


		#region Function

		#region AllClear
		/// <summary>
		/// حذف اطلاعات داخل متغییر ها
		/// </summary>
		private void AllClear()
		{
			_audit.Amount = null;
			_audit.Select_Count = null;
			_audit.Capital_Fund = null;
		}
		#endregion /AllClear

		#region GetAccountPayment
		/// <summary>
		/// دریافت و بارگذاری 
		/// لیست حساب پرداختی ها
		/// </summary>
		private void GetAccountPayment()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.AccountsPayment> _listaccountsPayments = null;

				_listaccountsPayments =
						dataBaseContext.AccountsPayments
						.OrderBy(current => current.Id)
						.ToList();

				if (_listaccountsPayments == null)
				{
					return;
				}
				else
				{
					accountsPayableDataGridView.DataSource = _listaccountsPayments;
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
		#endregion /GetAccountPayment

		#region GetCapitalFund
		/// <summary>
		/// موجودی سرمایه را بر میگرداند.
		/// </summary>
		/// <returns>_capitalfund</returns>
		private decimal GetCapitalFund()
		{
			decimal _capitalfund = 0;
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
					_capitalfund = decimal.Parse(capitalFund.Capital_Fund.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				}

				return _capitalfund;
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
		#endregion GetCapitalFund

		#region Initialize
		/// <summary>
		/// مقدار دهی اولیه فرم
		/// </summary>
		public void Initialize()
		{
			AllClear();
			_audit.Capital_Fund = GetCapitalFund();
			foreach (System.Windows.Forms.DataGridViewRow row in accountsPayableDataGridView.Rows)
			{
				row.Cells[1].Value = false;

				if (string.Compare(row.Cells[7].Value.ToString(), FinantialSituation.بدهکار.ToString()) == 0)
				{
					row.Cells[7].Style.BackColor = System.Drawing.Color.LightPink;
				}
				else if (string.Compare(row.Cells[7].Value.ToString(), FinantialSituation.تسویه.ToString()) == 0)
				{
					row.Cells[7].Style.BackColor = System.Drawing.Color.LightGreen;
				}
				else if (string.Compare(row.Cells[7].Value.ToString(), FinantialSituation.بستانکار.ToString()) == 0)
				{
					row.Cells[7].Style.BackColor = System.Drawing.Color.LightGreen;
				}
			}

			ResetAllControl();
		}
		#endregion /Initialize

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
			decimal? _resualtCalculate = _audit.Capital_Fund + (_audit.Amount_Payment);

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.FirstOrDefault();

				capitalFund.Capital_Fund  = $"{_resualtCalculate:#,0} تومان";

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

		#region ResetAllControl
		/// <summary>
		/// حالت اولیه کنترلها
		/// </summary>
		private void ResetAllControl()
		{
			paymentButton.Enabled = false;
			amountPaidTextBox.Clear();
			searchTextBox.Clear();
			sellerNameRadioButton.Checked = false;
			registerDateRadioButton.Checked = false;
			AllClear();

			GetAccountPayment();
		}
		#endregion /ResetAllControl

		#region SearchObject
		private void SearchObject(string _objectSearch, SearchType _searchType)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.AccountsPayment> _listAccountPayment = null;


				if (string.Compare(_searchType.ToString(), SearchType.نام_فروشنده.ToString()) == 0)
				{
					if (string.IsNullOrEmpty(_objectSearch))
					{
						_listAccountPayment =
							dataBaseContext.AccountsPayments
							.OrderBy(current => current.Id)
							.ToList();

					}
					else
					{
						_listAccountPayment =
							dataBaseContext.AccountsPayments
							.Where(current => current.Seller_Name.Contains(_objectSearch))
							.OrderBy(current => current.Id)
							.ToList();
					}

					accountsPayableDataGridView.DataSource = _listAccountPayment;

					return;
				}
				else if (string.Compare(_searchType.ToString(), SearchType.تاریخ_ثبت.ToString()) == 0)
				{
					if (string.IsNullOrEmpty(_objectSearch))
					{
						_listAccountPayment =
							dataBaseContext.AccountsPayments
							.OrderBy(current => current.Id)
							.ToList();

					}
					else
					{
						_listAccountPayment =
							dataBaseContext.AccountsPayments
							.Where(current => current.Registration_Date.Contains(_objectSearch))
							.OrderBy(current => current.Id)
							.ToList();
					}

					accountsPayableDataGridView.DataSource = _listAccountPayment;
					return;
				}
				else
				{
					Mbb.Windows.Forms.MessageBox.Show(
						text: "لطفا نوع جستجو را انتخاب نمایید!",
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					searchTextBox.Clear();
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
		#endregion /SearchObject

		#region UpdateAccountPayment
		/// <summary>
		/// به روز کردن جدول حساب پرداختی 
		/// </summary>
		/// <returns></returns>
		private bool UpdateAccountPayment()
		{
			int id;
			decimal _amountRemaining, _amountPaid, _result;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				foreach (System.Windows.Forms.DataGridViewRow row in accountsPayableDataGridView.Rows)
				{
					if (row.Cells[1].Value != null && (bool)row.Cells[1].Value == true)
					{
						_amountRemaining = decimal.Parse(row.Cells[6].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						_amountPaid = decimal.Parse(row.Cells[5].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						_result = _amountPaid - (_amountRemaining);


						id = int.Parse(row.Cells[0].Value.ToString());

						Models.AccountsPayment accountsPayment =
							dataBaseContext.AccountsPayments
							.Where(current => current.Id == id)
							.FirstOrDefault();

						accountsPayment.Amount_Paid = $"{_result:#,0} تومان";
						accountsPayment.Amount_Remaininig = $"0 تومان";
						accountsPayment.Finantial_Situation = Models.AccountsPayment.FinantialSituationAccountPaymetn.تسویه;

						dataBaseContext.SaveChanges();
					}
				}
				GetAccountPayment();
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
		#endregion /UpdateAccountPayment

		#endregion Function
	}
}

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
		#endregion /Layer

		private decimal _amounts;

		public decimal Amount_Payment { get; set; }
		public decimal Capital_Fund { get; set; }
		public int Select_Count { get; set; }
		public decimal Sum_Amount { get; set; }
		

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
			Initialize();
		}
		#endregion /AuditingForm_Load

		#region SearchTextBox_Enter
		private void SearchTextBox_Enter(object sender, System.EventArgs e)
		{

		}
		#endregion /SearchTextBox_Enter

		#region SearchTextBox_KeyPress
		private void SearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}
		#endregion /SearchTextBox_KeyPress

		#region SearchTextBox_TextChange
		private void SearchTextBox_TextChange(object sender, System.EventArgs e)
		{

		}
		#endregion /SearchTextBox_TextChange

		#region SellerNameRadioButton_CheckedChanged
		private void SellerNameRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{

		}
		#endregion /SellerNameRadioButton_CheckedChanged

		#region SellerNameLabel_Click
		private void SellerNameLabel_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /SellerNameLabel_Click

		#region RegisterDateRadioButton_CheckedChanged
		private void RegisterDateRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{

		}
		#endregion /RegisterDateRadioButton_CheckedChanged

		#region RegisterDateLabel_Click
		private void RegisterDateLabel_Click(object sender, System.EventArgs e)
		{

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

				if ((string.Compare(accountsPayableDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString(), FinantialSituation.تسویه.ToString()) == 0))
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

						Select_Count++;
						_amounts +=
							decimal.Parse(accountsPayableDataGridView.CurrentRow.Cells[6].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						Amount_Payment = _amounts;

					}
					else if (accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].Value != null && (bool)accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].Value == true)
					{

						accountsPayableDataGridView.Rows[e.RowIndex].Cells[1].Value = false;

						Select_Count--;

						_amounts -=
							decimal.Parse(accountsPayableDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						Amount_Payment = _amounts;

						if (Select_Count <= 0)
						{
							AllClear();
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

			if (_amounts == 0)
			{
				amountPaidTextBox.Clear();
				amountPaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

				paymentButton.Enabled = false;
			}
			else
			{
				amountPaidTextBox.Text = $"{_amounts:#,0} تومان";
				amountPaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

				paymentButton.Enabled = true;
			}
		}
		#endregion /AccountsPayableDataGridView_CellContentClick

		#region PaymentButton_Click
		private void PaymentButton_Click(object sender, System.EventArgs e)
		{
			if (Payment(Amount_Payment, Capital_Fund))
			{
				Infrastructure.Utility.WindowsNotification(
					message: "عملیات پرداخت انجام شد.", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
			}
			else
			{
				Infrastructure.Utility.WindowsNotification(
					message: "خطا در انجام عملیات", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
			}
		}
		#endregion /PaymentButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods


		#region Function

		#region AllClear
		/// <summary>
		/// حذف اطلاعات داخل متغییر ها و کنترل ها
		/// </summary>
		private void AllClear()
		{
			_amounts = 0;
			Select_Count = 0;
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


				foreach (System.Windows.Forms.DataGridViewRow row in accountsPayableDataGridView.Rows)
				{
					row.Cells[1].Value = false;

					if (string.Compare(row.Cells[8].Value.ToString(), FinantialSituation.بدهکار.ToString()) == 0)
					{
						row.Cells[8].Style.BackColor = System.Drawing.Color.LightPink;
					}
					else if (string.Compare(row.Cells[8].Value.ToString(), FinantialSituation.تسویه.ToString()) == 0)
					{
						row.Cells[8].Style.BackColor = System.Drawing.Color.LightGreen;
					}
					else if (string.Compare(row.Cells[8].Value.ToString(), FinantialSituation.بستانکار.ToString()) == 0)
					{
						row.Cells[8].Style.BackColor = System.Drawing.Color.LightGreen;
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
					_capitalfund =decimal.Parse(capitalFund.Capital_Fund.Replace("تومان",string.Empty).Replace(",",string.Empty).Trim());
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
			GetAccountPayment();
			AllClear();

			Capital_Fund = GetCapitalFund();
		}
		#endregion /Initialize

		#region Payment
		/// <summary>
		/// تابع پرداخت صورت حساب
		/// </summary>
		/// <param name="_amountPayment"></param>
		/// <param name="_capitalFund"></param>
		/// <returns>True Or False</returns>
		private bool Payment(decimal _amountPayment, decimal _capitalFund)
		{
			decimal _returnCapitalFund = 0;
			decimal _resualtCalculate = _capitalFund + (_amountPayment);

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
					capitalFund.Capital_Fund = $"{_resualtCalculate:#,0} تومان";

					dataBaseContext.CapitalFunds.Add(capitalFund);
				}
				else
				{
					capitalFund.Capital_Fund = $"{_resualtCalculate:#,0} تومان";
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


		#endregion Function

	}
}

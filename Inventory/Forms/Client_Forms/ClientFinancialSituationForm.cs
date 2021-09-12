using System.Linq;

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

		private decimal? _amounts = 0;

		public decimal? Amount_Paid { get; set; }
		public decimal? Capital_Fund { get; set; }
		public string Search_Client { get; set; }
		public int? Situation { get; set; }
		public decimal? Sum_Amount { get; set; }
		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public ClientFinancialSituationForm()
		{
			InitializeComponent();
			Initialize();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

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
				Search_Client = null;
				return;
			}
			else
			{
				searchClientTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

				Search_Client = searchClientTextBox.Text;

				SearchClient(Search_Client);
			}
		}
		#endregion /SearchClientTextBox_TextChange

		#region ListFinantioalClientDataGridView_CellClick
		private void ListFinantioalClientDataGridView_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex <= 0 && e.ColumnIndex <= 0)
			{
				return;
			}

			if (listFinantioalClientDataGridView.CurrentRow.Cells[1].Value != null && (bool)listFinantioalClientDataGridView.CurrentRow.Cells[1].Value == true)
			{
				if (string.Compare(listFinantioalClientDataGridView.CurrentRow.Cells[7].Value.ToString(),FinantialSituation.تسویه.ToString()) == 0 )
				{
					listFinantioalClientDataGridView.CurrentRow.Cells[1].Value = false;
				}
				else
				{
					_amounts += decimal.Parse(listFinantioalClientDataGridView.CurrentRow.Cells[5].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				}
				
			}

			Sum_Amount = _amounts;

			if (_amounts < 999)
			{
				totalAmountTextBox.Text = $"{Sum_Amount} تومان";
			}
			else
			{
				totalAmountTextBox.Text = $"{Sum_Amount:#,0} تومان";
			}
		}
		#endregion /ListFinantioalClientDataGridView_CellClick

		#region TotalAmountLabel_TextChanged
		private void TotalAmountTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Situation = CheckSituation(Sum_Amount);

			totalAmountTextBox.Text = $"{Sum_Amount:#,0} تومان";

			if (string.Compare(totalAmountTextBox.Text, "0 تومان") == 0 || totalAmountTextBox.Text.Length <= 11)
			{
				paymentButton.Enabled = true;
			}
			else
			{
				paymentButton.Enabled = false;
			}
		}
		#endregion /TotalAmountLabel_TextChanged

		#region PaymentButton_Click
		private void PaymentButton_Click(object sender, System.EventArgs e)
		{
			if (SetAmountInCapitalFund(CheckSituation(Sum_Amount), Sum_Amount))
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
		/// <returns>1 or 0 or -1</returns>
		private int? CheckSituation(decimal? _amount)
		{
			if (_amounts > 0)
			{
				financialSituationLabel.Text = "بدهکار";
				financialSituationLabel.ForeColor = System.Drawing.Color.LightGreen;
				paymentButton.Enabled = true;
				return 1;
			}
			else if (_amounts == 0)
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
				return -1;
			}
		}

		#endregion CheckSituation

		#region Initialize
		/// <summary>
		/// تنظیمات اولیه ورود
		/// </summary>
		private void Initialize()
		{
			GetListFinantialClient();
			Capital_Fund = GetCapitalFund();
		}
		#endregion /Initialize

		#region GetCapitalFund
		/// <summary>
		/// بارگذاری مبلغ سرمایه صندوق
		/// </summary>
		/// <returns>amount of 0</returns>
		private decimal GetCapitalFund()
		{
			decimal amount;
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
						amount = 0;
					}
					else if (capitalFund.Capital_Fund.Length < 9)
					{
						amount = decimal.Parse(capitalFund.Capital_Fund.Replace("توان", string.Empty).Trim());
					}
					else
					{
						amount = decimal.Parse(capitalFund.Capital_Fund.Replace("توان", string.Empty).Replace(",", string.Empty).Trim());
					}
				}

				MainForm.fundLabel.Text = $"{amount:#,0} تومان";

				return amount;
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
						.OrderByDescending(current => current.Registration_Date)
						.ToList();

				if (listFinancialClients == null)
				{
					return;
				}
				else
				{
					listFinantioalClientDataGridView.DataSource = listFinancialClients;
				}

				foreach (System.Windows.Forms.DataGridViewRow row in listFinantioalClientDataGridView.Rows)
				{
					if (string.Compare(row.Cells[7].Value.ToString(),FinantialSituation.بدهکار.ToString()) == 0)
					{
						row.DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
					}
					if (string.Compare(row.Cells[7].Value.ToString(), FinantialSituation.تسویه.ToString()) == 0)
					{
						row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
					}
					if (string.Compare(row.Cells[7].Value.ToString(), FinantialSituation.بستانکار.ToString()) == 0)
					{
						row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
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
		#endregion GetListFinantialClient

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

				listFinantioalClientDataGridView.DataSource = listFinancialClients;
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

		#region SetAmountInCapitalFund
		/// <summary>
		/// ثبت مبالغ (پرداختی یا دریافتی) صندوق سرمایه
		/// </summary>
		/// <param name="_situation"></param>
		/// <param name="_amount"></param>
		private bool SetAmountInCapitalFund(int? _situation, decimal? _amount)
		{
			if (_situation == 1)
			{
				Capital_Fund += _amount;

				Models.DataBaseContext dataBaseContext = null;
				try
				{
					dataBaseContext =
						new Models.DataBaseContext();

					Models.CapitalFund capitalFund =
						new Models.CapitalFund()
						{
							Capital_Fund = $"{Capital_Fund:#,0} تومان"
						};

					dataBaseContext.SaveChanges();
					Capital_Fund = GetCapitalFund();
					paymentButton.Enabled = false;

					foreach (System.Windows.Forms.DataGridViewRow row in listFinantioalClientDataGridView.Rows)
					{
						if (row.Cells[1].Value != null || (bool)row.Cells[1].Value == true)
						{
							row.Cells[1].Value = false;
							row.Cells[0].Value = $"0 تومان";
							row.Cells[7].Value = $"{FinantialSituation.تسویه}";
							row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
						}
					}

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
			else if (_situation == -1)
			{
				Capital_Fund -= _amount;

				Models.DataBaseContext dataBaseContext = null;
				try
				{
					dataBaseContext =
						new Models.DataBaseContext();

					Models.CapitalFund capitalFund =
						new Models.CapitalFund()
						{
							Capital_Fund = $"{Capital_Fund:#,0} تومان"
						};

					dataBaseContext.SaveChanges();

					Capital_Fund = GetCapitalFund();

					foreach (System.Windows.Forms.DataGridViewRow row in listFinantioalClientDataGridView.Rows)
					{
						if (row.Cells[1].Value != null || (bool)row.Cells[1].Value == true)
						{
							row.Cells[1].Value = false;
							row.Cells[0].Value = $"0 تومان";
							row.Cells[7].Value = $"{FinantialSituation.تسویه}";
							row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
						}
					}







					paymentButton.Enabled = false;

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
			else if(_situation == 0)
			{
				Infrastructure.Utility.WindowsNotification(message: "پرداختی صورت نگرفت.", caption: Infrastructure.PopupNotificationForm.Caption.اطلاع);
				return false;
			}
			else
			{
				return false;
			}

		}
		#endregion /SetAmountInCapitalFund

		#endregion /Function
	}
}

using System.Linq;

namespace Financial_Form
{
	public partial class FinancialReportForm : Infrastructure.EmptyForm
	{
		//------------------------------------------------------------------------------------ Fields And Properties

		#region Properties

		#region Layer
		/// <summary>
		/// کلاس گردش مالی
		/// این کلاس برای این است که با شی که از آن
		/// ایجاد میکنیم میتوانیم محتوای لیست دفتر روزنامه
		/// را در شی ایجاد شده ذخیره کنیم
		/// </summary>
		public class FinancialCirculation
		{
			public string Amount_Paid { get; set; }
			public string Amount_Received { get; set; }
		}
		#endregion /Layer

		private FinancialCirculation financialCirculation = new FinancialCirculation();

		private Financial_Order.AncillaryCostsUC _ancillaryCosts = new Financial_Order.AncillaryCostsUC();
		private Financial_Order.CapitalTurnoverChartUC _capitalTurnoverChartUC = new Financial_Order.CapitalTurnoverChartUC();
		private Financial_Order.DispositUC _dispositUC = new Financial_Order.DispositUC();
		private Financial_Order.PaymentUC _paymentUC = new Financial_Order.PaymentUC();

		#endregion /Properties



		//------------------------------------------------------------------------------------ Constracture

		public FinancialReportForm()
		{
			InitializeComponent();
		}



		//------------------------------------------------------------------------------------ Event Controls

		#region CapitalChartButton_Click
		private void CapitalChartButton_Click(object sender, System.EventArgs e)
		{
			ShowCapitalChartUC();
		}
		#endregion /CapitalChartButton_Click

		#region AncillaryCostsButton_Click
		private void AncillaryCostsButton_Click(object sender, System.EventArgs e)
		{
			ShowAncillaryCostsUC();
		}
		#endregion /AncillaryCostsButton_Click

		#region CapitalInflowButton_Click
		private void CapitalInflowButton_Click(object sender, System.EventArgs e)
		{
			ShowDispositUC();
		}
		#endregion /CapitalInflowButton_Click

		#region CapitalOutflowButton_Click
		private void CapitalOutflowButton_Click(object sender, System.EventArgs e)
		{
			ShowPaymentUC();
		}
		#endregion /CapitalOutflowButton_Click



		//------------------------------------------------------------------------------------ Private Methods

		#region Initialize
		/// <summary>
		/// تنظیمات اولیه ورودی
		/// </summary>
		public void Initialize()
		{
			bottomPanel.Controls.Clear();
			capitalFundLabel.Text = GetAmountInCirculation();
			ancillaryCostsLabel.Text = GetAmountAncillaryCosts();
			capitalInflowLabel.Text = GetTotalAmountRecived();
			capitalOutflowLabelLabel.Text = GetTotalAmountPaid();
		}
		#endregion /Initialize

		#region GetAmountAncillaryCosts
		/// <summary>
		/// کل هزینه های جانبی صورت گرفته
		/// در قالب یک متغییر رشته ای بازگشت داده
		/// می شود
		/// </summary>
		/// <returns>_sumTotalAncillaryCosts</returns>
		private string GetAmountAncillaryCosts()
		{
			string _sumTotalAncillaryCosts = "0 تومان";
			decimal _totalAmountPaid = 0;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.AncillaryCosts> listAncillaryCosts = new System.Collections.Generic.List<Models.AncillaryCosts>();

				listAncillaryCosts =
					dataBaseContext.AncillaryCosts
					.ToList();

				if (listAncillaryCosts == null)
				{
					return _sumTotalAncillaryCosts;
				}
				else
				{
					for (int count = 0; count < listAncillaryCosts.Count; count++)
					{
						_totalAmountPaid += decimal.Parse(listAncillaryCosts[count].Amount_Payment.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
				}

				return _sumTotalAncillaryCosts = $"{_totalAmountPaid:#,0} تومان";

			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
				return _sumTotalAncillaryCosts;
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
		#endregion /GetAmountAncillaryCosts

		#region GetAmountInCirculation
		/// <summary>
		/// کل مبلغ گردش مالی (چه پرداختی، چه دریافتی)
		/// در قالب یک متغییر رشته ای بازگشت داده
		/// می شود.
		/// </summary>
		/// <returns>_sumTotalCirculation</returns>
		private string GetAmountInCirculation()
		{
			string _sumTotalCirculation = "0 تومان";
			decimal _sumTotalAmount, _totalAmountReceived = 0, _totalAmountPaid = 0;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Journal> listJournals = new System.Collections.Generic.List<Models.Journal>();
				listJournals =
					dataBaseContext.Journals
					.ToList();

				if (listJournals == null)
				{
					return _sumTotalCirculation;
				}
				else
				{
					for (int count = 0; count < listJournals.Count; count++)
					{
						if (listJournals[count].Amount_Received.Length <= 9)
						{
							_totalAmountReceived += decimal.Parse(listJournals[count].Amount_Received.Replace("تومان", string.Empty).Trim());
						}
						else
						{
							_totalAmountReceived += decimal.Parse(listJournals[count].Amount_Received.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

						}

						if (listJournals[count].Amount_Paid.Length <= 9)
						{
							_totalAmountPaid += decimal.Parse(listJournals[count].Amount_Paid.Replace("تومان", string.Empty).Trim());
						}
						_totalAmountPaid += decimal.Parse(listJournals[count].Amount_Paid.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
				}

				_sumTotalAmount = _totalAmountPaid + _totalAmountReceived;

				return _sumTotalCirculation = $"{_sumTotalAmount:#,0} تومان";

			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
				return _sumTotalCirculation;
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
		#endregion /GetAmountInCirculation

		#region GetTotalAmountPaid
		/// <summary>
		/// کل مبالغ پرداختی را بر میگرداند
		/// </summary>
		/// <returns></returns>
		private string GetTotalAmountPaid()
		{
			string _sumTotalPaid = "0 تومان";
			decimal _totalAmountPaid = 0;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Journal> listJournals = new System.Collections.Generic.List<Models.Journal>();

				listJournals =
					dataBaseContext.Journals
					.ToList();

				if (listJournals == null)
				{
					return _sumTotalPaid;
				}
				else
				{
					for (int count = 0; count < listJournals.Count; count++)
					{
						_totalAmountPaid += decimal.Parse(listJournals[count].Amount_Paid.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
				}

				return _sumTotalPaid = $"{_totalAmountPaid:#,0} تومان";

			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
				return _sumTotalPaid;
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
		#endregion /GetTotalAmountPaid

		#region GetTotalAmountRecived
		/// <summary>
		/// کل مبالغ دریافتی را بر میگرداند
		/// </summary>
		/// <returns></returns>
		private string GetTotalAmountRecived()
		{
			string _sumTotalCirculation = "0 تومان";
			decimal _totalAmountReceived = 0;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Journal> listJournals = new System.Collections.Generic.List<Models.Journal>();

				listJournals =
					dataBaseContext.Journals
					.ToList();

				if (listJournals == null)
				{
					return _sumTotalCirculation;
				}
				else
				{
					for (int count = 0; count < listJournals.Count; count++)
					{
						_totalAmountReceived += decimal.Parse(listJournals[count].Amount_Received.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
				}

				return _sumTotalCirculation = $"{_totalAmountReceived:#,0} تومان";

			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
				return _sumTotalCirculation;
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
		#endregion /GetTotalAmountRecived

		#region ShowAncillaryCostsUC
		/// <summary>
		/// نماش فرم هزینه های 
		/// </summary>
		private void ShowAncillaryCostsUC()
		{
			bottomPanel.Controls.Clear();
			bottomPanel.Controls.Add(_ancillaryCosts);
			bottomPanel.Controls.Remove(_capitalTurnoverChartUC);
			bottomPanel.Controls.Remove(_dispositUC);
			bottomPanel.Controls.Remove(_paymentUC);
		}
		#endregion /ShowAncillaryCostsUC

		#region ShowCapitalChartUC
		/// <summary>
		/// نمایش فرم نمودار سرمایه
		/// </summary>
		private void ShowCapitalChartUC()
		{
			bottomPanel.Controls.Clear();
			bottomPanel.Controls.Add(_capitalTurnoverChartUC);
			bottomPanel.Controls.Remove(_ancillaryCosts);
			bottomPanel.Controls.Remove(_dispositUC);
			bottomPanel.Controls.Remove(_paymentUC);
		}
		#endregion /ShowCapitalChartUC

		#region ShowDispositUC
		/// <summary>
		/// نمایش فرم ورود سرمایه
		/// </summary>
		private void ShowDispositUC()
		{
			bottomPanel.Controls.Clear();
			bottomPanel.Controls.Add(_dispositUC);
			bottomPanel.Controls.Remove(_ancillaryCosts);
			bottomPanel.Controls.Remove(_capitalTurnoverChartUC);
			bottomPanel.Controls.Remove(_paymentUC);
		}
		#endregion /ShowDispositUC

		#region ShowPaymentUC
		/// <summary>
		/// نمایش فرم خروج سرمایه
		/// </summary>
		private void ShowPaymentUC()
		{
			bottomPanel.Controls.Clear();
			bottomPanel.Controls.Add(_paymentUC);
			bottomPanel.Controls.Remove(_ancillaryCosts);
			bottomPanel.Controls.Remove(_dispositUC);
			bottomPanel.Controls.Remove(_capitalTurnoverChartUC);
		}
		#endregion /ShowPaymentUC



	}
}

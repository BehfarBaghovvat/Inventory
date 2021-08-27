
using System.Linq;

namespace Financial_Form
{
	
	public partial class FinancialOrderForm : Infrastructure.EmptyForm
	{
		//------------------------------------------------------------------------------------ Fields And Properties

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

		//------------------------------------------------------------------------------------ Constracture

		public FinancialOrderForm()
		{
			InitializeComponent();
		}



		//------------------------------------------------------------------------------------ Event Controls

		#region CapitalTurnoverButton_Click
		private void CapitalTurnoverButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /CapitalTurnoverButton_Click

		#region AncillaryCostsButton_Click
		private void AncillaryCostsButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /AncillaryCostsButton_Click

		#region CapitalInflowButton_Click
		private void CapitalInflowButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /CapitalInflowButton_Click

		#region CapitalOutflowButton_Click
		private void CapitalOutflowButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /CapitalOutflowButton_Click



		//------------------------------------------------------------------------------------ Private Methods

		#region Initialize
		private void Initialize()
		{

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
					for (int count = 1; count < listAncillaryCosts.Count; count++)
					{
						_totalAmountPaid += decimal.Parse(listAncillaryCosts[count].Amount_Payment.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
				}

				return _sumTotalAncillaryCosts = $"{_totalAmountPaid}:#,0 تومان";

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
			decimal _totalAmountReceived = 0 , _totalAmountPaid = 0;

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
					for (int count = 1; count < listJournals.Count; count++)
					{
						_totalAmountReceived += decimal.Parse(listJournals[count].Amount_Received.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						_totalAmountPaid += decimal.Parse(listJournals[count].Amount_Paid.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
				}

				return _sumTotalCirculation = $"{_totalAmountPaid + _totalAmountReceived}:#,0 تومان";

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
					for (int count = 1; count < listJournals.Count; count++)
					{
						_totalAmountPaid += decimal.Parse(listJournals[count].Amount_Paid.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
				}

				return _sumTotalPaid = $"{_totalAmountPaid}:#,0 تومان";

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
					for (int count = 1; count < listJournals.Count; count++)
					{
						_totalAmountReceived += decimal.Parse(listJournals[count].Amount_Received.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
				}

				return _sumTotalCirculation = $"{_totalAmountReceived}:#,0 تومان";

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



	}
}

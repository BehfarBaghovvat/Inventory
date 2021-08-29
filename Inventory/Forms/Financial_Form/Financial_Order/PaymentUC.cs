using System.Linq;
namespace Financial_Order
{
	public partial class PaymentUC : System.Windows.Forms.UserControl
	{
		//------------------------------------------------------------------------------------ Fields And Properties


		//------------------------------------------------------------------------------------ Constracture

		public PaymentUC()
		{
			InitializeComponent();
		}



		//------------------------------------------------------------------------------------ Event Controls

		private void PaymentUC_Load(object sender, System.EventArgs e)
		{
			GetDataFromJournal();
		}



		//------------------------------------------------------------------------------------ Private Methods

		#region GetDataFromJournal
		/// <summary>
		/// دریافت اطلاعات از جدول روزنامه
		/// </summary>
		private void GetDataFromJournal()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.Journal> listJournals = new System.Collections.Generic.List<Models.Journal>();

				listJournals =
					dataBaseContext.Journals
					.Where(current => string.Compare(current.Amount_Paid,"0 تومان") !=0)
					.OrderBy(current => current.Amount_Paid)
					.ToList();

				paymentDataGridView.DataSource = listJournals;
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
		#endregion /GetDataFromJournal
	}
}

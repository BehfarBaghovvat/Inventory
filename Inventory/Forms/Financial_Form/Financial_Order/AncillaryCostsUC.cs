using System.Linq;
namespace Financial_Order
{
	public partial class AncillaryCostsUC : System.Windows.Forms.UserControl
	{
		//------------------------------------------------------------------------------------ Constracture

		public AncillaryCostsUC()
		{
			InitializeComponent();
			GetListAncillaryCosts();
		}



		//--------------------------------------------------------------------------------------------------    Private Methods

		#region GetListAncillaryCosts
		/// <summary>
		/// نمایش لیست کاملی از هزینه های جانبی صورت گرفته
		/// </summary>
		private void GetListAncillaryCosts()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.AncillaryCosts> listAncillaryCosts = new System.Collections.Generic.List<Models.AncillaryCosts>();

				listAncillaryCosts =
					dataBaseContext.AncillaryCosts

					.OrderByDescending(current => current.Registration_Date)
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
		#endregion /GetListAncillaryCosts
	}
}

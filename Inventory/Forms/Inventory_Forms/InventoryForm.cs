using System.Linq;

namespace Inventory_Forms
{
	public partial class InventoryForm : Infrastructure.EmptyForm
	{
		public InventoryForm()
		{
			InitializeComponent();

			LoadedProduction();
		}

		//----------Beginning of the code!----------

		#region ProductNameSearchTextBox_Enter
		private void ProductNameSearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /ProductNameSearchTextBox_Enter

		#region ProductNameSearchTextBox_KeyPress
		private void ProductNameSearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /ProductNameSearchTextBox_KeyPress

		#region ProductNameSearchTextBox_TextChange
		private void ProductNameSearchTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(productNameSearchTextBox.Text))
			{
				return;
			}
			else
			{
				ProductNameSearch(productNameSearchTextBox.Text);
			}
		}
		#endregion /ProductNameSearchTextBox_TextChange

		//----------End of code!----------

		#region Function

		#region LoadedProduction
		private void LoadedProduction()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.InventoryHolding> inventoryHoldings = null;

				inventoryHoldings =
					dataBaseContext.InventoryHoldings
					.OrderBy(currnet => currnet.Id)
					.ToList();

				inventoryHoldingDataGridView.DataSource = inventoryHoldings;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}

		#endregion /LoadedProduction

		#region ProductNameSearch
		private void ProductNameSearch(string productNameSearch)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.InventoryHolding> inventoryHoldingList = new System.Collections.Generic.List<Models.InventoryHolding>();

				if (string.IsNullOrEmpty(productNameSearch))
				{
					inventoryHoldingList =
						dataBaseContext.InventoryHoldings
						.OrderBy(current => current.Id)
						.ToList();
				}
				else
				{

					inventoryHoldingList =
						dataBaseContext.InventoryHoldings
						.Where(current => current.Product_Name.Contains(productNameSearch))
						.OrderBy(current => current.Id)
						.ToList();
				}

				inventoryHoldingDataGridView.DataSource = inventoryHoldingList;
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
		#endregion /ProductNameSearch

		#endregion /Function
	}
}

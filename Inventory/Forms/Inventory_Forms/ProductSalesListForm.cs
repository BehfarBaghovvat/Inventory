using System.Linq;

namespace Inventory_Forms
{
	public partial class InventoryOutputForm : Infrastructure.EmptyForm
	{

		#region Properties

		public string Search { get; set; }

		#endregion /Properties

		public InventoryOutputForm()
		{
			InitializeComponent();
		}

		//----------Beginning of the code!----------

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizeButton_Click

		#region SearchTextBox_Enter
		private void SearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /SearchTextBox_Enter

		#region SearchTextBox_KeyPress
		private void SearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (selectSearchComboBox.SelectedIndex == 0)
			{
				e.Handled = false;
				return;
			}
			else if (selectSearchComboBox.SelectedIndex >= 1 || selectSearchComboBox.SelectedIndex <= 4)
			{
				Infrastructure.Utility.PersianTyping(e);
			}
			else if (selectSearchComboBox.SelectedIndex == 5)
			{
				Infrastructure.Utility.PersianAndNumberTyping(e);
			}
		}
		#endregion /SearchTextBox_KeyPress

		#region SearchTextBox_TextChange
		private void SearchTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (selectSearchComboBox.SelectedIndex == 0)
			{
				Search = null;
				return;
			}
			else if (selectSearchComboBox.SelectedIndex == 1)//----- جستجوی نام مشتری
			{
				if (string.IsNullOrWhiteSpace(searchTextBox.Text))
				{
					Search = null;
					return;
				}
				else
				{
					Search = searchTextBox.Text;

					ClientNameSearch(Search);
				}
			}
			else if (selectSearchComboBox.SelectedIndex == 2)//----- جستجوی نام فروشنده
			{
				if (string.IsNullOrWhiteSpace(searchTextBox.Text))
				{
					Search = null;
					return;
				}
				else
				{
					Search = searchTextBox.Text;

					SellerNameSearch(Search);
				}
			}
			else if (selectSearchComboBox.SelectedIndex == 3)//----- جستجوی حامل کالا
			{
				if (string.IsNullOrWhiteSpace(searchTextBox.Text))
				{
					Search = null;
					return;
				}
				else
				{
					Search = searchTextBox.Text;
					CarrierNameSearch(Search);

				}
			}
			else if (selectSearchComboBox.SelectedIndex == 4)//----- جستجوی نام کالا
			{
				if (string.IsNullOrWhiteSpace(searchTextBox.Text))
				{
					Search = null;
					return;
				}
				else
				{
					Search = searchTextBox.Text;

					ProductNameSearch(Search);
				}
			}
			else if (selectSearchComboBox.SelectedIndex == 5)//----- جستجوی تاریخ ثبت
			{
				if (string.IsNullOrWhiteSpace(searchTextBox.Text))
				{
					Search = null;
					return;
				}
				else
				{
					Search = searchTextBox.Text;

					DateSearch(Search);
				}
			}
		}
		#endregion /SearchTextBox_TextChange

		#region SelectSearchComboBox_SelectedIndexChanged
		private void SelectSearchComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}
		#endregion /SelectSearchComboBox_SelectedIndexChanged

		//----------End of code!----------

		#region Founction

		#region CarrierNameSearch
		private void CarrierNameSearch(string carrierName)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.InventoryOutput> carrierList = new System.Collections.Generic.List<Models.InventoryOutput>();

				if (string.IsNullOrEmpty(carrierName))
				{
					carrierList =
					dataBaseContext.InventoryOutputs
					.OrderBy(current => current.Id)
					.ToList();
				}
				else
				{
					carrierList =
					dataBaseContext.InventoryOutputs
					.Where(current => current.Carrier_Name.Contains(carrierName))
					.OrderBy(current => current.Client_Name)
					.ToList();
				}

				inventoryOutputDataGridView.DataSource = carrierList;
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
		#endregion /CarrierNameSearch

		#region ClientNameSearch
		private void ClientNameSearch(string clientName)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.InventoryOutput> clientList = new System.Collections.Generic.List<Models.InventoryOutput>();

				if (string.IsNullOrEmpty(clientName))
				{
					clientList =
					dataBaseContext.InventoryOutputs
					.OrderBy(current => current.Id)
					.ToList();
				}
				else
				{
					clientList =
					dataBaseContext.InventoryOutputs
					.Where(current => current.Client_Name.Contains(clientName))
					.OrderBy(current => current.Client_Name)
					.ToList();
				}

				inventoryOutputDataGridView.DataSource = clientList;
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
		#endregion /ClientNameSearch

		#region DateSearch
		private void DateSearch(string dateSearch)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.InventoryOutput> dateList = new System.Collections.Generic.List<Models.InventoryOutput>();

				if (string.IsNullOrEmpty(dateSearch))
				{
					dateList =
					dataBaseContext.InventoryOutputs
					.OrderBy(current => current.Id)
					.ToList();
				}
				else
				{
					dateList =
					dataBaseContext.InventoryOutputs
					.Where(current => current.Add_Order_Date.Contains(dateSearch))
					.OrderBy(current => current.Id)
					.ToList();
				}

				inventoryOutputDataGridView.DataSource = dateList;
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
		#endregion /DateSearch

		#region LoadingInventoryOutput
		private void LoadingInventoryOutput()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.InventoryOutput> inventoryOutputList = new System.Collections.Generic.List<Models.InventoryOutput>();

				inventoryOutputList =
					dataBaseContext.InventoryOutputs
					.OrderBy(current => current.Id)
					.ToList();


				if (inventoryOutputList != null)
				{
					inventoryOutputDataGridView.DataSource = inventoryOutputList;
				}
				else
				{
					return;
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

		#endregion /LoadingInventoryOutput

		#region ProductNameSearch
		private void ProductNameSearch(string productName)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.InventoryOutput> productList = new System.Collections.Generic.List<Models.InventoryOutput>();

				if (string.IsNullOrEmpty(productName))
				{
					productList =
					dataBaseContext.InventoryOutputs
					.OrderBy(current => current.Id)
					.ToList();
				}
				else
				{
					productList =
					dataBaseContext.InventoryOutputs
					.Where(current => current.Product_Name.Contains(productName))
					.OrderBy(current => current.Id)
					.ToList();
				}

				inventoryOutputDataGridView.DataSource = productList;
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

		#region SellerNameSearch
		private void SellerNameSearch(string sellerName)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.InventoryOutput> sellerList = new System.Collections.Generic.List<Models.InventoryOutput>();

				if (string.IsNullOrEmpty(sellerName))
				{
					sellerList =
					dataBaseContext.InventoryOutputs
					.OrderBy(current => current.Id)
					.ToList();
				}
				else
				{
					sellerList =
					dataBaseContext.InventoryOutputs
					.Where(current => current.Seller_Name.Contains(sellerName))
					.OrderBy(current => current.Id)
					.ToList();
				}

				inventoryOutputDataGridView.DataSource = sellerList;
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
		#endregion /SellerNameSearch

		#endregion /Founction
	}
}

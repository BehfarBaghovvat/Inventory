using System.Linq;

namespace Inventory_Forms
{
	public partial class ProductSalesListForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		int index = 0;
		public string Search { get; set; }

		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public ProductSalesListForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region InventoryOutputForm_Load
		private void InventoryOutputForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /InventoryOutputForm_Load

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			closeFadeTimer.Start();
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
			if (index == 0)
			{
				Search = null;
				return;
			}
			else if (index == 1)//----- جستجوی نام مشتری
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
			else if (index == 3)//----- جستجوی حامل کالا
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
			else if (index == 4)//----- جستجوی نام کالا
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
			else if (index == 5)//----- جستجوی تاریخ ثبت
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
			index = selectSearchComboBox.SelectedIndex;
			searchTextBox.Clear();
		}
		#endregion /SelectSearchComboBox_SelectedIndexChanged

		#region CloseFadeTimer_Tick
		private void CloseFadeTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.1;
			if (this.Opacity == 0.0)
			{
				closeFadeTimer.Stop();
				this.Dispose();
			}
		}
		#endregion /CloseFadeTimer_Tick


		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founction

		#region CarrierNameSearch
		/// <summary>
		/// جستجو بر اساس نام حامل کالا
		/// </summary>
		/// <param name="carrierName"></param>
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
		/// <summary>
		/// جستجو بر اساس نام مشتری
		/// </summary>
		/// <param name="clientName"></param>
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
		/// <summary>
		/// جستجو بر اساس تاریخ
		/// </summary>
		/// <param name="dateSearch"></param>
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

		#region Initialize
		/// <summary>
		/// تنظیمات ورود اولیه
		/// </summary>
		private void Initialize()
		{
			animateWindow.Interval = 200;
			animateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
			animateWindow.Start();
			LoadingInventoryOutput();
		}
		#endregion /Initialize

		#region LoadingInventoryOutput
		/// <summary>
		/// بار گزاری خروجی کالا
		/// </summary>
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
		/// <summary>
		/// جستجو بر اساس نام کالا
		/// </summary>
		/// <param name="productName"></param>
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
		/// <summary>
		/// جستجو بر اساس نام فروشنده
		/// </summary>
		/// <param name="sellerName"></param>
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

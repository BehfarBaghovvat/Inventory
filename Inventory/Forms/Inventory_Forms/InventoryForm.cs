using System.Linq;

namespace Inventory_Forms
{
	public partial class InventoryForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Calsses

		/// <summary>
		/// اطلاعات جدید
		/// </summary>
		public class InventoryItem
		{
			public int Product_Id
			{
				get; set;
			}

			public byte[] Product_Image
			{
				get; set;
			}

			public string Product_Name
			{
				get; set;
			}

			public string Product_Purchase_Price
			{
				get; set;
			}

			public int? Product_Quantity
			{
				get; set;
			}

			public string Product_Sale_Price
			{
				get; set;
			}

			public string Product_Unit
			{
				get; set;
			}
		}

		#endregion /Classes

		private int _previousRow = 1;


		private Models.InventoryHolding _inventoryHolding;
		public Models.InventoryHolding InventoryHolding
		{
			get
			{
				if (_inventoryHolding == null)
				{
					_inventoryHolding =
						new Models.InventoryHolding();
				}
				return _inventoryHolding;
			}
			set
			{
				_inventoryHolding = value;
			}
		}

		private InventoryItem _productNew;
		public InventoryItem ProductNew
		{
			get
			{
				if (_productNew == null)
				{
					_productNew =
						new InventoryItem();
				}
				return _productNew;
			}
			set
			{
				_productNew = value;
			}
		}

		private InventoryItem _productOld;
		public InventoryItem ProductOld
		{
			get
			{
				if (_productOld == null)
				{
					_productOld =
						new InventoryItem();
				}
				return _productOld;
			}
			set
			{
				_productOld = value;
			}
		}
		public decimal Capital_Fund
		{
			get; set;
		}



		#endregion /Properties


		//-----------------------------------------------------------------------------------------------     Constracture

		public InventoryForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

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

		#region InventoryHoldingDataGridView_CellClick
		private void InventoryHoldingDataGridView_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			try
			{
				ProductNew.Product_Id = (int)inventoryHoldingDataGridView.CurrentRow.Cells[0].Value;

				if (e.ColumnIndex == 8 && e.RowIndex >= 0)
				{
					ProductNew.Product_Image = (byte[])inventoryHoldingDataGridView.CurrentRow.Cells[8].Value;
					ProductOld.Product_Image = (byte[])inventoryHoldingDataGridView.CurrentRow.Cells[8].Value;

					System.Windows.Forms.OpenFileDialog openFileDialog =
						new System.Windows.Forms.OpenFileDialog
						{
							Filter = "JPG (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
							Title = "Load product picture ",
						};

					if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					{
						inventoryHoldingDataGridView.CurrentRow.Cells[8].Value =
							System.Drawing.Image.FromFile(openFileDialog.FileName);

						ProductNew.Product_Image = System.IO.File.ReadAllBytes(openFileDialog.FileName);
					}
					else
					{
						return;
					}
				}

				if (e.ColumnIndex == 1 && e.RowIndex >= 0)
				{
					ProductNew.Product_Name = inventoryHoldingDataGridView.CurrentRow.Cells[1].Value.ToString();
					ProductOld.Product_Name = inventoryHoldingDataGridView.CurrentRow.Cells[1].Value.ToString();
				}

				if (e.ColumnIndex == 2 && e.RowIndex >= 0)
				{
					ProductNew.Product_Quantity = (int)inventoryHoldingDataGridView.CurrentRow.Cells[2].Value;
					ProductOld.Product_Quantity = (int)inventoryHoldingDataGridView.CurrentRow.Cells[2].Value;
				}

				if (e.ColumnIndex == 3 && e.RowIndex >= 0)
				{
					ProductNew.Product_Unit = inventoryHoldingDataGridView.CurrentRow.Cells[3].Value.ToString();
					ProductOld.Product_Unit = inventoryHoldingDataGridView.CurrentRow.Cells[3].Value.ToString();
				}

				if (e.ColumnIndex == 4 && e.RowIndex >= 0)
				{
					ProductNew.Product_Purchase_Price = inventoryHoldingDataGridView.CurrentRow.Cells[4].Value.ToString();
					ProductOld.Product_Purchase_Price = inventoryHoldingDataGridView.CurrentRow.Cells[4].Value.ToString();
				}

				if (e.ColumnIndex == 5 && e.RowIndex >= 0)
				{
					ProductNew.Product_Sale_Price = inventoryHoldingDataGridView.CurrentRow.Cells[5].Value.ToString();
					ProductOld.Product_Sale_Price = inventoryHoldingDataGridView.CurrentRow.Cells[5].Value.ToString();
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /InventoryHoldingDataGridView_CellClick

		#region InventoryHoldingDataGridView_CellDoubleClick
		private void InventoryHoldingDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (((e.ColumnIndex >= 1 && e.ColumnIndex <= 5) && e.RowIndex >= 0) || (e.ColumnIndex == 8 && e.RowIndex >= 0))
			{
				inventoryHoldingDataGridView.CurrentCell.ReadOnly = false;
				return;
			}
			else
			{
				inventoryHoldingDataGridView.CurrentCell.ReadOnly = true;
				return;
			}
		}
		#endregion /InventoryHoldingDataGridView_CellDoubleClick

		#region InventoryHoldingDataGridView_CellValueChanged
		private void InventoryHoldingDataGridView_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			decimal _productPurchasePrice = 0, _productSalePrice = 0;

			if (Inventory.Program.UserAuthentication.Access_Level == Models.User.AccessLeve.مدیریت || Inventory.Program.UserAuthentication.Access_Level == Models.User.AccessLeve.معاونت)
			{
				if (e.ColumnIndex == 1 && e.RowIndex >= 0)
				{
					ProductNew.Product_Name = inventoryHoldingDataGridView.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
				}
				else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
				{
					ProductNew.Product_Quantity = (int)inventoryHoldingDataGridView.CurrentRow.Cells[e.ColumnIndex].Value;
				}
				else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
				{
					ProductNew.Product_Unit = inventoryHoldingDataGridView.CurrentRow.Cells[3].Value.ToString();
				}
				else if (e.ColumnIndex == 4 && e.RowIndex >= 0)
				{
					_productPurchasePrice =
						decimal.Parse(inventoryHoldingDataGridView.CurrentRow.Cells[e.ColumnIndex].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					inventoryHoldingDataGridView.CurrentRow.Cells[e.ColumnIndex].Value = $"{_productPurchasePrice:#,0} تومان";

					ProductNew.Product_Purchase_Price = $"{_productPurchasePrice:#,0} تومان";
				}
				else if (e.ColumnIndex == 5 && e.RowIndex >= 0)
				{
					_productSalePrice =
						decimal.Parse(inventoryHoldingDataGridView.CurrentRow.Cells[5].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					inventoryHoldingDataGridView.CurrentRow.Cells[5].Value = $"{_productSalePrice:#,0} تومان";
					ProductNew.Product_Sale_Price = $"{_productSalePrice:#,0} تومان";
				}
			}
			else
			{
				return;
			}
		}
		#endregion /InventoryHoldingDataGridView_CellValueChanged

		#region InventoryHoldingDataGridView_RowEnter
		private void InventoryHoldingDataGridView_RowEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (!e.RowIndex.Equals(_previousRow))
			{
				if (EditReview(ProductNew, ProductOld))
				{
					EditProduct(ProductNew, ProductOld);
				}
				else
				{
					return;
				}
				_previousRow = e.RowIndex;
			}
		}
		#endregion /InventoryHoldingDataGridView_RowEnter

		#region InventoryHoldingDataGridView_RowLeave
		private void InventoryHoldingDataGridView_RowLeave(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			_previousRow = e.RowIndex;
		}
		#endregion /InventoryHoldingDataGridView_RowLeave

		#region ShowImageToolStripMenuItem_Click
		private void ShowImageToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			byte[] product_Image = (byte[])inventoryHoldingDataGridView.CurrentRow.Cells[8].Value;

			System.IO.MemoryStream ms = new System.IO.MemoryStream(product_Image);

			//----برای بار گزاری تصویر
			ViewProducrImageForm viewProducrImageForm = new ViewProducrImageForm(System.Drawing.Image.FromStream(ms));

			viewProducrImageForm.ShowDialog();
		}
		#endregion /ShowImageToolStripMenuItem_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Methods

		#region EditProduct
		/// <summary>
		/// اعمال تغییرات در لیست محصولات
		/// </summary>
		private void EditProduct(InventoryItem _inventoryItemNew, InventoryItem _inventoryItemOld)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				#region -----------------------------------------------     Edit Inventory Holding
				Models.InventoryHolding inventoryHolding =
							dataBaseContext.InventoryHoldings
							.Where(current => current.Id == _inventoryItemNew.Product_Id)
							.FirstOrDefault();

				if (inventoryHolding != null) //یعنی اگر رکورد در دیتابیس موجود بود
				{
					if (!_inventoryItemNew.Product_Image.Equals(_inventoryItemOld.Product_Image)) // اگر تصویر محصول تغییر داشت، تصویر جدید جایگزین گردد.
					{
						inventoryHolding.Product_Image = _inventoryItemNew.Product_Image;
					}

					if (!_inventoryItemNew.Product_Name.Equals(_inventoryItemOld.Product_Name)) // اگر نام محصول تغییر داشت، نام جدید محصول جایگزین گردد.
					{
						inventoryHolding.Product_Name = _inventoryItemNew.Product_Name;
					}

					if (!_inventoryItemNew.Product_Purchase_Price.Equals(_inventoryItemOld.Product_Purchase_Price)) // اگر قیمت خرید محصول تغییر داشت، قیمت جایگزین گردد
					{
						inventoryHolding.Product_Purchase_Price = _inventoryItemNew.Product_Purchase_Price;
					}

					if (!_inventoryItemNew.Product_Quantity.Equals(_inventoryItemOld.Product_Quantity)) // اگر تعداد محصول تغییر داشت، تعداد جدید جایگزین گردد
					{
						inventoryHolding.Product_Quantity = _inventoryItemNew.Product_Quantity;
					}

					if (!_inventoryItemNew.Product_Sale_Price.Equals(_inventoryItemOld.Product_Sale_Price)) // اگر قیمت فروش کالا تغییر داشت، قمیت جدید جایگزین گردد.
					{
						inventoryHolding.Product_Sale_Price = _inventoryItemNew.Product_Sale_Price;
					}

					if (!_inventoryItemNew.Product_Unit.Equals(_inventoryItemOld.Product_Unit)) // اگر واحد کالا تغییر داشت، واحد جدید جایگزین گردد.
					{
						inventoryHolding.Product_Unit = _inventoryItemNew.Product_Unit;
					}
				}
				dataBaseContext.SaveChanges();
				#endregion -----------------------------------------------     Edit Inventory Holding

				#region -----------------------------------------------     Edit Product Recive

				Models.ProductReceived productReceived =
					dataBaseContext.ProductReceiveds
					.Where(current => current.Id == _inventoryItemNew.Product_Id)
					.FirstOrDefault();

				if (productReceived != null)
				{
					if (!_inventoryItemNew.Product_Image.Equals(ProductOld.Product_Image)) // اگر تصویر محصول تغییر داشت، تصویر جدید جایگزین گردد.
					{
						productReceived.Product_Image = _inventoryItemNew.Product_Image;
					}

					if (!_inventoryItemNew.Product_Name.Equals(ProductOld.Product_Name)) // اگر نام محصول تغییر داشت، نام جدید محصول جایگزین گردد.
					{
						productReceived.Product_Name = _inventoryItemNew.Product_Name;
					}

					if (!_inventoryItemNew.Product_Purchase_Price.Equals(ProductOld.Product_Purchase_Price)) // اگر قیمت خرید محصول تغییر داشت، قیمت جایگزین گردد
					{
						productReceived.Product_Purchase_Price = _inventoryItemNew.Product_Purchase_Price;
					}

					if (!_inventoryItemNew.Product_Quantity.Equals(ProductOld.Product_Quantity)) // اگر تعداد محصول تغییر داشت، تعداد جدید جایگزین گردد
					{
						productReceived.Product_Quantity = _inventoryItemNew.Product_Quantity;
					}

					if (!_inventoryItemNew.Product_Sale_Price.Equals(ProductOld.Product_Sale_Price)) // اگر قیمت فروش کالا تغییر داشت، قمیت جدید جایگزین گردد.
					{
						productReceived.Product_Sale_Price = _inventoryItemNew.Product_Sale_Price;
					}

					if (!_inventoryItemNew.Product_Unit.Equals(ProductOld.Product_Unit)) // اگر واحد کالا تغییر داشت، واحد جدید جایگزین گردد.
					{
						productReceived.Product_Unit = _inventoryItemNew.Product_Unit;
					}

					productReceived.Number_Edit++;
					productReceived.Last_Edited_Date = $"{Infrastructure.Utility.PersianCalendar(dateTime: System.DateTime.Now)}";
					productReceived.Last_Edited_Time = $"{Infrastructure.Utility.ShowTime()}";
				}
				dataBaseContext.SaveChanges();
				#endregion -----------------------------------------------     Edit Product Recive

				Inventory.Program.MainForm.GetCapitalFund();
				Inventory.Program.MainForm.GetNon_CashCapital();
				Inventory.Program.MainForm.GetTotalCapital();


				Infrastructure.Utility.WindowsNotification(message: $"رکورد شماره {ProductNew.Product_Id} به روز رسانی شد.", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

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
		#endregion /EditProduct

		#region EditReview
		/// <summary>
		/// بررسی رکوردها جهت ویرایش اطلاعات
		/// </summary>
		/// <param name="_inventoryItemNew"></param>
		/// <param name="_inventoryItemOld"></param>
		/// <returns></returns>
		private bool EditReview(InventoryItem _inventoryItemNew, InventoryItem _inventoryItemOld)
		{
			try
			{
				if ((_inventoryItemNew.Product_Image == null) ||
					(_inventoryItemNew.Product_Name == null) ||
					(_inventoryItemNew.Product_Purchase_Price == null) ||
					(_inventoryItemNew.Product_Quantity == null) ||
					(_inventoryItemNew.Product_Sale_Price == null) ||
					(_inventoryItemNew.Product_Unit == null))
				{
					return false;
				}
				else
				{
					if ((_inventoryItemNew.Product_Image.Equals(_inventoryItemOld.Product_Image)) &&
						(_inventoryItemNew.Product_Name.Equals(_inventoryItemOld.Product_Name)) &&
						(_inventoryItemNew.Product_Purchase_Price.Equals(_inventoryItemOld.Product_Purchase_Price)) &&
						(_inventoryItemNew.Product_Quantity.Equals(_inventoryItemOld.Product_Quantity)) &&
						(_inventoryItemNew.Product_Sale_Price.Equals(_inventoryItemOld.Product_Sale_Price)) &&
						(_inventoryItemNew.Product_Unit.Equals(_inventoryItemOld.Product_Unit)))
					{
						return false;
					}
					else
					{
						if (!_inventoryItemNew.Product_Image.Equals(_inventoryItemOld.Product_Image))
						{
							return true;
						}
						else if (!_inventoryItemNew.Product_Name.Equals(_inventoryItemOld.Product_Name))
						{
							return true;
						}
						else if (!_inventoryItemNew.Product_Purchase_Price.Equals(_inventoryItemOld.Product_Purchase_Price))
						{
							return true;
						}
						else if (!_inventoryItemNew.Product_Quantity.Equals(_inventoryItemOld.Product_Quantity))
						{
							return true;
						}
						else if (!_inventoryItemNew.Product_Sale_Price.Equals(_inventoryItemOld.Product_Sale_Price))
						{
							return true;
						}
						else if (!_inventoryItemNew.Product_Unit.Equals(_inventoryItemOld.Product_Unit))
						{
							return true;
						}
						else
						{
							return false;
						}
					}
				}
			}
			catch (System.Exception)
			{
				return false;
			}
		}
		#endregion /EditReview

		#region Initialize
		/// <summary>
		/// تنظیمات ورود اولیه
		/// </summary>
		public void Initialize()
		{
			productNameSearchTextBox.Focus();
			productNameSearchTextBox.Clear();
			Capital_Fund = Inventory.Program.MainForm.GetCapitalFund();
			LoadedProduction();

			ProductNew.Product_Name = inventoryHoldingDataGridView.CurrentRow.Cells[1].Value.ToString();
			ProductOld.Product_Name = inventoryHoldingDataGridView.CurrentRow.Cells[1].Value.ToString();

			ProductNew.Product_Quantity = (int)inventoryHoldingDataGridView.CurrentRow.Cells[2].Value;
			ProductOld.Product_Quantity = (int)inventoryHoldingDataGridView.CurrentRow.Cells[2].Value;

			ProductNew.Product_Unit = inventoryHoldingDataGridView.CurrentRow.Cells[3].Value.ToString();
			ProductOld.Product_Unit = inventoryHoldingDataGridView.CurrentRow.Cells[3].Value.ToString();

			ProductNew.Product_Purchase_Price = inventoryHoldingDataGridView.CurrentRow.Cells[4].Value.ToString();
			ProductOld.Product_Purchase_Price = inventoryHoldingDataGridView.CurrentRow.Cells[4].Value.ToString();

			ProductNew.Product_Sale_Price = inventoryHoldingDataGridView.CurrentRow.Cells[5].Value.ToString();
			ProductOld.Product_Sale_Price = inventoryHoldingDataGridView.CurrentRow.Cells[5].Value.ToString();

			ProductNew.Product_Image = (byte[])inventoryHoldingDataGridView.CurrentRow.Cells[8].Value;
			ProductOld.Product_Image = (byte[])inventoryHoldingDataGridView.CurrentRow.Cells[8].Value;
		}
		#endregion /Initialize

		#region LoadedProduction
		/// <summary>
		/// بارگزاری کالاها
		/// </summary>
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
		/// <summary>
		/// جستجوی کالا بر اساس نام
		/// </summary>
		/// <param name="productNameSearch"></param>
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

		#endregion /Methods


	}
}

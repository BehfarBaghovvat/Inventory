using System;
using System.Linq;

namespace Inventory_Forms
{
	public partial class ProductBuyForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Layer
		/// <summary>
		/// کلاس صورت حساب
		/// </summary>
		public class BillBuyReportItems
		{
			//نکته: به یاد داشته باشید که نام پراپرتیز ها باید هم نام با عناصر داخل گزارش باشد
			// در غیر این صورت داده ها انتقال پیدا نمیکند.
			public string Product_Name
			{
				get; set;
			}
			public string Product_Price
			{
				get; set;
			}
			public int Product_Quantity
			{
				get; set;
			}
			public string Product_Unit
			{
				get; set;
			}
			public string Total_Price
			{
				get; set;
			}
		}

		/// <summary>
		/// کلاس مربوط به تعداد کالا
		/// که در صورت افزایش اختلاف افزایش
		/// موجودی توسط ایتم های این کلاس
		/// انجام میگردد.
		/// </summary>
		public class UpdateProductQuantity
		{
			public int Final_Quantity
			{
				get; set;
			}
			public int First_Quantity
			{
				get; set;
			}
			public int Second_Quantity
			{
				get; set;
			}
		}

		private BillBuyReportForm _billBuyReportForm;
		public BillBuyReportForm BillBuyReportForm
		{
			get
			{
				if (_billBuyReportForm == null || _billBuyReportForm.IsDisposed == true)
				{
					_billBuyReportForm =
						new BillBuyReportForm();
				}
				return _billBuyReportForm;
			}
			set
			{
				_billBuyReportForm = value;
			}
		}

		#endregion /Layer

		public System.Collections.Generic.List<BillBuyReportItems> listBillBuyReportItems =
			new System.Collections.Generic.List<BillBuyReportItems>();

		public int? Price
		{
			get; set;
		}
		public int TotalSumPrice
		{
			get; set;
		}
		public decimal TotalPurchaseAmount
		{
			get; set;
		}
		public decimal CapitalInventory
		{
			get; set;
		}

		decimal _sumAmount, _firstAmount, _secondAmount = 0;

		private Models.EventLog _eventLog;
		public Models.EventLog EventLog
		{
			get
			{
				if (_eventLog == null)
				{
					_eventLog =
						new Models.EventLog();
				}
				return _eventLog;
			}
		}

		private Models.InventoryHolding _inventoryHolding_New;
		public Models.InventoryHolding InventoryHolding_New
		{
			get
			{
				if (_inventoryHolding_New == null)
				{
					_inventoryHolding_New =
						new Models.InventoryHolding();
				}
				return _inventoryHolding_New;
			}
			set
			{
				_inventoryHolding_New = value;
			}
		}

		public int NumberPurchases
		{
			get; set;
		}

		private Models.ProductReceived _productReceived_New;
		public Models.ProductReceived ProductReceived_New
		{
			get
			{
				if (_productReceived_New == null)
				{
					_productReceived_New =
						new Models.ProductReceived();
				}
				return _productReceived_New;
			}
			set
			{
				_productReceived_New = value;
			}
		}

		private Models.ProductReceived _productReceived_Selected;
		public Models.ProductReceived ProductReceived_Selected
		{
			get
			{
				if (_productReceived_Selected == null)
				{
					_productReceived_Selected =
						new Models.ProductReceived();
				}
				return _productReceived_Selected;
			}
			set
			{
				_productReceived_Selected = value;
			}
		}

		private UpdateProductQuantity _updateProductQuantity = null;

		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public ProductBuyForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region ProductBuyForm_Load
		private void ProductBuyForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /ProductBuyForm_Load

		#region ProductNameTextBox_Enter
		private void ProductNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /ProductNameTextBox_Enter

		#region ProductNameTextBox_KeyPress
		private void ProductNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /ProductNameTextBox_KeyPress

		#region ProductNameTextBox_Leave
		private void ProductNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (SearchProduct(productNameTextBox.Text))
			{
				return;
			}
			else
			{
				productNameTextBox.Focus();
			}
		}
		#endregion /ProductNameTextBox_Leave

		#region ProductNameTextBox_TextChanged
		private void ProductNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(productNameTextBox.Text))
			{
				checkProductNamePictureBox.Image = Inventory.Properties.Resources.Tik_False;
				checkProductNamePictureBox.Visible = false;
				ProductReceived_New.Product_Name = null;
				InventoryHolding_New.Product_Name = null;
				return;
			}
			else
			{
				checkProductNamePictureBox.Visible = true;
				if (string.Compare(saveBottom.Text, "ثبت کالا") == 0)
				{
					if (SearchProduct(productNameTextBox.Text))
					{
						checkProductNamePictureBox.Image = Inventory.Properties.Resources.Tik_True;
						ProductReceived_New.Product_Name = productNameTextBox.Text;
						InventoryHolding_New.Product_Name = productNameTextBox.Text;
					}
					else
					{
						checkProductNamePictureBox.Image = Inventory.Properties.Resources.Tik_False;
						ProductReceived_New.Product_Name = null;
						InventoryHolding_New.Product_Name = null;
					}
				}
				else if (string.Compare(saveBottom.Text, "ویرایش کالا") == 0)
				{
					checkProductNamePictureBox.Image = Inventory.Properties.Resources.Tik_True;
					return;
				}
			}
		}
		#endregion /ProductNameTextBox_TextChanged

		#region SenderNameTextBox_Enter
		private void SenderNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /SenderNameTextBox_Enter

		#region SenderNameTextBox_KeyPress
		private void SenderNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /SenderNameTextBox_KeyPress

		#region SenderNameTextBox_TextChange
		private void SenderNameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(senderNameTextBox.Text))
			{
				ProductReceived_New.Sender_Name = null;
				return;
			}
			else
			{
				ProductReceived_New.Sender_Name = senderNameTextBox.Text;
			}
		}
		#endregion SenderNameTextBox_TextChange

		#region CarrierNameTextBox_Enter
		private void CarrierNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /CarrierNameTextBox_Enter

		#region CarrierNameTextBox_KeyPress
		private void CarrierNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /CarrierNameTextBox_KeyPress

		#region CarrierNameTextBox_TextChange
		private void CarrierNameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(carrierNameTextBox.Text))
			{
				ProductReceived_New.Carrier_Name = null;
				return;
			}
			else
			{
				ProductReceived_New.Carrier_Name = carrierNameTextBox.Text;
			}
		}
		#endregion /CarrierNameTextBox_TextChange		

		#region ProductPriceTextBox_Enter
		private void ProductPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (string.IsNullOrWhiteSpace(productPriceTextBox.Text))
			{
				Price = null;
				productPriceTextBox.Text = "0 تومان";
				productPriceTextBox.Select(0, 1);
				productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
			else if (productPriceTextBox.Text.Contains("تومان"))
			{
				return;
			}
		}
		#endregion /ProductPriceTextBox_Enter

		#region ProductPriceTextBox_KeyPress
		private void ProductPriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /ProductPriceTextBox_KeyPress

		#region ProductPriceTextBox_Leave
		private void ProductPriceTextBox_Leave(object sender, System.EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(productPriceTextBox.Text))
				{
					productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
					ProductReceived_New.Product_Purchase_Price = null;
					InventoryHolding_New.Product_Purchase_Price = null;
					return;
				}
				else if (string.Compare(productPriceTextBox.Text, "0 تومان") == 0)
				{
					productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
					productPriceTextBox.Clear();
					Price = null;
					ProductReceived_New.Product_Purchase_Price = null;
					InventoryHolding_New.Product_Purchase_Price = null;
					return;

				}
				else if (string.Compare(productPriceTextBox.Text, " تومان") == 0 || string.Compare(productPriceTextBox.Text, "تومان") == 0 || string.Compare(productPriceTextBox.Text, "توما") == 0 || string.Compare(productPriceTextBox.Text, "توم") == 0 || string.Compare(productPriceTextBox.Text, "تو") == 0 || string.Compare(productPriceTextBox.Text, "ت") == 0)
				{
					productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
					productPriceTextBox.Clear();
					Price = null;
					ProductReceived_New.Product_Purchase_Price = null;
					InventoryHolding_New.Product_Purchase_Price = null;
					return;
				}
				else
				{
					productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
					ProductReceived_New.Product_Purchase_Price = productPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
					Price = int.Parse(ProductReceived_New.Product_Purchase_Price.Replace(",", string.Empty).Trim());
					productPriceTextBox.Text = $"{Price:#,0} تومان";
					ProductReceived_New.Product_Purchase_Price = productPriceTextBox.Text;
					InventoryHolding_New.Product_Purchase_Price = productPriceTextBox.Text;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /ProductPriceTextBox_Leave

		#region ProductPriceTextBox_TextChange
		private void ProductPriceTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(productPriceTextBox.Text))
			{
				productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			}
			else
			{
				productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /ProductPriceTextBox_TextChange

		#region SalesPriceTextBox_Enter
		private void SalesPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (string.IsNullOrWhiteSpace(salesPriceTextBox.Text))
			{
				Price = null;
				salesPriceTextBox.Text = "0 تومان";
				salesPriceTextBox.Select(0, 1);
				salesPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
			else if (salesPriceTextBox.Text.Contains("تومان"))
			{
				return;
			}
		}
		#endregion /SalesPriceTextBox_Enter

		#region SalesPriceTextBox_KeyPress
		private void SalesPriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /SalesPriceTextBox_KeyPress

		#region SalesPriceTextBox_Leave
		private void SalesPriceTextBox_Leave(object sender, System.EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(salesPriceTextBox.Text))
				{
					salesPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
					ProductReceived_New.Product_Sale_Price = null;
					InventoryHolding_New.Product_Sale_Price = null;
					Price = null;
					return;
				}
				else if (string.Compare(salesPriceTextBox.Text, "0 تومان") == 0)
				{
					salesPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
					salesPriceTextBox.Clear();
					Price = null;
					ProductReceived_New.Product_Sale_Price = null;
					InventoryHolding_New.Product_Sale_Price = null;
					return;

				}
				else if (salesPriceTextBox.Text.Length < 7)
				{
					salesPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
					salesPriceTextBox.Clear();
					Price = null;
					ProductReceived_New.Product_Sale_Price = null;
					InventoryHolding_New.Product_Sale_Price = null;
					return;
				}
				else
				{
					salesPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
					ProductReceived_New.Product_Sale_Price = salesPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
					Price = int.Parse(ProductReceived_New.Product_Sale_Price.Replace(",", string.Empty).Trim());
					salesPriceTextBox.Text = $"{Price:#,0} تومان";
					ProductReceived_New.Product_Sale_Price = salesPriceTextBox.Text;
					InventoryHolding_New.Product_Sale_Price = salesPriceTextBox.Text;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /SalesPriceTextBox_Leave

		#region SalesPriceTextBox_TextChange
		private void SalesPriceTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(productPriceTextBox.Text))
			{
				salesPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			}
			else
			{
				salesPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /SalesPriceTextBox_TextChange

		#region ProductQuantityTextBox_Enter
		private void ProductQuantityTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (string.IsNullOrWhiteSpace(productQuantityTextBox.Text))
			{
				productQuantityTextBox.Select(0, productQuantityTextBox.Text.Length);
				productQuantityTextBox.Text = "0";
			}
			else
			{
				productQuantityTextBox.Select(0, productQuantityTextBox.Text.Length);
				return;
			}
		}
		#endregion /ProductQuantityTextBox_Enter

		#region ProductQuantityTextBox_KeyPress
		private void ProductQuantityTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /ProductQuantityTextBox_KeyPress

		#region ProductQuantityTextBox_Leave
		private void ProductQuantityTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(productQuantityTextBox.Text) || string.Compare(productQuantityTextBox.Text, "0") == 0)
			{
				productQuantityTextBox.Clear();
				ProductReceived_New.Product_Quantity = null;
			}
			else
			{
				return;
			}
		}
		#endregion /ProductQuantityTextBox_Leave

		#region ProductQuantityTextBox_TextChange
		private void ProductQuantityTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(productQuantityTextBox.Text))
			{
				ProductReceived_New.Product_Quantity = 0;
				return;
			}
			else
			{
				ProductReceived_New.Product_Quantity = int.Parse(productQuantityTextBox.Text);
				InventoryHolding_New.Product_Quantity = int.Parse(productQuantityTextBox.Text);

				_updateProductQuantity.Second_Quantity = int.Parse(productQuantityTextBox.Text);
			}
		}
		#endregion /ProductQuantityTextBox_TextChange

		#region ProductUnitComboBox_SelectedIndexChanged
		private void ProductUnitComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (productUnitComboBox.SelectedIndex == 0)
			{
				return;
			}
			else
			{
				ProductReceived_New.Product_Unit = productUnitComboBox.SelectedItem.ToString();
				InventoryHolding_New.Product_Unit = productUnitComboBox.SelectedItem.ToString();
			}
		}
		#endregion /ProductUnitComboBox_SelectedIndexChanged	

		#region SelectImageLinkLabel_LinkClicked
		private void SelectImageLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPG (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load user picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				productImagePictureBox.Image =
				System.Drawing.Image.FromFile(openFileDialog.FileName);
				ProductReceived_New.Product_Image = System.IO.File.ReadAllBytes(openFileDialog.FileName);
				InventoryHolding_New.Product_Image = System.IO.File.ReadAllBytes(openFileDialog.FileName);
				deleteImageButton.Visible = true;
			}
			else
			{
				ProductReceived_New.Product_Image = null;
				InventoryHolding_New.Product_Image = null;
				deleteImageButton.Visible = false;
			}
		}
		#endregion /SelectImageLinkLabel_LinkClicked

		#region DeleteImageButton_Click
		private void DeleteImageButton_Click(object sender, System.EventArgs e)
		{
			ProductReceived_New.Product_Image = null;
			productImagePictureBox.Image = null;
			deleteImageButton.Visible = false;
		}
		#endregion /DeleteImageButton_Click

		#region BillButton_Click
		private void BillButton_Click(object sender, System.EventArgs e)
		{
			if (NumberPurchases == 0 && listBillBuyReportItems.Count == 0)
			{
				Mbb.Windows.Forms.MessageBox.Show
					(text: Inventory.Properties.Resources.Purchase_Error,
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
			}
			else
			{
				BillBuyReportForm.senderNameTextBox.Text = senderNameTextBox.Text;
				BillBuyReportForm.carrierNameTextBox.Text = carrierNameTextBox.Text;
				BillBuyReportForm.MyProductBuyForm = this;
				BillBuyReportForm.SetBillInDataGridView(listBillBuyReportItems);
				BillBuyReportForm.ShowDialog();
			}
		}
		#endregion /BillButton_Click

		#region SearchTextBox_Enter
		private void SearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /SearchTextBox_Enter

		#region SearchTextBox_KeyPress
		private void SearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /SearchTextBox_KeyPress

		#region SearchTextBox_TextChange
		private void SearchTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchTextBox.Text) || filterSearchComboBox.SelectedIndex == 0)
			{
				productReceivedBindingSource.Filter = null;
			}
			else
			{
				productReceivedBindingSource.Filter = string.Format("{0} = '{1}'", filterSearchComboBox.Text, searchTextBox.Text);
			}
		}
		#endregion /SearchTextBox_TextChange

		#region SaveBottom_Click
		private void SaveBottom_Click(object sender, System.EventArgs e)
		{
			SetProduct(ProductReceived_New, InventoryHolding_New);
		}
		#endregion /SaveBottom_Click

		#region ResetBottom_Click
		private void ResetBottom_Click(object sender, System.EventArgs e)
		{
			AllClear();
		}
		#endregion /ResetBottom_Click

		#region EditProductToolStripMenuItem_Click
		private void EditProductToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			ClearForEdit();

			saveBottom.Text = "ویرایش کالا";

			ProductReceived_New.Product_Name = productRecivedDataGridView.CurrentRow.Cells[1].Value.ToString();
			InventoryHolding_New.Product_Name = productRecivedDataGridView.CurrentRow.Cells[1].Value.ToString();
			ProductReceived_Selected.Product_Name = productRecivedDataGridView.CurrentRow.Cells[1].Value.ToString();
			productNameTextBox.Text = productRecivedDataGridView.CurrentRow.Cells[1].Value.ToString();

			recipientNameTextBox.Text = productRecivedDataGridView.CurrentRow.Cells[2].Value.ToString();

			ProductReceived_Selected.Sender_Name = productRecivedDataGridView.CurrentRow.Cells[3].Value.ToString();
			ProductReceived_New.Sender_Name = productRecivedDataGridView.CurrentRow.Cells[3].Value.ToString();
			senderNameTextBox.Text = productRecivedDataGridView.CurrentRow.Cells[3].Value.ToString();

			ProductReceived_Selected.Carrier_Name = productRecivedDataGridView.CurrentRow.Cells[4].Value.ToString();
			ProductReceived_New.Carrier_Name = productRecivedDataGridView.CurrentRow.Cells[4].Value.ToString();
			carrierNameTextBox.Text = productRecivedDataGridView.CurrentRow.Cells[4].Value.ToString();

			ProductReceived_Selected.Product_Purchase_Price = productRecivedDataGridView.CurrentRow.Cells[7].Value.ToString();
			ProductReceived_New.Product_Purchase_Price = productRecivedDataGridView.CurrentRow.Cells[7].Value.ToString();
			InventoryHolding_New.Product_Purchase_Price = productRecivedDataGridView.CurrentRow.Cells[7].Value.ToString();
			productPriceTextBox.Text = productRecivedDataGridView.CurrentRow.Cells[7].Value.ToString();

			ProductReceived_Selected.Product_Sale_Price = productRecivedDataGridView.CurrentRow.Cells[8].Value.ToString();
			ProductReceived_New.Product_Sale_Price = productRecivedDataGridView.CurrentRow.Cells[8].Value.ToString();
			InventoryHolding_New.Product_Sale_Price = productRecivedDataGridView.CurrentRow.Cells[8].Value.ToString();
			salesPriceTextBox.Text = productRecivedDataGridView.CurrentRow.Cells[8].Value.ToString();

			ProductReceived_Selected.Product_Quantity = int.Parse(productRecivedDataGridView.CurrentRow.Cells[5].Value.ToString());
			ProductReceived_New.Product_Quantity = int.Parse(productRecivedDataGridView.CurrentRow.Cells[5].Value.ToString());
			InventoryHolding_New.Product_Quantity = int.Parse(productRecivedDataGridView.CurrentRow.Cells[5].Value.ToString());
			_updateProductQuantity.Second_Quantity = 0;
			productQuantityTextBox.Text = productRecivedDataGridView.CurrentRow.Cells[5].Value.ToString();

			ProductReceived_Selected.Product_Unit = productRecivedDataGridView.CurrentRow.Cells[6].Value.ToString();
			ProductReceived_New.Product_Unit = productRecivedDataGridView.CurrentRow.Cells[6].Value.ToString();
			InventoryHolding_New.Product_Unit = productRecivedDataGridView.CurrentRow.Cells[6].Value.ToString();
			productUnitComboBox.SelectedIndex = productUnitComboBox.FindString(productRecivedDataGridView.CurrentRow.Cells[6].Value.ToString());

			if (productRecivedDataGridView.CurrentRow.Cells[9].Value != null)
			{
				ProductReceived_Selected.Product_Image = (byte[])productRecivedDataGridView.CurrentRow.Cells[9].Value;
				ProductReceived_New.Product_Image = (byte[])productRecivedDataGridView.CurrentRow.Cells[9].Value;
				InventoryHolding_New.Product_Image = (byte[])productRecivedDataGridView.CurrentRow.Cells[9].Value;

				using (System.IO.MemoryStream ms = new System.IO.MemoryStream(ProductReceived_Selected.Product_Image))
				{
					productImagePictureBox.Image = System.Drawing.Image.FromStream(ms);
				}
			}
			else
			{
				return;
			}
		}
		#endregion /EditProductToolStripMenuItem_Click

		#region DeleteRecordToolStripMenuItem_Click
		private void DeleteRecordToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (string.Compare(saveBottom.Text, "ویرایش کالا") == 0)
				{
					saveBottom.Text = "ثبت کالا";
				}

				if (productRecivedDataGridView.Rows.Count == 0)
				{
					Mbb.Windows.Forms.MessageBox.Show
						(text: $"کالایی برای حذف موجود نمی باشد.",
						caption: "اطلاع",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}
				else
				{
					System.Windows.Forms.DialogResult dialogResult =
						Mbb.Windows.Forms.MessageBox.Show
						(text: $"{productRecivedDataGridView.CurrentRow.Cells[1].Value} حذف گردد؟",
						caption: "حذف کالا",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
						button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

					if (dialogResult == System.Windows.Forms.DialogResult.Yes)
					{
						decimal _refundAmount = 0;
						decimal _cashCapital = Inventory.Program.MainForm.GetCapitalFund();
						decimal _nonCashCapital = Inventory.Program.MainForm.GetNon_CashCapital();

						string productName = productRecivedDataGridView.CurrentRow.Cells[1].Value.ToString();

						using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
						{
							//=========================================================.این بخش برای حذف کالا از دریافتی های انباردار می باشد========================================================

							Models.ProductReceived productReceived =
								dataBaseContext.ProductReceiveds
								.Where(current => string.Compare(current.Product_Name, productName) == 0)
								.FirstOrDefault();

							if (productReceived != null)
							{
								_refundAmount = 
									decimal.Parse(productRecivedDataGridView.CurrentRow.Cells[7].Value.ToString().Replace("تومان", string.Empty).Replace(",", string.Empty).Trim()) * int.Parse(productRecivedDataGridView.CurrentRow.Cells[5].Value.ToString());

								_cashCapital += _refundAmount;

								

								var entry = dataBaseContext.Entry(productReceived);

								if (entry.State == System.Data.Entity.EntityState.Detached)
								{
									dataBaseContext.ProductReceiveds.Attach(productReceived);
								}
							}
							dataBaseContext.ProductReceiveds.Remove(productReceived);
							dataBaseContext.SaveChanges();

							

							//=========================================================.این بخش برای حذف کالا از انبار اصلی می باشد========================================================

							Models.InventoryHolding inventoryHolding =
								dataBaseContext.InventoryHoldings
								.Where(current => string.Compare(current.Product_Name, productName) == 0)
								.FirstOrDefault();

							if (inventoryHolding != null)
							{
								var entry = dataBaseContext.Entry(inventoryHolding);

								if (entry.State == System.Data.Entity.EntityState.Detached)
								{
									dataBaseContext.InventoryHoldings.Attach(inventoryHolding);
								}

								dataBaseContext.InventoryHoldings.Remove(inventoryHolding);
								dataBaseContext.SaveChanges();
							}
							productName = null;

							RefrashData();
						}

						CapitalUpdate(_cashCapital);

						Infrastructure.Utility.WindowsNotification
							(message: "کالای مورد نظر حذف گردید!",
							caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

						#region -----------------------------------------     Save Event Log     -----------------------------------------
						if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
						{
							EventLog.Username = Inventory.Program.UserAuthentication.Username;
							EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
							EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
							EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
							EventLog.Description = $"{productName} حذف گردید.";

							Infrastructure.Utility.EventLog(EventLog);
						}
						#endregion /-----------------------------------------     Save Event Log     -----------------------------------------
					}
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /DeleteRecordToolStripMenuItem_Click

		#region ViewProductToolStripMenuItem_Click
		private void ViewProductToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (productRecivedDataGridView.CurrentRow.Cells[9].Value == null)
			{
				ViewProducrImageForm viewProducrImageForm = new ViewProducrImageForm(null);
				viewProducrImageForm.ShowDialog();
			}
			else
			{
				byte[] product_Image = (byte[])productRecivedDataGridView.CurrentRow.Cells[9].Value;
				System.IO.MemoryStream ms = new System.IO.MemoryStream(product_Image);
				//----برای بار گزاری تصویر
				ViewProducrImageForm viewProducrImageForm = new ViewProducrImageForm(System.Drawing.Image.FromStream(ms));
				viewProducrImageForm.ShowDialog();
			}
		}
		#endregion /ViewProductToolStripMenuItem_Click

		#region ContextMenuStrip_Opening
		private void ContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (productRecivedDataGridView.Rows.Count == 0)
			{
				contextMenuStrip.Enabled = false;
			}
			else
			{
				contextMenuStrip.Enabled = true;
			}
		}
		#endregion /ContextMenuStrip_Opening



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Function

		#region AllClear
		/// <summary>
		/// پاک کردن تمام کنترل ها
		/// و برگشت به حالت اولیه
		/// </summary>
		private void AllClear()
		{
			NumberPurchases = 0;

			productNameTextBox.Clear();
			checkProductNamePictureBox.Image = Inventory.Properties.Resources.Tik_True;
			checkProductNamePictureBox.Visible = false;
			productPriceTextBox.Clear();
			salesPriceTextBox.Clear();
			productQuantityTextBox.Clear();
			productUnitComboBox.SelectedIndex = 0;
			senderNameTextBox.Clear();
			carrierNameTextBox.Clear();
			productImagePictureBox.Image = null;
			saveBottom.Text = "ثبت کالا";
			deleteImageButton.Visible = false;
			ProductReceived_New = null;
			InventoryHolding_New = null;
		}
		#endregion /AllClear

		#region CapitalUpdate
		/// <summary>
		/// به روز رسانی صندوق سرمایه
		/// </summary>
		/// <param name="cashCapital"></param>
		/// <param name="nonCashCapital"></param>
		/// <param name="totalCapital"></param>
		private void CapitalUpdate(decimal cashCapital)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.FirstOrDefault();

				capitalFund.Capital_Fund = $"{cashCapital:#,0} تومان";

				dataBaseContext.SaveChanges();

				Inventory.Program.MainForm.GetNon_CashCapital();

				Inventory.Program.MainForm.GetTotalCapital();
			}
			catch (Exception ex)
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
		#endregion /CapitalUpdate

		#region CheckFundBalance
		/// <summary>
		/// این تابع به کمک میکند تا میزان خرید را
		/// با میزان موجودی صندوق بررسی کنیم.
		/// در صورتی که مقدار True برگردانده شود
		/// یعنی مجاز به خرید کالا هستیم
		/// در غیر این صورت امکان خرید بیش از حد امکان ندارد.
		/// </summary>
		/// <param name="_amount"></param>
		/// <returns></returns>
		private bool CheckFundBalance(decimal _amount)
		{
			if (CapitalInventory <= _amount)
			{
				Mbb.Windows.Forms.MessageBox.Show(
					text: "مبلغ خرید شما از موجودی بیشتر است",
					caption: "خطای موجودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				return false;
			}
			else
			{
				return true;
			}
		}
		#endregion /CheckFundBalance

		#region ClearForEdit
		/// <summary>
		/// پاک کردن کنترلها
		/// برای انجام ویرایش
		/// </summary>
		private void ClearForEdit()
		{
			productNameTextBox.Clear();
			productPriceTextBox.Clear();
			productQuantityTextBox.Clear();
			productUnitComboBox.SelectedIndex = 0;
			senderNameTextBox.Clear();
			carrierNameTextBox.Clear();
			productImagePictureBox.Image = null;

			ProductReceived_New = null;
			InventoryHolding_New = null;
		}
		#endregion /ClearForEdit

		#region DeleteToGetNew
		/// <summary>
		/// حذف داده های درج شده جهت
		/// دریافت اطلاعات جدید
		/// </summary>
		private void DeleteToGetNew()
		{
			productNameTextBox.Clear();
			ProductReceived_New.Product_Name = null;
			InventoryHolding_New.Product_Name = null;

			productPriceTextBox.Clear();
			ProductReceived_New.Product_Purchase_Price = null;
			InventoryHolding_New.Product_Purchase_Price = null;

			salesPriceTextBox.Clear();
			ProductReceived_New.Product_Sale_Price = null;
			InventoryHolding_New.Product_Sale_Price = null;

			productQuantityTextBox.Clear();
			ProductReceived_New.Product_Quantity = null;
			InventoryHolding_New.Product_Quantity = null;

			productUnitComboBox.SelectedIndex = 0;
			ProductReceived_New.Product_Unit = null;
			InventoryHolding_New.Product_Unit = null;

			productImagePictureBox.Image = null;
			ProductReceived_New.Product_Image = null;
			InventoryHolding_New.Product_Image = null;

			deleteImageButton.Visible = false;
		}
		#endregion /DeleteToGetNew

		#region GetCapitalInventory
		/// <summary>
		/// موجودی صندوق را در متغییر decimal ذخیره کرده و بر می گرداند.
		/// </summary>
		/// <returns>_capitalInventory</returns>
		private decimal GetCapitalInventory()
		{
			decimal capital_Fund;

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
					capital_Fund = 0;

					Mbb.Windows.Forms.MessageBox.Show(
						text: "موجودی صندوق 0 می باشد. \nلطفا موجودی صندوق را بررسی نمایید.",
						caption: "خطای موجودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				}
				else
				{
					if (capitalFund.Capital_Fund.Length <= 9)
					{
						capital_Fund = decimal.Parse(capitalFund.Capital_Fund.Replace("تومان", string.Empty).Trim());
						Inventory.Program.MainForm.cashCapitalTextBox.Text = $"{capital_Fund} تومان ";

					}
					else
					{
						capital_Fund = decimal.Parse(capitalFund.Capital_Fund.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						Inventory.Program.MainForm.cashCapitalTextBox.Text = $"{capital_Fund:#,0} تومان ";
					}
				}

				return capital_Fund;

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
		#endregion /GetCapitalInventory

		#region Initialize
		/// <summary>
		/// تنظیمات ورودی اولیه
		/// </summary>
		public void Initialize()
		{
			this.Focus();

			_updateProductQuantity =
				new UpdateProductQuantity();

			RecipientName();
			CapitalInventory = GetCapitalInventory();
			AllClear();
			RefrashData();
		}
		#endregion /Initialize

		#region RefrashData
		/// <summary>
		/// تازه سازی اطلاعات
		/// </summary>
		private void RefrashData()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ProductReceived> listProductReceiveds = null;

				listProductReceiveds =
					dataBaseContext.ProductReceiveds
					.OrderBy(current => current.Id)
					.ToList();

				productRecivedDataGridView.DataSource = listProductReceiveds;
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
		#endregion /RefrashData

		#region LogInformationEditingEvents
		/// <summary>
		/// ثبت تمام فعالیت های کاربر
		/// </summary>
		private void LogInformationEditingEvents()
		{
			string descriptionLog = null;

			if (string.Compare(ProductReceived_Selected.Product_Name, ProductReceived_New.Product_Name) != 0)
			{
				descriptionLog =
					$"تغییر نام کالا از {ProductReceived_Selected.Product_Name} به {ProductReceived_New.Product_Name}";
			}

			if (string.Compare(ProductReceived_Selected.Product_Purchase_Price, ProductReceived_New.Product_Purchase_Price) != 0)
			{
				if (descriptionLog != null)
				{
					descriptionLog +=
						System.Environment.NewLine;
				}
				descriptionLog +=
					$"تغییر قیمت کالا از {ProductReceived_Selected.Product_Purchase_Price} به {ProductReceived_New.Product_Purchase_Price}";
			}

			if (string.Compare(ProductReceived_Selected.Product_Sale_Price, ProductReceived_New.Product_Sale_Price) != 0)
			{
				if (descriptionLog != null)
				{
					descriptionLog +=
						System.Environment.NewLine;
				}
				descriptionLog +=
					$"تغییر قیمت فروش کالا از {ProductReceived_Selected.Product_Sale_Price} به {ProductReceived_New.Product_Sale_Price}";
			}

			if (string.Compare(ProductReceived_Selected.Product_Quantity.ToString(), ProductReceived_New.Product_Quantity.ToString()) != 0)
			{
				if (descriptionLog != null)
				{
					descriptionLog +=
						System.Environment.NewLine;
				}
				descriptionLog +=
					$"تغییر تعداد کالا از {ProductReceived_Selected.Product_Quantity} به {ProductReceived_New.Product_Quantity}";
			}

			if (string.Compare(ProductReceived_Selected.Product_Unit, ProductReceived_New.Product_Unit) != 0)
			{
				if (descriptionLog != null)
				{
					descriptionLog +=
						System.Environment.NewLine;
				}
				descriptionLog +=
					$"تغییر واحد کالا از {ProductReceived_Selected.Product_Unit} به {ProductReceived_New.Product_Unit}";
			}

			if (string.Compare(ProductReceived_Selected.Sender_Name, ProductReceived_New.Sender_Name) != 0)
			{
				if (descriptionLog != null)
				{
					descriptionLog +=
						System.Environment.NewLine;
				}
				descriptionLog +=
					$"تغییر نام فرستنده کالا از {ProductReceived_Selected.Sender_Name} به {ProductReceived_New.Sender_Name}";
			}

			if (string.Compare(ProductReceived_Selected.Carrier_Name, ProductReceived_New.Carrier_Name) != 0)
			{
				if (descriptionLog != null)
				{
					descriptionLog +=
						System.Environment.NewLine;
				}
				descriptionLog +=
					$"تغییر نام حامل کالا از {ProductReceived_Selected.Carrier_Name} به {ProductReceived_New.Carrier_Name}";
			}

			if (descriptionLog == null)
			{
				return;
			}

			else
			{
				EventLog.Username = Inventory.Program.UserAuthentication.Username;
				EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
				EventLog.Description = descriptionLog;
				EventLog.Event_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
				EventLog.Event_Time = Infrastructure.Utility.ShowTime();

				Infrastructure.Utility.EventLog(EventLog);
			}
		}
		#endregion /LogInformationEditingEvents

		#region RemoveBill
		/// <summary>
		/// حذف اطلاعات صورت حساب
		/// </summary>
		public void RemoveBill()
		{
			AllClear();
			NumberPurchases = 0;
			listBillBuyReportItems.Clear();
		}
		#endregion /RemoveBill

		#region SetReceiptDataGridView
		/// <summary>
		/// ثبت داده های دیتاگریدویو در کلاس صورت حساب
		/// </summary>
		/// <param name="productReceived"></param>
		private void SetReceiptDataGridView(Models.ProductReceived productReceived)
		{
			int price;
			int? totalPrice;
			price = int.Parse(productReceived.Product_Purchase_Price.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
			totalPrice = (price * productReceived.Product_Quantity);

			BillBuyReportItems bill = new BillBuyReportItems()
			{
				Product_Name = productReceived.Product_Name,
				Product_Price = productReceived.Product_Purchase_Price,
				Product_Quantity = int.Parse(productReceived.Product_Quantity.ToString()),
				Product_Unit = productReceived.Product_Unit,
				Total_Price = $"{totalPrice:#,0} تومان",
			};

			listBillBuyReportItems.Add(bill);
		}
		#endregion /SetReceiptDataGridView

		#region SaveInventoryHolding
		/// <summary>
		/// ثبت اطلاعات در جدول انبار کالا
		/// </summary>
		/// <param name="inputInventoryHolding"></param>
		/// <returns></returns>
		private bool SaveInventoryHolding(Models.InventoryHolding inputInventoryHolding)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.InventoryHolding inventoryHolding =
					dataBaseContext.InventoryHoldings
					.Where(current => string.Compare(current.Product_Name, inputInventoryHolding.Product_Name) == 0)
					.FirstOrDefault();

				if (inventoryHolding == null)
				{
					inventoryHolding =
						new Models.InventoryHolding
						{
							Product_Name = inputInventoryHolding.Product_Name,
							Product_Image = inputInventoryHolding.Product_Image,
							Product_Purchase_Price = inputInventoryHolding.Product_Purchase_Price,
							Product_Sale_Price = inputInventoryHolding.Product_Sale_Price,
							Product_Quantity = inputInventoryHolding.Product_Quantity,
							Product_Unit = inputInventoryHolding.Product_Unit,
							Registration_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now),
							Registration_Time = Infrastructure.Utility.ShowTime(),
						};
					dataBaseContext.InventoryHoldings.Add(inventoryHolding);
					dataBaseContext.SaveChanges();
				}
				else
				{
					_updateProductQuantity.Final_Quantity =
						_updateProductQuantity.First_Quantity + _updateProductQuantity.Second_Quantity;

					inventoryHolding.Product_Name = inputInventoryHolding.Product_Name;
					inventoryHolding.Product_Image = inputInventoryHolding.Product_Image;
					inventoryHolding.Product_Purchase_Price = inputInventoryHolding.Product_Purchase_Price;
					inventoryHolding.Product_Sale_Price = inputInventoryHolding.Product_Sale_Price;
					inventoryHolding.Product_Quantity = _updateProductQuantity.Final_Quantity;
					inventoryHolding.Product_Unit = inputInventoryHolding.Product_Unit;

					dataBaseContext.SaveChanges();
				}

				inputInventoryHolding = null;
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
		#endregion /SaveInventoryHolding

		#region SaveProductReceived
		/// <summary>
		/// ثبت کالاهای جدید در جدول کالاها
		/// </summary>
		/// <param name="inputProductReceived"></param>
		/// <returns></returns>
		private bool SaveProductReceived(Models.ProductReceived inputProductReceived)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ProductReceived productReceived =
					dataBaseContext.ProductReceiveds
					.Where(current => string.Compare(current.Product_Name, inputProductReceived.Product_Name) == 0)
					.FirstOrDefault();

				if (productReceived == null)
				{
					productReceived =
					new Models.ProductReceived
					{
						Product_Name = inputProductReceived.Product_Name,
						Product_Image = inputProductReceived.Product_Image,
						Product_Purchase_Price = inputProductReceived.Product_Purchase_Price,
						Product_Sale_Price = inputProductReceived.Product_Sale_Price,
						Product_Quantity = inputProductReceived.Product_Quantity,
						Product_Unit = inputProductReceived.Product_Unit,
						Recipient_Name = Inventory.Program.UserAuthentication.Full_Name,
						Sender_Name = inputProductReceived.Sender_Name,
						Carrier_Name = inputProductReceived.Carrier_Name,
						Number_Edit = 0,
						Registration_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now),
						Registration_Time = Infrastructure.Utility.ShowTime(),
					};
					dataBaseContext.ProductReceiveds.Add(productReceived);
					dataBaseContext.SaveChanges();

					#region -----------------------------------------     Save Event Log     -----------------------------------------
					if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
					{
						EventLog.Username = Inventory.Program.UserAuthentication.Username;
						EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
						EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
						EventLog.Description = $"ثبت {inputProductReceived.Product_Name}";
						Infrastructure.Utility.EventLog(EventLog);
					}
					#endregion /-----------------------------------------     Save Event Log     -----------------------------------------
				}
				else
				{
					decimal _capitalFund = Inventory.Program.MainForm.GetCapitalFund();

					decimal _amountPaid = 
						decimal.Parse(inputProductReceived.Product_Purchase_Price.Replace("تومان",string.Empty).Replace(",",string.Empty).Trim()) * _updateProductQuantity.Second_Quantity;

					_capitalFund -= _amountPaid;

					productReceived.Product_Name = inputProductReceived.Product_Name;
					productReceived.Product_Image = inputProductReceived.Product_Image;
					productReceived.Product_Purchase_Price = inputProductReceived.Product_Purchase_Price;
					productReceived.Product_Sale_Price = inputProductReceived.Product_Sale_Price;
					productReceived.Product_Quantity = _updateProductQuantity.Second_Quantity;
					productReceived.Product_Unit = inputProductReceived.Product_Unit;
					productReceived.Recipient_Name = Inventory.Program.UserAuthentication.Full_Name;
					productReceived.Sender_Name = inputProductReceived.Sender_Name;
					productReceived.Carrier_Name = inputProductReceived.Carrier_Name;
					productReceived.Number_Edit = inputProductReceived.Number_Edit + 1;
					productReceived.Last_Edited_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
					productReceived.Last_Edited_Time = Infrastructure.Utility.ShowTime();

					dataBaseContext.SaveChanges();

					CapitalUpdate(_capitalFund);

					#region  -----------------------------------------    LogInformationEditingEvents     -----------------------------------------
					if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
					{
						LogInformationEditingEvents();
					}
					#endregion / -----------------------------------------     LogInformationEditingEvents     -----------------------------------------
				}
				inputProductReceived = null;

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
		#endregion /SaveProductReceived

		#region SearchProduct
		/// <summary>
		/// جستجوی کالا
		/// </summary>
		/// <param name="_productName"></param>
		/// <returns></returns>
		private bool SearchProduct(string _productName)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ProductReceived productReceived =
					dataBaseContext.ProductReceiveds
					.Where(current => string.Compare(current.Product_Name, _productName) == 0)
					.FirstOrDefault();

				if (productReceived == null)
				{
					return true;
				}
				else
				{
					return false;
				}
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


		#endregion /SearchProduct

		#region SetProduct
		/// <summary>
		/// اجرای عملیات ثبت کالا
		/// </summary>
		/// <param name="_productReceived"></param>
		/// <param name="_inventoryHolding"></param>
		private void SetProduct(Models.ProductReceived _productReceived, Models.InventoryHolding _inventoryHolding)
		{
			if (!ValidationData(_productReceived))
			{
				return;
			}
			else
			{
				if (_productReceived.Product_Purchase_Price.Length <= 9)
				{
					_firstAmount =
						decimal.Parse(_productReceived.Product_Purchase_Price.Replace("تومان", string.Empty).Trim());

					_sumAmount = _firstAmount + _secondAmount;
					_secondAmount = _sumAmount;
				}
				else
				{
					_firstAmount =
						decimal.Parse(_productReceived.Product_Purchase_Price.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());

					_sumAmount = _firstAmount + _secondAmount;
					_secondAmount = _sumAmount;
				}
				if (!CheckFundBalance(_amount: _sumAmount))
				{
					return;
				}
				else
				{
					if (string.Compare(saveBottom.Text, "ثبت کالا") == 0)
					{
						NumberPurchases++;
						SetReceiptDataGridView(_productReceived);

						if (SaveProductReceived(_productReceived) && SaveInventoryHolding(_inventoryHolding))
						{
							Infrastructure.Utility.WindowsNotification(
								message: "عملیات ثبت انجام شد",
								caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

							RefrashData();
							DeleteToGetNew();
							return;
						}
						else
						{
							Infrastructure.Utility.WindowsNotification(
								message: "عملیات ثبت انجام نگیردید",
								caption: Infrastructure.PopupNotificationForm.Caption.خطا);

							AllClear();
							return;
						}
					}
					else if (string.Compare(saveBottom.Text, "ویرایش کالا") == 0)
					{
						NumberPurchases++;
						SetReceiptDataGridView(_productReceived);

						if (SaveProductReceived(_productReceived) && SaveInventoryHolding(_inventoryHolding))
						{
							Infrastructure.Utility.WindowsNotification(
								message: "عملیات ویرایش انجام شد",
								caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

							RefrashData();
							AllClear();
							return;
						}
						else
						{
							Infrastructure.Utility.WindowsNotification(
								message: "عملیات ثبت انجام نگیردید",
								caption: Infrastructure.PopupNotificationForm.Caption.خطا);
							AllClear();
							return;
						}
					}
				}
			}
		}
		#endregion /SetProduct

		#region RecipientName
		/// <summary>
		/// نمایش نام تحویل گیرنده کالاها
		/// </summary>
		private void RecipientName()
		{
			try
			{
				if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") == 0 || Inventory.Program.UserAuthentication == null)
				{
					recipientNameTextBox.Text = "Administrator";
				}
				else
				{
					recipientNameTextBox.Text = Inventory.Program.UserAuthentication.Full_Name;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /RecipientName

		#region ValidationData
		/// <summary>
		/// این تابع بررسی می کند که آیا اطلاعات به طور کامل
		/// وارد شده است یا خیر
		/// </summary>
		/// <param name="productReceivedNew"></param>
		/// <returns>true or false</returns>
		private bool ValidationData(Models.ProductReceived productReceivedNew)
		{
			string errorMessage = null;

			try
			{
				if (string.Compare(saveBottom.Text, "ثبت کالا") ==0)
				{
					if (string.IsNullOrEmpty(productReceivedNew.Product_Name))
					{
						errorMessage = "لطفا نام کالا را وارد نمایید.";
					}
					if (string.IsNullOrEmpty(productReceivedNew.Sender_Name))
					{
						if (!string.IsNullOrEmpty(errorMessage))
						{
							errorMessage +=
								System.Environment.NewLine;
						}
						errorMessage += "لطفا نام ارسال کننده وارد نمایید.";
					}
					if (string.IsNullOrEmpty(productReceivedNew.Carrier_Name))
					{
						if (!string.IsNullOrEmpty(errorMessage))
						{
							errorMessage +=
								System.Environment.NewLine;
						}
						errorMessage += "لطفا نام حامل کالا وارد نمایید.";
					}
					if (string.IsNullOrEmpty(productReceivedNew.Product_Purchase_Price))
					{
						if (!string.IsNullOrEmpty(errorMessage))
						{
							errorMessage +=
								System.Environment.NewLine;
						}
						errorMessage += "لطفا قیمت کالا را تعیین نمایید.";
					}
					if (string.IsNullOrEmpty(productReceivedNew.Product_Sale_Price))
					{
						if (!string.IsNullOrEmpty(errorMessage))
						{
							errorMessage +=
								System.Environment.NewLine;
						}
						errorMessage += "لطفا قیمت فروش کالا را تعیین نمایید.";
					}
					if (productReceivedNew.Product_Quantity == null || productReceivedNew.Product_Quantity == 0)
					{
						if (!string.IsNullOrEmpty(errorMessage))
						{
							errorMessage +=
								System.Environment.NewLine;
						}
						errorMessage += "لطفا تعداد کالا را وارد نمایید.";
					}
					if (string.IsNullOrEmpty(productReceivedNew.Product_Unit))
					{
						if (!string.IsNullOrEmpty(errorMessage))
						{
							errorMessage +=
								System.Environment.NewLine;
						}
						errorMessage += "لطفا واحد کالا را تعیین نمایید.";
					}
					//if (productReceivedNew.Product_Image == null)
					//{
					//	if (!string.IsNullOrEmpty(errorMessage))
					//	{
					//		errorMessage +=
					//			System.Environment.NewLine;
					//	}
					//	errorMessage += "لطفا برای کالای خود تصویر انتخاب کنید.";
					//}

					if (string.IsNullOrEmpty(errorMessage))
					{
						return true;
					}
					else
					{
						Mbb.Windows.Forms.MessageBox.Show(text: errorMessage, caption: "خطای ورودی", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

						if (string.IsNullOrEmpty(productReceivedNew.Product_Name))
						{
							productNameTextBox.Focus();
						}
						else if (string.IsNullOrEmpty(productReceivedNew.Sender_Name))
						{
							senderNameTextBox.Focus();
						}
						else if (string.IsNullOrEmpty(productReceivedNew.Carrier_Name))
						{
							carrierNameTextBox.Focus();
						}
						else if (string.IsNullOrEmpty(productReceivedNew.Product_Purchase_Price))
						{
							productPriceTextBox.Focus();
						}
						else if (productReceivedNew.Product_Quantity == null || productReceivedNew.Product_Quantity == 0)
						{
							productQuantityTextBox.Focus();
						}
						else if (string.IsNullOrEmpty(productReceivedNew.Product_Unit))
						{
							productUnitComboBox.Focus();
						}
						else if (productReceivedNew.Product_Image == null)
						{
							System.Windows.Forms.OpenFileDialog openFileDialog =
								new System.Windows.Forms.OpenFileDialog
								{
									Filter = "JPG (*.jpg)|*.jpg|" +
								"PNG (*.png)|*.png|" +
								"BMP (*.bmp)|*.bmp",
									Title = "Load user picture ",
								};

							if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
							{
								productImagePictureBox.Image =
								System.Drawing.Image.FromFile(openFileDialog.FileName);
								ProductReceived_New.Product_Image = System.IO.File.ReadAllBytes(openFileDialog.FileName);
								deleteImageButton.Visible = true;
							}
							else
							{
								ProductReceived_New.Product_Image = null;
								deleteImageButton.Visible = false;
							}
						}
						return false;
					}
				}
				else
				{
					if (string.IsNullOrEmpty(productReceivedNew.Product_Name))
					{
						errorMessage = "لطفا نام کالا را وارد نمایید.";
					}
					if (string.IsNullOrEmpty(productReceivedNew.Sender_Name))
					{
						if (!string.IsNullOrEmpty(errorMessage))
						{
							errorMessage +=
								System.Environment.NewLine;
						}
						errorMessage += "لطفا نام ارسال کننده وارد نمایید.";
					}
					if (string.IsNullOrEmpty(productReceivedNew.Carrier_Name))
					{
						if (!string.IsNullOrEmpty(errorMessage))
						{
							errorMessage +=
								System.Environment.NewLine;
						}
						errorMessage += "لطفا نام حامل کالا وارد نمایید.";
					}
					if (string.IsNullOrEmpty(productReceivedNew.Product_Purchase_Price))
					{
						if (!string.IsNullOrEmpty(errorMessage))
						{
							errorMessage +=
								System.Environment.NewLine;
						}
						errorMessage += "لطفا قیمت کالا را تعیین نمایید.";
					}
					if (productReceivedNew.Product_Quantity == null)
					{
						if (!string.IsNullOrEmpty(errorMessage))
						{
							errorMessage +=
								System.Environment.NewLine;
						}
						errorMessage += "لطفا تعداد کالا را وارد نمایید.";
					}
					if (string.IsNullOrEmpty(productReceivedNew.Product_Unit))
					{
						if (!string.IsNullOrEmpty(errorMessage))
						{
							errorMessage +=
								System.Environment.NewLine;
						}
						errorMessage += "لطفا واحد کالا را تعیین نمایید.";
					}
					//if (productReceivedNew.Product_Image == null)
					//{
					//	if (!string.IsNullOrEmpty(errorMessage))
					//	{
					//		errorMessage +=
					//			System.Environment.NewLine;
					//	}
					//	errorMessage += "لطفا برای کالای خود تصویر انتخاب کنید.";
					//}
					if (string.IsNullOrEmpty(errorMessage))
					{
						return true;
					}
					else
					{
						Mbb.Windows.Forms.MessageBox.Show(text: errorMessage, caption: "خطای ورودی", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

						if (string.IsNullOrEmpty(productReceivedNew.Product_Name))
						{
							productNameTextBox.Focus();
						}
						else if (string.IsNullOrEmpty(productReceivedNew.Sender_Name))
						{
							senderNameTextBox.Focus();
						}
						else if (string.IsNullOrEmpty(productReceivedNew.Carrier_Name))
						{
							carrierNameTextBox.Focus();
						}
						else if (string.IsNullOrEmpty(productReceivedNew.Product_Purchase_Price))
						{
							productPriceTextBox.Focus();
						}
						else if (productReceivedNew.Product_Quantity == null || productReceivedNew.Product_Quantity == 0)
						{
							productQuantityTextBox.Focus();
						}
						else if (string.IsNullOrEmpty(productReceivedNew.Product_Unit))
						{
							productUnitComboBox.Focus();
						}
						//else if (productReceivedNew.Product_Image == null)
						//{
						//	System.Windows.Forms.OpenFileDialog openFileDialog =
						//		new System.Windows.Forms.OpenFileDialog
						//		{
						//			Filter = "JPG (*.jpg)|*.jpg|" +
						//		"PNG (*.png)|*.png|" +
						//		"BMP (*.bmp)|*.bmp",
						//			Title = "Load user picture ",
						//		};

						//	if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
						//	{
						//		productImagePictureBox.Image =
						//		System.Drawing.Image.FromFile(openFileDialog.FileName);
						//		ProductReceived_New.Product_Image = System.IO.File.ReadAllBytes(openFileDialog.FileName);
						//		deleteImageButton.Visible = true;
						//	}
						//	else
						//	{
						//		ProductReceived_New.Product_Image = null;
						//		deleteImageButton.Visible = false;
						//	}
						//}

						return false;
					}
				}
			}
			catch (System.Exception ex)
			{

				Infrastructure.Utility.ExceptionShow(ex);
				return false;

			}
		}

		#endregion /ValidationData

		#endregion /Function
	}
}
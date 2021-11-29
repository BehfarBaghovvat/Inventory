using System.Linq;

namespace Inventory_Forms
{
	public partial class ProductSalesForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Layer

		public class BillSaleReportItems
		{
			public string Product_Name { get; set; }
			public int? Product_Quantity { get; set; }
			public string Product_Unit { get; set; }
			public string Product_Price { get; set; }
			public string Total_Price { get; set; }
		}

		public class TransactionFactorsItems
		{
			public string Seller_Name { get; set; }
			public string Client_Name { get; set; }
			public string Carrier_Name { get; set; }
			public string License_Plate { get; set; }
			public string Phone_Number { get; set; }

		}

		private BillSaleReportForm _billSaleReportForm;
		public BillSaleReportForm BillSaleReportForm
		{
			get 
			{
				if (_billSaleReportForm == null || _billSaleReportForm.IsDisposed == true)
				{
					_billSaleReportForm =
						new BillSaleReportForm();
				}
				return _billSaleReportForm;
			}
		}

		private ProductSalesListForm _productSalesListForm;
		public ProductSalesListForm ProductSalesListForm
		{
			get
			{
				if (_productSalesListForm == null || _productSalesListForm.IsDisposed == true)
				{
					_productSalesListForm =
						new ProductSalesListForm();
				}
				return _productSalesListForm;
			}
		}

		#endregion /Layer

		public System.Collections.Generic.List<BillSaleReportItems> listBillSaleReports =
			new System.Collections.Generic.List<BillSaleReportItems>();

		private TransactionFactorsItems _transactionFactorsItems;
		public TransactionFactorsItems Transaction_Factors_Items
		{
			get
			{
				if (_transactionFactorsItems == null)
				{
					_transactionFactorsItems =
						new TransactionFactorsItems();
				}
				return _transactionFactorsItems;
			}
			set
			{
				_transactionFactorsItems = value;
			}
		}

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

		private Models.InventoryOutput _inventoryOutput;
		public Models.InventoryOutput InventoryOutput
		{
			get
			{
				if (_inventoryOutput == null)
				{
					_inventoryOutput =
						new Models.InventoryOutput();
				}
				return _inventoryOutput;
			}
			set { _inventoryOutput = value; }
		}

		public int Price { get; private set; }
		public int? OldQuantity { get; set; }
		public int? NewQuantity { get; set; }
		public int NumberPurchases { get; set; }

		#endregion/Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public ProductSalesForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region ProcutSalesForm_Load
		private void ProcutSalesForm_Load(object sender, System.EventArgs e)
		{
			
		}
		#endregion  /ProcutSalesForm_Load

		#region ProductQuantityTextBox_Enter
		private void ProductQuantityTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
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
				InventoryOutput.Product_Quantity = null;
			}
			else
			{
				if (CheckInventory(int.Parse(productQuantityTextBox.Text)))
				{
					InventoryOutput.Product_Quantity = int.Parse(productQuantityTextBox.Text);

					NewQuantity = OldQuantity - InventoryOutput.Product_Quantity;

					return;
				}
				else
				{
					Mbb.Windows.Forms.MessageBox.Show(text: "موجودی کالای مورد نظر \n کافی نمی باشد.", caption: "خطای موجودی", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					productQuantityTextBox.Focus();
					productQuantityTextBox.SelectAll();
					InventoryOutput.Product_Quantity = null;
				}
			}
		}
		#endregion /ProductQuantityTextBox_Leave

		#region ProductPriceTextBox_Enter
		private void ProductPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (string.IsNullOrWhiteSpace(productPriceTextBox.Text))
			{
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
					InventoryOutput.Product_Price = null;
					return;
				}
				else if (string.Compare(productPriceTextBox.Text, "0 تومان") == 0)
				{
					productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
					productPriceTextBox.Clear();
					InventoryOutput.Product_Price = null;
					return;

				}
				else if (string.Compare(productPriceTextBox.Text, " تومان") == 0 || string.Compare(productPriceTextBox.Text, "تومان") == 0 || string.Compare(productPriceTextBox.Text, "توما") == 0 || string.Compare(productPriceTextBox.Text, "توم") == 0 || string.Compare(productPriceTextBox.Text, "تو") == 0 || string.Compare(productPriceTextBox.Text, "ت") == 0)
				{
					productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
					productPriceTextBox.Clear();
					InventoryOutput.Product_Price = null;
					return;
				}
				else
				{
					productPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
					InventoryOutput.Product_Price = productPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
					Price = int.Parse(InventoryOutput.Product_Price.Replace(",", string.Empty).Trim());
					productPriceTextBox.Text = $"{Price:#,0} تومان";
					InventoryOutput.Product_Price = productPriceTextBox.Text;
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
				InventoryOutput.Carrier_Name = null;
				return;
			}
			else
			{
				InventoryOutput.Carrier_Name = carrierNameTextBox.Text;
			}
		}
		#endregion /CarrierNameTextBox_TextChange

		#region ClientNameTextBox_Enter
		private void ClientNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /ClientNameTextBox_Enter

		#region ClientNameTextBox_KeyPress
		private void ClientNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /ClientNameTextBox_KeyPress

		#region ClientNameTextBox_TextChange
		private void ClientNameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientNameTextBox.Text))
			{
				InventoryOutput.Client_Name = null;
				return;
			}
			else
			{
				InventoryOutput.Client_Name = clientNameTextBox.Text;
			}
		}
		#endregion /ClientNameTextBox_TextChange

		#region PhoneNumberTextBox_Enter
		private void PhoneNumberTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			
		}
		#endregion /PhoneNumberTextBox_Enter

		#region PhoneNumberTextBox_KeyPress
		private void PhoneNumberTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /PhoneNumberTextBox_KeyPress

		#region PhoneNumberTextBox_Leave
		private void PhoneNumberTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
			{
				phoneNumberTextBox.Clear();
				phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else if (!phoneNumberTextBox.Text.StartsWith("09"))
			{
				Mbb.Windows.Forms.MessageBox.Show(
				text: "فرمت شماره تلفن همراه صحیح نمی باشد. \n لطفا مجدد تلاش نمایید.",
				caption: "خطای ورودی",
				icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
				button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				phoneNumberTextBox.SelectAll();
				phoneNumberTextBox.Focus();
				return;
			}
			else if (phoneNumberTextBox.Text.Length < 11)
			{
				Mbb.Windows.Forms.MessageBox.Show(
					text: "تعداد ارقام وارد شده کمتر از 11 رقم می باشد. \n لطفا مجدد تلاش نمایید.",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				phoneNumberTextBox.Focus();
			}
			else if (phoneNumberTextBox.Text.Length == 11)
			{
				phoneNumberTextBox.Text = phoneNumberTextBox.Text.Insert(4, "-");

				InventoryOutput.Phone_Number = phoneNumberTextBox.Text;
				
			}
			else if (phoneNumberTextBox.Text.Length >= 12 && !phoneNumberTextBox.Text.Contains('-'))
			{
				Mbb.Windows.Forms.MessageBox.Show(
				text: "تعداد ارقام وارد شده بیشتر از 11 رقم می باشد. \n لطفا مجدد تلاش نمایید.",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				phoneNumberTextBox.SelectAll();
				phoneNumberTextBox.Focus();
				return;
			}
		}
		#endregion /PhoneNumberTextBox_Leave

		#region PhoneNumberTextBox_TextChange
		private void PhoneNumberTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
			{
				phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
			else
			{
				phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

				GetClientName(phoneNumberTextBox.Text);
				
			}
		}
		#endregion /PhoneNumberTextBox_TextChange

		#region ProductSearchTextBox_Enter
		private void ProductSearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /ProductSearchTextBox_Enter

		#region ProductSearchTextBox_KeyPress
		private void ProductSearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /ProductSearchTextBox_KeyPress

		#region ProductSearchTextBox_TextChange
		private void ProductSearchTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(productSearchTextBox.Text))
			{
				return;
			}
			else
			{
				ProductSearch(productSearchTextBox.Text);
			}
		}
		#endregion /ProductSearchTextBox_TextChange

		#region BillButton_Click
		private void BillButton_Click(object sender, System.EventArgs e)
		{
			if ((listBillSaleReports.Count == 0 && NumberPurchases == 0) || Transaction_Factors_Items == null)
			{
				Mbb.Windows.Forms.MessageBox.Show(text: "برای دریافت صورت حساب لطفا سفارش جدید دریافت کنید.",
					caption: "عدم صدور صورت حساب", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				return;
			}
			else
			{
				BillSaleReportForm.MyProductSalesForm = this;
				BillSaleReportForm.SetItemsBillSale(listBillSaleReports, Transaction_Factors_Items);

				BillSaleReportForm.Show();
			}
		}
		#endregion /BillButton_Click

		#region InventoryOutputButton_Click
		private void InventoryOutputButton_Click(object sender, System.EventArgs e)
		{
			ProductSalesListForm.ShowDialog();
		}
		#endregion /InventoryOutputButton_Click

		#region AddOrderButton_Click
		private void AddOrderButton_Click(object sender, System.EventArgs e)
		{
			if (InputValidation(InventoryOutput))
			{
				InventoryOutput.Product_Name = productNameTextBox.Text;
				InventoryOutput.Product_Unit = productUnitTextBox.Text;
				InventoryOutput.Seller_Name = sellerNameTextBox.Text;
				InventoryOutput.Add_Order_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
				InventoryOutput.Add_Order_Time = Infrastructure.Utility.ShowTime();

				AddOrder(InventoryOutput);
				addOrderButton.Enabled = false;
			}
			else
			{
				return;
			}
		}
		#endregion /AddOrderButton_Click

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			AllClear();
		}
		#endregion /ResetButton_Click

		#region InventoryHoldingDataGridView_CellDoubleClick
		private void InventoryHoldingDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (inventoryHoldingDataGridView.RowCount <= 0)
			{
				return;
			}
			else
			{
				addOrderButton.Enabled = true;
				productNameTextBox.Text = inventoryHoldingDataGridView.CurrentRow.Cells[1].Value.ToString();
				InventoryOutput.Product_Name = inventoryHoldingDataGridView.CurrentRow.Cells[1].Value.ToString();

				productQuantityTextBox.Text = inventoryHoldingDataGridView.CurrentRow.Cells[2].Value.ToString();
				InventoryOutput.Product_Quantity =int.Parse(inventoryHoldingDataGridView.CurrentRow.Cells[2].Value.ToString());
				productQuantityTextBox.Focus();
				productQuantityTextBox.SelectAll();
				OldQuantity = int.Parse(inventoryHoldingDataGridView.CurrentRow.Cells[2].Value.ToString());

				productUnitTextBox.Text = inventoryHoldingDataGridView.CurrentRow.Cells[3].Value.ToString();
				InventoryOutput.Product_Unit = inventoryHoldingDataGridView.CurrentRow.Cells[3].Value.ToString();

				productPriceTextBox.Text = inventoryHoldingDataGridView.CurrentRow.Cells[5].Value.ToString();
				InventoryOutput.Product_Price = inventoryHoldingDataGridView.CurrentRow.Cells[5].Value.ToString();

			}
		}
		#endregion /InventoryHoldingDataGridView_CellDoubleClick



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founction

		#region AllClear
		/// <summary>
		/// برگشت به حالت اولیه سفارش
		/// </summary>
		public void AllClear()
		{
			InventoryOutput = null;
			NumberPurchases = 0;
			listBillSaleReports.Clear();
			Transaction_Factors_Items = null;
			productNameTextBox.Clear();
			productQuantityTextBox.Clear();
			productUnitTextBox.Clear();
			productPriceTextBox.Clear();
			sellerNameTextBox.Clear();
			clientNameTextBox.Clear();
			carrierNameTextBox.Clear();
			phoneNumberTextBox.Clear();
		}
		#endregion /AllClear

		#region AddNewOrder
		private void AddNewOrder()
		{
			productNameTextBox.Clear();
			productQuantityTextBox.Clear();
			productUnitTextBox.Clear();
			productPriceTextBox.Clear();

			InventoryOutput.Product_Name = null;
			InventoryOutput.Product_Quantity = null;
			InventoryOutput.Product_Unit = null;
			InventoryOutput.Product_Price = null;
		}
		#endregion /AddNewOrder

		#region AddOrder
		/// <summary>
		/// افزودن سفارش
		/// </summary>
		/// <param name="inputInventoryOutput"></param>
		private void AddOrder(Models.InventoryOutput inputInventoryOutput)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				GetItemsBillSale(inputInventoryOutput);

				dataBaseContext =
					new Models.DataBaseContext();

				Models.InventoryOutput inventoryOutput =
					new Models.InventoryOutput
					{
						Product_Name = inputInventoryOutput.Product_Name,
						Product_Quantity = inputInventoryOutput.Product_Quantity,
						Product_Unit = inputInventoryOutput.Product_Unit,
						Product_Price = inputInventoryOutput.Product_Price,
						Seller_Name = inputInventoryOutput.Seller_Name,
						Client_Name = inputInventoryOutput.Client_Name,
						Carrier_Name = inputInventoryOutput.Carrier_Name,
						Add_Order_Date = inputInventoryOutput.Add_Order_Date,
						Add_Order_Time = inputInventoryOutput.Add_Order_Time,
					};
				dataBaseContext.InventoryOutputs.Add(inventoryOutput);
				dataBaseContext.SaveChanges();

				NumberPurchases++;

				#region -----------------------------------------     Save Event Log     -----------------------------------------
				if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
				{
					EventLog.Username = Inventory.Program.UserAuthentication.Username;
					EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
					EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
					EventLog.Description =
						$"{inputInventoryOutput.Product_Name} توسط" +
						$" {inputInventoryOutput.Seller_Name} به قیمت" +
						$" {inputInventoryOutput.Product_Price} به تعداد" +
						$" {inputInventoryOutput.Product_Quantity}" +
						$" {inputInventoryOutput.Product_Unit} توسط " +
						$"{inputInventoryOutput.Carrier_Name} به آقا/خانم " +
						$"{inputInventoryOutput.Client_Name} تحویل و در سیستم ثبت گردید.";

					Infrastructure.Utility.EventLog(EventLog);
				}
				#endregion /-----------------------------------------     Save Event Log     -----------------------------------------

				WarehouseOutput(NewQuantity, inputInventoryOutput.Product_Name);
				ProductReceived(NewQuantity, inputInventoryOutput.Product_Name);
				AddNewOrder();

				Infrastructure.Utility.WindowsNotification(message: $"{inputInventoryOutput.Product_Name} به فاکتور اضافه گردید.", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

				inputInventoryOutput = null;
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
		#endregion AddOrder

		#region CheckInventory
		/// <summary>
		/// بررسی موجودی یک کالا در انبار
		/// </summary>
		/// <param name="productQuantity"></param>
		/// <returns></returns>
		private bool CheckInventory(int? productQuantity)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.InventoryHolding inventoryHolding =
					dataBaseContext.InventoryHoldings
					.Where(current => string.Compare(current.Product_Name, productNameTextBox.Text) == 0)
					.FirstOrDefault();

				if (inventoryHolding.Product_Quantity < productQuantity)
				{
					return false;
				}
				else
				{
					return true;
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
		#endregion

		#region GetClientName
		/// <summary>
		/// با وارد کردن شماره همراه
		/// در صورت موجود بودن در سیستم
		/// نام مشتری برگشت داده میشود.
		/// </summary>
		/// <param name="_client"></param>
		/// <returns></returns>
		private void GetClientName(string _clientPhone)
		{
			string _phoneNumber = _clientPhone.Replace("-",string.Empty).Trim();

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Client client =
					dataBaseContext.Clients
					.Where(current => string.Compare(current.Phone_Number, _phoneNumber) ==0)
					.FirstOrDefault();

				if (client != null)
				{
					Transaction_Factors_Items.Phone_Number = client.Phone_Number;
					clientNameTextBox.Text = client.Client_Name;
				}
				else
				{
					Transaction_Factors_Items.Phone_Number = _phoneNumber;
					clientNameTextBox.Clear();
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
		#endregion /GetClientName

		#region LoadedProduction
		/// <summary>
		/// بارگزاری محصولات
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

		#region Initialize
		/// <summary>
		/// مقداردهی اولیه
		/// </summary>
		public void Initialize()
		{
			this.Focus();

			AllClear();

			if (Inventory.Program.UserAuthentication == null)
			{
				sellerNameTextBox.Text = "حالت استفاده بدون کاربر";
			}
			else
			{
				sellerNameTextBox.Text = Inventory.Program.UserAuthentication.Full_Name;
			}
			LoadedProduction();
		}
		#endregion /Initialize

		#region InputValidation
		/// <summary>
		/// اعتبارسنجی ورودی
		/// </summary>
		/// <param name="inventoryOutput"></param>
		/// <returns></returns>
		private bool InputValidation(Models.InventoryOutput inventoryOutput)
		{
			string errorMessage = null;

			if (inventoryOutput.Product_Quantity == null || inventoryOutput.Product_Quantity == 0)
			{
				errorMessage = "لطفا تعداد کالا را مشخص نمایید.";

			}
			if (string.IsNullOrEmpty(inventoryOutput.Product_Price))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += "لطفا  قیمت کالا را وارد نمایید.";
			}
			if (string.IsNullOrEmpty(inventoryOutput.Carrier_Name))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += "لطفا نام حامل کالا را وارد نمایید.";
			}
			if (string.IsNullOrEmpty(inventoryOutput.Client_Name))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += "لطفا نام مشتری را وارد نمایید.";
			}
			if (string.IsNullOrWhiteSpace(inventoryOutput.Phone_Number))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += "لطفا شماره تماس مشتری را وارد نمایید.";
			}

			//====================================================================================================================================

			if (errorMessage != null)
			{
				if (inventoryOutput.Product_Quantity == null || inventoryOutput.Product_Quantity == 0)
				{
					productQuantityTextBox.Focus();
				}
				else if (string.IsNullOrEmpty(inventoryOutput.Product_Price))
				{
					productPriceTextBox.Focus();
				}
				else if (string.IsNullOrEmpty(inventoryOutput.Client_Name))
				{
					clientNameTextBox.Focus();
				}
				else if (string.IsNullOrEmpty(inventoryOutput.Carrier_Name))
				{
					carrierNameTextBox.Focus();
				}
				else if (string.IsNullOrEmpty(inventoryOutput.Phone_Number))
				{
					phoneNumberTextBox.Focus();
				}

				Mbb.Windows.Forms.MessageBox.Show(text: errorMessage,
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				return false;
			}
			else
			{
				return true;
			}
		}
		#endregion /InputValidtion

		#region ProductReceived
		/// <summary>
		/// دریافت کالا
		/// </summary>
		/// <param name="newQuantity"></param>
		/// <param name="productName"></param>
		private void ProductReceived(int? newQuantity, string productName)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ProductReceived productReceived =
					dataBaseContext.ProductReceiveds
					.Where(current => string.Compare(current.Product_Name, productName) == 0)
					.FirstOrDefault();

				if (productReceived != null)
				{
					productReceived.Product_Quantity = newQuantity;
				}
				dataBaseContext.SaveChanges();
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
		#endregion /ProductReceived

		#region PrintInvoiceWare
		/// <summary>
		/// برای چاپ صورت حساب، یک لیست از اجناس تهیه نمودیم.
		/// </summary>
		/// <param name="printInventoryOutput"></param>
		private void GetItemsBillSale(Models.InventoryOutput inventoryOutput)
		{
			#region Calculate
			int price = int.Parse(inventoryOutput.Product_Price.Replace("تومان", string.Empty).Trim().Replace(",", string.Empty).Trim());
			int? quantity = inventoryOutput.Product_Quantity;
			int? totalPrice = price * quantity;
			#endregion /Calculate

			BillSaleReportItems billSaleReport = new BillSaleReportItems()
			{
				Product_Name = inventoryOutput.Product_Name,
				Product_Price = inventoryOutput.Product_Price,
				Product_Quantity = inventoryOutput.Product_Quantity,
				Product_Unit = inventoryOutput.Product_Unit,
				Total_Price = $"{totalPrice:#,0} تومان",
			};

			listBillSaleReports.Add(billSaleReport);
			listBillSaleReports.TrimExcess();

			Transaction_Factors_Items.Carrier_Name = inventoryOutput.Carrier_Name;
			Transaction_Factors_Items.Seller_Name = null;
			Transaction_Factors_Items.Seller_Name = Inventory.Program.UserAuthentication.Full_Name;
			Transaction_Factors_Items.Client_Name = inventoryOutput.Client_Name;

		}
		#endregion PrintInvoiceWare

		#region ProductSearch
		/// <summary>
		/// جستجوی کالا
		/// </summary>
		/// <param name="productName"></param>
		private void ProductSearch(string productName)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.InventoryHolding> inventoryHolding = null;

				if (string.IsNullOrWhiteSpace(productSearchTextBox.Text))
				{
					inventoryHolding =
					dataBaseContext.InventoryHoldings
					.OrderBy(current => current.Product_Name)
					.ToList();
				}
				else
				{
					inventoryHolding =
					dataBaseContext.InventoryHoldings
					.Where(current => current.Product_Name.Contains(productName))
					.OrderBy(current => current.Product_Name)
					.ToList();
				}

				inventoryHoldingDataGridView.DataSource = inventoryHolding;

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
		#endregion /ProductSearch

		#region RemoveBill
		/// <summary>
		/// حذف اطلاعات صورت حساب
		/// </summary>
		public void RemoveBill()
		{
			NumberPurchases = 0;
			listBillSaleReports.Clear();
			Transaction_Factors_Items = null;
		}
		#endregion /RemoveBill

		#region WarehouseOutput
		/// <summary>
		/// ثبت مقدار خروجی انبار
		/// </summary>
		/// <param name="newQuantity"></param>
		/// <param name="productName"></param>
		private void WarehouseOutput(int? newQuantity, string productName)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.InventoryHolding inventoryHolding =
					dataBaseContext.InventoryHoldings
					.Where(current => string.Compare(current.Product_Name, productName) == 0)
					.FirstOrDefault();

				if (inventoryHolding != null)
				{
					inventoryHolding.Product_Quantity = newQuantity;
				}
				dataBaseContext.SaveChanges();
				LoadedProduction();
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



		#endregion /WarehouseOutput

		#endregion /Founction
	}
}

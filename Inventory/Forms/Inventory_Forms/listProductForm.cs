using System;
using System.Linq;

namespace Inventory_Forms
{
	public partial class ListProductForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region --------------------------------------------------------     Properties     --------------------------------------------------------

		#region --------------------------------------------------------     Layer     --------------------------------------------------------

		public class ListProducte
		{
			public int ID
			{
				get; set;
			}

			public int Quantity_Producte
			{
				get; set;
			}

			public int Number_Orders
			{
				get; set;
			}
		}

		private class InvoiceItem
		{
			public string Producte_Name
			{
				get; set;
			}

			public string Description
			{
				get; set;
			}

			public int Number_Order
			{
				get; set;
			}

			public string Service_Price
			{
				get; set;
			}

			public string Producte_Price
			{
				get; set;
			}
		}


		private Inventory_Forms.ServiceForm _serviceForm;

		public Inventory_Forms.ServiceForm ServiceForm
		{
			get
			{
				if (_serviceForm == null || _serviceForm.IsDisposed == true)
				{
					_serviceForm =
						new Inventory_Forms.ServiceForm();
				}
				return _serviceForm;
			}
			set
			{
				_serviceForm = value;
			}
		}




		#endregion /--------------------------------------------------------     Layer     --------------------------------------------------------

		System.Collections.Generic.List<int> _listProductes = new System.Collections.Generic.List<int>();

		System.Collections.Generic.List<InvoiceItem> _listInvoiceItems = new System.Collections.Generic.List<InvoiceItem>();


		private ListProducte _producte;
		public ListProducte Producte
		{
			get
			{
				if (_producte == null)
				{
					_producte =
						new ListProducte();
				}
				return _producte;
			}
			set
			{
				_producte = value;
			}
		}

		public int NumberPurchases
		{
			get;
			private set;
		}






		#endregion /--------------------------------------------------------     Properties     --------------------------------------------------------



		//-----------------------------------------------------------------------------------------------     Constracture

		public ListProductForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		private void ListProductForm_Load(object sender, System.EventArgs e)
		{
			LoadListProducte();
		}

		#region InventoryHoldingDataGridView_CellDoubleClick
		private void InventoryHoldingDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 5 && e.RowIndex >=0)
			{
				inventoryHoldingDataGridView.CurrentRow.Cells[5].ReadOnly = false;
			}
			else
			{
				inventoryHoldingDataGridView.CurrentRow.Cells[5].ReadOnly = true;
			}
		}
		#endregion /InventoryHoldingDataGridView_CellDoubleClick


		#region InventoryHoldingDataGridView_CellValueChanged
		private void InventoryHoldingDataGridView_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == 5)
			{
				Producte.Number_Orders = int.Parse(inventoryHoldingDataGridView.CurrentRow.Cells[5].Value.ToString());

				// این خط از کد باعث می شود، زمانی که ما یک سطر را انتخاب کردیم و
				// مقدار تعداد سفارش را تعیین کردیم مقدار تعداد کالا را در یک متغییر نگهدارد.
				Producte.Quantity_Producte = _listProductes[e.RowIndex];

				int _remainingQuantity = Producte.Quantity_Producte - Producte.Number_Orders;

				inventoryHoldingDataGridView.CurrentRow.Cells[3].Value = _remainingQuantity.ToString();
			}
		}
		#endregion /InventoryHoldingDataGridView_CellValueChanged

		#region InventoryHoldingDataGridView_RowEnter
		private void InventoryHoldingDataGridView_RowEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{

		}
		#endregion /InventoryHoldingDataGridView_RowEnter

		#region inventoryHoldingDataGridView_CellClick
		private void inventoryHoldingDataGridView_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{

		}
		#endregion /inventoryHoldingDataGridView_CellClick

		private void SendToBillButton_Click(object sender, System.EventArgs e)
		{
			if (SetinvoiceItem())
			{
				//SendToInvoice();
				UpdateData();
			}
		}

		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Private_Methods

		#region LoadListProducte
		/// <summary>
		/// بارکشی لیست کالاها
		/// </summary>
		private void LoadListProducte()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.InventoryHolding> _listInventoryHoldings = null;

				_listInventoryHoldings =
					dataBaseContext.InventoryHoldings
					.OrderBy(currnet => currnet.Id)
					.ToList();

				inventoryHoldingDataGridView.DataSource = _listInventoryHoldings;

				foreach (System.Windows.Forms.DataGridViewRow row in inventoryHoldingDataGridView.Rows)
				{
					_listProductes.Add(int.Parse(row.Cells[3].Value.ToString()));
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
		#endregion /LoadListProducte


		#region UpdateData
		/// <summary>
		/// به روز کردن اطلاعات کالاهای انبار
		/// </summary>
		private void UpdateData()
		{

		}
		#endregion /UpdateData

		#region SendToInvoice
		/// <summary>
		/// ارسال کالاهای انتخابی به فاکتور
		/// </summary>
		private void SendToInvoice(System.Collections.Generic.List<Inventory_Forms.ServiceForm.InvoiceItem> invoiceItems)
		{
			if (NumberPurchases == 0 && _listInvoiceItems.Count == 0)
			{
				Mbb.Windows.Forms.MessageBox.Show
					(text: "هیچ کالایی برای ارسال به فاکتور انتخاب نگردیده.",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
			}
			else
			{
				
				//BillBuyReportForm.SetBillInDataGridView(listBillBuyReportItems);
				//BillBuyReportForm.ShowDialog();
			}




		}
		#endregion /SendToInvoice

		#region SetinvoiceItem
		/// <summary>
		/// ثبت کالاهای انتخاب شده جهت ارسال به فاکتور
		/// </summary>
		/// <returns></returns>
		private bool SetinvoiceItem()
		{
			try
			{
				foreach (System.Windows.Forms.DataGridViewRow row in inventoryHoldingDataGridView.Rows)
				{
					if (!string.IsNullOrWhiteSpace(inventoryHoldingDataGridView.CurrentRow.Cells[5].Value.ToString()) && string.Compare(inventoryHoldingDataGridView.CurrentRow.Cells[5].Value.ToString(), "0") != 0)
					{
						NumberPurchases++;

						InvoiceItem invoiceItem = new InvoiceItem
						{
							Producte_Name = row.Cells[1].Value.ToString(),
							Number_Order = int.Parse(row.Cells[5].Value.ToString()),
							Producte_Price = row.Cells[2].Value.ToString(),
						};

						_listInvoiceItems.Add(invoiceItem);
					}
				}

				return true;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
				return false;
			}
		}
		#endregion /SetinvoiceItem

		#endregion /Private_Methods






	}
}

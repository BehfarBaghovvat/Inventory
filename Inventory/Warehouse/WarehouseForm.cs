namespace Warehouse
{
	public partial class WarehouseForm : Infrastructure.BaseForm
	{
		#region Properties
		public bool InvoiceCommodity { get; set; }
		public bool Storage { get; set; }
		#endregion /Properties

		public WarehouseForm()
		{
			InitializeComponent();
		}

		private void InvoiceAndCommodityButton_Click(object sender, System.EventArgs e)
		{
			if (InvoiceCommodity == true)
			{
				return;
			}
			else
			{
				InvoiceCommodity = true;
				Storage = false;
				mainPanel.Controls.Clear();
				InvoiceAndCommodityForm invoiceAndCommodity = new InvoiceAndCommodityForm()
				{ Dock = System.Windows.Forms.DockStyle.Fill, TopLevel = false, TopMost = true };
				mainPanel.Controls.Add(invoiceAndCommodity);
				invoiceAndCommodity.Show();
			}
		}

		private void StoragButtonButton_Click(object sender, System.EventArgs e)
		{
			if (Storage == true)
			{
				return;
			}
			else
			{
				InvoiceCommodity = false;
				Storage = true;
				this.mainPanel.Controls.Clear();
			}
		}
	}
}

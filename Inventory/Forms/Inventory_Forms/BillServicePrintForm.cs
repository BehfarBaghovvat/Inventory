namespace Inventory_Forms
{
	public partial class BillServicePrintForm : Infrastructure.EmptyForm
	{
		public BillServicePrintForm()
		{
			InitializeComponent();
		}

		//----------Beginning of the code!----------

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{

			if (Mbb.Windows.Forms.MessageBox.Show(text: "آیا گزارش جاری حذف گردد؟", caption: "حذف گزارش", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
			{
				if (Inventory.MainForm.ProductBuyForm != null)
				{
					//Inventory.MainForm.InventoryEntranceForm.receiptDataGridView.Rows.Clear();
					//Inventory.MainForm.InventoryEntranceForm.getReceiptButton.Checked = false;
				}
				this.Dispose();
			}
			else
			{
				if (Inventory.MainForm.ProductBuyForm != null)
				{
					//Inventory.MainForm.InventoryEntranceForm.getReceiptButton.Checked = false;
				}
				this.Dispose();
			}
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizeButton_Click

		//----------End of code!----------
	}
}

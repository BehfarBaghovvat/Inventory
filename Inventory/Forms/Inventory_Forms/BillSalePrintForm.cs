
namespace Inventory_Forms
{
	public partial class BillSalePrintForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers


		//-----------------------------------------------------------------------------------------------     Constracture
		public BillSalePrintForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		#endregion /CloseButton_Click




		//-----------------------------------------------------------------------------------------------     Privat Methods
	}
}

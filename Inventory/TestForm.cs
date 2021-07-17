namespace Inventory
{
	public partial class TestForm : Infrastructure.BaseForm
	{
		public string Message { get; set; }

		public TestForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			invoiceNumberTextBox.Text = Infrastructure.Utility.GeneratInvoiceSerialNumber(int.Parse("1"));
		}

		private void button2_Click(object sender, System.EventArgs e)
		{

			invoiceNumber2TextBox.Text = Infrastructure.Utility.GeneratInvoiceSerialNumber(int.Parse("2"));
		}

		private void button3_Click(object sender, System.EventArgs e)
		{

			invoiceNumber3TextBox.Text = Infrastructure.Utility.GeneratInvoiceSerialNumber(int.Parse("3"));
		}

		private void button4_Click(object sender, System.EventArgs e)
		{

			invoiceNumber4TextBox.Text = Infrastructure.Utility.GeneratInvoiceSerialNumber(int.Parse("4"));
		}

		
	}
}

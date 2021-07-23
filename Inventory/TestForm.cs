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
			Mbb.Windows.Forms.MessageBox.Show(text: "",caption: "", icon: Mbb.Windows.Forms.MessageBoxIcon.Information, button: Mbb.Windows.Forms.MessageBoxButtons.Ok );
		}

		private void button2_Click(object sender, System.EventArgs e)
		{

		}
	}
}

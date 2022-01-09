namespace Inventory
{
	public partial class TestControlsForm : System.Windows.Forms.Form
	{
		decimal num1, num2, num3;


		public TestControlsForm()
		{
			InitializeComponent();
		}

		private void guna2GroupBox1_Leave(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show($"{numTextBox1.Text} - {numTextBox3.Text}{iranLabel.Text} - {numTextBox2.Text}{alphabetComboBox.SelectedItem}");
		}

	
	}
}

namespace Inventory
{
	public partial class TestControlsForm : System.Windows.Forms.Form
	{
		decimal num1, num2, num3;

		private void button1_Click(object sender, System.EventArgs e)
		{
			Mbb.Windows.Forms.MessageBox.Show(text: "Hello Word!", caption: "اعلان", icon: Mbb.Windows.Forms.MessageBoxIcon.Information, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
		}

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

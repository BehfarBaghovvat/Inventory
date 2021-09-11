namespace Inventory
{
	public partial class TestControlsForm : System.Windows.Forms.Form
	{
		public enum DaysOfWeek
		{
			شنبه,
			یکشنبه,
			دوشنبه,
			سه_شنبه,
			چهارشنبه,
			پنج_شنبه,
			جمعه,
		}

		public enum TimeInterval
		{
			روزانه,
			هفتگی,
			ماهیانه,
		}

		public TestControlsForm()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show($"{DaysOfWeek.شنبه}");

		}
	}
}

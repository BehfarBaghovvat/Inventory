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
			string[] drive = System.Environment.GetLogicalDrives();

			if (drive.Length <=1)
			{
				System.Windows.Forms.MessageBox.Show($"تعداد پارتیش {drive.Length} می باشد.");
			}
			else
			{
				System.Windows.Forms.MessageBox.Show($"تعداد پارتیش {drive.Length} می باشد.");
			}

		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			System.IO.Directory.CreateDirectory("E:\\NewDirectory");
		}
	}
}

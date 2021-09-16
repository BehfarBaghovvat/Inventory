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

		private void button3_Click(object sender, System.EventArgs e)
		{
			System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();
			//dayOfWeekComboBox.SelectedIndex = dayOfWeekComboBox.FindString($"{persianCalendar.GetDayOfWeek(System.DateTime.Now)}");
			System.DayOfWeek dayOfWeek = persianCalendar.GetDayOfWeek(System.DateTime.Now);

			switch (dayOfWeek)
			{
				case System.DayOfWeek.Saturday:
				dayOfWeekComboBox.SelectedIndex = 0;
				break;
				case System.DayOfWeek.Sunday:
				dayOfWeekComboBox.SelectedIndex = 1;
				break;
				case System.DayOfWeek.Monday:
				dayOfWeekComboBox.SelectedIndex = 2;
				break;
				case System.DayOfWeek.Tuesday:
				dayOfWeekComboBox.SelectedIndex = 3;
				break;
				case System.DayOfWeek.Wednesday:
				dayOfWeekComboBox.SelectedIndex = 4;
				break;
				case System.DayOfWeek.Thursday:
				dayOfWeekComboBox.SelectedIndex = 5;
				break;
				case System.DayOfWeek.Friday:
				dayOfWeekComboBox.SelectedIndex = 6;
				break;
				default:
				break;
			}


		}
	}
}

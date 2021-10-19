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



		decimal num1, num2, num3;


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
			//System.IO.Directory.CreateDirectory("E:\\NewDirectory");

			System.Windows.Forms.MessageBox.Show($"{bunifuTextBox4.Text.Insert(7, " - ").Insert(14," - ")}");
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

		private void bunifuTextBox4_Leave(object sender, System.EventArgs e)
		{
			//System.Windows.Forms.MessageBox.Show($"{bunifuTextBox4.Text.Insert(7, " - ")}");
			
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show($"{numTextBox1.Text} - {numTextBox3.Text}{iranLabel.Text} - {numTextBox2.Text}{alphabetComboBox.SelectedItem}");
		}		

		private void guna2GroupBox1_Leave(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show($"{numTextBox1.Text} - {numTextBox3.Text}{iranLabel.Text} - {numTextBox2.Text}{alphabetComboBox.SelectedItem}");
		}

		private void textBox6_TextChanged(object sender, System.EventArgs e)
		{
			if ((string.IsNullOrWhiteSpace(textBox5.Text) || string.Compare(textBox5.Text, "0") == 0) && (string.IsNullOrWhiteSpace(textBox6.Text) || string.Compare(textBox6.Text, "0") == 0))
			{
				num2 = 0;
				num1 = 0;

				num3 = num2 - (num1);

				textBox4.Text = $"{num3}";
			}
			else if (string.IsNullOrWhiteSpace(textBox5.Text) || string.Compare(textBox5.Text,"0")==0)
			{
				num2 = 0;

				num1 = decimal.Parse(textBox6.Text);

				num3 = num2 - (num1);

				textBox4.Text = $"{num3}";
			}
			else
			{
				num1 = decimal.Parse(textBox6.Text);

				num3 = num2 - (num1);

				textBox4.Text = $"{num3}";
			}
		}

		private void textBox5_TextChanged(object sender, System.EventArgs e)
		{
			if ((string.IsNullOrWhiteSpace(textBox5.Text) || string.Compare(textBox5.Text, "0") == 0) &&(string.IsNullOrWhiteSpace(textBox6.Text) || string.Compare(textBox6.Text, "0") == 0))
			{
				num2 = 0;
				num1 = 0;

				num3 = num2 - (num1);

				textBox4.Text = $"{num3}";
			}
			else if (string.IsNullOrWhiteSpace(textBox6.Text) || string.Compare(textBox6.Text, "0") == 0)
			{
				num1 = 0;

				num2 = decimal.Parse(textBox5.Text);

				num3 = num2 - (num1);

				textBox4.Text = $"{num3}";
			}
			else
			{
				num2 = decimal.Parse(textBox5.Text);

				num3 = num2 - (num1);

				textBox4.Text = $"{num3}";
			}
		}
	}
}

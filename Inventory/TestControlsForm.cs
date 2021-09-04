namespace Inventory
{
	public partial class TestControlsForm : System.Windows.Forms.Form
	{
		public TestControlsForm()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(System.DateTime.Now);
			int month = persianCalendar.GetMonth(System.DateTime.Now);
			int day = persianCalendar.GetDayOfMonth(System.DateTime.Now);

			string showCalendar =
				year.ToString() + "/" +
				month.ToString().PadLeft(2, '0') + "/" +
				day.ToString().PadLeft(2, '0');


			label1.Text = $"Current Day Is: {showCalendar}";

			//int year = int.Parse((maskedTextBox1.Text.Replace("/", string.Empty).Trim().Substring(0, 4)));
			//int month  = int.Parse((maskedTextBox1.Text.Replace("/", string.Empty).Trim().Substring(4, 2).PadLeft(2,'0')));
			//int day = int.Parse((maskedTextBox1.Text.Replace("/", string.Empty).Trim().Substring(6, 2)));		

			int futureDay = int.Parse(textBox1.Text);

			persianCalendar.GetYear(System.DateTime.Now.AddDays(futureDay));

			int nextYear = persianCalendar.GetYear(System.DateTime.Now.AddDays(futureDay)); ;
			int nextMonth = persianCalendar.GetMonth(System.DateTime.Now.AddDays(futureDay)); ;
			int nextDay = persianCalendar.GetDayOfMonth(System.DateTime.Now.AddDays(futureDay)); ;

			



			label2.Text =$"After {textBox1.Text} Day: {nextYear}/{nextMonth}/{nextDay}";
			
		}
	}
}

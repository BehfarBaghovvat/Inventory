namespace Financial_Order
{
	public partial class CapitalTurnoverChartUC : System.Windows.Forms.UserControl
	{
		//------------------------------------------------------------------------------------ Fields And Properties

		#region Properties

		#endregion /Properties


		//------------------------------------------------------------------------------------ Constracture
		public CapitalTurnoverChartUC()
		{
			InitializeComponent();
		}



		//------------------------------------------------------------------------------------ Event Controls

		#region DailyButton_Click
		private void DailyButton_Click(object sender, System.EventArgs e)
		{
			searchDailyPanel.BringToFront();
			searchMonthlyPanel.SendToBack();
			searchYearlyPanel.SendToBack();

		}
		#endregion /DailyButton_Click

		#region MonthlyButton_Click
		private void MonthlyButton_Click(object sender, System.EventArgs e)
		{
			searchMonthlyPanel.BringToFront();
			searchDailyPanel.SendToBack();
			searchYearlyPanel.SendToBack();
		}
		#endregion /MonthlyButton_Click

		#region YearlyButton_Click
		private void YearlyButton_Click(object sender, System.EventArgs e)
		{
			searchYearlyPanel.BringToFront();
			searchMonthlyPanel.SendToBack();
			searchDailyPanel.SendToBack();
		}

		private void dailyITextBox_Enter(object sender, System.EventArgs e)
		{

		}
		#endregion /YearlyButton_Click



		//------------------------------------------------------------------------------------ Private Methods



	}
}

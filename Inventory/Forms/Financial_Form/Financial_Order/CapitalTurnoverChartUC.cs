using System.Linq;

namespace Financial_Order
{
	public partial class CapitalTurnoverChartUC : System.Windows.Forms.UserControl
	{
		//------------------------------------------------------------------------------------ Fields And Properties

		#region Properties
		private class CurrentDate
		{
			public int CurrentYear { get; set; }
			public int CurrentMonth { get; set; }
			public int CurrentDay { get; set; }
		}

		private Models.DailyFinancialReport _dailyFinancialReport;
		public Models.DailyFinancialReport DailyFinancialReport
		{
			get
			{
				if (_dailyFinancialReport == null)
				{
					_dailyFinancialReport =
						new Models.DailyFinancialReport();
				}
				return _dailyFinancialReport;
			}
			set
			{
				_dailyFinancialReport = value;
			}
		}

		private Models.MonthlyFinancialReport _monthlyFinancialReport;
		public Models.MonthlyFinancialReport MonthlyFinancialReport
		{
			get 
			{
				if (_monthlyFinancialReport == null)
				{
					_monthlyFinancialReport =
						new Models.MonthlyFinancialReport();
				}
				return _monthlyFinancialReport;
			}
			set 
			{ 
				_monthlyFinancialReport = value;
			}
		}

		private Models.YearlyFinancialReport _yearlyFinancialReport;
		public Models.YearlyFinancialReport YearlyFinancialReport
		{
			get
			{
				if (_yearlyFinancialReport == null)
				{
					_yearlyFinancialReport =
						new Models.YearlyFinancialReport();
				}
				return _yearlyFinancialReport;
			}
			set
			{
				_yearlyFinancialReport = value;
			}
		}

		private CurrentDate currentDate = new CurrentDate();

		#endregion /Properties


		//------------------------------------------------------------------------------------ Constracture
		public CapitalTurnoverChartUC()
		{
			InitializeComponent();
			Initialize();
		}



		//------------------------------------------------------------------------------------ Event Controls

		#region --------------------------------------------------------------------------					Daily_Report

		#region DailyButton_Click
		private void DailyButton_Click(object sender, System.EventArgs e)
		{
			if (dailyButton.Checked == true)
			{
				return;
			}
			else
			{
				dailyButton.Checked = true;
				monthlyButton.Checked = false;
				yearlyButton.Checked = false;
				statisticsDisplayChart.Series.Clear();
				statisticsDisplayChart.AxisX.Clear();
				statisticsDisplayChart.AxisY.Clear();
				ViewDailyChart();
				searchDailyPanel.BringToFront();
				searchMonthlyPanel.SendToBack();
				searchYearlyPanel.SendToBack();
			}
		}
		#endregion /DailyButton_Click

		#region DayDailyOrderTextBox_Enter
		private void DayDailyOrderTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /DayDailyOrderTextBox_Enter

		#region DayDailyOrderTextBox_KeyPress
		private void DayDailyOrderTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /DayDailyOrderTextBox_KeyPress

		#region DayDailyOrderTextBox_TextChange
		private void DayDailyOrderTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(dayDailyOrderTextBox.Text))
			{
				DailyFinancialReport.Day = null;
				return;
			}
			else
			{
				DailyFinancialReport.Day = int.Parse(dayDailyOrderTextBox.Text);
			}
		}
		#endregion /DayDailyOrderTextBox_TextChange

		#region MonthOrderDailyComboBox_SelectedIndexChanged
		private void MonthDailyOrderComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (monthDailyOrderComboBox.SelectedIndex < 1)
			{
				DailyFinancialReport.Month = null;
				monthDailyOrderComboBox.ForeColor = System.Drawing.Color.Silver;
				return;
			}
			else
			{
				monthDailyOrderComboBox.ForeColor = System.Drawing.Color.Black;
				DailyFinancialReport.Month = monthDailyOrderComboBox.SelectedIndex ;
			}
		}
		#endregion /MonthOrderDailyComboBox_SelectedIndexChanged

		#region YearDailyOrderTextBox_Enter
		private void YearDailyOrderTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /YearDailyOrderTextBox_Enter

		#region YearDailyOrderTextBox_KeyPress
		private void YearDailyOrderTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /YearDailyOrderTextBox_KeyPress

		#region YearDailyOrderTextBox_TextChange
		private void YearDailyOrderTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(yearDailyOrderTextBox.Text))
			{
				DailyFinancialReport.Year = null;
				return;
			}
			else
			{
				DailyFinancialReport.Year = int.Parse(yearDailyOrderTextBox.Text);
			}
		}
		#endregion /YearDailyOrderTextBox_TextChange 

		#region ShowDailyChartButton_Click
		private void ShowDailyChartButton_Click(object sender, System.EventArgs e)
		{
			if (ValidationDateOfDay(DailyFinancialReport))
			{
				if (CheckValueDateDay(DailyFinancialReport, currentDate))
				{
					ShowDailyStatistics(DailyFinancialReport);
				}
			}
			else
			{
				return;
			}
		}
		#endregion /ShowDailyChartButton_Click



		#endregion /--------------------------------------------------------------------------					Daily_Report

		#region --------------------------------------------------------------------------					Monthly_Report

		#region MonthlyButton_Click
		private void MonthlyButton_Click(object sender, System.EventArgs e)
		{
			if (monthlyButton.Checked == true)
			{
				return;
			}
			else
			{
				dailyButton.Checked = false;
				monthlyButton.Checked = true;
				yearlyButton.Checked = false;
				statisticsDisplayChart.Series.Clear();
				statisticsDisplayChart.AxisX.Clear();
				statisticsDisplayChart.AxisY.Clear();
				ViewMonthlyChart();
				searchMonthlyPanel.BringToFront();
				searchDailyPanel.SendToBack();
				searchYearlyPanel.SendToBack();
			}
		}
		#endregion /MonthlyButton_Click

		#region MonthMonthlyOrderComboBox_SelectedIndexChanged
		private void MonthMonthlyOrderComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (monthMonthlyOrderComboBox.SelectedIndex < 1)
			{
				MonthlyFinancialReport.Month = null;
				monthMonthlyOrderComboBox.ForeColor = System.Drawing.Color.Gray;
				return;
			}
			else
			{
				monthMonthlyOrderComboBox.ForeColor = System.Drawing.Color.White;
				MonthlyFinancialReport.Month = monthMonthlyOrderComboBox.SelectedIndex;
			}
		}
		#endregion /MonthMonthlyOrderComboBox_SelectedIndexChanged

		#region YearMonthlyOrderTextBox_Enter
		private void YearMonthlyOrderTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /YearMonthlyOrderTextBox_Enter

		#region YearMonthlyOrderTextBox_KeyPress
		private void YearMonthlyOrderTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /YearMonthlyOrderTextBox_KeyPress

		#region YearMonthlyOrderTextBox_TextChange
		private void YearMonthlyOrderTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(yearMonthlyOrderTextBox.Text))
			{
				MonthlyFinancialReport.Year = null;
				return;
			}
			else
			{
				MonthlyFinancialReport.Year = int.Parse(yearMonthlyOrderTextBox.Text);
			}
		}
		#endregion /YearMonthlyOrderTextBox_TextChange

		#region ShowMonthlyChartButton_Click
		private void ShowMonthlyChartButton_Click(object sender, System.EventArgs e)
		{
			if (ValidationDateOfMonth(MonthlyFinancialReport))
			{
				if (CheckValueDateMonth(MonthlyFinancialReport, currentDate))
				{
					ShowMonthlyStatistics(MonthlyFinancialReport);
				}
			}
			else
			{
				return;
			}
		}
		#endregion /ShowMonthlyChartButton_Click



		#endregion /--------------------------------------------------------------------------					Monthly_Report

		#region --------------------------------------------------------------------------					Yearly_Report

		#region YearlyButton_Click
		private void YearlyButton_Click(object sender, System.EventArgs e)
		{
			if (yearlyButton.Checked == true)
			{
				return;
			}
			else
			{
				dailyButton.Checked = false;
				monthlyButton.Checked = false;
				yearlyButton.Checked = true;
				statisticsDisplayChart.Series.Clear();
				statisticsDisplayChart.AxisX.Clear();
				statisticsDisplayChart.AxisY.Clear();
				ViewYearlyChart();
				searchYearlyPanel.BringToFront();
				searchMonthlyPanel.SendToBack();
				searchDailyPanel.SendToBack();
			}
		}
		#endregion /YearlyButton_Click 

		#region YearlyYearOrderTextBox_Enter
		private void YearlyYearOrderTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /YearlyYearOrderTextBox_Enter

		#region YearlyYearOrderTextBox_KeyPress
		private void YearlyYearOrderTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /YearlyYearOrderTextBox_KeyPress

		#region YearlyYearOrderTextBox_TextChange
		private void YearlyYearOrderTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(yearlyYearOrderTextBox.Text))
			{
				YearlyFinancialReport.Year = null;
				return;
			}
			else
			{
				YearlyFinancialReport.Year = int.Parse(yearlyYearOrderTextBox.Text);
			}
		}
		#endregion /YearlyYearOrderTextBox_TextChange

		#region ShowYearlyChartButton_Click
		private void ShowYearlyChartButton_Click(object sender, System.EventArgs e)
		{
			if (ValidationDateOfYear(YearlyFinancialReport))
			{
				if (CheckValueDateYear(YearlyFinancialReport, currentDate))
				{
					ShowYearlyStatistics(YearlyFinancialReport);
				}
			}
			else
			{
				return;
			}
		}
		#endregion /ShowYearlyChartButton_Click



		#endregion /--------------------------------------------------------------------------					Yearly_Report



		//------------------------------------------------------------------------------------ Private Methods

		#region CheckValueDateDay
		/// <summary>
		/// محدوده روز و سال وارد شده توسط کاربر با روز و سال جاری سیستم بررسی میگردد
		/// </summary>
		/// <param name="_dailyFinancialReport"></param>
		/// <returns></returns>
		private bool CheckValueDateDay(Models.DailyFinancialReport _dailyFinancialReport, CurrentDate _currentDate)
		{
			if ((_dailyFinancialReport.Day >= 1 && _dailyFinancialReport.Day <= 31) && (_dailyFinancialReport.Year == _currentDate.CurrentYear))
			{
				return true;
			}
			else
			{
				if (_dailyFinancialReport.Day != _currentDate.CurrentDay)
				{
					Mbb.Windows.Forms.MessageBox.Show(
						$"محدوده انتخاب روز صحیح نمی باشد.\n لطفا روز صحیح را وارد نمایید.",
						$"خطای ورودی",
						Mbb.Windows.Forms.MessageBoxIcon.Error,
						Mbb.Windows.Forms.MessageBoxButtons.Ok);
					_dailyFinancialReport.Day = null;
					dayDailyOrderTextBox.Clear();
					dayDailyOrderTextBox.Focus();

				}
				if (_dailyFinancialReport.Year != _currentDate.CurrentYear)
				{
					Mbb.Windows.Forms.MessageBox.Show(
						$"سال درج شده صحیح نمی باشد.\n لطفا سال صحیح را وارد نمایید.",
						$"خطای ورودی",
						Mbb.Windows.Forms.MessageBoxIcon.Error,
						Mbb.Windows.Forms.MessageBoxButtons.Ok);
					_dailyFinancialReport.Year = null;
					yearDailyOrderTextBox.Clear();
					yearDailyOrderTextBox.Focus();
				}
				return false;
			}
		}
		#endregion /CheckValueDateDay

		#region CheckValueDateMonth
		/// <summary>
		/// محدوده سال وارد شده توسط کاربر با سال جاری سیستم بررسی میگردد
		/// </summary>
		/// <param name="_dailyFinancialReport"></param>
		/// <returns></returns>
		private bool CheckValueDateMonth(Models.MonthlyFinancialReport _monthlyFinancialReport, CurrentDate _currentDate)
		{
			if ((_monthlyFinancialReport.Year == _currentDate.CurrentYear))
			{
				return true;
			}
			else
			{
				if (_monthlyFinancialReport.Year != _currentDate.CurrentYear)
				{
					Mbb.Windows.Forms.MessageBox.Show(
						$"سال درج شده صحیح نمی باشد.\n لطفا سال صحیح را وارد نمایید.",
						$"خطای ورودی",
						Mbb.Windows.Forms.MessageBoxIcon.Error,
						Mbb.Windows.Forms.MessageBoxButtons.Ok);
					_monthlyFinancialReport.Year = null;
					yearDailyOrderTextBox.Clear();
					yearDailyOrderTextBox.Focus();
				}
				return false;
			}
		}
		#endregion /CheckValueDateMonth

		#region CheckValueDateYear
		/// <summary>
		/// محدوده سال وارد شده توسط کاربر با سال جاری سیستم بررسی میگردد
		/// </summary>
		/// <param name="_dailyFinancialReport"></param>
		/// <returns></returns>
		private bool CheckValueDateYear(Models.YearlyFinancialReport _yearlyFinancialReport, CurrentDate _currentDate)
		{
			if ((_yearlyFinancialReport.Year == _currentDate.CurrentYear))
			{
				return true;
			}
			else
			{
				if (_yearlyFinancialReport.Year != _currentDate.CurrentYear)
				{
					Mbb.Windows.Forms.MessageBox.Show(
						$"سال درج شده صحیح نمی باشد.\n لطفا سال صحیح را وارد نمایید.",
						$"خطای ورودی",
						Mbb.Windows.Forms.MessageBoxIcon.Error,
						Mbb.Windows.Forms.MessageBoxButtons.Ok);
					_yearlyFinancialReport.Year = null;
					yearDailyOrderTextBox.Clear();
					yearDailyOrderTextBox.Focus();
				}
				return false;
			}
		}
		#endregion /CheckValueDateYear

		#region Initialize
		/// <summary>
		/// تنظیمات ورودی اولیه 
		/// </summary>
		private void Initialize()
		{
			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			currentDate.CurrentDay = persianCalendar.GetDayOfMonth(System.DateTime.Now);
			currentDate.CurrentMonth = persianCalendar.GetMonth(System.DateTime.Now);
			currentDate.CurrentYear = persianCalendar.GetYear(System.DateTime.Now);

			financialDataGridView.DataSource = null;
			ViewDailyChart();
		}
		#endregion /Initialize

		#region ShowDailyStatistics
		/// <summary>
		/// نمایش نمودار روزانه
		/// </summary>
		/// <param name="_dailyFinancialReport"></param>
		private void ShowDailyStatistics(Models.DailyFinancialReport _dailyFinancialReport)
		{
			financialDataGridView.DataSource = null;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.DailyFinancialReport> listDailyFinancialReports = null;


				listDailyFinancialReports =
					dataBaseContext.DailyFinancialReports
					.Where(current => (current.Day == _dailyFinancialReport.Day) && (current.Month == _dailyFinancialReport.Month) && (current.Year == _dailyFinancialReport.Year))
					.OrderBy(current => current.Day)
					.ToList();

				if (listDailyFinancialReports.Count == 0)
				{
					Mbb.Windows.Forms.MessageBox.Show(
							text: "اطلاعاتی برای تاریخ مورد نظر یافت نگردید!",
							caption: "جستجوی ناموفق",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					dayDailyOrderTextBox.Clear();
					dayDailyOrderTextBox.Focus();
					monthDailyOrderComboBox.SelectedIndex = 0;
					yearDailyOrderTextBox.Clear();
					DailyFinancialReport = null;
					return;
				}
				else
				{
					financialDataGridView.DataSource = listDailyFinancialReports;
				}

			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}

			//------------------------------------------------------------------------------------ Show Statistics Result

			#region ShowStatisticsResult

			statisticsDisplayChart.Series.Clear();
			LiveCharts.SeriesCollection seriesViews = new LiveCharts.SeriesCollection();

			var days = (from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.DailyFinancialReport>
						select new { Day = o.Day, }).Distinct();

			#region Amounts Paid

			foreach (var day in days)
			{
				System.Collections.Generic.List<decimal> values = new System.Collections.Generic.List<decimal>();

				for (int hour = 00; hour <= 23; hour++)
				{
					decimal amountsPaid = 0;

					var data = from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.DailyFinancialReport>
							   where o.Day.Equals(day.Day) && o.Day.Equals(hour)
							   orderby o.Hour ascending
							   select new { o.Amounts_Paid, o.Hour, o.Minute };
					if (data.SingleOrDefault() != null)
					{
						amountsPaid = decimal.Parse(data.FirstOrDefault().Amounts_Paid.Replace("تومان",string.Empty).Replace(",",string.Empty).Trim());
					}
					values.Add(amountsPaid);

				}
				seriesViews.Add(new LiveCharts.Wpf.LineSeries() { Title = "مبالغ پرداختی", Values = new LiveCharts.ChartValues<decimal>(values)});
				statisticsDisplayChart.Series = seriesViews;
			}
			#endregion /Amounts Paid
			
			#region Amounts Received
			foreach (var day in days)
			{
				System.Collections.Generic.List<int> values = new System.Collections.Generic.List<int>();

				for (int hour = 00; hour <= 23; hour++)
				{
					int amountsReceived = 0;

					var data = from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.DailyFinancialReport>
							   where o.Day.Equals(day.Day) && o.Day.Equals(day)
							   orderby o.Hour ascending
							   select new { o.Amounts_Received, o.Hour, o.Minute};
					if (data.SingleOrDefault() != null)
					{
						amountsReceived = int.Parse(data.FirstOrDefault().Amounts_Received.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
					values.Add(amountsReceived);
				}
				seriesViews.Add(new LiveCharts.Wpf.LineSeries() { Title = "مبالغ دریافتی", Values = new LiveCharts.ChartValues<int>(values)});
				statisticsDisplayChart.Series = seriesViews;
			}
			#endregion /Amounts Received

			#endregion /ShowStatisticsResult
		}
		#endregion /ShowDailyStatistics

		#region ShowMonthlyStatistics
		/// <summary>
		/// نمایش نمودار مالی ماهانه
		/// </summary>
		/// <param name="_monthlyFinancialReport"></param>
		private void ShowMonthlyStatistics(Models.MonthlyFinancialReport _monthlyFinancialReport)
		{
			financialDataGridView.DataSource = null;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				string selectDate = 
					$"{_monthlyFinancialReport.Year}/{_monthlyFinancialReport.Month.ToString().PadLeft(2, '0')}";

				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.MonthlyFinancialReport> listMonthlyFinancialReports = null;


				listMonthlyFinancialReports =
					dataBaseContext.MonthlyFinancialReports
					.Where(current => current.Register_Date.Contains(selectDate))
					.OrderBy(current => current.Month)
						.ToList();

				if (listMonthlyFinancialReports.Count == 0)
				{
					Mbb.Windows.Forms.MessageBox.Show(
							text: "اطلاعاتی برای تاریخ مورد نظر یافت نگردید!",
							caption: "جستجوی ناموفق",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					
					monthMonthlyOrderComboBox.SelectedIndex = 0;
					yearMonthlyOrderTextBox.Clear();
					MonthlyFinancialReport = null;
					return;
				}
				else
				{
					financialDataGridView.DataSource = listMonthlyFinancialReports;
				}

			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}

			#region ViewMonthlyFinancial
			statisticsDisplayChart.Series.Clear();
			LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

			var months = (from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.MonthlyFinancialReport>
						  select new { Month = o.Month, }).Distinct();

			#region Sum Amount Paid Of Day
			foreach (var month in months)
			{
				System.Collections.Generic.List<decimal> values = new System.Collections.Generic.List<decimal>();

				for (int day = 1; day <= 31; day++)
				{
					decimal totalPrice = 0;

					var data = from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.MonthlyFinancialReport>
							   where o.Month.Equals(month.Month) && o.Day.Equals(day)
							   orderby o.Day ascending
							   select new { o.Sum_Amount_Paid_Of_Day, o.Day };
					if (data.SingleOrDefault() != null)
					{
						totalPrice = 
							decimal.Parse(data.FirstOrDefault().Sum_Amount_Paid_Of_Day.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
					values.Add(totalPrice);
				}
				series.Add(new LiveCharts.Wpf.LineSeries() { Title = $"جمع مبلغ پرداختی روز", Values = new LiveCharts.ChartValues<decimal>(values) });
				statisticsDisplayChart.Series = series;
			}
			#endregion /Sum Amount Paid Of Day

			#region Sum Amount Payment Of Day
			foreach (var month in months)
			{
				System.Collections.Generic.List<decimal> values = new System.Collections.Generic.List<decimal>();

				for (int day = 1; day <= 31; day++)
				{
					decimal paymentAmount = 0;

					var data = from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.MonthlyFinancialReport>
							   where o.Month.Equals(month.Month) && o.Day.Equals(day)
							   orderby o.Day ascending
							   select new { o.Sum_Amount_Payment_Of_Day, o.Day };
					if (data.SingleOrDefault() != null)
					{
						paymentAmount = 
							decimal.Parse(data.FirstOrDefault().Sum_Amount_Payment_Of_Day.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
					values.Add(paymentAmount);

				}
				series.Add(new LiveCharts.Wpf.LineSeries() { Title = "جمع مبلغ قابل پرداخت روز", Values = new LiveCharts.ChartValues<decimal>(values) });
				statisticsDisplayChart.Series = series;
			}
			#endregion /Sum Amount Payment Of Day

			#region Sum Amounts Received Of Day
			foreach (var month in months)
			{
				System.Collections.Generic.List<decimal> values = new System.Collections.Generic.List<decimal>();

				for (int day = 1; day <= 31; day++)
				{
					decimal remainingAmount = 0;

					var data = from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.MonthlyFinancialReport>
							   where o.Month.Equals(month.Month) && o.Day.Equals(day)
							   orderby o.Day ascending
							   select new { o.Sum_Amounts_Received_Of_Day, o.Day };
					if (data.SingleOrDefault() != null)
					{
						remainingAmount =
							decimal.Parse(data.FirstOrDefault().Sum_Amounts_Received_Of_Day.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
					values.Add(remainingAmount);

				}
				series.Add(new LiveCharts.Wpf.LineSeries() { Title = "جمع مبلغ دریافتی روز", Values = new LiveCharts.ChartValues<decimal>(values) });
				statisticsDisplayChart.Series = series;
			}
			#endregion /Sum Amounts Received Of Day

			#region Sum Amounts Remaining Of Day
			foreach (var month in months)
			{
				System.Collections.Generic.List<decimal> values = new System.Collections.Generic.List<decimal>();

				for (int day = 1; day <= 31; day++)
				{
					decimal remainingAmount = 0;

					var data = from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.MonthlyFinancialReport>
							   where o.Month.Equals(month.Month) && o.Day.Equals(day)
							   orderby o.Day ascending
							   select new { o.Sum_Amounts_Remaining_Of_Day, o.Day };
					if (data.SingleOrDefault() != null)
					{
						remainingAmount =
							decimal.Parse(data.FirstOrDefault().Sum_Amounts_Remaining_Of_Day.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
					values.Add(remainingAmount);

				}
				series.Add(new LiveCharts.Wpf.LineSeries() { Title = "جمع مبلغ باقیمانده روز", Values = new LiveCharts.ChartValues<decimal>(values) });
				statisticsDisplayChart.Series = series;
			}
			#endregion /Sum Amounts Remaining Of Day

			#endregion /ViewMonthlyFinancial
		}
		#endregion /ShowMonthlyStatistics

		#region ShowYearlyStatistics
		/// <summary>
		/// نمایش نمودار سالانه
		/// </summary>
		/// <param name="_yearlyFinancialReport"></param>
		private void ShowYearlyStatistics(Models.YearlyFinancialReport _yearlyFinancialReport)
		{
			financialDataGridView.DataSource = null;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				string selectDate =
					$"{_yearlyFinancialReport.Year}";

				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.YearlyFinancialReport> listyearlyFinancialReports = null;


				listyearlyFinancialReports =
					dataBaseContext.YearlyFinancialReports
					.Where(current => current.Register_Date.Contains(selectDate))
					.OrderBy(current => current.Month)
						.ToList();

				if (listyearlyFinancialReports.Count == 0)
				{
					Mbb.Windows.Forms.MessageBox.Show(
							text: "اطلاعاتی برای تاریخ مورد نظر یافت نگردید!",
							caption: "جستجوی ناموفق",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					yearlyYearOrderTextBox.Clear();
					yearlyYearOrderTextBox.Focus();
					return;
				}
				else
				{
					financialDataGridView.DataSource = listyearlyFinancialReports;
				}

			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}

			#region ViewMonthlyFinancial
			
			LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

			var years = (from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.YearlyFinancialReport>
						  select new { Year = o.Year, }).Distinct();

			#region Sum Amount Paid Of Month
			foreach (var year in years)
			{
				System.Collections.Generic.List<decimal> values = new System.Collections.Generic.List<decimal>();

				for (int month = 1; month <= 12; month++)
				{
					decimal totalPrice = 0;

					var data = from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.YearlyFinancialReport>
							   where o.Year.Equals(year.Year) && o.Month.Equals(month)
							   orderby o.Month ascending
							   select new { o.Sum_Amount_Paid_Of_Month, o.Month };
					if (data.SingleOrDefault() != null)
					{
						totalPrice =
							decimal.Parse(data.FirstOrDefault().Sum_Amount_Paid_Of_Month.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
					values.Add(totalPrice);
				}
				series.Add(new LiveCharts.Wpf.LineSeries() { Title = $"جمع مبلغ پرداختی ماه", Values = new LiveCharts.ChartValues<decimal>(values)});
				statisticsDisplayChart.Series = series;
			}
			#endregion /Sum Amount Paid Of Month

			#region Sum Amount Payment Of Month
			foreach (var year in years)
			{
				System.Collections.Generic.List<decimal> values = new System.Collections.Generic.List<decimal>();

				for (int month = 1; month <= 12; month++)
				{
					decimal paymentAmount = 0;

					var data = from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.YearlyFinancialReport>
							   where o.Year.Equals(year.Year) && o.Month.Equals(month)
							   orderby o.Month ascending
							   select new { o.Sum_Amount_Payment_Of_Month, o.Month };
					if (data.SingleOrDefault() != null)
					{
						paymentAmount =
							decimal.Parse(data.FirstOrDefault().Sum_Amount_Payment_Of_Month.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
					values.Add(paymentAmount);
				}
				series.Add(new LiveCharts.Wpf.LineSeries() { Title = "جمع مبلغ قابل پرداخت ماه", Values = new LiveCharts.ChartValues<decimal>(values) });
				statisticsDisplayChart.Series = series;
			}
			#endregion /Sum Amount Payment Of Month

			#region Sum Amounts Received Of Month
			foreach (var year in years)
			{
				System.Collections.Generic.List<decimal> values = new System.Collections.Generic.List<decimal>();

				for (int month = 1; month <= 12; month++)
				{
					decimal remainingAmount = 0;

					var data = from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.YearlyFinancialReport>
							   where o.Year.Equals(year.Year) && o.Month.Equals(month)
							   orderby o.Month ascending
							   select new { o.Sum_Amounts_Received_Of_Month, o.Month };
					if (data.SingleOrDefault() != null)
					{
						remainingAmount =
							decimal.Parse(data.FirstOrDefault().Sum_Amounts_Received_Of_Month.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
					values.Add(remainingAmount);
				}
				series.Add(new LiveCharts.Wpf.LineSeries() { Title = "جمع مبلغ دریافتی ماه", Values = new LiveCharts.ChartValues<decimal>(values) });
				statisticsDisplayChart.Series = series;
			}
			#endregion /Sum Amounts Received Of Month

			#region Sum Amounts Remaining Of Month
			foreach (var year in years)
			{
				System.Collections.Generic.List<decimal> values = new System.Collections.Generic.List<decimal>();

				for (int month = 1; month <= 12; month++)
				{
					decimal remainingAmount = 0;

					var data = from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.YearlyFinancialReport>
							   where o.Year.Equals(year.Year) && o.Month.Equals(month)
							   orderby o.Month ascending
							   select new { o.Sum_Amounts_Remaining_Of_Month, o.Month };
					if (data.SingleOrDefault() != null)
					{
						remainingAmount =
							decimal.Parse(data.FirstOrDefault().Sum_Amounts_Remaining_Of_Month.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
					}
					values.Add(remainingAmount);
				}
				series.Add(new LiveCharts.Wpf.LineSeries() { Title = "جمع مبلغ باقیمانده ماه", Values = new LiveCharts.ChartValues<decimal>(values)});
				statisticsDisplayChart.Series = series;
			}
			#endregion /Sum Amounts Remaining Of Month

			#endregion /ViewMonthlyFinancial


		}
		#endregion /ShowYearlyStatistics

		#region ValidationDateOfDay
		/// <summary>
		/// مقادیر فیلدهای پنل روزانه بررسی می گردد.
		/// </summary>
		/// <param name="_dailyFinancialReport"></param>
		/// <returns></returns>
		private bool ValidationDateOfDay(Models.DailyFinancialReport _dailyFinancialReport)
		{
			string errorMessage = null;
			if (string.IsNullOrEmpty(_dailyFinancialReport.Day.ToString()) || _dailyFinancialReport.Day == 0)
			{
				errorMessage = $"لطفا فیلد روز را کامل نمایید";
			}
			else if (string.IsNullOrEmpty(_dailyFinancialReport.Month.ToString()) || _dailyFinancialReport.Month == 0)
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += $"لطفا یک ماه را انتخاب نمایید.";
			}
			else if (string.IsNullOrEmpty(_dailyFinancialReport.Year.ToString()) || _dailyFinancialReport.Year == 0)
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += $"لطفا سال مورد نظر را انتخاب کنید.";
			}

			//--------------------------------------------------------------------------------------------------------------------------
			if (!string.IsNullOrEmpty(errorMessage))
			{
				if (string.IsNullOrEmpty(_dailyFinancialReport.Day.ToString()) || _dailyFinancialReport.Day == 0)
				{
					dayDailyOrderTextBox.Focus();
				}
				if (string.IsNullOrEmpty(_dailyFinancialReport.Month.ToString()) || _dailyFinancialReport.Month == 0)
				{
					monthDailyOrderComboBox.Focus();
				}
				if (string.IsNullOrEmpty(_dailyFinancialReport.Year.ToString()) || _dailyFinancialReport.Year == 0)
				{
					yearDailyOrderTextBox.Focus();
				}

				Mbb.Windows.Forms.MessageBox.Show(
					errorMessage,
					  $"خطای ورودی",
					  Mbb.Windows.Forms.MessageBoxIcon.Error,
					  Mbb.Windows.Forms.MessageBoxButtons.Ok);
				return false;
			}
			else
			{
				return true;
			}
		}
		#endregion /ValidationDateOfDay

		#region ValidationDateOfMonth
		/// <summary>
		/// مقادیر فیلدهای پنل ماهانه بررسی میگردد
		/// </summary>
		/// <returns></returns>
		private bool ValidationDateOfMonth(Models.MonthlyFinancialReport _monthlyFinancialReport)
		{
			string errorMessage = null;
			if (string.IsNullOrEmpty(_monthlyFinancialReport.Month.ToString()) || _monthlyFinancialReport.Month == 0)
			{
				errorMessage += $"لطفا یک ماه را انتخاب نمایید.";
			}
			else if (string.IsNullOrEmpty(_monthlyFinancialReport.Year.ToString()) || _monthlyFinancialReport.Year == 0)
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += $"لطفا سال مورد نظر را انتخاب کنید.";
			}

			//--------------------------------------------------------------------------------------------------------------------------
			if (!string.IsNullOrEmpty(errorMessage))
			{
				if (string.IsNullOrEmpty(_dailyFinancialReport.Month.ToString()) || _dailyFinancialReport.Month == 0)
				{
					monthDailyOrderComboBox.Focus();
				}
				if (string.IsNullOrEmpty(_dailyFinancialReport.Year.ToString()) || _dailyFinancialReport.Year == 0)
				{
					yearDailyOrderTextBox.Focus();
				}

				Mbb.Windows.Forms.MessageBox.Show(
					errorMessage,
					  $"خطای ورودی",
					  Mbb.Windows.Forms.MessageBoxIcon.Error,
					  Mbb.Windows.Forms.MessageBoxButtons.Ok);
				return false;
			}
			else
			{
				return true;
			}
			
		}
		#endregion /ValidationDateOfMonth

		#region ValidationDateOfYear
		/// <summary>
		/// مقادیر فیلد پنل سالانه، بررسی می گردد
		/// </summary>
		/// <returns></returns>
		private bool ValidationDateOfYear(Models.YearlyFinancialReport _yearlyFinancialReport)
		{
			return true;
		}
		#endregion /ValidationDateOfYear

		#region ViewDailyChart
		/// <summary>
		/// تنظیمات اولیه نمودار، برای نمایش نمودار روزانه
		/// </summary>
		private void ViewDailyChart()
		{
			dailyFinancialReportBindingSource.DataSource = new System.Collections.Generic.List<Models.DailyFinancialReport>();
			statisticsDisplayChart.Series.Clear();
			statisticsDisplayChart.AxisX.Clear();
			statisticsDisplayChart.AxisX.Add(new LiveCharts.Wpf.Axis
			{
				Title = "ساعات روز",
				Labels = new[]
				{ "00", "01", "02", "03", "04", "05",
					"06", "07", "08", "09", "10", "11",
					"12", "13", "14", "15", "16", "17",
					"18", "19", "20", "21", "22", "23",}
			});
			statisticsDisplayChart.AxisY.Clear();
			statisticsDisplayChart.AxisY.Add(new LiveCharts.Wpf.Axis
			{
				Title = "درآمد",
				LabelFormatter = value => value.ToString()
			});

			statisticsDisplayChart.LegendLocation = LiveCharts.LegendLocation.Right;
		}
		#endregion /ViewDailyChart

		#region ViewMonthlyChart
		/// <summary>
		/// تنظیمات اولیه نمودار، برای نمایش نمودار ماهیانه
		/// </summary>
		private void ViewMonthlyChart()
		{
			monthlyFinancialReportBindingSource.DataSource =
				new System.Collections.Generic.List<Models.MonthlyFinancialReport>();
			statisticsDisplayChart.Series.Clear();
			statisticsDisplayChart.AxisX.Clear();
			statisticsDisplayChart.AxisX.Add(new LiveCharts.Wpf.Axis
			{
				Title = "روز های ماه",
				Labels = new[]
				{ "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
					"11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
					"21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31",}
			});
			statisticsDisplayChart.AxisY.Clear();
			statisticsDisplayChart.AxisY.Add(new LiveCharts.Wpf.Axis
			{
				Title = "درآمد",
				LabelFormatter = value => value.ToString()
			});

			statisticsDisplayChart.LegendLocation = LiveCharts.LegendLocation.Right;
		}
		#endregion /ViewMonthlyChart

		#region ViewYearlyChart
		/// <summary>
		/// تنظیمات اولیه نمودار برای نمایش نمودار سالانه
		/// </summary>
		private void ViewYearlyChart()
		{
			yearlyFinancialReportBindingSource.DataSource = new System.Collections.Generic.List<Models.YearlyFinancialReport>();

			
			
			statisticsDisplayChart.AxisX.Add(new LiveCharts.Wpf.Axis
			{
				Title = "Month Days",
				Labels = new[]
				{ "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور",
					"مهر", "آبان", "آذر", "دی", "بهمن", "اسفند",}
			});

			
			statisticsDisplayChart.AxisY.Add(new LiveCharts.Wpf.Axis
			{
				Title = "Amount",
				LabelFormatter = value => value.ToString("C"),
			});
			statisticsDisplayChart.LegendLocation = LiveCharts.LegendLocation.Right;
		}




		#endregion /ViewYearlyChart	
	}
}

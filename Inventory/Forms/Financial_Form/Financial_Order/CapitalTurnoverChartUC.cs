using Models;
using System.Linq;
using System.Windows.Media;

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

		private CurrentDate currentDate = new CurrentDate();





		#endregion /Properties


		//------------------------------------------------------------------------------------ Constracture
		public CapitalTurnoverChartUC()
		{
			InitializeComponent();

			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			currentDate.CurrentDay = persianCalendar.GetDayOfMonth(System.DateTime.Now);
			currentDate.CurrentMonth = persianCalendar.GetMonth(System.DateTime.Now);
			currentDate.CurrentYear = persianCalendar.GetYear(System.DateTime.Now);

			financialDataGridView.DataSource = null;
			ViewDailyChart();
		}



		//------------------------------------------------------------------------------------ Event Controls

		#region --------------------------------------------------------------------------					Daily_Report

		#region DailyButton_Click
		private void DailyButton_Click(object sender, System.EventArgs e)
		{
			searchDailyPanel.BringToFront();
			searchMonthlyPanel.SendToBack();
			searchYearlyPanel.SendToBack();
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
		private void MonthOrderDailyComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (monthOrderDailyComboBox.SelectedIndex < 1)
			{
				DailyFinancialReport.Month = null;
				monthOrderDailyComboBox.ForeColor = System.Drawing.Color.Gray;
				return;
			}
			else
			{
				monthOrderDailyComboBox.ForeColor = System.Drawing.Color.White;
				DailyFinancialReport.Month = monthOrderDailyComboBox.SelectedIndex;
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
				if (CheckValueDate(DailyFinancialReport, currentDate))
				{

				}
			}
			else
			{
				return;
			}
		}
		#endregion /ShowDailyChartButton_Click


		#endregion /--------------------------------------------------------------------------					Daily_Report









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
		#endregion /YearlyButton_Click



		//------------------------------------------------------------------------------------ Private Methods

		#region CheckValueDate
		/// <summary>
		/// روز و سال وارد شده توسط کاربر با روز و سال جاری سیستم بررسی میگردد
		/// </summary>
		/// <param name="_dailyFinancialReport"></param>
		/// <returns></returns>
		private bool CheckValueDate(DailyFinancialReport _dailyFinancialReport, CurrentDate _currentDate)
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
		#endregion /CheckValueDate

		#region ShowDailyStatistics
		/// <summary>
		/// نمایش نمودار روزانه
		/// </summary>
		/// <param name="_dailyFinancialReport"></param>
		private void ShowDailyStatistics(Models.DailyFinancialReport _dailyFinancialReport)
		{
			ViewDailyChart();

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
					monthOrderDailyComboBox.SelectedIndex = 0;
					yearDailyOrderTextBox.Clear();
					DailyFinancialReport = null;
					return;
				}
				else
				{
					financialDataGridView.DataSource = null;
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
				System.Collections.Generic.List<int> values = new System.Collections.Generic.List<int>();

				for (int hour = 00; hour <= 23; hour++)
				{
					int amountsPaid = 0;

					var data = from o in financialDataGridView.DataSource as System.Collections.Generic.List<Models.DailyFinancialReport>
							   where o.Day.Equals(day.Day) && o.Day.Equals(hour)
							   orderby o.Hour ascending
							   select new { o.Amounts_Paid, o.Hour, o.Minute };
					if (data.SingleOrDefault() != null)
					{
						amountsPaid = int.Parse(data.FirstOrDefault().Amounts_Paid);
					}
					values.Add(amountsPaid);

				}
				seriesViews.Add(new LiveCharts.Wpf.LineSeries() { Title = "مبالغ پرداختی", Values = new LiveCharts.ChartValues<int>(values)});
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
						amountsReceived = int.Parse(data.FirstOrDefault().Amounts_Received);
					}
					values.Add(amountsReceived);

				}
				seriesViews.Add(new LiveCharts.Wpf.LineSeries() { Title = "مبالغ دریافتی", Values = new LiveCharts.ChartValues<int>(values) });
				statisticsDisplayChart.Series = seriesViews;
			}
			#endregion /Amounts Received

			#endregion /ShowStatisticsResult








		}
		#endregion /ShowDailyStatistics

		#region ShowMonthlyStatistics
		private void ShowMonthlyStatistics(Models.MonthlyFinancialReport _monthlyFinancialReport)
		{
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

					//dayDailyOrderTextBox.Clear();
					//dayDailyOrderTextBox.Focus();
					//monthOrderDailyComboBox.SelectedIndex = 0;
					//yearDailyOrderTextBox.Clear();
					//DailyFinancialReport = null;
					return;
				}
				else
				{
					financialDataGridView.DataSource = null;
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
		}
		#endregion /ShowMonthlyStatistics

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
					monthOrderDailyComboBox.Focus();
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
			return true;
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

			statisticsDisplayChart.Series.Clear();
			statisticsDisplayChart.AxisX.Clear();
			statisticsDisplayChart.AxisX.Add(new LiveCharts.Wpf.Axis
			{
				Title = "Month Days",
				Labels = new[]
				{ "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور",
					"مهر", "آبان", "آذر", "دی", "بهمن", "اسفند",}
			});

			statisticsDisplayChart.AxisY.Clear();
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

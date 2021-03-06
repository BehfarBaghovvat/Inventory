namespace Models
{
	/// <summary>
	/// تنظیم پشتیبان گیر خودکار
	/// </summary>
	public class BackupSetting
	{
		public enum TimeInterval
		{
			روزانه,
			هفتگی,
			ماهیانه,
		}

		public BackupSetting()
		{

		}
		/// <summary>
		/// وضعیت پشتیبان خودکار
		/// </summary>
		#region Auto_Backup
		//-----DisplayName field for Auto_Backup
		[System.ComponentModel.DisplayName(displayName: "وضعیت پشتیبان خودکار")]
		public bool Auto_Backup { get; set; }
		#endregion /Auto_Backup

		/// <summary>
		/// روزهای هفته
		/// </summary>
		#region Days_Of_Week
		//-----DisplayName field for Days_Of_Week
		[System.ComponentModel.DisplayName(displayName: "روزهای هفته")]
		public System.DayOfWeek Days_Of_Week { get; set; }
		#endregion /Days_Of_Week

		/// <summary>
		/// روز چندم ماه
		/// </summary>
		#region Day_Of_Month
		//-----DisplayName field for Day_Of_Month
		[System.ComponentModel.DisplayName(displayName: "روز چندم ماه")]
		public int? Day_Of_Month { get; set; }
		#endregion Day_Of_Month

		/// <summary>
		/// ساعت روز
		/// </summary>
		#region Hour
		//-----DisplayName field for Hour
		[System.ComponentModel.DisplayName(displayName: "ساعت روز")]
		public int? Hour { get; set; }
		#endregion /Hour

		/// <summary>
		/// ردیف
		/// </summary>
		#region Id
		//-----DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//-----Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }
		#endregion /Id

		/// <summary>
		/// دقیقه روز
		/// </summary>
		#region Minutes
		//-----DisplayName field for Minutes
		[System.ComponentModel.DisplayName(displayName: "دقیقه روز")]
		public int? Minutes { get; set; }
		#endregion /Minutes

		/// <summary>
		/// بازه زمانی
		/// </summary>
		#region Time_Interval
		//-----DisplayName field for Tiem_Interval
		[System.ComponentModel.DisplayName(displayName: "بازه زمانی")]
		public TimeInterval Time_Interval { get; set; }
		#endregion /Time_Interval

	}
}

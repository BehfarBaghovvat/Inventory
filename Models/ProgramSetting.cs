namespace Models
{
	/// <summary>
	/// تنظیمات برنامه
	/// </summary>
	public class ProgramSetting
	{
		public ProgramSetting(): base()
		{

		}

		/// <summary>
		/// اطلاعیه سرمایه
		/// </summary>
		#region Capital_Display
		//-----DisplayName field for Capital_Display
		[System.ComponentModel.DisplayName(displayName: "اطلاعیه سرمایه")]
		public bool Capital_Notification { get; set; }
		#endregion /Capital_Display

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
		/// فاصله زمانی
		/// </summary>
		#region Interval
		//-----DisplayName field for Interval
		[System.ComponentModel.DisplayName(displayName: "فاصله زمانی")]
		public double Interval { get; set; }
		#endregion /Interval


		/// <summary>
		/// تنظیم بازیه زمانی
		/// </summary>
		#region Interval
		//-----DisplayName field for Interval_Check
		[System.ComponentModel.DisplayName(displayName: "تنظیم بازیه زمانی")]
		public bool Interval_Check { get; set; }
		#endregion /Interval

	}
}

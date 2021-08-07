namespace Models
{
	/// <summary>
	/// گزارش مالی روزانه
	/// </summary>
	public class DailyFinancialReport
	{
		public DailyFinancialReport()
		{

		}

		/// <summary>
		/// مبالغ پرداختی
		/// </summary>
		#region Amounts_Paid
		//----- Display Name Amounts_Paid
		[System.ComponentModel.DisplayName(displayName: "مبالغ پرداختی")]
		//-----StringLength Amounts_Paid
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Amounts_Paid { get; set; }
		#endregion /Amounts_Paid

		/// <summary>
		/// مبالغ دریافتی
		/// </summary>
		#region Amounts_Received
		//----- Display Name Amounts_Received
		[System.ComponentModel.DisplayName(displayName: "مبالغ دریافتی")]
		//-----StringLength Amounts_Received
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Amounts_Received { get; set; }
		#endregion /Amounts_Received

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
		/// تاریخ ثبت
		/// </summary>
		#region Register_Date
		//-----DisplayName field for RegistrationDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Register_Date { get; set; }
		#endregion /Register_Date

		/// <summary>
		/// زمان ثبت
		/// </summary>
		#region Register_Time
		//-----DisplayName field for RegistrationTime
		[System.ComponentModel.DisplayName(displayName: "زمان ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Register_Time { get; set; }
		#endregion /Register_Time

		#region Date
		/// <summary>
		/// سال
		/// </summary>
		public int? Year { get; set; }
		/// <summary>
		/// ماه
		/// </summary>
		public int? Month { get; set; }
		/// <summary>
		/// روز
		/// </summary>
		public int? Day { get; set; }
		#endregion /Date

		#region Time
		/// <summary>
		/// ساعت
		/// </summary>
		public int? Hour { get; set; }
		/// <summary>
		/// دقیقه
		/// </summary>
		public int? Minute { get; set; }
		/// <summary>
		/// ثانیه
		/// </summary>
		public int? Second { get; set; }
		#endregion /Time
	}
}

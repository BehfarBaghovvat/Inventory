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

		#region Amounts_Paid
		//----- Display Name Amounts_Paid
		[System.ComponentModel.DisplayName(displayName: "مبالغ پرداختی")]
		//-----Allow Empty Amounts_Paid
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Amounts_Paid
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Amounts_Paid { get; set; }
		#endregion /Amounts_Paid

		#region Amounts_Received
		//----- Display Name Amounts_Received
		[System.ComponentModel.DisplayName(displayName: "مبالغ دریافتی")]
		//-----Allow Empty Amounts_Received
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Amounts_Received
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Amounts_Received { get; set; }
		#endregion /Amounts_Received

		#region Id
		//-----DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//-----Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }
		#endregion /Id

		#region Registration_Date
		//-----DisplayName field for RegistrationDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Registration_Date { get; set; }
		#endregion /Registration_Date

		#region Registration_Time
		//-----DisplayName field for RegistrationTime
		[System.ComponentModel.DisplayName(displayName: "زمان ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Registration_Time { get; set; }
		#endregion /Registration_Time

		#region Date
		public int Year { get; set; }
		public int Month { get; set; }
		public int Day { get; set; }
		#endregion /Date

		#region Time
		public int Hour { get; set; }
		public int Minute { get; set; }
		public int Second { get; set; }
		#endregion /Time
	}
}

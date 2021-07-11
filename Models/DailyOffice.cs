namespace Models
{
	/// <summary>
	/// دفتر روزنامه
	/// </summary>
	public class DailyOffice
	{
		public DailyOffice()
		{

		}

		#region Agent
		//-----DisplayName field for Description
		[System.ComponentModel.DisplayName(displayName: "عامل")]
		//--Lenght Description
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30)]
		public string Agent { get; set; }
		#endregion /Agent

		#region Amount_Paid
		//-----DisplayName field for Amount_Payment
		[System.ComponentModel.DisplayName(displayName: "پرداختی")]
		public string Amount_Paid { get; set; }
		#endregion /Amount_Paid

		#region Amount_Received
		//-----DisplayName field for Amount_Received
		[System.ComponentModel.DisplayName(displayName: "دریافتی")]
		public string Amount_Received { get; set; }
		#endregion /Amount_Received

		#region Description
		//-----DisplayName field for Description
		[System.ComponentModel.DisplayName(displayName: "شرح")]
		//--Lenght Description
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 5000)]
		public string Description { get; set; }
		#endregion /Description

		#region Id
		//--DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//--Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }
		#endregion /Id

		#region Invoice_Serial_Numvber
		//--DisplayName field for Invoice_Serial_Numvber
		[System.ComponentModel.DisplayName(displayName: "شماره فاکتور")]
		//--Lenght Invoice_Serial_Numvber
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Invoice_Serial_Numvber { get; set; }
		#endregion /Invoice_Serial_Numvber

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
	}
}

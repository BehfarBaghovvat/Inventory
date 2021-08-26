namespace Models
{
	/// <summary>
	/// دفتر روزنامه
	/// </summary>
	public class GeneralJournal
	{
		public GeneralJournal()
		{

		}

		/// <summary>
		/// عامل
		/// </summary>
		#region Agent
		//-----DisplayName field for Description
		[System.ComponentModel.DisplayName(displayName: "عامل")]
		//--Lenght Description
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30)]
		public string Agent { get; set; }
		#endregion /Agent

		/// <summary>
		/// مبلغ پرداختی
		/// </summary>
		#region Amount_Paid
		//-----DisplayName field for Amount_Payment
		[System.ComponentModel.DisplayName(displayName: "پرداختی")]
		public string Amount_Paid { get; set; }
		#endregion /Amount_Paid

		/// <summary>
		/// مبلغ دریافتی
		/// </summary>
		#region Amount_Received
		//-----DisplayName field for Amount_Received
		[System.ComponentModel.DisplayName(displayName: "دریافتی")]
		public string Amount_Received { get; set; }
		#endregion /Amount_Received

		/// <summary>
		/// توضیحات
		/// </summary>
		#region Description
		//-----DisplayName field for Description
		[System.ComponentModel.DisplayName(displayName: "شرح")]
		//--Lenght Description
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 5000)]
		public string Description { get; set; }
		#endregion /Description

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
		/// شماره فاکتور
		/// </summary>
		#region Invoice_Serial_Numvber
		//--DisplayName field for Invoice_Serial_Numvber
		[System.ComponentModel.DisplayName(displayName: "شماره فاکتور")]
		//--Lenght Invoice_Serial_Numvber
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Invoice_Serial_Numvber { get; set; }
		#endregion /Invoice_Serial_Numvber

		/// <summary>
		/// تاریخ ثبت
		/// </summary>
		#region Registration_Date
		//-----DisplayName field for RegistrationDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Registration_Date { get; set; }
		#endregion /Registration_Date

		/// <summary>
		/// زمان ثبت
		/// </summary>
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

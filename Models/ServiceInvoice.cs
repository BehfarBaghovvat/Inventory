namespace Models
{
	/// <summary>
	/// فاکتور سرویس
	/// </summary>
	public class ServiceInvoice
	{
		public ServiceInvoice()
		{

		}

		/// <summary>
		/// نام مشتری
		/// </summary>
		#region Client_Name
		/// <summary>
		/// نام مشتری یا درخواست کننده سرویس
		/// </summary>
		//-----DisplayName field for Client_Name
		[System.ComponentModel.DisplayName(displayName: "نام مشتری")]
		//--Lenght Client_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Client_Name { get; set; }
		#endregion /Client_Name

		/// <summary>
		/// ثبت کیلومتر فعلی
		/// </summary>
		#region Current_Kilometer
		//-----DisplayName field for Service_Date
		[System.ComponentModel.DisplayName(displayName: "کیلومتر فعلی")]
		//--Lenght Service_Date
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]
		public string Current_Kilometer { get; set; }
		#endregion /Current_Kilometer

		/// <summary>
		/// ردیف
		/// </summary>
		#region Id
		//-----DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//-----Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public uint Id { get; set; }
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
		/// شماره پلاک وسیله نقلیه
		/// </summary>
		#region License_Plate
		[System.ComponentModel.DisplayName(displayName: "پلاک وسیله نقیله")]
		//--Lenght LicensePlate
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 11)]
		public string License_Plate { get; set; }
		#endregion /License_Plate

		/// <summary>
		/// ثبت کیلومتر بعدی
		/// </summary>
		#region Next_Kilometer
		//-----DisplayName field for Service_Date
		[System.ComponentModel.DisplayName(displayName: "کیلومتر بعدی")]
		//--Lenght Service_Date
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength:20)]
		public string Next_Kilometer { get; set; }
		#endregion /Next_Kilometer

		/// <summary>
		/// شماره تماس
		/// </summary>
		#region Phone_Number
		//-----DisplayName field for Phone_Number
		[System.ComponentModel.DisplayName(displayName: "شماره تماس")]
		//--Lenght Phone_Number
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Phone_Number { get; set; }
		#endregion /Phone_Number

		/// <summary>
		/// تاریخ سرویس
		/// </summary>
		#region Service_Date
		//-----DisplayName field for Service_Date
		[System.ComponentModel.DisplayName(displayName: "تاریخ سرویس")]
		//--Lenght Service_Date
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Service_Date { get; set; }
		#endregion /Service_Date

		/// <summary>
		/// زمان سرویس
		/// </summary>
		#region Service_Time
		//-----DisplayName field for Service_Time
		[System.ComponentModel.DisplayName(displayName: "زمان سرویس")]
		//--Lenght Service_Time
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Service_Time { get; set; }
		#endregion /Service_Time
	}
}

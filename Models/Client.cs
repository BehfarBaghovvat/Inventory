namespace Models
{
	/// <summary>
	/// جدول مشتریان
	/// </summary>
	public class Client
	{
		public Client()
		{

		}

		/// <summary>
		/// نام مشتری
		/// </summary>
		#region Client_Name
		[System.ComponentModel.DisplayName(displayName: "نام مشتری")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Client_Name { get; set; }
		#endregion /Client_Name

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
		/// شماره پلاک وسیله نقلیه
		/// </summary>
		#region License_Plate
		[System.ComponentModel.DisplayName(displayName: "پلاک وسیله نقیله")]
		//--Lenght LicensePlate
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]
		public string License_Plate { get; set; }
		#endregion /License_Plate

		/// <summary>
		/// شماره تماس
		/// </summary>
		#region Phone_Number
		//-----DisplayName field for Phone_Number
		[System.ComponentModel.DisplayName(displayName: "شماره تماس")]
		//--Lenght Phone_Number
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 12)]
		public string Phone_Number { get; set; }
		#endregion /Phone_Number

		/// <summary>
		/// تایخ ثبت
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

namespace Models
{
	public class Service
	{
		/// <summary>
		/// جدول خدمات
		/// </summary>
		public Service()
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
			(maximumLength: 60)]
		public string Client_Name { get; set; }
		#endregion /Client_Name

		/// <summary>
		/// توضیحات
		/// </summary>
		#region Description
		/// <summary>
		/// توضیحات برای سرویس انجام شده
		/// </summary>
		//-----DisplayName field for Description
		[System.ComponentModel.DisplayName(displayName: "توضیحات")]
		//--Lenght Description
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 3000)]
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
		public uint Id { get; set; }
		#endregion /Id

		/// <summary>
		/// شماره فاکتور
		/// </summary>
		#region Invoice_Serial_Numvber
		/// <summary>
		/// شماره سریال فاکتور
		/// </summary>
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
		/// <summary>
		/// تاریخ ثبت سرویس
		/// </summary>
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
		/// <summary>
		/// زمان ثبت سرویس
		/// </summary>
		//-----DisplayName field for RegistrationTime
		[System.ComponentModel.DisplayName(displayName: "زمان ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Registration_Time { get; set; }
		#endregion /Registration_Time

		/// <summary>
		/// نام تعمیر کار
		/// </summary>
		#region Repairmaen_Name
		/// <summary>
		/// نام سرویس کاری که کار مورد نظر را انجام داده
		/// </summary>
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "نام تعمیرکار")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Repairman_Name { get; set; }
		#endregion /Repairmaen_Name

		/// <summary>
		/// قیمت سرویس
		/// </summary>
		#region Service_Price
		/// <summary>
		/// قیمتی که برای هر سرویس یا کار انجام شده تعیین میگردد
		/// </summary>
		[System.ComponentModel.DisplayName(displayName: "قیمت سرویس ")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 150)]
		public string Service_Price { get; set; }
		#endregion /Service_Price

		/// <summary>
		/// نام سرویس
		/// </summary>
		#region Service_Name
		/// <summary>
		/// نام سرویس
		/// </summary>
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "نام سرویس")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Service_Name { get; set; }
		#endregion /Service_Name

		/// <summary>
		/// تعداد سرویس
		/// </summary>
		#region Service_Number
		/// <summary>
		/// تعداد سرویس 
		/// </summary>
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "تعداد سرویس")]
		public int? Service_Number { get; set; }
		#endregion /Service_Number

		/// <summary>
		/// جمع قیمت
		/// </summary>
		#region Total_Sum_Price
		/// <summary>
		/// جمع قیمت هر سرویس
		/// </summary>
		//--DisplayName field for Total_Sum_Price
		[System.ComponentModel.DisplayName(displayName: "جمع قیمت")]
		//--Lenght Total_Sum_Price
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 160)]
		public string Total_Sum_Price { get; set; }
		#endregion /Total_Sum_Price


	}
}

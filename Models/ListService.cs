namespace Models
{
	/// <summary>
	/// جدول سرویس خودرو
	/// </summary>
	public class ListService
	{
		public ListService()
		{

		}

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
		public int Id { get; set; }
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
		/// تاریخ ثبت سرویس
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
		public byte? Service_Number { get; set; }
		#endregion /Service_Number

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
		/// زمان ثبت سرویس
		/// </summary>
		#region Service_Time
		//-----DisplayName field for Service_Time
		[System.ComponentModel.DisplayName(displayName: "زمان سرویس")]
		//--Lenght Service_Time
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Service_Time { get; set; }
		#endregion /Service_Time

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

namespace Models
{
	/// <summary>
	///  جدول فاکتور فروش کالا
	/// </summary>
	public class SalesInvoice
	{
		public enum SalesPaymentType
		{
			نقد,
			چک,
		}

		public enum PaymentCachType
		{
			غیرنقد,
			نقد,
			کارتخوان,
			نقد_کارتخوان
		}

		public SalesInvoice()
		{

		}

		/// <summary>
		/// نام حامل
		/// </summary>
		#region Carrier_Name
		//--DisplayName field for Carrier_Name
		[System.ComponentModel.DisplayName(displayName: "نام حامل")]
		//--Lenght Carrier_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Carrier_Name { get; set; }
		#endregion /Carrier_Name

		/// <summary>
		/// نام مشتری
		/// </summary>
		#region Client_Name
		//--DisplayName field for Client_Name
		[System.ComponentModel.DisplayName(displayName: "نام مشتری")]
		//--Lenght Client_Name
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
		/// نوع پرداخت
		/// </summary>
		#region Payment_Type
		//--DisplayName field for Invoice_Serial_Numvber
		[System.ComponentModel.DisplayName(displayName: "نوع پرداخت")]
		public SalesPaymentType Sales_Payment_Type { get; set; }
		#endregion /Payment_Type

		/// <summary>
		/// نوع پرداخت نقد
		/// </summary>
		#region Payment_Cach_Type
		//--DisplayName field for Invoice_Serial_Numvber
		[System.ComponentModel.DisplayName(displayName: "نوع پرداخت نقد")]
		public PaymentCachType Payment_Cach_Type { get; set; }
		#endregion /Payment_Cach_Type

		/// <summary>
		/// تایخ فروش
		/// </summary>
		#region Sales_Date
		//-----DisplayName field for RegistrationDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ فروش")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Sales_Date { get; set; }
		#endregion /Sales_Date

		/// <summary>
		/// زمان فروش
		/// </summary>
		#region Sales_Time
		//-----DisplayName field for Purchase_Time
		[System.ComponentModel.DisplayName(displayName: "زمان فروش")]
		//--Lenght Purchase_Time
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Sales_Time { get; set; }
		#endregion /Sales_Time

		/// <summary>
		/// نام فروشنده
		/// </summary>
		#region Seller_Name
		//--DisplayName field for Seller_Name
		[System.ComponentModel.DisplayName(displayName: "نام فروشنده")]
		//--Lenght Seller_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Seller_Name { get; set; }
		#endregion /Seller_Name

		/// <summary>
		/// جمع قیمت
		/// </summary>
		#region Total_Sum_Price
		//--DisplayName field for Total_Sum_Price
		[System.ComponentModel.DisplayName(displayName: "جمع قیمت")]
		//--Lenght Total_Sum_Price
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 160)]
		public string Total_Sum_Price { get; set; }
		#endregion /Total_Sum_Price
	}
}

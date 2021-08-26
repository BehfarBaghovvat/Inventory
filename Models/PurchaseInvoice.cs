namespace Models
{
	/// <summary>
	/// جدول فاکتور خرید کالا
	/// </summary>
	public class PurchaseInvoice
	{
		public PurchaseInvoice()
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
		/// نام تحویل گیرنده
		/// </summary>
		#region Recipient_Name
		//--DisplayName field for Recipient_Name
		[System.ComponentModel.DisplayName(displayName: "نام تحویل گیرنده ")]
		//--Lenght Recipient_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Recipient_Name { get; set; }
		#endregion /Recipient_Name

		/// <summary>
		/// تایخ خرید
		/// </summary>
		#region Purchase_Date
		//-----DisplayName field for RegistrationDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ خرید")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Purchase_Date { get; set; }
		#endregion /Purchase_Date

		/// <summary>
		/// زمان خرید
		/// </summary>
		#region Purchase_Time
		//-----DisplayName field for Purchase_Time
		[System.ComponentModel.DisplayName(displayName: "زمان خرید")]
		//--Lenght Purchase_Time
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Purchase_Time { get; set; }
		#endregion /Purchase_Time

		/// <summary>
		/// نام فرستنده
		/// </summary>
		#region Sender_Name
		//--DisplayName field for Sender_Name
		[System.ComponentModel.DisplayName(displayName: "نام فرستنده")]
		//--Lenght Sender_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Sender_Name { get; set; }
		#endregion /Sender_Name

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

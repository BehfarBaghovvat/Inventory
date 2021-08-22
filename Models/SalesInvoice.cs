﻿namespace Models
{
	/// <summary>
	///  جدول فاکتور فروش کالا
	/// </summary>
	public class SalesInvoice
	{
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
		/// نام کالا
		/// </summary>
		#region Product_Name
		//--DisplayName field for Product_Name
		[System.ComponentModel.DisplayName(displayName: "نام کالا")]
		//--Lenght Product_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Product_Name { get; set; }
		#endregion /Product_Name

		/// <summary>
		/// قیمت کالا
		/// </summary>
		#region Product_Price
		//--DisplayName field for Product_Price
		[System.ComponentModel.DisplayName(displayName: "قیمت کالا")]
		//--Lenght Product_Price
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 150)]
		public string Product_Price { get; set; }
		#endregion /Product_Price

		/// <summary>
		/// تعداد کالا
		/// </summary>
		#region Product_Quantity
		//--DisplayName field for Product_Quantity
		[System.ComponentModel.DisplayName(displayName: "تعداد کالا")]
		public int? Product_Quantity { get; set; }
		#endregion /Product_Quantity

		/// <summary>
		/// واحد کالا
		/// </summary>
		#region Product_Unit
		//--DisplayName field for Product_Unit
		[System.ComponentModel.DisplayName(displayName: "واحد کالا")]
		public string Product_Unit { get; set; }
		#endregion /Product_Unit

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

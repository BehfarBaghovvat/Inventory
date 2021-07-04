namespace Models
{
	public class SalesInvoice
	{
		public SalesInvoice()
		{

		}

		#region Carrier_Name
		[System.ComponentModel.DisplayName(displayName: "نام حامل")]
		//--Lenght Carrier_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Carrier_Name { get; set; }
		#endregion /Carrier_Name

		#region Client_Name
		[System.ComponentModel.DisplayName(displayName: "نام مشتری")]
		//--Lenght Client_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Client_Name { get; set; }
		#endregion /Client_Name

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

		#region Product_Name
		[System.ComponentModel.DisplayName(displayName: "نام کالا")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Product_Name { get; set; }
		#endregion /Product_Name

		#region Product_Price
		[System.ComponentModel.DisplayName(displayName: "قیمت کالا")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 150)]
		public string Product_Price { get; set; }
		#endregion /Product_Price

		#region Product_Quantity
		[System.ComponentModel.DisplayName(displayName: "تعداد کالا")]
		public int? Product_Quantity { get; set; }
		#endregion /Product_Quantity

		#region Product_Unit
		[System.ComponentModel.DisplayName(displayName: "واحد کالا")]
		public string Product_Unit { get; set; }
		#endregion /Product_Unit

		#region Seller_Name
		[System.ComponentModel.DisplayName(displayName: "نام فروشنده")]
		//--Lenght Seller_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Seller_Name { get; set; }
		#endregion /Seller_Name

		#region Total_Sum_Price
		[System.ComponentModel.DisplayName(displayName: "جمع قیمت")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 160)]
		public string Total_Sum_Price { get; set; }
		#endregion /Total_Sum_Price
	}
}

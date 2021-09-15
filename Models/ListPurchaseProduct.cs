namespace Models
{
	/// <summary>
	/// جدول لیست خرید کالا
	/// </summary>
	public class ListPurchaseProduct
	{
		public ListPurchaseProduct()
		{

		}

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
	}
}

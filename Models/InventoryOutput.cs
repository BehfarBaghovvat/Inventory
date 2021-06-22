namespace Models
{
	public class InventoryOutput //لیست خروجی انبار
	{
		public InventoryOutput() : base()
		{

		}

		#region Add_Order_Date
		//-----DisplayName field for RegistrationDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت سفارش")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Add_Order_Date { get; set; }
		#endregion /Add_Order_Date

		#region Add_Order_Time
		//-----DisplayName field for RegistrationTime
		[System.ComponentModel.DisplayName(displayName: "زمان ثبت سفارش")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Add_Order_Time { get; set; }
		#endregion /Add_Order_Time

		#region Carrier_Name
		[System.ComponentModel.DisplayName(displayName: "نام حامل کالا")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Carrier_Name { get; set; }
		#endregion /Carrier_Name

		#region Client_Name
		[System.ComponentModel.DisplayName(displayName: "نام مشتری")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Client_Name { get; set; }
		#endregion /Client_Name

		#region Id
		//-----DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//-----Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }
		#endregion /Id

		#region Product_Image
		[System.ComponentModel.DisplayName(displayName: "تصویر کالا")]
		public byte[] Product_Image { get; set; }
		#endregion /Product_Image

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
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Product_Unit { get; set; }
		#endregion /Product_Unit

		#region Seller_Name
		[System.ComponentModel.DisplayName(displayName: "نام فروشنده")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Seller_Name { get; set; }
		#endregion /Seller_Name
	}
}

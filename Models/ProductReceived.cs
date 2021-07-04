namespace Models
{
	public class ProductReceived //ورودی کالا
	{
		public ProductReceived() : base()
		{

		}

		#region Last_Edited_Date
		//-----DisplayName field for Edit_Date
		[System.ComponentModel.DisplayName(displayName: "تاریخ آخرین ویرایش")]
		//--Lenght Edit_Date
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Last_Edited_Date { get; set; }
		#endregion /Last_Edited_Date

		#region Last_Edited_Time
		//-----DisplayName field for Edit_Time
		[System.ComponentModel.DisplayName(displayName: "زمان  آخرین ویرایش")]
		//--Lenght Edit_Time
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Last_Edited_Time { get; set; }
		#endregion /Last_Edited_Time

		#region Carrier_Name
		[System.ComponentModel.DisplayName(displayName: "نام حامل کالا")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Carrier_Name { get; set; }
		#endregion /Carrier_Name

		#region Id
		//-----DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//-----Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }
		#endregion /Id

		#region Number_Edit
		[System.ComponentModel.DisplayName(displayName: "تعداد ویرایش")]
		public int Number_Edit { get; set; }
		#endregion /Number_Edit

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

		#region Product_Purchase_Price
		[System.ComponentModel.DisplayName(displayName: "قیمت خرید کالا")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 150)]
		public string Product_Purchase_Price { get; set; }
		#endregion /Product_Purchase_Price

		#region Product_Quantity
		[System.ComponentModel.DisplayName(displayName: "تعداد کالا")]
		public int? Product_Quantity { get; set; }
		#endregion /Product_Quantity

		#region Product_Unit
		[System.ComponentModel.DisplayName(displayName: "واحد کالا")]
		public string Product_Unit { get; set; }
		#endregion /Product_Unit

		#region Registration_Date
		//-----DisplayName field for RegistrationDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Registration_Date { get; set; }
		#endregion /Registration_Date

		#region Registration_Time
		//-----DisplayName field for RegistrationTime
		[System.ComponentModel.DisplayName(displayName: "زمان ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Registration_Time { get; set; }
		#endregion /Registration_Time

		#region Sender_Name
		[System.ComponentModel.DisplayName(displayName: "نام ارسال کننده")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Sender_Name { get; set; }
		#endregion /Sender_Name

		#region Transfer_Name
		[System.ComponentModel.DisplayName(displayName: "نام تحویل گیردنده")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Recipient_Name { get; set; }
		#endregion /Transfer_Name
	}
}

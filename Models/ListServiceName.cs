namespace Models
{
	/// <summary>
	/// لیست انواع خدمات
	/// </summary>
	public class ListServiceName
	{
		public ListServiceName()
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
		public uint Id { get; set; }
		#endregion /Id

		/// <summary>
		/// مبلغ سرویس
		/// </summary>
		#region Service_Price
		[System.ComponentModel.DisplayName(displayName: "قیمت سرویس دهی")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 150)]
		public string Service_Price { get; set; }
		#endregion /Service_Price

		/// <summary>
		/// نام سرویس
		/// </summary>
		#region Service_Name
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "نام سرویس")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Service_Name { get; set; }
		#endregion /Service_Name
	}
}

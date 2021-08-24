namespace Models
{
	/// <summary>
	/// جدول اسامی خدمات
	/// </summary>
	public class ListServiceNames
	{
		public ListServiceNames()
		{

		}

		/// <summary>
		/// لیست اسامی خدمات
		/// </summary>
		#region List_Services_Name
		//-----DisplayName field for Cost_Name
		[System.ComponentModel.DisplayName(displayName: "لیست اسامی خدمات")]
		//--Lenght Cost_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string List_Services_Name { get; set; }
		#endregion /List_Services_Name

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
	}
}

namespace Models
{
	/// <summary>
	/// بانک اسامی هزینه های جانبی
	/// </summary>
	public class ListIncidentalExpensesName
	{
		public ListIncidentalExpensesName()
		{

		}

		/// <summary>
		/// لیست اسامی هزینه ها
		/// </summary>
		#region Cost_Name
		//-----DisplayName field for Cost_Name
		[System.ComponentModel.DisplayName(displayName: "لیست اسامی هزینه")]
		//--Lenght Cost_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 75)]
		public string Cost_Name { get; set; }
		#endregion /Cost_Name

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
	}
}

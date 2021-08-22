namespace Models
{
	/// <summary>
	/// گردش سرمایه
	/// </summary>
	public class CapitalTurnover
	{
		public CapitalTurnover()
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
		/// سرمایه صندوق
		/// </summary>
		#region Capital_Fund
		[System.ComponentModel.DisplayName(displayName: "سرمایه")]
		public string Fund { get; set; }
		#endregion /Capital_Fund

		/// <summary>
		/// تاریخ ثبت
		/// </summary>
		#region Register_Date
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		public string Register_Date { get; set; }
		#endregion /Register_Date

		/// <summary>
		/// زمان ثبت
		/// </summary>
		#region Register_Date
		[System.ComponentModel.DisplayName(displayName: "زمان ثبت")]
		public string Register_Time { get; set; }
		#endregion /Register_Date

	}
}

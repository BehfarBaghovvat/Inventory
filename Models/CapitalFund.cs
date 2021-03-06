namespace Models
{
	/// <summary>
	/// صندوق سرمایه
	/// </summary>
	public class CapitalFund
	{
		public CapitalFund()
		{

		}

		/// <summary>
		/// صندوق سرمایه
		/// </summary>
		#region Capital_Fund
		[System.ComponentModel.DisplayName(displayName: "صندوق سرمایه")]
		public string Capital_Fund { get; set; }
		#endregion /Capital_Fund

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

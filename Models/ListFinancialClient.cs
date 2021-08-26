
namespace Models
{
	/// <summary>
	/// جدول لیست مالی مشتریان
	/// </summary>
	public class ListFinancialClient
	{
		public ListFinancialClient()
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
	}
}

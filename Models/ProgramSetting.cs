namespace Models
{
	/// <summary>
	/// تنظیمات برنامه
	/// </summary>
	public class ProgramSetting
	{
		public ProgramSetting(): base()
		{

		}

		/// <summary>
		/// اطلاعیه سرمایه
		/// </summary>
		#region Capital_Display
		//-----DisplayName field for Capital_Display
		[System.ComponentModel.DisplayName(displayName: "اطلاعیه سرمایه")]
		public bool Capital_Notification { get; set; }
		#endregion /Capital_Display

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

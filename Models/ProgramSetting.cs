namespace Models
{
	public class ProgramSetting
	{
		public ProgramSetting(): base()
		{

		}

		#region Capital_Display
		//-----DisplayName field for Capital_Display
		[System.ComponentModel.DisplayName(displayName: "نمایش سرمایه")]
		public bool Capital_Display { get; set; }
		#endregion /Capital_Display

		#region Id
		//-----DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//-----Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }
		#endregion /Id

		
	}
}

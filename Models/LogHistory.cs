namespace Models
{
	public class LogHistory : BaseEntity
	{
		public LogHistory() : base()
		{

		}

		#region FullName
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]
		//--Not allowed to be empty Username
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//--Lenght Username
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 55)]
		public string Full_Name { get; set; }
		#endregion /FullName

		#region Username
		//--Username is not Unique
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]

		//--Not allowed to be empty Username
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		//--Lenght Username
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Username { get; set; }
		#endregion /Username

		#region LoginTime
		//--Not allowed to be empty LoginTime
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]
		//--Lenght LoginTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Login_Time { get; set; }
		#endregion /LoginTime

		#region LogoutTime
		//--Not allowed to be empty LogoutTime
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]

		//--Lenght LogoutTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]

		public string Logout_Time { get; set; }
		#endregion /LogoutTime
	}
}

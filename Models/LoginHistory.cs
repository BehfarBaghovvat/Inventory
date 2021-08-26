namespace Models
{
	/// <summary>
	/// تاریخچه ورود و خروج
	/// </summary>
	public class LoginHistory //تاریخچه ورود و خروج
	{
		public LoginHistory() : base()
		{

		}

		/// <summary>
		/// نام کاربر
		/// </summary>
		#region FullName
		[System.ComponentModel.DisplayName(displayName: "نام کاربر")]

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
		/// تاریخ ورود
		/// </summary>
		#region Login_Time
		[System.ComponentModel.DisplayName(displayName: "زمان ورود")]
		//--Lenght Login_Date
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Login_Time { get; set; }
		#endregion /Login_Time

		/// <summary>
		/// تاریخ خروج
		/// </summary>
		#region Logout_Time
		[System.ComponentModel.DisplayName(displayName: "زمان خروج")]
		//--Lenght Logout_Time
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]

		public string Logout_Time { get; set; }
		#endregion /Logout_Time

		/// <summary>
		/// شناسه کاربری
		/// </summary>
		#region Username
		[System.ComponentModel.DisplayName(displayName: "شناسه کاربری")]

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
	}
}

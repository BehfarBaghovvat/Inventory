namespace Models
{
	/// <summary>
	/// لیست کاربران
	/// </summary>
	public class User
	{
		public enum AccessLeve
		{
			مدیریت,
			معاونت,
			کارمند,
			نیروی_خدماتی,
			کاربر_ساده,
		}

		public enum Active
		{
			فعال,
			غیرفعال,
		}

		public User() : base()
		{

		}

		/// <summary>
		/// سطح دسترسی
		/// </summary>
		#region Access_Level
		//-----DisplayName field for AccessLevel
		[System.ComponentModel.DisplayName(displayName: "سطح دسترسی")]
		public AccessLeve Access_Level { get; set; }
		#endregion /Access_Level

		/// <summary>
		/// تاریخ ویرایش
		/// </summary>
		#region Edit_Date
		//-----DisplayName field for Edit_Date
		[System.ComponentModel.DisplayName(displayName: "تاریخ ویرایش")]
		//--Lenght Edit_Date
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Edit_Date { get; set; }
		#endregion /Edit_Date

		/// <summary>
		/// زمان ویرایش
		/// </summary>
		#region Edit_Time
		//-----DisplayName field for Edit_Time
		[System.ComponentModel.DisplayName(displayName: "زمان ویرایش")]
		//--Lenght Edit_Time
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Edit_Time { get; set; }
		#endregion /Edit_Time

		/// <summary>
		/// وضعیت فعالیت
		/// </summary>
		#region IsActive
		//-----DisplayName field for IsActive
		[System.ComponentModel.DisplayName(displayName: "فعالیت")]
		public bool Is_Active { get; set; }
		#endregion /IsActive

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
		/// نام و نام خانوادگی
		/// </summary>
		#region FullName
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "نام و نام خانوادگی")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Full_Name { get; set; }
		#endregion /FullName

		/// <summary>
		/// رمز عبور
		/// </summary>
		#region Password
		[System.ComponentModel.DisplayName(displayName: "رمز عبور")]
		//--Lenght Password
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]
		public string Password { get; set; }
		#endregion /Password

		/// <summary>
		/// تایخ ثبت
		/// </summary>
		#region Registration_Date
		//-----DisplayName field for RegistrationDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Registration_Date { get; set; }
		#endregion /Registration_Date

		/// <summary>
		/// زمان ثبت
		/// </summary>
		#region Registration_Time
		//-----DisplayName field for RegistrationTime
		[System.ComponentModel.DisplayName(displayName: "زمان ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Registration_Time { get; set; }
		#endregion /Registration_Time

		/// <summary>
		/// تصویر کاربر
		/// </summary>
		#region UserImage
		//-----DisplayName field for UserImage
		[System.ComponentModel.DisplayName(displayName: "تصویر کاربر")]
		public byte[] User_Image { get; set; }
		#endregion /UserImage

		/// <summary>
		/// شناسه کاربری
		/// </summary>
		#region Username
		//--DisplayName field for Username
		[System.ComponentModel.DisplayName(displayName: "شناسه کاربری")]
		//--Uniq Username
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		//--Lenght Username
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Username { get; set; }
		#endregion /Username
	}
}

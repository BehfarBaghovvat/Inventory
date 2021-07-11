namespace Models
{
	/// <summary>
	/// رویدادها
	/// </summary>
	public class EventLog
	{
		public EventLog() : base()
		{

		}

		#region Description
		//-----DisplayName field for Description
		[System.ComponentModel.DisplayName(displayName: "توضیحات")]
		//-----Not allowed to be empty Description
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Lenght Description
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 1000)]
		public string Description { get; set; }
		#endregion /Description

		#region Event_Date
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "تاریخ رخداد")]
		//-----Not allowed to be empty EventDate
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Lenght EventDate
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Event_Date { get; set; }
		#endregion /Event_Date

		#region Event_Time
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "زمان رخداد")]
		//-----Not allowed to be empty EventTime
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----Lenght EventTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Event_Time { get; set; }
		#endregion /Event_Time

		#region FullName
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "نام و نام خانوادگی")]
		//-----StringLength of FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Full_Name { get; set; }
		#endregion /FullName

		#region Id
		//-----DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//-----Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }
		#endregion /Id

		#region Username
		//-----DisplayName field for Username
		[System.ComponentModel.DisplayName(displayName: "شناسه کاربری")]
		//--Uniq Username
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		//--Lenght Username
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 15)]
		public string Username { get; set; }
		#endregion /Username
	}
}

namespace Models
{
	/// <summary>
	/// هزینه های جانبی
	/// </summary>
	public class AncillaryCosts
	{
		public AncillaryCosts()
		{

		}
		/// <summary>
		/// مبلغ پرداختی
		/// </summary>
		#region Amount_Payment
		//--DisplayName field for Cost_Name
		[System.ComponentModel.DisplayName(displayName: "مبلغ پرداختی")]
		//--Lenght Cost_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Amount_Payment { get; set; }
		#endregion /Amount_Payment

		/// <summary>
		/// نام هزینه صورت گرفته
		/// </summary>
		#region Cost_Name
		//--DisplayName field for Cost_Name
		[System.ComponentModel.DisplayName(displayName: "نام هزینه صورت گرفته")]
		//--Lenght Cost_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
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

		/// <summary>
		/// نام پرداخت کننده
		/// </summary>
		#region Name_Payer
		//--DisplayName field for NamePayer
		[System.ComponentModel.DisplayName(displayName: "نام پرداخت کننده")]
		//--Lenght NamePayer
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Name_Payer { get; set; }
		#endregion /Name_Payer

		/// <summary>
		/// تاریخ ثبت
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
	}
}

namespace Models
{
	/// <summary>
	///دفتر معین واریز به صندوق
	/// </summary>
	public class AccountsReceivable
	{
		public AccountsReceivable()
		{

		}

		/// <summary>
		/// مبلغ پرداخت شده
		/// </summary>
		#region Amount_Paid
		//-----DisplayName field for Amount_Payable
		[System.ComponentModel.DisplayName(displayName: "مبلغ پرداخت شده")]
		//--Lenght Amount_Payable
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Amount_Paid { get; set; }
		#endregion /Amount_Paid

		/// <summary>
		/// مبلغ قابل پرداخت
		/// </summary>
		#region Amount_Payable
		//-----DisplayName field for Amount_Payable
		[System.ComponentModel.DisplayName(displayName: "مبلغ قابل پرداخت")]
		//--Lenght Amount_Payable
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength:160)]
		public string Amount_Payable { get; set; }
		#endregion /Amount_Payable

		/// <summary>
		/// نام مشتری
		/// </summary>
		#region Client_Name
		[System.ComponentModel.DisplayName(displayName: "نام مشتری")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Client_Name { get; set; }
		#endregion /Client_Name

		/// <summary>
		/// توضیحات
		/// </summary>
		#region Description
		[System.ComponentModel.DisplayName(displayName: "توضیحات")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 1000)]
		public string Description { get; set; }
		#endregion /Description

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

		/// <summary>
		/// مبلغ باقی مانده
		/// </summary>
		#region Remaininig_Amount
		[System.ComponentModel.DisplayName(displayName: "مبلغ باقیمانده")]
		//--Lenght Amount_Payable
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Remaininig_Amount { get; set; }
		#endregion /Remaininig_Amount

		/// <summary>
		/// درصد مالیات
		/// </summary>
		#region Tax_Percent
		//--DisplayName Tax_Percent
		[System.ComponentModel.DisplayName(displayName: "درصد مالیات")]
		//--Lenght Tax_Percent
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 3)]
		public string Tax_Percent { get; set; }
		#endregion /Tax_Percent
	}
}

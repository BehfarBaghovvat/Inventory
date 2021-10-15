namespace Models
{
	/// <summary>
	/// دفتر معین پرداختی ها
	/// </summary>
	public class AccountsPayment
	{
		public enum FinantialSituation
		{
			طلبکار,
			تسویه,
			بدهکار,
		}

		public AccountsPayment()
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
			(maximumLength: 160)]
		public string Amount_Payable { get; set; }
		#endregion /Amount_Payable

		/// <summary>
		/// توضیحات
		/// </summary>
		#region Description
		//--DisplayName field for Description
		[System.ComponentModel.DisplayName(displayName: "توضیحات")]
		//--Lenght Description
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 1000)]
		public string Description { get; set; }
		#endregion /Description

		/// <summary>
		/// وضعیت مالی
		/// </summary>
		#region Finantial_Situation
		//--DisplayName FinantialSituation
		[System.ComponentModel.DisplayName(displayName: "وضعیت مالی")]
		public FinantialSituation Finantial_Situation { get; set; }
		#endregion /Finantial_Situation

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
		/// مبلغ باقیمانده
		/// </summary>
		#region Remaininig_Amount
		[System.ComponentModel.DisplayName(displayName: "مبلغ باقیمانده")]
		//--Lenght Amount_Payable
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Remaininig_Amount { get; set; }
		#endregion /Remaininig_Amount

		/// <summary>
		/// نام فروشنده
		/// </summary>
		#region Seller_Name
		//--DisplayName field for Seller_Name
		[System.ComponentModel.DisplayName(displayName: "نام فروشنده")]
		//--Lenght Seller_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Seller_Name { get; set; }
		#endregion /Seller_Name
	}
}

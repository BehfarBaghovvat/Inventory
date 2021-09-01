namespace Models
{
	/// <summary>
	/// جدول ثبت چک بانکی
	/// </summary>
	public class ChequeSection
	{
		public enum StatusChequa
		{
			وصول_شد,
			نامشخص,
			عدم_وصول_چک,
		}
		public ChequeSection()
		{

		}

		#region Amount_Number_Paid
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "مبلغ پرداختی به عدد")]
		public string Amount_Number_Paid { get; set; }
		#endregion /Amount_Number_Paid

		#region Amount_Words_Paid
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "مبلغ پرداختی به حروف")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 1000)]
		public string Amount_Words_Paid { get; set; }
		#endregion /Amount_Words_Paid

		#region Amount_Words_Received
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "مبلغ دریافتی به حروف")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 1000)]
		public string Amount_Words_Received { get; set; }
		#endregion /Amount_Words_Received

		#region Amount_Number_Received
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "مبلغ دریافتی به عدد")]
		public string Amount_Number_Received { get; set; }
		#endregion /Amount_Number_Received

		#region Data_Receipt
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "تاریخ وصول")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Data_Receipt { get; set; }
		#endregion /Data_Receipt

		#region Id
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public int Id { get; set; }
		#endregion /Id

		#region NameAccountHolder
		//-----DisplayName field for Name_Account_Holder
		[System.ComponentModel.DisplayName(displayName: "نام صاحب حساب")]
		//--Lenght Name_Account_Holder
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 55)]
		public string Name_Account_Holder { get; set; }
		#endregion /NameAccountHolder

		#region National_Code
		//-----DisplayName field for NationalCode
		[System.ComponentModel.DisplayName(displayName: "شناسه ملی")]
		//--Lenght NationalCode
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 12)]
		public string National_Code { get; set; }
		#endregion /National_Code

		#region Number_Chequa
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "شماره صیاد چک")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Number_Chequa { get; set; }
		#endregion /Number_Chequa

		#region Pay_To
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "در وجه")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Pay_To { get; set; }
		#endregion /Pay_To

		#region Status_Chequa
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "وضعیت چک")]
		public StatusChequa Status_Chequa { get; set; }
		#endregion /Status_Chequa
	}
}

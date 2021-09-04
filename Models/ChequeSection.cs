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

		/// <summary>
		/// مبلغ چک پرداختی به عدد
		/// </summary>
		#region Amount_Number_Paid
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "مبلغ پرداختی به عدد")]
		public string Amount_Number_Paid { get; set; }
		#endregion /Amount_Number_Paid

		/// <summary>
		/// مبلغ چک دریافتی به عدد
		/// </summary>
		#region Amount_Words_Received
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "مبلغ دریافتی به حروف")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 1000)]
		public string Amount_Words_Received { get; set; }
		#endregion /Amount_Words_Received

		/// <summary>
		/// مبلغ چک پرداختی به حروف
		/// </summary>
		#region Amount_Words_Paid
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "مبلغ پرداختی به حروف")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 1000)]
		public string Amount_Words_Paid { get; set; }
		#endregion /Amount_Words_Paid

		/// <summary>
		/// مبلغ چک دریافتی به حروف
		/// </summary>
		#region Amount_Number_Received
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "مبلغ دریافتی به عدد")]
		public string Amount_Number_Received { get; set; }
		#endregion /Amount_Number_Received

		/// <summary>
		/// تاریخ چک
		/// </summary>
		#region Data_Receipt
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "تاریخ وصول")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Data_Receipt { get; set; }
		#endregion /Data_Receipt

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
		/// نام صحاب حساب
		/// </summary>
		#region NameAccountHolder
		//-----DisplayName field for Name_Account_Holder
		[System.ComponentModel.DisplayName(displayName: "نام صاحب حساب")]
		//--Lenght Name_Account_Holder
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 55)]
		public string Name_Account_Holder { get; set; }
		#endregion /NameAccountHolder

		/// <summary>
		/// شماره ملی
		/// </summary>
		#region National_Code
		//-----DisplayName field for NationalCode
		[System.ComponentModel.DisplayName(displayName: "شناسه ملی")]
		//--Lenght NationalCode
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 12)]
		public string National_Code { get; set; }
		#endregion /National_Code

		/// <summary>
		/// در وجه
		/// </summary>
		#region Pay_To
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "در وجه")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Pay_To { get; set; }
		#endregion /Pay_To

		/// <summary>
		/// سریال 16 رقمی صیاد
		/// </summary>
		#region Serial_Cheque
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "شماره صیاد چک")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Serial_Cheque { get; set; }
		#endregion /Serial_Cheque

		/// <summary>
		/// وضعیت چک
		/// </summary>
		#region Status_Chequa
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "وضعیت چک")]
		public StatusChequa Status_Chequa { get; set; }
		#endregion /Status_Chequa
	}
}

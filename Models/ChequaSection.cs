namespace Models
{
	/// <summary>
	/// جدول ثبت چک بانکی
	/// </summary>
	public class ChequaSection
	{
		public ChequaSection()
		{

		}

		#region Amount_Words
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "مبلغ به عدد")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Amount_Number { get; set; }
		#endregion /Amount_Words

		#region Amount_Words
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "مبلغ به حروف")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 1000)]
		public string Amount_Words { get; set; }
		#endregion /Amount_Words

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

		#region National_Code
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "شناسه ملی")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 12)]
		public string National_Code { get; set; }
		#endregion /National_Code

		#region Number_Chequa
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "شماره چک")]
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
	}
}

namespace Models
{
	public class YearlyFinancialReport
	{
		public YearlyFinancialReport()
		{

		}

		#region Id
		//-----DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//-----Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }
		#endregion /Id

		#region Sum_Total_Price_Of_Month
		//----- Display Name TotalPrice
		[System.ComponentModel.DisplayName(displayName: "جمع کل حساب ماه")]
		//-----Allow Empty TotalPrice
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength TotalPrice
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Sum_Total_Price_Of_Month { get; set; }
		#endregion /Sum_Total_Price_Of_Month

		#region Sum_Payment_Amount_Of_Month
		//----- Display Name Payment
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ پرداختی ماه")]
		//-----Allow Empty Payment
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Payment
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Sum_Payment_Amount_Of_Month { get; set; }
		//-----
		#endregion /Sum_Payment_Amount_Of_Month

		#region Sum_Remaining_Amount_Of_Month
		//----- Display Name Remaining Amount
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ بدهی ماه")]
		//-----Allow Empty Remaining Amount
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Remaining Amount
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 55)]
		public string Sum_Remaining_Amount_Of_Month { get; set; }
		#endregion /Sum_Remaining_Amount_Of_Month

		#region Register_Date
		//----- Display Name TotalPrice
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		//-----Allow Empty TotalPrice
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength TotalPrice
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Register_Date { get; set; }
		#endregion /Register_Date

		#region Date
		public int Year { get; set; }
		public int Month { get; set; }
		#endregion /Date

		
	}
}

namespace Models
{
	public class YearlyFinancialReport
	{
		public YearlyFinancialReport()
		{

		}

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
		/// جمع کل حساب ماه
		/// </summary>
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

		/// <summary>
		/// چمع مبلغ پرداختی ماه
		/// </summary>
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

		/// <summary>
		/// چمع مبلغ بدهی ماه
		/// </summary>
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

		/// <summary>
		/// تاریخ ثبت
		/// </summary>
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

		/// <summary>
		/// تکفکیک تاریخ
		/// </summary>
		#region Date
		public int Year { get; set; }
		public int Month { get; set; }
		#endregion /Date

		
	}
}

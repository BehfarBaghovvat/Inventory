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
		/// جمع مبلغ پرداختی ماه
		/// </summary>
		#region Sum_Total_Price_Of_Month
		//----- Display Name Sum_Amount_Paid_Of_Month
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ پرداختی ماه")]
		//-----Allow Empty Sum_Amount_Paid_Of_Month
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Sum_Amount_Paid_Of_Month
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Sum_Amount_Paid_Of_Month { get; set; }
		#endregion /Sum_Amount_Paid_Of_Month

		/// <summary>
		/// جمع مبلغ قابل پرداخت ماه
		/// </summary>
		#region Sum_Amount_Payment_Of_Month
		//----- Display Name Sum_Amount_Payment_Of_Month
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ قابل پرداخت ماه")]
		//-----Allow Empty Sum_Amount_Payment_Of_Month
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Sum_Amount_Payment_Of_Month
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 45)]
		public string Sum_Amount_Payment_Of_Month { get; set; }
		//-----
		#endregion /Sum_Amount_Payment_Of_Month

		/// <summary>
		/// جمع مبلغ دریافتی ماه
		/// </summary>
		#region Sum_Amounts_Received_Of_Month
		//----- Display Name Sum_Amounts_Received_Of_Month Amount
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ دریافتی ماه")]
		//-----Allow Empty Sum_Amounts_Received_Of_Month
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Sum_Amounts_Received_Of_Month
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 55)]
		public string Sum_Amounts_Received_Of_Month { get; set; }
		#endregion /Sum_Amounts_Received_Of_Month

		/// <summary>
		/// جمع مبلغ باقیمانده ماه
		/// </summary>
		#region Sum_Amounts_Remaining_Of_Month
		//----- Display Name Sum_Amounts_Remaining_Of_Month
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ باقیمانده ماه")]
		//-----Allow Empty Sum_Amounts_Remaining_Of_Month
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Sum_Amounts_Remaining_Of_Month
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 150)]
		public string Sum_Amounts_Remaining_Of_Month { get; set; }
		#endregion /Sum_Amounts_Remaining_Of_Month

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
		public int? Year { get; set; }
		public int? Month { get; set; }
		#endregion /Date

		
	}
}

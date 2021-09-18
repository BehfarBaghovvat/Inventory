namespace Models
{
	public class MonthlyFinancialReport
	{
		public MonthlyFinancialReport()
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
		/// جمع مبلغ پرداختی روز
		/// </summary>
		#region Sum_Amount_Paid_Of_Day
		//----- Display Name Sum_Amount_Paid_Of_Day
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ پرداختی روز")]
		//-----Allow Empty Sum_Amount_Paid_Of_Day
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Sum_Amount_Paid_Of_Day
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 150)]
		public string Sum_Amount_Paid_Of_Day { get; set; }
		//-----
		#endregion /Sum_Amount_Paid_Of_Day

		/// <summary>
		/// جمع مبلغ قابل پرداخت روز
		/// </summary>
		#region Sum_Amount_Payment_Of_Day
		//----- Display Name Payment
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ قابل پرداخت روز")]
		//-----Allow Empty Payment
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Payment
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 150)]
		public string Sum_Amount_Payment_Of_Day { get; set; }
		//-----
		#endregion /Sum_Amount_Payment_Of_Day

		/// <summary>
		/// جمع مبلغ دریافتی روز
		/// </summary>
		#region Sum_Amounts_Received_Of_Day
		//----- Display Name Amounts_Received
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ دریافتی روز")]
		//-----StringLength Amounts_Received
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 150)]
		public string Sum_Amounts_Received_Of_Day { get; set; }
		#endregion /Sum_Amounts_Received_Of_Day

		/// <summary>
		/// جمع مبلغ باقیمانده روز
		/// </summary>
		#region Sum_Amounts_Remaining_Of_Day
		//----- Display Name Sum_Amounts_Remaining_Of_Day
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ باقیمانده روز")]
		//-----Allow Empty Sum_Amounts_Remaining_Of_Day
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
		//-----StringLength Sum_Amounts_Remaining_Of_Day
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 150)]
		public string Sum_Amounts_Remaining_Of_Day { get; set; }
		#endregion /Sum_Amounts_Remaining_Of_Day

		/// <summary>
		/// زمان ثبت 
		/// </summary>
		#region Register_Date
		//----- Display Name TotalPrice
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		//-----StringLength TotalPrice
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Register_Date { get; set; }
		#endregion /Register_Date

		/// <summary>
		/// اجزای تاریخ
		/// </summary>
		#region Date
		public int? Year { get; set; }
		public int? Month { get; set; }
		public int? Day { get; set; }
		#endregion /Date

		
	}
}

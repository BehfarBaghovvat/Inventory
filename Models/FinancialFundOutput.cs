using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class FinancialFundOutput
	{
		public FinancialFundOutput()
		{

		}

		#region Amount_Paid
		//-----DisplayName field for Amount_Payable
		[System.ComponentModel.DisplayName(displayName: "مبلغ پرداخت شده")]
		//--Lenght Amount_Payable
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Amount_Paid { get; set; }
		#endregion /Amount_Paid

		#region Amount_Payable
		//-----DisplayName field for Amount_Payable
		[System.ComponentModel.DisplayName(displayName: "مبلغ قابل پرداخت")]
		//--Lenght Amount_Payable
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 160)]
		public string Amount_Payable { get; set; }
		#endregion /Amount_Payable

		#region Seller_Name
		//--DisplayName field for Seller_Name
		[System.ComponentModel.DisplayName(displayName: "نام فروشنده")]
		//--Lenght Seller_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Seller_Name { get; set; }
		#endregion /Seller_Name

		#region Id
		//-----DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//-----Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }
		#endregion /Id

		#region Registration_Date
		//-----DisplayName field for RegistrationDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Registration_Date { get; set; }
		#endregion /Registration_Date

		#region Registration_Time
		//-----DisplayName field for RegistrationTime
		[System.ComponentModel.DisplayName(displayName: "زمان ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 8)]
		public string Registration_Time { get; set; }
		#endregion /Registration_Time

		#region Remaininig_Amount
		[System.ComponentModel.DisplayName(displayName: "مبلغ باقیمانده")]
		//--Lenght Amount_Payable
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Remaininig_Amount { get; set; }
		#endregion /Remaininig_Amount
	}
}

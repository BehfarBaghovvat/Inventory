
namespace Models
{
	/// <summary>
	/// جدول لیست مالی مشتریان
	/// </summary>
	public class ListFinancialClient
	{
		public enum FinantialSituation
		{
			طلبکار,
			تسویه,
			بدهکار,
		}
		public ListFinancialClient()
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
		#region Amounts_Payment
		//-----DisplayName field for Amounts_Payment
		[System.ComponentModel.DisplayName(displayName: "مبلغ قابل پرداخت")]
		//--Lenght Amounts_Payment
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 160)]
		public string Amounts_Payment { get; set; }
		#endregion /Amounts_Payment

		/// <summary>
		/// مبلغ باقی مانده
		/// </summary>
		#region Amount_Remaininig
		//-----DisplayName field for Amount_Remaininig
		[System.ComponentModel.DisplayName(displayName: "مبلغ باقیمانده")]
		//--Lenght Amount_Remaininig
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 150)]
		public string Amount_Remaininig { get; set; }
		#endregion /Amount_Remaininig

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
		/// شماره پلاک وسیله نقلیه
		/// </summary>
		#region License_Plate
		[System.ComponentModel.DisplayName(displayName: "پلاک وسیله نقیله")]
		//--Lenght LicensePlate
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]
		public string License_Plate { get; set; }
		#endregion /License_Plate

		/// <summary>
		/// شماره تماس
		/// </summary>
		#region Phone_Number
		//-----DisplayName field for Phone_Number
		[System.ComponentModel.DisplayName(displayName: "شماره تماس")]
		//--Lenght Phone_Number
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 11)]
		public string Phone_Number { get; set; }
		#endregion /Phone_Number

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

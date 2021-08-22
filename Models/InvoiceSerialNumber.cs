namespace Models
{
	/// <summary>
	/// شماره فاکتور
	/// </summary>
	public class InvoiceSerialNumber
	{
		public InvoiceSerialNumber()
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
		public uint Id { get; set; }
		#endregion /Id

		/// <summary>
		/// شماره فاکتور
		/// </summary>
		#region Invoice_Serial_Numvber
		//--DisplayName field for Invoice_Serial_Numvber
		[System.ComponentModel.DisplayName(displayName: "شماره فاکتور")]
		//--Lenght Invoice_Serial_Numvber
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Invoice_Serial_Numvber { get; set; }
		#endregion /Invoice_Serial_Numvber

		/// <summary>
		/// تاریخ ثبت
		/// </summary>
		#region Registration_Date
		//-----DisplayName field for RegistrationDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 21)]
		public string Registration_Date { get; set; }
		#endregion /Registration_Date
	}
}

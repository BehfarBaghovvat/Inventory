namespace Models
{
	public class InvoiceSerialNumber
	{
		public InvoiceSerialNumber()
		{

		}

		#region Id
		//--DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//--Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }
		#endregion /Id

		#region Invoice_Serial_Numvber
		//--DisplayName field for Id_Invoice
		[System.ComponentModel.DisplayName(displayName: "شماره فاکتور")]
		//--Lenght Id_Invoice
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Invoice_Serial_Numvber { get; set; }
		#endregion /Invoice_Serial_Numvber

		#region Registration_Date
		//-----DisplayName field for RegistrationDate
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت")]
		//--Lenght RegistrationTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Registration_Date { get; set; }
		#endregion /Registration_Date
	}
}

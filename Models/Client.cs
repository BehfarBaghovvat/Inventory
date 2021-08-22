namespace Models
{
	/// <summary>
	/// مشتری
	/// </summary>
	public class Client
	{
		public Client()
		{

		}

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
			(maximumLength: 1000)]
		public string License_Plate { get; set; }
		#endregion /License_Plate

		/// <summary>
		/// شماره تماس
		/// </summary>
		#region Phone_Number
		[System.ComponentModel.DisplayName(displayName: "شماره تماس")]
		
		public byte Phone_Number { get; set; }
		#endregion /Phone_Number

	}
}

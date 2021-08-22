using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	/// <summary>
	/// لیست خدمات مشتریان
	/// </summary>
	class ListClientService
	{

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
		/// توضیحات
		/// </summary>
		#region Description
		[System.ComponentModel.DisplayName(displayName: "توضیحات")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 1000)]
		public string Description { get; set; }
		#endregion /Description

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
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 11)]
		public string Phone_Number { get; set; }
		#endregion /Phone_Number

	}
}

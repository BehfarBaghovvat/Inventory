﻿namespace Models
{
	public class TypesService
	{
		public TypesService()
		{

		}

		#region Id
		//-----DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//-----Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }
		#endregion /Id

		#region Service_Price
		[System.ComponentModel.DisplayName(displayName: "قیمت سرویس دهی")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 150)]
		public string Service_Price { get; set; }
		#endregion /Service_Price

		#region Service_Name
		//-----DisplayName field for FullName
		[System.ComponentModel.DisplayName(displayName: "نام سرویس")]
		//--Lenght FullName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]
		public string Service_Name { get; set; }
		#endregion /Service_Name
	}
}

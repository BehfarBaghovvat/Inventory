using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	/// <summary>
	/// بانک اسامی هزینه های جانبی
	/// </summary>
	public class ListIncidentalExpenses
	{
		/// <summary>
		/// لیست اسامی هزینه ها
		/// </summary>
		#region List_Cost_Name
		//-----DisplayName field for Cost_Name
		[System.ComponentModel.DisplayName(displayName: "لیست اسامی هزینه")]
		//--Lenght Cost_Name
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string List_Cost_Name { get; set; }
		#endregion /List_Cost_Name

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
	}
}

using System.Globalization;

namespace Models
{
	public class Commodity : BaseEntity
	{
		public Commodity() : base()
		{

		}

		#region Commodity_Name
		//--Lenght CommodityName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]
		public string Commodity_Name { get; set; }
		#endregion /

		#region Commodity_Price
		//--Lenght CommodityPrice
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]
		public string Commodity_Price { get; set; }
		#endregion Commodity_Price

		#region Commodity_Unit
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Commodity_Unit { get; set; }
		#endregion /Commodity_Unit

		#region Edit_Time
		//--Lenght EditTIme
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Edit_Time { get; set; }
		#endregion /Edit_Time

		#region Quantity
		//--Lenght Quantity
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 5)]
		public string Quantity { get; set; }
		#endregion /Quantity

		#region Quantity_Crumbs
		//--Lenght RegisterTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 5)]
		public string Quantity_Crumbs { get; set; }
		#endregion /Quantity_Crumbs

		#region Register_Time
		//--Lenght RegisterTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Register_Time { get; set; }
		#endregion /Register_Time

		#region Selling_Type
		//-----StringLength SellingType
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string Selling_Type { get; set; }
		#endregion /Selling_Type
	}
}

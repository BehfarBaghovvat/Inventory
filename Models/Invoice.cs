namespace Models
{
	public class Invoice : BaseEntity
	{
		public Invoice() : base()
		{

		}

		public string Invoice_Number { get; set; }
		public string Commodity_Name { get; set; }
		public string Commodity_Price { get; set; }
		public string Quantity { get; set; }
		public string Quantity_Crumbs { get; set; }
		public string Register_Time { get; set; }
		public string Edit_Time { get; set; }

	}
}

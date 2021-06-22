namespace Models
{
	public class DataBaseContext : System.Data.Entity.DbContext
	{
		static DataBaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				( new System.Data.Entity.DropCreateDatabaseIfModelChanges<DataBaseContext>());

			//System.Data.Entity.Database.SetInitializer
			//(new System.Data.Entity.MigrateDatabaseToLatestVersion<DataBaseContext, Migrations.Configuration>());
		}

		public DataBaseContext() : base()
		{

		}

		public System.Data.Entity.DbSet<CapitalFund> CapitalFunds { get; set; }
		public System.Data.Entity.DbSet<Client> Clients { get; set; }
		public System.Data.Entity.DbSet<EventLog> EventLogs { get; set; }
		public System.Data.Entity.DbSet<FinancialFundInput> FinancialFundInputs { get; set; }
		public System.Data.Entity.DbSet<FinancialFundOutput> FinancialFundOutputs { get; set; }
		public System.Data.Entity.DbSet<InventoryHolding> InventoryHoldings { get; set; }
		public System.Data.Entity.DbSet<LoginHistory> LoginHistories { get; set; }
		public System.Data.Entity.DbSet<InventoryOutput> InventoryOutputs { get; set; }
		public System.Data.Entity.DbSet<ProductReceived> ProductReceiveds { get; set; }
		public System.Data.Entity.DbSet<Service> Services { get; set; }
		public System.Data.Entity.DbSet<TypesService> TypesServices { get; set; }
		public System.Data.Entity.DbSet<User> Users { get; set; }

	}
}

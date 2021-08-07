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

		public System.Data.Entity.DbSet<AccountsReceivable> AccountsReceivables { get; set; }
		public System.Data.Entity.DbSet<AccountsPayable> AccountsPayables { get; set; }
        public System.Data.Entity.DbSet<AncillaryCosts> AncillaryCosts { get; set; }
        public System.Data.Entity.DbSet<CapitalFund> CapitalFunds { get; set; }
		public System.Data.Entity.DbSet<Client> Clients { get; set; }
		public System.Data.Entity.DbSet<DailyFinancialReport> DailyFinancialReports { get; set; }
		public System.Data.Entity.DbSet<EventLog> EventLogs { get; set; }
		public System.Data.Entity.DbSet<GeneralJournal> GeneralJournals { get; set; }
		public System.Data.Entity.DbSet<InventoryHolding> InventoryHoldings { get; set; }
		public System.Data.Entity.DbSet<LoginHistory> LoginHistories { get; set; }
		public System.Data.Entity.DbSet<MonthlyFinancialReport> MonthlyFinancialReports { get; set; }
		public System.Data.Entity.DbSet<InvoiceSerialNumber> InvoiceSerialNumbers { get; set; }
		public System.Data.Entity.DbSet<InventoryOutput> InventoryOutputs { get; set; }
		public System.Data.Entity.DbSet<ProductReceived> ProductReceiveds { get; set; }
		public System.Data.Entity.DbSet<ProgramSetting> ProgramSettings { get; set; }
		public System.Data.Entity.DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
		public System.Data.Entity.DbSet<SalesInvoice> SalesInvoices { get; set; }
		public System.Data.Entity.DbSet<Service> Services { get; set; }
		public System.Data.Entity.DbSet<TypesService> TypesServices { get; set; }
		public System.Data.Entity.DbSet<User> Users { get; set; }
		public System.Data.Entity.DbSet<YearlyFinancialReport> YearlyFinancialReports { get; set; }
	}
}

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
		public System.Data.Entity.DbSet<BackupSetting> BackupSettings { get; set; }
        public System.Data.Entity.DbSet<CapitalFund> CapitalFunds { get; set; }
		public System.Data.Entity.DbSet<ChequeSection> ChequeSections { get; set; }
		public System.Data.Entity.DbSet<Client> Clients { get; set; }
		public System.Data.Entity.DbSet<DailyFinancialReport> DailyFinancialReports { get; set; }
		public System.Data.Entity.DbSet<EventLog> EventLogs { get; set; }
		public System.Data.Entity.DbSet<InventoryHolding> InventoryHoldings { get; set; }
		public System.Data.Entity.DbSet<InventoryOutput> InventoryOutputs { get; set; }
		public System.Data.Entity.DbSet<Journal> Journals { get; set; }
		public System.Data.Entity.DbSet<ListFinancialClient> ListFinancialClients { get; set; }
		public System.Data.Entity.DbSet<ListIncidentalExpensesName> ListIncidentalExpensesNames { get; set; }
		public System.Data.Entity.DbSet<ListPurchaseProduct> ListPurchaseProducts { get; set; }
		public System.Data.Entity.DbSet<ListSalesProduct> ListSalesProducts { get; set; }
		public System.Data.Entity.DbSet<ListService> ListServices { get; set; }
		public System.Data.Entity.DbSet<ListServiceName> ListServiceNames { get; set; }
		public System.Data.Entity.DbSet<LoginHistory> LoginHistories { get; set; }
		public System.Data.Entity.DbSet<MonthlyFinancialReport> MonthlyFinancialReports { get; set; }
		public System.Data.Entity.DbSet<ProductReceived> ProductReceiveds { get; set; }
		public System.Data.Entity.DbSet<ProgramSetting> ProgramSettings { get; set; }
		public System.Data.Entity.DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
		public System.Data.Entity.DbSet<SalesInvoice> SalesInvoices { get; set; }
		public System.Data.Entity.DbSet<ServiceInvoice> ServiceInvoices { get; set; }
		public System.Data.Entity.DbSet<User> Users { get; set; }
		public System.Data.Entity.DbSet<YearlyFinancialReport> YearlyFinancialReports { get; set; }
	}
}

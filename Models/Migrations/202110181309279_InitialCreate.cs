namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountsPayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount_Paid = c.String(maxLength: 150),
                        Amount_Payable = c.String(maxLength: 160),
                        Amount_Remaininig = c.String(maxLength: 150),
                        Description = c.String(maxLength: 1000),
                        Finantial_Situation = c.Int(nullable: false),
                        Registration_Date = c.String(maxLength: 10),
                        Registration_Time = c.String(maxLength: 8),
                        Seller_Name = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountsReceivables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount_Paid = c.String(maxLength: 60),
                        Amount_Payable = c.String(maxLength: 160),
                        Client_Name = c.String(maxLength: 60),
                        Description = c.String(maxLength: 1000),
                        Registration_Date = c.String(maxLength: 10),
                        Registration_Time = c.String(maxLength: 8),
                        Remaininig_Amount = c.String(maxLength: 60),
                        Tax_Percent = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AncillaryCosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount_Payment = c.String(maxLength: 60),
                        Cost_Name = c.String(maxLength: 25),
                        Name_Payer = c.String(maxLength: 25),
                        Registration_Date = c.String(maxLength: 10),
                        Registration_Time = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackupSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Auto_Backup = c.Boolean(nullable: false),
                        Days_Of_Week = c.Int(nullable: false),
                        Day_Of_Month = c.Int(),
                        Hour = c.Int(),
                        Minutes = c.Int(),
                        Time_Interval = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CapitalFunds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capital_Fund = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChequeSections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount_Number_Paid = c.String(),
                        Amount_Words_Received = c.String(maxLength: 1000),
                        Amount_Words_Paid = c.String(maxLength: 1000),
                        Amount_Number_Received = c.String(),
                        Data_Receipt = c.String(maxLength: 10),
                        Name_Account_Holder = c.String(maxLength: 55),
                        National_Code = c.String(maxLength: 12),
                        Pay_To = c.String(maxLength: 60),
                        Serial_Cheque = c.String(maxLength: 25),
                        Status_Chequa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Client_Name = c.String(maxLength: 60),
                        License_Plate = c.String(maxLength: 20),
                        Phone_Number = c.String(maxLength: 12),
                        Registration_Date = c.String(maxLength: 10),
                        Registration_Time = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DailyFinancialReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amounts_Paid = c.String(maxLength: 150),
                        Amounts_Payment = c.String(maxLength: 150),
                        Amounts_Received = c.String(maxLength: 150),
                        Amounts_Remaining = c.String(maxLength: 150),
                        Register_Date = c.String(maxLength: 10),
                        Register_Time = c.String(maxLength: 8),
                        Year = c.Int(),
                        Month = c.Int(),
                        Day = c.Int(),
                        Hour = c.Int(),
                        Minute = c.Int(),
                        Second = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EventLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 1000),
                        Event_Date = c.String(nullable: false, maxLength: 10),
                        Event_Time = c.String(nullable: false, maxLength: 8),
                        Full_Name = c.String(maxLength: 60),
                        Username = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true);
            
            CreateTable(
                "dbo.InventoryHoldings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Image = c.Binary(),
                        Product_Name = c.String(maxLength: 100),
                        Product_Purchase_Price = c.String(maxLength: 150),
                        Product_Quantity = c.Int(),
                        Product_Unit = c.String(),
                        Registration_Date = c.String(maxLength: 10),
                        Registration_Time = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InventoryOutputs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Add_Order_Date = c.String(maxLength: 10),
                        Add_Order_Time = c.String(maxLength: 8),
                        Carrier_Name = c.String(maxLength: 60),
                        Client_Name = c.String(maxLength: 60),
                        Phone_Number = c.String(maxLength: 12),
                        Product_Image = c.Binary(),
                        Product_Name = c.String(maxLength: 100),
                        Product_Price = c.String(maxLength: 150),
                        Product_Quantity = c.Int(),
                        Product_Unit = c.String(maxLength: 100),
                        Seller_Name = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Journals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount_Paid = c.String(),
                        Amount_Received = c.String(),
                        Description = c.String(),
                        Invoice_Serial_Numvber = c.String(maxLength: 60),
                        Registration_Date = c.String(maxLength: 10),
                        Registration_Time = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ListFinancialClients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount_Paid = c.String(maxLength: 60),
                        Amounts_Payment = c.String(maxLength: 160),
                        Amount_Remaininig = c.String(maxLength: 150),
                        Client_Name = c.String(maxLength: 60),
                        Finantial_Situation = c.Int(nullable: false),
                        License_Plate = c.String(maxLength: 20),
                        Phone_Number = c.String(maxLength: 11),
                        Registration_Date = c.String(maxLength: 10),
                        Registration_Time = c.String(maxLength: 8),
                        Tax_Percent = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ListIncidentalExpensesNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cost_Name = c.String(maxLength: 75),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ListPurchaseProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Invoice_Serial_Numvber = c.String(maxLength: 60),
                        Product_Name = c.String(maxLength: 100),
                        Product_Price = c.String(maxLength: 150),
                        Product_Quantity = c.Int(),
                        Product_Unit = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ListSalesProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Invoice_Serial_Numvber = c.String(maxLength: 60),
                        Product_Name = c.String(maxLength: 100),
                        Product_Price = c.String(maxLength: 150),
                        Product_Quantity = c.Int(),
                        Product_Unit = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ListServiceNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Service_Price = c.String(maxLength: 150),
                        Service_Name = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ListServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 3000),
                        Invoice_Serial_Numvber = c.String(maxLength: 60),
                        Repairman_Name = c.String(maxLength: 60),
                        Service_Date = c.String(maxLength: 10),
                        Service_Name = c.String(maxLength: 60),
                        Service_Number = c.Byte(),
                        Service_Price = c.String(maxLength: 150),
                        Service_Time = c.String(maxLength: 8),
                        Total_Sum_Price = c.String(maxLength: 160),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LoginHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Full_Name = c.String(nullable: false, maxLength: 55),
                        Login_Time = c.String(maxLength: 25),
                        Logout_Time = c.String(maxLength: 25),
                        Username = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Full_Name)
                .Index(t => t.Username);
            
            CreateTable(
                "dbo.MonthlyFinancialReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sum_Amount_Paid_Of_Day = c.String(nullable: false, maxLength: 150),
                        Sum_Amount_Payment_Of_Day = c.String(nullable: false, maxLength: 150),
                        Sum_Amounts_Received_Of_Day = c.String(maxLength: 150),
                        Sum_Amounts_Remaining_Of_Day = c.String(nullable: false, maxLength: 150),
                        Register_Date = c.String(maxLength: 10),
                        Year = c.Int(),
                        Month = c.Int(),
                        Day = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductReceiveds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Carrier_Name = c.String(maxLength: 60),
                        Last_Edited_Date = c.String(maxLength: 10),
                        Last_Edited_Time = c.String(maxLength: 8),
                        Number_Edit = c.Int(nullable: false),
                        Product_Image = c.Binary(),
                        Product_Name = c.String(maxLength: 100),
                        Product_Purchase_Price = c.String(maxLength: 150),
                        Product_Quantity = c.Int(),
                        Product_Unit = c.String(),
                        Registration_Date = c.String(maxLength: 10),
                        Registration_Time = c.String(maxLength: 8),
                        Sender_Name = c.String(maxLength: 60),
                        Recipient_Name = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProgramSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capital_Notification = c.Boolean(nullable: false),
                        Interval = c.Double(nullable: false),
                        Interval_Check = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PurchaseInvoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Carrier_Name = c.String(maxLength: 60),
                        Invoice_Serial_Numvber = c.String(maxLength: 60),
                        Recipient_Name = c.String(maxLength: 60),
                        Purchase_Date = c.String(maxLength: 10),
                        Purchase_Payment_Type = c.Int(nullable: false),
                        Purchase_Time = c.String(maxLength: 8),
                        Sender_Name = c.String(maxLength: 60),
                        Total_Sum_Price = c.String(maxLength: 160),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalesInvoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Carrier_Name = c.String(maxLength: 60),
                        Client_Name = c.String(maxLength: 60),
                        Invoice_Serial_Number = c.String(maxLength: 60),
                        Sales_Payment_Type = c.Int(nullable: false),
                        Payment_Cach_Type = c.Int(nullable: false),
                        Sales_Date = c.String(maxLength: 10),
                        Sales_Time = c.String(maxLength: 8),
                        Seller_Name = c.String(maxLength: 60),
                        Total_Sum_Price = c.String(maxLength: 160),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServiceInvoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Client_Name = c.String(maxLength: 100),
                        Current_Kilometer = c.String(maxLength: 20),
                        Invoice_Serial_Number = c.String(maxLength: 60),
                        License_Plate = c.String(maxLength: 11),
                        Next_Kilometer = c.String(maxLength: 20),
                        Phone_Number = c.String(maxLength: 10),
                        Service_Date = c.String(maxLength: 10),
                        Service_Time = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Access_Level = c.Int(nullable: false),
                        Edit_Date = c.String(maxLength: 10),
                        Edit_Time = c.String(maxLength: 8),
                        Is_Active = c.Boolean(nullable: false),
                        Full_Name = c.String(maxLength: 60),
                        Password = c.String(maxLength: 50),
                        Registration_Date = c.String(maxLength: 10),
                        Registration_Time = c.String(maxLength: 8),
                        User_Image = c.Binary(),
                        Username = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true);
            
            CreateTable(
                "dbo.YearlyFinancialReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sum_Amount_Paid_Of_Month = c.String(nullable: false, maxLength: 45),
                        Sum_Amount_Payment_Of_Month = c.String(nullable: false, maxLength: 45),
                        Sum_Amounts_Received_Of_Month = c.String(nullable: false, maxLength: 55),
                        Sum_Amounts_Remaining_Of_Month = c.String(nullable: false, maxLength: 150),
                        Register_Date = c.String(nullable: false, maxLength: 10),
                        Year = c.Int(),
                        Month = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.LoginHistories", new[] { "Username" });
            DropIndex("dbo.LoginHistories", new[] { "Full_Name" });
            DropIndex("dbo.EventLogs", new[] { "Username" });
            DropTable("dbo.YearlyFinancialReports");
            DropTable("dbo.Users");
            DropTable("dbo.ServiceInvoices");
            DropTable("dbo.SalesInvoices");
            DropTable("dbo.PurchaseInvoices");
            DropTable("dbo.ProgramSettings");
            DropTable("dbo.ProductReceiveds");
            DropTable("dbo.MonthlyFinancialReports");
            DropTable("dbo.LoginHistories");
            DropTable("dbo.ListServices");
            DropTable("dbo.ListServiceNames");
            DropTable("dbo.ListSalesProducts");
            DropTable("dbo.ListPurchaseProducts");
            DropTable("dbo.ListIncidentalExpensesNames");
            DropTable("dbo.ListFinancialClients");
            DropTable("dbo.Journals");
            DropTable("dbo.InventoryOutputs");
            DropTable("dbo.InventoryHoldings");
            DropTable("dbo.EventLogs");
            DropTable("dbo.DailyFinancialReports");
            DropTable("dbo.Clients");
            DropTable("dbo.ChequeSections");
            DropTable("dbo.CapitalFunds");
            DropTable("dbo.BackupSettings");
            DropTable("dbo.AncillaryCosts");
            DropTable("dbo.AccountsReceivables");
            DropTable("dbo.AccountsPayments");
        }
    }
}

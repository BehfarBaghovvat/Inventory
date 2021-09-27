using System.Linq;

namespace Inventory
{
	public partial class MainForm : Infrastructure.BaseForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region --------------------------------------------------------     Properties     --------------------------------------------------------

		#region --------------------------------------------------------     Layer     --------------------------------------------------------

		/// <summary>
		/// کلاس مربوط به تاریخ و زمان سیستم
		/// </summary>
		private class DateTimeSystem
		{
			string second, minute, hour;
			public int Hour { get; set; }
			public int Minute { get; set; }
			public int Second { get; set; }

			public int Day_Year { get; set; }
			public System.DayOfWeek Day_Week { get; set; }
			public int Day_Month { get; set; }
			public int Month { get; set; }
			public int Year { get; set; }
		}

		//------------------------------------------------------------------------- Inventory

		private Inventory_Forms.ProductBuyForm _productBuyForm;
		public Inventory_Forms.ProductBuyForm ProductBuyForm
		{
			get
			{
				if (_productBuyForm == null || _productBuyForm.IsDisposed)
				{
					_productBuyForm =
						new Inventory_Forms.ProductBuyForm();

					_productBuyForm.TopLevel = false;
					_productBuyForm.TopMost = true;
					_productBuyForm.Dock = System.Windows.Forms.DockStyle.Fill;
				}
				return _productBuyForm;
			}
		}

		private Inventory_Forms.ProductSalesForm _productSalesForm;
		public Inventory_Forms.ProductSalesForm ProductSalesForm
		{
			get
			{
				if (_productSalesForm == null || _productSalesForm.IsDisposed == true)
				{
					_productSalesForm =
						new Inventory_Forms.ProductSalesForm();

					_productSalesForm.TopLevel = false;
					_productSalesForm.TopMost = true;
					_productSalesForm.Dock = System.Windows.Forms.DockStyle.Fill;
				}
				return _productSalesForm;
			}
		}

		private Inventory_Forms.InventoryForm _inventoryForm;
		public Inventory_Forms.InventoryForm InventoryForm
		{
			get
			{
				if (_inventoryForm == null || _inventoryForm.IsDisposed == true)
				{
					_inventoryForm =
						new Inventory_Forms.InventoryForm();

					_inventoryForm.TopLevel = false;
					_inventoryForm.TopMost = true;
					_inventoryForm.Dock = System.Windows.Forms.DockStyle.Fill;
				}
				return _inventoryForm;
			}
		}

		private Inventory_Forms.ServiceForm _serviceForm;
		public Inventory_Forms.ServiceForm ServiceForm
		{
			get
			{
				if (_serviceForm == null || _serviceForm.IsDisposed == true)
				{
					_serviceForm =
						new Inventory_Forms.ServiceForm();

					_serviceForm.TopLevel = false;
					_serviceForm.TopMost = true;
					_serviceForm.Dock = System.Windows.Forms.DockStyle.Fill;
				}
				return _serviceForm;
			}
		}

		//------------------------------------------------------------------------- Financial

		private Financial_Form.SafeBoxForm _safeBoxForm;
		public Financial_Form.SafeBoxForm SafeBoxForm
		{
			get
			{
				if (_safeBoxForm == null || _safeBoxForm.IsDisposed == true)
				{
					_safeBoxForm =
						new Financial_Form.SafeBoxForm();

					_safeBoxForm.TopLevel = false;
					_safeBoxForm.TopMost = true;
					_safeBoxForm.Dock = System.Windows.Forms.DockStyle.Fill;
				}
				return _safeBoxForm;
			}
			set
			{
				_safeBoxForm = value;
			}
		}

		private Financial_Form.AncillaryCostsForm _ancillaryCostsForm;
		public Financial_Form.AncillaryCostsForm AncillaryCostsForm
		{
			get
			{
				if (_ancillaryCostsForm == null || _ancillaryCostsForm.IsDisposed == true)
				{
					_ancillaryCostsForm =
						new Financial_Form.AncillaryCostsForm();

					_ancillaryCostsForm.TopLevel = false;
					_ancillaryCostsForm.TopMost = true;
					_ancillaryCostsForm.Dock = System.Windows.Forms.DockStyle.Fill;

				}
				return _ancillaryCostsForm;
			}
			set
			{
				_ancillaryCostsForm = value;
			}
		}

		private Financial_Form.FinancialReportForm _financialReportForm;
		public Financial_Form.FinancialReportForm FinancialReportForm
		{
			get
			{
				if (_financialReportForm == null || _financialReportForm.IsDisposed == true)
				{
					_financialReportForm =
						new Financial_Form.FinancialReportForm();

					_financialReportForm.TopLevel = false;
					_financialReportForm.TopMost = true;
					_financialReportForm.Dock = System.Windows.Forms.DockStyle.Fill;
				}
				return _financialReportForm;
			}
			set
			{
				_financialReportForm = value;
			}
		}

		private Financial_Form.SectionChequeBankForm _sectionChequeBankForm;
		public Financial_Form.SectionChequeBankForm SectionChequeBankForm
		{
			get
			{
				if (_sectionChequeBankForm == null || _sectionChequeBankForm.IsDisposed == true)
				{
					_sectionChequeBankForm =
						new Financial_Form.SectionChequeBankForm();

					_sectionChequeBankForm.TopLevel = false;
					_sectionChequeBankForm.TopMost = true;
					_sectionChequeBankForm.Dock = System.Windows.Forms.DockStyle.Fill;
				}
				return _sectionChequeBankForm;
			}
			set
			{
				_sectionChequeBankForm = value;
			}
		}

		//------------------------------------------------------------------------- CLient

		private Client_Forms.RegisterClientForm _registerClientForm;
		public Client_Forms.RegisterClientForm RegisterClientForm
		{
			get
			{
				if (_registerClientForm == null || _registerClientForm.IsDisposed == true)
				{
					_registerClientForm =
						new Client_Forms.RegisterClientForm();

					_registerClientForm.TopLevel = false;
					_registerClientForm.TopMost = true;
					_registerClientForm.Dock = System.Windows.Forms.DockStyle.Fill;
				}
				return _registerClientForm;
			}
			set
			{
				_registerClientForm = value;
			}
		}

		private Client_Forms.ClientFinancialSituationForm _clientFinancialSituationForm;
		public Client_Forms.ClientFinancialSituationForm ClientFinancialSituationForm
		{
			get
			{
				if (_clientFinancialSituationForm == null || _clientFinancialSituationForm.IsDisposed == true)
				{
					_clientFinancialSituationForm =
						new Client_Forms.ClientFinancialSituationForm();

					_clientFinancialSituationForm.TopLevel = false;
					_clientFinancialSituationForm.TopMost = true;
					_clientFinancialSituationForm.Dock = System.Windows.Forms.DockStyle.Fill;
				}
				return _clientFinancialSituationForm;
			}
			set
			{
				_clientFinancialSituationForm = value;
			}
		}

		//------------------------------------------------------------------------- Setting

		private Setting_Forms.ManagementSettingForm _managementSettingForm;
		public Setting_Forms.ManagementSettingForm ManagementSettingForm
		{
			get
			{
				if (_managementSettingForm == null || _managementSettingForm.IsDisposed == true)
				{
					_managementSettingForm =
						new Setting_Forms.ManagementSettingForm();

					_managementSettingForm.TopLevel = false;
					_managementSettingForm.TopMost = true;
					_managementSettingForm.Dock = System.Windows.Forms.DockStyle.Fill;
				}
				return _managementSettingForm;
			}
			set
			{
				_managementSettingForm = value;
			}
		}

		private Setting_Forms.BackupSettingForm _backupSettingForm;
		public Setting_Forms.BackupSettingForm BackupSettingForm
		{
			get
			{
				if (_backupSettingForm == null || _backupSettingForm.IsDisposed == true)
				{
					_backupSettingForm =
						new Setting_Forms.BackupSettingForm();

					_backupSettingForm.TopLevel = false;
					_backupSettingForm.TopMost = true;
					_backupSettingForm.Dock = System.Windows.Forms.DockStyle.Fill;
				}
				return _backupSettingForm;
			}
			set
			{
				_backupSettingForm = value;
			}
		}

		#endregion /--------------------------------------------------------     Layer     --------------------------------------------------------
		public enum AccessLeve
		{
			مدیریت,
			معاونت,
			کارمند,
			نیروی_خدماتی,
			کاربر_ساده,
		}

		public Models.EventLog EventLog { get; set; }

		private Models.LoginHistory _logHistory;
		public Models.LoginHistory LogHistory
		{
			get
			{
				if (_logHistory == null)
				{
					_logHistory =
						new Models.LoginHistory();
				}
				return _logHistory;
			}
		}

		private DateTimeSystem _dateTimeSystem =
			new DateTimeSystem();

		System.Data.SqlClient.SqlConnection sqlConnection =
			new System.Data.SqlClient.SqlConnection(Inventory.Properties.Settings.Default.INVENTORYConnectionString);

		#endregion /--------------------------------------------------------     Properties     --------------------------------------------------------



		//-----------------------------------------------------------------------------------------------     Constracture

		public MainForm()
		{
			InitializeComponent();

		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region          -------------------------------     MainForm     -------------------------------

		#region MainForm_Load
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /MainForm_Load

		#region MainForm_FormClosing
		private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") == 0 || string.IsNullOrEmpty(Inventory.Program.UserAuthentication.Username))
			{
				return;
			}
			else
			{
				Infrastructure.Utility.SaveLogOutTime(Inventory.Program.SavaLogHistory);
			}
		}
		#endregion /MainForm_FormClosing

		#region FadeInMainFormTimer_Tick
		private void FadeInMainFormTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity += 0.01;

			if (this.Opacity >= 0.95)
			{
				fadeInMainFormTimer.Stop();
			}
		}
		#endregion /FadeInMainFormTimer_Tick

		#region ShutDownMainFormTime_Tick
		private void ShutDownMainFormTime_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.1;

			if (this.Opacity <= 0.0)
			{
				shutDownMainFormTime.Stop();
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /ShutDownMainFormTime_Tick

		#endregion /          -------------------------------     MainForm     -------------------------------

		#region ShutDownButton_Click
		private void ShutDownButton_Click(object sender, System.EventArgs e)
		{
			if (Mbb.Windows.Forms.MessageBox.Show(text: "از برنامه خارج می شوید؟", caption: "خروج", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
			{
				shutDownMainFormTime.Start();
			}
			else
			{
				return;
			}
		}
		#endregion /ShutDownButton_Click

		#region LogOutMainFormTimer_Tick
		private void LogOutMainFormTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.05;

			if (this.Opacity == 0.0)
			{
				shutDownMainFormTime.Stop();
				this.Dispose();
				Inventory.Program.SingInLoaded();
			}
		}
		#endregion /LogOutMainFormTimer_Tick

		#region LogoutButton_Click
		private void LogoutButton_Click(object sender, System.EventArgs e)
		{
			if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") == 0)
			{
				logOutMainFormTimer.Start();
			}
			else
			{
				if (Mbb.Windows.Forms.MessageBox.Show(text: "از حساب کاربری خود خارج می شوید؟", caption: "خروج از حساب", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					logOutMainFormTimer.Start();
				}
				else
				{
					return;
				}
			}
		}
		#endregion /LogoutButton_Click

		#region HomeButton_Click
		private void HomeButton_Click(object sender, System.EventArgs e)
		{
			if (homeButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(homePanel);
				homeButton.Checked = true;

				dropUpInventoryTimer.Start();
				dropDownInventoryTimer.Stop();
				dropUpFinancialTimer.Start();
				dropDownFinancialTimer.Stop();
				dropUpClitntTimer.Start();
				dropDownClitntTimer.Stop();
				dropUpSettingTimer.Start();
				dropDownSettingTimer.Stop();

				//-------------------------------------------- Inventory


				inventoryButton.Checked = false;
				ProductBuyForm.Hide();
				ProductSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();
				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				//-------------------------------------------- Financial

				fainancialButton.Checked = false;
				FinancialReportForm.Hide();
				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();
				ancillaryCostsButton.Checked = false;
				financialReportButton.Checked = false;
				safeBoxButton.Checked = false;
				sectionChequeBankButton.Checked = false;

				//-------------------------------------------- Client

				clientButton.Checked = false;
				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();
				registerClientButton.Checked = false;
				clientFinancialSituationButton.Checked = false;

				//-------------------------------------------- Setting

				settingButton.Checked = false;
				ManagementSettingForm.Hide();
				BackupSettingForm.Hide();
				managementSettingsButton.Checked = false;
				backupSettingsButton.Checked = false;
			}
		}
		#endregion /HomeButton_Click

		#region                         -----------     Inventory     ----------

		#region InventoryButton_Click
		private void InventoryButton_Click(object sender, System.EventArgs e)
		{
			if (inventoryButton.Checked)
			{
				return;
			}
			else
			{
				dropDownInventoryTimer.Start();
				dropUpInventoryTimer.Stop();
				dropUpFinancialTimer.Start();

				dropUpFinancialTimer.Start();
				dropDownFinancialTimer.Stop();
				dropUpClitntTimer.Start();
				dropDownClitntTimer.Stop();
				dropUpSettingTimer.Start();
				dropDownSettingTimer.Stop();

				homeButton.Checked = false;
				inventoryButton.Checked = true;
				fainancialButton.Checked = false;
				clientButton.Checked = false;
				settingButton.Checked = false;
			}
		}
		#endregion /InventoryButton_Click

		#region SubmenuInventory

		#region InventoryEntryButton_Click
		private void InventoryEntryButton_Click(object sender, System.EventArgs e)
		{
			if (inventoryEntryButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(ProductBuyForm);
				ProductBuyForm.Initialize();
				ProductBuyForm.Show();

				ProductSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				AncillaryCostsForm.Hide();
				FinancialReportForm.Hide();
				SafeBoxForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

				ManagementSettingForm.Hide();
				BackupSettingForm.Hide();

				homeButton.Checked = false;
				inventoryEntryButton.Checked = true;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialReportButton.Checked = false;
				safeBoxButton.Checked = false;
				sectionChequeBankButton.Checked = false;

				registerClientButton.Checked = false;
				clientFinancialSituationButton.Checked = false;

				managementSettingsButton.Checked = false;
				backupSettingsButton.Checked = false;
			}
		}
		#endregion /InventoryEntryButton_Click

		#region ProductSalesButton_Click
		private void ProductSalesButton_Click(object sender, System.EventArgs e)
		{
			if (productSalesButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(ProductSalesForm);
				ProductSalesForm.Initialize();
				ProductSalesForm.Show();

				ProductBuyForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				AncillaryCostsForm.Hide();
				FinancialReportForm.Hide();
				SafeBoxForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

				ManagementSettingForm.Hide();
				BackupSettingForm.Hide();

				homeButton.Checked = false;
				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = true;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialReportButton.Checked = false;
				safeBoxButton.Checked = false;
				sectionChequeBankButton.Checked = false;

				registerClientButton.Checked = false;
				clientFinancialSituationButton.Checked = false;

				managementSettingsButton.Checked = false;
				backupSettingsButton.Checked = false;
			}
		}
		#endregion /ProductSalesButton_Click

		#region InventoryholdingButton_Click
		private void InventoryholdingButton_Click(object sender, System.EventArgs e)
		{
			if (inventoryholdingButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(InventoryForm);
				InventoryForm.Initialize();
				InventoryForm.Show();

				ProductBuyForm.Hide();
				ProductSalesForm.Hide();
				ServiceForm.Hide();

				AncillaryCostsForm.Hide();
				FinancialReportForm.Hide();
				SafeBoxForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

				ManagementSettingForm.Hide();
				BackupSettingForm.Hide();

				homeButton.Checked = false;
				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = true;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialReportButton.Checked = false;
				safeBoxButton.Checked = false;
				sectionChequeBankButton.Checked = false;

				registerClientButton.Checked = false;
				clientFinancialSituationButton.Checked = false;

				managementSettingsButton.Checked = false;
				backupSettingsButton.Checked = false;
			}
		}
		#endregion /InventoryholdingButton_Click

		#region ServiceButton_Click
		private void ServiceButton_Click(object sender, System.EventArgs e)
		{
			if (serviceButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(ServiceForm);
				ServiceForm.Initialize();
				ServiceForm.Show();

				ProductBuyForm.Hide();
				ProductSalesForm.Hide();
				InventoryForm.Hide();

				AncillaryCostsForm.Hide();
				FinancialReportForm.Hide();
				SafeBoxForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

				ManagementSettingForm.Hide();
				BackupSettingForm.Hide();

				homeButton.Checked = false;
				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = true;

				ancillaryCostsButton.Checked = false;
				financialReportButton.Checked = false;
				safeBoxButton.Checked = false;
				sectionChequeBankButton.Checked = false;

				registerClientButton.Checked = false;
				clientFinancialSituationButton.Checked = false;

				managementSettingsButton.Checked = false;
				backupSettingsButton.Checked = false;
			}
		}
		#endregion /ServiceButton_Click

		#endregion /SubmenuInventory

		#region DropDownInventoryTimer_Tick
		private void DropDownInventoryTimer_Tick(object sender, System.EventArgs e)
		{
			submenuInventoryPanel.Height += 10;
			if (submenuInventoryPanel.Height >= 155)
			{
				dropDownInventoryTimer.Stop();
			}
		}
		#endregion /DropDownInventoryTimer_Tick

		#region DropUpInventoryTimer_Tick
		private void DropUpInventoryTimer_Tick(object sender, System.EventArgs e)
		{
			submenuInventoryPanel.Height -= 10;
			if (submenuInventoryPanel.Height <= 0)
			{
				dropUpInventoryTimer.Stop();
			}
		}
		#endregion /DropUpInventoryTimer_Tick 

		#endregion /                        -----------     Inventory     ----------

		#region                         -----------     Financial     ----------

		#region FainancialButton_Click
		private void FainancialButton_Click(object sender, System.EventArgs e)
		{
			if (fainancialButton.Checked)
			{
				return;
			}
			else
			{
				fainancialButton.Checked = true;
				dropDownFinancialTimer.Start();
				dropUpFinancialTimer.Stop();

				dropUpInventoryTimer.Start();
				dropDownInventoryTimer.Stop();
				dropUpClitntTimer.Start();
				dropDownClitntTimer.Stop();
				dropUpSettingTimer.Start();
				dropDownSettingTimer.Stop();

				homeButton.Checked = false;
				inventoryButton.Checked = false;
				clientButton.Checked = false;
				settingButton.Checked = false;


			}
		}
		#endregion /FainancialButton_Click 

		#region SubmenuFinancial

		#region SafeBoxButton_Click
		private void SafeBoxButton_Click(object sender, System.EventArgs e)
		{
			if (safeBoxButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(SafeBoxForm);
				SafeBoxForm.Initialize();
				SafeBoxForm.Show();

				ProductBuyForm.Hide();
				ProductSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				AncillaryCostsForm.Hide();
				FinancialReportForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

				ManagementSettingForm.Hide();
				BackupSettingForm.Hide();

				homeButton.Checked = false;

				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialReportButton.Checked = false;
				safeBoxButton.Checked = true;
				sectionChequeBankButton.Checked = false;

				registerClientButton.Checked = false;
				clientFinancialSituationButton.Checked = false;

				managementSettingsButton.Checked = false;
				backupSettingsButton.Checked = false;
			}
		}
		#endregion /SafeBoxButton_Click

		#region AncillaryCostsButton_Click
		private void AncillaryCostsButton_Click(object sender, System.EventArgs e)
		{
			if (ancillaryCostsButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(AncillaryCostsForm);
				AncillaryCostsForm.Initialize();
				AncillaryCostsForm.Show();

				ProductBuyForm.Hide();
				ProductSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				FinancialReportForm.Hide();
				SafeBoxForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

				ManagementSettingForm.Hide();
				BackupSettingForm.Hide();

				homeButton.Checked = false;

				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = true;
				financialReportButton.Checked = false;
				safeBoxButton.Checked = false;
				sectionChequeBankButton.Checked = false;

				registerClientButton.Checked = false;
				clientFinancialSituationButton.Checked = false;

				managementSettingsButton.Checked = false;
				backupSettingsButton.Checked = false;
			}
		}
		#endregion /AncillaryCostsButton_Click

		#region FinancialOrderButton_Click
		private void FinancialOrderButton_Click(object sender, System.EventArgs e)
		{
			if (financialReportButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(FinancialReportForm);
				FinancialReportForm.Initialize();
				FinancialReportForm.Show();

				ProductBuyForm.Hide();
				ProductSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

				ManagementSettingForm.Hide();
				BackupSettingForm.Hide();

				homeButton.Checked = false;

				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialReportButton.Checked = true;
				safeBoxButton.Checked = false;
				sectionChequeBankButton.Checked = false;

				registerClientButton.Checked = false;
				clientFinancialSituationButton.Checked = false;

				managementSettingsButton.Checked = false;
				backupSettingsButton.Checked = false;
			}
		}
		#endregion /FinancialOrderButton_Click

		#region SectionChequeBankButton_Click
		private void SectionChequeBankButton_Click(object sender, System.EventArgs e)
		{
			if (sectionChequeBankButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(SectionChequeBankForm);
				SectionChequeBankForm.Show();

				ProductBuyForm.Hide();
				ProductSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				FinancialReportForm.Hide();
				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

				ManagementSettingForm.Hide();
				BackupSettingForm.Hide();

				homeButton.Checked = false;

				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialReportButton.Checked = false;
				safeBoxButton.Checked = false;
				sectionChequeBankButton.Checked = true;

				registerClientButton.Checked = false;
				clientFinancialSituationButton.Checked = false;

				managementSettingsButton.Checked = false;
				backupSettingsButton.Checked = false;
			}
		}
		#endregion /SectionChequeBankButton_Click

		#endregion /SubmenuFinancial

		#region DropDownFinancialTimer_Tick
		private void DropDownFinancialTimer_Tick(object sender, System.EventArgs e)
		{
			submenuFinancialPanel.Height += 10;
			if (submenuFinancialPanel.Height >= 155)
			{
				dropDownFinancialTimer.Stop();
			}
		}
		#endregion /DropDownFinancialTimer_Tick

		#region DropUpFinancialTimer_Tick
		private void DropUpFinancialTimer_Tick(object sender, System.EventArgs e)
		{
			submenuFinancialPanel.Height -= 10;
			if (submenuFinancialPanel.Height <= 0)
			{
				dropUpFinancialTimer.Stop();
			}
		}
		#endregion /DropUpFinancialTimer_Tick

		#endregion /                    -----------     Financial     ----------

		#region                         -----------     Client     ----------

		#region ClientButton_Click
		private void ClientButton_Click(object sender, System.EventArgs e)
		{
			if (clientButton.Checked)
			{
				return;
			}
			else
			{
				clientButton.Checked = true;
				dropDownClitntTimer.Start();
				dropUpClitntTimer.Stop();

				dropUpInventoryTimer.Start();
				dropDownInventoryTimer.Stop();
				dropUpFinancialTimer.Start();
				dropDownFinancialTimer.Stop();
				dropUpSettingTimer.Start();
				dropDownSettingTimer.Stop();

				homeButton.Checked = false;
				inventoryButton.Checked = false;
				fainancialButton.Checked = false;
				settingButton.Checked = false;
			}
		}
		#endregion /ClientButton_Click 

		#region SubmenuClient

		#region RegisterClientButton_Click
		private void RegisterClientButton_Click(object sender, System.EventArgs e)
		{
			if (registerClientButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(RegisterClientForm);
				RegisterClientForm.Initialize();
				RegisterClientForm.Show();

				ProductBuyForm.Hide();
				ProductSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				FinancialReportForm.Hide();
				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();

				ClientFinancialSituationForm.Hide();

				ManagementSettingForm.Hide();
				BackupSettingForm.Hide();

				homeButton.Checked = false;

				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialReportButton.Checked = false;
				safeBoxButton.Checked = false;
				sectionChequeBankButton.Checked = false;

				registerClientButton.Checked = true;
				clientFinancialSituationButton.Checked = false;

				managementSettingsButton.Checked = false;
				backupSettingsButton.Checked = false;
			}
		}
		#endregion /RegisterClientButton_Click

		#region ClientFinancialSituationGradientButton_Click
		private void ClientFinancialSituationButton_Click(object sender, System.EventArgs e)
		{
			if (clientFinancialSituationButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(ClientFinancialSituationForm);
				ClientFinancialSituationForm.Initialize();
				ClientFinancialSituationForm.Show();

				ProductBuyForm.Hide();
				ProductSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				FinancialReportForm.Hide();
				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();

				RegisterClientForm.Hide();

				ManagementSettingForm.Hide();
				BackupSettingForm.Hide();

				homeButton.Checked = false;

				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialReportButton.Checked = false;
				safeBoxButton.Checked = false;
				sectionChequeBankButton.Checked = false;

				registerClientButton.Checked = false;
				clientFinancialSituationButton.Checked = true;

				managementSettingsButton.Checked = false;
				backupSettingsButton.Checked = false;
			}
		}
		#endregion /ClientFinancialSituationGradientButton_Click

		#endregion /SubmenuClient

		#region DropDownClitntTimer_Tick
		private void DropDownClitntTimer_Tick(object sender, System.EventArgs e)
		{
			submenuClientPanel.Height += 10;
			if (submenuClientPanel.Height >= 120)
			{
				dropDownClitntTimer.Stop();
			}
		}
		#endregion /DropDownClitntTimer_Tick

		#region DropUpClitntTimer_Tick
		private void DropUpClitntTimer_Tick(object sender, System.EventArgs e)
		{
			submenuClientPanel.Height -= 10;
			if (submenuClientPanel.Height <= 0)
			{
				dropUpClitntTimer.Stop();
			}
		}
		#endregion /DropUpClitntTimer_Tick

		#endregion /                    -----------     Client     ----------

		#region                         -----------     Setting     ----------

		#region SettingButton_Click
		private void SettingButton_Click(object sender, System.EventArgs e)
		{
			if (settingButton.Checked)
			{
				return;
			}
			else
			{
				settingButton.Checked = true;
				dropDownSettingTimer.Start();
				dropUpSettingTimer.Stop();

				dropUpInventoryTimer.Start();
				dropDownInventoryTimer.Stop();
				dropUpFinancialTimer.Start();
				dropDownFinancialTimer.Stop();
				dropUpClitntTimer.Start();
				dropDownClitntTimer.Stop();

				homeButton.Checked = false;
				inventoryButton.Checked = false;
				fainancialButton.Checked = false;
				clientButton.Checked = false;
			}
		}
		#endregion /SettingButton_Click 

		#region SubmenuSetting

		#region ManagementSettingsButton_Click
		private void ManagementSettingsButton_Click(object sender, System.EventArgs e)
		{
			if (managementSettingsButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(ManagementSettingForm);
				ManagementSettingForm.Initialize();
				ManagementSettingForm.Show();

				ProductBuyForm.Hide();
				ProductSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				FinancialReportForm.Hide();
				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

				BackupSettingForm.Hide();

				homeButton.Checked = false;

				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialReportButton.Checked = false;
				safeBoxButton.Checked = false;
				sectionChequeBankButton.Checked = false;

				registerClientButton.Checked = false;
				clientFinancialSituationButton.Checked = false;

				managementSettingsButton.Checked = true;
				backupSettingsButton.Checked = false;


			}
		}
		#endregion /ManagementSettingsButton_Click

		#region BackupSettingsButton_Click
		private void BackupSettingsButton_Click(object sender, System.EventArgs e)
		{
			if (backupSettingsButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(BackupSettingForm);
				BackupSettingForm.Initialize();
				BackupSettingForm.Show();

				ProductBuyForm.Hide();
				ProductSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				FinancialReportForm.Hide();
				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

				ManagementSettingForm.Hide();

				homeButton.Checked = false;

				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialReportButton.Checked = false;
				safeBoxButton.Checked = false;
				sectionChequeBankButton.Checked = false;

				registerClientButton.Checked = false;
				clientFinancialSituationButton.Checked = false;

				managementSettingsButton.Checked = false;
				backupSettingsButton.Checked = true;
			}
		}
		#endregion /BackupSettingsButton_Click

		#endregion /SubmenuSetting

		#region DropDownSettingTimer_Tick
		private void DropDownSettingTimer_Tick(object sender, System.EventArgs e)
		{
			submenuSettingPanel.Height += 10;
			if (submenuSettingPanel.Height >= 85)
			{
				dropDownSettingTimer.Stop();
			}
		}
		#endregion /DropDownSettingTimer_Tick

		#region DropUpSettingTimer_Tick
		private void DropUpSettingTimer_Tick(object sender, System.EventArgs e)
		{
			submenuSettingPanel.Height -= 10;
			if (submenuSettingPanel.Height <= 0)
			{
				dropUpSettingTimer.Stop();
			}
		}
		#endregion /DropUpSettingTimer_Tick

		#endregion /                    -----------     Setting     ----------

		#region ClockTimer_Tick
		private void ClockTimer_Tick(object sender, System.EventArgs e)
		{
			string second, minute, hour;
			string finalSecond, finalMinute, finalHour;
			int month, day;

			_dateTimeSystem.Second = System.DateTime.Now.Second;
			second = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
			secondsLabel.Text = second;

			_dateTimeSystem.Minute = System.DateTime.Now.Minute;
			minute = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			minutesLabel.Text = minute;

			_dateTimeSystem.Hour = System.DateTime.Now.Hour;
			hour = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
			hoursLabel.Text = hour;

			finalSecond = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
			finalMinute = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			finalHour = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');

			System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

			_dateTimeSystem.Day_Month = persianCalendar.GetDayOfMonth(System.DateTime.Now);
			_dateTimeSystem.Day_Year = persianCalendar.GetDayOfYear(System.DateTime.Now);
			_dateTimeSystem.Day_Week = persianCalendar.GetDayOfWeek(System.DateTime.Now);
			_dateTimeSystem.Month = persianCalendar.GetMonth(System.DateTime.Now);
			_dateTimeSystem.Year = persianCalendar.GetYear(System.DateTime.Now);


			if (GetAutomaticBackupStatus())
			{
				GetBackupTime(_dateTimeSystem);
			}
			else
			{
				return;
			}

			#region MonthlyFinancialCalculation
			if (string.Compare(finalHour, "23") == 0 && string.Compare(finalMinute, "55") == 0 && string.Compare(finalSecond, "00") == 0)
			{
				MonthlyFinancialCalculation();
			}
			#endregion /MonthlyFinancialCalculation

			#region AnnualFinancialCalculation
			if (((_dateTimeSystem.Month >= 1 || _dateTimeSystem.Month <= 6) && _dateTimeSystem.Day_Month == 31) && (string.Compare(finalHour, "23") == 0 && string.Compare(finalMinute, "55") == 0 && string.Compare(finalSecond, "00") == 0))
			{
				AnnualFinancialCalculation();
			}
			else if (((_dateTimeSystem.Month >= 7 || _dateTimeSystem.Month <= 11) && _dateTimeSystem.Day_Month == 30) && (string.Compare(finalHour, "23") == 0 && string.Compare(finalMinute, "55") == 0 && string.Compare(finalSecond, "00") == 0))
			{
				AnnualFinancialCalculation();
			}
			else if ((_dateTimeSystem.Month == 12 && _dateTimeSystem.Day_Month == 29) && (string.Compare(finalHour, "23") == 0 && string.Compare(finalMinute, "55") == 0 && string.Compare(finalSecond, "00") == 0))
			{
				AnnualFinancialCalculation();
			}
			#endregion /AnnualFinancialCalculation
		}
		#endregion /ClockTimer_Tick



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founcitons

		#region AccountLoaded
		/// <summary>
		/// بارگزاری حساب کاربری
		/// </summary>
		private void AccountLoaded()
		{
			if (Inventory.Program.UserAuthentication == null)
			{
				return;
			}
			else
			{
				var byteImage = Program.UserAuthentication.User_Image;
				if (byteImage != null)
				{
					using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
					{
						userImagePictureBox.Image = System.Drawing.Image.FromStream(ms);
					}
				}
				else
				{
					return;
				}

				if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin", true) == 0)
				{
					return;
				}
				else
				{
					CheckAccessLevel(Inventory.Program.UserAuthentication.Access_Level);
					SaveLoginHistory(Program.UserAuthentication);
				}
			}
		}
		#endregion /AccountLoaded

		#region AnnualFinancialCalculation
		/// <summary>
		/// تهیه نمودار مالی برای هر سال
		/// </summary>
		private void AnnualFinancialCalculation()
		{
			System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(System.DateTime.Now);
			int month = persianCalendar.GetMonth(System.DateTime.Now);

			string dateNow = $"{year}";

			decimal sumAmountPayment = 0;
			decimal resultSumAmountPayment = 0;
			decimal sumAmountPaid = 0;
			decimal resultSumAmountPaid = 0;
			decimal sumAmountReceived = 0;
			decimal resultSumAmountReceived = 0;
			decimal sumAmountRemaining = 0;
			decimal resultSumAmountRemaining = 0;

			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.MonthlyFinancialReport> listMonthlyFinancialReports =
					dataBaseContext.MonthlyFinancialReports
					.Where(current => current.Register_Date.Contains(dateNow))
					.OrderBy(current => current.Month)
					.ToList();

				if (listMonthlyFinancialReports != null)
				{
					foreach (var item in listMonthlyFinancialReports)
					{
						sumAmountPayment = decimal.Parse(item.Sum_Amount_Payment_Of_Day.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						resultSumAmountPayment += sumAmountPayment;

						sumAmountPaid = decimal.Parse(item.Sum_Amount_Payment_Of_Day.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						resultSumAmountPaid += sumAmountPaid;

						sumAmountReceived = decimal.Parse(item.Sum_Amount_Payment_Of_Day.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						resultSumAmountReceived += sumAmountReceived;

						sumAmountRemaining = decimal.Parse(item.Sum_Amount_Payment_Of_Day.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						resultSumAmountRemaining += sumAmountRemaining;
					}
				}

				Models.YearlyFinancialReport yearlyFinancialReport = new Models.YearlyFinancialReport
				{
					Sum_Amount_Paid_Of_Month = sumAmountPaid.ToString(),
					Sum_Amount_Payment_Of_Month = resultSumAmountPayment.ToString(),
					Sum_Amounts_Received_Of_Month = resultSumAmountReceived.ToString(),
					Sum_Amounts_Remaining_Of_Month = resultSumAmountRemaining.ToString(),
					Register_Date = dateNow,
					Year = year,
					Month = month,
				};

				dataBaseContext.YearlyFinancialReports.Add(yearlyFinancialReport);
				dataBaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /AnnualFinancialCalculation

		#region CheckAccessLevel
		/// <summary>
		/// بررسی سطح دسترسی کاربر
		/// </summary>
		/// <param name="_accessLeve"></param>
		private void CheckAccessLevel(Models.User.AccessLeve _accessLeve)
		{
			switch (_accessLeve)
			{
				case Models.User.AccessLeve.مدیریت:

				inventoryEntryButton.Enabled = true;
				productSalesButton.Enabled = true;
				inventoryholdingButton.Enabled = true;
				serviceButton.Enabled = true;

				ancillaryCostsButton.Enabled = true;
				financialReportButton.Enabled = true;
				safeBoxButton.Enabled = true;
				sectionChequeBankButton.Enabled = true;

				clientFinancialSituationButton.Enabled = true;
				registerClientButton.Enabled = true;

				backupSettingsButton.Enabled = true;
				managementSettingsButton.Enabled = true;
				break;

				case Models.User.AccessLeve.معاونت:

				inventoryEntryButton.Enabled = true;
				productSalesButton.Enabled = true;
				inventoryholdingButton.Enabled = true;
				serviceButton.Enabled = true;

				ancillaryCostsButton.Enabled = true;
				financialReportButton.Enabled = true;
				safeBoxButton.Enabled = true;
				sectionChequeBankButton.Enabled = true;

				clientFinancialSituationButton.Enabled = true;
				registerClientButton.Enabled = true;

				backupSettingsButton.Enabled = true;
				managementSettingsButton.Enabled = false;

				break;

				case Models.User.AccessLeve.کارمند:

				inventoryEntryButton.Enabled = true;
				productSalesButton.Enabled = true;
				inventoryholdingButton.Enabled = true;
				serviceButton.Enabled = true;

				safeBoxButton.Enabled = true;
				ancillaryCostsButton.Enabled = true;
				financialReportButton.Enabled = false;
				sectionChequeBankButton.Enabled = true;

				registerClientButton.Enabled = true;
				clientFinancialSituationButton.Enabled = false;

				backupSettingsButton.Enabled = true;
				managementSettingsButton.Enabled = false;

				break;

				case Models.User.AccessLeve.کاربر_ساده:

				inventoryEntryButton.Enabled = true;
				productSalesButton.Enabled = false;
				inventoryholdingButton.Enabled = true;
				serviceButton.Enabled = false;

				safeBoxButton.Enabled = false;
				ancillaryCostsButton.Enabled = false;
				financialReportButton.Enabled = false;
				sectionChequeBankButton.Enabled = false;

				registerClientButton.Enabled = true;
				clientFinancialSituationButton.Enabled = false;

				backupSettingsButton.Enabled = false;
				managementSettingsButton.Enabled = false;

				break;

				default:
				break;
			}
		}
		#endregion /CheckAccessLevel

		#region DatabaseBackup
		/// <summary>
		/// تهیه نسخه پشتیبان از بانک اطلاعاتی 
		/// بر اساس زمان بندی تعیین شده
		/// </summary>
		private void DatabaseBackup()
		{
			string dataBase = sqlConnection.Database.ToString();
			try
			{
				string command = $"Backup Database [{dataBase}] To Disk='D:\\BackupDatabase\\Database-{System.DateTime.Now:yyyy-MM-dd--HH-mm-ss}.bak'";
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
				System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection();
				System.Data.SqlClient.SqlCommand sqlCommand = null;

				sqlConnection.ConnectionString = ($"Data Source=.; Initial Catalog={dataBase}; Integrated Security=True");

				if (sqlConnection.State != System.Data.ConnectionState.Open)
				{
					sqlConnection.Open();
				}

				sqlCommand = new System.Data.SqlClient.SqlCommand(command, sqlConnection);
				sqlCommand.ExecuteNonQuery();
				this.Cursor = System.Windows.Forms.Cursors.Default;
				Infrastructure.Utility.WindowsNotification(
					message: $"فایل Database-{System.DateTime.Now:yyyy-MM-dd--HH-mm-ss} ایجاد گردید.",
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

				#region  -----------------------------------------    SetEventLog     -----------------------------------------
				SetEventLog();
				#endregion / -----------------------------------------     SetEventLog     -----------------------------------------

			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion DatabaseBackup

		#region GetAutomaticBackupStatus
		/// <summary>
		/// دریافت وضعیت پشتیبان گیری خودکار
		/// </summary>
		/// <returns>true Or false</returns>
		private bool GetAutomaticBackupStatus()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.BackupSetting backupSetting =
					dataBaseContext.BackupSettings
					.Where(current => current.Id == 1)
					.FirstOrDefault();

				if (backupSetting == null)
				{
					return false;
				}
				else
				{
					if (backupSetting.Auto_Backup)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
				return false;
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /GetAutomaticBackupStatus

		#region GetBackupTime
		/// <summary>
		/// دریافت زمان پشتیبان گیری خودکار
		/// </summary>
		/// <param name="_dateTimeSystem"></param>
		private void GetBackupTime(DateTimeSystem _dateTimeSystem)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.BackupSetting backupSetting =
					new Models.BackupSetting();

				if (backupSetting.Time_Interval == Models.BackupSetting.TimeInterval.روزانه)
				{
					if ((_dateTimeSystem.Hour == backupSetting.Hour) && (_dateTimeSystem.Minute == backupSetting.Minutes))
					{
						DatabaseBackup();
					}
					return;
				}
				else if (backupSetting.Time_Interval == Models.BackupSetting.TimeInterval.هفتگی)
				{
					if ((_dateTimeSystem.Day_Week == backupSetting.Days_Of_Week))
					{
						DatabaseBackup();
					}
					return;
				}
				else if (backupSetting.Time_Interval == Models.BackupSetting.TimeInterval.ماهیانه)
				{
					if ((_dateTimeSystem.Day_Month == backupSetting.Day_Of_Month))
					{
						DatabaseBackup();
					}
					return;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /GetBackupTime

		#region GetCapitalFund
		/// <summary>
		/// بارگزاری موجودی صندوق
		/// </summary>
		/// <returns></returns>
		private void GetCapitalFund()
		{
			decimal capital_Fund;
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.FirstOrDefault();

				if (capitalFund == null)
				{
					capital_Fund = 0;
				}
				else
				{
					if (string.IsNullOrEmpty(capitalFund.Capital_Fund))
					{
						capital_Fund = 0;
					}
					else if (capitalFund.Capital_Fund.Length <= 9)
					{
						capital_Fund = decimal.Parse(capitalFund.Capital_Fund.Replace("تومان", string.Empty).Trim());
						fundsNotificationTextBox.Text = $"{capital_Fund} تومان";
					}
					else
					{
						capital_Fund = decimal.Parse(capitalFund.Capital_Fund.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						fundsNotificationTextBox.Text = $"{capital_Fund:#,0} تومان";
					}
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);

			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /GetCapitalFund

		#region Initialize
		/// <summary>
		/// تنظمیات ورود اولیه
		/// </summary>
		private void Initialize()
		{
			AccountLoaded();
			ResetSubmenu();
			GetCapitalFund();

			homeButton.Checked = true;

			solarCalenderLabel.Text = Infrastructure.Utility.PersianCalendar();
			gregorianCalendarLabel.Text = Infrastructure.Utility.ADCalendar();

			secondsLabel.Text =
				System.DateTime.Now.Second.ToString().PadLeft(2, '0');

			minutesLabel.Text =
				System.DateTime.Now.Minute.ToString().PadLeft(2, '0');

			hoursLabel.Text =
				System.DateTime.Now.Hour.ToString().PadLeft(2, '0');

			clockTimer.Start();

			this.Opacity = 0.0;

			fadeInMainFormTimer.Start();
		}
		#endregion /Initialize

		#region MonthlyFinancialCalculation
		/// <summary>
		/// تهیه یک نمودار مالی برای ماه های سال
		/// </summary>
		private void MonthlyFinancialCalculation()
		{
			System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(System.DateTime.Now);
			int month = persianCalendar.GetMonth(System.DateTime.Now);
			int day = persianCalendar.GetDayOfMonth(System.DateTime.Now);

			string dateNow =
				$"{year}/{month.ToString().PadLeft(2, '0')}/{day.ToString().PadLeft(2, '0')}";

			decimal sumAmountPayment = 0;
			decimal resultSumAmountPayment = 0;
			decimal sumAmountPaid = 0;
			decimal resultSumAmountPaid = 0;
			decimal sumAmountReceived = 0;
			decimal resultSumAmountReceived = 0;
			decimal sumAmountRemaining = 0;
			decimal resultSumAmountRemaining = 0;

			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.DailyFinancialReport> _dailyFinancialReports =
					dataBaseContext.DailyFinancialReports
					.Where(current => current.Register_Date.Contains(dateNow))
					.OrderBy(current => current.Register_Date)
					.ToList();

				if (_dailyFinancialReports != null)
				{
					foreach (var item in _dailyFinancialReports)
					{
						sumAmountPayment = decimal.Parse(item.Amounts_Payment.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						resultSumAmountPayment += sumAmountPayment;

						sumAmountPaid = decimal.Parse(item.Amounts_Payment.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						resultSumAmountPaid += sumAmountPaid;

						sumAmountReceived = decimal.Parse(item.Amounts_Received.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						resultSumAmountReceived += sumAmountReceived;

						sumAmountRemaining = decimal.Parse(item.Amounts_Payment.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
						resultSumAmountRemaining += sumAmountRemaining;
					}
				}

				Models.MonthlyFinancialReport monthlyFinancialReport =
					dataBaseContext.MonthlyFinancialReports
					.Where(current => string.Compare(current.Register_Date, dateNow) == 0)
					.FirstOrDefault();

				if (monthlyFinancialReport != null)
				{
					monthlyFinancialReport =
						new Models.MonthlyFinancialReport
						{
							Sum_Amount_Payment_Of_Day = resultSumAmountPayment.ToString(),
							Sum_Amount_Paid_Of_Day = resultSumAmountPaid.ToString(),
							Sum_Amounts_Remaining_Of_Day = resultSumAmountRemaining.ToString(),
							Sum_Amounts_Received_Of_Day = resultSumAmountReceived.ToString(),
							Register_Date = dateNow,
							Year = year,
							Month = month,
							Day = day,
						};
					dataBaseContext.SaveChanges();

					Mbb.Windows.Forms.MessageBox.Show
						(text: "حساب روز محاسبه گردید و بسته شد!",
						caption: "تکمیل محاسبات",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Success,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}
				else if (monthlyFinancialReport == null)
				{
					monthlyFinancialReport =
						new Models.MonthlyFinancialReport
						{
							Sum_Amount_Payment_Of_Day = resultSumAmountPayment.ToString(),
							Sum_Amount_Paid_Of_Day = resultSumAmountPaid.ToString(),
							Sum_Amounts_Remaining_Of_Day = resultSumAmountRemaining.ToString(),
							Sum_Amounts_Received_Of_Day = resultSumAmountReceived.ToString(),
							Register_Date = dateNow,
							Year = year,
							Month = month,
							Day = day,
						};
					dataBaseContext.MonthlyFinancialReports.Add(monthlyFinancialReport);
					dataBaseContext.SaveChanges();

					Mbb.Windows.Forms.MessageBox.Show
						(text: "حساب روز محاسبه گردید و بسته شد!",
						caption: "تکمیل محاسبات",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Success,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /MonthlyFinancialCalculation		

		#region ResetSubmenu
		/// <summary>
		/// بستن همه منوهای برنامه
		/// </summary>
		private void ResetSubmenu()
		{
			submenuInventoryPanel.Height = 0;
			submenuFinancialPanel.Height = 0;
			submenuClientPanel.Height = 0;
			submenuSettingPanel.Height = 0;

			//-------------------------------------------- Inventory

			ProductBuyForm.Hide();
			ProductSalesForm.Dispose();
			InventoryForm.Dispose();
			ServiceForm.Dispose();

			inventoryButton.Checked = false;
			inventoryEntryButton.Checked = false;
			productSalesButton.Checked = false;
			inventoryholdingButton.Checked = false;
			serviceButton.Checked = false;

			//-------------------------------------------- Financial

			AncillaryCostsForm.Hide();
			FinancialReportForm.Hide();
			SafeBoxForm.Hide();
			SectionChequeBankForm.Hide();

			fainancialButton.Checked = false;
			ancillaryCostsButton.Checked = false;
			financialReportButton.Checked = false;
			safeBoxButton.Checked = false;
			sectionChequeBankButton.Checked = false;

			//-------------------------------------------- Client

			ClientFinancialSituationForm.Hide();
			RegisterClientForm.Hide();

			clientButton.Checked = false;
			clientFinancialSituationButton.Checked = false;
			registerClientButton.Checked = false;

			//-------------------------------------------- Setting

			BackupSettingForm.Hide();
			ManagementSettingForm.Hide();

			settingButton.Checked = false;
			backupSettingsButton.Checked = false;
			managementSettingsButton.Checked = false;
		}
		#endregion /ResetSubmenu

		#region SaveLoginHistory
		/// <summary>
		/// ثبت زمان و تاریخ خروج کاربر
		/// </summary>
		/// <param name="user"></param>
		private void SaveLoginHistory(Models.User user)
		{
			LogHistory.Login_Time = $"{Infrastructure.Utility.ShowTime()} - {Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";

			LogHistory.Logout_Time = $"Null";

			string fullName;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				if (string.IsNullOrWhiteSpace(user.Full_Name))
				{
					fullName = "Null";
				}
				else
				{
					fullName = user.Full_Name;
				}

				dataBaseContext =
					new Models.DataBaseContext();
				Models.LoginHistory logHistory =
					dataBaseContext.LoginHistories
					.OrderBy(current => current.Login_Time)
					.FirstOrDefault();

				logHistory =
					new Models.LoginHistory
					{
						Full_Name = fullName,
						Username = user.Username,
						Login_Time = LogHistory.Login_Time,
						Logout_Time = LogHistory.Logout_Time,
					};

				dataBaseContext.LoginHistories.Add(logHistory);
				dataBaseContext.SaveChanges();

				Program.SavaLogHistory = logHistory;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			if (dataBaseContext != null)
			{
				dataBaseContext.Dispose();
				dataBaseContext = null;
			}
		}
		#endregion /SaveLoginHistory

		#region SetEventLog
		/// <summary>
		/// ثبت رویدادهای صورت گرفته
		/// </summary>
		private void SetEventLog()
		{
			EventLog.Username = string.Empty;
			EventLog.Full_Name = "سیستم خودکار";
			EventLog.Description = "تهیه نسخه پشتیبان از بانک اطلاعات";
			EventLog.Event_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
			EventLog.Event_Time = Infrastructure.Utility.ShowTime();

			Infrastructure.Utility.EventLog(EventLog);
		}
		#endregion /SetEventLog

		#endregion /Founcitons
	}
}

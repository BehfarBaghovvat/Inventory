using System.Linq;

namespace Inventory
{
	public partial class MainForm : Infrastructure.BaseForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region --------------------------------------------------------     Properties     --------------------------------------------------------

		#region --------------------------------------------------------     Layer     --------------------------------------------------------

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

		private Inventory_Forms.ProcutSalesForm _procutSalesForm;
		public Inventory_Forms.ProcutSalesForm ProcutSalesForm
		{
			get
			{
				if (_procutSalesForm == null || _procutSalesForm.IsDisposed == true)
				{
					_procutSalesForm =
						new Inventory_Forms.ProcutSalesForm();

					_procutSalesForm.TopLevel = false;
					_procutSalesForm.TopMost = true;
					_procutSalesForm.Dock = System.Windows.Forms.DockStyle.Fill;
				}
				return _procutSalesForm;
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

		public enum AccessLeve
		{
			مدیریت,
			معاونت,
			کارمند,
			نیروی_خدماتی,
			کاربر_ساده,
		}
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
			if (string.Compare(Inventory.Program.UserAuthentication.Username,"admin")==0)
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
				ProcutSalesForm.Hide();
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

				ProcutSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				AncillaryCostsForm.Hide();
				FinancialReportForm.Hide();
				SafeBoxForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

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
				mainPanel.Controls.Add(ProcutSalesForm);
				ProcutSalesForm.Initialize();
				ProcutSalesForm.Show();

				ProductBuyForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				AncillaryCostsForm.Hide();
				FinancialReportForm.Hide();
				SafeBoxForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

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
				ProcutSalesForm.Hide();
				ServiceForm.Hide();

				AncillaryCostsForm.Hide();
				FinancialReportForm.Hide();
				SafeBoxForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

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
				ProcutSalesForm.Hide();
				InventoryForm.Hide();

				AncillaryCostsForm.Hide();
				FinancialReportForm.Hide();
				SafeBoxForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

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
				SafeBoxForm.Show();

				ProductBuyForm.Hide();
				ProcutSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				AncillaryCostsForm.Hide();
				FinancialReportForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

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
				AncillaryCostsForm.Show();

				ProductBuyForm.Hide();
				ProcutSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				FinancialReportForm.Hide();
				SafeBoxForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

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
				FinancialReportForm.Show();

				ProductBuyForm.Hide();
				ProcutSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();
				SectionChequeBankForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

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
				ProcutSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				FinancialReportForm.Hide();
				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

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
				RegisterClientForm.Show();

				ProductBuyForm.Hide();
				ProcutSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				FinancialReportForm.Hide();
				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();

				ClientFinancialSituationForm.Hide();

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
				ClientFinancialSituationForm.Show();

				ProductBuyForm.Hide();
				ProcutSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				FinancialReportForm.Hide();
				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

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
				ProcutSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				FinancialReportForm.Hide();
				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

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
				ProcutSalesForm.Hide();
				InventoryForm.Hide();
				ServiceForm.Hide();

				FinancialReportForm.Hide();
				AncillaryCostsForm.Hide();
				SafeBoxForm.Hide();

				RegisterClientForm.Hide();
				ClientFinancialSituationForm.Hide();

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

			second = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
			secondsLabel.Text = second;

			minute = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			minutesLabel.Text = minute;

			hour = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
			hoursLabel.Text = hour;

			finalSecond = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
			finalMinute = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			finalHour = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');

			System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

			month = persianCalendar.GetMonth(System.DateTime.Now);
			day = persianCalendar.GetDayOfMonth(System.DateTime.Now);

			//#region MonthlyFinancialCalculation
			//if (string.Compare(finalHour, "23") == 0 && string.Compare(finalMinute, "55") == 0 && string.Compare(finalSecond, "00") == 0)
			//{

			//	return;
			//}
			//#endregion /MonthlyFinancialCalculation

			//#region AnnualFinancialCalculation
			//if (((month >= 1 || month <= 6) && day == 31) && (string.Compare(finalHour, "23") == 0 && string.Compare(finalMinute, "55") == 0 && string.Compare(finalSecond, "00") == 0))
			//{

			//}
			//else if (((month >= 7 || month <= 11) && day == 30) && (string.Compare(finalHour, "23") == 0 && string.Compare(finalMinute, "55") == 0 && string.Compare(finalSecond, "00") == 0))
			//{
			//	AnnualFinancialCalculation();
			//}
			//else if ((month == 12 && day == 29) && (string.Compare(finalHour, "23") == 0 && string.Compare(finalMinute, "55") == 0 && string.Compare(finalSecond, "00") == 0))
			//{
			//	AnnualFinancialCalculation();
			//}
			//#endregion /AnnualFinancialCalculation
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
				productSalesButton.Enabled = true;
				inventoryholdingButton.Enabled = true;
				serviceButton.Enabled = true;

				safeBoxButton.Enabled = false;
				ancillaryCostsButton.Enabled = true;
				financialReportButton.Enabled = false;
				sectionChequeBankButton.Enabled = true;

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
			ProcutSalesForm.Dispose();
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

		#endregion /Founcitons
	}
}

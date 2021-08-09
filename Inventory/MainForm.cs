using System.Linq;

namespace Inventory
{
	public partial class MainForm : Infrastructure.BaseForm
	{
		#region --------------------------------------------------------     Properties     --------------------------------------------------------

		#region --------------------------------------------------------     Layer     --------------------------------------------------------

		//------------------------------------------------------------------------- Inventory

		private static Inventory_Forms.ProductBuyForm _productBuyForm;
		public static Inventory_Forms.ProductBuyForm ProductBuyForm
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

		private static Inventory_Forms.ProcutSalesForm _procutSalesForm;
		public static Inventory_Forms.ProcutSalesForm ProcutSalesForm
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

		private static Inventory_Forms.InventoryForm _inventoryForm;
		public static Inventory_Forms.InventoryForm InventoryForm
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

		private static Inventory_Forms.ServiceForm _serviceForm;
		public static Inventory_Forms.ServiceForm ServiceForm
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

		private Financial_Form.FinancialOrderForm _financialOrderForm;
		public Financial_Form.FinancialOrderForm FinancialOrderForm
		{
			get
			{
				if (_financialOrderForm == null || _financialOrderForm.IsDisposed == true)
				{
					_financialOrderForm = 
						new Financial_Form.FinancialOrderForm();
					_financialOrderForm.TopLevel = false;
					_financialOrderForm.TopMost = true;
					_financialOrderForm.Dock = System.Windows.Forms.DockStyle.Fill;

				}
				return _financialOrderForm;
			}
			set
			{
				_financialOrderForm = value;
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

		public MainForm()
		{
			InitializeComponent();
			ResetSubmenu();
			LoadingFund();

		}

		//----------Beginning of the code!----------

		#region          -------------------------------     MainForm     -------------------------------

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

		#region MainForm_Load
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			AccountLoaded();

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
		#endregion /MainForm_Load

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

				ProductBuyForm.Dispose();
				ProcutSalesForm.Dispose();
				InventoryForm.Dispose();
				ServiceForm.Dispose();
				inventoryButton.Checked = false;
				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				//-------------------------------------------- Financial

				fainancialButton.Checked = false;

				//-------------------------------------------- Client

				clientButton.Checked = false;

				//-------------------------------------------- Setting

				settingButton.Checked = false;
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
				ProductBuyForm.Show();

				ProcutSalesForm.Dispose();
				InventoryForm.Dispose();
				ServiceForm.Dispose();

				AncillaryCostsForm.Dispose();
				FinancialOrderForm.Dispose();
				SafeBoxForm.Dispose();

				homeButton.Checked = false;
				inventoryEntryButton.Checked = true;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialOrderButton.Checked = false;
				safeBoxButton.Checked = false;
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
				ProcutSalesForm.Show();

				ProductBuyForm.Dispose();
				InventoryForm.Dispose();
				ServiceForm.Dispose();

				AncillaryCostsForm.Dispose();
				FinancialOrderForm.Dispose();
				SafeBoxForm.Dispose();

				homeButton.Checked = false;
				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = true;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialOrderButton.Checked = false;
				safeBoxButton.Checked = false;
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
				InventoryForm.Show();

				ProductBuyForm.Dispose();
				ProcutSalesForm.Dispose();
				ServiceForm.Dispose();

				AncillaryCostsForm.Dispose();
				FinancialOrderForm.Dispose();
				SafeBoxForm.Dispose();

				homeButton.Checked = false;
				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = true;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialOrderButton.Checked = false;
				safeBoxButton.Checked = false;
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
				ServiceForm.Show();

				ProductBuyForm.Dispose();
				ProcutSalesForm.Dispose();
				InventoryForm.Dispose();

				AncillaryCostsForm.Dispose();
				FinancialOrderForm.Dispose();
				SafeBoxForm.Dispose();

				homeButton.Checked = false;
				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = true;

				ancillaryCostsButton.Checked = false;
				financialOrderButton.Checked = false;
				safeBoxButton.Checked = false;
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

				ProductBuyForm.Dispose();
				ProcutSalesForm.Dispose();
				InventoryForm.Dispose();
				ServiceForm.Dispose();

				AncillaryCostsForm.Dispose();
				FinancialOrderForm.Dispose();

				homeButton.Checked = false;

				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialOrderButton.Checked = false;
				safeBoxButton.Checked = true;
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

				ProductBuyForm.Dispose();
				ProcutSalesForm.Dispose();
				InventoryForm.Dispose();
				ServiceForm.Dispose();
				
				FinancialOrderForm.Dispose();
				SafeBoxForm.Dispose();

				homeButton.Checked = false;

				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = true;
				financialOrderButton.Checked = false;
				safeBoxButton.Checked = false;
			}
		}
		#endregion /AncillaryCostsButton_Click

		#region FinancialOrderButton_Click
		private void FinancialOrderButton_Click(object sender, System.EventArgs e)
		{
			if (financialOrderButton.Checked)
			{
				return;
			}
			else
			{
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(FinancialOrderForm);
				FinancialOrderForm.Show();

				ProductBuyForm.Dispose();
				ProcutSalesForm.Dispose();
				InventoryForm.Dispose();
				ServiceForm.Dispose();

				AncillaryCostsForm.Dispose();
				SafeBoxForm.Dispose();

				homeButton.Checked = false;

				inventoryEntryButton.Checked = false;
				productSalesButton.Checked = false;
				inventoryholdingButton.Checked = false;
				serviceButton.Checked = false;

				ancillaryCostsButton.Checked = false;
				financialOrderButton.Checked = true;
				safeBoxButton.Checked = false;
			}
		}
		#endregion /FinancialOrderButton_Click












		#endregion /SubmenuFinancial

		#region DropDownFinancialTimer_Tick
		private void DropDownFinancialTimer_Tick(object sender, System.EventArgs e)
		{
			submenuFinancialPanel.Height += 10;
			if (submenuFinancialPanel.Height >= 190)
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





















		#endregion /SubmenuSetting

		#region DropDownSettingTimer_Tick
		private void DropDownSettingTimer_Tick(object sender, System.EventArgs e)
		{
			submenuSettingPanel.Height += 10;
			if (submenuSettingPanel.Height >= 120)
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

		//----------End of code!----------

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
					switch (Program.UserAuthentication.Access_Level)
					{
						case Models.User.AccessLeve.مدیریت:
						homeButton.Enabled = true;
						inventoryButton.Enabled = true;
						break;

						case Models.User.AccessLeve.معاونت:
						homeButton.Enabled = true;
						inventoryButton.Enabled = true;
						break;

						case Models.User.AccessLeve.کارمند:
						homeButton.Enabled = true;
						inventoryButton.Enabled = true;
						break;

						case Models.User.AccessLeve.نیروی_خدماتی:
						homeButton.Enabled = true;
						inventoryButton.Enabled = true;
						break;

						case Models.User.AccessLeve.کاربر_ساده:
						homeButton.Enabled = true;
						inventoryButton.Enabled = true;
						break;

						default:
						break;
					}
					SaveLoginHistory(Program.UserAuthentication);
				}
			}
		}
		#endregion /AccountLoaded

		#region LoadingFund
		/// <summary>
		/// بارگزاری موجودی صندوق
		/// </summary>
		/// <returns></returns>
		private void LoadingFund()
		{
			long fund;
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
					fund = 0;
				}
				else
				{
					fund = long.Parse(capitalFund.Capital_Fund
						.Replace("تومان", string.Empty)
						.Replace(",", string.Empty)
						.Trim());
				}

				fundsLabel.Text = $"{fund:#,0} تومان";
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
		#endregion /LoadingFund

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

			ProductBuyForm.Dispose();
			ProcutSalesForm.Dispose();
			InventoryForm.Dispose();
			ServiceForm.Dispose();
			inventoryButton.Checked = false;
			inventoryEntryButton.Checked = false;
			productSalesButton.Checked = false;
			inventoryholdingButton.Checked = false;
			serviceButton.Checked = false;

			//-------------------------------------------- Financial

			fainancialButton.Checked = false;

			//-------------------------------------------- Client

			clientButton.Checked = false;

			//-------------------------------------------- Setting

			settingButton.Checked = false;
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

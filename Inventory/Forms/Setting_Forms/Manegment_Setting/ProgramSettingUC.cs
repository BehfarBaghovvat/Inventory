using System.Linq;

namespace Manegment_Setting
{
	public partial class ProgramSettingUC : System.Windows.Forms.UserControl
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		#region Layer

		#endregion /Layer

		private Models.ListIncidentalExpensesName _listIncidentalExpensesName;
		public Models.ListIncidentalExpensesName ListIncidentalExpensesName 
		{ 
			get
			{
				if (_listIncidentalExpensesName == null)
				{
					_listIncidentalExpensesName =
						new Models.ListIncidentalExpensesName();
				}

				return _listIncidentalExpensesName;
			}
			set
			{
				_listIncidentalExpensesName = value;
			}
		}

		private Models.ListServiceName _listServiceName;
		public Models.ListServiceName ListServiceName
		{
			get
			{
				if (_listServiceName == null)
				{
					_listServiceName =
						new Models.ListServiceName();
				}
				return _listServiceName;
			}
			set
			{
				_listServiceName = value;
			}
		}		

		private Models.EventLog _eventLog;
		public Models.EventLog EventLog
		{
			get
			{
				if (_eventLog == null)
				{
					_eventLog =
						new Models.EventLog();
				}
				return _eventLog;
			}
			set
			{
				_eventLog = value;
			}
		}


		public int ServicePrice { get; set; }

		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public ProgramSettingUC()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region ProgramSettingUC_Load
		private void ProgramSettingUC_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /ProgramSettingUC_Load

		#region ------------------------------------------------------------------------------ Service Section ------------------------------------------------------------------------------

		#region ServiceNameTextBox_Enter
		private void ServiceNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /ServiceNameTextBox_Enter

		#region ServiceNameTextBox_KeyPress
		private void ServiceNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /ServiceNameTextBox_KeyPress

		#region ServiceNameTextBox_TextChange
		private void ServiceNameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(serviceNameTextBox.Text))
			{
				ListServiceName.Service_Name = null;
			}
			else
			{
				ListServiceName.Service_Name = serviceNameTextBox.Text;
			}


			if (string.IsNullOrWhiteSpace(serviceNameTextBox.Text) || string.IsNullOrWhiteSpace(serviceAmountTextBox.Text))
			{
				saveServiceNameButton.Enabled = false;
			}
			else
			{
				saveServiceNameButton.Enabled = true;
			}
		}
		#endregion /ServiceNameTextBox_TextChange

		#region ServiceAmountTextBox_Enter
		private void ServiceAmountTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (serviceAmountTextBox.Text.Contains("تومان"))
			{
				return;
			}
			else
			{
				serviceAmountTextBox.Text = "0 تومان";
				serviceAmountTextBox.Select(0, 1);
				serviceAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /ServiceAmountTextBox_Enter

		#region ServiceAmountTextBox_KeyPress
		private void ServiceAmountTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /ServiceAmountTextBox_KeyPress

		#region ServiceAmountTextBox_Leave
		private void ServiceAmountTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(serviceAmountTextBox.Text) || serviceAmountTextBox.Text.Length < 7 || string.CompareOrdinal(serviceAmountTextBox.Text, "0 تومان")==0)
			{
				ListServiceName.Service_Price = null;
				serviceAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				serviceAmountTextBox.Clear();
			}
			else
			{
				serviceAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				ServicePrice = int.Parse(serviceAmountTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				ListServiceName.Service_Price = $"{ServicePrice:#,0} تومان";
				serviceAmountTextBox.Text = $"{ServicePrice:#,0} تومان";
			}
		}
		#endregion /ServiceAmountTextBox_Leave

		#region ServiceAmountTextBox_TextChange
		private void ServiceAmountTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(serviceNameTextBox.Text) || string.IsNullOrWhiteSpace(serviceAmountTextBox.Text) || string.CompareOrdinal(serviceAmountTextBox.Text, "0 تومان") == 0)
			{
				saveServiceNameButton.Enabled = false;
			}
			else
			{
				saveServiceNameButton.Enabled = true;
			}
		}
		#endregion /ServiceAmountTextBox_TextChange

		#region SaveServiceNameButton_Click
		private void SaveServiceNameButton_Click(object sender, System.EventArgs e)
		{
			SetServiceName(ListServiceName);
		}
		#endregion /SaveServiceNameButton_Click

		#region EditServiceToolStripMenuItem_Click
		private void EditServiceToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			serviceNameTextBox.Clear();
			serviceAmountTextBox.Clear();

			serviceNameTextBox.Text = listServiceNameDataGridView.CurrentRow.Cells[1].Value.ToString();
			serviceAmountTextBox.Text = listServiceNameDataGridView.CurrentRow.Cells[2].Value.ToString();

			saveServiceNameButton.Text = "ویرایش";

		}
		#endregion /EditServiceToolStripMenuItem_Click

		#region DeleteServiceToolStripMenuItem_Click
		private void DeleteServiceToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			string _serviceName = 
				listIncidentalExpensesNameDataGridView.CurrentRow.Cells[1].Value.ToString();

			DeleteServiceName(_serviceName);
		}
		#endregion /DeleteServiceToolStripMenuItem_Click

		#region DeleteAllServiceToolStripMenuItem_Click
		private void DeleteAllServiceToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			DeleteAllCosts();
		}
		#endregion /DeleteAllServiceToolStripMenuItem_Click

		#endregion / ------------------------------------------------------------------------------ Service Section ------------------------------------------------------------------------------

		#region ------------------------------------------------------------------------------ Cost Section ------------------------------------------------------------------------------

		#region CostNameTextBox_Enter
		private void CostNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /CostNameTextBox_Enter

		#region CostNameTextBox_KeyPress
		private void CostNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /CostNameTextBox_KeyPress

		#region CostNameTextBox_TextChange
		private void CostNameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(costNameTextBox.Text))
			{
				saveCostNameButton.Enabled = false;
				ListIncidentalExpensesName.Cost_Name = null;
			}
			else
			{
				saveCostNameButton.Enabled = true;
				ListIncidentalExpensesName.Cost_Name = costNameTextBox.Text;
			}

		}
		#endregion /CostNameTextBox_TextChange

		#region SaveCostNameButton_Click
		private void SaveCostNameButton_Click(object sender, System.EventArgs e)
		{
			SetCostName(ListIncidentalExpensesName);
		}
		#endregion /SaveCostNameButton_Click

		#region EditCostToolStripMenuItem_Click
		private void EditCostToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			costNameTextBox.Clear();
			saveCostNameButton.Text = "ویرایش";

			costNameTextBox.Text =
				listIncidentalExpensesNameDataGridView.CurrentRow.Cells[1].Value.ToString();
		}
		#endregion /EditCostToolStripMenuItem_Click

		#region DeleteCostToolStripMenuItem_Click
		private void DeleteCostToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			string _costName = listIncidentalExpensesNameDataGridView.CurrentRow.Cells[1].Value.ToString();

			DeleteCostName(_costName: _costName);
		}
		#endregion /DeleteCostToolStripMenuItem_Click

		#region DeleteAllCostToolStripMenuItem_Click
		private void DeleteAllCostToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			DeleteAllCosts();
		}
		#endregion /DeleteAllCostToolStripMenuItem_Click

		#endregion /------------------------------------------------------------------------------ Cost Section ------------------------------------------------------------------------------

		// این بخش برای سایر کنترل ها در نظر گرفته شده
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Function

		#region AllClear
		/// <summary>
		/// حالت اولیه تمام کنترل ها
		/// </summary>
		private void AllClear()
		{
			serviceNameTextBox.Clear();
			serviceAmountTextBox.Clear();
			serviceAmountTextBox.TextAlign = 
				System.Windows.Forms.HorizontalAlignment.Left;

			costNameTextBox.Clear();
		}
		#endregion AllClear

		#region DeleteCostName
		/// <summary>
		/// حذف یکی از هزینه های جانبی
		/// از بانک اطلاعاتی
		/// </summary>
		/// <param name="_costName"></param>
		private void DeleteCostName(string _costName)
		{
			try
			{
				if (listIncidentalExpensesNameDataGridView.Rows.Count == 0)
				{
					Mbb.Windows.Forms.MessageBox.Show
						(text: $"هزینه ای برای حذف موجود نمی باشد.",
						caption: "اطلاع",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}
				else
				{
					System.Windows.Forms.DialogResult dialogResult =
						Mbb.Windows.Forms.MessageBox.Show
						(text: $"{listIncidentalExpensesNameDataGridView.CurrentRow.Cells[1].Value} حذف گردد؟",
						caption: "حذف هزینه",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
						button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

					if (dialogResult == System.Windows.Forms.DialogResult.Yes)
					{
						using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
						{
							//=========================================================.این بخش برای حذف هزینه از بانک لیست هزینه های جانبی می باشد========================================================

							Models.ListIncidentalExpensesName listIncidentalExpensesName =
								dataBaseContext.ListIncidentalExpensesNames
								.Where(current => string.Compare(current.Cost_Name, _costName) == 0)
								.FirstOrDefault();
							if (listIncidentalExpensesName != null)
							{
								var entry = dataBaseContext.Entry(listIncidentalExpensesName);

								if (entry.State == System.Data.Entity.EntityState.Detached)
								{
									dataBaseContext.ListIncidentalExpensesNames.Attach(listIncidentalExpensesName);
								}
							}
							dataBaseContext.ListIncidentalExpensesNames.Remove(listIncidentalExpensesName);
							dataBaseContext.SaveChanges();

						}

						Infrastructure.Utility.WindowsNotification
							(message: "هزینه مورد نظر حذف گردید!",
							caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

						#region -----------------------------------------     Save Event Log     -----------------------------------------
						if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
						{
							EventLog.Username = Inventory.Program.UserAuthentication.Username;
							EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
							EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
							EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
							EventLog.Description = $"{_costName} حذف گردید.";

							Infrastructure.Utility.EventLog(EventLog);
						}
						#endregion /-----------------------------------------     Save Event Log     -----------------------------------------

						GetListIncidentalExpensesName();
					}
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion DeleteCostName

		#region DeleteServiceName
		/// <summary>
		/// حذف یک از سرویس ها از بانک اطلاعاتی
		/// </summary>
		/// <param name="_serviceName"></param>
		private void DeleteServiceName(string _serviceName)
		{
			try
			{
				if (listIncidentalExpensesNameDataGridView.Rows.Count == 0)
				{
					Mbb.Windows.Forms.MessageBox.Show
						(text: $"سرویسی برای حذف موجود نمی باشد.",
						caption: "اطلاع",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					return;
				}
				else
				{
					System.Windows.Forms.DialogResult dialogResult =
						Mbb.Windows.Forms.MessageBox.Show
						(text: $"{listIncidentalExpensesNameDataGridView.CurrentRow.Cells[1].Value} حذف گردد؟",
						caption: "حذف سرویس",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
						button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

					if (dialogResult == System.Windows.Forms.DialogResult.Yes)
					{
						using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
						{
							//=========================================================.این بخش برای حذف هزینه از بانک لیست هزینه های جانبی می باشد========================================================

							Models.ListServiceName listServiceName =
								dataBaseContext.ListServiceNames
								.Where(current => string.Compare(current.Service_Name, _serviceName) == 0)
								.FirstOrDefault();
							if (listServiceName != null)
							{
								var entry = dataBaseContext.Entry(listServiceName);

								if (entry.State == System.Data.Entity.EntityState.Detached)
								{
									dataBaseContext.ListServiceNames.Attach(listServiceName);
								}
							}
							dataBaseContext.ListServiceNames.Remove(listServiceName);
							dataBaseContext.SaveChanges();

						}

						Infrastructure.Utility.WindowsNotification
							(message: "سرویس مورد نظر حذف گردید!",
							caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

						#region -----------------------------------------     Save Event Log     -----------------------------------------
						if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
						{
							EventLog.Username = Inventory.Program.UserAuthentication.Username;
							EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
							EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
							EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
							EventLog.Description = $"{_serviceName} حذف گردید.";

							Infrastructure.Utility.EventLog(EventLog);
						}
						#endregion /-----------------------------------------     Save Event Log     -----------------------------------------

						GetListIncidentalExpensesName();
					}
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /DeleteServiceName

		#region DeleteAllCosts
		/// <summary>
		/// حذف کامل لیست هزینه های جانبی
		/// </summary>
		private void DeleteAllCosts()
		{
			if (listIncidentalExpensesNameDataGridView.Rows.Count >= 1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"آیا همه اطلاعات حذف گردد؟!",
					caption: "هشدار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف کامل اطلاعات مربوط به هزینه های جانبی
				{
					System.Collections.Generic.List<Models.ListIncidentalExpensesName> listIncidentalExpensesNames = new System.Collections.Generic.List<Models.ListIncidentalExpensesName>();

					using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
					{
						listIncidentalExpensesNames =
						   dataBaseContext.ListIncidentalExpensesNames
						   .OrderBy(current => current.Cost_Name)
						   .ToList();

						if (listIncidentalExpensesNames != null)
						{
							foreach (var item in listIncidentalExpensesNames) //---توسط این کد با پیمایش در لیست اسامی هزینه های جانبی یکی یکی ایتمهای موجود در لیست اسامی هزینه های جانبی را حذف میکند.
							{
								dataBaseContext.ListIncidentalExpensesNames.Remove(item);
								dataBaseContext.SaveChanges();
							}
						}
						else if (listIncidentalExpensesNames == null)
						{
							return;
						}

						#region -----------------------------------------     Save Event Log     -----------------------------------------
						if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
						{
							EventLog.Username = Inventory.Program.UserAuthentication.Username;
							EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
							EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
							EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
							EventLog.Description = $"حذف کامل لیست هزینه های جانبی.";

							Infrastructure.Utility.EventLog(EventLog);
						}
						#endregion /-----------------------------------------     Save Event Log     -----------------------------------------

					}

					Infrastructure.Utility.WindowsNotification
						(message: "کلیه اطلاعات اسامی هزینه های جانبی حذف گردید!",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

					GetListIncidentalExpensesName();
				}
			}
		}
		#endregion /DeleteAllCosts

		#region DeleteAllServiceName
		/// <summary>
		/// حذف کامل لیست سرویس های
		/// فنی از داخل بانک اطلاعاتی
		/// </summary>
		private void DeleteAllServiceName()
		{
			if (listIncidentalExpensesNameDataGridView.Rows.Count >= 1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"آیا همه اطلاعات حذف گردد؟!",
					caption: "هشدار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف کامل اطلاعات مربوط به سرویس
				{
					System.Collections.Generic.List<Models.ListServiceName> listServiceNames =
						new System.Collections.Generic.List<Models.ListServiceName>();

					using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
					{
						listServiceNames =
						   dataBaseContext.ListServiceNames
						   .OrderBy(current => current.Id)
						   .ToList();

						if (listServiceNames != null)
						{
							foreach (var item in listServiceNames) //---توسط این کد با پیمایش در لیست اسامی سرویس یکی یکی ایتمهای موجود در لیست سرویس را حذف میکند.
							{
								dataBaseContext.ListServiceNames.Remove(item);
								dataBaseContext.SaveChanges();
							}
						}
						else if (listServiceNames == null)
						{
							return;
						}

						#region -----------------------------------------     Save Event Log     -----------------------------------------
						if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
						{
							EventLog.Username = Inventory.Program.UserAuthentication.Username;
							EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
							EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
							EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
							EventLog.Description = $"حذف کامل لیست اسامی سرویس.";

							Infrastructure.Utility.EventLog(EventLog);
						}
						#endregion /-----------------------------------------     Save Event Log     -----------------------------------------

					}

					Infrastructure.Utility.WindowsNotification
						(message: "کلیه اطلاعات سرویس حذف گردید!",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

					GetListIncidentalExpensesName();
				}
			}
		}
		#endregion /DeleteAllServiceName

		#region GetListIncidentalExpensesName
		/// <summary>
		/// بارگذاری / تازه سازی لیست هزینه های جانبی
		/// </summary>
		private void GetListIncidentalExpensesName()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.ListIncidentalExpensesName> listIncidentalExpensesNames =
					new System.Collections.Generic.List<Models.ListIncidentalExpensesName>();

				listIncidentalExpensesNames =
					dataBaseContext.ListIncidentalExpensesNames
					.OrderBy(current => current.Id)
					.ToList();

				if (listIncidentalExpensesNames.Count > 0)
				{
					listIncidentalExpensesNameContextMenuStrip.Enabled = true;
				}
				else
				{
					listIncidentalExpensesNameContextMenuStrip.Enabled = false;
				}

				listIncidentalExpensesNameDataGridView.DataSource = listIncidentalExpensesNames;
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
		#endregion /GetListIncidentalExpensesName

		#region GetListServiceName
		/// <summary>
		/// بارگذاری / تازه سازی لیست 
		/// اسامی سرویس ها
		/// </summary>
		private void GetListServiceName()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.ListServiceName> listServiceNames =
					new System.Collections.Generic.List<Models.ListServiceName>();

				listServiceNames =
					dataBaseContext.ListServiceNames
					.OrderBy(current => current.Id)
					.ToList();

				if (listServiceNames.Count > 0)
				{
					listServiceNameContextMenuStrip.Enabled = true;
				}
				else
				{
					listServiceNameContextMenuStrip.Enabled = false;
				}

				listServiceNameDataGridView.DataSource = listServiceNames;
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
		#endregion /GetListServiceName

		#region Initialize
		/// <summary>
		/// تنظیمات ورود اولیه
		/// </summary>
		private void Initialize()
		{
			GetListIncidentalExpensesName();
			GetListServiceName();
		}
		#endregion Initialize

		#region SetCostName
		/// <summary>
		/// ثبت اسامی هزینه های جانبی در سیستم
		/// </summary>
		/// <param name="_costItems"></param>
		private void SetCostName(Models.ListIncidentalExpensesName _listIncidentalExpensesName)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ListIncidentalExpensesName listIncidentalExpensesName =
					dataBaseContext.ListIncidentalExpensesNames
					.Where(current => string.Compare(current.Cost_Name, _listIncidentalExpensesName.Cost_Name) == 0)
					.FirstOrDefault();

				if (string.Compare(saveCostNameButton.Text, "ثبت")==0)
				{
					if (listIncidentalExpensesName != null)
					{
						Mbb.Windows.Forms.MessageBox.Show(
							text: $"{_listIncidentalExpensesName.Cost_Name} در سیستم موجود می باشد. \n لطفا از نام دیگری استفاده نمایید. ",
							caption: "تکرار نام",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						costNameTextBox.Focus();
						return;
					}
					else
					{
						listIncidentalExpensesName =
							new Models.ListIncidentalExpensesName()
							{
								Cost_Name = _listIncidentalExpensesName.Cost_Name,
							};

						dataBaseContext.ListIncidentalExpensesNames.Add(listIncidentalExpensesName);
						dataBaseContext.SaveChanges();
					}

					GetListIncidentalExpensesName();

					saveCostNameButton.Enabled = false;

					AllClear();

					Infrastructure.Utility.WindowsNotification(
						message: $"{_listIncidentalExpensesName.Cost_Name} ذخیره گردید.",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
					return;
				}
				else if (string.Compare(saveCostNameButton.Text, "ویرایش") == 0)
				{
					listIncidentalExpensesName =
						new Models.ListIncidentalExpensesName();

					listIncidentalExpensesName.Cost_Name = _listIncidentalExpensesName.Cost_Name;

					dataBaseContext.SaveChanges();

					Infrastructure.Utility.WindowsNotification(
						message: $"{_listIncidentalExpensesName.Cost_Name} ویرایش گردید.",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
					return;
				}

				GetListIncidentalExpensesName();

				saveCostNameButton.Enabled = false;
				saveCostNameButton.Text = "ثبت";

				AllClear();
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

		#endregion /SetCostName

		#region SetServiceName
		/// <summary>
		/// ثبت اسامی سرویس ها در
		/// بانک اطلاعاتی
		/// </summary>
		/// <param name="_listServiceName"></param>
		private void SetServiceName(Models.ListServiceName _listServiceName)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ListServiceName listServiceName =
					dataBaseContext.ListServiceNames
					.Where(current => string.Compare(current.Service_Name, _listServiceName.Service_Name) == 0)
					.FirstOrDefault();


				if (string.Compare(saveServiceNameButton.Text, "ثبت") == 0)
				{
					if (listServiceName != null)
					{
						Mbb.Windows.Forms.MessageBox.Show(
							text: $"{_listServiceName.Service_Name} در سیستم موجود می باشد. \n لطفا از نام دیگری استفاده نمایید.",
							caption: "نام تکراری",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						serviceNameTextBox.Focus();
						return;
					}
					else
					{
						listServiceName =
							new Models.ListServiceName()
							{
								Service_Name = _listServiceName.Service_Name,
								Service_Price = _listServiceName.Service_Price,
							};

						dataBaseContext.ListServiceNames.Add(listServiceName);
						dataBaseContext.SaveChanges();
					}

					GetListServiceName();

					saveServiceNameButton.Enabled = false;

					serviceNameTextBox.Clear();
					serviceAmountTextBox.Clear();
					serviceAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

					AllClear();

					Infrastructure.Utility.WindowsNotification(
						message: $"{listServiceName.Service_Name} ذخیره گردید.",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				}
				else if (string.Compare(saveServiceNameButton.Text, "ویرایش") == 0)
				{
					listServiceName =
						new Models.ListServiceName();

					listServiceName.Service_Name = _listServiceName.Service_Name;
					listServiceName.Service_Price = _listServiceName.Service_Price;

					dataBaseContext.SaveChanges();

					GetListServiceName();

					saveServiceNameButton.Enabled = false;
					saveServiceNameButton.Text = "ثبت";

					serviceNameTextBox.Clear();
					serviceAmountTextBox.Clear();
					serviceAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

					AllClear();

					Infrastructure.Utility.WindowsNotification(
						message: $"{listServiceName.Service_Name} ویرایش گردید.",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
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



		#endregion SetServiceName

		#endregion Function
	}
}

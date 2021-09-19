using System.Linq;

namespace Client_Forms
{
	public partial class RegisterClientForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties
		public Models.Client Client_GetData { get; set; }
		public Models.Client Client_FirstLoad { get; set; }
		public Models.Client Client_New { get; set; }
		public Models.EventLog EventLog { get; set; }
		public string Search_Item { get; set; }
		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public RegisterClientForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region RegisterClientForm_Load
		private void RegisterClientForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /RegisterClientForm_Load

		#region ClientNameTextBox_Enter
		private void ClientNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /ClientNameTextBox_Enter

		#region ClientNameTextBox_KeyPress
		private void ClientNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /ClientNameTextBox_KeyPress

		#region ClientNameTextBox_TextChange 
		private void ClientNameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientNameTextBox.Text))
			{
				Client_GetData.Client_Name = null;
				return;
			}
			else
			{
				Client_GetData.Client_Name = clientNameTextBox.Text;
			}
		}
		#endregion /ClientNameTextBox_TextChange

		#region LicensePlateTextBox_Enter
		private void LicensePlateTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			licensePlateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		}
		#endregion /LicensePlateTextBox_Enter

		#region LicensePlateTextBox_KeyPress
		private void LicensePlateTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /LicensePlateTextBox_KeyPress

		#region LicensePlateTextBox_Leave
		private void LicensePlateTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(licensePlateTextBox.Text) || licensePlateTextBox.Text.Length < 7)
			{
				Client_GetData.License_Plate = null;
				licensePlateTextBox.Clear();
				licensePlateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else
			{
				Client_GetData.License_Plate = licensePlateTextBox.Text = licensePlateTextBox.Text.Insert(2, " - ").Insert(7, " - ").Insert(8, " ایران ");
			}
		}
		#endregion /LicensePlateTextBox_Leave

		#region PhonNumberTextBox_Enter
		private void PhonNumberTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			phonNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		}
		#endregion /PhonNumberTextBox_Enter

		#region PhonNumberTextBox_KeyPress
		private void PhonNumberTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /PhonNumberTextBox_KeyPress

		#region PhonNumberTextBox_Leave
		private void PhonNumberTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(phonNumberTextBox.Text) || phonNumberTextBox.Text.Length < 11)
			{
				phonNumberTextBox.Clear();
				Client_GetData.Phone_Number = null;
				phonNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else
			{
				phonNumberTextBox.Text = phonNumberTextBox.Text.Insert(4, "-");
				Client_GetData.Phone_Number = phonNumberTextBox.Text;
			}
		}
		#endregion /PhonNumberTextBox_Leave

		#region SearchTextBox_Enter
		private void SearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		}
		#endregion /SearchTextBox_Enter

		#region SearchTextBox_KeyPress
		private void SearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /SearchTextBox_KeyPress

		#region SearchTextBox_TextChange
		private void SearchTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchTextBox.Text))
			{
				Search_Item = null;
				searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			}
			else
			{
				Search_Item = searchTextBox.Text;

				SearchClient(Search_Item);
			}
		}
		#endregion /SearchTextBox_TextChange

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if (string.Compare(saveButton.Text, "ثبت مشتری") == 0)
			{
				if (SetInClient(Client_GetData))
				{
					Infrastructure.Utility.WindowsNotification(message: "مشتری جدید ثبت گردید", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
					return;
				}
				else
				{
					Infrastructure.Utility.WindowsNotification(message: "عدم موفقیت در ثبت اطلاعات", caption: Infrastructure.PopupNotificationForm.Caption.خطا);
				} 
			}
			else if (string.Compare(saveButton.Text, "ویرایش مشتری") == 0)
			{
				if (EditClient(Client_GetData))
				{
					Infrastructure.Utility.WindowsNotification(message: "ویرایش مشتری انجام گردید", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
					return;
				}
				else
				{
					Infrastructure.Utility.WindowsNotification(message: "عدم موفقیت در ویرایش اطلاعات", caption: Infrastructure.PopupNotificationForm.Caption.خطا);
				}
			}
		}
		#endregion /SaveButton_Click

		#region ClientEditToolStripMenuItem_Click
		private void ClientEditToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			saveButton.Text = "ویرایش مشتری";

			Client_FirstLoad.Client_Name = listClientDataGridView.CurrentRow.Cells[0].Value.ToString();
			clientNameTextBox.Text = listClientDataGridView.CurrentRow.Cells[0].Value.ToString();
			Client_GetData.Client_Name = listClientDataGridView.CurrentRow.Cells[0].Value.ToString();

			Client_FirstLoad.License_Plate = listClientDataGridView.CurrentRow.Cells[1].Value.ToString();
			licensePlateTextBox.Text = listClientDataGridView.CurrentRow.Cells[1].Value.ToString();
			Client_GetData.License_Plate = listClientDataGridView.CurrentRow.Cells[1].Value.ToString();

			Client_FirstLoad.Phone_Number = listClientDataGridView.CurrentRow.Cells[2].Value.ToString();
			phonNumberTextBox.Text = listClientDataGridView.CurrentRow.Cells[1].Value.ToString();
			Client_GetData.Phone_Number = listClientDataGridView.CurrentRow.Cells[1].Value.ToString();
		}
		#endregion /ClientEditToolStripMenuItem_Click

		#region ClientDeleteToolStripMenuItem_Click
		private void ClientDeleteToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			ClientDelete();
		}
		#endregion /ClientDeleteToolStripMenuItem_Click

		#region AllClientsDeleteToolStripMenuItem_Click
		private void AllClientsDeleteToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			AllClientDeleted();
		}
		#endregion /AllClientsDeleteToolStripMenuItem_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Function

		#region AllClear
		/// <summary>
		/// پاک کردن اطلاعات از داخل کنترل ها و متغییر ها
		/// </summary>
		private void AllClear()
		{
			clientNameTextBox.Clear();
			licensePlateTextBox.Clear();
			phonNumberTextBox.Clear();

			Client_FirstLoad = null;
			Client_GetData = null;
			Client_New = null;
		}
		#endregion /AllClear

		#region AllClientDeleted
		/// <summary>
		/// حذف کامل لیست مشتریان از بانک اطلاعاتی
		/// </summary>
		private void AllClientDeleted()
		{
			if (listClientDataGridView.Rows.Count >= 1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"آیا همه مشتریان حذف گردند؟!",
					caption: "هشدار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف کامل اطلاعات مربوط به نوشیدنی
				{
					System.Collections.Generic.List<Models.Client> listClient = new System.Collections.Generic.List<Models.Client>();

					using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
					{
						listClient =
						   dataBaseContext.Clients
						   .OrderBy(current => current.Client_Name)
						   .ToList();

						if (listClient != null)
						{
							foreach (var item in listClient) //---توسط این کد با پیمایش در لیست مشتریان یکی یکی ایتمهای موجود در لیست مشتریان را حذف میکند.
							{
								dataBaseContext.Clients.Remove(item);
								dataBaseContext.SaveChanges();
							}
						}
						else if (listClient == null)
						{
							return;
						}

						#region  -----------------------------------------    SetEventLog     -----------------------------------------
						if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
						{
							EventLog.Username = Inventory.Program.UserAuthentication.Username;
							EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
							EventLog.Description = $"حذف کامل مشتریان.";
							EventLog.Event_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
							EventLog.Event_Time = Infrastructure.Utility.ShowTime();

							Infrastructure.Utility.EventLog(EventLog);
						}
						#endregion / -----------------------------------------     SetEventLog     -----------------------------------------

						GetDataFromClient();
					}

					Infrastructure.Utility.WindowsNotification
						(message: "کلیه لیست مشتریان حذف گردید!",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				}
			}
			else
			{
				Mbb.Windows.Forms.MessageBox.Show
					(text: $"موردی برای حذف وجود ندارد!",
					caption: "اطلاع",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				return;
			}
		}
		#endregion /AllClientDeleted

		#region ClientDelete
		/// <summary>
		/// حذف موردی مشتری از بانک اطلاعاتی
		/// </summary>
		private void ClientDelete()
		{
			if (listClientDataGridView.Rows.Count >= 1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"{listClientDataGridView.CurrentRow.Cells[0].Value} حذف گردد؟!",
					caption: "حذف رکورد",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف مشترک
				{
					string clientName = listClientDataGridView.CurrentRow.Cells[1].Value.ToString();

					using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
					{
						Models.Client client =
							dataBaseContext.Clients
							.Where(current => string.Compare(current.Client_Name, clientName) == 0)
							.FirstOrDefault();
						if (client != null)
						{
							var entry = dataBaseContext.Entry(client);

							if (entry.State == System.Data.Entity.EntityState.Detached)
							{
								dataBaseContext.Clients.Attach(client);
							}
						}
						dataBaseContext.Clients.Remove(client);
						dataBaseContext.SaveChanges();

						#region  -----------------------------------------    SetEventLog     -----------------------------------------
						if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
						{
							EventLog.Username = Inventory.Program.UserAuthentication.Username;
							EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
							EventLog.Description = $"{clientName} حذف شد.";
							EventLog.Event_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
							EventLog.Event_Time = Infrastructure.Utility.ShowTime();

							Infrastructure.Utility.EventLog(EventLog);
						}
						#endregion / -----------------------------------------     SetEventLog     -----------------------------------------
					}

					Infrastructure.Utility.WindowsNotification
						(message: "کد مورد نظر حذف گردید!",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				}
			}
			else
			{
				Mbb.Windows.Forms.MessageBox.Show
					(text: $"موردی برای حذف وجود ندارد!",
					caption: "اخطار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
			}
		}
		#endregion /ClientDelete

		#region EditClient
		/// <summary>
		/// ویرایش اطلاعات مشتری
		/// </summary>
		/// <param name="_editClient"></param>
		/// <returns>true or false</returns>
		private bool EditClient(Models.Client _editClient)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Client client =
								dataBaseContext.Clients
								.Where(current => string.Compare(current.License_Plate, Client_FirstLoad.Client_Name) == 0)
								.FirstOrDefault();

				if (client != null)
				{
					client.Client_Name = _editClient.Client_Name;
					client.License_Plate = _editClient.License_Plate;
					client.Phone_Number = _editClient.Phone_Number;
				}

				dataBaseContext.SaveChanges();

				return true;

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
		#endregion /EditClient

		#region GetDataFromClient
		/// <summary>
		/// بارگزاری لیست مشتریان
		/// </summary>
		private void GetDataFromClient()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Client> listClients = new System.Collections.Generic.List<Models.Client>();


				if (listClients == null)
				{
					listClientDataGridView.DataSource = null;
					return;
				}
				else
				{
					listClients =
						dataBaseContext.Clients
						.OrderByDescending(current => current.Registration_Date)
						.ToList();
				}

				listClientDataGridView.DataSource = listClients;

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
		#endregion /GetDataFromClient

		#region Initialize
		/// <summary>
		/// تنظیمات ورود اولیه
		/// </summary>
		private void Initialize()
		{
			AllClear();
			GetDataFromClient();
		}
		#endregion /Initialize

		#region SearchClient
		/// <summary>
		/// جستجوی مشتری
		/// </summary>
		/// <param name="_searchItem"></param>
		private void SearchClient(string _searchItem)
		{
			if (_searchItem.StartsWith("09"))
			{
				Models.DataBaseContext dataBaseContext = null;
				try
				{
					dataBaseContext =
						new Models.DataBaseContext();

					System.Collections.Generic.List<Models.Client> listClients = null;

					if (string.IsNullOrWhiteSpace(_searchItem))
					{
						listClients =
							dataBaseContext.Clients
							.OrderBy(current => current.Registration_Date)
							.ToList();
					}
					else
					{
						listClients =
							dataBaseContext.Clients
							.Where(current => current.Phone_Number.Contains(_searchItem))
							.OrderBy(current => current.Registration_Date)
							.ToList();
					}

					listClientDataGridView.DataSource = listClients;

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
			else
			{
				Models.DataBaseContext dataBaseContext = null;
				try
				{
					dataBaseContext =
						new Models.DataBaseContext();

					System.Collections.Generic.List<Models.Client> listClients = null;

					if (string.IsNullOrWhiteSpace(_searchItem))
					{
						listClients =
							dataBaseContext.Clients
							.OrderBy(current => current.Registration_Date)
							.ToList();
					}
					else
					{
						listClients =
							dataBaseContext.Clients
							.Where(current => current.Phone_Number.Contains(_searchItem))
							.OrderBy(current => current.Registration_Date)
							.ToList();
					}

					listClientDataGridView.DataSource = listClients;
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
		}
		#endregion /SearchClient

		#region SetInClient
		/// <summary>
		/// ذخیره اطلاعات در جدول مشتریان
		/// </summary>
		/// <param name="_client"></param>
		/// <returns>true or false</returns>
		private bool SetInClient(Models.Client _client)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Client client =
					new Models.Client()
					{
						Client_Name = _client.Client_Name,
						License_Plate = _client.License_Plate,
						Phone_Number = _client.Phone_Number,
						Registration_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}",
						Registration_Time = $"{Infrastructure.Utility.ShowTime()}",
					};

				dataBaseContext.Clients.Add(client);
				dataBaseContext.SaveChanges();

				GetDataFromClient();

				return true;
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
		#endregion /SetInClient

		#region SetEventLog
		private void SetEventLog()
		{
			string descriptionLog = null;

			if (Client_FirstLoad.Client_Name != Client_GetData.Client_Name)
			{
				descriptionLog =
					$"نام مشتری از {Client_FirstLoad.Client_Name} به { Client_GetData.Client_Name} تغییر یافت";
			}
			if (Client_FirstLoad.License_Plate != Client_GetData.License_Plate)
			{
				if (descriptionLog != null)
				{
					descriptionLog +=
						System.Environment.NewLine;
				}
				descriptionLog +=
					$"شماره وسیله نقلیه از {Client_FirstLoad.License_Plate} به {Client_GetData.License_Plate} تغییر یافت";
			}
			if (Client_FirstLoad.Phone_Number != Client_GetData.Phone_Number)
			{
				if (descriptionLog != null)
				{
					descriptionLog +=
						System.Environment.NewLine;
				}
				descriptionLog +=
					$"شماره تماس از {Client_FirstLoad.Phone_Number} به {Client_GetData.License_Plate} تغییر یافت";
			}

			if (descriptionLog == null)
			{
				return;
			}
			else
			{
				EventLog.Username = Inventory.Program.UserAuthentication.Username;
				EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
				EventLog.Description = descriptionLog;
				EventLog.Event_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
				EventLog.Event_Time = Infrastructure.Utility.ShowTime();

				Infrastructure.Utility.EventLog(EventLog);
			}
		}
		#endregion /SetEventLog

		#endregion /Function
	}
}

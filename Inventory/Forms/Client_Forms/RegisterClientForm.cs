using System.Linq;

namespace Client_Forms
{
	public partial class RegisterClientForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		private Models.Client _client_GetData;
		public Models.Client Client_GetData
		{
			get
			{
				if (_client_GetData == null)
				{
					_client_GetData =
						new Models.Client();
				}
				return _client_GetData;
			}
			set
			{
				_client_GetData = value;
			}
		}

		private Models.Client _client_FirstLoad;
		public Models.Client Client_FirstLoad
		{
			get
			{
				if (_client_FirstLoad == null)
				{
					_client_FirstLoad =
						new Models.Client();
				}
				return _client_FirstLoad;
			}
			set
			{
				_client_FirstLoad = value;
			}
		}

		private Models.Client _client_New;
		public Models.Client Client_New
		{
			get
			{
				if (_client_New == null)
				{
					_client_New =
						new Models.Client();
				}
				return _client_New;
			}
			set
			{
				_client_New = value;
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

		#region LicensePlateGroupBox_Leave
		private void LicensePlateGroupBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(numTextBox1.Text) || string.IsNullOrWhiteSpace(numTextBox2.Text) || string.IsNullOrWhiteSpace(numTextBox3.Text))
			{
				Client_GetData.License_Plate = null;
				return;
			}
			else
			{
				Client_GetData.License_Plate =
					$"{numTextBox3.Text}{iranLabel.Text} - {numTextBox2.Text}{alphabetComboBox.SelectedItem} - {numTextBox1.Text}";

				if (LicensePlateConfirmation(Client_GetData) == true)
				{
					confirmLicensePlatePicturBox.Visible = true;
					confirmLicensePlatePicturBox.Image = Inventory.Properties.Resources.Tik_True;
				}
				else if (LicensePlateConfirmation(Client_GetData) == false)
				{
					confirmLicensePlatePicturBox.Visible = true;
					confirmLicensePlatePicturBox.Image = Inventory.Properties.Resources.Tik_False;
					Client_GetData.License_Plate = null;
					numTextBox1.Focus();
				}
			}
		}
		#endregion /LicensePlateGroupBox_Leave

		#region PhonNumberTextBox_Enter
		private void PhonNumberTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /PhonNumberTextBox_Enter

		#region PhonNumberTextBox_KeyPress
		private void PhonNumberTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /PhonNumberTextBox_KeyPress

		#region PhoneNumberTextBox_Leave
		private void PhoneNumberTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) || phoneNumberTextBox.Text.Length < 11)
			{
				Mbb.Windows.Forms.MessageBox.Show(
					text: "تعداد ارقام وارد شده کمتر از 11 رقم می باشد. \n لطفا مجدد تلاش نمایید.",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				phoneNumberTextBox.Clear();
				Client_GetData.Phone_Number = null;
				phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else if (!phoneNumberTextBox.Text.StartsWith("09"))
			{
				Mbb.Windows.Forms.MessageBox.Show(
					text: "فرمت شماره تلفن همراه صحیح نمی باشد. \n لطفا مجدد تلاش نمایید.",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				phoneNumberTextBox.Focus();
				return;
			}
			else
			{
				if (Client_GetData.Phone_Number.Length > 11)
				{
					Mbb.Windows.Forms.MessageBox.Show(
					text: "تعداد ارقام وارد شده بیشتر از 11 می باشد. \n لطفا مجدد تلاش نمایید.",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					phoneNumberTextBox.Focus();
					return;
				}
				else
				{
					phoneNumberTextBox.Text = phoneNumberTextBox.Text.Insert(4, "-");
				}
			}
		}
		#endregion /PhoneNumberTextBox_Leave

		#region PhoneNumberTextBox_TextChange
		private void PhoneNumberTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
			{
				confirmTelPicturBox.Visible = false;
				phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else
			{
				phoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

				Client_GetData.Phone_Number = phoneNumberTextBox.Text;
				if (Client_GetData.Phone_Number.Length < 11)
				{
					confirmTelPicturBox.Visible = true;
					confirmTelPicturBox.Image = Inventory.Properties.Resources.Tik_False;
					phoneNumberTextBox.Focus();
					Client_GetData.Phone_Number = null;
					return;
				}
				else
				{
					if (TelConfirmation(Client_GetData) == true)
					{
						confirmTelPicturBox.Visible = true;
						confirmTelPicturBox.Image = Inventory.Properties.Resources.Tik_True;
						Client_GetData.Phone_Number = phoneNumberTextBox.Text;
					}
					else if (TelConfirmation(Client_GetData) == false)
					{
						confirmTelPicturBox.Visible = true;
						confirmTelPicturBox.Image = Inventory.Properties.Resources.Tik_False;
						Client_GetData.Phone_Number = null;
					}
				}
			}
		}
		#endregion /PhoneNumberTextBox_TextChange

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
				GetListClient();
				searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			}
			else
			{
				SearchClient(searchTextBox.Text);
			}
		}
		#endregion /SearchTextBox_TextChange

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if (ValidationData(Client_GetData))
			{
				if (string.Compare(saveButton.Text, "ثبت مشتری") == 0)
				{
					if (SetClient(Client_GetData))
					{
						Infrastructure.Utility.WindowsNotification(
						message: "مشتری جدید ثبت گردید",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
						return;
					}
					else
					{
						Infrastructure.Utility.WindowsNotification
							(message: "عدم موفقیت در ثبت اطلاعات",
							caption: Infrastructure.PopupNotificationForm.Caption.خطا);
					}
				}
				else if (string.Compare(saveButton.Text, "ویرایش مشتری") == 0)
				{
					if (EditClient(Client_GetData))
					{
						Infrastructure.Utility.WindowsNotification(
							message: "ویرایش مشتری انجام گردید",
							caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
						return;
					}
					else
					{
						Infrastructure.Utility.WindowsNotification(
							message: "عدم موفقیت در ویرایش اطلاعات",
							caption: Infrastructure.PopupNotificationForm.Caption.خطا);
					}
				}
				else
				{
					return;
				}
			}

		}
		#endregion /SaveButton_Click

		#region ClientEditToolStripMenuItem_Click
		private void ClientEditToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			saveButton.Text = "ویرایش مشتری";

			Client_FirstLoad.Client_Name = listClientDataGridView.CurrentRow.Cells[1].Value.ToString();
			clientNameTextBox.Text = listClientDataGridView.CurrentRow.Cells[1].Value.ToString();
			Client_GetData.Client_Name = listClientDataGridView.CurrentRow.Cells[1].Value.ToString();

			Client_FirstLoad.License_Plate = listClientDataGridView.CurrentRow.Cells[3].Value.ToString();
			numTextBox3.Text = Client_FirstLoad.License_Plate.Substring(0, 2);
			alphabetComboBox.SelectedIndex = alphabetComboBox.FindString(Client_FirstLoad.License_Plate.Substring(13, 1));
			numTextBox2.Text = Client_FirstLoad.License_Plate.Substring(10, 3);
			numTextBox1.Text = Client_FirstLoad.License_Plate.Substring(17, 2);
			Client_GetData.License_Plate = listClientDataGridView.CurrentRow.Cells[3].Value.ToString();

			Client_FirstLoad.Phone_Number = listClientDataGridView.CurrentRow.Cells[2].Value.ToString().Replace("-", string.Empty).Trim();
			phoneNumberTextBox.Text = listClientDataGridView.CurrentRow.Cells[2].Value.ToString().Replace("-", string.Empty).Trim();
			Client_GetData.Phone_Number = listClientDataGridView.CurrentRow.Cells[2].Value.ToString().Replace("-", string.Empty).Trim();
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
			numTextBox1.Clear();
			numTextBox2.Clear();
			alphabetComboBox.SelectedIndex = 0;
			numTextBox3.Clear();
			confirmLicensePlatePicturBox.Visible = false;
			phoneNumberTextBox.Clear();

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

						GetListClient();
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
					.Where(current => string.Compare(current.Client_Name, _editClient.Client_Name) == 0)
					.FirstOrDefault();

				client.Client_Name = _editClient.Client_Name;
				client.License_Plate = _editClient.License_Plate;
				client.Phone_Number = _editClient.Phone_Number;

				dataBaseContext.SaveChanges();

				saveButton.Text = "ثبت مشتری";

				AllClear();
				GetListClient();

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

		#region EditClientEventLog
		private void EditClientEventLog(Models.Client _firstLoad, Models.Client _newData)
		{
			string eventDescription = null;


			if (string.Compare(_firstLoad.Client_Name, _newData.Client_Name) != 0)
			{
				eventDescription = $"نام {_firstLoad.Client_Name} به {_newData.Client_Name} تغییر یافت.";
			}
			if (string.Compare(_firstLoad.License_Plate, _newData.License_Plate) != 0)
			{
				if (eventDescription != null)
				{
					eventDescription +=
						System.Environment.NewLine;
				}

				eventDescription +=
					$"پلاک وسیله نقلیه آقا / خانم {_newData.Client_Name} از {_firstLoad.License_Plate} به {_newData.License_Plate} تغییر یافت.";
			}
			if (string.Compare(_firstLoad.Phone_Number, _newData.Phone_Number) != 0)
			{
				if (eventDescription != null)
				{
					eventDescription +=
						System.Environment.NewLine;
				}

				eventDescription +=
					$"شماره تلفن آقا / خانم {_newData.Client_Name} از {_firstLoad.Phone_Number} به {_newData.Phone_Number} تغییر یافت.";
			}

			#region  -----------------------------------------    SetEventLog     -----------------------------------------
			if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
			{
				EventLog.Username = Inventory.Program.UserAuthentication.Username;
				EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
				EventLog.Description = eventDescription;
				EventLog.Event_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
				EventLog.Event_Time = Infrastructure.Utility.ShowTime();

				Infrastructure.Utility.EventLog(EventLog);
			}
			#endregion / -----------------------------------------     SetEventLog     -----------------------------------------
		}
		#endregion /EditClientEventLog

		#region GetListClient
		/// <summary>
		/// بارگزاری لیست مشتریان
		/// </summary>
		private void GetListClient()
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
						.OrderBy(current => current.Id)
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
		#endregion /GetListClient

		#region Initialize
		/// <summary>
		/// تنظیمات ورود اولیه
		/// </summary>
		public void Initialize()
		{
			AllClear();
			GetListClient();
		}
		#endregion /Initialize

		#region LicensePlateConfirmation
		/// <summary>
		/// بررسی وجود شماره پلاک وسیله نقلیه در بانک اطلاعاتی
		/// </summary>
		/// <param name="_client"></param>
		/// <returns></returns>
		private static bool LicensePlateConfirmation(Models.Client _client)
		{
			bool status;

			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.Client client =
				dataBaseContext.Clients
				.Where(current => string.Compare(current.License_Plate, _client.License_Plate) == 0)
				.FirstOrDefault();

			if (client == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}

			return status;
		}
		#endregion /LicensePlateConfirmation

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
							.OrderBy(current => current.Id)
							.ToList();
					}
					else
					{
						listClients =
							dataBaseContext.Clients
							.Where(current => current.Phone_Number.Contains(_searchItem))
							.OrderBy(current => current.Id)
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
							.OrderBy(current => current.Id)
							.ToList();
					}
					else
					{
						listClients =
							dataBaseContext.Clients
							.Where(current => current.License_Plate.Contains(_searchItem))
							.OrderBy(current => current.Id)
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

		#region SetClient
		/// <summary>
		/// ذخیره اطلاعات در جدول مشتریان
		/// </summary>
		/// <param name="_client"></param>
		/// <returns>true or false</returns>
		private bool SetClient(Models.Client _setClient)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

					Models.Client client = new Models.Client();

					client.Client_Name = _setClient.Client_Name;
					client.License_Plate = _setClient.License_Plate;
					client.Phone_Number = _setClient.Phone_Number;
					client.Registration_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					client.Registration_Time = $"{Infrastructure.Utility.ShowTime()}";

					dataBaseContext.Clients.Add(client);
					dataBaseContext.SaveChanges();

					#region  -----------------------------------------    SetEventLog     -----------------------------------------
					if (string.Compare(Inventory.Program.UserAuthentication.Username, "admin") != 0)
					{
						EventLog.Username = Inventory.Program.UserAuthentication.Username;
						EventLog.Full_Name = Inventory.Program.UserAuthentication.Full_Name;
						EventLog.Description = $"ثبت آقا / خانم {_setClient.Client_Name} در سیستم.";
						EventLog.Event_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
						EventLog.Event_Time = Infrastructure.Utility.ShowTime();

						Infrastructure.Utility.EventLog(EventLog);
					}
					#endregion / -----------------------------------------     SetEventLog     -----------------------------------------

				AllClear();
				GetListClient();

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
		#endregion /SetClient

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

		#region TelConfirmation
		/// <summary>
		/// بررسی وجود شماره همراه در سیستم
		/// </summary>
		/// <param name="tel"></param>
		/// <returns></returns>
		private bool TelConfirmation(Models.Client _client)
		{
			bool status;
			Models.DataBaseContext dataBaseContext = null;
			dataBaseContext =
					new Models.DataBaseContext();

			Models.Client client =
				dataBaseContext.Clients
				.Where(current => string.Compare(current.Phone_Number, _client.Phone_Number) == 0)
				.FirstOrDefault();

			if (client == null)
			{
				status = true;
			}
			else
			{
				status = false;
			}
			return status;
		}


		#endregion /TelConfirmation

		#region ValidationData
		/// <summary>
		/// اعتبار سنجی اطلاعات ورودی
		/// </summary>
		/// <param name="_client"></param>
		/// <returns></returns>
		private bool ValidationData(Models.Client _client)
		{
			bool status = true;

			if (string.IsNullOrEmpty(_client.Client_Name))
			{
				status = false;
			}
			if (string.IsNullOrEmpty(_client.License_Plate))
			{
				status = false;
			}
			if (string.IsNullOrEmpty(_client.Phone_Number))
			{
				status = false;
			}

			if (status)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion /ValidationData

		#endregion /Function


	}
}

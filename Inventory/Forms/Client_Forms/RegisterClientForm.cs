using System.Linq;

namespace Client_Forms
{
	public partial class RegisterClientForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties
		public Models.Client Client { get; set; }

		public string Search_Item { get; set; }
		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public RegisterClientForm()
		{
			InitializeComponent();
			GetDataFromClient();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

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
				Client.Client_Name = null;
				return;
			}
			else
			{
				Client.Client_Name = clientNameTextBox.Text;
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
				Client.License_Plate = null;
				licensePlateTextBox.Clear();
				licensePlateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else
			{
				Client.License_Plate = licensePlateTextBox.Text = licensePlateTextBox.Text.Insert(2, " - ").Insert(7, " - ").Insert(8, " ایران ");
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
				Client.Phone_Number = null;
				phonNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else
			{
				Client.Phone_Number = phonNumberTextBox.Text = phonNumberTextBox.Text.Insert(3, "-");
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
			if (SetInClient(Client))
			{
				Infrastructure.Utility.WindowsNotification(message: "مشتری جدید ثبت گردید", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				return;
			}
			else
			{
				Infrastructure.Utility.WindowsNotification(message: "عدم موفقیت در ثبت اطلاعات", caption: Infrastructure.PopupNotificationForm.Caption.خطا);
			}
		}
		#endregion /SaveButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Function

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

		#endregion /Function

	}
}

using System.Linq;

namespace Inventory_Forms
{
	public partial class ServiceReportForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers



		//-----------------------------------------------------------------------------------------------     Constracture

		public ServiceReportForm()
		{
			InitializeComponent();
			LoadingService();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizeButton_Click

		#region SelectSearchComboBox_SelectedIndexChanged
		private void SelectSearchComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int index = selectSearchComboBox.SelectedIndex;

			switch (index)
			{
				case 0:
					searchClientNameTextBox.Visible = false;
					searchDateTextBox.Visible = false;
					break;
				case 1:
					searchClientNameTextBox.Visible = true;
					searchDateTextBox.Visible = false;
					break;
				case 2:
					searchClientNameTextBox.Visible = false;
					searchDateTextBox.Visible = true;
					break;
				case 3:
					searchClientNameTextBox.Visible = true;
					searchDateTextBox.Visible = true;
					break;
			}
		}
		#endregion /SelectSearchComboBox_SelectedIndexChanged

		#region SearchClientNameTextBox_Enter
		private void SearchClientNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /SearchClientNameTextBox_Enter

		#region SearchClientNameTextBox_KeyPress
		private void SearchClientNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /SearchClientNameTextBox_KeyPress

		#region SearchClientNameTextBox_TextChange
		private void SearchClientNameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (selectSearchComboBox.SelectedIndex == 1)
			{
				if (string.IsNullOrWhiteSpace (searchClientNameTextBox.Text))
				{
					return;
				}
				else
				{
					ClientNameSearch(searchClientNameTextBox.Text);
					return;
				}
				
			}
			else if(selectSearchComboBox.SelectedIndex == 3)
			{
				if (string.IsNullOrWhiteSpace(searchClientNameTextBox.Text) || string.IsNullOrWhiteSpace(searchDateTextBox.Text))
				{
					return;
				}
				else
				{
					ClientAndDateSearch(searchClientNameTextBox.Text, searchDateTextBox.Text);
				}
			}
		}
		#endregion /SearchClientNameTextBox_TextChange

		#region SearchDateTextBox_Enter
		private void SearchDateTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /SearchDateTextBox_Enter

		#region SearchDateTextBox_KeyPress
		private void SearchDateTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /SearchDateTextBox_KeyPress

		#region SearchDateTextBox_TextChange
		private void SearchDateTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (selectSearchComboBox.SelectedIndex == 2)
			{
				if (string.IsNullOrWhiteSpace(searchDateTextBox.Text))
				{
					return;
				}
				else
				{
					DateSearch(searchDateTextBox.Text);
					return;
				}
			}
			else if (selectSearchComboBox.SelectedIndex == 3)
			{
				if (string.IsNullOrWhiteSpace(searchDateTextBox.Text) || string.IsNullOrWhiteSpace(searchClientNameTextBox.Text))
				{
					return;
				}
				else
				{
					ClientAndDateSearch(searchClientNameTextBox.Text, searchDateTextBox.Text);
					return;
				}
			}
		}
		#endregion /SearchDateTextBox_TextChange

		#region ServiceListDataGridView_CellDoubleClick
		private void ServiceListDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}
			if (e.ColumnIndex < 0)
			{
				return;
			}

			clientNameLabel.Text = serviceListDataGridView.CurrentRow.Cells[1].Value.ToString();
			repairmanNameLabel.Text = serviceListDataGridView.CurrentRow.Cells[2].Value.ToString();
			registerDateLabel.Text = $"{serviceListDataGridView.CurrentRow.Cells[6].Value} - {serviceListDataGridView.CurrentRow.Cells[7].Value}";
			registerDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			serviceNameLabel.Text = serviceListDataGridView.CurrentRow.Cells[3].Value.ToString();
			servicePriceLabel.Text = serviceListDataGridView.CurrentRow.Cells[4].Value.ToString();
			serviceNumberLabel.Text = serviceListDataGridView.CurrentRow.Cells[5].Value.ToString();
			serviceNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			descriptionLabel.Text = serviceListDataGridView.CurrentRow.Cells[8].Value.ToString();
		}
		#endregion /ServiceListDataGridView_CellDoubleClick



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founction

		#region ClientNameSearch
		private void ClientNameSearch(string clientName)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.Service> clientList = new System.Collections.Generic.List<Models.Service>();

				if (string.IsNullOrEmpty(clientName))
				{
					clientList =
					dataBaseContext.Services
					.OrderBy(current => current.Id)
					.ToList();
				}
				else
				{
					clientList =
					dataBaseContext.Services
					.Where(current => current.Client_Name.Contains(clientName))
					.OrderBy(current => current.Client_Name)
					.ToList();
				}

				serviceListDataGridView.DataSource = clientList;
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
		#endregion /ClientNameSearch

		#region ClientAndDateSearch
		private void ClientAndDateSearch (string clientNameSearch, string dateSearch)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.Service> clientAndDateList = new System.Collections.Generic.List<Models.Service>();

				if (string.IsNullOrEmpty(clientNameSearch) || string.IsNullOrEmpty(dateSearch))
				{
					clientAndDateList =
					dataBaseContext.Services
					.OrderBy(current => current.Id)
					.ToList();
				}
				else
				{
					clientAndDateList =
					dataBaseContext.Services
					.Where(current => current.Client_Name.Contains(clientNameSearch) && current.Registration_Date.Contains(dateSearch))
					.OrderBy(current => current.Client_Name)
					.ToList();
				}

				serviceListDataGridView.DataSource = clientAndDateList;

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
		#endregion /ClientAndDateSearch

		#region DateSearch
		private void DateSearch(string dateSearch)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.Service> dateList = new System.Collections.Generic.List<Models.Service>();


				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.Service> clientList = new System.Collections.Generic.List<Models.Service>();

				if (string.IsNullOrEmpty(dateSearch))
				{
					clientList =
					dataBaseContext.Services
					.OrderBy(current => current.Id)
					.ToList();
				}
				else
				{
					clientList =
					dataBaseContext.Services
					.Where(current => current.Registration_Date.Contains(dateSearch))
					.OrderBy(current => current.Client_Name)
					.ToList();
				}

				serviceListDataGridView.DataSource = clientList;
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
		#endregion /DateSearch

		#region LoadingService
		private void LoadingService()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Service> serviceList = new System.Collections.Generic.List<Models.Service>();

				serviceList =
					dataBaseContext.Services
					.OrderBy(current => current.Id)
					.ToList();


				if (serviceList != null)
				{
					serviceListDataGridView.DataSource = serviceList;
				}
				else
				{
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

		#endregion /LoadingService

		#endregion /Founction
	}
}

﻿using System.Linq;

namespace Inventory_Forms
{
	public partial class ServiceReportForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		private int index = 0;

		public string SearchItem { get; set; }

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
			index = selectSearchComboBox.SelectedIndex;

			switch (index)
			{
				case 1:
				Infrastructure.Utility.EnglishLanguage();
				invoicePanel.Visible = true;
					licensePlatePanel.Visible = false;
				break;

				case 2:
				Infrastructure.Utility.PersianLanguage();
				invoicePanel.Visible = false;
					licensePlatePanel.Visible = true;
				break;

				case 3:
				Infrastructure.Utility.PersianLanguage();
				invoicePanel.Visible = false;
					licensePlatePanel.Visible = true;
				break;
			}
		}
		#endregion /SelectSearchComboBox_SelectedIndexChanged

		#region SearchClientNameTextBox_Enter
		private void SearchTextBox_Enter(object sender, System.EventArgs e)
		{
			switch (index)
			{
				case 1:
				searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				break;
				case 2:
				searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				break;
				case 3:
				searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				break;
			}
		}
		#endregion /SearchClientNameTextBox_Enter

		#region SearchClientNameTextBox_KeyPress
		private void SearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			switch (index)
			{
				case 0:
				Mbb.Windows.Forms.MessageBox.Show(
					text: "لطفا نوع جستجو را تعیین نمایید.",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Alert,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				selectSearchComboBox.Focus();
				break;
				case 1:
					Infrastructure.Utility.EnglishAndNumberTyping(e);
				break;
				case 2:
				Infrastructure.Utility.PersianAndNumberTyping(e);
				break;
				case 3:
				Infrastructure.Utility.InsertOnlyNumber(e);
				break;
			}
		}
		#endregion /SearchClientNameTextBox_KeyPress

		#region SearchClientNameTextBox_TextChange
		private void SearchTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchTextBox.Text))
			{
				SearchItem = null;
			}
			else
			{
				SearchItem = searchTextBox.Text;
			}
		}
		#endregion /SearchClientNameTextBox_TextChange

		#region SearchButton_Click
		private void SearchButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /SearchButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founction

		//#region ClientNameSearch
		//private void ClientNameSearch(string clientName)
		//{
		//	Models.DataBaseContext dataBaseContext = null;

		//	try
		//	{
		//		dataBaseContext =
		//			new Models.DataBaseContext();
		//		System.Collections.Generic.List<Models.Service> clientList = new System.Collections.Generic.List<Models.Service>();

		//		if (string.IsNullOrEmpty(clientName))
		//		{
		//			clientList =
		//			dataBaseContext.Services
		//			.OrderBy(current => current.Id)
		//			.ToList();
		//		}
		//		else
		//		{
		//			clientList =
		//			dataBaseContext.Services
		//			.Where(current => current.Client_Name.Contains(clientName))
		//			.OrderBy(current => current.Client_Name)
		//			.ToList();
		//		}

		//		serviceListDataGridView.DataSource = clientList;
		//	}
		//	catch (System.Exception ex)
		//	{
		//		Infrastructure.Utility.ExceptionShow(ex);
		//	}
		//	finally
		//	{
		//		if (dataBaseContext != null)
		//		{
		//			dataBaseContext.Dispose();
		//			dataBaseContext = null;
		//		}
		//	}
		//}
		//#endregion /ClientNameSearch

		//#region ClientAndDateSearch
		//private void ClientAndDateSearch(string clientNameSearch, string dateSearch)
		//{
		//	Models.DataBaseContext dataBaseContext = null;

		//	try
		//	{
		//		dataBaseContext =
		//			new Models.DataBaseContext();
		//		System.Collections.Generic.List<Models.Service> clientAndDateList = new System.Collections.Generic.List<Models.Service>();

		//		if (string.IsNullOrEmpty(clientNameSearch) || string.IsNullOrEmpty(dateSearch))
		//		{
		//			clientAndDateList =
		//			dataBaseContext.Services
		//			.OrderBy(current => current.Id)
		//			.ToList();
		//		}
		//		else
		//		{
		//			clientAndDateList =
		//			dataBaseContext.Services
		//			.Where(current => current.Client_Name.Contains(clientNameSearch) && current.Registration_Date.Contains(dateSearch))
		//			.OrderBy(current => current.Client_Name)
		//			.ToList();
		//		}

		//		serviceListDataGridView.DataSource = clientAndDateList;

		//	}
		//	catch (System.Exception ex)
		//	{
		//		Infrastructure.Utility.ExceptionShow(ex);
		//	}
		//	finally
		//	{
		//		if (dataBaseContext != null)
		//		{
		//			dataBaseContext.Dispose();
		//			dataBaseContext = null;
		//		}
		//	}
		//}
		//#endregion /ClientAndDateSearch




		//#region DateSearch
		//private void DateSearch(string dateSearch)
		//{
		//	Models.DataBaseContext dataBaseContext = null;

		//	try
		//	{
		//		dataBaseContext =
		//			new Models.DataBaseContext();
		//		System.Collections.Generic.List<Models.Service> dateList = new System.Collections.Generic.List<Models.Service>();


		//		dataBaseContext =
		//			new Models.DataBaseContext();
		//		System.Collections.Generic.List<Models.Service> clientList = new System.Collections.Generic.List<Models.Service>();

		//		if (string.IsNullOrEmpty(dateSearch))
		//		{
		//			clientList =
		//			dataBaseContext.Services
		//			.OrderBy(current => current.Id)
		//			.ToList();
		//		}
		//		else
		//		{
		//			clientList =
		//			dataBaseContext.Services
		//			.Where(current => current.Registration_Date.Contains(dateSearch))
		//			.OrderBy(current => current.Client_Name)
		//			.ToList();
		//		}

		//		serviceListDataGridView.DataSource = clientList;
		//	}
		//	catch (System.Exception ex)
		//	{
		//		Infrastructure.Utility.ExceptionShow(ex);
		//	}
		//	finally
		//	{
		//		if (dataBaseContext != null)
		//		{
		//			dataBaseContext.Dispose();
		//			dataBaseContext = null;
		//		}
		//	}
		//}
		//#endregion /DateSearch

		private void GetInvoiced (string _invoiceSerialNumvber)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Service> listService = null;

				Models.InvoiceSerialNumber invoiceSerialNumber=
					dataBaseContext.InvoiceSerialNumbers
					.Where(current => string.Compare(current.Invoice_Serial_Numvber, _invoiceSerialNumvber) == 0)
					.FirstOrDefault();

				if (invoiceSerialNumber == null)
				{
					Mbb.Windows.Forms.MessageBox.Show(
						text:"شماره فاکتور مورد نظر در سیستم یافت نگردید. \n لطفا مجدد تلاش نمیادد."
						,caption: "جستجوی ناموفق"
						,icon: Mbb.Windows.Forms.MessageBoxIcon.Error
						,button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					searchTextBox.Focus();
				}
				else
				{
					listService =
					dataBaseContext.Services
					.Where(current => current.Invoice_Serial_Numvber.Contains(invoiceSerialNumber.Invoice_Serial_Numvber))
					.OrderByDescending(current => current.Service_Name)
					.ToList();
				}

				serviceListDataGridView.DataSource = listService;

				invoiceSerialNumberTextBox.Text = invoiceSerialNumber.Invoice_Serial_Numvber;







			}
			catch (System.Exception ex)
			{

				throw;
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
		
		private void GetLicensePlate(string searchItem)
		{

		}

		private void GetPhoneNumber(string searchItem)
		{

		}

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

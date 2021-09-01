using System.Linq;

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
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region ServiceReportForm_Load
		private void ServiceReportForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /ServiceReportForm_Load

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			closeFadeTimer.Start();
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
			if (index == 0)
			{
				Mbb.Windows.Forms.MessageBox.Show(
					"لطفا نوع جستجو را انتخاب نمایید",
					"خطای ورودی",
					Mbb.Windows.Forms.MessageBoxIcon.Error,
					Mbb.Windows.Forms.MessageBoxButtons.Ok);
				selectSearchComboBox.Focus();
				return;
			}
			else if (index == 1)
			{
				GetInvoiced(SearchItem);
				return;
			}
			else if (index == 2)
			{
				GetLicensePlate(SearchItem);
				return;
			}
			else if (index == 3)
			{
				GetPhoneNumber(SearchItem);
				return;
			}
			else
			{
				Mbb.Windows.Forms.MessageBox.Show(
					"لطفا نوع جستجو را انتخاب نمایید",
					"خطای ورودی",
					Mbb.Windows.Forms.MessageBoxIcon.Error,
					Mbb.Windows.Forms.MessageBoxButtons.Ok);
				selectSearchComboBox.Focus();
				return;
			}

		}
		#endregion /SearchButton_Click

		#region ShowFadeTimer_Tick
		private void ShowFadeTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity += 0.5;
			if (this.Opacity >= 10)
			{
				showFadeTimer.Stop();
			}
		}
		#endregion /ShowFadeTimer_Tick

		#region CloseFadeTimer_Tick
		private void CloseFadeTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.5;
			if (this.Opacity <= 0)
			{
				closeFadeTimer.Stop();
				this.Dispose();
			}
		}
		#endregion /CloseFadeTimer_Tick



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founction

		#region GetInvoiced
		/// <summary>
		/// برگرداندن فاکتور سرویس ها
		/// </summary>
		/// <param name="_invoiceSerialNumvber"></param>
		private void GetInvoiced(string _invoiceSerialNumvber)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ListService> listService = null;

				Models.ServiceInvoice invoiceSerialNumber =
					dataBaseContext.ServiceInvoices
					.Where(current => string.Compare(current.Invoice_Serial_Numvber, _invoiceSerialNumvber) == 0)
					.FirstOrDefault();

				if (invoiceSerialNumber == null)
				{
					Mbb.Windows.Forms.MessageBox.Show(
						text: "شماره فاکتور مورد نظر در سیستم یافت نگردید. \n لطفا مجدد تلاش نمیادد."
						, caption: "جستجوی ناموفق"
						, icon: Mbb.Windows.Forms.MessageBoxIcon.Error
						, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					searchTextBox.Focus();
				}
				else
				{
					listService =
					dataBaseContext.ListServices
					.Where(current => current.Invoice_Serial_Numvber.Contains(invoiceSerialNumber.Invoice_Serial_Numvber))
					.OrderByDescending(current => current.Service_Name)
					.ToList();
				}

				serviceListDataGridView.DataSource = listService;

				invoiceSerialNumberTextBox.Text = invoiceSerialNumber.Invoice_Serial_Numvber;
				serviceDateTextBox.Text = invoiceSerialNumber.Service_Date;
				serviceTimeTextBox.Text = invoiceSerialNumber.Service_Time;
				currentKilometersTextBox.Text = invoiceSerialNumber.Current_Kilometer;
				clientNameTextBox.Text = invoiceSerialNumber.Client_Name;
				licensePlateTextBox.Text = invoiceSerialNumber.License_Plate;
				phonNumberTextBox.Text = invoiceSerialNumber.Phone_Number;
				nextKilometersTextBox.Text = invoiceSerialNumber.Next_Kilometer;

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
		#endregion /GetInvoiced

		#region GetLicensePlate
		/// <summary>
		/// جستجو بر اساس شماره پلاک وسیله نقلیه
		/// </summary>
		/// <param name="searchItem"></param>
		private void GetLicensePlate(string _licensePlate)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ListService> listService = null;

				Models.ServiceInvoice invoiceSerialNumber =
					dataBaseContext.ServiceInvoices
					.Where(current => string.Compare(current.License_Plate, _licensePlate) == 0)
					.FirstOrDefault();

				if (invoiceSerialNumber == null)
				{
					Mbb.Windows.Forms.MessageBox.Show(
						text: "شماره پلاک وسیله نقلیه مورد نظر در سیستم یافت نگردید. \n لطفا مجدد تلاش نمیادد."
						, caption: "جستجوی ناموفق"
						, icon: Mbb.Windows.Forms.MessageBoxIcon.Error
						, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					searchTextBox.Focus();
				}
				else
				{
					listService =
					dataBaseContext.ListServices
					.Where(current => current.Invoice_Serial_Numvber.Contains(invoiceSerialNumber.Invoice_Serial_Numvber))
					.OrderByDescending(current => current.Service_Name)
					.ToList();
				}

				serviceListDataGridView.DataSource = listService;

				invoiceSerialNumberTextBox.Text = invoiceSerialNumber.Invoice_Serial_Numvber;
				serviceDateTextBox.Text = invoiceSerialNumber.Service_Date;
				serviceTimeTextBox.Text = invoiceSerialNumber.Service_Time;
				currentKilometersTextBox.Text = invoiceSerialNumber.Current_Kilometer;
				clientNameTextBox.Text = invoiceSerialNumber.Client_Name;
				licensePlateTextBox.Text = invoiceSerialNumber.License_Plate;
				phonNumberTextBox.Text = invoiceSerialNumber.Phone_Number;
				nextKilometersTextBox.Text = invoiceSerialNumber.Next_Kilometer;

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
		#endregion /GetLicensePlate

		#region GetPhoneNumber
		/// <summary>
		/// جستجو بر اساس شماره تماس
		/// </summary>
		/// <param name="searchItem"></param>
		private void GetPhoneNumber(string _phoneNumber)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ListService> listService = null;

				Models.ServiceInvoice invoiceSerialNumber =
					dataBaseContext.ServiceInvoices
					.Where(current => string.Compare(current.Phone_Number, _phoneNumber) == 0)
					.FirstOrDefault();

				if (invoiceSerialNumber == null)
				{
					Mbb.Windows.Forms.MessageBox.Show(
						text: "شماره تماس مورد نظر در سیستم یافت نگردید. \n لطفا مجدد تلاش نمیادد."
						, caption: "جستجوی ناموفق"
						, icon: Mbb.Windows.Forms.MessageBoxIcon.Error
						, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					searchTextBox.Focus();
				}
				else
				{
					listService =
					dataBaseContext.ListServices
					.Where(current => current.Invoice_Serial_Numvber.Contains(invoiceSerialNumber.Invoice_Serial_Numvber))
					.OrderByDescending(current => current.Service_Name)
					.ToList();
				}

				serviceListDataGridView.DataSource = listService;

				invoiceSerialNumberTextBox.Text = invoiceSerialNumber.Invoice_Serial_Numvber;
				serviceDateTextBox.Text = invoiceSerialNumber.Service_Date;
				serviceTimeTextBox.Text = invoiceSerialNumber.Service_Time;
				currentKilometersTextBox.Text = invoiceSerialNumber.Current_Kilometer;
				clientNameTextBox.Text = invoiceSerialNumber.Client_Name;
				licensePlateTextBox.Text = invoiceSerialNumber.License_Plate;
				phonNumberTextBox.Text = invoiceSerialNumber.Phone_Number;
				nextKilometersTextBox.Text = invoiceSerialNumber.Next_Kilometer;

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
		#endregion /GetPhoneNumber

		#region Initialize
		/// <summary>
		/// تنظیمات ورود اولیه
		/// </summary>
		private void Initialize()
		{
			this.Opacity = 0.0;

			showFadeTimer.Start();
			LoadingService();
		}
		#endregion /Initialize

		#region LoadingService
		private void LoadingService()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ListService> serviceList = new System.Collections.Generic.List<Models.ListService>();

				serviceList =
					dataBaseContext.ListServices
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

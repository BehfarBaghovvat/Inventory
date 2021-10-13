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
			hideFadeTimer.Start();
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
				searchLicensePlateGroupBox.Visible = false;
				searchTextBox.Visible = true;
				invoicePanel.BringToFront();
				licensePlatePanel.SendToBack();
				break;

				case 2:
				Infrastructure.Utility.PersianLanguage();
				searchLicensePlateGroupBox.Visible = true;
				searchTextBox.Visible = false;
				invoicePanel.SendToBack();
				licensePlatePanel.BringToFront();
				break;

				case 3:
				searchLicensePlateGroupBox.Visible = false;
				searchTextBox.Visible = true;
				invoicePanel.SendToBack();
				licensePlatePanel.BringToFront();
				break;
			}
		}
		#endregion /SelectSearchComboBox_SelectedIndexChanged

		#region SearchLicensePlateGroupBox_Leave
		private void SearchLicensePlateGroupBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(numTextBox1.Text) || string.IsNullOrWhiteSpace(numTextBox2.Text) || string.IsNullOrWhiteSpace(numTextBox3.Text))
			{
				SearchItem = null;
				return;
			}
			else
			{
				SearchItem =
					$"{numTextBox3.Text}{iranLabel.Text} - {numTextBox2.Text}{alphabetComboBox.SelectedItem} - {numTextBox1.Text}";
			}
		}
		#endregion /SearchLicensePlateGroupBox_Leave

		#region SearchTextBox_Enter
		private void SearchTextBox_Enter(object sender, System.EventArgs e)
		{
			switch (index)
			{
				case 1:
				Infrastructure.Utility.EnglishLanguage();
				
				break;
				case 3:
				Infrastructure.Utility.PersianLanguage();
				
				break;
			}
		}
		#endregion /SearchTextBox_Enter

		#region SearchTextBox_KeyPress
		private void SearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (index == 1)
			{
				Infrastructure.Utility.EnglishAndNumberTyping(e);
				
			}
			else if (index == 3)
			{
				Infrastructure.Utility.InsertOnlyNumber(e);
			}
			else
			{
				Infrastructure.Utility.InsertOnlyNumber(e);
			}
		}
		#endregion /SearchTextBox_KeyPress

		#region SearchTextBox_TextChange
		private void SearchTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (index == 0)
			{
				Mbb.Windows.Forms.MessageBox.Show(
					text: "لطفا نوع جستجو را تعیین نمایید.",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Alert,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
				//searchTextBox.Clear();
				//selectSearchComboBox.Focus();
				return;
			}
			else if (searchTextBox.Text.Length <= 0)
			{
				searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				searchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				searchTextBox.Font = Infrastructure.Utility.IRANSansXFaNumFont(9);
				SearchItem = null;
				return;
			}
			else
			{
				if (index == 1)
				{
					searchTextBox.Font = Infrastructure.Utility.CenturyGothicFont(9);
					searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
					searchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
					SearchItem = searchTextBox.Text;
					return;
				}
				else if (index == 3)
				{
					searchTextBox.Font = Infrastructure.Utility.IRANSansXFaNumFont(9);
					SearchItem = searchTextBox.Text;
					return;
				}
			}
		}
		#endregion /SearchTextBox_TextChange

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
				if (string.IsNullOrEmpty(SearchItem))
				{
					Mbb.Windows.Forms.MessageBox.Show(
						text: "لطفا سریال فاکتور را وارد نمایید. ",
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					searchTextBox.Focus();
					return;
				}
				else
				{
					GetInvoiced(SearchItem);
				}
				return;
			}
			else if (index == 2)
			{
				if (string.IsNullOrEmpty(SearchItem))
				{
					Mbb.Windows.Forms.MessageBox.Show(
						text: "لطفا شماره پلاک وسیله نقلیه را وارد نمایید. ",
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					searchNumTextBox1.Focus();
					return;
				}
				else
				{
					GetLicensePlate(SearchItem);
				}
				return;
			}
			else if (index == 3)
			{
				if (string.IsNullOrEmpty(SearchItem))
				{
					Mbb.Windows.Forms.MessageBox.Show(
						text: "لطفا شماره تلفن همراه را وارد نمایید. ",
						caption: "خطای ورودی",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
					searchTextBox.Focus();
					return;
				}
				else
				{
					GetPhoneNumber(SearchItem);
				}
				return;
			}
		}
		#endregion /SearchButton_Click

		#region HideFadeTimer_Tick
		private void HideFadeTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.1;
			if (this.Opacity <= 0.0)
			{
				hideFadeTimer.Stop();
				this.Dispose();
			}
		}
		#endregion /HideFadeTimer_Tick



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founction

		#region GetInvoiced
		/// <summary>
		/// برگرداندن فاکتور سرویس ها
		/// </summary>
		/// <param name="_invoiceSerialNumvber"></param>
		private void GetInvoiced(string _invoiceSerialNumber)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ServiceInvoice invoiceSerialNumber =
					dataBaseContext.ServiceInvoices
					.Where(current => string.Compare(current.Invoice_Serial_Number, _invoiceSerialNumber, false) == 0)
					.FirstOrDefault();

				if (invoiceSerialNumber == null)
				{
					Mbb.Windows.Forms.MessageBox.Show(
						text: "شماره فاکتور مورد نظر در سیستم یافت نگردید. \n لطفا مجدد تلاش نمیاد."
						, caption: "جستجوی ناموفق"
						, icon: Mbb.Windows.Forms.MessageBoxIcon.Error
						, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

					searchTextBox.Focus();
				}
				else
				{
					System.Collections.Generic.List<Models.ListService> listService = null;
					listService =
					dataBaseContext.ListServices
					.Where(current => current.Invoice_Serial_Numvber.Contains(invoiceSerialNumber.Invoice_Serial_Number))
					.OrderByDescending(current => current.Service_Name)
					.ToList();

					serviceListDataGridView.DataSource = listService;

					invoiceSerialNumberTextBox.Text = invoiceSerialNumber.Invoice_Serial_Number;
					serviceDateTextBox.Text = invoiceSerialNumber.Service_Date;
					serviceTimeTextBox.Text = invoiceSerialNumber.Service_Time;
					currentKilometersTextBox.Text = invoiceSerialNumber.Current_Kilometer;
					clientNameTextBox.Text = invoiceSerialNumber.Client_Name;
					numTextBox3.Text = invoiceSerialNumber.License_Plate.Substring(0, 2);
					alphabetComboBox.SelectedIndex = alphabetComboBox.FindString(invoiceSerialNumber.License_Plate.Substring(13, 1));
					numTextBox2.Text = invoiceSerialNumber.License_Plate.Substring(10, 3);
					numTextBox1.Text = invoiceSerialNumber.License_Plate.Substring(17, 2);
					phonNumberTextBox.Text = invoiceSerialNumber.Phone_Number;
					nextKilometersTextBox.Text = invoiceSerialNumber.Next_Kilometer;
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
					.Where(current => current.Invoice_Serial_Numvber.Contains(invoiceSerialNumber.Invoice_Serial_Number))
					.OrderByDescending(current => current.Service_Name)
					.ToList();

					serviceListDataGridView.DataSource = listService;

					invoiceSerialNumberTextBox.Text = invoiceSerialNumber.Invoice_Serial_Number;
					serviceDateTextBox.Text = invoiceSerialNumber.Service_Date;
					serviceTimeTextBox.Text = invoiceSerialNumber.Service_Time;
					currentKilometersTextBox.Text = invoiceSerialNumber.Current_Kilometer;
					clientNameTextBox.Text = invoiceSerialNumber.Client_Name;
					numTextBox3.Text = invoiceSerialNumber.License_Plate.Substring(0, 2);
					alphabetComboBox.SelectedIndex = alphabetComboBox.FindString(invoiceSerialNumber.License_Plate.Substring(13, 1));
					numTextBox2.Text = invoiceSerialNumber.License_Plate.Substring(10, 3);
					numTextBox1.Text = invoiceSerialNumber.License_Plate.Substring(17, 2);
					phonNumberTextBox.Text = invoiceSerialNumber.Phone_Number;
					nextKilometersTextBox.Text = invoiceSerialNumber.Next_Kilometer;
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
					return;
				}
				else
				{
					listService =
					dataBaseContext.ListServices
					.Where(current => current.Invoice_Serial_Numvber.Contains(invoiceSerialNumber.Invoice_Serial_Number))
					.OrderByDescending(current => current.Service_Name)
					.ToList();

					serviceListDataGridView.DataSource = listService;

					invoiceSerialNumberTextBox.Text = invoiceSerialNumber.Invoice_Serial_Number;
					serviceDateTextBox.Text = invoiceSerialNumber.Service_Date;
					serviceTimeTextBox.Text = invoiceSerialNumber.Service_Time;
					currentKilometersTextBox.Text = invoiceSerialNumber.Current_Kilometer;
					clientNameTextBox.Text = invoiceSerialNumber.Client_Name;
					numTextBox3.Text = invoiceSerialNumber.License_Plate.Substring(0, 2);
					alphabetComboBox.SelectedIndex = alphabetComboBox.FindString(invoiceSerialNumber.License_Plate.Substring(13, 1));
					numTextBox2.Text = invoiceSerialNumber.License_Plate.Substring(10, 3);
					numTextBox1.Text = invoiceSerialNumber.License_Plate.Substring(17, 2);
					phonNumberTextBox.Text = invoiceSerialNumber.Phone_Number;
					nextKilometersTextBox.Text = invoiceSerialNumber.Next_Kilometer;
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
		#endregion /GetPhoneNumber

		#region Initialize
		/// <summary>
		/// تنظیمات ورود اولیه
		/// </summary>
		private void Initialize()
		{
			showFormAnimateWindow.Interval = 200;
			showFormAnimateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
			showFormAnimateWindow.Start();
			//LoadingService();

			searchTextBox.Clear();
		}
		#endregion /Initialize

		#region LoadingService
		/// <summary>
		/// بارگذاری لیست سرویس
		/// </summary>
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

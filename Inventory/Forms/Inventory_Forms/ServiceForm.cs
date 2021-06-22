using System.Linq;

namespace Inventory_Forms
{
	public partial class ServiceForm : Infrastructure.EmptyForm
	{
		#region Properties

		#region Layer
		/// <summary>
		/// این کلاس به همراه خصوصیات آن جهت انتقال اطلاعات به داخل گزارش
		/// تهیه گردیده است.
		/// </summary>
		private class ServiceItem
		{
			//نکته: به یاد داشته باشید که نام پراپرتیز ها باید هم نام با عناصر داخل گزارش باشد
			// در غیر این صورت داده ها انتقال پیدا نمیکند.
			public string Service_Name { get; set; }
			public string Description { get; set; }
			public string Service_Price { get; set; }
			public int Service_Number { get; set; }
			public string TotalPrice { get; set; }
		}

		private BillServicePrintForm _billServicePrintForm;

		public BillServicePrintForm BillServicePrintForm
		{
			get
			{
				if (_billServicePrintForm == null || _billServicePrintForm.IsDisposed == true)
				{
					_billServicePrintForm =
						new BillServicePrintForm();
				}
				return _billServicePrintForm;
			}
		}
		#endregion /Layer

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
			set { _eventLog = value; }
		}

		private Models.Service _service = null;
		public Models.Service Service
		{
			get
			{
				if (_service == null)
				{
					_service =
						new Models.Service();
				}
				return _service;
			}
			set { _service = value; }
		}

		public int? AmountPayment { get; set; }
		public int? CashPaymentAmount { get; set; }
		public int? Percent { get; set; }
		public int? Price { get; set; }
		public int? PosePaymentAmount { get; set; }
		public int? RemainingAmount { get; set; }
		public int? SumPirice { get; set; }
		#endregion /Properties

		public ServiceForm()
		{
			InitializeComponent();

			Service.Registration_Date = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
			Service.Registration_Time = Infrastructure.Utility.ShowTime();

			registerDateTextBox.Text = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} - { Infrastructure.Utility.ShowTime()}";

			LoadService();
		}

		//----------Beginning of the code!----------

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
				Service.Client_Name = null;
				return;
			}
			else
			{
				Service.Client_Name = clientNameTextBox.Text;
			}
		}
		#endregion /ClientNameTextBox_TextChange

		#region ServceNameComboBox_SelectionChangeCommitted
		private void ServiceNameComboBox_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			SetServicePrice();
		}
		#endregion /ServceNameComboBox_SelectionChangeCommitted

		#region ServicePriceTextBox_Enter
		private void ServicePriceTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (string.IsNullOrWhiteSpace(servicePriceTextBox.Text))
			{
				Price = null;
				servicePriceTextBox.Text = "0 تومان";
				servicePriceTextBox.Select(0, 1);
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
			else if (servicePriceTextBox.Text.Contains("تومان"))
			{
				return;
			}
		}
		#endregion /ServicePriceTextBox_Enter

		#region ServicePriceTextBox_KeyPress
		private void ServicePriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /ServicePriceTextBox_KeyPress

		#region ServicePriceTextBox_Leave
		private void ServicePriceTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(servicePriceTextBox.Text))
			{
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				Service.Service_Price = null;
				return;
			}
			else if (string.Compare(servicePriceTextBox.Text, "0 تومان") == 0)
			{
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				servicePriceTextBox.Clear();
				Price = null;
				Service.Service_Price = null;
				return;

			}
			else if (string.Compare(servicePriceTextBox.Text, " تومان") == 0 || string.Compare(servicePriceTextBox.Text, "تومان") == 0 || string.Compare(servicePriceTextBox.Text, "توما") == 0 || string.Compare(servicePriceTextBox.Text, "توم") == 0 || string.Compare(servicePriceTextBox.Text, "تو") == 0 || string.Compare(servicePriceTextBox.Text, "ت") == 0)
			{
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				servicePriceTextBox.Clear();
				Price = null;
				Service.Service_Price = null;
				return;
			}
			else
			{
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				Service.Service_Price = servicePriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				Price = int.Parse(Service.Service_Price.Replace(",", string.Empty).Trim());
				servicePriceTextBox.Text = $"{Price:#,0} تومان";
				Service.Service_Price = servicePriceTextBox.Text;
			}
		}
		#endregion /ServicePriceTextBox_Leave

		#region ServiceNameComboBox_TextChanged
		private void ServiceNameComboBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(servicePriceTextBox.Text))
			{
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			}
			else
			{
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			}
		}
		#endregion /ServiceNameComboBox_TextChanged

		#region ServiceNumberTextBox_Enter
		private void ServiceNumberTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /ServiceNumberTextBox_Enter

		#region ServiceNumberTextBox_KeyPress
		private void ServiceNumberTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /ServiceNumberTextBox_KeyPress

		#region ServiceNumberTextBox_TextChange
		private void ServiceNumberTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(serviceNumberTextBox.Text) || string.Compare(serviceNumberTextBox.Text, "0") == 0)
			{
				Service.Service_Number = null;
				return;
			}
			else
			{
				Service.Service_Number = int.Parse(serviceNumberTextBox.Text);
			}
		}
		#endregion /ServiceNumberTextBox_TextChange

		#region RepairmanNameTextBox_Enter
		private void RepairmanNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /RepairmanNameTextBox_Enter

		#region RepairmanNameTextBox_KeyPress
		private void RepairmanNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /RepairmanNameTextBox_KeyPress

		#region RepairmanNameTextBox_TextChange
		private void RepairmanNameTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(repairmanNameTextBox.Text))
			{
				Service.Repairman_Name = null;
				return;
			}
			else
			{
				Service.Repairman_Name = repairmanNameTextBox.Text;
			}
		}
		#endregion /RepairmanNameTextBox_TextChange

		#region DescriptionTextBox_Enter
		private void DescriptionTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /DescriptionTextBox_Enter

		#region DescriptionTextBox_KeyPress
		private void DescriptionTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /DescriptionTextBox_KeyPress

		#region DescriptionTextBox_TextChange
		private void DescriptionTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
			{
				Service.Description = null;
				return;
			}
			else
			{
				Service.Description = descriptionTextBox.Text;
			}
		}
		#endregion /DescriptionTextBox_TextChange

		#region AddServiceButton_Click
		private void AddServiceButton_Click(object sender, System.EventArgs e)
		{
			AddService(Service);
		}
		#endregion /AddServiceButton_Click

		#region ReductionServiceButton_Click
		private void ReductionServiceButton_Click(object sender, System.EventArgs e)
		{
			ReductionService();
		}
		#endregion /ReductionServiceButton_Click

		#region NewServiceButton_Click
		private void NewServiceButton_Click(object sender, System.EventArgs e)
		{
			NewService();
		}
		#endregion /NewServiceButton_Click

		#region ShowReportServiceButton_Click
		private void ShowReportServiceButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /ShowReportServiceButton_Click

		#region ServiceInvoiceButton_Click
		private void ServiceInvoiceButton_Click(object sender, System.EventArgs e)
		{
			if (InputValidation(Service))
			{
				System.Collections.Generic.List<ServiceItem> serviceItemLists = new System.Collections.Generic.List<ServiceItem>();

				foreach (System.Windows.Forms.DataGridViewRow rows in listServiceDataGridView.Rows)
				{
					ServiceItem iserviceItem = new ServiceItem
					{
						Service_Name = rows.Cells[0].Value.ToString(),
						Description = rows.Cells[1].Value.ToString(),
						Service_Price = rows.Cells[2].Value.ToString(),
						Service_Number = int.Parse(rows.Cells[3].Value.ToString()),
						TotalPrice = rows.Cells[4].Value.ToString(),
					};
					serviceItemLists.Add(iserviceItem);
				}

				Stimulsoft.Report.StiReport serviceReport = new Stimulsoft.Report.StiReport();

				serviceReport.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\ServicReport.mrt");
				serviceReport.RegBusinessObject("Service", serviceItemLists);

				(serviceReport.GetComponentByName("dateOfPrintTextBox") as Stimulsoft.Report.Components.StiText).Text = $"{Service.Registration_Date} - {Service.Registration_Time}";
				(serviceReport.GetComponentByName("repairmanNameTextBox") as Stimulsoft.Report.Components.StiText).Text = Service.Repairman_Name;
				(serviceReport.GetComponentByName("clientNameTextBox") as Stimulsoft.Report.Components.StiText).Text = Service.Client_Name;
				(serviceReport.GetComponentByName("sumPriceTextBox") as Stimulsoft.Report.Components.StiText).Text = sumPriceTextBox.Text;
				(serviceReport.GetComponentByName("amountPaymentTextBox") as Stimulsoft.Report.Components.StiText).Text = amountPaymentTextBox.Text;
				(serviceReport.GetComponentByName("remainingTexBox") as Stimulsoft.Report.Components.StiText).Text = remainingTextBox.Text;

				serviceReport.Render(true);
				BillServicePrintForm.serviceStiViewerControl.Report = serviceReport;
				BillServicePrintForm.ShowDialog();
			}
			else
			{
				return;
			}

		}
		#endregion /ServiceInvoiceButton_Click

		#region ListServiceDataGridView_RowsAdded
		private void ListServiceDataGridView_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
		{
			AddRowRevice(e);
		}
		#endregion /ListServiceDataGridView_RowsAdded

		#region SumPriceTextBox_TextChanged
		private void SumPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{
			SumPirice = int.Parse(sumPriceTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
			remainingTextBox.Text = sumPriceTextBox.Text;
		}
		#endregion /SumPriceTextBox_TextChanged

		#region AmountPaymentTextBox_TextChanged
		private void AmountPaymentTextBox_TextChanged(object sender, System.EventArgs e)
		{
			RemainingAmount = SumPirice - AmountPayment;

			remainingTextBox.Text = $"{RemainingAmount:#,0} تومان";
		}
		#endregion /AmountPaymentTextBox_TextChanged

		#region CashPaymentTextBox_Enter
		private void CashPaymentTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			if (cachPaymentRadioButton.Checked == true || cachAndPosPaymentRadioButton.Checked == true)
			{
				cashPaymentTextBox.ReadOnly = false;
				if (string.IsNullOrWhiteSpace(cashPaymentTextBox.Text))
				{
					Price = null;
					cashPaymentTextBox.Text = "0 تومان";
					cashPaymentTextBox.Select(0, 1);

					cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				}
				else if (cashPaymentTextBox.Text.Contains("تومان"))
				{
					return;
				}
			}
			else
			{
				cashPaymentTextBox.ReadOnly = true;
				return;
			}
		}
		#endregion /CashPaymentTextBox_Enter

		#region CashPaymentTextBox_KeyPress
		private void CashPaymentTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /CashPaymentTextBox_KeyPress

		#region CashPaymentTextBox_Leave
		private void CashPaymentTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cashPaymentTextBox.Text))
			{
				cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else if (string.Compare(cashPaymentTextBox.Text, "0 تومان") == 0)
			{
				cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				cashPaymentTextBox.Clear();
				return;
			}
			else if (string.Compare(cashPaymentTextBox.Text, " تومان") == 0 || string.Compare(cashPaymentTextBox.Text, "تومان") == 0 || string.Compare(cashPaymentTextBox.Text, "توما") == 0 || string.Compare(cashPaymentTextBox.Text, "توم") == 0 || string.Compare(cashPaymentTextBox.Text, "تو") == 0 || string.Compare(cashPaymentTextBox.Text, "ت") == 0)
			{
				cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				cashPaymentTextBox.Clear();
				Price = null;
				return;
			}
			else
			{
				cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				Price = int.Parse(cashPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				cashPaymentTextBox.Text = $"{Price:#,0} تومان";
			}
		}
		#endregion /CashPaymentTextBox_Leave

		#region CashPaymentTextBox_TextChange
		private void CashPaymentTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(cashPaymentTextBox.Text) || string.Compare(cashPaymentTextBox.Text, "0 تومان") == 0 || string.Compare(cashPaymentTextBox.Text, " تومان") == 0 || string.Compare(cashPaymentTextBox.Text, "تومان") == 0 || string.Compare(cashPaymentTextBox.Text, "توما") == 0 || string.Compare(cashPaymentTextBox.Text, "توم") == 0 || string.Compare(cashPaymentTextBox.Text, "تو") == 0 || string.Compare(cashPaymentTextBox.Text, "ت") == 0)
			{
				CashPaymentAmount = 0;
				AmountPayment = CashPaymentAmount + PosePaymentAmount;
				amountPaymentTextBox.Text = $"{AmountPayment: #,0} تومان";
				return;
			}
			else
			{
				CashPaymentAmount = int.Parse(cashPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				if (PosePaymentAmount == 0 || PosePaymentAmount == null)
				{
					AmountPayment = CashPaymentAmount;
					amountPaymentTextBox.Text = $"{CashPaymentAmount: #,0} تومان";
				}
				else
				{
					AmountPayment = CashPaymentAmount + PosePaymentAmount;
					amountPaymentTextBox.Text = $"{AmountPayment: #,0} تومان";
				}
			}
		}

		#endregion /CashPaymentTextBox_TextChange

		#region PosPaymentTextBox_Enter
		private void PosPaymentTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			if (posPaymentRadioButton.Checked == true || cachAndPosPaymentRadioButton.Checked == true)
			{
				posPaymentTextBox.ReadOnly = false;
				if (string.IsNullOrWhiteSpace(posPaymentTextBox.Text))
				{
					Price = null;
					posPaymentTextBox.Text = "0 تومان";
					posPaymentTextBox.Select(0, 1);
					posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				}
				else if (posPaymentTextBox.Text.Contains("تومان"))
				{
					return;
				}
			}
			else
			{
				posPaymentTextBox.ReadOnly = true;
				return;
			}
		}
		#endregion /PosPaymentTextBox_Enter

		#region PosPaymentTextBox_KeyPress
		private void PosPaymentTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /PosPaymentTextBox_KeyPress

		#region PosPaymentTextBox_Leave
		private void PosPaymentTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(posPaymentTextBox.Text))
			{
				posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				return;
			}
			else if (string.Compare(posPaymentTextBox.Text, "0 تومان") == 0)
			{
				posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				posPaymentTextBox.Clear();
				return;
			}
			else if (string.Compare(posPaymentTextBox.Text, " تومان") == 0 || string.Compare(posPaymentTextBox.Text, "تومان") == 0 || string.Compare(posPaymentTextBox.Text, "توما") == 0 || string.Compare(posPaymentTextBox.Text, "توم") == 0 || string.Compare(posPaymentTextBox.Text, "تو") == 0 || string.Compare(posPaymentTextBox.Text, "ت") == 0)
			{
				posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				posPaymentTextBox.Clear();
				return;
			}
			else
			{
				posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				Price = int.Parse(posPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				posPaymentTextBox.Text = $"{Price:#,0} تومان";
			}
		}
		#endregion /PosPaymentTextBox_Leave

		#region PosPaymentTextBox_TextChange
		private void PosPaymentTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(posPaymentTextBox.Text) || string.Compare(posPaymentTextBox.Text, "0 تومان") == 0 || string.Compare(posPaymentTextBox.Text, " تومان") == 0 || string.Compare(posPaymentTextBox.Text, "تومان") == 0 || string.Compare(posPaymentTextBox.Text, "توما") == 0 || string.Compare(posPaymentTextBox.Text, "توم") == 0 || string.Compare(posPaymentTextBox.Text, "تو") == 0 || string.Compare(posPaymentTextBox.Text, "ت") == 0)
			{
				PosePaymentAmount = 0;
				AmountPayment = CashPaymentAmount + PosePaymentAmount;
				amountPaymentTextBox.Text = $"{AmountPayment: #,0} تومان";

				return;
			}
			else
			{
				PosePaymentAmount = int.Parse(posPaymentTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				if (CashPaymentAmount == 0 || CashPaymentAmount == null)
				{
					AmountPayment = PosePaymentAmount;
					amountPaymentTextBox.Text = $"{PosePaymentAmount: #,0} تومان";
				}
				else
				{
					AmountPayment = CashPaymentAmount + PosePaymentAmount;
					amountPaymentTextBox.Text = $"{AmountPayment: #,0} تومان";
				}
			}
		}
		#endregion /PosPaymentTextBox_TextChange

		#region CachPaymentRadioButton_CheckedChanged
		private void CachPaymentRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			cashPaymentTextBox.Clear();
			posPaymentTextBox.Clear();

			CashPaymentAmount = 0;
			PosePaymentAmount = 0;
			AmountPayment = 0;

			amountPaymentTextBox.Text = "0 تومان";
		}
		#endregion /CachPaymentRadioButton_CheckedChanged

		#region CachPaymentLabel_Click
		private void CachPaymentLabel_Click(object sender, System.EventArgs e)
		{
			cachPaymentRadioButton.Checked = true;
		}
		#endregion /CachPaymentLabel_Click

		#region PosPaymentRadioButton_CheckedChanged
		private void PosPaymentRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			cashPaymentTextBox.Clear();
			posPaymentTextBox.Clear();

			CashPaymentAmount = 0;
			PosePaymentAmount = 0;
			AmountPayment = 0;

			amountPaymentTextBox.Text = "0 تومان";
		}
		#endregion /PosPaymentRadioButton_CheckedChanged

		#region PosPaymentLabel_Click
		private void PosPaymentLabel_Click(object sender, System.EventArgs e)
		{
			posPaymentRadioButton.Checked = true;
		}
		#endregion /PosPaymentLabel_Click

		#region CachAndPosPaymentRadioButton_CheckedChanged
		private void CachAndPosPaymentRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			cashPaymentTextBox.Clear();
			posPaymentTextBox.Clear();

			CashPaymentAmount = 0;
			PosePaymentAmount = 0;
			AmountPayment = 0;

			amountPaymentTextBox.Text = "0 تومان";
		}
		#endregion /CachAndPosPaymentRadioButton_CheckedChanged

		#region CachAndPosPaymentLabel_Click
		private void CachAndPosPaymentLabel_Click(object sender, System.EventArgs e)
		{
			cachAndPosPaymentRadioButton.Checked = true;
		}
		#endregion /CachAndPosPaymentLabel_Click

		#region DebtorRadioButton_CheckedChanged
		private void DebtorRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			cashPaymentTextBox.Clear();
			posPaymentTextBox.Clear();

			CashPaymentAmount = 0;
			PosePaymentAmount = 0;
			AmountPayment = 0;

			amountPaymentTextBox.Text = "0 تومان";
		}
		#endregion /DebtorRadioButton_CheckedChanged

		#region DebtorLabel_Click
		private void DebtorLabel_Click(object sender, System.EventArgs e)
		{
			debtorRadioButton.Checked = true;
		}
		#endregion /DebtorLabel_Click

		#region EditServiceToolStripMenuItem_Click
		private void EditServiceToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			EditService();
		}
		#endregion /EditServiceToolStripMenuItem_Click

		//----------End of code!----------

		#region Function

		#region AddService
		private void AddService(Models.Service service)
		{
			int servicePice = int.Parse(service.Service_Price.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
			int? price = service.Service_Number * servicePice;

			string sumPrice = $"{price:#,0} تومان";

			if (string.IsNullOrEmpty(service.Description))
			{
				service.Description = "توضیحات ندارد";
			}

			listServiceDataGridView.Rows.Add(service.Service_Name, service.Description, service.Service_Price, service.Service_Number, sumPrice);

			ContinueRegisterService();



		}
		#endregion /AddService

		#region AddRowRevice
		private void AddRowRevice(System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
		{
			string value;
			int newPrice;
			int totalSumPrice = 0;
			if (e.RowIndex != -1)
			{
				if (listServiceDataGridView.RowCount >= 1)
				{
					newServiceButton.Enabled = true;
					showReportServiceButton.Enabled = true;
					editServiceToolStripMenuItem.Enabled = true;
					saveAllServiceButton.Enabled = true;
					reductionServiceButton.Enabled = true;
					for (int i = 0; i < listServiceDataGridView.Rows.Count; i++)
					{
						value = listServiceDataGridView.Rows[i].Cells[4].Value.ToString().Replace("تومان", string.Empty).Trim();
						newPrice = int.Parse(value.Replace(",", string.Empty).Trim());
						totalSumPrice += newPrice;
					}
					value =
						$"{totalSumPrice:#,0} تومان";
					sumPriceTextBox.Text = value;
				}
				else
				{
					return;
				}
			}
			else
			{
				return;
			}
		}
		#endregion /AddRowRevice

		#region ContinueRegisterService
		/// <summary>
		/// برای ادامه ثبت سرویس این تابع اطلاعات سرویس 
		/// قبلی را حذف و منتظر دریافت اطلاعات جدید میگردد.
		/// </summary>
		private void ContinueRegisterService()
		{
			Service.Service_Name = null;
			Service.Service_Price = null;
			Service.Service_Number = null;
			Service.Description = null;

			serviceNameComboBox.StartIndex = 0;
			servicePriceTextBox.Clear();
			servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			serviceNumberTextBox.Clear();
			descriptionTextBox.Clear();
		}
		#endregion ContinueRegisterService

		#region EditService
		private void EditService()
		{
			if (listServiceDataGridView.Rows.Count >= 1)
			{
				addServiceButton.Text = "ویرایش سرویس";

				serviceNameComboBox.SelectedIndex = serviceNameComboBox.FindString(listServiceDataGridView.CurrentRow.Cells[0].Value.ToString());
				descriptionTextBox.Text = listServiceDataGridView.CurrentRow.Cells[1].Value.ToString();
				servicePriceTextBox.Text = listServiceDataGridView.CurrentRow.Cells[2].Value.ToString();
				serviceNumberTextBox.Text = listServiceDataGridView.CurrentRow.Cells[3].Value.ToString();
			}
		}
		#endregion

		#region InputValidation
		private bool InputValidation(Models.Service service)
		{
			string errorMessage = null;

			if (string.IsNullOrEmpty(service.Client_Name))
			{
				errorMessage = "لطفا نام مشتری را وارد نمایید.";
			}
			if (string.IsNullOrEmpty(service.Repairman_Name))
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += "لطفا نام تعمیرکار را وارد نمایید.";
			}
			if (listServiceDataGridView.Rows.Count <= 0)
			{
				if (!string.IsNullOrEmpty(errorMessage))
				{
					errorMessage +=
						System.Environment.NewLine;
				}
				errorMessage += "حداقل یک سرویس ثبت نمایید.";
			}

			if (!string.IsNullOrEmpty(errorMessage))
			{
				if (string.IsNullOrEmpty(service.Client_Name))
				{
					clientNameTextBox.Focus();
				}
				else if (string.IsNullOrEmpty(service.Repairman_Name))
				{
					repairmanNameTextBox.Focus();
				}
				else if (listServiceDataGridView.Rows.Count <= 0)
				{
					serviceNameComboBox.Focus();
				}

				Mbb.Windows.Forms.MessageBox.Show
					(text: errorMessage, caption: "خطای ورودی", icon: Mbb.Windows.Forms.MessageBoxIcon.Error, button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				return false;
			}
			else
			{
				return true;
			}
		}
		#endregion /InputValidation

		#region LoadService
		private void LoadService()
		{
			serviceNameComboBox.Items.Add("...انتخاب سرویس");
			serviceNameComboBox.StartIndex = 0;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					 new Models.DataBaseContext();

				System.Collections.Generic.List<Models.TypesService> listTypesService = new System.Collections.Generic.List<Models.TypesService>();

				listTypesService =
					dataBaseContext.TypesServices
					.OrderBy(current => current.Id)
					.ToList();


				for (int i = 0; i < listTypesService.Count; i++)
				{
					serviceNameComboBox.Items.Add(listTypesService.ElementAt(i));
					serviceNameComboBox.ValueMember = "Id";
					serviceNameComboBox.DisplayMember = "Service_Name";
				}

				//serviceNameComboBox.DataSource = listTypesService;

				//serviceNameComboBox.ValueMember = "Id";
				//serviceNameComboBox.DisplayMember = "Service_Name";
			}
			catch (System.Exception ex)
			{

				Infrastructure.Utility.ExceptionShow(ex);
			}
		}
		#endregion /LoadService

		#region NewService
		private void NewService()
		{
			Service = null;

			clientNameTextBox.Clear();
			serviceNameComboBox.StartIndex = 0;
			serviceNumberTextBox.Clear();
			registerDateTextBox.Text =
				$"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} - { Infrastructure.Utility.ShowTime()}";
			repairmanNameTextBox.Clear();
			descriptionTextBox.Clear();

			cashPaymentTextBox.Clear();
			posPaymentTextBox.Clear();

			AmountPayment = null;
			CashPaymentAmount = null;
			Percent = null;
			Price = null;
			PosePaymentAmount = null;
			RemainingAmount = null;
			SumPirice = null;

			cachAndPosPaymentRadioButton.Checked = false;
			posPaymentRadioButton.Checked = false;
			cachAndPosPaymentRadioButton.Checked = false;
			debtorRadioButton.Checked = false;

			sumPriceTextBox.Text = "0 تومان";
			amountPaymentTextBox.Text = "0 تومان";
			remainingTextBox.Text = "0 تومان";
		}
		#endregion

		#region ReductionService
		private void ReductionService()
		{
			if (listServiceDataGridView.Rows.Count >= 1)
			{
				int value = int.Parse(listServiceDataGridView.CurrentRow.Cells[3].Value.ToString());

				if (value <= 1)
				{
					#region Validate
					string amountPayable =
									this.sumPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
					string WarePrice =
						listServiceDataGridView.CurrentRow.Cells[2].Value.ToString().Replace("تومان", string.Empty).Trim();

					int itemTotalPrice =
						int.Parse(amountPayable.Replace(",", string.Empty).Trim());
					int itemPrice =
							int.Parse(WarePrice.Replace(",", string.Empty).Trim());

					itemTotalPrice -= itemPrice;
					value--;
					listServiceDataGridView.CurrentRow.Cells[3].Value = value;

					#region ===========================================================================          EventLog          ===========================================================================
					EventLog.Username = Inventory.Program.UserAuthentication.Username;
					EventLog.Full_Name = $"{Inventory.Program.UserAuthentication.Full_Name}";
					EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
					EventLog.Description = $"سفارش {listServiceDataGridView.CurrentRow.Cells[1].Value} حذف گردید!";

					Infrastructure.Utility.EventLog(EventLog);
					#endregion /===========================================================================          EventLog          ===========================================================================

					int SumPriceItem =
							itemPrice * value;
					WarePrice =
						$"{SumPriceItem:#,0} تومان";

					listServiceDataGridView.CurrentRow.Cells[2].Value = WarePrice;

					if (itemTotalPrice == 0)
					{
						this.sumPriceTextBox.Text =
							"0 تومان";
					}
					else
					{
						amountPayable =
							$"{itemTotalPrice:#,0} تومان";
						this.sumPriceTextBox.Text = amountPayable;
					}
					#endregion /Validate

					foreach (System.Windows.Forms.DataGridViewRow row in this.listServiceDataGridView.SelectedRows)
					{
						listServiceDataGridView.Rows.RemoveAt(row.Index);

						if (listServiceDataGridView.Rows.Count == 0)
						{
							reductionServiceButton.Enabled = false;
							newServiceButton.Enabled = false;
							showReportServiceButton.Enabled = false;
							editServiceToolStripMenuItem.Enabled = false;
							saveAllServiceButton.Enabled = false;
							reductionServiceButton.Enabled = false;
							return;
						}
					}
					return;
				}
				else
				{
					string amountPayable =
						this.sumPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
					string WarePrice =
						listServiceDataGridView.CurrentRow.Cells[2].Value.ToString().Replace("تومان", string.Empty).Trim();

					int itemTotalPrice =
						int.Parse(amountPayable.Replace(",", string.Empty).Trim());
					int itemPrice =
							int.Parse(WarePrice.Replace(",", string.Empty).Trim());

					itemTotalPrice -= itemPrice;
					value--;
					listServiceDataGridView.CurrentRow.Cells[3].Value = value;

					#region ===========================================================================          EventLog          ===========================================================================
					EventLog.Username = Inventory.Program.UserAuthentication.Username;
					EventLog.Full_Name = $"{Inventory.Program.UserAuthentication.Full_Name}";
					EventLog.Event_Date = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
					EventLog.Event_Time = $"{Infrastructure.Utility.ShowTime()}";
					EventLog.Description = $"کاهش سرویس {listServiceDataGridView.CurrentRow.Cells[1].Value}";

					Infrastructure.Utility.EventLog(EventLog);
					#endregion /===========================================================================          EventLog          ===========================================================================

					int SumPriceItem =
							itemPrice * value;
					WarePrice =
						$"{SumPriceItem:#,0} تومان";

					listServiceDataGridView.CurrentRow.Cells[4].Value = WarePrice;

					if (itemTotalPrice == 0)
					{
						this.sumPriceTextBox.Text =
							"0 تومان";
					}
					else
					{
						amountPayable =
							$"{itemTotalPrice:#,0} تومان";
						this.sumPriceTextBox.Text = amountPayable;
					}
					return;
				}
			}

		}
		#endregion /ReductionService

		#region SetServicePrice
		/// <summary>
		/// .با دریافت نام سرویس قیمت آن را به نمایش در می آورد
		/// </summary>
		/// <param name="serviceName"></param>
		/// <returns></returns>
		private void SetServicePrice()
		{
			if (serviceNameComboBox.SelectedIndex <= 0)
			{
				Mbb.Windows.Forms.MessageBox.Show
					(text: "لطفا یکی از سرویس های موجود را انتخاب کنید",
					caption: "تصحیح انتخاب",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				Service.Service_Name = null;
				Service.Service_Price = null;
				servicePriceTextBox.Clear();
				servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				return;
			}
			else
			{
				Models.TypesService typesService = serviceNameComboBox.SelectedItem as Models.TypesService;

				if (typesService != null)
				{

					Service.Service_Name = typesService.Service_Name;
					Service.Service_Price = typesService.Service_Price;
					servicePriceTextBox.Text = typesService.Service_Price;
					servicePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				}
			}
		}












		#endregion /SetServicePrice

		#endregion /Function
	}
}

using System.Data.Entity;
using System.Linq;

namespace Warehouse
{
	public partial class InvoiceAndCommodityForm : Infrastructure.BaseForm
	{
		public string CommodityImage { get; set; }
		public string CommodityName { get; set; }
		public string CommodityPrice { get; set; }
		public string CommodityUnit { get; set; }
		public string NumberCrumbs { get; set; }
		public string Quantity { get; set; }
		public string SellerType { get; set; }
		public string Username { get; private set; }
		public string FullName { get; private set; }
		public string EventDate { get; private set; }
		public string EventTime { get; private set; }
		public string EventText { get; private set; }

		public InvoiceAndCommodityForm()
		{
			InitializeComponent();
			this.Opacity = 0.0;
		}

		//-----Begining of code!

		#region InvoiceAndCommodityForm_Load
		private void InvoiceAndCommodityForm_Load(object sender, System.EventArgs e)
		{

		}
		#endregion /InvoiceAndCommodityForm_Load

		#region CommodityButton_Click
		private void CommodityButton_Click(object sender, System.EventArgs e)
		{
			Transition2.HideSync(invoicePanel);
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(commodityPanel);
			Transition1.ShowSync(commodityPanel);
		}
		#endregion /CommodityButton_Click

		#region InvoiceButton_Click
		private void InvoiceButton_Click(object sender, System.EventArgs e)
		{
			Transition2.HideSync(commodityPanel);
			mainPanel.Controls.Clear();
			mainPanel.Controls.Add(invoicePanel);
			Transition1.ShowSync(invoicePanel);
		}
		#endregion /InvoiceButton_Click

		#region SelectPictureLinkLabel_LinkClicked
		private void SelectPictureLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPG (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load user picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				CommodityImage = openFileDialog.FileName;
				commodityImagePictureBox.Image =
				System.Drawing.Image.FromFile(CommodityImage);
			}
			if (CommodityImage != string.Empty)
			{
				deleteImageButton.Visible = true;
			}
			else
			{
				deleteImageButton.Visible = false;
			}
		}
		#endregion /SelectPictureLinkLabel_LinkClicked

		#region DeleteImageButton_Click
		private void DeleteImageButton_Click(object sender, System.EventArgs e)
		{
			commodityImagePictureBox.Image = Inventory.Properties.Resources.box_512px;
			CommodityImage = string.Empty;
			deleteImageButton.Visible = false;
		}
		#endregion /DeleteImageButton_Click

		#region CommodityNameTextBox_Enter
		private void CommodityNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
		#endregion /CommodityNameTextBox_Enter

		#region CommodityNameTextBox_KeyPress
		private void CommodityNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /CommodityNameTextBox_KeyPress

		#region CommodityNameTextBox_Leave
		private void CommodityNameTextBox_Leave(object sender, System.EventArgs e)
		{

		}
		#endregion /CommodityNameTextBox_Leave

		#region CommodityNameTextBox_TextChanged
		private void CommodityNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(commodityNameTextBox.Text))
			{
				CommodityName = string.Empty;
			}
			else
			{
				CommodityName = commodityNameTextBox.Text;
			}
		}
		#endregion /CommodityNameTextBox_TextChanged

		#region CommodityPriceTextBox_Enter
		private void CommodityPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			commodityPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

			commodityPriceTextBox.HideSelection = true;

			if (string.IsNullOrWhiteSpace(commodityPriceTextBox.Text) == false)
			{
				commodityPriceTextBox.SelectionStart = 0;
				CommodityPrice = commodityPriceTextBox.Text.Replace("تومان", string.Empty).Trim();

				commodityPriceTextBox.SelectionLength = CommodityPrice.Length;
			}
		}
		#endregion /CommodityPriceTextBox_Enter

		#region CommodityPriceTextBox_KeyPress
		private void CommodityPriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /CommodityPriceTextBox_KeyPress

		#region CommodityPriceTextBox_Leave
		private void CommodityPriceTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(commodityPriceTextBox.Text))
			{
				commodityPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				CommodityPrice = string.Empty;
			}
			else 
			{

				commodityPriceTextBox.HideSelection = false;
				commodityPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
				CommodityPrice = commodityPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				long commodityPrice = int.Parse(CommodityPrice.Replace(",", string.Empty).Trim());
				commodityPriceTextBox.Text = $"{commodityPrice:#,0} تومان";
				CommodityPrice = commodityPriceTextBox.Text;
			}
		}
		#endregion /CommodityPriceTextBox_Leave

		#region CommodityPriceTextBox_TextChanged
		private void CommodityPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{
		}
		#endregion /CommodityPriceTextBox_TextChanged

		#region CommodityQuantityTextBox_Enter
		private void CommodityQuantityTextBox_Enter(object sender, System.EventArgs e)
		{

		}
		#endregion /CommodityQuantityTextBox_Enter

		#region CommodityQuantityTextBox_KeyPress
		private void CommodityQuantityTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}
		#endregion /CommodityQuantityTextBox_KeyPress

		#region CommodityQuantityTextBox_Leave
		private void CommodityQuantityTextBox_Leave(object sender, System.EventArgs e)
		{

		}
		#endregion /CommodityQuantityTextBox_Leave

		#region MyRegion
		private void CommodityQuantityTextBox_TextChanged(object sender, System.EventArgs e)
		{

		} 
		#endregion

		#region MyRegion
		private void CommodityUnitComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}
		#endregion

		#region CommodityRetailerRadioButton_CheckedChanged
		private void CommodityRetailerRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			if (commodityRetailerRadioButton.Checked == true)
			{
				retailerPanel.Visible = true;
				SellerType = string.Empty;
				SellerType = commodityRetailerLabel.Text;
				Label2.Text = $"عدد ({commodityNameTextBox.Text}) در هر ({commodityUnitComboBox.SelectedItem}) موجود است."; 
			}
		}
		#endregion /CommodityRetailerRadioButton_CheckedChanged

		#region CommodityRetailerLabel_Click
		private void CommodityRetailerLabel_Click(object sender, System.EventArgs e)
		{
			commodityRetailerRadioButton.Checked = true;
		}
		#endregion /CommodityRetailerLabel_Click

		#region CommodityWholesalerRadioButtonn_CheckedChanged
		private void CommodityWholesalerRadioButtonn_CheckedChanged(object sender, System.EventArgs e)
		{
			if (commodityWholesalerRadioButton.Checked == true)
			{
				retailerPanel.Visible = false;
				SellerType = string.Empty;
				SellerType = commodityWholesalerLabel.Text; 
			}
		}
		#endregion /CommodityWholesalerRadioButtonn_CheckedChanged

		#region CommodityWholesalerLabel_Click
		private void CommodityWholesalerLabel_Click(object sender, System.EventArgs e)
		{
			commodityWholesalerRadioButton.Checked = true;
		}
		#endregion /CommodityWholesalerLabel_Click

		#region CommodityNumberCrumbsTextBox_Enter
		private void CommodityNumberCrumbsTextBox_Enter(object sender, System.EventArgs e)
		{

		}
		#endregion /CommodityNumberCrumbsTextBox_Enter

		#region CommodityNumberCrumbsTextBox_KeyPress
		private void CommodityNumberCrumbsTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}
		#endregion /CommodityNumberCrumbsTextBox_KeyPress

		#region CommodityNumberCrumbsTextBox_Leave
		private void CommodityNumberCrumbsTextBox_Leave(object sender, System.EventArgs e)
		{

		}
		#endregion /CommodityNumberCrumbsTextBox_Leave

		#region CommodityNumberCrumbsTextBox_TextChanged
		private void CommodityNumberCrumbsTextBox_TextChanged(object sender, System.EventArgs e)
		{

		}
		#endregion /CommodityNumberCrumbsTextBox_TextChanged

		#region DeleteCommodityButton_Click
		private void DeleteCommodityButton_Click(object sender, System.EventArgs e)
		{
			if (commodityDataGridView.Rows.Count >= 1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"{commodityDataGridView.CurrentRow.Cells[0].Value} حذف گردد؟!",
					caption: "هشدار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف مشترک
				{
					string commodityName = commodityDataGridView.CurrentRow.Cells[0].Value.ToString();

					using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
					{
						Models.Commodity commodity =
							dataBaseContext.Commodities
							.Where(current => string.Compare(current.Commodity_Name, commodityName) == 0)
							.FirstOrDefault();
						if (commodity != null)
						{
							var entry = dataBaseContext.Entry(commodity);

							if (entry.State == EntityState.Detached)
							{
								dataBaseContext.Commodities.Attach(commodity);
							}
						}

						#region EventLog
						Username = Inventory.Program.AuthenticatedUser.Username;
						FullName = $"{Inventory.Program.AuthenticatedUser.First_Name} {Inventory.Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventText = $"{commodity} حذف گردید.";

						Infrastructure.Utility.EventLog(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventText);
						#endregion /EventLog

						dataBaseContext.Commodities.Remove(commodity);
						dataBaseContext.SaveChanges();
					}

					if (commodityDataGridView.Rows.Count == 0)
					{
						deleteCommodityButton.Enabled = false;
						allClearCommodityButton.Enabled = false;
					}

					Infrastructure.Utility.WindowsNotification
						(message: "کالای مورد نظر حذف گردید!",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				}
			}
		}
		#endregion /DeleteCommodityButton_Click

		#region AllClearButton_Click
		private void AllClearButton_Click(object sender, System.EventArgs e)
		{
			if (commodityDataGridView.Rows.Count >= 1)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show
					(text: $"آیا همه اطلاعات کالاها حذف گردد؟!",
					caption: "هشدار",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Warning,
					button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)//----جهت حذف کامل اطلاعات مربوط به نوشیدنی
				{
					System.Collections.Generic.List<Models.Commodity> commodity = new System.Collections.Generic.List<Models.Commodity>();

					using (Models.DataBaseContext dataBaseContext = new Models.DataBaseContext())
					{
						commodity =
						   dataBaseContext.Commodities
						   .OrderBy(current => current.Commodity_Name)
						   .ToList();

						if (commodity != null)
						{
							foreach (var item in commodity) //---توسط این کد با پیمایش در لیست نوشیدنی یکی یکی ایتمهای موجود در لیست نوشیدنی را حذف میکند.
							{
								dataBaseContext.Commodities.Remove(item);
								dataBaseContext.SaveChanges();
							}
						}
						else if (commodity == null)
						{
							return;
						}

						#region EventLog
						Username = Inventory.Program.AuthenticatedUser.Username;
						FullName = $"{Inventory.Program.AuthenticatedUser.First_Name} {Inventory.Program.AuthenticatedUser.Last_Name}";
						EventDate = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)}";
						EventTime = $"{Infrastructure.Utility.ShowTime()}";
						EventText = $"حذف کامل اطلاعات کالاها.";

						Infrastructure.Utility.EventLog(username: Username,
							fullName: FullName,
							eventDate: EventDate,
							eventTime: EventTime,
							eventTitle: EventText);
						#endregion /EventLog

						deleteCommodityButton.Enabled = false;
						allClearCommodityButton.Enabled = false;
					}

					Infrastructure.Utility.WindowsNotification
						(message: "کلیه اطلاعات کالا حذف گردید!",
						caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
				}
			}
		}
		#endregion /AllClearButton_Click

		#region CancelButton_Click
		private void CancelCommodityButton_Click(object sender, System.EventArgs e)
		{
			if (commodityImagePictureBox.Image != Inventory.Properties.Resources.box_512px || string.IsNullOrWhiteSpace(commodityNameTextBox.Text) != true || string.IsNullOrWhiteSpace(commodityPriceTextBox.Text) != true || commodityUnitComboBox.SelectedIndex > 0 || string.IsNullOrWhiteSpace(commodityQuantityTextBox.Text) != true || string.IsNullOrWhiteSpace(commodityNumberCrumbsTextBox.Text) != true)
			{
				System.Windows.Forms.DialogResult dialogResult =
					Mbb.Windows.Forms.MessageBox.Show(text: "آیا اطلاعات ورودی حذف گردد؟", caption: "حالت اولیه", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					ResetAll();
				}
			}
		}
		#endregion /CancelButton_Click

		#region SaveEditICommodityButton_Click
		private void SaveEditICommodityButton_Click(object sender, System.EventArgs e)
		{
			if (string.Compare(saveEditICommodityButton.Text, "ثبت کالا") == 0)
			{
				if (commodityRetailerRadioButton.Checked == true)//-----خرده فروشی فعال است
				{

				}
				else if (commodityWholesalerRadioButton.Checked == true)//-----عمده فروشی فعال است
				{

				}
			}
			else if (string.Compare(saveEditICommodityButton.Text, "ویرایش کالا") == 0)
			{

			}
		}
		#endregion /SaveEditICommodityButton_Click

		//-----End of code!

		#region Founction
		#region ResetAll
		private void ResetAll()
		{
			commodityImagePictureBox.Image = Inventory.Properties.Resources.box_512px;
			commodityNameTextBox.Clear();
			commodityPriceTextBox.Clear();
			commodityUnitComboBox.SelectedIndex = 0;
			commodityQuantityTextBox.Clear();
			commodityNumberCrumbsTextBox.Clear();
			retailerPanel.Enabled = false;
			commodityRetailerRadioButton.Checked = false;
			commodityWholesalerRadioButton.Checked = true;
			Label2.Text = $"عدد({string.Empty}) در هر({string.Empty}) موجود است.";
			Label3.Text = $"مجموعا ({string.Empty}) عدد ({string.Empty}) موجود است.";

			CommodityImage = string.Empty;
			CommodityName = string.Empty;
			CommodityPrice = string.Empty;
			CommodityUnit = string.Empty;
			NumberCrumbs = string.Empty;
			Quantity = string.Empty;
			SellerType = string.Empty;
		}


		#endregion /ResetAll

		#endregion /Founction
	}
}

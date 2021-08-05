using System.Linq;

namespace Financial_Form
{
	public partial class SafeBoxForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties
		private Models.CapitalFund _capitalFund;
		public Models.CapitalFund CapitalFund
		{
			get
			{
				if (_capitalFund==null)
				{
					_capitalFund =
						new Models.CapitalFund();
				}
				return _capitalFund;
			}
			set
			{
				_capitalFund = value;
			}
		}

		public int? Amount { get; set; }
		public string Capital_Fund { get; set; }
		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public SafeBoxForm()
		{
			InitializeComponent();
		}

		//-----------------------------------------------------------------------------------------------     Events Controls

		#region SafeBoxForm_Load
		private void SafeBoxForm_Load(object sender, System.EventArgs e)
		{
			LoadingFund();
		}
		#endregion /SafeBoxForm_Load

		#region EntryFuneTextBox_Enter
		private void EntryFuneTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			entryFuneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

			entryFuneTextBox.Text = "0 تومان";

			entryFuneTextBox.Select(0, entryFuneTextBox.Text.Length - 6);

			if (string.IsNullOrWhiteSpace(entryFuneTextBox.Text))
			{
				CapitalFund.Capital_Fund = null;
				Amount = null;
			}
			else if (entryFuneTextBox.Text.Contains("تومان"))
			{
				return;
			}
		}
		#endregion /EntryFuneTextBox_Enter

		#region EntryFuneTextBox_KeyPress
		private void EntryFuneTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /EntryFuneTextBox_KeyPress

		#region EntryFuneTextBox_Leave
		private void EntryFuneTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(entryFuneTextBox.Text) ||
			   string.Compare(entryFuneTextBox.Text, "0 تومان") == 0 ||
			   string.Compare(entryFuneTextBox.Text, " تومان") == 0 ||
			   string.Compare(entryFuneTextBox.Text, "تومان") == 0 ||
			   string.Compare(entryFuneTextBox.Text, "توما") == 0 ||
			   string.Compare(entryFuneTextBox.Text, "توم") == 0 ||
			   string.Compare(entryFuneTextBox.Text, "تو") == 0 ||
			   string.Compare(entryFuneTextBox.Text, "ت") == 0)
			{
				acceptButton.Enabled = false;
				entryFuneTextBox.Text = "0 تومان";
				CapitalFund.Capital_Fund = null;
				Amount = null;
				return;
			}
			else
			{
				Amount = int.Parse(entryFuneTextBox.Text.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				entryFuneTextBox.Text = $"{Amount:#,0} تومان";
				Capital_Fund = $"{Amount:#,0} تومان";
			}
		}
		#endregion /EntryFuneTextBox_Leave

		#region EntryFuneTextBox_TextChange
		private void EntryFuneTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(entryFuneTextBox.Text) ||
				string.Compare(entryFuneTextBox.Text, "0 تومان") == 0 ||
				string.Compare(entryFuneTextBox.Text, " تومان") == 0 ||
				string.Compare(entryFuneTextBox.Text, "تومان") == 0 ||
				string.Compare(entryFuneTextBox.Text, "توما") == 0 ||
				string.Compare(entryFuneTextBox.Text, "توم") == 0 ||
				string.Compare(entryFuneTextBox.Text, "تو") == 0 ||
				string.Compare(entryFuneTextBox.Text, "ت") == 0)
			{
				acceptButton.Enabled = false;
				Capital_Fund = null;
				Amount = null;
				return;
			}
			else
			{
				acceptButton.Enabled = true;
			}
		}
		#endregion /EntryFuneTextBox_TextChange

		#region AcceptButton_Click
		private void AcceptButton_Click(object sender, System.EventArgs e)
		{
			if (SetInCapitalFund(Amount))
			{
				Infrastructure.Utility.WindowsNotification(message: "مبلغ واریز شد.", caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);
			}
			else
			{
				Infrastructure.Utility.WindowsNotification(message:$"{Inventory.Properties.Resources.Operation_Defect}", caption: Infrastructure.PopupNotificationForm.Caption.خطا);
			}
		}
		#endregion /AcceptButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Function

		#region LoadingFund
		private void LoadingFund()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.FirstOrDefault();

				funeLabel.Text = capitalFund.Capital_Fund;
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
		#endregion /LoadingFund

		#region SetInCapitalFund
		private bool SetInCapitalFund(int? _amount)
		{
			int? fund, sumAccount;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.FirstOrDefault();

				fund = int.Parse(capitalFund.Capital_Fund.Replace("تومان", string.Empty).Replace(",", string.Empty).Trim());
				

				sumAccount = fund + _amount;
				capitalFund.Capital_Fund = $"{sumAccount:#,0} تومان";
				dataBaseContext.SaveChanges();

				LoadingFund();
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
		#endregion /SetInCapitalFund

		#endregion /Function


	}
}

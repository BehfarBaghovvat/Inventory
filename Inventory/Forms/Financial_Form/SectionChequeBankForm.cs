namespace Financial_Form
{
	public partial class SectionChequeBankForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properties

		private Chequa_Bank.IssuanceChequaUC _issuanceChequaUC = new Chequa_Bank.IssuanceChequaUC();
		private Chequa_Bank.GetChequaUC _getChequaUC = new Chequa_Bank.GetChequaUC();
		private Chequa_Bank.ListChequasBankUC _listChequasBankUC = new Chequa_Bank.ListChequasBankUC();

		#endregion / Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public SectionChequeBankForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region IssuanceChequaButton_Click
		private void IssuanceChequaButton_Click(object sender, System.EventArgs e)
		{
			if (issuanceChequaButton.Checked)
			{
				return;
			}
			else
			{
				chequaPanel.Controls.Clear();
				chequaPanel.Controls.Remove(_getChequaUC);
				chequaPanel.Controls.Remove(_listChequasBankUC);
				chequaPanel.Controls.Add(_issuanceChequaUC);

				issuanceChequaButton.Checked = true;
				getChequaButton.Checked = false;
				listChequasBankButton.Checked = false;
			}
		}
		#endregion /IssuanceChequaButton_Click

		#region GetChequaButton_Click
		private void GetChequaButton_Click(object sender, System.EventArgs e)
		{
			if (getChequaButton.Checked)
			{
				return;
			}
			else
			{
				chequaPanel.Controls.Clear();
				chequaPanel.Controls.Remove(_issuanceChequaUC);
				chequaPanel.Controls.Remove(_listChequasBankUC);
				chequaPanel.Controls.Add(_getChequaUC);

				issuanceChequaButton.Checked = false;
				getChequaButton.Checked = true;
				listChequasBankButton.Checked = false;
			}
		}
		#endregion /GetChequaButton_Click

		#region ListChequasBankButton_Click
		private void ListChequasBankButton_Click(object sender, System.EventArgs e)
		{
			if (listChequasBankButton.Checked)
			{
				return;
			}
			else
			{
				chequaPanel.Controls.Clear();
				chequaPanel.Controls.Remove(_issuanceChequaUC);
				chequaPanel.Controls.Remove(_getChequaUC);
				chequaPanel.Controls.Add(_listChequasBankUC);

				issuanceChequaButton.Checked = false;
				getChequaButton.Checked = false;
				listChequasBankButton.Checked = true;
			}
		}
		#endregion /ListChequasBankButton_Click
	}
}

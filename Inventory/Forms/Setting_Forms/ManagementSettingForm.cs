namespace Setting_Forms
{
	public partial class ManagementSettingForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		private Manegment_Setting.UserSettingUC _userSettingUC = new Manegment_Setting.UserSettingUC();
		private Manegment_Setting.EventLogUC _eventLogUC = new Manegment_Setting.EventLogUC();
		private Manegment_Setting.LoginControlUC _loginControlUC = new Manegment_Setting.LoginControlUC();





		//-----------------------------------------------------------------------------------------------     Constracture

		public ManagementSettingForm()
		{
			InitializeComponent();
		}




		//-----------------------------------------------------------------------------------------------     Events Controls

		#region UserSettingButton_Click
		private void UserSettingButton_Click(object sender, System.EventArgs e)
		{
			controlPanel.Controls.Clear();
			controlPanel.Controls.Add(_userSettingUC);
			_userSettingUC.Dock = System.Windows.Forms.DockStyle.Fill;
		}
		#endregion /UserSettingButton_Click

		#region EventLogButton_Click
		private void EventLogButton_Click(object sender, System.EventArgs e)
		{
			controlPanel.Controls.Clear();
			controlPanel.Controls.Add(_eventLogUC);
			_eventLogUC.Dock = System.Windows.Forms.DockStyle.Fill;
		}
		#endregion /EventLogButton_Click

		#region CheckInCheckOutButton_Click
		private void CheckInCheckOutButton_Click(object sender, System.EventArgs e)
		{
			controlPanel.Controls.Clear();
			controlPanel.Controls.Add(_loginControlUC);
			_loginControlUC.Dock = System.Windows.Forms.DockStyle.Fill;
		}
		#endregion /CheckInCheckOutButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founcitons



		#endregion /Founcitons
	}
}

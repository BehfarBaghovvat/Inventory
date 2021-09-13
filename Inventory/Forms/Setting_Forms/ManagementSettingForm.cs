namespace Setting_Forms
{
	public partial class ManagementSettingForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers

		#region Properites

		private Manegment_Setting.UserSettingUC _userSettingUC = new Manegment_Setting.UserSettingUC();
		private Manegment_Setting.EventLogUC _eventLogUC = new Manegment_Setting.EventLogUC();
		private Manegment_Setting.LoginControlUC _loginControlUC = new Manegment_Setting.LoginControlUC(); 

		#endregion /Properties



		//-----------------------------------------------------------------------------------------------     Constracture

		public ManagementSettingForm()
		{
			InitializeComponent();
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region ManagementSettingForm_Load
		private void ManagementSettingForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /ManagementSettingForm_Load

		#region UserSettingButton_Click
		private void UserSettingButton_Click(object sender, System.EventArgs e)
		{
			controlPanel.Controls.Clear();
			controlPanel.Controls.Add(_userSettingUC);
		}
		#endregion /UserSettingButton_Click

		#region EventLogButton_Click
		private void EventLogButton_Click(object sender, System.EventArgs e)
		{
			controlPanel.Controls.Clear();
			controlPanel.Controls.Add(_eventLogUC);
		}
		#endregion /EventLogButton_Click

		#region CheckInCheckOutButton_Click
		private void CheckInCheckOutButton_Click(object sender, System.EventArgs e)
		{
			controlPanel.Controls.Clear();
			controlPanel.Controls.Add(_loginControlUC);
		}
		#endregion /CheckInCheckOutButton_Click



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Founcitons

		#region Initialize
		/// <summary>
		/// تنظیمات ورودی اولیه
		/// </summary>
		public void Initialize()
		{
			controlPanel.Controls.Clear();
		}
		#endregion Initialize

		#endregion /Founcitons
	}
}

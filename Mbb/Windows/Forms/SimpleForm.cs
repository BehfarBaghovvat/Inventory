namespace Mbb.Windows.Forms
{
	public partial class SimpleForm : Form
	{
		#region        "     Properties     "

		#region MyRegion
		private System.Drawing.Color _underlineTitle;

		public System.Drawing.Color UnderlineTitle
		{
			get { return _underlineTitle; }
			set 
			{ 
				_underlineTitle = value;
				
			}
		} 
		#endregion


		#endregion        /"     Properties     "


		public SimpleForm()
		{
			InitializeComponent();
		}
	}
}

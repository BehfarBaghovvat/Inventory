namespace Inventory_Forms
{
	public partial class BillBuyPrintForm : Infrastructure.EmptyForm
	{
		#region Properties

		#region Layer
		#endregion /Layer

		#endregion /Properties

		public BillBuyPrintForm()
		{
			InitializeComponent();
		}

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			closeFadeFormTimer.Start();
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizeButton_Click

		#region CloseFadeFormTimer_Tick
		private void CloseFadeFormTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.1;

			if (this.Opacity <= 0.0)
			{
				closeFadeFormTimer.Stop();
				this.Dispose();
			}
		}
		#endregion /CloseFadeFormTimer_Tick
	}
}

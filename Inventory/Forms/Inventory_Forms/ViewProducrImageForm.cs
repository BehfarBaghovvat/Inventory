namespace Inventory_Forms
{
	public partial class ViewProducrImageForm : Infrastructure.EmptyForm
	{
		//-----------------------------------------------------------------------------------------------     Fields, Properties, Layers




		//-----------------------------------------------------------------------------------------------     Constracture

		public ViewProducrImageForm(System.Drawing.Image _product_Image)
		{
			InitializeComponent();
			Initialize( _product_Image);
		}



		//-----------------------------------------------------------------------------------------------     Events Controls

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			productImagePictureBox.Image = null;
			closeFormTimer.Start();
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}

		#endregion /MinimizeButton_Click

		#region CloseFormTimer_Tick
		private void CloseFormTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.1;
			if (this.Opacity <= 0.0)
			{
				closeFormTimer.Stop();
				this.Close();
			}
		}
		#endregion /CloseFormTimer_Tick



		//-----------------------------------------------------------------------------------------------     Privat Methods

		#region Function

		#region Initialize
		private void Initialize(System.Drawing.Image _product_Image)
		{
			showGunaAnimateWindow.Interval = 200;
			showGunaAnimateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
			showGunaAnimateWindow.Start();
			productImagePictureBox.Image = _product_Image;
		}
		#endregion /Initialize

		#endregion Function
	}
}

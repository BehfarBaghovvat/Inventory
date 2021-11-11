namespace Infrastructure
{
	public partial class BaseForm : System.Windows.Forms.Form
	{
		#region Properties
		#region Layer
		
		#endregion /Layer

		public System.Drawing.Color CaptionColor
		{
			get
			{
				return caption.ForeColor;
			}
			set
			{
				caption.ForeColor = value;
			}
		}
		public System.Drawing.Color CaptionLineColor
		{
			get
			{
				return captionLine.BackColor;
			}
			set
			{
				captionLine.BackColor = value;
			}
		}
		public bool DragForm { get; set; }
		public System.Drawing.Color SideColorCaption 
		{
			get
			{
				return side.BackColor;
			}
			set
			{
				side.BackColor = value;
			}
		}
		public string CaptionForm
		{ 
			get
			{
				return caption.Text;
			}
			set
			{
				caption.Text = value;
			}
		}
		public System.Drawing.Color TopColor 
		{
			get
			{
				return topLayer.BackColor;
			}
			set
			{
				topLayer.BackColor = value;
			}

		}
		#endregion /Properties

		public BaseForm()
		{
			InitializeComponent();
		}

		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		//----------Beginning of the code!----------

		#region BaseForm_Load
		private void BaseForm_Load(object sender, System.EventArgs e)
		{
			
		}
		#endregion /BaseForm_Load

		#region Exit_Click
		private void Exit_Click(object sender, System.EventArgs e)
		{
			if (Mbb.Windows.Forms.MessageBox.Show(text: "از برنامه خارج می شوید؟", caption: "خروج", icon: Mbb.Windows.Forms.MessageBoxIcon.Question, button: Mbb.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
			{
				exitTimer.Start();
			}
			else
			{
				return;
			}
		}
		#endregion /Exit_Click

		#region Minimized_Click
		private void Minimized_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /Minimized_Click

		#region Top_MouseDown
		private void Top_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (DragForm)
			{
				ReleaseCapture();
				SendMessage(this.Handle, 0x112, 0xf012, 0);
			}
			else
			{
				return;
			}
		}
		#endregion /Top_MouseDown

		#region Caption_MouseDown
		private void Caption_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (DragForm)
			{
				ReleaseCapture();
				SendMessage(this.Handle, 0x112, 0xf012, 0);
			}
			else
			{
				return;
			}
		}

		#endregion

		#region ExitTimer_Tick
		private void ExitTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.01;

			if (this.Opacity <= 0.0)
			{
				exitTimer.Stop();
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /ExitTimer_Tick

		//------------------------------------------


	}
}

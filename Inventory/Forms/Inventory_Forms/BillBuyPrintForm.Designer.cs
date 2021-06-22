
namespace Inventory_Forms
{
	partial class BillBuyPrintForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillBuyPrintForm));
			this.topPanel = new Mbb.Windows.Forms.Panel();
			this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
			this.closeButton = new Guna.UI2.WinForms.Guna2Button();
			this.receiptStiViewerControl = new Stimulsoft.Report.Viewer.StiRibbonViewerControl();
			this.showFormAnimateWindow = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
			this.closeFadeFormTimer = new System.Windows.Forms.Timer(this.components);
			this.topPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.minimizeButton);
			this.topPanel.Controls.Add(this.closeButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(950, 30);
			this.topPanel.TabIndex = 1;
			// 
			// minimizeButton
			// 
			this.minimizeButton.Animated = true;
			this.minimizeButton.CheckedState.Parent = this.minimizeButton;
			this.minimizeButton.CustomImages.Parent = this.minimizeButton;
			this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.minimizeButton.FillColor = System.Drawing.Color.Transparent;
			this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.minimizeButton.ForeColor = System.Drawing.Color.White;
			this.minimizeButton.HoverState.Parent = this.minimizeButton;
			this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
			this.minimizeButton.ImageSize = new System.Drawing.Size(15, 15);
			this.minimizeButton.Location = new System.Drawing.Point(50, 0);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.ShadowDecoration.Parent = this.minimizeButton;
			this.minimizeButton.Size = new System.Drawing.Size(50, 30);
			this.minimizeButton.TabIndex = 1;
			this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Animated = true;
			this.closeButton.CheckedState.Parent = this.closeButton;
			this.closeButton.CustomImages.Parent = this.closeButton;
			this.closeButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.closeButton.HoverState.Parent = this.closeButton;
			this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
			this.closeButton.ImageSize = new System.Drawing.Size(10, 10);
			this.closeButton.Location = new System.Drawing.Point(0, 0);
			this.closeButton.Name = "closeButton";
			this.closeButton.PressedColor = System.Drawing.Color.White;
			this.closeButton.ShadowDecoration.Parent = this.closeButton;
			this.closeButton.Size = new System.Drawing.Size(50, 30);
			this.closeButton.TabIndex = 0;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// receiptStiViewerControl
			// 
			this.receiptStiViewerControl.AllowDrop = true;
			this.receiptStiViewerControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.receiptStiViewerControl.Location = new System.Drawing.Point(0, 30);
			this.receiptStiViewerControl.Name = "receiptStiViewerControl";
			this.receiptStiViewerControl.Report = null;
			this.receiptStiViewerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.receiptStiViewerControl.ShowZoom = true;
			this.receiptStiViewerControl.Size = new System.Drawing.Size(950, 730);
			this.receiptStiViewerControl.TabIndex = 2;
			// 
			// showFormAnimateWindow
			// 
			this.showFormAnimateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
			this.showFormAnimateWindow.Interval = 250;
			this.showFormAnimateWindow.TargetControl = this;
			// 
			// closeFadeFormTimer
			// 
			this.closeFadeFormTimer.Interval = 5;
			this.closeFadeFormTimer.Tick += new System.EventHandler(this.CloseFadeFormTimer_Tick);
			// 
			// BillBuyPrintForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(950, 760);
			this.Controls.Add(this.receiptStiViewerControl);
			this.Controls.Add(this.topPanel);
			this.MaximumSize = new System.Drawing.Size(950, 760);
			this.MinimumSize = new System.Drawing.Size(950, 726);
			this.Name = "BillBuyPrintForm";
			this.Text = "ReceiptForm";
			this.topPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Mbb.Windows.Forms.Panel topPanel;
		private Guna.UI2.WinForms.Guna2Button closeButton;
		private Guna.UI2.WinForms.Guna2Button minimizeButton;
		public Stimulsoft.Report.Viewer.StiRibbonViewerControl receiptStiViewerControl;
		public Guna.UI.WinForms.GunaAnimateWindow showFormAnimateWindow;
		private System.Windows.Forms.Timer closeFadeFormTimer;
	}
}
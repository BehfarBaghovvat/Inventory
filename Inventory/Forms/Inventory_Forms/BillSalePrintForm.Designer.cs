﻿
namespace Inventory_Forms
{
	partial class BillSaleReportForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillSaleReportForm));
			this.topPanel = new Mbb.Windows.Forms.Panel();
			this.billsaleStiRibbonViewerControl = new Stimulsoft.Report.Viewer.StiRibbonViewerControl();
			this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
			this.closeButton = new Guna.UI2.WinForms.Guna2Button();
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
			this.topPanel.TabIndex = 3;
			// 
			// billsaleStiRibbonViewerControl
			// 
			this.billsaleStiRibbonViewerControl.AllowDrop = true;
			this.billsaleStiRibbonViewerControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.billsaleStiRibbonViewerControl.Location = new System.Drawing.Point(0, 30);
			this.billsaleStiRibbonViewerControl.Name = "billsaleStiRibbonViewerControl";
			this.billsaleStiRibbonViewerControl.Report = null;
			this.billsaleStiRibbonViewerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.billsaleStiRibbonViewerControl.ShowZoom = true;
			this.billsaleStiRibbonViewerControl.Size = new System.Drawing.Size(950, 730);
			this.billsaleStiRibbonViewerControl.TabIndex = 4;
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
			// 
			// BillSaleReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(950, 760);
			this.Controls.Add(this.billsaleStiRibbonViewerControl);
			this.Controls.Add(this.topPanel);
			this.Name = "BillSaleReportForm";
			this.Text = "BillSaleReportForm";
			this.topPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Mbb.Windows.Forms.Panel topPanel;
		private Guna.UI2.WinForms.Guna2Button minimizeButton;
		private Guna.UI2.WinForms.Guna2Button closeButton;
		public Stimulsoft.Report.Viewer.StiRibbonViewerControl billsaleStiRibbonViewerControl;
	}
}
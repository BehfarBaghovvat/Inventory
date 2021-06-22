namespace Warehouse
{
	partial class WarehouseForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseForm));
			this.warehouseFormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.menuPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.invoiceAndCommodityButton = new Guna.UI2.WinForms.Guna2TileButton();
			this.storagButton = new Guna.UI2.WinForms.Guna2TileButton();
			this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// warehouseFormElipse
			// 
			this.warehouseFormElipse.BorderRadius = 35;
			this.warehouseFormElipse.TargetControl = this;
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.Transparent;
			this.menuPanel.Controls.Add(this.invoiceAndCommodityButton);
			this.menuPanel.Controls.Add(this.storagButton);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.menuPanel.FillColor = System.Drawing.Color.Indigo;
			this.menuPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(12)))), ((int)(((byte)(64)))));
			this.menuPanel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.menuPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.ShadowDecoration.Parent = this.menuPanel;
			this.menuPanel.Size = new System.Drawing.Size(990, 120);
			this.menuPanel.TabIndex = 0;
			this.menuPanel.UseTransparentBackground = true;
			// 
			// invoiceAndCommodityButton
			// 
			this.invoiceAndCommodityButton.Animated = true;
			this.invoiceAndCommodityButton.BorderColor = System.Drawing.Color.Transparent;
			this.invoiceAndCommodityButton.BorderRadius = 15;
			this.invoiceAndCommodityButton.CheckedState.Parent = this.invoiceAndCommodityButton;
			this.invoiceAndCommodityButton.CustomImages.Parent = this.invoiceAndCommodityButton;
			this.invoiceAndCommodityButton.FillColor = System.Drawing.Color.BlueViolet;
			this.invoiceAndCommodityButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.invoiceAndCommodityButton.ForeColor = System.Drawing.Color.White;
			this.invoiceAndCommodityButton.HoverState.FillColor = System.Drawing.Color.Transparent;
			this.invoiceAndCommodityButton.HoverState.Parent = this.invoiceAndCommodityButton;
			this.invoiceAndCommodityButton.Image = ((System.Drawing.Image)(resources.GetObject("invoiceAndCommodityButton.Image")));
			this.invoiceAndCommodityButton.ImageOffset = new System.Drawing.Point(0, -30);
			this.invoiceAndCommodityButton.ImageSize = new System.Drawing.Size(50, 50);
			this.invoiceAndCommodityButton.Location = new System.Drawing.Point(507, 12);
			this.invoiceAndCommodityButton.Name = "invoiceAndCommodityButton";
			this.invoiceAndCommodityButton.PressedColor = System.Drawing.Color.Transparent;
			this.invoiceAndCommodityButton.ShadowDecoration.Parent = this.invoiceAndCommodityButton;
			this.invoiceAndCommodityButton.Size = new System.Drawing.Size(80, 180);
			this.invoiceAndCommodityButton.TabIndex = 0;
			this.invoiceAndCommodityButton.Text = "فاکتور و کالا";
			this.invoiceAndCommodityButton.TextOffset = new System.Drawing.Point(0, -20);
			this.invoiceAndCommodityButton.UseTransparentBackground = true;
			this.invoiceAndCommodityButton.Click += new System.EventHandler(this.InvoiceAndCommodityButton_Click);
			// 
			// storagButton
			// 
			this.storagButton.Animated = true;
			this.storagButton.BorderColor = System.Drawing.Color.Transparent;
			this.storagButton.BorderRadius = 15;
			this.storagButton.CheckedState.Parent = this.storagButton;
			this.storagButton.CustomImages.Parent = this.storagButton;
			this.storagButton.FillColor = System.Drawing.Color.BlueViolet;
			this.storagButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.storagButton.ForeColor = System.Drawing.Color.White;
			this.storagButton.HoverState.FillColor = System.Drawing.Color.Transparent;
			this.storagButton.HoverState.Parent = this.storagButton;
			this.storagButton.Image = ((System.Drawing.Image)(resources.GetObject("storagButton.Image")));
			this.storagButton.ImageOffset = new System.Drawing.Point(0, -30);
			this.storagButton.ImageSize = new System.Drawing.Size(50, 50);
			this.storagButton.Location = new System.Drawing.Point(403, 12);
			this.storagButton.Name = "storagButton";
			this.storagButton.PressedColor = System.Drawing.Color.Transparent;
			this.storagButton.ShadowDecoration.Parent = this.storagButton;
			this.storagButton.Size = new System.Drawing.Size(80, 180);
			this.storagButton.TabIndex = 0;
			this.storagButton.Text = "انبار";
			this.storagButton.TextOffset = new System.Drawing.Point(0, -20);
			this.storagButton.UseTransparentBackground = true;
			this.storagButton.Click += new System.EventHandler(this.StoragButtonButton_Click);
			// 
			// mainPanel
			// 
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mainPanel.Location = new System.Drawing.Point(0, 120);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
			this.mainPanel.Size = new System.Drawing.Size(990, 530);
			this.mainPanel.TabIndex = 1;
			// 
			// WarehouseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(12)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(990, 650);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.menuPanel);
			this.Name = "WarehouseForm";
			this.Text = "WarehouseForm";
			this.menuPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse warehouseFormElipse;
		private Guna.UI2.WinForms.Guna2GradientPanel menuPanel;
		private Guna.UI2.WinForms.Guna2TileButton invoiceAndCommodityButton;
		private Guna.UI2.WinForms.Guna2TileButton storagButton;
		private Guna.UI2.WinForms.Guna2Panel mainPanel;
	}
}
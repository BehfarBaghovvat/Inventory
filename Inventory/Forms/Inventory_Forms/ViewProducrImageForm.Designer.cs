
namespace Inventory_Forms
{
	partial class ViewProducrImageForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProducrImageForm));
			this.closeButton = new Guna.UI2.WinForms.Guna2Button();
			this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
			this.topPanel = new Mbb.Windows.Forms.Panel();
			this.productImagePictureBox = new System.Windows.Forms.PictureBox();
			this.showGunaAnimateWindow = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
			this.ViewProducrImageFormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.closeFormTimer = new System.Windows.Forms.Timer(this.components);
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productImagePictureBox)).BeginInit();
			this.SuspendLayout();
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
			// topPanel
			// 
			this.topPanel.Controls.Add(this.minimizeButton);
			this.topPanel.Controls.Add(this.closeButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(770, 30);
			this.topPanel.TabIndex = 4;
			// 
			// productImagePictureBox
			// 
			this.productImagePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productImagePictureBox.BackgroundImage")));
			this.productImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.productImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productImagePictureBox.Location = new System.Drawing.Point(0, 30);
			this.productImagePictureBox.Name = "productImagePictureBox";
			this.productImagePictureBox.Size = new System.Drawing.Size(770, 770);
			this.productImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.productImagePictureBox.TabIndex = 5;
			this.productImagePictureBox.TabStop = false;
			// 
			// showGunaAnimateWindow
			// 
			this.showGunaAnimateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_ACTIVATE;
			this.showGunaAnimateWindow.Interval = 200;
			this.showGunaAnimateWindow.TargetControl = this;
			// 
			// ViewProducrImageFormElipse
			// 
			this.ViewProducrImageFormElipse.BorderRadius = 25;
			this.ViewProducrImageFormElipse.TargetControl = this;
			// 
			// closeFormTimer
			// 
			this.closeFormTimer.Interval = 5;
			this.closeFormTimer.Tick += new System.EventHandler(this.CloseFormTimer_Tick);
			// 
			// ViewProducrImageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(770, 800);
			this.Controls.Add(this.productImagePictureBox);
			this.Controls.Add(this.topPanel);
			this.Name = "ViewProducrImageForm";
			this.Text = "ViewProducrImageForm";
			this.topPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.productImagePictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Button closeButton;
		private Guna.UI2.WinForms.Guna2Button minimizeButton;
		private Mbb.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.PictureBox productImagePictureBox;
		private Guna.UI.WinForms.GunaAnimateWindow showGunaAnimateWindow;
		private Guna.UI2.WinForms.Guna2Elipse ViewProducrImageFormElipse;
		private System.Windows.Forms.Timer closeFormTimer;
	}
}
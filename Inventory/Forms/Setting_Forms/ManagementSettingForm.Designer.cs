
namespace Setting_Forms
{
	partial class ManagementSettingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementSettingForm));
			this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.controlPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.menuPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.checkInCheckOutButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.separatorPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.eventLogButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.separatorPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.userSettingButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.separatorPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.programSettingButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.mainPanel.SuspendLayout();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BorderColor = System.Drawing.Color.Indigo;
			this.mainPanel.BorderRadius = 15;
			this.mainPanel.BorderThickness = 3;
			this.mainPanel.Controls.Add(this.controlPanel);
			this.mainPanel.Controls.Add(this.menuPanel);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
			this.mainPanel.Size = new System.Drawing.Size(1150, 650);
			this.mainPanel.TabIndex = 0;
			// 
			// controlPanel
			// 
			this.controlPanel.Location = new System.Drawing.Point(13, 68);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.ShadowDecoration.Parent = this.controlPanel;
			this.controlPanel.Size = new System.Drawing.Size(1125, 570);
			this.controlPanel.TabIndex = 1;
			// 
			// menuPanel
			// 
			this.menuPanel.Controls.Add(this.checkInCheckOutButton);
			this.menuPanel.Controls.Add(this.separatorPanel3);
			this.menuPanel.Controls.Add(this.eventLogButton);
			this.menuPanel.Controls.Add(this.separatorPanel2);
			this.menuPanel.Controls.Add(this.userSettingButton);
			this.menuPanel.Controls.Add(this.separatorPanel1);
			this.menuPanel.Controls.Add(this.programSettingButton);
			this.menuPanel.Location = new System.Drawing.Point(12, 12);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.ShadowDecoration.Parent = this.menuPanel;
			this.menuPanel.Size = new System.Drawing.Size(1125, 50);
			this.menuPanel.TabIndex = 0;
			// 
			// checkInCheckOutButton
			// 
			this.checkInCheckOutButton.Animated = true;
			this.checkInCheckOutButton.BorderRadius = 5;
			this.checkInCheckOutButton.CheckedState.Parent = this.checkInCheckOutButton;
			this.checkInCheckOutButton.CustomImages.Parent = this.checkInCheckOutButton;
			this.checkInCheckOutButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.checkInCheckOutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.checkInCheckOutButton.FillColor2 = System.Drawing.Color.RoyalBlue;
			this.checkInCheckOutButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkInCheckOutButton.ForeColor = System.Drawing.Color.White;
			this.checkInCheckOutButton.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
			this.checkInCheckOutButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.checkInCheckOutButton.HoverState.Parent = this.checkInCheckOutButton;
			this.checkInCheckOutButton.Image = ((System.Drawing.Image)(resources.GetObject("checkInCheckOutButton.Image")));
			this.checkInCheckOutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.checkInCheckOutButton.ImageSize = new System.Drawing.Size(30, 30);
			this.checkInCheckOutButton.Location = new System.Drawing.Point(390, 0);
			this.checkInCheckOutButton.Name = "checkInCheckOutButton";
			this.checkInCheckOutButton.ShadowDecoration.Parent = this.checkInCheckOutButton;
			this.checkInCheckOutButton.Size = new System.Drawing.Size(180, 50);
			this.checkInCheckOutButton.TabIndex = 6;
			this.checkInCheckOutButton.Text = "کنترل ورود و خروج";
			this.checkInCheckOutButton.Click += new System.EventHandler(this.CheckInCheckOutButton_Click);
			// 
			// separatorPanel3
			// 
			this.separatorPanel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.separatorPanel3.Location = new System.Drawing.Point(570, 0);
			this.separatorPanel3.Name = "separatorPanel3";
			this.separatorPanel3.ShadowDecoration.Parent = this.separatorPanel3;
			this.separatorPanel3.Size = new System.Drawing.Size(5, 50);
			this.separatorPanel3.TabIndex = 5;
			// 
			// eventLogButton
			// 
			this.eventLogButton.Animated = true;
			this.eventLogButton.BorderRadius = 5;
			this.eventLogButton.CheckedState.Parent = this.eventLogButton;
			this.eventLogButton.CustomImages.Parent = this.eventLogButton;
			this.eventLogButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.eventLogButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.eventLogButton.FillColor2 = System.Drawing.Color.RoyalBlue;
			this.eventLogButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eventLogButton.ForeColor = System.Drawing.Color.White;
			this.eventLogButton.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
			this.eventLogButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.eventLogButton.HoverState.Parent = this.eventLogButton;
			this.eventLogButton.Image = ((System.Drawing.Image)(resources.GetObject("eventLogButton.Image")));
			this.eventLogButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.eventLogButton.ImageSize = new System.Drawing.Size(30, 30);
			this.eventLogButton.Location = new System.Drawing.Point(575, 0);
			this.eventLogButton.Name = "eventLogButton";
			this.eventLogButton.ShadowDecoration.Parent = this.eventLogButton;
			this.eventLogButton.Size = new System.Drawing.Size(180, 50);
			this.eventLogButton.TabIndex = 4;
			this.eventLogButton.Text = "کنترل رخداد";
			this.eventLogButton.Click += new System.EventHandler(this.EventLogButton_Click);
			// 
			// separatorPanel2
			// 
			this.separatorPanel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.separatorPanel2.Location = new System.Drawing.Point(755, 0);
			this.separatorPanel2.Name = "separatorPanel2";
			this.separatorPanel2.ShadowDecoration.Parent = this.separatorPanel2;
			this.separatorPanel2.Size = new System.Drawing.Size(5, 50);
			this.separatorPanel2.TabIndex = 3;
			// 
			// userSettingButton
			// 
			this.userSettingButton.Animated = true;
			this.userSettingButton.BorderRadius = 5;
			this.userSettingButton.CheckedState.Parent = this.userSettingButton;
			this.userSettingButton.CustomImages.Parent = this.userSettingButton;
			this.userSettingButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.userSettingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.userSettingButton.FillColor2 = System.Drawing.Color.RoyalBlue;
			this.userSettingButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userSettingButton.ForeColor = System.Drawing.Color.White;
			this.userSettingButton.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
			this.userSettingButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.userSettingButton.HoverState.Parent = this.userSettingButton;
			this.userSettingButton.Image = ((System.Drawing.Image)(resources.GetObject("userSettingButton.Image")));
			this.userSettingButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.userSettingButton.ImageSize = new System.Drawing.Size(30, 30);
			this.userSettingButton.Location = new System.Drawing.Point(760, 0);
			this.userSettingButton.Name = "userSettingButton";
			this.userSettingButton.ShadowDecoration.Parent = this.userSettingButton;
			this.userSettingButton.Size = new System.Drawing.Size(180, 50);
			this.userSettingButton.TabIndex = 2;
			this.userSettingButton.Text = "تنظیمات کاربران";
			this.userSettingButton.Click += new System.EventHandler(this.UserSettingButton_Click);
			// 
			// separatorPanel1
			// 
			this.separatorPanel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.separatorPanel1.Location = new System.Drawing.Point(940, 0);
			this.separatorPanel1.Name = "separatorPanel1";
			this.separatorPanel1.ShadowDecoration.Parent = this.separatorPanel1;
			this.separatorPanel1.Size = new System.Drawing.Size(5, 50);
			this.separatorPanel1.TabIndex = 1;
			// 
			// programSettingButton
			// 
			this.programSettingButton.Animated = true;
			this.programSettingButton.BorderRadius = 5;
			this.programSettingButton.CheckedState.Parent = this.programSettingButton;
			this.programSettingButton.CustomImages.Parent = this.programSettingButton;
			this.programSettingButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.programSettingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.programSettingButton.FillColor2 = System.Drawing.Color.RoyalBlue;
			this.programSettingButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.programSettingButton.ForeColor = System.Drawing.Color.White;
			this.programSettingButton.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
			this.programSettingButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.programSettingButton.HoverState.Parent = this.programSettingButton;
			this.programSettingButton.Image = ((System.Drawing.Image)(resources.GetObject("programSettingButton.Image")));
			this.programSettingButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.programSettingButton.ImageSize = new System.Drawing.Size(30, 30);
			this.programSettingButton.Location = new System.Drawing.Point(945, 0);
			this.programSettingButton.Name = "programSettingButton";
			this.programSettingButton.ShadowDecoration.Parent = this.programSettingButton;
			this.programSettingButton.Size = new System.Drawing.Size(180, 50);
			this.programSettingButton.TabIndex = 0;
			this.programSettingButton.Text = "تنظیمات نرم افزار";
			// 
			// ManagementSettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(1150, 650);
			this.Controls.Add(this.mainPanel);
			this.Name = "ManagementSettingForm";
			this.Text = "ManagementSettingForm";
			this.mainPanel.ResumeLayout(false);
			this.menuPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel mainPanel;
		private Guna.UI2.WinForms.Guna2GradientPanel controlPanel;
		private Guna.UI2.WinForms.Guna2GradientPanel menuPanel;
		private Guna.UI2.WinForms.Guna2GradientButton checkInCheckOutButton;
		private Guna.UI2.WinForms.Guna2GradientPanel separatorPanel3;
		private Guna.UI2.WinForms.Guna2GradientButton eventLogButton;
		private Guna.UI2.WinForms.Guna2GradientPanel separatorPanel2;
		private Guna.UI2.WinForms.Guna2GradientButton userSettingButton;
		private Guna.UI2.WinForms.Guna2GradientPanel separatorPanel1;
		private Guna.UI2.WinForms.Guna2GradientButton programSettingButton;
	}
}
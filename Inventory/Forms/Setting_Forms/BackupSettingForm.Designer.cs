
namespace Setting_Forms
{
	partial class BackupSettingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupSettingForm));
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.backupSettengGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
			this.saveButton = new Guna.UI2.WinForms.Guna2Button();
			this.timeIntervalLabel = new Mbb.Windows.Forms.Label();
			this.timeIntervalComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.autoBackupLabel = new Mbb.Windows.Forms.Label();
			this.autoBackupCheckBox = new Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.setTimeBackupGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
			this.HoureLabel = new Mbb.Windows.Forms.Label();
			this.minutesLbel = new Mbb.Windows.Forms.Label();
			this.minutesNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.houreNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.dayOfWeekGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
			this.ofWeekLabel = new Mbb.Windows.Forms.Label();
			this.dayOfWeekLabel = new Mbb.Windows.Forms.Label();
			this.dayOfWeekComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.dayOfMonthGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
			this.evryMonthLabel = new Mbb.Windows.Forms.Label();
			this.dayOfMonthLabel = new Mbb.Windows.Forms.Label();
			this.dayOfMonthNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.restorePanel = new Guna.UI2.WinForms.Guna2Panel();
			this.selectLoadPathButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.restorBackupButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.loadPathTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.backupPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.selectSavePathButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.backupButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.savePathTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.mainPanel.SuspendLayout();
			this.backupSettengGroupBox.SuspendLayout();
			this.setTimeBackupGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.houreNumericUpDown)).BeginInit();
			this.dayOfWeekGroupBox.SuspendLayout();
			this.dayOfMonthGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dayOfMonthNumericUpDown)).BeginInit();
			this.restorePanel.SuspendLayout();
			this.backupPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BorderColor = System.Drawing.Color.Indigo;
			this.mainPanel.BorderRadius = 15;
			this.mainPanel.BorderThickness = 3;
			this.mainPanel.Controls.Add(this.backupSettengGroupBox);
			this.mainPanel.Controls.Add(this.restorePanel);
			this.mainPanel.Controls.Add(this.backupPanel);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
			this.mainPanel.Size = new System.Drawing.Size(1150, 650);
			this.mainPanel.TabIndex = 0;
			// 
			// backupSettengGroupBox
			// 
			this.backupSettengGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.backupSettengGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.backupSettengGroupBox.BorderRadius = 10;
			this.backupSettengGroupBox.BorderThickness = 3;
			this.backupSettengGroupBox.Controls.Add(this.saveButton);
			this.backupSettengGroupBox.Controls.Add(this.timeIntervalLabel);
			this.backupSettengGroupBox.Controls.Add(this.timeIntervalComboBox);
			this.backupSettengGroupBox.Controls.Add(this.autoBackupLabel);
			this.backupSettengGroupBox.Controls.Add(this.autoBackupCheckBox);
			this.backupSettengGroupBox.Controls.Add(this.setTimeBackupGroupBox);
			this.backupSettengGroupBox.Controls.Add(this.dayOfWeekGroupBox);
			this.backupSettengGroupBox.Controls.Add(this.dayOfMonthGroupBox);
			this.backupSettengGroupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.backupSettengGroupBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backupSettengGroupBox.ForeColor = System.Drawing.Color.White;
			this.backupSettengGroupBox.Location = new System.Drawing.Point(12, 12);
			this.backupSettengGroupBox.Name = "backupSettengGroupBox";
			this.backupSettengGroupBox.ShadowDecoration.Parent = this.backupSettengGroupBox;
			this.backupSettengGroupBox.Size = new System.Drawing.Size(1126, 217);
			this.backupSettengGroupBox.TabIndex = 0;
			this.backupSettengGroupBox.Text = "تنظیمات پشتیبان گیری خودکار";
			this.backupSettengGroupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.backupSettengGroupBox.UseTransparentBackground = true;
			// 
			// saveButton
			// 
			this.saveButton.Animated = true;
			this.saveButton.BorderRadius = 5;
			this.saveButton.CheckedState.Parent = this.saveButton;
			this.saveButton.CustomImages.Parent = this.saveButton;
			this.saveButton.Enabled = false;
			this.saveButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.saveButton.HoverState.Parent = this.saveButton;
			this.saveButton.Location = new System.Drawing.Point(917, 154);
			this.saveButton.Name = "saveButton";
			this.saveButton.PressedColor = System.Drawing.Color.White;
			this.saveButton.ShadowDecoration.Parent = this.saveButton;
			this.saveButton.Size = new System.Drawing.Size(180, 45);
			this.saveButton.TabIndex = 7;
			this.saveButton.Text = "ثبت تنظیمات";
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// timeIntervalLabel
			// 
			this.timeIntervalLabel.AutoSize = true;
			this.timeIntervalLabel.ForeColor = System.Drawing.Color.Black;
			this.timeIntervalLabel.Location = new System.Drawing.Point(523, 54);
			this.timeIntervalLabel.Name = "timeIntervalLabel";
			this.timeIntervalLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.timeIntervalLabel.Size = new System.Drawing.Size(179, 22);
			this.timeIntervalLabel.TabIndex = 2;
			this.timeIntervalLabel.Text = "لطفا بازه زمانی را مشخص کنید:";
			// 
			// timeIntervalComboBox
			// 
			this.timeIntervalComboBox.Animated = true;
			this.timeIntervalComboBox.BackColor = System.Drawing.Color.Transparent;
			this.timeIntervalComboBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.timeIntervalComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.timeIntervalComboBox.DropDownHeight = 100;
			this.timeIntervalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.timeIntervalComboBox.DropDownWidth = 124;
			this.timeIntervalComboBox.Enabled = false;
			this.timeIntervalComboBox.FocusedColor = System.Drawing.Color.Empty;
			this.timeIntervalComboBox.FocusedState.Parent = this.timeIntervalComboBox;
			this.timeIntervalComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.timeIntervalComboBox.ForeColor = System.Drawing.Color.Black;
			this.timeIntervalComboBox.FormattingEnabled = true;
			this.timeIntervalComboBox.HoverState.Parent = this.timeIntervalComboBox;
			this.timeIntervalComboBox.IntegralHeight = false;
			this.timeIntervalComboBox.ItemHeight = 22;
			this.timeIntervalComboBox.Items.AddRange(new object[] {
            "روزانه",
            "هفتگی",
            "ماهانه"});
			this.timeIntervalComboBox.ItemsAppearance.Parent = this.timeIntervalComboBox;
			this.timeIntervalComboBox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
			this.timeIntervalComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
			this.timeIntervalComboBox.Location = new System.Drawing.Point(382, 51);
			this.timeIntervalComboBox.Name = "timeIntervalComboBox";
			this.timeIntervalComboBox.ShadowDecoration.Parent = this.timeIntervalComboBox;
			this.timeIntervalComboBox.Size = new System.Drawing.Size(124, 28);
			this.timeIntervalComboBox.TabIndex = 3;
			this.timeIntervalComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.timeIntervalComboBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			this.timeIntervalComboBox.SelectedIndexChanged += new System.EventHandler(this.TimeIntervalComboBox_SelectedIndexChanged);
			// 
			// autoBackupLabel
			// 
			this.autoBackupLabel.AutoSize = true;
			this.autoBackupLabel.ForeColor = System.Drawing.Color.Black;
			this.autoBackupLabel.Location = new System.Drawing.Point(777, 54);
			this.autoBackupLabel.Name = "autoBackupLabel";
			this.autoBackupLabel.Size = new System.Drawing.Size(294, 22);
			this.autoBackupLabel.TabIndex = 1;
			this.autoBackupLabel.Text = "آیا تهیه نسخه پشتیبان به صورت خودکار انجام گیرد؟";
			// 
			// autoBackupCheckBox
			// 
			this.autoBackupCheckBox.Animated = true;
			this.autoBackupCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.autoBackupCheckBox.CheckedState.BorderRadius = 2;
			this.autoBackupCheckBox.CheckedState.BorderThickness = 0;
			this.autoBackupCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.autoBackupCheckBox.CheckedState.Parent = this.autoBackupCheckBox;
			this.autoBackupCheckBox.Location = new System.Drawing.Point(1077, 55);
			this.autoBackupCheckBox.Name = "autoBackupCheckBox";
			this.autoBackupCheckBox.ShadowDecoration.Parent = this.autoBackupCheckBox;
			this.autoBackupCheckBox.Size = new System.Drawing.Size(20, 20);
			this.autoBackupCheckBox.TabIndex = 0;
			this.autoBackupCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.autoBackupCheckBox.UncheckedState.BorderRadius = 2;
			this.autoBackupCheckBox.UncheckedState.BorderThickness = 0;
			this.autoBackupCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.autoBackupCheckBox.UncheckedState.Parent = this.autoBackupCheckBox;
			this.autoBackupCheckBox.CheckedChanged += new System.EventHandler(this.AutoBackupCheckBox_CheckedChanged);
			// 
			// setTimeBackupGroupBox
			// 
			this.setTimeBackupGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.setTimeBackupGroupBox.BorderRadius = 15;
			this.setTimeBackupGroupBox.BorderThickness = 2;
			this.setTimeBackupGroupBox.Controls.Add(this.HoureLabel);
			this.setTimeBackupGroupBox.Controls.Add(this.minutesLbel);
			this.setTimeBackupGroupBox.Controls.Add(this.minutesNumericUpDown);
			this.setTimeBackupGroupBox.Controls.Add(this.houreNumericUpDown);
			this.setTimeBackupGroupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.setTimeBackupGroupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
			this.setTimeBackupGroupBox.Enabled = false;
			this.setTimeBackupGroupBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.setTimeBackupGroupBox.ForeColor = System.Drawing.Color.White;
			this.setTimeBackupGroupBox.Location = new System.Drawing.Point(382, 107);
			this.setTimeBackupGroupBox.Name = "setTimeBackupGroupBox";
			this.setTimeBackupGroupBox.ShadowDecoration.Parent = this.setTimeBackupGroupBox;
			this.setTimeBackupGroupBox.Size = new System.Drawing.Size(316, 92);
			this.setTimeBackupGroupBox.TabIndex = 4;
			this.setTimeBackupGroupBox.Text = "لطفا زمان تهیه نسخه پشتیبان را مشخص کنید";
			this.setTimeBackupGroupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// HoureLabel
			// 
			this.HoureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HoureLabel.AutoSize = true;
			this.HoureLabel.ForeColor = System.Drawing.Color.Black;
			this.HoureLabel.Location = new System.Drawing.Point(119, 56);
			this.HoureLabel.Name = "HoureLabel";
			this.HoureLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.HoureLabel.Size = new System.Drawing.Size(41, 14);
			this.HoureLabel.TabIndex = 2;
			this.HoureLabel.Text = "ساعت";
			// 
			// minutesLbel
			// 
			this.minutesLbel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minutesLbel.AutoSize = true;
			this.minutesLbel.ForeColor = System.Drawing.Color.Black;
			this.minutesLbel.Location = new System.Drawing.Point(272, 56);
			this.minutesLbel.Name = "minutesLbel";
			this.minutesLbel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.minutesLbel.Size = new System.Drawing.Size(35, 14);
			this.minutesLbel.TabIndex = 0;
			this.minutesLbel.Text = "دقیقه";
			// 
			// minutesNumericUpDown
			// 
			this.minutesNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minutesNumericUpDown.BackColor = System.Drawing.Color.Transparent;
			this.minutesNumericUpDown.BorderRadius = 5;
			this.minutesNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.minutesNumericUpDown.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.minutesNumericUpDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.minutesNumericUpDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.minutesNumericUpDown.DisabledState.Parent = this.minutesNumericUpDown;
			this.minutesNumericUpDown.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
			this.minutesNumericUpDown.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
			this.minutesNumericUpDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.minutesNumericUpDown.FocusedState.Parent = this.minutesNumericUpDown;
			this.minutesNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minutesNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.minutesNumericUpDown.Location = new System.Drawing.Point(166, 46);
			this.minutesNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.minutesNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.minutesNumericUpDown.Name = "minutesNumericUpDown";
			this.minutesNumericUpDown.ShadowDecoration.Parent = this.minutesNumericUpDown;
			this.minutesNumericUpDown.Size = new System.Drawing.Size(100, 35);
			this.minutesNumericUpDown.TabIndex = 1;
			this.minutesNumericUpDown.UseTransparentBackground = true;
			this.minutesNumericUpDown.ValueChanged += new System.EventHandler(this.MinutesNumericUpDown_ValueChanged);
			// 
			// houreNumericUpDown
			// 
			this.houreNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.houreNumericUpDown.BackColor = System.Drawing.Color.Transparent;
			this.houreNumericUpDown.BorderRadius = 5;
			this.houreNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.houreNumericUpDown.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.houreNumericUpDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.houreNumericUpDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.houreNumericUpDown.DisabledState.Parent = this.houreNumericUpDown;
			this.houreNumericUpDown.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
			this.houreNumericUpDown.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
			this.houreNumericUpDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.houreNumericUpDown.FocusedState.Parent = this.houreNumericUpDown;
			this.houreNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.houreNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.houreNumericUpDown.Location = new System.Drawing.Point(13, 46);
			this.houreNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.houreNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
			this.houreNumericUpDown.Name = "houreNumericUpDown";
			this.houreNumericUpDown.ShadowDecoration.Parent = this.houreNumericUpDown;
			this.houreNumericUpDown.Size = new System.Drawing.Size(100, 35);
			this.houreNumericUpDown.TabIndex = 3;
			this.houreNumericUpDown.UseTransparentBackground = true;
			this.houreNumericUpDown.ValueChanged += new System.EventHandler(this.HoureNumericUpDown_ValueChanged);
			// 
			// dayOfWeekGroupBox
			// 
			this.dayOfWeekGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.dayOfWeekGroupBox.BorderRadius = 15;
			this.dayOfWeekGroupBox.BorderThickness = 2;
			this.dayOfWeekGroupBox.Controls.Add(this.ofWeekLabel);
			this.dayOfWeekGroupBox.Controls.Add(this.dayOfWeekLabel);
			this.dayOfWeekGroupBox.Controls.Add(this.dayOfWeekComboBox);
			this.dayOfWeekGroupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.dayOfWeekGroupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
			this.dayOfWeekGroupBox.Enabled = false;
			this.dayOfWeekGroupBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dayOfWeekGroupBox.ForeColor = System.Drawing.Color.White;
			this.dayOfWeekGroupBox.Location = new System.Drawing.Point(382, 107);
			this.dayOfWeekGroupBox.Name = "dayOfWeekGroupBox";
			this.dayOfWeekGroupBox.ShadowDecoration.Parent = this.dayOfWeekGroupBox;
			this.dayOfWeekGroupBox.Size = new System.Drawing.Size(316, 92);
			this.dayOfWeekGroupBox.TabIndex = 5;
			this.dayOfWeekGroupBox.Text = "لطفا روز هفته مورد نظر برای پشتیبان گیری را تعیین نمایید";
			this.dayOfWeekGroupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// ofWeekLabel
			// 
			this.ofWeekLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ofWeekLabel.AutoSize = true;
			this.ofWeekLabel.ForeColor = System.Drawing.Color.Black;
			this.ofWeekLabel.Location = new System.Drawing.Point(55, 53);
			this.ofWeekLabel.Name = "ofWeekLabel";
			this.ofWeekLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ofWeekLabel.Size = new System.Drawing.Size(49, 14);
			this.ofWeekLabel.TabIndex = 2;
			this.ofWeekLabel.Text = "هر هفته";
			// 
			// dayOfWeekLabel
			// 
			this.dayOfWeekLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dayOfWeekLabel.AutoSize = true;
			this.dayOfWeekLabel.ForeColor = System.Drawing.Color.Black;
			this.dayOfWeekLabel.Location = new System.Drawing.Point(239, 53);
			this.dayOfWeekLabel.Name = "dayOfWeekLabel";
			this.dayOfWeekLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dayOfWeekLabel.Size = new System.Drawing.Size(20, 14);
			this.dayOfWeekLabel.TabIndex = 0;
			this.dayOfWeekLabel.Text = "روز";
			// 
			// dayOfWeekComboBox
			// 
			this.dayOfWeekComboBox.Animated = true;
			this.dayOfWeekComboBox.BackColor = System.Drawing.Color.Transparent;
			this.dayOfWeekComboBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.dayOfWeekComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.dayOfWeekComboBox.DropDownHeight = 100;
			this.dayOfWeekComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dayOfWeekComboBox.DropDownWidth = 124;
			this.dayOfWeekComboBox.FocusedColor = System.Drawing.Color.Empty;
			this.dayOfWeekComboBox.FocusedState.Parent = this.dayOfWeekComboBox;
			this.dayOfWeekComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.dayOfWeekComboBox.ForeColor = System.Drawing.Color.Black;
			this.dayOfWeekComboBox.FormattingEnabled = true;
			this.dayOfWeekComboBox.HoverState.Parent = this.dayOfWeekComboBox;
			this.dayOfWeekComboBox.IntegralHeight = false;
			this.dayOfWeekComboBox.ItemHeight = 22;
			this.dayOfWeekComboBox.Items.AddRange(new object[] {
            "شنبه",
            "یکشنبه",
            "دوشنبه",
            "سه شنبه",
            "چهار شنبه",
            "پنچ شنبه",
            "جمعه"});
			this.dayOfWeekComboBox.ItemsAppearance.Parent = this.dayOfWeekComboBox;
			this.dayOfWeekComboBox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
			this.dayOfWeekComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
			this.dayOfWeekComboBox.Location = new System.Drawing.Point(109, 48);
			this.dayOfWeekComboBox.Name = "dayOfWeekComboBox";
			this.dayOfWeekComboBox.ShadowDecoration.Parent = this.dayOfWeekComboBox;
			this.dayOfWeekComboBox.Size = new System.Drawing.Size(124, 28);
			this.dayOfWeekComboBox.TabIndex = 1;
			this.dayOfWeekComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.dayOfWeekComboBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			this.dayOfWeekComboBox.SelectedIndexChanged += new System.EventHandler(this.DayOfWeekComboBox_SelectedIndexChanged);
			// 
			// dayOfMonthGroupBox
			// 
			this.dayOfMonthGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.dayOfMonthGroupBox.BorderRadius = 15;
			this.dayOfMonthGroupBox.BorderThickness = 2;
			this.dayOfMonthGroupBox.Controls.Add(this.evryMonthLabel);
			this.dayOfMonthGroupBox.Controls.Add(this.dayOfMonthLabel);
			this.dayOfMonthGroupBox.Controls.Add(this.dayOfMonthNumericUpDown);
			this.dayOfMonthGroupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.dayOfMonthGroupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 35, 0, 0);
			this.dayOfMonthGroupBox.Enabled = false;
			this.dayOfMonthGroupBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dayOfMonthGroupBox.ForeColor = System.Drawing.Color.White;
			this.dayOfMonthGroupBox.Location = new System.Drawing.Point(382, 107);
			this.dayOfMonthGroupBox.Name = "dayOfMonthGroupBox";
			this.dayOfMonthGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dayOfMonthGroupBox.ShadowDecoration.Parent = this.dayOfMonthGroupBox;
			this.dayOfMonthGroupBox.Size = new System.Drawing.Size(316, 92);
			this.dayOfMonthGroupBox.TabIndex = 6;
			this.dayOfMonthGroupBox.Text = "لطفا روز چندم ماه نسخه پشتیبان تهیه گردد";
			this.dayOfMonthGroupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// evryMonthLabel
			// 
			this.evryMonthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.evryMonthLabel.AutoSize = true;
			this.evryMonthLabel.ForeColor = System.Drawing.Color.Black;
			this.evryMonthLabel.Location = new System.Drawing.Point(71, 53);
			this.evryMonthLabel.Name = "evryMonthLabel";
			this.evryMonthLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.evryMonthLabel.Size = new System.Drawing.Size(40, 14);
			this.evryMonthLabel.TabIndex = 2;
			this.evryMonthLabel.Text = "هر ماه";
			// 
			// dayOfMonthLabel
			// 
			this.dayOfMonthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dayOfMonthLabel.AutoSize = true;
			this.dayOfMonthLabel.ForeColor = System.Drawing.Color.Black;
			this.dayOfMonthLabel.Location = new System.Drawing.Point(222, 52);
			this.dayOfMonthLabel.Name = "dayOfMonthLabel";
			this.dayOfMonthLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dayOfMonthLabel.Size = new System.Drawing.Size(20, 14);
			this.dayOfMonthLabel.TabIndex = 0;
			this.dayOfMonthLabel.Text = "روز";
			// 
			// dayOfMonthNumericUpDown
			// 
			this.dayOfMonthNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dayOfMonthNumericUpDown.BackColor = System.Drawing.Color.Transparent;
			this.dayOfMonthNumericUpDown.BorderRadius = 5;
			this.dayOfMonthNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.dayOfMonthNumericUpDown.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.dayOfMonthNumericUpDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.dayOfMonthNumericUpDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.dayOfMonthNumericUpDown.DisabledState.Parent = this.dayOfMonthNumericUpDown;
			this.dayOfMonthNumericUpDown.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
			this.dayOfMonthNumericUpDown.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
			this.dayOfMonthNumericUpDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.dayOfMonthNumericUpDown.FocusedState.Parent = this.dayOfMonthNumericUpDown;
			this.dayOfMonthNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dayOfMonthNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.dayOfMonthNumericUpDown.Location = new System.Drawing.Point(116, 44);
			this.dayOfMonthNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dayOfMonthNumericUpDown.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
			this.dayOfMonthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.dayOfMonthNumericUpDown.Name = "dayOfMonthNumericUpDown";
			this.dayOfMonthNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dayOfMonthNumericUpDown.ShadowDecoration.Parent = this.dayOfMonthNumericUpDown;
			this.dayOfMonthNumericUpDown.Size = new System.Drawing.Size(100, 35);
			this.dayOfMonthNumericUpDown.TabIndex = 1;
			this.dayOfMonthNumericUpDown.UseTransparentBackground = true;
			this.dayOfMonthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.dayOfMonthNumericUpDown.ValueChanged += new System.EventHandler(this.DayOfMonthNumericUpDown_ValueChanged);
			// 
			// restorePanel
			// 
			this.restorePanel.BorderColor = System.Drawing.Color.Indigo;
			this.restorePanel.BorderRadius = 10;
			this.restorePanel.BorderThickness = 3;
			this.restorePanel.Controls.Add(this.selectLoadPathButton);
			this.restorePanel.Controls.Add(this.restorBackupButton);
			this.restorePanel.Controls.Add(this.loadPathTextBox);
			this.restorePanel.Font = new System.Drawing.Font("IRANSansXFaNum", 8F);
			this.restorePanel.Location = new System.Drawing.Point(12, 423);
			this.restorePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.restorePanel.Name = "restorePanel";
			this.restorePanel.ShadowDecoration.Parent = this.restorePanel;
			this.restorePanel.Size = new System.Drawing.Size(1125, 120);
			this.restorePanel.TabIndex = 2;
			// 
			// selectLoadPathButton
			// 
			this.selectLoadPathButton.BorderRadius = 5;
			this.selectLoadPathButton.CheckedState.Parent = this.selectLoadPathButton;
			this.selectLoadPathButton.CustomImages.Parent = this.selectLoadPathButton;
			this.selectLoadPathButton.FillColor = System.Drawing.Color.Teal;
			this.selectLoadPathButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.selectLoadPathButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectLoadPathButton.ForeColor = System.Drawing.Color.White;
			this.selectLoadPathButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.selectLoadPathButton.HoverState.FillColor2 = System.Drawing.Color.Teal;
			this.selectLoadPathButton.HoverState.Parent = this.selectLoadPathButton;
			this.selectLoadPathButton.Location = new System.Drawing.Point(806, 66);
			this.selectLoadPathButton.Name = "selectLoadPathButton";
			this.selectLoadPathButton.ShadowDecoration.Parent = this.selectLoadPathButton;
			this.selectLoadPathButton.Size = new System.Drawing.Size(150, 40);
			this.selectLoadPathButton.TabIndex = 1;
			this.selectLoadPathButton.Text = "مسیره بارگیری";
			this.selectLoadPathButton.Click += new System.EventHandler(this.SelectLoadPathButton_Click);
			// 
			// restorBackupButton
			// 
			this.restorBackupButton.BorderRadius = 5;
			this.restorBackupButton.CheckedState.Parent = this.restorBackupButton;
			this.restorBackupButton.CustomImages.Parent = this.restorBackupButton;
			this.restorBackupButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.restorBackupButton.FillColor2 = System.Drawing.Color.Teal;
			this.restorBackupButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.restorBackupButton.ForeColor = System.Drawing.Color.White;
			this.restorBackupButton.HoverState.Parent = this.restorBackupButton;
			this.restorBackupButton.Location = new System.Drawing.Point(962, 66);
			this.restorBackupButton.Name = "restorBackupButton";
			this.restorBackupButton.ShadowDecoration.Parent = this.restorBackupButton;
			this.restorBackupButton.Size = new System.Drawing.Size(150, 40);
			this.restorBackupButton.TabIndex = 0;
			this.restorBackupButton.Text = "عملیات بازیابی";
			this.restorBackupButton.Click += new System.EventHandler(this.RestorBackupButton_Click);
			// 
			// loadPathTextBox
			// 
			this.loadPathTextBox.AcceptsReturn = false;
			this.loadPathTextBox.AcceptsTab = false;
			this.loadPathTextBox.AnimationSpeed = 200;
			this.loadPathTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.loadPathTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.loadPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.loadPathTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadPathTextBox.BackgroundImage")));
			this.loadPathTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.loadPathTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.loadPathTextBox.BorderColorHover = System.Drawing.Color.Aqua;
			this.loadPathTextBox.BorderColorIdle = System.Drawing.Color.Silver;
			this.loadPathTextBox.BorderRadius = 1;
			this.loadPathTextBox.BorderThickness = 3;
			this.loadPathTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.loadPathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.loadPathTextBox.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadPathTextBox.DefaultText = "";
			this.loadPathTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.loadPathTextBox.HideSelection = true;
			this.loadPathTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("loadPathTextBox.IconLeft")));
			this.loadPathTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.loadPathTextBox.IconPadding = 11;
			this.loadPathTextBox.IconRight = null;
			this.loadPathTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.loadPathTextBox.Lines = new string[0];
			this.loadPathTextBox.Location = new System.Drawing.Point(17, 13);
			this.loadPathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.loadPathTextBox.MaxLength = 32767;
			this.loadPathTextBox.MinimumSize = new System.Drawing.Size(100, 46);
			this.loadPathTextBox.Modified = false;
			this.loadPathTextBox.Multiline = false;
			this.loadPathTextBox.Name = "loadPathTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.loadPathTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.loadPathTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.Aqua;
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.loadPathTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Silver;
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties4.ForeColor = System.Drawing.Color.Empty;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.loadPathTextBox.OnIdleState = stateProperties4;
			this.loadPathTextBox.PasswordChar = '\0';
			this.loadPathTextBox.PlaceholderForeColor = System.Drawing.Color.LightGray;
			this.loadPathTextBox.PlaceholderText = "Load Path";
			this.loadPathTextBox.ReadOnly = true;
			this.loadPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.loadPathTextBox.SelectedText = "";
			this.loadPathTextBox.SelectionLength = 0;
			this.loadPathTextBox.SelectionStart = 0;
			this.loadPathTextBox.ShortcutsEnabled = true;
			this.loadPathTextBox.Size = new System.Drawing.Size(1091, 46);
			this.loadPathTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.loadPathTextBox.TabIndex = 2;
			this.loadPathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.loadPathTextBox.TextMarginBottom = 0;
			this.loadPathTextBox.TextMarginLeft = 10;
			this.loadPathTextBox.TextMarginTop = -2;
			this.loadPathTextBox.TextPlaceholder = "Load Path";
			this.loadPathTextBox.UseSystemPasswordChar = false;
			this.loadPathTextBox.WordWrap = true;
			// 
			// backupPanel
			// 
			this.backupPanel.BorderColor = System.Drawing.Color.Indigo;
			this.backupPanel.BorderRadius = 10;
			this.backupPanel.BorderThickness = 3;
			this.backupPanel.Controls.Add(this.selectSavePathButton);
			this.backupPanel.Controls.Add(this.backupButton);
			this.backupPanel.Controls.Add(this.savePathTextBox);
			this.backupPanel.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.backupPanel.Location = new System.Drawing.Point(13, 264);
			this.backupPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.backupPanel.Name = "backupPanel";
			this.backupPanel.ShadowDecoration.Parent = this.backupPanel;
			this.backupPanel.Size = new System.Drawing.Size(1125, 120);
			this.backupPanel.TabIndex = 1;
			// 
			// selectSavePathButton
			// 
			this.selectSavePathButton.Animated = true;
			this.selectSavePathButton.BorderRadius = 5;
			this.selectSavePathButton.CheckedState.Parent = this.selectSavePathButton;
			this.selectSavePathButton.CustomImages.Parent = this.selectSavePathButton;
			this.selectSavePathButton.FillColor = System.Drawing.Color.Teal;
			this.selectSavePathButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.selectSavePathButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectSavePathButton.ForeColor = System.Drawing.Color.White;
			this.selectSavePathButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.selectSavePathButton.HoverState.FillColor2 = System.Drawing.Color.Teal;
			this.selectSavePathButton.HoverState.Parent = this.selectSavePathButton;
			this.selectSavePathButton.Location = new System.Drawing.Point(805, 66);
			this.selectSavePathButton.Name = "selectSavePathButton";
			this.selectSavePathButton.ShadowDecoration.Parent = this.selectSavePathButton;
			this.selectSavePathButton.Size = new System.Drawing.Size(150, 40);
			this.selectSavePathButton.TabIndex = 1;
			this.selectSavePathButton.Text = "مسیر ذخیره";
			this.selectSavePathButton.Click += new System.EventHandler(this.SelectSavePathButton_Click);
			// 
			// backupButton
			// 
			this.backupButton.Animated = true;
			this.backupButton.BorderRadius = 5;
			this.backupButton.CheckedState.Parent = this.backupButton;
			this.backupButton.CustomImages.Parent = this.backupButton;
			this.backupButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.backupButton.FillColor2 = System.Drawing.Color.Teal;
			this.backupButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backupButton.ForeColor = System.Drawing.Color.White;
			this.backupButton.HoverState.FillColor = System.Drawing.Color.Teal;
			this.backupButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.backupButton.HoverState.Parent = this.backupButton;
			this.backupButton.Location = new System.Drawing.Point(961, 66);
			this.backupButton.Name = "backupButton";
			this.backupButton.ShadowDecoration.Parent = this.backupButton;
			this.backupButton.Size = new System.Drawing.Size(150, 40);
			this.backupButton.TabIndex = 0;
			this.backupButton.Text = "عملیات پشتیبان گیری";
			this.backupButton.Click += new System.EventHandler(this.BackupButton_Click);
			// 
			// savePathTextBox
			// 
			this.savePathTextBox.AcceptsReturn = false;
			this.savePathTextBox.AcceptsTab = false;
			this.savePathTextBox.AnimationSpeed = 200;
			this.savePathTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.savePathTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.savePathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.savePathTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savePathTextBox.BackgroundImage")));
			this.savePathTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.savePathTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.savePathTextBox.BorderColorHover = System.Drawing.Color.Aqua;
			this.savePathTextBox.BorderColorIdle = System.Drawing.Color.Silver;
			this.savePathTextBox.BorderRadius = 1;
			this.savePathTextBox.BorderThickness = 3;
			this.savePathTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.savePathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.savePathTextBox.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.savePathTextBox.DefaultText = "";
			this.savePathTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.savePathTextBox.HideSelection = true;
			this.savePathTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("savePathTextBox.IconLeft")));
			this.savePathTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.savePathTextBox.IconPadding = 11;
			this.savePathTextBox.IconRight = null;
			this.savePathTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.savePathTextBox.Lines = new string[0];
			this.savePathTextBox.Location = new System.Drawing.Point(17, 13);
			this.savePathTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.savePathTextBox.MaxLength = 32767;
			this.savePathTextBox.MinimumSize = new System.Drawing.Size(100, 46);
			this.savePathTextBox.Modified = false;
			this.savePathTextBox.Multiline = false;
			this.savePathTextBox.Name = "savePathTextBox";
			stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			stateProperties5.FillColor = System.Drawing.Color.Empty;
			stateProperties5.ForeColor = System.Drawing.Color.Empty;
			stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.savePathTextBox.OnActiveState = stateProperties5;
			stateProperties6.BorderColor = System.Drawing.Color.Empty;
			stateProperties6.FillColor = System.Drawing.Color.White;
			stateProperties6.ForeColor = System.Drawing.Color.Empty;
			stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.savePathTextBox.OnDisabledState = stateProperties6;
			stateProperties7.BorderColor = System.Drawing.Color.Aqua;
			stateProperties7.FillColor = System.Drawing.Color.Empty;
			stateProperties7.ForeColor = System.Drawing.Color.Empty;
			stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.savePathTextBox.OnHoverState = stateProperties7;
			stateProperties8.BorderColor = System.Drawing.Color.Silver;
			stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties8.ForeColor = System.Drawing.Color.Empty;
			stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.savePathTextBox.OnIdleState = stateProperties8;
			this.savePathTextBox.PasswordChar = '\0';
			this.savePathTextBox.PlaceholderForeColor = System.Drawing.Color.LightGray;
			this.savePathTextBox.PlaceholderText = "Save Path";
			this.savePathTextBox.ReadOnly = true;
			this.savePathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.savePathTextBox.SelectedText = "";
			this.savePathTextBox.SelectionLength = 0;
			this.savePathTextBox.SelectionStart = 0;
			this.savePathTextBox.ShortcutsEnabled = true;
			this.savePathTextBox.Size = new System.Drawing.Size(1090, 46);
			this.savePathTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.savePathTextBox.TabIndex = 2;
			this.savePathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.savePathTextBox.TextMarginBottom = 0;
			this.savePathTextBox.TextMarginLeft = 10;
			this.savePathTextBox.TextMarginTop = -2;
			this.savePathTextBox.TextPlaceholder = "Save Path";
			this.savePathTextBox.UseSystemPasswordChar = false;
			this.savePathTextBox.WordWrap = true;
			// 
			// BackupSettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(1150, 650);
			this.Controls.Add(this.mainPanel);
			this.Name = "BackupSettingForm";
			this.Text = "BackupSettingForm";
			this.Load += new System.EventHandler(this.BackupSettingForm_Load);
			this.mainPanel.ResumeLayout(false);
			this.backupSettengGroupBox.ResumeLayout(false);
			this.backupSettengGroupBox.PerformLayout();
			this.setTimeBackupGroupBox.ResumeLayout(false);
			this.setTimeBackupGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.houreNumericUpDown)).EndInit();
			this.dayOfWeekGroupBox.ResumeLayout(false);
			this.dayOfWeekGroupBox.PerformLayout();
			this.dayOfMonthGroupBox.ResumeLayout(false);
			this.dayOfMonthGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dayOfMonthNumericUpDown)).EndInit();
			this.restorePanel.ResumeLayout(false);
			this.backupPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel mainPanel;
		private Guna.UI2.WinForms.Guna2Panel restorePanel;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox loadPathTextBox;
		private Guna.UI2.WinForms.Guna2Panel backupPanel;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox savePathTextBox;
		private Guna.UI2.WinForms.Guna2GradientButton selectLoadPathButton;
		private Guna.UI2.WinForms.Guna2GradientButton restorBackupButton;
		private Guna.UI2.WinForms.Guna2GradientButton selectSavePathButton;
		private Guna.UI2.WinForms.Guna2GradientButton backupButton;
		private Guna.UI2.WinForms.Guna2GroupBox backupSettengGroupBox;
		private Guna.UI2.WinForms.Guna2Button saveButton;
		private Guna.UI2.WinForms.Guna2GroupBox setTimeBackupGroupBox;
		private Mbb.Windows.Forms.Label HoureLabel;
		private Mbb.Windows.Forms.Label minutesLbel;
		private Guna.UI2.WinForms.Guna2NumericUpDown minutesNumericUpDown;
		private Guna.UI2.WinForms.Guna2NumericUpDown houreNumericUpDown;
		private Mbb.Windows.Forms.Label timeIntervalLabel;
		private Guna.UI2.WinForms.Guna2ComboBox timeIntervalComboBox;
		private Mbb.Windows.Forms.Label autoBackupLabel;
		private Guna.UI2.WinForms.Guna2CustomCheckBox autoBackupCheckBox;
		private Guna.UI2.WinForms.Guna2GroupBox dayOfMonthGroupBox;
		private Mbb.Windows.Forms.Label dayOfMonthLabel;
		private Guna.UI2.WinForms.Guna2GroupBox dayOfWeekGroupBox;
		private Mbb.Windows.Forms.Label dayOfWeekLabel;
		private Guna.UI2.WinForms.Guna2ComboBox dayOfWeekComboBox;
		private Mbb.Windows.Forms.Label evryMonthLabel;
		private Mbb.Windows.Forms.Label ofWeekLabel;
		private Guna.UI2.WinForms.Guna2NumericUpDown dayOfMonthNumericUpDown;
	}
}

namespace Manegment_Setting
{
	partial class UserSettingUC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettingUC));
			this.dataGridViewPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.userListDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accessLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userSettingGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
			this.activationUserLabel = new Mbb.Windows.Forms.Label();
			this.activationUserCheckBox = new Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.usenamePanel = new Mbb.Windows.Forms.Panel();
			this.usernameLabel = new Mbb.Windows.Forms.Label();
			this.accessLevelGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
			this.simpleUserLabel = new Mbb.Windows.Forms.Label();
			this.simpleUserRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
			this.assistanceLabel = new Mbb.Windows.Forms.Label();
			this.assistanceRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
			this.employeedLabel = new Mbb.Windows.Forms.Label();
			this.employeedRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
			this.administratorLabel = new Mbb.Windows.Forms.Label();
			this.administratorRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
			this.updateButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.userListDataGridViewElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userImagePictureBox = new Mbb.Windows.Forms.CircularPictureBox();
			this.dataGridViewPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userListDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.userSettingGroupBox.SuspendLayout();
			this.accessLevelGroupBox.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewPanel
			// 
			this.dataGridViewPanel.Controls.Add(this.userListDataGridView);
			this.dataGridViewPanel.Location = new System.Drawing.Point(10, 10);
			this.dataGridViewPanel.Name = "dataGridViewPanel";
			this.dataGridViewPanel.ShadowDecoration.Parent = this.dataGridViewPanel;
			this.dataGridViewPanel.Size = new System.Drawing.Size(780, 550);
			this.dataGridViewPanel.TabIndex = 0;
			// 
			// userListDataGridView
			// 
			this.userListDataGridView.AllowUserToAddRows = false;
			this.userListDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
			this.userListDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.userListDataGridView.AutoGenerateColumns = false;
			this.userListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.userListDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.userListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.userListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.userListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansXFaNum", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.userListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.userListDataGridView.ColumnHeadersHeight = 40;
			this.userListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.userListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.accessLevelDataGridViewTextBoxColumn,
            this.editDateDataGridViewTextBoxColumn,
            this.editTimeDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.registrationTimeDataGridViewTextBoxColumn,
            this.userImageDataGridViewImageColumn});
			this.userListDataGridView.ContextMenuStrip = this.contextMenuStrip;
			this.userListDataGridView.DataSource = this.userBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.userListDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.userListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userListDataGridView.EnableHeadersVisualStyles = false;
			this.userListDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
			this.userListDataGridView.Location = new System.Drawing.Point(0, 0);
			this.userListDataGridView.Name = "userListDataGridView";
			this.userListDataGridView.ReadOnly = true;
			this.userListDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.userListDataGridView.RowHeadersVisible = false;
			this.userListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.userListDataGridView.Size = new System.Drawing.Size(780, 550);
			this.userListDataGridView.TabIndex = 0;
			this.userListDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
			this.userListDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
			this.userListDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.userListDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.userListDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.userListDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.userListDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.userListDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
			this.userListDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
			this.userListDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.userListDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.userListDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.userListDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.userListDataGridView.ThemeStyle.HeaderStyle.Height = 40;
			this.userListDataGridView.ThemeStyle.ReadOnly = true;
			this.userListDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
			this.userListDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.userListDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.userListDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.userListDataGridView.ThemeStyle.RowsStyle.Height = 22;
			this.userListDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
			this.userListDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.userListDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserListDataGridView_CellDoubleClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.FillWeight = 50F;
			this.idDataGridViewTextBoxColumn.HeaderText = "ردیف";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// isActiveDataGridViewCheckBoxColumn
			// 
			this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "Is_Active";
			this.isActiveDataGridViewCheckBoxColumn.FillWeight = 50F;
			this.isActiveDataGridViewCheckBoxColumn.HeaderText = "فعالیت";
			this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
			this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// usernameDataGridViewTextBoxColumn
			// 
			this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
			this.usernameDataGridViewTextBoxColumn.FillWeight = 125F;
			this.usernameDataGridViewTextBoxColumn.HeaderText = "شناسه کاربری";
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
			this.fullNameDataGridViewTextBoxColumn.FillWeight = 125F;
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// accessLevelDataGridViewTextBoxColumn
			// 
			this.accessLevelDataGridViewTextBoxColumn.DataPropertyName = "Access_Level";
			this.accessLevelDataGridViewTextBoxColumn.HeaderText = "سطح دسترسی";
			this.accessLevelDataGridViewTextBoxColumn.Name = "accessLevelDataGridViewTextBoxColumn";
			this.accessLevelDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// editDateDataGridViewTextBoxColumn
			// 
			this.editDateDataGridViewTextBoxColumn.DataPropertyName = "Edit_Date";
			this.editDateDataGridViewTextBoxColumn.FillWeight = 75F;
			this.editDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ویرایش";
			this.editDateDataGridViewTextBoxColumn.Name = "editDateDataGridViewTextBoxColumn";
			this.editDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// editTimeDataGridViewTextBoxColumn
			// 
			this.editTimeDataGridViewTextBoxColumn.DataPropertyName = "Edit_Time";
			this.editTimeDataGridViewTextBoxColumn.FillWeight = 75F;
			this.editTimeDataGridViewTextBoxColumn.HeaderText = "زمان ویرایش";
			this.editTimeDataGridViewTextBoxColumn.Name = "editTimeDataGridViewTextBoxColumn";
			this.editTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
			this.passwordDataGridViewTextBoxColumn.HeaderText = "رمز عبور";
			this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
			this.passwordDataGridViewTextBoxColumn.Visible = false;
			// 
			// registrationDateDataGridViewTextBoxColumn
			// 
			this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "Registration_Date";
			this.registrationDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
			this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
			this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
			this.registrationDateDataGridViewTextBoxColumn.Visible = false;
			// 
			// registrationTimeDataGridViewTextBoxColumn
			// 
			this.registrationTimeDataGridViewTextBoxColumn.DataPropertyName = "Registration_Time";
			this.registrationTimeDataGridViewTextBoxColumn.HeaderText = "زمان ثبت";
			this.registrationTimeDataGridViewTextBoxColumn.Name = "registrationTimeDataGridViewTextBoxColumn";
			this.registrationTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.registrationTimeDataGridViewTextBoxColumn.Visible = false;
			// 
			// userImageDataGridViewImageColumn
			// 
			this.userImageDataGridViewImageColumn.DataPropertyName = "User_Image";
			this.userImageDataGridViewImageColumn.HeaderText = "تصویر کاربر";
			this.userImageDataGridViewImageColumn.Name = "userImageDataGridViewImageColumn";
			this.userImageDataGridViewImageColumn.ReadOnly = true;
			this.userImageDataGridViewImageColumn.Visible = false;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(Models.User);
			// 
			// userSettingGroupBox
			// 
			this.userSettingGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.userSettingGroupBox.BorderRadius = 25;
			this.userSettingGroupBox.BorderThickness = 3;
			this.userSettingGroupBox.Controls.Add(this.userImagePictureBox);
			this.userSettingGroupBox.Controls.Add(this.activationUserLabel);
			this.userSettingGroupBox.Controls.Add(this.activationUserCheckBox);
			this.userSettingGroupBox.Controls.Add(this.usenamePanel);
			this.userSettingGroupBox.Controls.Add(this.usernameLabel);
			this.userSettingGroupBox.Controls.Add(this.accessLevelGroupBox);
			this.userSettingGroupBox.Controls.Add(this.updateButton);
			this.userSettingGroupBox.CustomBorderColor = System.Drawing.Color.Transparent;
			this.userSettingGroupBox.FillColor = System.Drawing.Color.Transparent;
			this.userSettingGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.userSettingGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.userSettingGroupBox.Location = new System.Drawing.Point(812, 107);
			this.userSettingGroupBox.Name = "userSettingGroupBox";
			this.userSettingGroupBox.ShadowDecoration.Parent = this.userSettingGroupBox;
			this.userSettingGroupBox.Size = new System.Drawing.Size(293, 357);
			this.userSettingGroupBox.TabIndex = 19;
			this.userSettingGroupBox.UseTransparentBackground = true;
			// 
			// activationUserLabel
			// 
			this.activationUserLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.activationUserLabel.AutoSize = true;
			this.activationUserLabel.Font = new System.Drawing.Font("IRANSans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.activationUserLabel.ForeColor = System.Drawing.Color.White;
			this.activationUserLabel.Location = new System.Drawing.Point(155, 275);
			this.activationUserLabel.Name = "activationUserLabel";
			this.activationUserLabel.Size = new System.Drawing.Size(83, 19);
			this.activationUserLabel.TabIndex = 23;
			this.activationUserLabel.Text = "فعال بودن کاربر";
			this.activationUserLabel.Click += new System.EventHandler(this.ActivationUserLabel_Click);
			// 
			// activationUserCheckBox
			// 
			this.activationUserCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.activationUserCheckBox.Animated = true;
			this.activationUserCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.activationUserCheckBox.CheckedState.BorderRadius = 2;
			this.activationUserCheckBox.CheckedState.BorderThickness = 0;
			this.activationUserCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.activationUserCheckBox.CheckedState.Parent = this.activationUserCheckBox;
			this.activationUserCheckBox.Location = new System.Drawing.Point(245, 274);
			this.activationUserCheckBox.Name = "activationUserCheckBox";
			this.activationUserCheckBox.ShadowDecoration.Parent = this.activationUserCheckBox;
			this.activationUserCheckBox.Size = new System.Drawing.Size(20, 20);
			this.activationUserCheckBox.TabIndex = 22;
			this.activationUserCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.activationUserCheckBox.UncheckedState.BorderRadius = 2;
			this.activationUserCheckBox.UncheckedState.BorderThickness = 0;
			this.activationUserCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.activationUserCheckBox.UncheckedState.Parent = this.activationUserCheckBox;
			this.activationUserCheckBox.CheckedChanged += new System.EventHandler(this.ActivationUserCheckBox_CheckedChanged);
			// 
			// usenamePanel
			// 
			this.usenamePanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.usenamePanel.BackColor = System.Drawing.Color.Black;
			this.usenamePanel.ForeColor = System.Drawing.Color.DimGray;
			this.usenamePanel.Location = new System.Drawing.Point(44, 151);
			this.usenamePanel.Name = "usenamePanel";
			this.usenamePanel.Size = new System.Drawing.Size(205, 3);
			this.usenamePanel.TabIndex = 18;
			// 
			// usernameLabel
			// 
			this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
			this.usernameLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.usernameLabel.ForeColor = System.Drawing.Color.LightGray;
			this.usernameLabel.Location = new System.Drawing.Point(46, 129);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.usernameLabel.Size = new System.Drawing.Size(200, 20);
			this.usernameLabel.TabIndex = 19;
			this.usernameLabel.Text = "شناسه کاربری";
			this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.usernameLabel.TextChanged += new System.EventHandler(this.UsernameLabel_TextChanged);
			// 
			// accessLevelGroupBox
			// 
			this.accessLevelGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.accessLevelGroupBox.BorderRadius = 15;
			this.accessLevelGroupBox.Controls.Add(this.simpleUserLabel);
			this.accessLevelGroupBox.Controls.Add(this.simpleUserRadioButton);
			this.accessLevelGroupBox.Controls.Add(this.assistanceLabel);
			this.accessLevelGroupBox.Controls.Add(this.assistanceRadioButton);
			this.accessLevelGroupBox.Controls.Add(this.employeedLabel);
			this.accessLevelGroupBox.Controls.Add(this.employeedRadioButton);
			this.accessLevelGroupBox.Controls.Add(this.administratorLabel);
			this.accessLevelGroupBox.Controls.Add(this.administratorRadioButton);
			this.accessLevelGroupBox.CustomBorderColor = System.Drawing.Color.Purple;
			this.accessLevelGroupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
			this.accessLevelGroupBox.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.accessLevelGroupBox.ForeColor = System.Drawing.Color.White;
			this.accessLevelGroupBox.Location = new System.Drawing.Point(16, 168);
			this.accessLevelGroupBox.Name = "accessLevelGroupBox";
			this.accessLevelGroupBox.ShadowDecoration.Parent = this.accessLevelGroupBox;
			this.accessLevelGroupBox.Size = new System.Drawing.Size(261, 98);
			this.accessLevelGroupBox.TabIndex = 21;
			this.accessLevelGroupBox.Text = "سطح دسترسی";
			this.accessLevelGroupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.accessLevelGroupBox.TextOffset = new System.Drawing.Point(0, -5);
			// 
			// simpleUserLabel
			// 
			this.simpleUserLabel.AutoSize = true;
			this.simpleUserLabel.BackColor = System.Drawing.Color.Transparent;
			this.simpleUserLabel.ForeColor = System.Drawing.Color.Black;
			this.simpleUserLabel.Location = new System.Drawing.Point(28, 69);
			this.simpleUserLabel.Name = "simpleUserLabel";
			this.simpleUserLabel.Size = new System.Drawing.Size(51, 17);
			this.simpleUserLabel.TabIndex = 10;
			this.simpleUserLabel.Text = "کاربر ساده";
			this.simpleUserLabel.Click += new System.EventHandler(this.SimpleUserLabel_Click);
			// 
			// simpleUserRadioButton
			// 
			this.simpleUserRadioButton.BackColor = System.Drawing.Color.Transparent;
			this.simpleUserRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.simpleUserRadioButton.CheckedState.BorderThickness = 0;
			this.simpleUserRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.simpleUserRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
			this.simpleUserRadioButton.CheckedState.Parent = this.simpleUserRadioButton;
			this.simpleUserRadioButton.Location = new System.Drawing.Point(85, 67);
			this.simpleUserRadioButton.Name = "simpleUserRadioButton";
			this.simpleUserRadioButton.ShadowDecoration.Parent = this.simpleUserRadioButton;
			this.simpleUserRadioButton.Size = new System.Drawing.Size(20, 20);
			this.simpleUserRadioButton.TabIndex = 9;
			this.simpleUserRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.simpleUserRadioButton.UncheckedState.BorderThickness = 2;
			this.simpleUserRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			this.simpleUserRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			this.simpleUserRadioButton.UncheckedState.Parent = this.simpleUserRadioButton;
			this.simpleUserRadioButton.UseTransparentBackground = true;
			this.simpleUserRadioButton.CheckedChanged += new System.EventHandler(this.SimpleUserRadioButton_CheckedChanged);
			// 
			// assistanceLabel
			// 
			this.assistanceLabel.AutoSize = true;
			this.assistanceLabel.BackColor = System.Drawing.Color.Transparent;
			this.assistanceLabel.ForeColor = System.Drawing.Color.Black;
			this.assistanceLabel.Location = new System.Drawing.Point(38, 39);
			this.assistanceLabel.Name = "assistanceLabel";
			this.assistanceLabel.Size = new System.Drawing.Size(41, 17);
			this.assistanceLabel.TabIndex = 8;
			this.assistanceLabel.Text = "معاونت";
			this.assistanceLabel.Click += new System.EventHandler(this.AssistanceLabel_Click);
			// 
			// assistanceRadioButton
			// 
			this.assistanceRadioButton.BackColor = System.Drawing.Color.Transparent;
			this.assistanceRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.assistanceRadioButton.CheckedState.BorderThickness = 0;
			this.assistanceRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.assistanceRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
			this.assistanceRadioButton.CheckedState.Parent = this.assistanceRadioButton;
			this.assistanceRadioButton.Location = new System.Drawing.Point(85, 37);
			this.assistanceRadioButton.Name = "assistanceRadioButton";
			this.assistanceRadioButton.ShadowDecoration.Parent = this.assistanceRadioButton;
			this.assistanceRadioButton.Size = new System.Drawing.Size(20, 20);
			this.assistanceRadioButton.TabIndex = 7;
			this.assistanceRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.assistanceRadioButton.UncheckedState.BorderThickness = 2;
			this.assistanceRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			this.assistanceRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			this.assistanceRadioButton.UncheckedState.Parent = this.assistanceRadioButton;
			this.assistanceRadioButton.UseTransparentBackground = true;
			this.assistanceRadioButton.CheckedChanged += new System.EventHandler(this.AssistanceRadioButton_CheckedChanged);
			// 
			// employeedLabel
			// 
			this.employeedLabel.AutoSize = true;
			this.employeedLabel.BackColor = System.Drawing.Color.Transparent;
			this.employeedLabel.ForeColor = System.Drawing.Color.Black;
			this.employeedLabel.Location = new System.Drawing.Point(172, 69);
			this.employeedLabel.Name = "employeedLabel";
			this.employeedLabel.Size = new System.Drawing.Size(35, 17);
			this.employeedLabel.TabIndex = 6;
			this.employeedLabel.Text = "کارمند";
			this.employeedLabel.Click += new System.EventHandler(this.EmployeedLabel_Click);
			// 
			// employeedRadioButton
			// 
			this.employeedRadioButton.BackColor = System.Drawing.Color.Transparent;
			this.employeedRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.employeedRadioButton.CheckedState.BorderThickness = 0;
			this.employeedRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.employeedRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
			this.employeedRadioButton.CheckedState.Parent = this.employeedRadioButton;
			this.employeedRadioButton.Location = new System.Drawing.Point(213, 67);
			this.employeedRadioButton.Name = "employeedRadioButton";
			this.employeedRadioButton.ShadowDecoration.Parent = this.employeedRadioButton;
			this.employeedRadioButton.Size = new System.Drawing.Size(20, 20);
			this.employeedRadioButton.TabIndex = 5;
			this.employeedRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.employeedRadioButton.UncheckedState.BorderThickness = 2;
			this.employeedRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			this.employeedRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			this.employeedRadioButton.UncheckedState.Parent = this.employeedRadioButton;
			this.employeedRadioButton.UseTransparentBackground = true;
			this.employeedRadioButton.CheckedChanged += new System.EventHandler(this.EmployeedRadioButton_CheckedChanged);
			// 
			// administratorLabel
			// 
			this.administratorLabel.AutoSize = true;
			this.administratorLabel.BackColor = System.Drawing.Color.Transparent;
			this.administratorLabel.ForeColor = System.Drawing.Color.Black;
			this.administratorLabel.Location = new System.Drawing.Point(163, 39);
			this.administratorLabel.Name = "administratorLabel";
			this.administratorLabel.Size = new System.Drawing.Size(44, 17);
			this.administratorLabel.TabIndex = 4;
			this.administratorLabel.Text = "مدیریت";
			this.administratorLabel.Click += new System.EventHandler(this.AdministratorLabel_Click);
			// 
			// administratorRadioButton
			// 
			this.administratorRadioButton.BackColor = System.Drawing.Color.Transparent;
			this.administratorRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.administratorRadioButton.CheckedState.BorderThickness = 0;
			this.administratorRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.administratorRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
			this.administratorRadioButton.CheckedState.Parent = this.administratorRadioButton;
			this.administratorRadioButton.Location = new System.Drawing.Point(213, 37);
			this.administratorRadioButton.Name = "administratorRadioButton";
			this.administratorRadioButton.ShadowDecoration.Parent = this.administratorRadioButton;
			this.administratorRadioButton.Size = new System.Drawing.Size(20, 20);
			this.administratorRadioButton.TabIndex = 0;
			this.administratorRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.administratorRadioButton.UncheckedState.BorderThickness = 2;
			this.administratorRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			this.administratorRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			this.administratorRadioButton.UncheckedState.Parent = this.administratorRadioButton;
			this.administratorRadioButton.UseTransparentBackground = true;
			this.administratorRadioButton.Click += new System.EventHandler(this.AdministratorRadioButton_CheckedChanged);
			// 
			// updateButton
			// 
			this.updateButton.Animated = true;
			this.updateButton.BorderRadius = 5;
			this.updateButton.CheckedState.Parent = this.updateButton;
			this.updateButton.CustomImages.Parent = this.updateButton;
			this.updateButton.Enabled = false;
			this.updateButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.updateButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateButton.ForeColor = System.Drawing.Color.White;
			this.updateButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.updateButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.updateButton.HoverState.Parent = this.updateButton;
			this.updateButton.Location = new System.Drawing.Point(71, 308);
			this.updateButton.Name = "updateButton";
			this.updateButton.PressedColor = System.Drawing.Color.White;
			this.updateButton.ShadowDecoration.Parent = this.updateButton;
			this.updateButton.Size = new System.Drawing.Size(150, 35);
			this.updateButton.TabIndex = 26;
			this.updateButton.Text = "به روز رسانی";
			this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// userListDataGridViewElipse
			// 
			this.userListDataGridViewElipse.BorderRadius = 20;
			this.userListDataGridViewElipse.TargetControl = this.userListDataGridView;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Font = new System.Drawing.Font("IRANSansX", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteUserToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.contextMenuStrip.Size = new System.Drawing.Size(146, 26);
			// 
			// deleteUserToolStripMenuItem
			// 
			this.deleteUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteUserToolStripMenuItem.Image")));
			this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
			this.deleteUserToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.deleteUserToolStripMenuItem.Text = "حذف کاربر";
			this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.DeleteUserToolStripMenuItem_Click);
			// 
			// userImagePictureBox
			// 
			this.userImagePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userImagePictureBox.BackgroundImage")));
			this.userImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.userImagePictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
			this.userImagePictureBox.BorderColor1 = System.Drawing.Color.RoyalBlue;
			this.userImagePictureBox.BorderColor2 = System.Drawing.Color.HotPink;
			this.userImagePictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			this.userImagePictureBox.BordrSize = 2;
			this.userImagePictureBox.GradiantAngle = 50F;
			this.userImagePictureBox.Location = new System.Drawing.Point(96, 10);
			this.userImagePictureBox.Name = "userImagePictureBox";
			this.userImagePictureBox.Size = new System.Drawing.Size(100, 100);
			this.userImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userImagePictureBox.TabIndex = 1;
			this.userImagePictureBox.TabStop = false;
			// 
			// UserSettingUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.Controls.Add(this.userSettingGroupBox);
			this.Controls.Add(this.dataGridViewPanel);
			this.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximumSize = new System.Drawing.Size(1125, 570);
			this.MinimumSize = new System.Drawing.Size(1125, 570);
			this.Name = "UserSettingUC";
			this.Size = new System.Drawing.Size(1125, 570);
			this.Load += new System.EventHandler(this.UserSettingUC_Load);
			this.dataGridViewPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.userListDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.userSettingGroupBox.ResumeLayout(false);
			this.userSettingGroupBox.PerformLayout();
			this.accessLevelGroupBox.ResumeLayout(false);
			this.accessLevelGroupBox.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel dataGridViewPanel;
		private Guna.UI2.WinForms.Guna2DataGridView userListDataGridView;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accessLevelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn editDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn editTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn userImageDataGridViewImageColumn;
		private Guna.UI2.WinForms.Guna2GroupBox userSettingGroupBox;
		private Mbb.Windows.Forms.Label activationUserLabel;
		private Guna.UI2.WinForms.Guna2CustomCheckBox activationUserCheckBox;
		private Mbb.Windows.Forms.Panel usenamePanel;
		private Mbb.Windows.Forms.Label usernameLabel;
		private Guna.UI2.WinForms.Guna2GroupBox accessLevelGroupBox;
		private Mbb.Windows.Forms.Label simpleUserLabel;
		private Guna.UI2.WinForms.Guna2CustomRadioButton simpleUserRadioButton;
		private Mbb.Windows.Forms.Label assistanceLabel;
		private Guna.UI2.WinForms.Guna2CustomRadioButton assistanceRadioButton;
		private Mbb.Windows.Forms.Label employeedLabel;
		private Guna.UI2.WinForms.Guna2CustomRadioButton employeedRadioButton;
		private Mbb.Windows.Forms.Label administratorLabel;
		private Guna.UI2.WinForms.Guna2CustomRadioButton administratorRadioButton;
		private Guna.UI2.WinForms.Guna2GradientButton updateButton;
		private Guna.UI2.WinForms.Guna2Elipse userListDataGridViewElipse;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
		private Mbb.Windows.Forms.CircularPictureBox userImagePictureBox;
	}
}


namespace Financial_Form
{
	partial class AuditingForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditingForm));
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.accountsPayableDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.accountsPayableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.accountsPayableDataGridViewElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.amountPaidTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SelectObject = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sellerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountPayableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.remaininigAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Account_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paymentButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.searchTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.sellerNameLabel = new Mbb.Windows.Forms.Label();
			this.sellerNameRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
			this.registerDateRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
			this.registerDateLabel = new Mbb.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.accountsPayableBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BorderColor = System.Drawing.Color.Indigo;
			this.mainPanel.BorderRadius = 15;
			this.mainPanel.BorderThickness = 3;
			this.mainPanel.Controls.Add(this.registerDateRadioButton);
			this.mainPanel.Controls.Add(this.sellerNameRadioButton);
			this.mainPanel.Controls.Add(this.sellerNameLabel);
			this.mainPanel.Controls.Add(this.searchTextBox);
			this.mainPanel.Controls.Add(this.paymentButton);
			this.mainPanel.Controls.Add(this.amountPaidTextBox);
			this.mainPanel.Controls.Add(this.accountsPayableDataGridView);
			this.mainPanel.Controls.Add(this.registerDateLabel);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
			this.mainPanel.Size = new System.Drawing.Size(1150, 650);
			this.mainPanel.TabIndex = 1;
			// 
			// accountsPayableDataGridView
			// 
			this.accountsPayableDataGridView.AllowUserToAddRows = false;
			this.accountsPayableDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
			this.accountsPayableDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.accountsPayableDataGridView.AutoGenerateColumns = false;
			this.accountsPayableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.accountsPayableDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.accountsPayableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.accountsPayableDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.accountsPayableDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.accountsPayableDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansXFaNum", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.accountsPayableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.accountsPayableDataGridView.ColumnHeadersHeight = 35;
			this.accountsPayableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.accountsPayableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.SelectObject,
            this.descriptionDataGridViewTextBoxColumn,
            this.sellerNameDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn,
            this.amountPayableDataGridViewTextBoxColumn,
            this.remaininigAmountDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.Account_Status});
			this.accountsPayableDataGridView.DataSource = this.accountsPayableBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.accountsPayableDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.accountsPayableDataGridView.EnableHeadersVisualStyles = false;
			this.accountsPayableDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
			this.accountsPayableDataGridView.Location = new System.Drawing.Point(15, 53);
			this.accountsPayableDataGridView.Name = "accountsPayableDataGridView";
			this.accountsPayableDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.accountsPayableDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.accountsPayableDataGridView.RowHeadersVisible = false;
			this.accountsPayableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.accountsPayableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.accountsPayableDataGridView.Size = new System.Drawing.Size(1120, 491);
			this.accountsPayableDataGridView.TabIndex = 0;
			this.accountsPayableDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
			this.accountsPayableDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
			this.accountsPayableDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.accountsPayableDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.accountsPayableDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.accountsPayableDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.accountsPayableDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.accountsPayableDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
			this.accountsPayableDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
			this.accountsPayableDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.accountsPayableDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.accountsPayableDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.accountsPayableDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.accountsPayableDataGridView.ThemeStyle.HeaderStyle.Height = 35;
			this.accountsPayableDataGridView.ThemeStyle.ReadOnly = false;
			this.accountsPayableDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
			this.accountsPayableDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.accountsPayableDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.accountsPayableDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.accountsPayableDataGridView.ThemeStyle.RowsStyle.Height = 22;
			this.accountsPayableDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
			this.accountsPayableDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// accountsPayableBindingSource
			// 
			this.accountsPayableBindingSource.DataSource = typeof(Models.AccountsPayable);
			// 
			// accountsPayableDataGridViewElipse
			// 
			this.accountsPayableDataGridViewElipse.BorderRadius = 15;
			this.accountsPayableDataGridViewElipse.TargetControl = this.accountsPayableDataGridView;
			// 
			// amountPaidTextBox
			// 
			this.amountPaidTextBox.AcceptsReturn = false;
			this.amountPaidTextBox.AcceptsTab = false;
			this.amountPaidTextBox.AnimationSpeed = 200;
			this.amountPaidTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.amountPaidTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.amountPaidTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.amountPaidTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("amountPaidTextBox.BackgroundImage")));
			this.amountPaidTextBox.BorderColorActive = System.Drawing.Color.RoyalBlue;
			this.amountPaidTextBox.BorderColorDisabled = System.Drawing.Color.Empty;
			this.amountPaidTextBox.BorderColorHover = System.Drawing.Color.Empty;
			this.amountPaidTextBox.BorderColorIdle = System.Drawing.Color.Silver;
			this.amountPaidTextBox.BorderRadius = 1;
			this.amountPaidTextBox.BorderThickness = 3;
			this.amountPaidTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.amountPaidTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.amountPaidTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.amountPaidTextBox.DefaultText = "";
			this.amountPaidTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.amountPaidTextBox.ForeColor = System.Drawing.Color.White;
			this.amountPaidTextBox.HideSelection = true;
			this.amountPaidTextBox.IconLeft = null;
			this.amountPaidTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.amountPaidTextBox.IconPadding = 10;
			this.amountPaidTextBox.IconRight = null;
			this.amountPaidTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.amountPaidTextBox.Lines = new string[0];
			this.amountPaidTextBox.Location = new System.Drawing.Point(15, 550);
			this.amountPaidTextBox.MaximumSize = new System.Drawing.Size(350, 45);
			this.amountPaidTextBox.MaxLength = 32767;
			this.amountPaidTextBox.MinimumSize = new System.Drawing.Size(350, 45);
			this.amountPaidTextBox.Modified = false;
			this.amountPaidTextBox.Multiline = false;
			this.amountPaidTextBox.Name = "amountPaidTextBox";
			stateProperties5.BorderColor = System.Drawing.Color.RoyalBlue;
			stateProperties5.FillColor = System.Drawing.Color.Empty;
			stateProperties5.ForeColor = System.Drawing.Color.Empty;
			stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.amountPaidTextBox.OnActiveState = stateProperties5;
			stateProperties6.BorderColor = System.Drawing.Color.Empty;
			stateProperties6.FillColor = System.Drawing.Color.White;
			stateProperties6.ForeColor = System.Drawing.Color.Empty;
			stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.amountPaidTextBox.OnDisabledState = stateProperties6;
			stateProperties7.BorderColor = System.Drawing.Color.Empty;
			stateProperties7.FillColor = System.Drawing.Color.Empty;
			stateProperties7.ForeColor = System.Drawing.Color.Empty;
			stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.amountPaidTextBox.OnHoverState = stateProperties7;
			stateProperties8.BorderColor = System.Drawing.Color.Silver;
			stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties8.ForeColor = System.Drawing.Color.White;
			stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.amountPaidTextBox.OnIdleState = stateProperties8;
			this.amountPaidTextBox.PasswordChar = '\0';
			this.amountPaidTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.amountPaidTextBox.PlaceholderText = "مبلغ پرداختی...";
			this.amountPaidTextBox.ReadOnly = false;
			this.amountPaidTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.amountPaidTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.amountPaidTextBox.SelectedText = "";
			this.amountPaidTextBox.SelectionLength = 0;
			this.amountPaidTextBox.SelectionStart = 0;
			this.amountPaidTextBox.ShortcutsEnabled = true;
			this.amountPaidTextBox.Size = new System.Drawing.Size(350, 45);
			this.amountPaidTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.amountPaidTextBox.TabIndex = 1;
			this.amountPaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.amountPaidTextBox.TextMarginBottom = 0;
			this.amountPaidTextBox.TextMarginLeft = 5;
			this.amountPaidTextBox.TextMarginTop = 0;
			this.amountPaidTextBox.TextPlaceholder = "مبلغ پرداختی...";
			this.amountPaidTextBox.UseSystemPasswordChar = false;
			this.amountPaidTextBox.WordWrap = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.FillWeight = 50F;
			this.idDataGridViewTextBoxColumn.HeaderText = "ردیف";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// SelectObject
			// 
			this.SelectObject.FillWeight = 30F;
			this.SelectObject.HeaderText = "انتخاب";
			this.SelectObject.Name = "SelectObject";
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.FillWeight = 200F;
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "توضیحات";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			// 
			// sellerNameDataGridViewTextBoxColumn
			// 
			this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "Seller_Name";
			this.sellerNameDataGridViewTextBoxColumn.HeaderText = "نام فروشنده";
			this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
			// 
			// amountPaidDataGridViewTextBoxColumn
			// 
			this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_Paid";
			this.amountPaidDataGridViewTextBoxColumn.HeaderText = "مبلغ پرداخت شده";
			this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
			// 
			// amountPayableDataGridViewTextBoxColumn
			// 
			this.amountPayableDataGridViewTextBoxColumn.DataPropertyName = "Amount_Payable";
			this.amountPayableDataGridViewTextBoxColumn.HeaderText = "مبلغ قابل پرداخت";
			this.amountPayableDataGridViewTextBoxColumn.Name = "amountPayableDataGridViewTextBoxColumn";
			// 
			// remaininigAmountDataGridViewTextBoxColumn
			// 
			this.remaininigAmountDataGridViewTextBoxColumn.DataPropertyName = "Remaininig_Amount";
			this.remaininigAmountDataGridViewTextBoxColumn.HeaderText = "مبلغ باقیمانده";
			this.remaininigAmountDataGridViewTextBoxColumn.Name = "remaininigAmountDataGridViewTextBoxColumn";
			// 
			// registrationDateDataGridViewTextBoxColumn
			// 
			this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "Registration_Date";
			this.registrationDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
			this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
			// 
			// Account_Status
			// 
			this.Account_Status.HeaderText = "وضعیت";
			this.Account_Status.Name = "Account_Status";
			// 
			// paymentButton
			// 
			this.paymentButton.Animated = true;
			this.paymentButton.BorderColor = System.Drawing.Color.Empty;
			this.paymentButton.BorderRadius = 5;
			this.paymentButton.CheckedState.Parent = this.paymentButton;
			this.paymentButton.CustomImages.Parent = this.paymentButton;
			this.paymentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.paymentButton.FillColor2 = System.Drawing.Color.Indigo;
			this.paymentButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paymentButton.ForeColor = System.Drawing.Color.White;
			this.paymentButton.HoverState.FillColor = System.Drawing.Color.Indigo;
			this.paymentButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.paymentButton.HoverState.Parent = this.paymentButton;
			this.paymentButton.Location = new System.Drawing.Point(15, 600);
			this.paymentButton.Name = "paymentButton";
			this.paymentButton.PressedColor = System.Drawing.Color.White;
			this.paymentButton.ShadowDecoration.Parent = this.paymentButton;
			this.paymentButton.Size = new System.Drawing.Size(150, 35);
			this.paymentButton.TabIndex = 2;
			this.paymentButton.Text = "پرداخت";
			// 
			// searchTextBox
			// 
			this.searchTextBox.AcceptsReturn = false;
			this.searchTextBox.AcceptsTab = false;
			this.searchTextBox.AnimationSpeed = 200;
			this.searchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.searchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.searchTextBox.BackColor = System.Drawing.Color.Transparent;
			this.searchTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTextBox.BackgroundImage")));
			this.searchTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.searchTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.searchTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.searchTextBox.BorderColorIdle = System.Drawing.Color.Silver;
			this.searchTextBox.BorderRadius = 30;
			this.searchTextBox.BorderThickness = 2;
			this.searchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.searchTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.searchTextBox.DefaultText = "";
			this.searchTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.searchTextBox.HideSelection = true;
			this.searchTextBox.IconLeft = null;
			this.searchTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchTextBox.IconPadding = 8;
			this.searchTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("searchTextBox.IconRight")));
			this.searchTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchTextBox.Lines = new string[0];
			this.searchTextBox.Location = new System.Drawing.Point(535, 12);
			this.searchTextBox.MaxLength = 32767;
			this.searchTextBox.MinimumSize = new System.Drawing.Size(100, 35);
			this.searchTextBox.Modified = false;
			this.searchTextBox.Multiline = false;
			this.searchTextBox.Name = "searchTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.searchTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Silver;
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties4.ForeColor = System.Drawing.Color.Empty;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchTextBox.OnIdleState = stateProperties4;
			this.searchTextBox.PasswordChar = '\0';
			this.searchTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.searchTextBox.PlaceholderText = "جستجو (نام فروشنده، تاریخ)...";
			this.searchTextBox.ReadOnly = false;
			this.searchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.searchTextBox.SelectedText = "";
			this.searchTextBox.SelectionLength = 0;
			this.searchTextBox.SelectionStart = 0;
			this.searchTextBox.ShortcutsEnabled = true;
			this.searchTextBox.Size = new System.Drawing.Size(600, 35);
			this.searchTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
			this.searchTextBox.TabIndex = 3;
			this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.searchTextBox.TextMarginBottom = 0;
			this.searchTextBox.TextMarginLeft = 5;
			this.searchTextBox.TextMarginTop = 0;
			this.searchTextBox.TextPlaceholder = "جستجو (نام فروشنده، تاریخ)...";
			this.searchTextBox.UseSystemPasswordChar = false;
			this.searchTextBox.WordWrap = true;
			// 
			// sellerNameLabel
			// 
			this.sellerNameLabel.AutoSize = true;
			this.sellerNameLabel.ForeColor = System.Drawing.Color.White;
			this.sellerNameLabel.Location = new System.Drawing.Point(213, 21);
			this.sellerNameLabel.Name = "sellerNameLabel";
			this.sellerNameLabel.Size = new System.Drawing.Size(145, 17);
			this.sellerNameLabel.TabIndex = 6;
			this.sellerNameLabel.Text = "جستجو بر اساس نام  فروشنده";
			this.sellerNameLabel.Click += new System.EventHandler(this.sellerNameLabel_Click);
			// 
			// sellerNameRadioButton
			// 
			this.sellerNameRadioButton.BackColor = System.Drawing.Color.Transparent;
			this.sellerNameRadioButton.Checked = true;
			this.sellerNameRadioButton.CheckedState.BorderColor = System.Drawing.Color.Silver;
			this.sellerNameRadioButton.CheckedState.BorderThickness = 0;
			this.sellerNameRadioButton.CheckedState.FillColor = System.Drawing.Color.Silver;
			this.sellerNameRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
			this.sellerNameRadioButton.CheckedState.Parent = this.sellerNameRadioButton;
			this.sellerNameRadioButton.Location = new System.Drawing.Point(357, 19);
			this.sellerNameRadioButton.Name = "sellerNameRadioButton";
			this.sellerNameRadioButton.ShadowDecoration.Parent = this.sellerNameRadioButton;
			this.sellerNameRadioButton.Size = new System.Drawing.Size(20, 20);
			this.sellerNameRadioButton.TabIndex = 7;
			this.sellerNameRadioButton.UncheckedState.BorderColor = System.Drawing.Color.Silver;
			this.sellerNameRadioButton.UncheckedState.BorderThickness = 2;
			this.sellerNameRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			this.sellerNameRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			this.sellerNameRadioButton.UncheckedState.Parent = this.sellerNameRadioButton;
			this.sellerNameRadioButton.CheckedChanged += new System.EventHandler(this.sellerNameRadioButton_CheckedChanged);
			// 
			// registerDateRadioButton
			// 
			this.registerDateRadioButton.BackColor = System.Drawing.Color.Transparent;
			this.registerDateRadioButton.CheckedState.BorderColor = System.Drawing.Color.Silver;
			this.registerDateRadioButton.CheckedState.BorderThickness = 0;
			this.registerDateRadioButton.CheckedState.FillColor = System.Drawing.Color.Silver;
			this.registerDateRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
			this.registerDateRadioButton.CheckedState.Parent = this.registerDateRadioButton;
			this.registerDateRadioButton.Location = new System.Drawing.Point(140, 19);
			this.registerDateRadioButton.Name = "registerDateRadioButton";
			this.registerDateRadioButton.ShadowDecoration.Parent = this.registerDateRadioButton;
			this.registerDateRadioButton.Size = new System.Drawing.Size(20, 20);
			this.registerDateRadioButton.TabIndex = 8;
			this.registerDateRadioButton.UncheckedState.BorderColor = System.Drawing.Color.Silver;
			this.registerDateRadioButton.UncheckedState.BorderThickness = 2;
			this.registerDateRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			this.registerDateRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			this.registerDateRadioButton.UncheckedState.Parent = this.registerDateRadioButton;
			this.registerDateRadioButton.CheckedChanged += new System.EventHandler(this.registerDateRadioButton_CheckedChanged);
			// 
			// registerDateLabel
			// 
			this.registerDateLabel.AutoSize = true;
			this.registerDateLabel.ForeColor = System.Drawing.Color.White;
			this.registerDateLabel.Location = new System.Drawing.Point(29, 21);
			this.registerDateLabel.Name = "registerDateLabel";
			this.registerDateLabel.Size = new System.Drawing.Size(111, 17);
			this.registerDateLabel.TabIndex = 9;
			this.registerDateLabel.Text = "جستجو بر اساس تاریخ";
			this.registerDateLabel.Click += new System.EventHandler(this.registerDateLabel_Click);
			// 
			// AuditingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(1150, 650);
			this.Controls.Add(this.mainPanel);
			this.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "AuditingForm";
			this.Text = "AuditingForm";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.accountsPayableBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel mainPanel;
		private Guna.UI2.WinForms.Guna2DataGridView accountsPayableDataGridView;
		private System.Windows.Forms.BindingSource accountsPayableBindingSource;
		private Guna.UI2.WinForms.Guna2Elipse accountsPayableDataGridViewElipse;
		private Guna.UI2.WinForms.Guna2GradientButton paymentButton;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox amountPaidTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn SelectObject;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountPayableDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn remaininigAmountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Account_Status;
		private Guna.UI2.WinForms.Guna2CustomRadioButton registerDateRadioButton;
		private Guna.UI2.WinForms.Guna2CustomRadioButton sellerNameRadioButton;
		private Mbb.Windows.Forms.Label sellerNameLabel;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchTextBox;
		private Mbb.Windows.Forms.Label registerDateLabel;
	}
}

namespace Client_Forms
{
	partial class ClientFinancialSituationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientFinancialSituationForm));
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.financialSituationLabel = new System.Windows.Forms.Label();
			this.totalAmountUnderlinePanel = new System.Windows.Forms.Panel();
			this.totalAmountTextBox = new System.Windows.Forms.Label();
			this.paymentButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.searchClientTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.listFinantioalClientDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Select_Item = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountPayableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.remaininigAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.finantialSituationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.taxPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.listFinancialClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.listFinantioalClientDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.listFinancialClientBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BorderColor = System.Drawing.Color.Indigo;
			this.mainPanel.BorderRadius = 15;
			this.mainPanel.BorderThickness = 3;
			this.mainPanel.Controls.Add(this.financialSituationLabel);
			this.mainPanel.Controls.Add(this.totalAmountUnderlinePanel);
			this.mainPanel.Controls.Add(this.totalAmountTextBox);
			this.mainPanel.Controls.Add(this.paymentButton);
			this.mainPanel.Controls.Add(this.searchClientTextBox);
			this.mainPanel.Controls.Add(this.listFinantioalClientDataGridView);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
			this.mainPanel.Size = new System.Drawing.Size(1150, 650);
			this.mainPanel.TabIndex = 1;
			// 
			// financialSituationLabel
			// 
			this.financialSituationLabel.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.financialSituationLabel.ForeColor = System.Drawing.Color.White;
			this.financialSituationLabel.Location = new System.Drawing.Point(368, 518);
			this.financialSituationLabel.Name = "financialSituationLabel";
			this.financialSituationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.financialSituationLabel.Size = new System.Drawing.Size(123, 25);
			this.financialSituationLabel.TabIndex = 5;
			this.financialSituationLabel.Text = "(وضعیت مالی)";
			this.financialSituationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// totalAmountUnderlinePanel
			// 
			this.totalAmountUnderlinePanel.BackColor = System.Drawing.Color.DimGray;
			this.totalAmountUnderlinePanel.Location = new System.Drawing.Point(12, 553);
			this.totalAmountUnderlinePanel.Name = "totalAmountUnderlinePanel";
			this.totalAmountUnderlinePanel.Size = new System.Drawing.Size(350, 3);
			this.totalAmountUnderlinePanel.TabIndex = 4;
			// 
			// totalAmountTextBox
			// 
			this.totalAmountTextBox.Font = new System.Drawing.Font("IRANSansXFaNum", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.totalAmountTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.totalAmountTextBox.Location = new System.Drawing.Point(12, 505);
			this.totalAmountTextBox.Name = "totalAmountTextBox";
			this.totalAmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.totalAmountTextBox.Size = new System.Drawing.Size(350, 45);
			this.totalAmountTextBox.TabIndex = 3;
			this.totalAmountTextBox.Text = "0 تومان";
			this.totalAmountTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.totalAmountTextBox.TextChanged += new System.EventHandler(this.TotalAmountTextBox_TextChanged);
			// 
			// paymentButton
			// 
			this.paymentButton.Animated = true;
			this.paymentButton.BorderRadius = 5;
			this.paymentButton.CheckedState.Parent = this.paymentButton;
			this.paymentButton.CustomImages.Parent = this.paymentButton;
			this.paymentButton.Enabled = false;
			this.paymentButton.FillColor = System.Drawing.Color.RoyalBlue;
			this.paymentButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.paymentButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paymentButton.ForeColor = System.Drawing.Color.White;
			this.paymentButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.paymentButton.HoverState.FillColor2 = System.Drawing.Color.RoyalBlue;
			this.paymentButton.HoverState.Parent = this.paymentButton;
			this.paymentButton.Image = ((System.Drawing.Image)(resources.GetObject("paymentButton.Image")));
			this.paymentButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.paymentButton.ImageOffset = new System.Drawing.Point(25, 0);
			this.paymentButton.ImageSize = new System.Drawing.Size(25, 25);
			this.paymentButton.Location = new System.Drawing.Point(12, 603);
			this.paymentButton.Name = "paymentButton";
			this.paymentButton.PressedColor = System.Drawing.Color.White;
			this.paymentButton.ShadowDecoration.Parent = this.paymentButton;
			this.paymentButton.Size = new System.Drawing.Size(180, 35);
			this.paymentButton.TabIndex = 2;
			this.paymentButton.Text = "پرداخت";
			this.paymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
			// 
			// searchClientTextBox
			// 
			this.searchClientTextBox.AcceptsReturn = false;
			this.searchClientTextBox.AcceptsTab = false;
			this.searchClientTextBox.AnimationSpeed = 200;
			this.searchClientTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.searchClientTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.searchClientTextBox.BackColor = System.Drawing.Color.Transparent;
			this.searchClientTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchClientTextBox.BackgroundImage")));
			this.searchClientTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.searchClientTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.searchClientTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.searchClientTextBox.BorderColorIdle = System.Drawing.Color.Gray;
			this.searchClientTextBox.BorderRadius = 25;
			this.searchClientTextBox.BorderThickness = 2;
			this.searchClientTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.searchClientTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.searchClientTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.searchClientTextBox.DefaultText = "";
			this.searchClientTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.searchClientTextBox.HideSelection = true;
			this.searchClientTextBox.IconLeft = null;
			this.searchClientTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchClientTextBox.IconPadding = 7;
			this.searchClientTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("searchClientTextBox.IconRight")));
			this.searchClientTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchClientTextBox.Lines = new string[0];
			this.searchClientTextBox.Location = new System.Drawing.Point(538, 12);
			this.searchClientTextBox.MaxLength = 32767;
			this.searchClientTextBox.MinimumSize = new System.Drawing.Size(100, 35);
			this.searchClientTextBox.Modified = false;
			this.searchClientTextBox.Multiline = false;
			this.searchClientTextBox.Name = "searchClientTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchClientTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.searchClientTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchClientTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Gray;
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties4.ForeColor = System.Drawing.Color.Empty;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchClientTextBox.OnIdleState = stateProperties4;
			this.searchClientTextBox.PasswordChar = '\0';
			this.searchClientTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.searchClientTextBox.PlaceholderText = "جستجو (شماره پلاک، شماره تماس)";
			this.searchClientTextBox.ReadOnly = false;
			this.searchClientTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.searchClientTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.searchClientTextBox.SelectedText = "";
			this.searchClientTextBox.SelectionLength = 0;
			this.searchClientTextBox.SelectionStart = 0;
			this.searchClientTextBox.ShortcutsEnabled = true;
			this.searchClientTextBox.Size = new System.Drawing.Size(600, 39);
			this.searchClientTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
			this.searchClientTextBox.TabIndex = 1;
			this.searchClientTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.searchClientTextBox.TextMarginBottom = 0;
			this.searchClientTextBox.TextMarginLeft = 8;
			this.searchClientTextBox.TextMarginTop = 0;
			this.searchClientTextBox.TextPlaceholder = "جستجو (شماره پلاک، شماره تماس)";
			this.searchClientTextBox.UseSystemPasswordChar = false;
			this.searchClientTextBox.WordWrap = true;
			this.searchClientTextBox.TextChange += new System.EventHandler(this.SearchClientTextBox_TextChange);
			this.searchClientTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchClientTextBox_KeyPress);
			this.searchClientTextBox.Enter += new System.EventHandler(this.SearchClientTextBox_Enter);
			// 
			// listFinantioalClientDataGridView
			// 
			this.listFinantioalClientDataGridView.AllowUserToAddRows = false;
			this.listFinantioalClientDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
			this.listFinantioalClientDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.listFinantioalClientDataGridView.AutoGenerateColumns = false;
			this.listFinantioalClientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.listFinantioalClientDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.listFinantioalClientDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listFinantioalClientDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listFinantioalClientDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.listFinantioalClientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.listFinantioalClientDataGridView.ColumnHeadersHeight = 30;
			this.listFinantioalClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.listFinantioalClientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Select_Item,
            this.clientNameDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn,
            this.amountPayableDataGridViewTextBoxColumn,
            this.remaininigAmountDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.finantialSituationDataGridViewTextBoxColumn,
            this.registrationTimeDataGridViewTextBoxColumn,
            this.taxPercentDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.licensePlateDataGridViewTextBoxColumn});
			this.listFinantioalClientDataGridView.DataSource = this.listFinancialClientBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.listFinantioalClientDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.listFinantioalClientDataGridView.EnableHeadersVisualStyles = false;
			this.listFinantioalClientDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
			this.listFinantioalClientDataGridView.Location = new System.Drawing.Point(12, 53);
			this.listFinantioalClientDataGridView.Name = "listFinantioalClientDataGridView";
			this.listFinantioalClientDataGridView.ReadOnly = true;
			this.listFinantioalClientDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.listFinantioalClientDataGridView.RowHeadersVisible = false;
			this.listFinantioalClientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listFinantioalClientDataGridView.Size = new System.Drawing.Size(1126, 440);
			this.listFinantioalClientDataGridView.TabIndex = 0;
			this.listFinantioalClientDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
			this.listFinantioalClientDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
			this.listFinantioalClientDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.listFinantioalClientDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.listFinantioalClientDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.listFinantioalClientDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.listFinantioalClientDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.listFinantioalClientDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
			this.listFinantioalClientDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
			this.listFinantioalClientDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.listFinantioalClientDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.listFinantioalClientDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.listFinantioalClientDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.listFinantioalClientDataGridView.ThemeStyle.HeaderStyle.Height = 30;
			this.listFinantioalClientDataGridView.ThemeStyle.ReadOnly = true;
			this.listFinantioalClientDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
			this.listFinantioalClientDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listFinantioalClientDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.listFinantioalClientDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.listFinantioalClientDataGridView.ThemeStyle.RowsStyle.Height = 22;
			this.listFinantioalClientDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
			this.listFinantioalClientDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.listFinantioalClientDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListFinantioalClientDataGridView_CellClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.FillWeight = 50F;
			this.idDataGridViewTextBoxColumn.HeaderText = "ردیف";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Select_Item
			// 
			this.Select_Item.FillWeight = 50F;
			this.Select_Item.HeaderText = "انتخاب مورد";
			this.Select_Item.Name = "Select_Item";
			this.Select_Item.ReadOnly = true;
			// 
			// clientNameDataGridViewTextBoxColumn
			// 
			this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
			this.clientNameDataGridViewTextBoxColumn.FillWeight = 150F;
			this.clientNameDataGridViewTextBoxColumn.HeaderText = "نام مشتری";
			this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
			this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// amountPaidDataGridViewTextBoxColumn
			// 
			this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_Paid";
			this.amountPaidDataGridViewTextBoxColumn.FillWeight = 125F;
			this.amountPaidDataGridViewTextBoxColumn.HeaderText = "مبلغ پرداخت شده";
			this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
			this.amountPaidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// amountPayableDataGridViewTextBoxColumn
			// 
			this.amountPayableDataGridViewTextBoxColumn.DataPropertyName = "Amount_Payable";
			this.amountPayableDataGridViewTextBoxColumn.FillWeight = 125F;
			this.amountPayableDataGridViewTextBoxColumn.HeaderText = "مبلغ قابل پرداخت";
			this.amountPayableDataGridViewTextBoxColumn.Name = "amountPayableDataGridViewTextBoxColumn";
			this.amountPayableDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// remaininigAmountDataGridViewTextBoxColumn
			// 
			this.remaininigAmountDataGridViewTextBoxColumn.DataPropertyName = "Remaininig_Amount";
			this.remaininigAmountDataGridViewTextBoxColumn.FillWeight = 125F;
			this.remaininigAmountDataGridViewTextBoxColumn.HeaderText = "مبلغ باقیمانده";
			this.remaininigAmountDataGridViewTextBoxColumn.Name = "remaininigAmountDataGridViewTextBoxColumn";
			this.remaininigAmountDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// registrationDateDataGridViewTextBoxColumn
			// 
			this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "Registration_Date";
			this.registrationDateDataGridViewTextBoxColumn.FillWeight = 75F;
			this.registrationDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
			this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
			this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// finantialSituationDataGridViewTextBoxColumn
			// 
			this.finantialSituationDataGridViewTextBoxColumn.DataPropertyName = "Finantial_Situation";
			this.finantialSituationDataGridViewTextBoxColumn.FillWeight = 75F;
			this.finantialSituationDataGridViewTextBoxColumn.HeaderText = "وضعیت مالی";
			this.finantialSituationDataGridViewTextBoxColumn.Name = "finantialSituationDataGridViewTextBoxColumn";
			this.finantialSituationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// registrationTimeDataGridViewTextBoxColumn
			// 
			this.registrationTimeDataGridViewTextBoxColumn.DataPropertyName = "Registration_Time";
			this.registrationTimeDataGridViewTextBoxColumn.HeaderText = "زمان ثبت";
			this.registrationTimeDataGridViewTextBoxColumn.Name = "registrationTimeDataGridViewTextBoxColumn";
			this.registrationTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.registrationTimeDataGridViewTextBoxColumn.Visible = false;
			// 
			// taxPercentDataGridViewTextBoxColumn
			// 
			this.taxPercentDataGridViewTextBoxColumn.DataPropertyName = "Tax_Percent";
			this.taxPercentDataGridViewTextBoxColumn.HeaderText = "درصد مالیات";
			this.taxPercentDataGridViewTextBoxColumn.Name = "taxPercentDataGridViewTextBoxColumn";
			this.taxPercentDataGridViewTextBoxColumn.ReadOnly = true;
			this.taxPercentDataGridViewTextBoxColumn.Visible = false;
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "شماره تماس";
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
			this.phoneNumberDataGridViewTextBoxColumn.Visible = false;
			// 
			// licensePlateDataGridViewTextBoxColumn
			// 
			this.licensePlateDataGridViewTextBoxColumn.DataPropertyName = "License_Plate";
			this.licensePlateDataGridViewTextBoxColumn.HeaderText = "پلاک وسیله نقیله";
			this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
			this.licensePlateDataGridViewTextBoxColumn.ReadOnly = true;
			this.licensePlateDataGridViewTextBoxColumn.Visible = false;
			// 
			// listFinancialClientBindingSource
			// 
			this.listFinancialClientBindingSource.DataSource = typeof(Models.ListFinancialClient);
			// 
			// ClientFinancialSituationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(1150, 650);
			this.Controls.Add(this.mainPanel);
			this.Name = "ClientFinancialSituationForm";
			this.Text = "ClientFinancialSituationForm";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.listFinantioalClientDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.listFinancialClientBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel mainPanel;
		private Guna.UI2.WinForms.Guna2DataGridView listFinantioalClientDataGridView;
		private System.Windows.Forms.BindingSource listFinancialClientBindingSource;
		private Guna.UI2.WinForms.Guna2GradientButton paymentButton;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchClientTextBox;
		private System.Windows.Forms.Label financialSituationLabel;
		private System.Windows.Forms.Panel totalAmountUnderlinePanel;
		private System.Windows.Forms.Label totalAmountTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Select_Item;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountPayableDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn remaininigAmountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn finantialSituationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn taxPercentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
	}
}
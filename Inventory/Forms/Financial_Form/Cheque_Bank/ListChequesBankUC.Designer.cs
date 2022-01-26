
namespace Chequa_Bank
{
	partial class ListChequasBankUC
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListChequasBankUC));
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.listChequasDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Select_Chequa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.payToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataReceiptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountNumberPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountNumberReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusChequaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chequaSectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchSerialChequeTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.chequePaymentButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.listChequasDataGridViewElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			((System.ComponentModel.ISupportInitialize)(this.listChequasDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chequaSectionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// listChequasDataGridView
			// 
			this.listChequasDataGridView.AllowUserToAddRows = false;
			this.listChequasDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansFaNum", 8F);
			this.listChequasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.listChequasDataGridView.AutoGenerateColumns = false;
			this.listChequasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.listChequasDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.listChequasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listChequasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listChequasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.listChequasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.listChequasDataGridView.ColumnHeadersHeight = 35;
			this.listChequasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.listChequasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Select_Chequa,
            this.payToDataGridViewTextBoxColumn,
            this.dataReceiptDataGridViewTextBoxColumn,
            this.amountNumberPaidDataGridViewTextBoxColumn,
            this.amountNumberReceivedDataGridViewTextBoxColumn,
            this.statusChequaDataGridViewTextBoxColumn});
			this.listChequasDataGridView.DataSource = this.chequaSectionBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.listChequasDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.listChequasDataGridView.EnableHeadersVisualStyles = false;
			this.listChequasDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
			this.listChequasDataGridView.Location = new System.Drawing.Point(10, 57);
			this.listChequasDataGridView.Name = "listChequasDataGridView";
			this.listChequasDataGridView.ReadOnly = true;
			this.listChequasDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.listChequasDataGridView.RowHeadersVisible = false;
			this.listChequasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.listChequasDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.listChequasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listChequasDataGridView.Size = new System.Drawing.Size(1090, 450);
			this.listChequasDataGridView.TabIndex = 0;
			this.listChequasDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
			this.listChequasDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
			this.listChequasDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("IRANSansFaNum", 8F);
			this.listChequasDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.listChequasDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.listChequasDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.listChequasDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.listChequasDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
			this.listChequasDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
			this.listChequasDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.listChequasDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.listChequasDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.listChequasDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.listChequasDataGridView.ThemeStyle.HeaderStyle.Height = 35;
			this.listChequasDataGridView.ThemeStyle.ReadOnly = true;
			this.listChequasDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
			this.listChequasDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listChequasDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.listChequasDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.listChequasDataGridView.ThemeStyle.RowsStyle.Height = 22;
			this.listChequasDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
			this.listChequasDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.FillWeight = 50F;
			this.idDataGridViewTextBoxColumn.HeaderText = "ردیف";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Select_Chequa
			// 
			this.Select_Chequa.DataPropertyName = "Amount_Number";
			this.Select_Chequa.FillWeight = 50F;
			this.Select_Chequa.HeaderText = "انتخاب چک";
			this.Select_Chequa.Name = "Select_Chequa";
			this.Select_Chequa.ReadOnly = true;
			// 
			// payToDataGridViewTextBoxColumn
			// 
			this.payToDataGridViewTextBoxColumn.DataPropertyName = "Pay_To";
			this.payToDataGridViewTextBoxColumn.HeaderText = "در وجه";
			this.payToDataGridViewTextBoxColumn.Name = "payToDataGridViewTextBoxColumn";
			this.payToDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataReceiptDataGridViewTextBoxColumn
			// 
			this.dataReceiptDataGridViewTextBoxColumn.DataPropertyName = "Data_Receipt";
			this.dataReceiptDataGridViewTextBoxColumn.FillWeight = 75F;
			this.dataReceiptDataGridViewTextBoxColumn.HeaderText = "تاریخ وصول";
			this.dataReceiptDataGridViewTextBoxColumn.Name = "dataReceiptDataGridViewTextBoxColumn";
			this.dataReceiptDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// amountNumberPaidDataGridViewTextBoxColumn
			// 
			this.amountNumberPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_Number_Paid";
			this.amountNumberPaidDataGridViewTextBoxColumn.HeaderText = "مبلغ پرداختی به عدد";
			this.amountNumberPaidDataGridViewTextBoxColumn.Name = "amountNumberPaidDataGridViewTextBoxColumn";
			this.amountNumberPaidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// amountNumberReceivedDataGridViewTextBoxColumn
			// 
			this.amountNumberReceivedDataGridViewTextBoxColumn.DataPropertyName = "Amount_Number_Received";
			this.amountNumberReceivedDataGridViewTextBoxColumn.HeaderText = "مبلغ دریافتی به عدد";
			this.amountNumberReceivedDataGridViewTextBoxColumn.Name = "amountNumberReceivedDataGridViewTextBoxColumn";
			this.amountNumberReceivedDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// statusChequaDataGridViewTextBoxColumn
			// 
			this.statusChequaDataGridViewTextBoxColumn.DataPropertyName = "Status_Chequa";
			this.statusChequaDataGridViewTextBoxColumn.FillWeight = 75F;
			this.statusChequaDataGridViewTextBoxColumn.HeaderText = "وضعیت چک";
			this.statusChequaDataGridViewTextBoxColumn.Name = "statusChequaDataGridViewTextBoxColumn";
			this.statusChequaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// chequaSectionBindingSource
			// 
			this.chequaSectionBindingSource.DataSource = typeof(Models.ChequeSection);
			// 
			// searchSerialChequeTextBox
			// 
			this.searchSerialChequeTextBox.AcceptsReturn = false;
			this.searchSerialChequeTextBox.AcceptsTab = false;
			this.searchSerialChequeTextBox.AnimationSpeed = 200;
			this.searchSerialChequeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.searchSerialChequeTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.searchSerialChequeTextBox.BackColor = System.Drawing.Color.Transparent;
			this.searchSerialChequeTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchSerialChequeTextBox.BackgroundImage")));
			this.searchSerialChequeTextBox.BorderColorActive = System.Drawing.Color.RoyalBlue;
			this.searchSerialChequeTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.searchSerialChequeTextBox.BorderColorHover = System.Drawing.Color.BlueViolet;
			this.searchSerialChequeTextBox.BorderColorIdle = System.Drawing.Color.Gray;
			this.searchSerialChequeTextBox.BorderRadius = 25;
			this.searchSerialChequeTextBox.BorderThickness = 2;
			this.searchSerialChequeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.searchSerialChequeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.searchSerialChequeTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.searchSerialChequeTextBox.DefaultText = "";
			this.searchSerialChequeTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.searchSerialChequeTextBox.ForeColor = System.Drawing.Color.White;
			this.searchSerialChequeTextBox.HideSelection = true;
			this.searchSerialChequeTextBox.IconLeft = null;
			this.searchSerialChequeTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchSerialChequeTextBox.IconPadding = 7;
			this.searchSerialChequeTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("searchSerialChequeTextBox.IconRight")));
			this.searchSerialChequeTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchSerialChequeTextBox.Lines = new string[0];
			this.searchSerialChequeTextBox.Location = new System.Drawing.Point(235, 8);
			this.searchSerialChequeTextBox.MaximumSize = new System.Drawing.Size(865, 40);
			this.searchSerialChequeTextBox.MaxLength = 32767;
			this.searchSerialChequeTextBox.MinimumSize = new System.Drawing.Size(865, 40);
			this.searchSerialChequeTextBox.Modified = false;
			this.searchSerialChequeTextBox.Multiline = false;
			this.searchSerialChequeTextBox.Name = "searchSerialChequeTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.RoyalBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchSerialChequeTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.searchSerialChequeTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.BlueViolet;
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchSerialChequeTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Gray;
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties4.ForeColor = System.Drawing.Color.White;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchSerialChequeTextBox.OnIdleState = stateProperties4;
			this.searchSerialChequeTextBox.PasswordChar = '\0';
			this.searchSerialChequeTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
			this.searchSerialChequeTextBox.PlaceholderText = "شماره 16 رقمی صیاد";
			this.searchSerialChequeTextBox.ReadOnly = false;
			this.searchSerialChequeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.searchSerialChequeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.searchSerialChequeTextBox.SelectedText = "";
			this.searchSerialChequeTextBox.SelectionLength = 0;
			this.searchSerialChequeTextBox.SelectionStart = 0;
			this.searchSerialChequeTextBox.ShortcutsEnabled = true;
			this.searchSerialChequeTextBox.Size = new System.Drawing.Size(865, 40);
			this.searchSerialChequeTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
			this.searchSerialChequeTextBox.TabIndex = 1;
			this.searchSerialChequeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.searchSerialChequeTextBox.TextMarginBottom = 0;
			this.searchSerialChequeTextBox.TextMarginLeft = 5;
			this.searchSerialChequeTextBox.TextMarginTop = 0;
			this.searchSerialChequeTextBox.TextPlaceholder = "شماره 16 رقمی صیاد";
			this.searchSerialChequeTextBox.UseSystemPasswordChar = false;
			this.searchSerialChequeTextBox.WordWrap = true;
			this.searchSerialChequeTextBox.TextChange += new System.EventHandler(this.SearchSerialChequeTextBox_TextChange);
			this.searchSerialChequeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchSerialChequeTextBox_KeyPress);
			this.searchSerialChequeTextBox.Enter += new System.EventHandler(this.SearchSerialChequeTextBox_Enter);
			// 
			// chequePaymentButton
			// 
			this.chequePaymentButton.Animated = true;
			this.chequePaymentButton.BorderRadius = 5;
			this.chequePaymentButton.CheckedState.Parent = this.chequePaymentButton;
			this.chequePaymentButton.CustomImages.Parent = this.chequePaymentButton;
			this.chequePaymentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.chequePaymentButton.FillColor2 = System.Drawing.Color.Indigo;
			this.chequePaymentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.chequePaymentButton.ForeColor = System.Drawing.Color.White;
			this.chequePaymentButton.HoverState.FillColor = System.Drawing.Color.Indigo;
			this.chequePaymentButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.chequePaymentButton.HoverState.Parent = this.chequePaymentButton;
			this.chequePaymentButton.Location = new System.Drawing.Point(26, 8);
			this.chequePaymentButton.Name = "chequePaymentButton";
			this.chequePaymentButton.PressedColor = System.Drawing.Color.White;
			this.chequePaymentButton.ShadowDecoration.Parent = this.chequePaymentButton;
			this.chequePaymentButton.Size = new System.Drawing.Size(180, 40);
			this.chequePaymentButton.TabIndex = 2;
			this.chequePaymentButton.Text = "پرداخت چک";
			this.chequePaymentButton.Click += new System.EventHandler(this.ChequePaymentButton_Click);
			// 
			// listChequasDataGridViewElipse
			// 
			this.listChequasDataGridViewElipse.BorderRadius = 15;
			this.listChequasDataGridViewElipse.TargetControl = this.listChequasDataGridView;
			// 
			// ListChequasBankUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.Controls.Add(this.chequePaymentButton);
			this.Controls.Add(this.searchSerialChequeTextBox);
			this.Controls.Add(this.listChequasDataGridView);
			this.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ListChequasBankUC";
			this.Size = new System.Drawing.Size(1110, 520);
			((System.ComponentModel.ISupportInitialize)(this.listChequasDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chequaSectionBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2DataGridView listChequasDataGridView;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchSerialChequeTextBox;
		private System.Windows.Forms.BindingSource chequaSectionBindingSource;
		private Guna.UI2.WinForms.Guna2GradientButton chequePaymentButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Select_Chequa;
		private System.Windows.Forms.DataGridViewTextBoxColumn payToDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberChequaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataReceiptDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountNumberPaidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountNumberReceivedDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusChequaDataGridViewTextBoxColumn;
		private Guna.UI2.WinForms.Guna2Elipse listChequasDataGridViewElipse;
	}
}

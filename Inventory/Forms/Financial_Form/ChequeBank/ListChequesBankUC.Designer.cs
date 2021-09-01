
namespace ChequaBank
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
			this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.chequaSectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Select_Chequa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.payToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberChequaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataReceiptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountNumberPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountWordsPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountWordsReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountNumberReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nationalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusChequaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChequaPaymentButton = new Guna.UI2.WinForms.Guna2GradientButton();
			((System.ComponentModel.ISupportInitialize)(this.listChequasDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chequaSectionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// listChequasDataGridView
			// 
			this.listChequasDataGridView.AllowUserToAddRows = false;
			this.listChequasDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
			this.listChequasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.listChequasDataGridView.AutoGenerateColumns = false;
			this.listChequasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.listChequasDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.listChequasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listChequasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listChequasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.listChequasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.listChequasDataGridView.ColumnHeadersHeight = 30;
			this.listChequasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.listChequasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.idDataGridViewTextBoxColumn,
			this.Select_Chequa,
			this.payToDataGridViewTextBoxColumn,
			this.numberChequaDataGridViewTextBoxColumn,
			this.dataReceiptDataGridViewTextBoxColumn,
			this.amountNumberPaidDataGridViewTextBoxColumn,
			this.amountWordsPaidDataGridViewTextBoxColumn,
			this.amountWordsReceivedDataGridViewTextBoxColumn,
			this.amountNumberReceivedDataGridViewTextBoxColumn,
			this.nationalCodeDataGridViewTextBoxColumn,
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
			this.listChequasDataGridView.Location = new System.Drawing.Point(10, 51);
			this.listChequasDataGridView.Name = "listChequasDataGridView";
			this.listChequasDataGridView.ReadOnly = true;
			this.listChequasDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.listChequasDataGridView.RowHeadersVisible = false;
			this.listChequasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.listChequasDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.listChequasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listChequasDataGridView.Size = new System.Drawing.Size(1090, 460);
			this.listChequasDataGridView.TabIndex = 0;
			this.listChequasDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
			this.listChequasDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
			this.listChequasDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
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
			this.listChequasDataGridView.ThemeStyle.HeaderStyle.Height = 30;
			this.listChequasDataGridView.ThemeStyle.ReadOnly = true;
			this.listChequasDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
			this.listChequasDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listChequasDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.listChequasDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.listChequasDataGridView.ThemeStyle.RowsStyle.Height = 22;
			this.listChequasDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
			this.listChequasDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// bunifuTextBox1
			// 
			this.bunifuTextBox1.AcceptsReturn = false;
			this.bunifuTextBox1.AcceptsTab = false;
			this.bunifuTextBox1.AnimationSpeed = 200;
			this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
			this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.RoyalBlue;
			this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.BlueViolet;
			this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Gray;
			this.bunifuTextBox1.BorderRadius = 25;
			this.bunifuTextBox1.BorderThickness = 2;
			this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.bunifuTextBox1.DefaultText = "";
			this.bunifuTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.bunifuTextBox1.ForeColor = System.Drawing.Color.White;
			this.bunifuTextBox1.HideSelection = true;
			this.bunifuTextBox1.IconLeft = null;
			this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuTextBox1.IconPadding = 7;
			this.bunifuTextBox1.IconRight = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.IconRight")));
			this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuTextBox1.Lines = new string[0];
			this.bunifuTextBox1.Location = new System.Drawing.Point(235, 8);
			this.bunifuTextBox1.MaxLength = 32767;
			this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
			this.bunifuTextBox1.Modified = false;
			this.bunifuTextBox1.Multiline = false;
			this.bunifuTextBox1.Name = "bunifuTextBox1";
			stateProperties1.BorderColor = System.Drawing.Color.RoyalBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.bunifuTextBox1.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.bunifuTextBox1.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.BlueViolet;
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.bunifuTextBox1.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Gray;
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties4.ForeColor = System.Drawing.Color.White;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.bunifuTextBox1.OnIdleState = stateProperties4;
			this.bunifuTextBox1.PasswordChar = '\0';
			this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.DimGray;
			this.bunifuTextBox1.PlaceholderText = "شماره چک";
			this.bunifuTextBox1.ReadOnly = false;
			this.bunifuTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.bunifuTextBox1.SelectedText = "";
			this.bunifuTextBox1.SelectionLength = 0;
			this.bunifuTextBox1.SelectionStart = 0;
			this.bunifuTextBox1.ShortcutsEnabled = true;
			this.bunifuTextBox1.Size = new System.Drawing.Size(865, 35);
			this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
			this.bunifuTextBox1.TabIndex = 1;
			this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.bunifuTextBox1.TextMarginBottom = 0;
			this.bunifuTextBox1.TextMarginLeft = 5;
			this.bunifuTextBox1.TextMarginTop = 0;
			this.bunifuTextBox1.TextPlaceholder = "شماره چک";
			this.bunifuTextBox1.UseSystemPasswordChar = false;
			this.bunifuTextBox1.WordWrap = true;
			// 
			// chequaSectionBindingSource
			// 
			this.chequaSectionBindingSource.DataSource = typeof(Models.ChequeSection);
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
			// numberChequaDataGridViewTextBoxColumn
			// 
			this.numberChequaDataGridViewTextBoxColumn.DataPropertyName = "Number_Chequa";
			this.numberChequaDataGridViewTextBoxColumn.HeaderText = "شماره چک";
			this.numberChequaDataGridViewTextBoxColumn.Name = "numberChequaDataGridViewTextBoxColumn";
			this.numberChequaDataGridViewTextBoxColumn.ReadOnly = true;
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
			// amountWordsPaidDataGridViewTextBoxColumn
			// 
			this.amountWordsPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_Words_Paid";
			this.amountWordsPaidDataGridViewTextBoxColumn.HeaderText = "مبلغ پرداختی به حروف";
			this.amountWordsPaidDataGridViewTextBoxColumn.Name = "amountWordsPaidDataGridViewTextBoxColumn";
			this.amountWordsPaidDataGridViewTextBoxColumn.ReadOnly = true;
			this.amountWordsPaidDataGridViewTextBoxColumn.Visible = false;
			// 
			// amountWordsReceivedDataGridViewTextBoxColumn
			// 
			this.amountWordsReceivedDataGridViewTextBoxColumn.DataPropertyName = "Amount_Words_Received";
			this.amountWordsReceivedDataGridViewTextBoxColumn.HeaderText = "مبلغ دریافتی به حروف";
			this.amountWordsReceivedDataGridViewTextBoxColumn.Name = "amountWordsReceivedDataGridViewTextBoxColumn";
			this.amountWordsReceivedDataGridViewTextBoxColumn.ReadOnly = true;
			this.amountWordsReceivedDataGridViewTextBoxColumn.Visible = false;
			// 
			// amountNumberReceivedDataGridViewTextBoxColumn
			// 
			this.amountNumberReceivedDataGridViewTextBoxColumn.DataPropertyName = "Amount_Number_Received";
			this.amountNumberReceivedDataGridViewTextBoxColumn.HeaderText = "مبلغ دریافتی به عدد";
			this.amountNumberReceivedDataGridViewTextBoxColumn.Name = "amountNumberReceivedDataGridViewTextBoxColumn";
			this.amountNumberReceivedDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nationalCodeDataGridViewTextBoxColumn
			// 
			this.nationalCodeDataGridViewTextBoxColumn.DataPropertyName = "National_Code";
			this.nationalCodeDataGridViewTextBoxColumn.HeaderText = "شناسه ملی";
			this.nationalCodeDataGridViewTextBoxColumn.Name = "nationalCodeDataGridViewTextBoxColumn";
			this.nationalCodeDataGridViewTextBoxColumn.ReadOnly = true;
			this.nationalCodeDataGridViewTextBoxColumn.Visible = false;
			// 
			// statusChequaDataGridViewTextBoxColumn
			// 
			this.statusChequaDataGridViewTextBoxColumn.DataPropertyName = "Status_Chequa";
			this.statusChequaDataGridViewTextBoxColumn.FillWeight = 75F;
			this.statusChequaDataGridViewTextBoxColumn.HeaderText = "وضعیت چک";
			this.statusChequaDataGridViewTextBoxColumn.Name = "statusChequaDataGridViewTextBoxColumn";
			this.statusChequaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// ChequaPaymentButton
			// 
			this.ChequaPaymentButton.Animated = true;
			this.ChequaPaymentButton.BorderRadius = 5;
			this.ChequaPaymentButton.CheckedState.Parent = this.ChequaPaymentButton;
			this.ChequaPaymentButton.CustomImages.Parent = this.ChequaPaymentButton;
			this.ChequaPaymentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.ChequaPaymentButton.FillColor2 = System.Drawing.Color.Indigo;
			this.ChequaPaymentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ChequaPaymentButton.ForeColor = System.Drawing.Color.White;
			this.ChequaPaymentButton.HoverState.FillColor = System.Drawing.Color.Indigo;
			this.ChequaPaymentButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.ChequaPaymentButton.HoverState.Parent = this.ChequaPaymentButton;
			this.ChequaPaymentButton.Location = new System.Drawing.Point(26, 5);
			this.ChequaPaymentButton.Name = "ChequaPaymentButton";
			this.ChequaPaymentButton.PressedColor = System.Drawing.Color.White;
			this.ChequaPaymentButton.ShadowDecoration.Parent = this.ChequaPaymentButton;
			this.ChequaPaymentButton.Size = new System.Drawing.Size(180, 40);
			this.ChequaPaymentButton.TabIndex = 2;
			this.ChequaPaymentButton.Text = "پرداخت چک";
			// 
			// ListChequasBankUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.Controls.Add(this.ChequaPaymentButton);
			this.Controls.Add(this.bunifuTextBox1);
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
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Select_Chequa;
		private System.Windows.Forms.DataGridViewTextBoxColumn payToDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberChequaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataReceiptDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountNumberPaidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountWordsPaidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountWordsReceivedDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountNumberReceivedDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nationalCodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusChequaDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource chequaSectionBindingSource;
		private Guna.UI2.WinForms.Guna2GradientButton ChequaPaymentButton;
	}
}

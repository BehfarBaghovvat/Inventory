﻿
namespace Inventory_Forms
{
	partial class InvoiceForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.invoiceDataGridViewElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.listWareDataGridView = new System.Windows.Forms.DataGridView();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.printInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.amountPaymentTextBox = new Mbb.Windows.Forms.Label();
			this.amountPaymentLabel = new Mbb.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.printButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.taxRateTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.remainingAmountTextBox = new Mbb.Windows.Forms.Label();
			this.totalSumPriceTextBox = new Mbb.Windows.Forms.Label();
			this.remainingAmountLabel = new Mbb.Windows.Forms.Label();
			this.taxRateLabel = new Mbb.Windows.Forms.Label();
			this.totalSumPriceLable = new Mbb.Windows.Forms.Label();
			this.carrierNameTextBox = new Mbb.Windows.Forms.Label();
			this.carrierNameLabel = new Mbb.Windows.Forms.Label();
			this.clientNameTextBox = new Mbb.Windows.Forms.Label();
			this.clientNameLabel = new Mbb.Windows.Forms.Label();
			this.dateSetInvoiceTextBox = new Mbb.Windows.Forms.Label();
			this.sellerNameTextBox = new Mbb.Windows.Forms.Label();
			this.dateSetInvoiceLabel = new Mbb.Windows.Forms.Label();
			this.sellerNameLabel = new Mbb.Windows.Forms.Label();
			this.topPanel = new Mbb.Windows.Forms.Panel();
			this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
			this.closeButton = new Guna.UI2.WinForms.Guna2Button();
			this.invoiceTitleLabel = new Mbb.Windows.Forms.Label();
			this.plusMarkLabel = new Mbb.Windows.Forms.Label();
			this.posPaymentTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.cashPaymentTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.paymentTypeGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
			this.debtorLabel = new Mbb.Windows.Forms.Label();
			this.cachAndPosPaymentLabel = new Mbb.Windows.Forms.Label();
			this.posPaymentLabel = new Mbb.Windows.Forms.Label();
			this.cachPaymentLabel = new Mbb.Windows.Forms.Label();
			this.debtorRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
			this.cachAndPosPaymentRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
			this.posPaymentRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
			this.cachPaymentRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
			this.cashRegisterButton = new Guna.UI2.WinForms.Guna2GradientButton();
			((System.ComponentModel.ISupportInitialize)(this.listWareDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.printInvoiceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.topPanel.SuspendLayout();
			this.paymentTypeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// invoiceDataGridViewElipse
			// 
			this.invoiceDataGridViewElipse.BorderRadius = 20;
			this.invoiceDataGridViewElipse.TargetControl = this.listWareDataGridView;
			// 
			// listWareDataGridView
			// 
			this.listWareDataGridView.AllowDrop = true;
			this.listWareDataGridView.AllowUserToAddRows = false;
			this.listWareDataGridView.AllowUserToDeleteRows = false;
			this.listWareDataGridView.AllowUserToResizeColumns = false;
			this.listWareDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansXFaNum", 8F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.listWareDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.listWareDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listWareDataGridView.AutoGenerateColumns = false;
			this.listWareDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.listWareDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.listWareDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listWareDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listWareDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.listWareDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.listWareDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.listWareDataGridView.ColumnHeadersHeight = 35;
			this.listWareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.listWareDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn,
            this.productUnitDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
			this.listWareDataGridView.DataSource = this.printInvoiceBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.listWareDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.listWareDataGridView.EnableHeadersVisualStyles = false;
			this.listWareDataGridView.Location = new System.Drawing.Point(10, 161);
			this.listWareDataGridView.Name = "listWareDataGridView";
			this.listWareDataGridView.ReadOnly = true;
			this.listWareDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.listWareDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.listWareDataGridView.RowHeadersVisible = false;
			this.listWareDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			this.listWareDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.listWareDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.listWareDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
			this.listWareDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F);
			this.listWareDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
			this.listWareDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.listWareDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
			this.listWareDataGridView.RowTemplate.Height = 25;
			this.listWareDataGridView.RowTemplate.ReadOnly = true;
			this.listWareDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.listWareDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listWareDataGridView.Size = new System.Drawing.Size(890, 140);
			this.listWareDataGridView.TabIndex = 15;
			this.listWareDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ListWareDataGridView_RowsAdded);
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
			this.productNameDataGridViewTextBoxColumn.HeaderText = "نام کالا";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productQuantityDataGridViewTextBoxColumn
			// 
			this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "Product_Quantity";
			this.productQuantityDataGridViewTextBoxColumn.HeaderText = "تعداد کالا";
			this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
			this.productQuantityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productUnitDataGridViewTextBoxColumn
			// 
			this.productUnitDataGridViewTextBoxColumn.DataPropertyName = "Product_Unit";
			this.productUnitDataGridViewTextBoxColumn.HeaderText = "واحد کالا";
			this.productUnitDataGridViewTextBoxColumn.Name = "productUnitDataGridViewTextBoxColumn";
			this.productUnitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productPriceDataGridViewTextBoxColumn
			// 
			this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "Product_Price";
			this.productPriceDataGridViewTextBoxColumn.HeaderText = "قیمت کالا";
			this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
			this.productPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// totalPriceDataGridViewTextBoxColumn
			// 
			this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "Total_Price";
			this.totalPriceDataGridViewTextBoxColumn.HeaderText = "جمع مبلغ";
			this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
			this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// printInvoiceBindingSource
			// 
			//this.printInvoiceBindingSource.DataSource = typeof(Inventory_Forms.PrintInvoice);
			// 
			// amountPaymentTextBox
			// 
			this.amountPaymentTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.amountPaymentTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.amountPaymentTextBox.Location = new System.Drawing.Point(21, 403);
			this.amountPaymentTextBox.MaximumSize = new System.Drawing.Size(300, 30);
			this.amountPaymentTextBox.MinimumSize = new System.Drawing.Size(300, 30);
			this.amountPaymentTextBox.Name = "amountPaymentTextBox";
			this.amountPaymentTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.amountPaymentTextBox.Size = new System.Drawing.Size(300, 30);
			this.amountPaymentTextBox.TabIndex = 20;
			this.amountPaymentTextBox.Text = "0 تومان";
			this.amountPaymentTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.amountPaymentTextBox.TextChanged += new System.EventHandler(this.AmountPaymentTextBox_TextChanged);
			// 
			// amountPaymentLabel
			// 
			this.amountPaymentLabel.AutoSize = true;
			this.amountPaymentLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.amountPaymentLabel.ForeColor = System.Drawing.Color.White;
			this.amountPaymentLabel.Location = new System.Drawing.Point(336, 407);
			this.amountPaymentLabel.Name = "amountPaymentLabel";
			this.amountPaymentLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.amountPaymentLabel.Size = new System.Drawing.Size(86, 22);
			this.amountPaymentLabel.TabIndex = 19;
			this.amountPaymentLabel.Text = "مبلغ پرداختی:";
			this.amountPaymentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 43);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(129, 101);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// printButton
			// 
			this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.printButton.Animated = true;
			this.printButton.BorderRadius = 5;
			this.printButton.CheckedState.Parent = this.printButton;
			this.printButton.CustomImages.Parent = this.printButton;
			this.printButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.printButton.FillColor2 = System.Drawing.Color.White;
			this.printButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.printButton.ForeColor = System.Drawing.Color.Black;
			this.printButton.HoverState.FillColor = System.Drawing.Color.White;
			this.printButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.printButton.HoverState.Parent = this.printButton;
			this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
			this.printButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.printButton.ImageOffset = new System.Drawing.Point(10, 0);
			this.printButton.Location = new System.Drawing.Point(694, 313);
			this.printButton.Name = "printButton";
			this.printButton.PressedColor = System.Drawing.Color.White;
			this.printButton.PressedDepth = 60;
			this.printButton.ShadowDecoration.Parent = this.printButton;
			this.printButton.Size = new System.Drawing.Size(180, 32);
			this.printButton.TabIndex = 24;
			this.printButton.Text = "چاپ صورت حساب";
			this.printButton.TextOffset = new System.Drawing.Point(5, 0);
			this.printButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.FillColor = System.Drawing.Color.White;
			this.guna2Panel1.Location = new System.Drawing.Point(15, 452);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(411, 3);
			this.guna2Panel1.TabIndex = 23;
			// 
			// taxRateTextBox
			// 
			this.taxRateTextBox.AcceptsReturn = false;
			this.taxRateTextBox.AcceptsTab = false;
			this.taxRateTextBox.AnimationSpeed = 200;
			this.taxRateTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.taxRateTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.taxRateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.taxRateTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taxRateTextBox.BackgroundImage")));
			this.taxRateTextBox.BorderColorActive = System.Drawing.Color.Empty;
			this.taxRateTextBox.BorderColorDisabled = System.Drawing.Color.Empty;
			this.taxRateTextBox.BorderColorHover = System.Drawing.Color.Empty;
			this.taxRateTextBox.BorderColorIdle = System.Drawing.Color.Empty;
			this.taxRateTextBox.BorderRadius = 1;
			this.taxRateTextBox.BorderThickness = 0;
			this.taxRateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.taxRateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.taxRateTextBox.DefaultFont = new System.Drawing.Font("IRANSansFaNum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.taxRateTextBox.DefaultText = "";
			this.taxRateTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.taxRateTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.taxRateTextBox.HideSelection = true;
			this.taxRateTextBox.IconLeft = null;
			this.taxRateTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.taxRateTextBox.IconPadding = 10;
			this.taxRateTextBox.IconRight = null;
			this.taxRateTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.taxRateTextBox.Lines = new string[0];
			this.taxRateTextBox.Location = new System.Drawing.Point(19, 360);
			this.taxRateTextBox.MaximumSize = new System.Drawing.Size(300, 30);
			this.taxRateTextBox.MaxLength = 32767;
			this.taxRateTextBox.MinimumSize = new System.Drawing.Size(300, 30);
			this.taxRateTextBox.Modified = false;
			this.taxRateTextBox.Multiline = false;
			this.taxRateTextBox.Name = "taxRateTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.Empty;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.taxRateTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.taxRateTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.Empty;
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.taxRateTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Empty;
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			stateProperties4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.taxRateTextBox.OnIdleState = stateProperties4;
			this.taxRateTextBox.PasswordChar = '\0';
			this.taxRateTextBox.PlaceholderForeColor = System.Drawing.Color.White;
			this.taxRateTextBox.PlaceholderText = "% 0";
			this.taxRateTextBox.ReadOnly = false;
			this.taxRateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.taxRateTextBox.SelectedText = "";
			this.taxRateTextBox.SelectionLength = 0;
			this.taxRateTextBox.SelectionStart = 0;
			this.taxRateTextBox.ShortcutsEnabled = true;
			this.taxRateTextBox.Size = new System.Drawing.Size(300, 30);
			this.taxRateTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.taxRateTextBox.TabIndex = 1;
			this.taxRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.taxRateTextBox.TextMarginBottom = 0;
			this.taxRateTextBox.TextMarginLeft = 0;
			this.taxRateTextBox.TextMarginTop = 2;
			this.taxRateTextBox.TextPlaceholder = "% 0";
			this.taxRateTextBox.UseSystemPasswordChar = false;
			this.taxRateTextBox.WordWrap = true;
			this.taxRateTextBox.TextChange += new System.EventHandler(this.TaxRateTextBox_TextChange);
			this.taxRateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TaxRateTextBox_KeyPress);
			this.taxRateTextBox.Enter += new System.EventHandler(this.TaxRateTextBox_Enter);
			// 
			// remainingAmountTextBox
			// 
			this.remainingAmountTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.remainingAmountTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.remainingAmountTextBox.Location = new System.Drawing.Point(19, 467);
			this.remainingAmountTextBox.MaximumSize = new System.Drawing.Size(300, 30);
			this.remainingAmountTextBox.MinimumSize = new System.Drawing.Size(300, 30);
			this.remainingAmountTextBox.Name = "remainingAmountTextBox";
			this.remainingAmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.remainingAmountTextBox.Size = new System.Drawing.Size(300, 30);
			this.remainingAmountTextBox.TabIndex = 22;
			this.remainingAmountTextBox.Text = "0 تومان";
			this.remainingAmountTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// totalSumPriceTextBox
			// 
			this.totalSumPriceTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.totalSumPriceTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.totalSumPriceTextBox.Location = new System.Drawing.Point(19, 317);
			this.totalSumPriceTextBox.Name = "totalSumPriceTextBox";
			this.totalSumPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.totalSumPriceTextBox.Size = new System.Drawing.Size(300, 30);
			this.totalSumPriceTextBox.TabIndex = 17;
			this.totalSumPriceTextBox.Text = "0 تومان";
			this.totalSumPriceTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.totalSumPriceTextBox.TextAlignChanged += new System.EventHandler(this.TotalSumPriceTextBox_TextAlignChanged);
			// 
			// remainingAmountLabel
			// 
			this.remainingAmountLabel.AutoSize = true;
			this.remainingAmountLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.remainingAmountLabel.ForeColor = System.Drawing.Color.White;
			this.remainingAmountLabel.Location = new System.Drawing.Point(336, 471);
			this.remainingAmountLabel.Name = "remainingAmountLabel";
			this.remainingAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.remainingAmountLabel.Size = new System.Drawing.Size(103, 22);
			this.remainingAmountLabel.TabIndex = 21;
			this.remainingAmountLabel.Text = "باقیمانده حساب:";
			this.remainingAmountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// taxRateLabel
			// 
			this.taxRateLabel.AutoSize = true;
			this.taxRateLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.taxRateLabel.ForeColor = System.Drawing.Color.White;
			this.taxRateLabel.Location = new System.Drawing.Point(336, 364);
			this.taxRateLabel.Name = "taxRateLabel";
			this.taxRateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.taxRateLabel.Size = new System.Drawing.Size(84, 22);
			this.taxRateLabel.TabIndex = 18;
			this.taxRateLabel.Text = "درصد مالیات:";
			this.taxRateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// totalSumPriceLable
			// 
			this.totalSumPriceLable.AutoSize = true;
			this.totalSumPriceLable.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.totalSumPriceLable.ForeColor = System.Drawing.Color.White;
			this.totalSumPriceLable.Location = new System.Drawing.Point(336, 321);
			this.totalSumPriceLable.Name = "totalSumPriceLable";
			this.totalSumPriceLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.totalSumPriceLable.Size = new System.Drawing.Size(99, 22);
			this.totalSumPriceLable.TabIndex = 16;
			this.totalSumPriceLable.Text = "جمع کل حساب:";
			this.totalSumPriceLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// carrierNameTextBox
			// 
			this.carrierNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.carrierNameTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.carrierNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.carrierNameTextBox.Location = new System.Drawing.Point(577, 130);
			this.carrierNameTextBox.Name = "carrierNameTextBox";
			this.carrierNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.carrierNameTextBox.Size = new System.Drawing.Size(214, 24);
			this.carrierNameTextBox.TabIndex = 13;
			this.carrierNameTextBox.Text = "نام حامل کالا";
			this.carrierNameTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// carrierNameLabel
			// 
			this.carrierNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.carrierNameLabel.AutoSize = true;
			this.carrierNameLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.carrierNameLabel.ForeColor = System.Drawing.Color.White;
			this.carrierNameLabel.Location = new System.Drawing.Point(800, 131);
			this.carrierNameLabel.Name = "carrierNameLabel";
			this.carrierNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.carrierNameLabel.Size = new System.Drawing.Size(86, 22);
			this.carrierNameLabel.TabIndex = 12;
			this.carrierNameLabel.Text = "نام حامل کالا:";
			// 
			// clientNameTextBox
			// 
			this.clientNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clientNameTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.clientNameTextBox.Location = new System.Drawing.Point(577, 96);
			this.clientNameTextBox.Name = "clientNameTextBox";
			this.clientNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.clientNameTextBox.Size = new System.Drawing.Size(214, 24);
			this.clientNameTextBox.TabIndex = 11;
			this.clientNameTextBox.Text = "نام مشتری";
			this.clientNameTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// clientNameLabel
			// 
			this.clientNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clientNameLabel.AutoSize = true;
			this.clientNameLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientNameLabel.ForeColor = System.Drawing.Color.White;
			this.clientNameLabel.Location = new System.Drawing.Point(800, 97);
			this.clientNameLabel.Name = "clientNameLabel";
			this.clientNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.clientNameLabel.Size = new System.Drawing.Size(74, 22);
			this.clientNameLabel.TabIndex = 10;
			this.clientNameLabel.Text = "نام مشتری:";
			// 
			// dateSetInvoiceTextBox
			// 
			this.dateSetInvoiceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateSetInvoiceTextBox.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.dateSetInvoiceTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.dateSetInvoiceTextBox.Location = new System.Drawing.Point(622, 36);
			this.dateSetInvoiceTextBox.Name = "dateSetInvoiceTextBox";
			this.dateSetInvoiceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateSetInvoiceTextBox.Size = new System.Drawing.Size(200, 19);
			this.dateSetInvoiceTextBox.TabIndex = 7;
			this.dateSetInvoiceTextBox.Text = "تاریخ ثبت";
			this.dateSetInvoiceTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sellerNameTextBox
			// 
			this.sellerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sellerNameTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.sellerNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.sellerNameTextBox.Location = new System.Drawing.Point(577, 60);
			this.sellerNameTextBox.Name = "sellerNameTextBox";
			this.sellerNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.sellerNameTextBox.Size = new System.Drawing.Size(214, 24);
			this.sellerNameTextBox.TabIndex = 9;
			this.sellerNameTextBox.Text = "نام فروشنده";
			this.sellerNameTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dateSetInvoiceLabel
			// 
			this.dateSetInvoiceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateSetInvoiceLabel.AutoSize = true;
			this.dateSetInvoiceLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.dateSetInvoiceLabel.ForeColor = System.Drawing.Color.White;
			this.dateSetInvoiceLabel.Location = new System.Drawing.Point(828, 37);
			this.dateSetInvoiceLabel.Name = "dateSetInvoiceLabel";
			this.dateSetInvoiceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateSetInvoiceLabel.Size = new System.Drawing.Size(35, 17);
			this.dateSetInvoiceLabel.TabIndex = 6;
			this.dateSetInvoiceLabel.Text = "تاریخ:";
			// 
			// sellerNameLabel
			// 
			this.sellerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sellerNameLabel.AutoSize = true;
			this.sellerNameLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.sellerNameLabel.ForeColor = System.Drawing.Color.White;
			this.sellerNameLabel.Location = new System.Drawing.Point(800, 61);
			this.sellerNameLabel.Name = "sellerNameLabel";
			this.sellerNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.sellerNameLabel.Size = new System.Drawing.Size(80, 22);
			this.sellerNameLabel.TabIndex = 8;
			this.sellerNameLabel.Text = "نام فروشنده:";
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.minimizeButton);
			this.topPanel.Controls.Add(this.closeButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(910, 30);
			this.topPanel.TabIndex = 0;
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
			this.minimizeButton.TabIndex = 0;
			this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
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
			this.closeButton.TabIndex = 1;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// invoiceTitleLabel
			// 
			this.invoiceTitleLabel.AutoSize = true;
			this.invoiceTitleLabel.Font = new System.Drawing.Font("IRANSans", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.invoiceTitleLabel.ForeColor = System.Drawing.Color.Aqua;
			this.invoiceTitleLabel.Location = new System.Drawing.Point(328, 23);
			this.invoiceTitleLabel.Name = "invoiceTitleLabel";
			this.invoiceTitleLabel.Size = new System.Drawing.Size(244, 63);
			this.invoiceTitleLabel.TabIndex = 14;
			this.invoiceTitleLabel.Text = "صورت حساب";
			// 
			// plusMarkLabel
			// 
			this.plusMarkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.plusMarkLabel.AutoSize = true;
			this.plusMarkLabel.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.plusMarkLabel.ForeColor = System.Drawing.Color.White;
			this.plusMarkLabel.Location = new System.Drawing.Point(676, 367);
			this.plusMarkLabel.Name = "plusMarkLabel";
			this.plusMarkLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.plusMarkLabel.Size = new System.Drawing.Size(25, 31);
			this.plusMarkLabel.TabIndex = 4;
			this.plusMarkLabel.Text = "+";
			// 
			// posPaymentTextBox
			// 
			this.posPaymentTextBox.AcceptsReturn = false;
			this.posPaymentTextBox.AcceptsTab = false;
			this.posPaymentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.posPaymentTextBox.AnimationSpeed = 200;
			this.posPaymentTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.posPaymentTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.posPaymentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.posPaymentTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("posPaymentTextBox.BackgroundImage")));
			this.posPaymentTextBox.BorderColorActive = System.Drawing.Color.Fuchsia;
			this.posPaymentTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.posPaymentTextBox.BorderColorHover = System.Drawing.Color.Cyan;
			this.posPaymentTextBox.BorderColorIdle = System.Drawing.Color.DimGray;
			this.posPaymentTextBox.BorderRadius = 1;
			this.posPaymentTextBox.BorderThickness = 3;
			this.posPaymentTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.posPaymentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.posPaymentTextBox.DefaultFont = new System.Drawing.Font("IRANSansFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.posPaymentTextBox.DefaultText = "";
			this.posPaymentTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.posPaymentTextBox.ForeColor = System.Drawing.Color.White;
			this.posPaymentTextBox.HideSelection = true;
			this.posPaymentTextBox.IconLeft = null;
			this.posPaymentTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.posPaymentTextBox.IconPadding = 10;
			this.posPaymentTextBox.IconRight = null;
			this.posPaymentTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.posPaymentTextBox.Lines = new string[0];
			this.posPaymentTextBox.Location = new System.Drawing.Point(500, 365);
			this.posPaymentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.posPaymentTextBox.MaximumSize = new System.Drawing.Size(171, 28);
			this.posPaymentTextBox.MaxLength = 32767;
			this.posPaymentTextBox.MinimumSize = new System.Drawing.Size(86, 28);
			this.posPaymentTextBox.Modified = false;
			this.posPaymentTextBox.Multiline = false;
			this.posPaymentTextBox.Name = "posPaymentTextBox";
			stateProperties5.BorderColor = System.Drawing.Color.Fuchsia;
			stateProperties5.FillColor = System.Drawing.Color.Empty;
			stateProperties5.ForeColor = System.Drawing.Color.Empty;
			stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.posPaymentTextBox.OnActiveState = stateProperties5;
			stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties6.FillColor = System.Drawing.Color.White;
			stateProperties6.ForeColor = System.Drawing.Color.Empty;
			stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.posPaymentTextBox.OnDisabledState = stateProperties6;
			stateProperties7.BorderColor = System.Drawing.Color.Cyan;
			stateProperties7.FillColor = System.Drawing.Color.Empty;
			stateProperties7.ForeColor = System.Drawing.Color.Empty;
			stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.posPaymentTextBox.OnHoverState = stateProperties7;
			stateProperties8.BorderColor = System.Drawing.Color.DimGray;
			stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			stateProperties8.ForeColor = System.Drawing.Color.White;
			stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.posPaymentTextBox.OnIdleState = stateProperties8;
			this.posPaymentTextBox.PasswordChar = '\0';
			this.posPaymentTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.posPaymentTextBox.PlaceholderText = "پرداخت کارت خوان";
			this.posPaymentTextBox.ReadOnly = false;
			this.posPaymentTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.posPaymentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.posPaymentTextBox.SelectedText = "";
			this.posPaymentTextBox.SelectionLength = 0;
			this.posPaymentTextBox.SelectionStart = 0;
			this.posPaymentTextBox.ShortcutsEnabled = true;
			this.posPaymentTextBox.Size = new System.Drawing.Size(171, 28);
			this.posPaymentTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.posPaymentTextBox.TabIndex = 3;
			this.posPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.posPaymentTextBox.TextMarginBottom = 0;
			this.posPaymentTextBox.TextMarginLeft = 5;
			this.posPaymentTextBox.TextMarginTop = 0;
			this.posPaymentTextBox.TextPlaceholder = "پرداخت کارت خوان";
			this.posPaymentTextBox.UseSystemPasswordChar = false;
			this.posPaymentTextBox.WordWrap = true;
			this.posPaymentTextBox.TextChange += new System.EventHandler(this.PosPaymentTextBox_TextChange);
			this.posPaymentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PosPaymentTextBox_KeyPress);
			this.posPaymentTextBox.Enter += new System.EventHandler(this.PosPaymentTextBox_Enter);
			this.posPaymentTextBox.Leave += new System.EventHandler(this.PosPaymentTextBox_Leave);
			// 
			// cashPaymentTextBox
			// 
			this.cashPaymentTextBox.AcceptsReturn = false;
			this.cashPaymentTextBox.AcceptsTab = false;
			this.cashPaymentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cashPaymentTextBox.AnimationSpeed = 200;
			this.cashPaymentTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.cashPaymentTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.cashPaymentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cashPaymentTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cashPaymentTextBox.BackgroundImage")));
			this.cashPaymentTextBox.BorderColorActive = System.Drawing.Color.Fuchsia;
			this.cashPaymentTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.cashPaymentTextBox.BorderColorHover = System.Drawing.Color.Cyan;
			this.cashPaymentTextBox.BorderColorIdle = System.Drawing.Color.DimGray;
			this.cashPaymentTextBox.BorderRadius = 1;
			this.cashPaymentTextBox.BorderThickness = 3;
			this.cashPaymentTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cashPaymentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.cashPaymentTextBox.DefaultFont = new System.Drawing.Font("IRANSansFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashPaymentTextBox.DefaultText = "";
			this.cashPaymentTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cashPaymentTextBox.ForeColor = System.Drawing.Color.White;
			this.cashPaymentTextBox.HideSelection = true;
			this.cashPaymentTextBox.IconLeft = null;
			this.cashPaymentTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.cashPaymentTextBox.IconPadding = 10;
			this.cashPaymentTextBox.IconRight = null;
			this.cashPaymentTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.cashPaymentTextBox.Lines = new string[0];
			this.cashPaymentTextBox.Location = new System.Drawing.Point(702, 365);
			this.cashPaymentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cashPaymentTextBox.MaximumSize = new System.Drawing.Size(171, 28);
			this.cashPaymentTextBox.MaxLength = 32767;
			this.cashPaymentTextBox.MinimumSize = new System.Drawing.Size(86, 28);
			this.cashPaymentTextBox.Modified = false;
			this.cashPaymentTextBox.Multiline = false;
			this.cashPaymentTextBox.Name = "cashPaymentTextBox";
			stateProperties9.BorderColor = System.Drawing.Color.Fuchsia;
			stateProperties9.FillColor = System.Drawing.Color.Empty;
			stateProperties9.ForeColor = System.Drawing.Color.Empty;
			stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.cashPaymentTextBox.OnActiveState = stateProperties9;
			stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties10.FillColor = System.Drawing.Color.White;
			stateProperties10.ForeColor = System.Drawing.Color.Empty;
			stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.cashPaymentTextBox.OnDisabledState = stateProperties10;
			stateProperties11.BorderColor = System.Drawing.Color.Cyan;
			stateProperties11.FillColor = System.Drawing.Color.Empty;
			stateProperties11.ForeColor = System.Drawing.Color.Empty;
			stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.cashPaymentTextBox.OnHoverState = stateProperties11;
			stateProperties12.BorderColor = System.Drawing.Color.DimGray;
			stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			stateProperties12.ForeColor = System.Drawing.Color.White;
			stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.cashPaymentTextBox.OnIdleState = stateProperties12;
			this.cashPaymentTextBox.PasswordChar = '\0';
			this.cashPaymentTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.cashPaymentTextBox.PlaceholderText = "پرداخت نقدی";
			this.cashPaymentTextBox.ReadOnly = false;
			this.cashPaymentTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cashPaymentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.cashPaymentTextBox.SelectedText = "";
			this.cashPaymentTextBox.SelectionLength = 0;
			this.cashPaymentTextBox.SelectionStart = 0;
			this.cashPaymentTextBox.ShortcutsEnabled = true;
			this.cashPaymentTextBox.Size = new System.Drawing.Size(171, 28);
			this.cashPaymentTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.cashPaymentTextBox.TabIndex = 2;
			this.cashPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.cashPaymentTextBox.TextMarginBottom = 0;
			this.cashPaymentTextBox.TextMarginLeft = 5;
			this.cashPaymentTextBox.TextMarginTop = 0;
			this.cashPaymentTextBox.TextPlaceholder = "پرداخت نقدی";
			this.cashPaymentTextBox.UseSystemPasswordChar = false;
			this.cashPaymentTextBox.WordWrap = true;
			this.cashPaymentTextBox.TextChange += new System.EventHandler(this.CashPaymentTextBox_TextChange);
			this.cashPaymentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashPaymentTextBox_KeyPress);
			this.cashPaymentTextBox.Enter += new System.EventHandler(this.CashPaymentTextBox_Enter);
			this.cashPaymentTextBox.Leave += new System.EventHandler(this.CashPaymentTextBox_Leave);
			// 
			// paymentTypeGroupBox
			// 
			this.paymentTypeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.paymentTypeGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.paymentTypeGroupBox.BorderRadius = 15;
			this.paymentTypeGroupBox.Controls.Add(this.debtorLabel);
			this.paymentTypeGroupBox.Controls.Add(this.cachAndPosPaymentLabel);
			this.paymentTypeGroupBox.Controls.Add(this.posPaymentLabel);
			this.paymentTypeGroupBox.Controls.Add(this.cachPaymentLabel);
			this.paymentTypeGroupBox.Controls.Add(this.debtorRadioButton);
			this.paymentTypeGroupBox.Controls.Add(this.cachAndPosPaymentRadioButton);
			this.paymentTypeGroupBox.Controls.Add(this.posPaymentRadioButton);
			this.paymentTypeGroupBox.Controls.Add(this.cachPaymentRadioButton);
			this.paymentTypeGroupBox.CustomBorderColor = System.Drawing.Color.Teal;
			this.paymentTypeGroupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
			this.paymentTypeGroupBox.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paymentTypeGroupBox.ForeColor = System.Drawing.Color.White;
			this.paymentTypeGroupBox.Location = new System.Drawing.Point(500, 412);
			this.paymentTypeGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.paymentTypeGroupBox.Name = "paymentTypeGroupBox";
			this.paymentTypeGroupBox.ShadowDecoration.Parent = this.paymentTypeGroupBox;
			this.paymentTypeGroupBox.Size = new System.Drawing.Size(374, 82);
			this.paymentTypeGroupBox.TabIndex = 5;
			this.paymentTypeGroupBox.Text = "نوع پرداخت";
			this.paymentTypeGroupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.paymentTypeGroupBox.TextOffset = new System.Drawing.Point(-10, -6);
			this.paymentTypeGroupBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			this.paymentTypeGroupBox.UseTransparentBackground = true;
			// 
			// debtorLabel
			// 
			this.debtorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.debtorLabel.AutoSize = true;
			this.debtorLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.debtorLabel.ForeColor = System.Drawing.Color.Black;
			this.debtorLabel.Location = new System.Drawing.Point(98, 57);
			this.debtorLabel.Name = "debtorLabel";
			this.debtorLabel.Size = new System.Drawing.Size(37, 17);
			this.debtorLabel.TabIndex = 7;
			this.debtorLabel.Text = "بدهکار";
			this.debtorLabel.Click += new System.EventHandler(this.DebtorLabel_Click);
			// 
			// cachAndPosPaymentLabel
			// 
			this.cachAndPosPaymentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cachAndPosPaymentLabel.AutoSize = true;
			this.cachAndPosPaymentLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cachAndPosPaymentLabel.ForeColor = System.Drawing.Color.Black;
			this.cachAndPosPaymentLabel.Location = new System.Drawing.Point(208, 57);
			this.cachAndPosPaymentLabel.Name = "cachAndPosPaymentLabel";
			this.cachAndPosPaymentLabel.Size = new System.Drawing.Size(120, 17);
			this.cachAndPosPaymentLabel.TabIndex = 5;
			this.cachAndPosPaymentLabel.Text = "پرداخت نقد و کارت خوان";
			this.cachAndPosPaymentLabel.Click += new System.EventHandler(this.CachAndPosPaymentLabel_Click);
			// 
			// posPaymentLabel
			// 
			this.posPaymentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.posPaymentLabel.AutoSize = true;
			this.posPaymentLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.posPaymentLabel.ForeColor = System.Drawing.Color.Black;
			this.posPaymentLabel.Location = new System.Drawing.Point(40, 32);
			this.posPaymentLabel.Name = "posPaymentLabel";
			this.posPaymentLabel.Size = new System.Drawing.Size(95, 17);
			this.posPaymentLabel.TabIndex = 3;
			this.posPaymentLabel.Text = "پرداخت کارت خوان";
			this.posPaymentLabel.Click += new System.EventHandler(this.PosPaymentLabel_Click);
			// 
			// cachPaymentLabel
			// 
			this.cachPaymentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cachPaymentLabel.AutoSize = true;
			this.cachPaymentLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cachPaymentLabel.ForeColor = System.Drawing.Color.Black;
			this.cachPaymentLabel.Location = new System.Drawing.Point(260, 32);
			this.cachPaymentLabel.Name = "cachPaymentLabel";
			this.cachPaymentLabel.Size = new System.Drawing.Size(60, 17);
			this.cachPaymentLabel.TabIndex = 1;
			this.cachPaymentLabel.Text = "پرداخت نقد";
			this.cachPaymentLabel.Click += new System.EventHandler(this.CachPaymentLabel_Click);
			// 
			// debtorRadioButton
			// 
			this.debtorRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.debtorRadioButton.Animated = true;
			this.debtorRadioButton.CheckedState.BorderColor = System.Drawing.Color.Purple;
			this.debtorRadioButton.CheckedState.BorderThickness = 0;
			this.debtorRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.debtorRadioButton.CheckedState.InnerColor = System.Drawing.Color.Aqua;
			this.debtorRadioButton.CheckedState.InnerOffset = 1;
			this.debtorRadioButton.CheckedState.Parent = this.debtorRadioButton;
			this.debtorRadioButton.Location = new System.Drawing.Point(141, 57);
			this.debtorRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.debtorRadioButton.Name = "debtorRadioButton";
			this.debtorRadioButton.ShadowDecoration.Parent = this.debtorRadioButton;
			this.debtorRadioButton.Size = new System.Drawing.Size(17, 16);
			this.debtorRadioButton.TabIndex = 6;
			this.debtorRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.debtorRadioButton.UncheckedState.BorderThickness = 2;
			this.debtorRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			this.debtorRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			this.debtorRadioButton.UncheckedState.Parent = this.debtorRadioButton;
			this.debtorRadioButton.CheckedChanged += new System.EventHandler(this.DebtorRadioButton_CheckedChanged);
			// 
			// cachAndPosPaymentRadioButton
			// 
			this.cachAndPosPaymentRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cachAndPosPaymentRadioButton.Animated = true;
			this.cachAndPosPaymentRadioButton.CheckedState.BorderColor = System.Drawing.Color.Purple;
			this.cachAndPosPaymentRadioButton.CheckedState.BorderThickness = 0;
			this.cachAndPosPaymentRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.cachAndPosPaymentRadioButton.CheckedState.InnerColor = System.Drawing.Color.Aqua;
			this.cachAndPosPaymentRadioButton.CheckedState.InnerOffset = 1;
			this.cachAndPosPaymentRadioButton.CheckedState.Parent = this.cachAndPosPaymentRadioButton;
			this.cachAndPosPaymentRadioButton.Location = new System.Drawing.Point(331, 57);
			this.cachAndPosPaymentRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cachAndPosPaymentRadioButton.Name = "cachAndPosPaymentRadioButton";
			this.cachAndPosPaymentRadioButton.ShadowDecoration.Parent = this.cachAndPosPaymentRadioButton;
			this.cachAndPosPaymentRadioButton.Size = new System.Drawing.Size(17, 16);
			this.cachAndPosPaymentRadioButton.TabIndex = 4;
			this.cachAndPosPaymentRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cachAndPosPaymentRadioButton.UncheckedState.BorderThickness = 2;
			this.cachAndPosPaymentRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			this.cachAndPosPaymentRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			this.cachAndPosPaymentRadioButton.UncheckedState.Parent = this.cachAndPosPaymentRadioButton;
			this.cachAndPosPaymentRadioButton.CheckedChanged += new System.EventHandler(this.CachAndPosPaymentRadioButton_CheckedChanged);
			// 
			// posPaymentRadioButton
			// 
			this.posPaymentRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.posPaymentRadioButton.Animated = true;
			this.posPaymentRadioButton.CheckedState.BorderColor = System.Drawing.Color.Purple;
			this.posPaymentRadioButton.CheckedState.BorderThickness = 0;
			this.posPaymentRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.posPaymentRadioButton.CheckedState.InnerColor = System.Drawing.Color.Aqua;
			this.posPaymentRadioButton.CheckedState.InnerOffset = 1;
			this.posPaymentRadioButton.CheckedState.Parent = this.posPaymentRadioButton;
			this.posPaymentRadioButton.Location = new System.Drawing.Point(141, 32);
			this.posPaymentRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.posPaymentRadioButton.Name = "posPaymentRadioButton";
			this.posPaymentRadioButton.ShadowDecoration.Parent = this.posPaymentRadioButton;
			this.posPaymentRadioButton.Size = new System.Drawing.Size(17, 16);
			this.posPaymentRadioButton.TabIndex = 2;
			this.posPaymentRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.posPaymentRadioButton.UncheckedState.BorderThickness = 2;
			this.posPaymentRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			this.posPaymentRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			this.posPaymentRadioButton.UncheckedState.Parent = this.posPaymentRadioButton;
			this.posPaymentRadioButton.CheckedChanged += new System.EventHandler(this.PosPaymentRadioButton_CheckedChanged);
			// 
			// cachPaymentRadioButton
			// 
			this.cachPaymentRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cachPaymentRadioButton.Animated = true;
			this.cachPaymentRadioButton.CheckedState.BorderColor = System.Drawing.Color.Purple;
			this.cachPaymentRadioButton.CheckedState.BorderThickness = 0;
			this.cachPaymentRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.cachPaymentRadioButton.CheckedState.InnerColor = System.Drawing.Color.Aqua;
			this.cachPaymentRadioButton.CheckedState.InnerOffset = 1;
			this.cachPaymentRadioButton.CheckedState.Parent = this.cachPaymentRadioButton;
			this.cachPaymentRadioButton.Location = new System.Drawing.Point(331, 32);
			this.cachPaymentRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cachPaymentRadioButton.Name = "cachPaymentRadioButton";
			this.cachPaymentRadioButton.ShadowDecoration.Parent = this.cachPaymentRadioButton;
			this.cachPaymentRadioButton.Size = new System.Drawing.Size(17, 16);
			this.cachPaymentRadioButton.TabIndex = 0;
			this.cachPaymentRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cachPaymentRadioButton.UncheckedState.BorderThickness = 2;
			this.cachPaymentRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
			this.cachPaymentRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			this.cachPaymentRadioButton.UncheckedState.Parent = this.cachPaymentRadioButton;
			this.cachPaymentRadioButton.CheckedChanged += new System.EventHandler(this.CachPaymentRadioButton_CheckedChanged);
			// 
			// cashRegisterButton
			// 
			this.cashRegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cashRegisterButton.Animated = true;
			this.cashRegisterButton.BorderRadius = 5;
			this.cashRegisterButton.CheckedState.Parent = this.cashRegisterButton;
			this.cashRegisterButton.CustomImages.Parent = this.cashRegisterButton;
			this.cashRegisterButton.FillColor = System.Drawing.Color.White;
			this.cashRegisterButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cashRegisterButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cashRegisterButton.ForeColor = System.Drawing.Color.Black;
			this.cashRegisterButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.cashRegisterButton.HoverState.FillColor2 = System.Drawing.Color.White;
			this.cashRegisterButton.HoverState.Parent = this.cashRegisterButton;
			this.cashRegisterButton.Image = ((System.Drawing.Image)(resources.GetObject("cashRegisterButton.Image")));
			this.cashRegisterButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.cashRegisterButton.ImageOffset = new System.Drawing.Point(10, 0);
			this.cashRegisterButton.Location = new System.Drawing.Point(508, 313);
			this.cashRegisterButton.Name = "cashRegisterButton";
			this.cashRegisterButton.PressedColor = System.Drawing.Color.White;
			this.cashRegisterButton.PressedDepth = 60;
			this.cashRegisterButton.ShadowDecoration.Parent = this.cashRegisterButton;
			this.cashRegisterButton.Size = new System.Drawing.Size(180, 32);
			this.cashRegisterButton.TabIndex = 25;
			this.cashRegisterButton.Text = "ثبت پرداخت";
			this.cashRegisterButton.TextOffset = new System.Drawing.Point(5, 0);
			this.cashRegisterButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			this.cashRegisterButton.Click += new System.EventHandler(this.CashRegisterButton_Click);
			// 
			// InvoiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(910, 508);
			this.Controls.Add(this.cashRegisterButton);
			this.Controls.Add(this.plusMarkLabel);
			this.Controls.Add(this.posPaymentTextBox);
			this.Controls.Add(this.cashPaymentTextBox);
			this.Controls.Add(this.paymentTypeGroupBox);
			this.Controls.Add(this.amountPaymentTextBox);
			this.Controls.Add(this.amountPaymentLabel);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.printButton);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.taxRateTextBox);
			this.Controls.Add(this.remainingAmountTextBox);
			this.Controls.Add(this.totalSumPriceTextBox);
			this.Controls.Add(this.remainingAmountLabel);
			this.Controls.Add(this.taxRateLabel);
			this.Controls.Add(this.totalSumPriceLable);
			this.Controls.Add(this.carrierNameTextBox);
			this.Controls.Add(this.carrierNameLabel);
			this.Controls.Add(this.clientNameTextBox);
			this.Controls.Add(this.clientNameLabel);
			this.Controls.Add(this.dateSetInvoiceTextBox);
			this.Controls.Add(this.sellerNameTextBox);
			this.Controls.Add(this.dateSetInvoiceLabel);
			this.Controls.Add(this.sellerNameLabel);
			this.Controls.Add(this.listWareDataGridView);
			this.Controls.Add(this.topPanel);
			this.Controls.Add(this.invoiceTitleLabel);
			this.Name = "InvoiceForm";
			this.Text = "InvoiceForm";
			((System.ComponentModel.ISupportInitialize)(this.listWareDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.printInvoiceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.topPanel.ResumeLayout(false);
			this.paymentTypeGroupBox.ResumeLayout(false);
			this.paymentTypeGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.Panel topPanel;
		private Guna.UI2.WinForms.Guna2Button minimizeButton;
		private Guna.UI2.WinForms.Guna2Button closeButton;
		private System.Windows.Forms.DataGridView listWareDataGridView;
		private Guna.UI2.WinForms.Guna2Elipse invoiceDataGridViewElipse;
		private Mbb.Windows.Forms.Label sellerNameLabel;
		private Mbb.Windows.Forms.Label clientNameLabel;
		private Mbb.Windows.Forms.Label carrierNameLabel;
		private Mbb.Windows.Forms.Label sellerNameTextBox;
		private Mbb.Windows.Forms.Label clientNameTextBox;
		private Mbb.Windows.Forms.Label carrierNameTextBox;
		private Mbb.Windows.Forms.Label dateSetInvoiceLabel;
		private Mbb.Windows.Forms.Label dateSetInvoiceTextBox;
		private Mbb.Windows.Forms.Label invoiceTitleLabel;
		private Mbb.Windows.Forms.Label totalSumPriceTextBox;
		private Mbb.Windows.Forms.Label totalSumPriceLable;
		private Mbb.Windows.Forms.Label taxRateLabel;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox taxRateTextBox;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Mbb.Windows.Forms.Label remainingAmountLabel;
		private Mbb.Windows.Forms.Label remainingAmountTextBox;
		private Guna.UI2.WinForms.Guna2GradientButton printButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productUnitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource printInvoiceBindingSource;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Mbb.Windows.Forms.Label amountPaymentTextBox;
		private Mbb.Windows.Forms.Label amountPaymentLabel;
		private Mbb.Windows.Forms.Label plusMarkLabel;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox posPaymentTextBox;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox cashPaymentTextBox;
		private Guna.UI2.WinForms.Guna2GroupBox paymentTypeGroupBox;
		private Mbb.Windows.Forms.Label debtorLabel;
		private Mbb.Windows.Forms.Label cachAndPosPaymentLabel;
		private Mbb.Windows.Forms.Label posPaymentLabel;
		private Mbb.Windows.Forms.Label cachPaymentLabel;
		private Guna.UI2.WinForms.Guna2CustomRadioButton debtorRadioButton;
		private Guna.UI2.WinForms.Guna2CustomRadioButton cachAndPosPaymentRadioButton;
		private Guna.UI2.WinForms.Guna2CustomRadioButton posPaymentRadioButton;
		private Guna.UI2.WinForms.Guna2CustomRadioButton cachPaymentRadioButton;
		private Guna.UI2.WinForms.Guna2GradientButton cashRegisterButton;
	}
}

namespace Inventory_Forms
{
	partial class BillBuyReportForm
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
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillBuyReportForm));
			this.showGunaAnimateWindow = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
			this.closeFormTimer = new System.Windows.Forms.Timer(this.components);
			this.receiptDataGridViewElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.productListDataGridView = new System.Windows.Forms.DataGridView();
			this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Product_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Product_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleLabel = new System.Windows.Forms.Label();
			this.totalSumPriceTextBox = new System.Windows.Forms.Label();
			this.remainingAmountTextBox = new System.Windows.Forms.Label();
			this.totalSumPriceLable = new System.Windows.Forms.Label();
			this.amountPaidTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.remainingAmountLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.dateOfPrintLabel = new System.Windows.Forms.Label();
			this.dateOfPrintTextBox = new System.Windows.Forms.Label();
			this.printButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.paymentButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.topPanel = new Mbb.Windows.Forms.Panel();
			this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
			this.closeButton = new Guna.UI2.WinForms.Guna2Button();
			this.carrierNameTextBox = new Mbb.Windows.Forms.Label();
			this.carrierNameLabel = new Mbb.Windows.Forms.Label();
			this.recipientNameTextBox = new Mbb.Windows.Forms.Label();
			this.recipientNameLabel = new Mbb.Windows.Forms.Label();
			this.senderNameTextBox = new Mbb.Windows.Forms.Label();
			this.senderNameLabel = new Mbb.Windows.Forms.Label();
			this.amountPaidLabel = new System.Windows.Forms.Label();
			this.invoiceSerialNumberTextBox = new Mbb.Windows.Forms.Label();
			this.invoiceSerialNumbeLabel = new Mbb.Windows.Forms.Label();
			this.paymentTypeGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
			this.paymentChequeLabel = new System.Windows.Forms.Label();
			this.paymentCashLabel = new System.Windows.Forms.Label();
			this.paymentChequeRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
			this.paymentCashRadioButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
			((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.topPanel.SuspendLayout();
			this.paymentTypeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// showGunaAnimateWindow
			// 
			this.showGunaAnimateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
			this.showGunaAnimateWindow.Interval = 250;
			this.showGunaAnimateWindow.TargetControl = this;
			// 
			// closeFormTimer
			// 
			this.closeFormTimer.Interval = 5;
			this.closeFormTimer.Tick += new System.EventHandler(this.CloseFormTimer_Tick);
			// 
			// receiptDataGridViewElipse
			// 
			this.receiptDataGridViewElipse.BorderRadius = 25;
			this.receiptDataGridViewElipse.TargetControl = this.productListDataGridView;
			// 
			// productListDataGridView
			// 
			this.productListDataGridView.AllowUserToAddRows = false;
			this.productListDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansXFaNum Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.productListDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.productListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.productListDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.productListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.productListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.productListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.productListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.productListDataGridView.ColumnHeadersHeight = 35;
			this.productListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.productListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Product_Price,
            this.Product_Quantity,
            this.Product_Unit,
            this.Total_Amount});
			this.productListDataGridView.EnableHeadersVisualStyles = false;
			this.productListDataGridView.Location = new System.Drawing.Point(12, 242);
			this.productListDataGridView.MultiSelect = false;
			this.productListDataGridView.Name = "productListDataGridView";
			this.productListDataGridView.ReadOnly = true;
			this.productListDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.productListDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.productListDataGridView.RowHeadersVisible = false;
			this.productListDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansXFaNum Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			this.productListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.productListDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.productListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.productListDataGridView.Size = new System.Drawing.Size(886, 160);
			this.productListDataGridView.TabIndex = 7;
			// 
			// Product_Name
			// 
			this.Product_Name.FillWeight = 200F;
			this.Product_Name.HeaderText = "نام کالا";
			this.Product_Name.Name = "Product_Name";
			this.Product_Name.ReadOnly = true;
			// 
			// Product_Price
			// 
			this.Product_Price.HeaderText = "قیمت خرید";
			this.Product_Price.Name = "Product_Price";
			this.Product_Price.ReadOnly = true;
			// 
			// Product_Quantity
			// 
			this.Product_Quantity.FillWeight = 50F;
			this.Product_Quantity.HeaderText = "تعداد";
			this.Product_Quantity.Name = "Product_Quantity";
			this.Product_Quantity.ReadOnly = true;
			// 
			// Product_Unit
			// 
			this.Product_Unit.FillWeight = 50F;
			this.Product_Unit.HeaderText = "واحد";
			this.Product_Unit.Name = "Product_Unit";
			this.Product_Unit.ReadOnly = true;
			// 
			// Total_Amount
			// 
			this.Total_Amount.HeaderText = "جمع مبلغ";
			this.Total_Amount.Name = "Total_Amount";
			this.Total_Amount.ReadOnly = true;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel.Font = new System.Drawing.Font("IRANSansX", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.titleLabel.ForeColor = System.Drawing.Color.White;
			this.titleLabel.Location = new System.Drawing.Point(248, 32);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.titleLabel.Size = new System.Drawing.Size(414, 57);
			this.titleLabel.TabIndex = 4;
			this.titleLabel.Text = "رسید خرید کالاهای ورودی";
			// 
			// totalSumPriceTextBox
			// 
			this.totalSumPriceTextBox.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.totalSumPriceTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.totalSumPriceTextBox.Location = new System.Drawing.Point(12, 413);
			this.totalSumPriceTextBox.Name = "totalSumPriceTextBox";
			this.totalSumPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.totalSumPriceTextBox.Size = new System.Drawing.Size(300, 25);
			this.totalSumPriceTextBox.TabIndex = 9;
			this.totalSumPriceTextBox.Text = "0 تومان";
			this.totalSumPriceTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.totalSumPriceTextBox.TextChanged += new System.EventHandler(this.TotalSumPriceTextBox_TextChanged);
			// 
			// remainingAmountTextBox
			// 
			this.remainingAmountTextBox.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.remainingAmountTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.remainingAmountTextBox.Location = new System.Drawing.Point(12, 495);
			this.remainingAmountTextBox.Name = "remainingAmountTextBox";
			this.remainingAmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.remainingAmountTextBox.Size = new System.Drawing.Size(300, 25);
			this.remainingAmountTextBox.TabIndex = 12;
			this.remainingAmountTextBox.Text = "0 تومان";
			this.remainingAmountTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// totalSumPriceLable
			// 
			this.totalSumPriceLable.AutoSize = true;
			this.totalSumPriceLable.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.totalSumPriceLable.ForeColor = System.Drawing.Color.White;
			this.totalSumPriceLable.Location = new System.Drawing.Point(337, 414);
			this.totalSumPriceLable.Name = "totalSumPriceLable";
			this.totalSumPriceLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.totalSumPriceLable.Size = new System.Drawing.Size(99, 22);
			this.totalSumPriceLable.TabIndex = 8;
			this.totalSumPriceLable.Text = "جمع کل حساب:";
			// 
			// amountPaidTextBox
			// 
			this.amountPaidTextBox.AcceptsReturn = false;
			this.amountPaidTextBox.AcceptsTab = false;
			this.amountPaidTextBox.AnimationSpeed = 200;
			this.amountPaidTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.amountPaidTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.amountPaidTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.amountPaidTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("amountPaidTextBox.BackgroundImage")));
			this.amountPaidTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.amountPaidTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.amountPaidTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.amountPaidTextBox.BorderColorIdle = System.Drawing.Color.Silver;
			this.amountPaidTextBox.BorderRadius = 1;
			this.amountPaidTextBox.BorderThickness = 0;
			this.amountPaidTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.amountPaidTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.amountPaidTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.amountPaidTextBox.DefaultText = "0 تومان";
			this.amountPaidTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.amountPaidTextBox.ForeColor = System.Drawing.Color.White;
			this.amountPaidTextBox.HideSelection = true;
			this.amountPaidTextBox.IconLeft = null;
			this.amountPaidTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.amountPaidTextBox.IconPadding = 10;
			this.amountPaidTextBox.IconRight = null;
			this.amountPaidTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.amountPaidTextBox.Lines = new string[] {
        "0 تومان"};
			this.amountPaidTextBox.Location = new System.Drawing.Point(12, 453);
			this.amountPaidTextBox.MaximumSize = new System.Drawing.Size(300, 25);
			this.amountPaidTextBox.MaxLength = 32767;
			this.amountPaidTextBox.MinimumSize = new System.Drawing.Size(300, 25);
			this.amountPaidTextBox.Modified = false;
			this.amountPaidTextBox.Multiline = false;
			this.amountPaidTextBox.Name = "amountPaidTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.amountPaidTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.amountPaidTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.amountPaidTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Silver;
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			stateProperties4.ForeColor = System.Drawing.Color.White;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.amountPaidTextBox.OnIdleState = stateProperties4;
			this.amountPaidTextBox.PasswordChar = '\0';
			this.amountPaidTextBox.PlaceholderForeColor = System.Drawing.Color.White;
			this.amountPaidTextBox.PlaceholderText = "";
			this.amountPaidTextBox.ReadOnly = false;
			this.amountPaidTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.amountPaidTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.amountPaidTextBox.SelectedText = "";
			this.amountPaidTextBox.SelectionLength = 0;
			this.amountPaidTextBox.SelectionStart = 0;
			this.amountPaidTextBox.ShortcutsEnabled = true;
			this.amountPaidTextBox.Size = new System.Drawing.Size(300, 25);
			this.amountPaidTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.amountPaidTextBox.TabIndex = 1;
			this.amountPaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.amountPaidTextBox.TextMarginBottom = 0;
			this.amountPaidTextBox.TextMarginLeft = -8;
			this.amountPaidTextBox.TextMarginTop = 0;
			this.amountPaidTextBox.TextPlaceholder = "";
			this.amountPaidTextBox.UseSystemPasswordChar = false;
			this.amountPaidTextBox.WordWrap = true;
			this.amountPaidTextBox.TextChange += new System.EventHandler(this.AmountPaidTextBox_TextChange);
			this.amountPaidTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountPaidTextBox_KeyPress);
			this.amountPaidTextBox.Enter += new System.EventHandler(this.AmountPaidTextBox_Enter);
			this.amountPaidTextBox.Leave += new System.EventHandler(this.AmountPaidTextBox_Leave);
			// 
			// remainingAmountLabel
			// 
			this.remainingAmountLabel.AutoSize = true;
			this.remainingAmountLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.remainingAmountLabel.ForeColor = System.Drawing.Color.White;
			this.remainingAmountLabel.Location = new System.Drawing.Point(337, 496);
			this.remainingAmountLabel.Name = "remainingAmountLabel";
			this.remainingAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.remainingAmountLabel.Size = new System.Drawing.Size(62, 22);
			this.remainingAmountLabel.TabIndex = 11;
			this.remainingAmountLabel.Text = "باقیمانده:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(12, 484);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 3);
			this.panel1.TabIndex = 10;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(12, 43);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(130, 110);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPictureBox.TabIndex = 26;
			this.logoPictureBox.TabStop = false;
			// 
			// dateOfPrintLabel
			// 
			this.dateOfPrintLabel.AllowDrop = true;
			this.dateOfPrintLabel.AutoSize = true;
			this.dateOfPrintLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.dateOfPrintLabel.ForeColor = System.Drawing.Color.White;
			this.dateOfPrintLabel.Location = new System.Drawing.Point(863, 42);
			this.dateOfPrintLabel.Name = "dateOfPrintLabel";
			this.dateOfPrintLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateOfPrintLabel.Size = new System.Drawing.Size(35, 17);
			this.dateOfPrintLabel.TabIndex = 5;
			this.dateOfPrintLabel.Text = "تاریخ:";
			// 
			// dateOfPrintTextBox
			// 
			this.dateOfPrintTextBox.AllowDrop = true;
			this.dateOfPrintTextBox.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.dateOfPrintTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.dateOfPrintTextBox.Location = new System.Drawing.Point(707, 38);
			this.dateOfPrintTextBox.Name = "dateOfPrintTextBox";
			this.dateOfPrintTextBox.Size = new System.Drawing.Size(150, 25);
			this.dateOfPrintTextBox.TabIndex = 6;
			this.dateOfPrintTextBox.Text = "00/00/00 - 00:00:00";
			this.dateOfPrintTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// printButton
			// 
			this.printButton.Animated = true;
			this.printButton.BorderRadius = 5;
			this.printButton.CheckedState.Parent = this.printButton;
			this.printButton.CustomImages.Parent = this.printButton;
			this.printButton.FillColor = System.Drawing.SystemColors.ControlDarkDark;
			this.printButton.FillColor2 = System.Drawing.Color.White;
			this.printButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.printButton.ForeColor = System.Drawing.Color.Black;
			this.printButton.HoverState.FillColor = System.Drawing.Color.White;
			this.printButton.HoverState.FillColor2 = System.Drawing.SystemColors.ControlDarkDark;
			this.printButton.HoverState.Parent = this.printButton;
			this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
			this.printButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.printButton.Location = new System.Drawing.Point(718, 478);
			this.printButton.Name = "printButton";
			this.printButton.PressedColor = System.Drawing.Color.Teal;
			this.printButton.ShadowDecoration.Parent = this.printButton;
			this.printButton.Size = new System.Drawing.Size(180, 35);
			this.printButton.TabIndex = 2;
			this.printButton.Text = "چاپ رسید خرید";
			this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// paymentButton
			// 
			this.paymentButton.Animated = true;
			this.paymentButton.BorderRadius = 5;
			this.paymentButton.CheckedState.Parent = this.paymentButton;
			this.paymentButton.CustomImages.Parent = this.paymentButton;
			this.paymentButton.Enabled = false;
			this.paymentButton.FillColor = System.Drawing.Color.White;
			this.paymentButton.FillColor2 = System.Drawing.SystemColors.ControlDarkDark;
			this.paymentButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.paymentButton.ForeColor = System.Drawing.Color.Black;
			this.paymentButton.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
			this.paymentButton.HoverState.FillColor2 = System.Drawing.Color.White;
			this.paymentButton.HoverState.Parent = this.paymentButton;
			this.paymentButton.Image = ((System.Drawing.Image)(resources.GetObject("paymentButton.Image")));
			this.paymentButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.paymentButton.Location = new System.Drawing.Point(532, 478);
			this.paymentButton.Name = "paymentButton";
			this.paymentButton.PressedColor = System.Drawing.Color.Teal;
			this.paymentButton.ShadowDecoration.Parent = this.paymentButton;
			this.paymentButton.Size = new System.Drawing.Size(180, 35);
			this.paymentButton.TabIndex = 27;
			this.paymentButton.Text = "پرداخت هزینه";
			this.paymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
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
			this.minimizeButton.TabIndex = 1;
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
			this.closeButton.TabIndex = 0;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// carrierNameTextBox
			// 
			this.carrierNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.carrierNameTextBox.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.carrierNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.carrierNameTextBox.Location = new System.Drawing.Point(601, 206);
			this.carrierNameTextBox.Name = "carrierNameTextBox";
			this.carrierNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.carrierNameTextBox.Size = new System.Drawing.Size(200, 25);
			this.carrierNameTextBox.TabIndex = 35;
			this.carrierNameTextBox.Text = "نام حامل کالا";
			this.carrierNameTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// carrierNameLabel
			// 
			this.carrierNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.carrierNameLabel.AutoSize = true;
			this.carrierNameLabel.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.carrierNameLabel.ForeColor = System.Drawing.Color.White;
			this.carrierNameLabel.Location = new System.Drawing.Point(828, 209);
			this.carrierNameLabel.Name = "carrierNameLabel";
			this.carrierNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.carrierNameLabel.Size = new System.Drawing.Size(73, 19);
			this.carrierNameLabel.TabIndex = 34;
			this.carrierNameLabel.Text = "نام حامل کالا:";
			// 
			// recipientNameTextBox
			// 
			this.recipientNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.recipientNameTextBox.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.recipientNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.recipientNameTextBox.Location = new System.Drawing.Point(601, 169);
			this.recipientNameTextBox.Name = "recipientNameTextBox";
			this.recipientNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.recipientNameTextBox.Size = new System.Drawing.Size(200, 25);
			this.recipientNameTextBox.TabIndex = 33;
			this.recipientNameTextBox.Text = "نام تحویل گیرنده";
			this.recipientNameTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// recipientNameLabel
			// 
			this.recipientNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.recipientNameLabel.AutoSize = true;
			this.recipientNameLabel.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.recipientNameLabel.ForeColor = System.Drawing.Color.White;
			this.recipientNameLabel.Location = new System.Drawing.Point(807, 172);
			this.recipientNameLabel.Name = "recipientNameLabel";
			this.recipientNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.recipientNameLabel.Size = new System.Drawing.Size(92, 19);
			this.recipientNameLabel.TabIndex = 32;
			this.recipientNameLabel.Text = "نام تحویل گیرنده:";
			// 
			// senderNameTextBox
			// 
			this.senderNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.senderNameTextBox.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.senderNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.senderNameTextBox.Location = new System.Drawing.Point(601, 132);
			this.senderNameTextBox.Name = "senderNameTextBox";
			this.senderNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.senderNameTextBox.Size = new System.Drawing.Size(200, 25);
			this.senderNameTextBox.TabIndex = 31;
			this.senderNameTextBox.Text = "نام فرستنده";
			this.senderNameTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// senderNameLabel
			// 
			this.senderNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.senderNameLabel.AutoSize = true;
			this.senderNameLabel.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.senderNameLabel.ForeColor = System.Drawing.Color.White;
			this.senderNameLabel.Location = new System.Drawing.Point(834, 135);
			this.senderNameLabel.Name = "senderNameLabel";
			this.senderNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.senderNameLabel.Size = new System.Drawing.Size(67, 19);
			this.senderNameLabel.TabIndex = 30;
			this.senderNameLabel.Text = "نام فرستنده:";
			// 
			// amountPaidLabel
			// 
			this.amountPaidLabel.AutoSize = true;
			this.amountPaidLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.amountPaidLabel.ForeColor = System.Drawing.Color.White;
			this.amountPaidLabel.Location = new System.Drawing.Point(337, 454);
			this.amountPaidLabel.Name = "amountPaidLabel";
			this.amountPaidLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.amountPaidLabel.Size = new System.Drawing.Size(86, 22);
			this.amountPaidLabel.TabIndex = 36;
			this.amountPaidLabel.Text = "مبلغ پرداختی:";
			// 
			// invoiceSerialNumberTextBox
			// 
			this.invoiceSerialNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.invoiceSerialNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.invoiceSerialNumberTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.invoiceSerialNumberTextBox.Location = new System.Drawing.Point(601, 98);
			this.invoiceSerialNumberTextBox.Name = "invoiceSerialNumberTextBox";
			this.invoiceSerialNumberTextBox.Size = new System.Drawing.Size(200, 25);
			this.invoiceSerialNumberTextBox.TabIndex = 38;
			this.invoiceSerialNumberTextBox.Text = "Serial Invoice";
			this.invoiceSerialNumberTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// invoiceSerialNumbeLabel
			// 
			this.invoiceSerialNumbeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.invoiceSerialNumbeLabel.AutoSize = true;
			this.invoiceSerialNumbeLabel.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.invoiceSerialNumbeLabel.ForeColor = System.Drawing.Color.White;
			this.invoiceSerialNumbeLabel.Location = new System.Drawing.Point(834, 101);
			this.invoiceSerialNumbeLabel.Name = "invoiceSerialNumbeLabel";
			this.invoiceSerialNumbeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.invoiceSerialNumbeLabel.Size = new System.Drawing.Size(69, 19);
			this.invoiceSerialNumbeLabel.TabIndex = 37;
			this.invoiceSerialNumbeLabel.Text = "شماره فاکتور:";
			// 
			// paymentTypeGroupBox
			// 
			this.paymentTypeGroupBox.BorderRadius = 10;
			this.paymentTypeGroupBox.Controls.Add(this.paymentChequeLabel);
			this.paymentTypeGroupBox.Controls.Add(this.paymentCashLabel);
			this.paymentTypeGroupBox.Controls.Add(this.paymentChequeRadioButton);
			this.paymentTypeGroupBox.Controls.Add(this.paymentCashRadioButton);
			this.paymentTypeGroupBox.CustomBorderColor = System.Drawing.Color.RoyalBlue;
			this.paymentTypeGroupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
			this.paymentTypeGroupBox.Font = new System.Drawing.Font("IRANSansXFaNum", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.paymentTypeGroupBox.ForeColor = System.Drawing.Color.White;
			this.paymentTypeGroupBox.Location = new System.Drawing.Point(532, 408);
			this.paymentTypeGroupBox.Name = "paymentTypeGroupBox";
			this.paymentTypeGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.paymentTypeGroupBox.ShadowDecoration.Parent = this.paymentTypeGroupBox;
			this.paymentTypeGroupBox.Size = new System.Drawing.Size(366, 60);
			this.paymentTypeGroupBox.TabIndex = 39;
			this.paymentTypeGroupBox.Text = "نوع پرداخت";
			this.paymentTypeGroupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.paymentTypeGroupBox.TextOffset = new System.Drawing.Point(0, -7);
			this.paymentTypeGroupBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			// 
			// paymentChequeLabel
			// 
			this.paymentChequeLabel.BackColor = System.Drawing.Color.Transparent;
			this.paymentChequeLabel.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.paymentChequeLabel.ForeColor = System.Drawing.Color.Black;
			this.paymentChequeLabel.Location = new System.Drawing.Point(34, 30);
			this.paymentChequeLabel.Name = "paymentChequeLabel";
			this.paymentChequeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.paymentChequeLabel.Size = new System.Drawing.Size(120, 25);
			this.paymentChequeLabel.TabIndex = 11;
			this.paymentChequeLabel.Text = "پرداخت چک بانکی";
			this.paymentChequeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.paymentChequeLabel.Click += new System.EventHandler(this.PaymentChequeLabel_Click);
			// 
			// paymentCashLabel
			// 
			this.paymentCashLabel.BackColor = System.Drawing.Color.Transparent;
			this.paymentCashLabel.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.paymentCashLabel.ForeColor = System.Drawing.Color.Black;
			this.paymentCashLabel.Location = new System.Drawing.Point(227, 30);
			this.paymentCashLabel.Name = "paymentCashLabel";
			this.paymentCashLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.paymentCashLabel.Size = new System.Drawing.Size(80, 25);
			this.paymentCashLabel.TabIndex = 10;
			this.paymentCashLabel.Text = "پرداخت نقد";
			this.paymentCashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.paymentCashLabel.Click += new System.EventHandler(this.PaymentCashLabel_Click);
			// 
			// paymentChequeRadioButton
			// 
			this.paymentChequeRadioButton.BackColor = System.Drawing.Color.Transparent;
			this.paymentChequeRadioButton.CheckedState.BorderColor = System.Drawing.Color.RoyalBlue;
			this.paymentChequeRadioButton.CheckedState.BorderThickness = 2;
			this.paymentChequeRadioButton.CheckedState.FillColor = System.Drawing.Color.White;
			this.paymentChequeRadioButton.CheckedState.InnerColor = System.Drawing.Color.RoyalBlue;
			this.paymentChequeRadioButton.CheckedState.InnerOffset = -3;
			this.paymentChequeRadioButton.CheckedState.Parent = this.paymentChequeRadioButton;
			this.paymentChequeRadioButton.Location = new System.Drawing.Point(160, 32);
			this.paymentChequeRadioButton.Name = "paymentChequeRadioButton";
			this.paymentChequeRadioButton.ShadowDecoration.Parent = this.paymentChequeRadioButton;
			this.paymentChequeRadioButton.Size = new System.Drawing.Size(20, 20);
			this.paymentChequeRadioButton.TabIndex = 1;
			this.paymentChequeRadioButton.UncheckedState.BorderColor = System.Drawing.Color.RoyalBlue;
			this.paymentChequeRadioButton.UncheckedState.BorderThickness = 2;
			this.paymentChequeRadioButton.UncheckedState.FillColor = System.Drawing.Color.White;
			this.paymentChequeRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			this.paymentChequeRadioButton.UncheckedState.Parent = this.paymentChequeRadioButton;
			this.paymentChequeRadioButton.CheckedChanged += new System.EventHandler(this.PaymentChequeRadioButton_CheckedChanged);
			// 
			// paymentCashRadioButton
			// 
			this.paymentCashRadioButton.BackColor = System.Drawing.Color.Transparent;
			this.paymentCashRadioButton.CheckedState.BorderColor = System.Drawing.Color.RoyalBlue;
			this.paymentCashRadioButton.CheckedState.BorderThickness = 2;
			this.paymentCashRadioButton.CheckedState.FillColor = System.Drawing.Color.White;
			this.paymentCashRadioButton.CheckedState.InnerColor = System.Drawing.Color.RoyalBlue;
			this.paymentCashRadioButton.CheckedState.InnerOffset = -3;
			this.paymentCashRadioButton.CheckedState.Parent = this.paymentCashRadioButton;
			this.paymentCashRadioButton.Location = new System.Drawing.Point(313, 32);
			this.paymentCashRadioButton.Name = "paymentCashRadioButton";
			this.paymentCashRadioButton.ShadowDecoration.Parent = this.paymentCashRadioButton;
			this.paymentCashRadioButton.Size = new System.Drawing.Size(20, 20);
			this.paymentCashRadioButton.TabIndex = 0;
			this.paymentCashRadioButton.UncheckedState.BorderColor = System.Drawing.Color.RoyalBlue;
			this.paymentCashRadioButton.UncheckedState.BorderThickness = 2;
			this.paymentCashRadioButton.UncheckedState.FillColor = System.Drawing.Color.White;
			this.paymentCashRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
			this.paymentCashRadioButton.UncheckedState.Parent = this.paymentCashRadioButton;
			this.paymentCashRadioButton.CheckedChanged += new System.EventHandler(this.PaymentCashRadioButton_CheckedChanged);
			// 
			// BillBuyReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(910, 530);
			this.Controls.Add(this.paymentTypeGroupBox);
			this.Controls.Add(this.invoiceSerialNumberTextBox);
			this.Controls.Add(this.invoiceSerialNumbeLabel);
			this.Controls.Add(this.amountPaidLabel);
			this.Controls.Add(this.carrierNameTextBox);
			this.Controls.Add(this.carrierNameLabel);
			this.Controls.Add(this.recipientNameTextBox);
			this.Controls.Add(this.recipientNameLabel);
			this.Controls.Add(this.senderNameTextBox);
			this.Controls.Add(this.senderNameLabel);
			this.Controls.Add(this.paymentButton);
			this.Controls.Add(this.printButton);
			this.Controls.Add(this.dateOfPrintLabel);
			this.Controls.Add(this.dateOfPrintTextBox);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.remainingAmountLabel);
			this.Controls.Add(this.amountPaidTextBox);
			this.Controls.Add(this.totalSumPriceLable);
			this.Controls.Add(this.remainingAmountTextBox);
			this.Controls.Add(this.totalSumPriceTextBox);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.productListDataGridView);
			this.Controls.Add(this.topPanel);
			this.Name = "BillBuyReportForm";
			this.Text = "BillBuyForm";
			this.Load += new System.EventHandler(this.BillBuyReportForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.topPanel.ResumeLayout(false);
			this.paymentTypeGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Mbb.Windows.Forms.Panel topPanel;
		private Guna.UI2.WinForms.Guna2Button minimizeButton;
		private Guna.UI2.WinForms.Guna2Button closeButton;
		private Guna.UI.WinForms.GunaAnimateWindow showGunaAnimateWindow;
		private System.Windows.Forms.Timer closeFormTimer;
		private Guna.UI2.WinForms.Guna2Elipse receiptDataGridViewElipse;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label totalSumPriceTextBox;
		private System.Windows.Forms.Label remainingAmountTextBox;
		private System.Windows.Forms.Label totalSumPriceLable;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox amountPaidTextBox;
		private System.Windows.Forms.Label remainingAmountLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label dateOfPrintLabel;
		private System.Windows.Forms.Label dateOfPrintTextBox;
		private Guna.UI2.WinForms.Guna2GradientButton printButton;
		public System.Windows.Forms.DataGridView productListDataGridView;
		private Guna.UI2.WinForms.Guna2GradientButton paymentButton;
		private Mbb.Windows.Forms.Label carrierNameLabel;
		private Mbb.Windows.Forms.Label recipientNameLabel;
		private Mbb.Windows.Forms.Label senderNameLabel;
		private System.Windows.Forms.Label amountPaidLabel;
		private Mbb.Windows.Forms.Label invoiceSerialNumberTextBox;
		private Mbb.Windows.Forms.Label invoiceSerialNumbeLabel;
		public Mbb.Windows.Forms.Label carrierNameTextBox;
		public Mbb.Windows.Forms.Label senderNameTextBox;
		public Mbb.Windows.Forms.Label recipientNameTextBox;
		private Guna.UI2.WinForms.Guna2GroupBox paymentTypeGroupBox;
		private Guna.UI2.WinForms.Guna2CustomRadioButton paymentChequeRadioButton;
		private Guna.UI2.WinForms.Guna2CustomRadioButton paymentCashRadioButton;
		private System.Windows.Forms.Label paymentChequeLabel;
		private System.Windows.Forms.Label paymentCashLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product_Unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total_Amount;
	}
}
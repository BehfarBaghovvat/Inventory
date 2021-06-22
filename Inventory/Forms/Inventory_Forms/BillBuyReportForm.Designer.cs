
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillBuyReportForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.topPanel = new Mbb.Windows.Forms.Panel();
			this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
			this.closeButton = new Guna.UI2.WinForms.Guna2Button();
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
			this.amountPaymentTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.amountPaymentLabel = new System.Windows.Forms.Label();
			this.remainingAmountLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.dateOfPrintLabel = new System.Windows.Forms.Label();
			this.dateOfPrintTextBox = new System.Windows.Forms.Label();
			this.printButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.paymentButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
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
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
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
			this.productListDataGridView.ColumnHeadersHeight = 40;
			this.productListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.productListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Product_Price,
            this.Product_Quantity,
            this.Product_Unit,
            this.Total_Amount});
			this.productListDataGridView.EnableHeadersVisualStyles = false;
			this.productListDataGridView.Location = new System.Drawing.Point(10, 174);
			this.productListDataGridView.MultiSelect = false;
			this.productListDataGridView.Name = "productListDataGridView";
			this.productListDataGridView.ReadOnly = true;
			this.productListDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.productListDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.productListDataGridView.RowHeadersVisible = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansX", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			this.productListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.productListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.productListDataGridView.Size = new System.Drawing.Size(890, 150);
			this.productListDataGridView.TabIndex = 7;
			this.productListDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ProductListDataGridView_RowsAdded);
			// 
			// Product_Name
			// 
			this.Product_Name.HeaderText = "نام کالا";
			this.Product_Name.Name = "Product_Name";
			this.Product_Name.ReadOnly = true;
			// 
			// Product_Price
			// 
			this.Product_Price.HeaderText = "قیمت خرید کالا";
			this.Product_Price.Name = "Product_Price";
			this.Product_Price.ReadOnly = true;
			// 
			// Product_Quantity
			// 
			this.Product_Quantity.HeaderText = "تعداد کالا";
			this.Product_Quantity.Name = "Product_Quantity";
			this.Product_Quantity.ReadOnly = true;
			// 
			// Product_Unit
			// 
			this.Product_Unit.HeaderText = "واحد کالا";
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
			this.totalSumPriceTextBox.Location = new System.Drawing.Point(12, 329);
			this.totalSumPriceTextBox.Name = "totalSumPriceTextBox";
			this.totalSumPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.totalSumPriceTextBox.Size = new System.Drawing.Size(300, 30);
			this.totalSumPriceTextBox.TabIndex = 9;
			this.totalSumPriceTextBox.Text = "0 تومان";
			this.totalSumPriceTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.totalSumPriceTextBox.TextChanged += new System.EventHandler(this.TotalSumPriceTextBox_TextChanged);
			// 
			// remainingAmountTextBox
			// 
			this.remainingAmountTextBox.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.remainingAmountTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.remainingAmountTextBox.Location = new System.Drawing.Point(12, 423);
			this.remainingAmountTextBox.Name = "remainingAmountTextBox";
			this.remainingAmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.remainingAmountTextBox.Size = new System.Drawing.Size(300, 30);
			this.remainingAmountTextBox.TabIndex = 12;
			this.remainingAmountTextBox.Text = "0 تومان";
			this.remainingAmountTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// totalSumPriceLable
			// 
			this.totalSumPriceLable.AutoSize = true;
			this.totalSumPriceLable.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.totalSumPriceLable.ForeColor = System.Drawing.Color.White;
			this.totalSumPriceLable.Location = new System.Drawing.Point(337, 333);
			this.totalSumPriceLable.Name = "totalSumPriceLable";
			this.totalSumPriceLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.totalSumPriceLable.Size = new System.Drawing.Size(99, 22);
			this.totalSumPriceLable.TabIndex = 8;
			this.totalSumPriceLable.Text = "جمع کل حساب:";
			// 
			// amountPaymentTextBox
			// 
			this.amountPaymentTextBox.AcceptsReturn = false;
			this.amountPaymentTextBox.AcceptsTab = false;
			this.amountPaymentTextBox.AnimationSpeed = 200;
			this.amountPaymentTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.amountPaymentTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.amountPaymentTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.amountPaymentTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("amountPaymentTextBox.BackgroundImage")));
			this.amountPaymentTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.amountPaymentTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.amountPaymentTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.amountPaymentTextBox.BorderColorIdle = System.Drawing.Color.Silver;
			this.amountPaymentTextBox.BorderRadius = 1;
			this.amountPaymentTextBox.BorderThickness = 0;
			this.amountPaymentTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.amountPaymentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.amountPaymentTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.amountPaymentTextBox.DefaultText = "";
			this.amountPaymentTextBox.FillColor = System.Drawing.SystemColors.ControlDarkDark;
			this.amountPaymentTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.amountPaymentTextBox.HideSelection = true;
			this.amountPaymentTextBox.IconLeft = null;
			this.amountPaymentTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.amountPaymentTextBox.IconPadding = 10;
			this.amountPaymentTextBox.IconRight = null;
			this.amountPaymentTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.amountPaymentTextBox.Lines = new string[0];
			this.amountPaymentTextBox.Location = new System.Drawing.Point(12, 364);
			this.amountPaymentTextBox.MaxLength = 32767;
			this.amountPaymentTextBox.MinimumSize = new System.Drawing.Size(100, 35);
			this.amountPaymentTextBox.Modified = false;
			this.amountPaymentTextBox.Multiline = false;
			this.amountPaymentTextBox.Name = "amountPaymentTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.amountPaymentTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.amountPaymentTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.amountPaymentTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Silver;
			stateProperties4.FillColor = System.Drawing.SystemColors.ControlDarkDark;
			stateProperties4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.amountPaymentTextBox.OnIdleState = stateProperties4;
			this.amountPaymentTextBox.PasswordChar = '\0';
			this.amountPaymentTextBox.PlaceholderForeColor = System.Drawing.Color.White;
			this.amountPaymentTextBox.PlaceholderText = "0 تومان";
			this.amountPaymentTextBox.ReadOnly = false;
			this.amountPaymentTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.amountPaymentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.amountPaymentTextBox.SelectedText = "";
			this.amountPaymentTextBox.SelectionLength = 0;
			this.amountPaymentTextBox.SelectionStart = 0;
			this.amountPaymentTextBox.ShortcutsEnabled = true;
			this.amountPaymentTextBox.Size = new System.Drawing.Size(300, 35);
			this.amountPaymentTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.amountPaymentTextBox.TabIndex = 1;
			this.amountPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.amountPaymentTextBox.TextMarginBottom = 0;
			this.amountPaymentTextBox.TextMarginLeft = -5;
			this.amountPaymentTextBox.TextMarginTop = 0;
			this.amountPaymentTextBox.TextPlaceholder = "0 تومان";
			this.amountPaymentTextBox.UseSystemPasswordChar = false;
			this.amountPaymentTextBox.WordWrap = true;
			this.amountPaymentTextBox.TextChange += new System.EventHandler(this.AmountPaymentTextBox_TextChange);
			this.amountPaymentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountPaymentTextBox_KeyPress);
			this.amountPaymentTextBox.Enter += new System.EventHandler(this.AmountPaymentTextBox_Enter);
			this.amountPaymentTextBox.Leave += new System.EventHandler(this.AmountPaymentTextBox_Leave);
			// 
			// amountPaymentLabel
			// 
			this.amountPaymentLabel.AutoSize = true;
			this.amountPaymentLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.amountPaymentLabel.ForeColor = System.Drawing.Color.White;
			this.amountPaymentLabel.Location = new System.Drawing.Point(337, 368);
			this.amountPaymentLabel.Name = "amountPaymentLabel";
			this.amountPaymentLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.amountPaymentLabel.Size = new System.Drawing.Size(86, 22);
			this.amountPaymentLabel.TabIndex = 2;
			this.amountPaymentLabel.Text = "مبلغ پرداختی:";
			// 
			// remainingAmountLabel
			// 
			this.remainingAmountLabel.AutoSize = true;
			this.remainingAmountLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.remainingAmountLabel.ForeColor = System.Drawing.Color.White;
			this.remainingAmountLabel.Location = new System.Drawing.Point(337, 427);
			this.remainingAmountLabel.Name = "remainingAmountLabel";
			this.remainingAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.remainingAmountLabel.Size = new System.Drawing.Size(62, 22);
			this.remainingAmountLabel.TabIndex = 11;
			this.remainingAmountLabel.Text = "باقیمانده:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(12, 408);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 5);
			this.panel1.TabIndex = 10;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(24, 53);
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
			this.dateOfPrintLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.dateOfPrintLabel.ForeColor = System.Drawing.Color.White;
			this.dateOfPrintLabel.Location = new System.Drawing.Point(841, 134);
			this.dateOfPrintLabel.Name = "dateOfPrintLabel";
			this.dateOfPrintLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateOfPrintLabel.Size = new System.Drawing.Size(43, 22);
			this.dateOfPrintLabel.TabIndex = 5;
			this.dateOfPrintLabel.Text = "تاریخ:";
			// 
			// dateOfPrintTextBox
			// 
			this.dateOfPrintTextBox.AllowDrop = true;
			this.dateOfPrintTextBox.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.dateOfPrintTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.dateOfPrintTextBox.Location = new System.Drawing.Point(585, 128);
			this.dateOfPrintTextBox.Name = "dateOfPrintTextBox";
			this.dateOfPrintTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dateOfPrintTextBox.Size = new System.Drawing.Size(250, 35);
			this.dateOfPrintTextBox.TabIndex = 6;
			this.dateOfPrintTextBox.Text = "تاریخ";
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
			this.printButton.Font = new System.Drawing.Font("IRANSansX", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.printButton.ForeColor = System.Drawing.Color.Black;
			this.printButton.HoverState.FillColor = System.Drawing.Color.White;
			this.printButton.HoverState.FillColor2 = System.Drawing.SystemColors.ControlDarkDark;
			this.printButton.HoverState.Parent = this.printButton;
			this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
			this.printButton.Location = new System.Drawing.Point(718, 330);
			this.printButton.Name = "printButton";
			this.printButton.PressedColor = System.Drawing.Color.Teal;
			this.printButton.ShadowDecoration.Parent = this.printButton;
			this.printButton.Size = new System.Drawing.Size(180, 35);
			this.printButton.TabIndex = 2;
			this.printButton.Text = "چاپ رسید خرید";
			this.printButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// paymentButton
			// 
			this.paymentButton.Animated = true;
			this.paymentButton.BorderRadius = 5;
			this.paymentButton.CheckedState.Parent = this.paymentButton;
			this.paymentButton.CustomImages.Parent = this.paymentButton;
			this.paymentButton.FillColor = System.Drawing.Color.White;
			this.paymentButton.FillColor2 = System.Drawing.SystemColors.ControlDarkDark;
			this.paymentButton.Font = new System.Drawing.Font("IRANSansX", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.paymentButton.ForeColor = System.Drawing.Color.Black;
			this.paymentButton.HoverState.FillColor = System.Drawing.SystemColors.ControlDarkDark;
			this.paymentButton.HoverState.FillColor2 = System.Drawing.Color.White;
			this.paymentButton.HoverState.Parent = this.paymentButton;
			this.paymentButton.Image = ((System.Drawing.Image)(resources.GetObject("paymentButton.Image")));
			this.paymentButton.Location = new System.Drawing.Point(532, 330);
			this.paymentButton.Name = "paymentButton";
			this.paymentButton.PressedColor = System.Drawing.Color.Teal;
			this.paymentButton.ShadowDecoration.Parent = this.paymentButton;
			this.paymentButton.Size = new System.Drawing.Size(180, 35);
			this.paymentButton.TabIndex = 27;
			this.paymentButton.Text = "پرداخت  هزینه";
			this.paymentButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			// 
			// BillBuyReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(910, 460);
			this.Controls.Add(this.paymentButton);
			this.Controls.Add(this.printButton);
			this.Controls.Add(this.dateOfPrintLabel);
			this.Controls.Add(this.dateOfPrintTextBox);
			this.Controls.Add(this.logoPictureBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.remainingAmountLabel);
			this.Controls.Add(this.amountPaymentLabel);
			this.Controls.Add(this.amountPaymentTextBox);
			this.Controls.Add(this.totalSumPriceLable);
			this.Controls.Add(this.remainingAmountTextBox);
			this.Controls.Add(this.totalSumPriceTextBox);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.productListDataGridView);
			this.Controls.Add(this.topPanel);
			this.Name = "BillBuyReportForm";
			this.Text = "BillBuyForm";
			this.topPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
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
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox amountPaymentTextBox;
		private System.Windows.Forms.Label amountPaymentLabel;
		private System.Windows.Forms.Label remainingAmountLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label dateOfPrintLabel;
		private System.Windows.Forms.Label dateOfPrintTextBox;
		private Guna.UI2.WinForms.Guna2GradientButton printButton;
		public System.Windows.Forms.DataGridView productListDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product_Unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total_Amount;
		private Guna.UI2.WinForms.Guna2GradientButton paymentButton;
	}
}
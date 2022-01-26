
namespace Inventory_Forms
{
	partial class ProductSalesListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSalesListForm));
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.inventoryOutputDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sellerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.carrierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addOrderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addOrderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.inventoryOutputBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.inventoryOutputElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.InventoryOutputFormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.topPanel = new Mbb.Windows.Forms.Panel();
			this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
			this.closeButton = new Guna.UI2.WinForms.Guna2Button();
			this.searchGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
			this.searchTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.selectSearchComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.animateWindow = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
			this.closeFadeTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.inventoryOutputDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryOutputBindingSource)).BeginInit();
			this.topPanel.SuspendLayout();
			this.searchGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// inventoryOutputDataGridView
			// 
			this.inventoryOutputDataGridView.AllowUserToAddRows = false;
			this.inventoryOutputDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansFaNum", 8F);
			this.inventoryOutputDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.inventoryOutputDataGridView.AutoGenerateColumns = false;
			this.inventoryOutputDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.inventoryOutputDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.inventoryOutputDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inventoryOutputDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.inventoryOutputDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.inventoryOutputDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.inventoryOutputDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.inventoryOutputDataGridView.ColumnHeadersHeight = 35;
			this.inventoryOutputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.inventoryOutputDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.sellerNameDataGridViewTextBoxColumn,
            this.carrierNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn,
            this.productUnitDataGridViewTextBoxColumn,
            this.addOrderDateDataGridViewTextBoxColumn,
            this.addOrderTimeDataGridViewTextBoxColumn,
            this.productImageDataGridViewImageColumn});
			this.inventoryOutputDataGridView.DataSource = this.inventoryOutputBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.inventoryOutputDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.inventoryOutputDataGridView.EnableHeadersVisualStyles = false;
			this.inventoryOutputDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
			this.inventoryOutputDataGridView.Location = new System.Drawing.Point(12, 137);
			this.inventoryOutputDataGridView.Name = "inventoryOutputDataGridView";
			this.inventoryOutputDataGridView.ReadOnly = true;
			this.inventoryOutputDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.inventoryOutputDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.inventoryOutputDataGridView.RowHeadersVisible = false;
			this.inventoryOutputDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.inventoryOutputDataGridView.RowTemplate.Height = 25;
			this.inventoryOutputDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.inventoryOutputDataGridView.Size = new System.Drawing.Size(1040, 501);
			this.inventoryOutputDataGridView.TabIndex = 0;
			this.inventoryOutputDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
			this.inventoryOutputDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
			this.inventoryOutputDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("IRANSansFaNum", 8F);
			this.inventoryOutputDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.inventoryOutputDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.inventoryOutputDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.inventoryOutputDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.inventoryOutputDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
			this.inventoryOutputDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
			this.inventoryOutputDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.inventoryOutputDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.inventoryOutputDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.inventoryOutputDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.inventoryOutputDataGridView.ThemeStyle.HeaderStyle.Height = 35;
			this.inventoryOutputDataGridView.ThemeStyle.ReadOnly = true;
			this.inventoryOutputDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
			this.inventoryOutputDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.inventoryOutputDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.inventoryOutputDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.inventoryOutputDataGridView.ThemeStyle.RowsStyle.Height = 25;
			this.inventoryOutputDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
			this.inventoryOutputDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.FillWeight = 50F;
			this.idDataGridViewTextBoxColumn.HeaderText = "ردیف";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// clientNameDataGridViewTextBoxColumn
			// 
			this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
			this.clientNameDataGridViewTextBoxColumn.HeaderText = "نام مشتری";
			this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
			this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sellerNameDataGridViewTextBoxColumn
			// 
			this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "Seller_Name";
			this.sellerNameDataGridViewTextBoxColumn.HeaderText = "نام فروشنده";
			this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
			this.sellerNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// carrierNameDataGridViewTextBoxColumn
			// 
			this.carrierNameDataGridViewTextBoxColumn.DataPropertyName = "Carrier_Name";
			this.carrierNameDataGridViewTextBoxColumn.HeaderText = "نام حامل کالا";
			this.carrierNameDataGridViewTextBoxColumn.Name = "carrierNameDataGridViewTextBoxColumn";
			this.carrierNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
			this.productNameDataGridViewTextBoxColumn.FillWeight = 200F;
			this.productNameDataGridViewTextBoxColumn.HeaderText = "نام کالا";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productPriceDataGridViewTextBoxColumn
			// 
			this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "Product_Price";
			this.productPriceDataGridViewTextBoxColumn.HeaderText = "قیمت کالا";
			this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
			this.productPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productQuantityDataGridViewTextBoxColumn
			// 
			this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "Product_Quantity";
			this.productQuantityDataGridViewTextBoxColumn.FillWeight = 50F;
			this.productQuantityDataGridViewTextBoxColumn.HeaderText = "تعداد";
			this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
			this.productQuantityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productUnitDataGridViewTextBoxColumn
			// 
			this.productUnitDataGridViewTextBoxColumn.DataPropertyName = "Product_Unit";
			this.productUnitDataGridViewTextBoxColumn.FillWeight = 50F;
			this.productUnitDataGridViewTextBoxColumn.HeaderText = "واحد";
			this.productUnitDataGridViewTextBoxColumn.Name = "productUnitDataGridViewTextBoxColumn";
			this.productUnitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// addOrderDateDataGridViewTextBoxColumn
			// 
			this.addOrderDateDataGridViewTextBoxColumn.DataPropertyName = "Add_Order_Date";
			this.addOrderDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
			this.addOrderDateDataGridViewTextBoxColumn.Name = "addOrderDateDataGridViewTextBoxColumn";
			this.addOrderDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// addOrderTimeDataGridViewTextBoxColumn
			// 
			this.addOrderTimeDataGridViewTextBoxColumn.DataPropertyName = "Add_Order_Time";
			this.addOrderTimeDataGridViewTextBoxColumn.HeaderText = "زمان ثبت";
			this.addOrderTimeDataGridViewTextBoxColumn.Name = "addOrderTimeDataGridViewTextBoxColumn";
			this.addOrderTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productImageDataGridViewImageColumn
			// 
			this.productImageDataGridViewImageColumn.DataPropertyName = "Product_Image";
			this.productImageDataGridViewImageColumn.HeaderText = "تصویر کالا";
			this.productImageDataGridViewImageColumn.Name = "productImageDataGridViewImageColumn";
			this.productImageDataGridViewImageColumn.ReadOnly = true;
			this.productImageDataGridViewImageColumn.Visible = false;
			// 
			// inventoryOutputBindingSource
			// 
			this.inventoryOutputBindingSource.DataSource = typeof(Models.InventoryOutput);
			// 
			// inventoryOutputElipse
			// 
			this.inventoryOutputElipse.BorderRadius = 25;
			this.inventoryOutputElipse.TargetControl = this.inventoryOutputDataGridView;
			// 
			// InventoryOutputFormElipse
			// 
			this.InventoryOutputFormElipse.BorderRadius = 25;
			this.InventoryOutputFormElipse.TargetControl = this;
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.minimizeButton);
			this.topPanel.Controls.Add(this.closeButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(1064, 30);
			this.topPanel.TabIndex = 4;
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
			// searchGroupBox
			// 
			this.searchGroupBox.BorderRadius = 10;
			this.searchGroupBox.Controls.Add(this.searchTextBox);
			this.searchGroupBox.Controls.Add(this.selectSearchComboBox);
			this.searchGroupBox.CustomBorderColor = System.Drawing.Color.Silver;
			this.searchGroupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
			this.searchGroupBox.FillColor = System.Drawing.Color.Transparent;
			this.searchGroupBox.Font = new System.Drawing.Font("IRANSansX", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.searchGroupBox.ForeColor = System.Drawing.Color.White;
			this.searchGroupBox.Location = new System.Drawing.Point(12, 36);
			this.searchGroupBox.Name = "searchGroupBox";
			this.searchGroupBox.ShadowDecoration.Parent = this.searchGroupBox;
			this.searchGroupBox.Size = new System.Drawing.Size(1040, 95);
			this.searchGroupBox.TabIndex = 5;
			this.searchGroupBox.Text = "جستجو";
			this.searchGroupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.searchGroupBox.TextOffset = new System.Drawing.Point(0, -4);
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
			this.searchTextBox.BorderRadius = 25;
			this.searchTextBox.BorderThickness = 1;
			this.searchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.searchTextBox.DefaultFont = new System.Drawing.Font("IRANSansFaNum", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.searchTextBox.DefaultText = "";
			this.searchTextBox.FillColor = System.Drawing.Color.White;
			this.searchTextBox.ForeColor = System.Drawing.Color.Black;
			this.searchTextBox.HideSelection = true;
			this.searchTextBox.IconLeft = null;
			this.searchTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchTextBox.IconPadding = 7;
			this.searchTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("searchTextBox.IconRight")));
			this.searchTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchTextBox.Lines = new string[0];
			this.searchTextBox.Location = new System.Drawing.Point(538, 45);
			this.searchTextBox.MaxLength = 32767;
			this.searchTextBox.MinimumSize = new System.Drawing.Size(100, 36);
			this.searchTextBox.Modified = false;
			this.searchTextBox.Multiline = false;
			this.searchTextBox.Name = "searchTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.searchTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.Cyan;
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Silver;
			stateProperties4.FillColor = System.Drawing.Color.White;
			stateProperties4.ForeColor = System.Drawing.Color.Black;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchTextBox.OnIdleState = stateProperties4;
			this.searchTextBox.PasswordChar = '\0';
			this.searchTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.searchTextBox.PlaceholderText = "جستجو بر اساس (نام مشتری، نام کالا و ...)";
			this.searchTextBox.ReadOnly = false;
			this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.searchTextBox.SelectedText = "";
			this.searchTextBox.SelectionLength = 0;
			this.searchTextBox.SelectionStart = 0;
			this.searchTextBox.ShortcutsEnabled = true;
			this.searchTextBox.Size = new System.Drawing.Size(479, 36);
			this.searchTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
			this.searchTextBox.TabIndex = 3;
			this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.searchTextBox.TextMarginBottom = 0;
			this.searchTextBox.TextMarginLeft = 5;
			this.searchTextBox.TextMarginTop = 0;
			this.searchTextBox.TextPlaceholder = "جستجو بر اساس (نام مشتری، نام کالا و ...)";
			this.searchTextBox.UseSystemPasswordChar = false;
			this.searchTextBox.WordWrap = true;
			this.searchTextBox.TextChange += new System.EventHandler(this.SearchTextBox_TextChange);
			this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
			this.searchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
			// 
			// selectSearchComboBox
			// 
			this.selectSearchComboBox.Animated = true;
			this.selectSearchComboBox.AutoRoundedCorners = true;
			this.selectSearchComboBox.BackColor = System.Drawing.Color.Transparent;
			this.selectSearchComboBox.BorderColor = System.Drawing.Color.Silver;
			this.selectSearchComboBox.BorderRadius = 17;
			this.selectSearchComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectSearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectSearchComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.selectSearchComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.selectSearchComboBox.FocusedState.Parent = this.selectSearchComboBox;
			this.selectSearchComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectSearchComboBox.ForeColor = System.Drawing.Color.Black;
			this.selectSearchComboBox.FormattingEnabled = true;
			this.selectSearchComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.selectSearchComboBox.HoverState.Parent = this.selectSearchComboBox;
			this.selectSearchComboBox.ItemHeight = 30;
			this.selectSearchComboBox.Items.AddRange(new object[] {
            "...انتخاب جستجو",
            "نام مشتری",
            "نام فروشنده",
            "نام حامل کالا",
            "نام کالا",
            "تاریخ ثبت"});
			this.selectSearchComboBox.ItemsAppearance.BackColor = System.Drawing.Color.White;
			this.selectSearchComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
			this.selectSearchComboBox.ItemsAppearance.Parent = this.selectSearchComboBox;
			this.selectSearchComboBox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Teal;
			this.selectSearchComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
			this.selectSearchComboBox.Location = new System.Drawing.Point(306, 45);
			this.selectSearchComboBox.Name = "selectSearchComboBox";
			this.selectSearchComboBox.ShadowDecoration.Parent = this.selectSearchComboBox;
			this.selectSearchComboBox.Size = new System.Drawing.Size(210, 36);
			this.selectSearchComboBox.StartIndex = 0;
			this.selectSearchComboBox.TabIndex = 2;
			this.selectSearchComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.selectSearchComboBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.selectSearchComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectSearchComboBox_SelectedIndexChanged);
			// 
			// animateWindow
			// 
			this.animateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
			this.animateWindow.Interval = 200;
			this.animateWindow.TargetControl = this;
			// 
			// closeFadeTimer
			// 
			this.closeFadeTimer.Interval = 5;
			this.closeFadeTimer.Tick += new System.EventHandler(this.CloseFadeTimer_Tick);
			// 
			// ProductSalesListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 650);
			this.Controls.Add(this.searchGroupBox);
			this.Controls.Add(this.topPanel);
			this.Controls.Add(this.inventoryOutputDataGridView);
			this.Name = "ProductSalesListForm";
			this.Text = "InventoryOutputForm";
			this.Load += new System.EventHandler(this.InventoryOutputForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.inventoryOutputDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryOutputBindingSource)).EndInit();
			this.topPanel.ResumeLayout(false);
			this.searchGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2DataGridView inventoryOutputDataGridView;
		private System.Windows.Forms.BindingSource inventoryOutputBindingSource;
		private Guna.UI2.WinForms.Guna2Elipse inventoryOutputElipse;
		private Guna.UI2.WinForms.Guna2Elipse InventoryOutputFormElipse;
		private Mbb.Windows.Forms.Panel topPanel;
		private Guna.UI2.WinForms.Guna2Button minimizeButton;
		private Guna.UI2.WinForms.Guna2Button closeButton;
		private Guna.UI2.WinForms.Guna2GroupBox searchGroupBox;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchTextBox;
		private Guna.UI2.WinForms.Guna2ComboBox selectSearchComboBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn carrierNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productUnitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addOrderDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addOrderTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn productImageDataGridViewImageColumn;
		private Guna.UI.WinForms.GunaAnimateWindow animateWindow;
		private System.Windows.Forms.Timer closeFadeTimer;
	}
}
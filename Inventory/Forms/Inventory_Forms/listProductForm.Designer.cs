
namespace Inventory_Forms
{
	partial class ListProductForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProductForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.topPanel = new Mbb.Windows.Forms.Panel();
			this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
			this.closeButton = new Guna.UI2.WinForms.Guna2Button();
			this.sendToBillButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.cancelButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.inventoryHoldingDataGridViewElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.inventoryHoldingDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productSalePriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productQuantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productUnitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Number_Orders = new Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewIntegerInputColumn();
			this.productImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.inventoryHoldingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searckPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.searchProducteTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.inventoryHoldingDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryHoldingBindingSource)).BeginInit();
			this.searckPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.SystemColors.Control;
			this.topPanel.Controls.Add(this.minimizeButton);
			this.topPanel.Controls.Add(this.closeButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(1350, 30);
			this.topPanel.TabIndex = 1;
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
			// 
			// sendToBillButton
			// 
			this.sendToBillButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sendToBillButton.Animated = true;
			this.sendToBillButton.BorderRadius = 5;
			this.sendToBillButton.CheckedState.Parent = this.sendToBillButton;
			this.sendToBillButton.CustomImages.Parent = this.sendToBillButton;
			this.sendToBillButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.sendToBillButton.FillColor2 = System.Drawing.Color.White;
			this.sendToBillButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sendToBillButton.ForeColor = System.Drawing.Color.White;
			this.sendToBillButton.HoverState.FillColor = System.Drawing.Color.White;
			this.sendToBillButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.sendToBillButton.HoverState.Parent = this.sendToBillButton;
			this.sendToBillButton.Location = new System.Drawing.Point(1188, 509);
			this.sendToBillButton.Name = "sendToBillButton";
			this.sendToBillButton.ShadowDecoration.Parent = this.sendToBillButton;
			this.sendToBillButton.Size = new System.Drawing.Size(150, 35);
			this.sendToBillButton.TabIndex = 2;
			this.sendToBillButton.Text = "ارسال به فاکتور";
			this.sendToBillButton.Click += new System.EventHandler(this.SendToBillButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.Animated = true;
			this.cancelButton.BorderRadius = 5;
			this.cancelButton.CheckedState.Parent = this.cancelButton;
			this.cancelButton.CustomImages.Parent = this.cancelButton;
			this.cancelButton.FillColor = System.Drawing.Color.White;
			this.cancelButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.cancelButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.ForeColor = System.Drawing.Color.White;
			this.cancelButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.cancelButton.HoverState.FillColor2 = System.Drawing.Color.White;
			this.cancelButton.HoverState.Parent = this.cancelButton;
			this.cancelButton.Location = new System.Drawing.Point(1032, 509);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.ShadowDecoration.Parent = this.cancelButton;
			this.cancelButton.Size = new System.Drawing.Size(150, 35);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "انصراف";
			// 
			// inventoryHoldingDataGridViewElipse
			// 
			this.inventoryHoldingDataGridViewElipse.BorderRadius = 15;
			this.inventoryHoldingDataGridViewElipse.TargetControl = this.inventoryHoldingDataGridView;
			// 
			// inventoryHoldingDataGridView
			// 
			this.inventoryHoldingDataGridView.AllowUserToAddRows = false;
			this.inventoryHoldingDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
			dataGridViewCellStyle10.Font = new System.Drawing.Font("IRANSansXFaNum", 8F);
			this.inventoryHoldingDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
			this.inventoryHoldingDataGridView.AutoGenerateColumns = false;
			this.inventoryHoldingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.inventoryHoldingDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.inventoryHoldingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inventoryHoldingDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.inventoryHoldingDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.inventoryHoldingDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("IRANSansXFaNum", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.inventoryHoldingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.inventoryHoldingDataGridView.ColumnHeadersHeight = 35;
			this.inventoryHoldingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.inventoryHoldingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.productNameDataGridViewTextBoxColumn1,
            this.productSalePriceDataGridViewTextBoxColumn1,
            this.productQuantityDataGridViewTextBoxColumn1,
            this.productUnitDataGridViewTextBoxColumn1,
            this.Number_Orders,
            this.productImageDataGridViewImageColumn});
			this.inventoryHoldingDataGridView.DataSource = this.inventoryHoldingBindingSource;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.inventoryHoldingDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
			this.inventoryHoldingDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
			this.inventoryHoldingDataGridView.EnableHeadersVisualStyles = false;
			this.inventoryHoldingDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
			this.inventoryHoldingDataGridView.Location = new System.Drawing.Point(0, 82);
			this.inventoryHoldingDataGridView.Name = "inventoryHoldingDataGridView";
			this.inventoryHoldingDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.inventoryHoldingDataGridView.RowHeadersVisible = false;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.inventoryHoldingDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle13;
			this.inventoryHoldingDataGridView.RowTemplate.Height = 30;
			this.inventoryHoldingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.inventoryHoldingDataGridView.Size = new System.Drawing.Size(1350, 421);
			this.inventoryHoldingDataGridView.TabIndex = 1;
			this.inventoryHoldingDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
			this.inventoryHoldingDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
			this.inventoryHoldingDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F);
			this.inventoryHoldingDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.inventoryHoldingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.inventoryHoldingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.inventoryHoldingDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.inventoryHoldingDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
			this.inventoryHoldingDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
			this.inventoryHoldingDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.inventoryHoldingDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.inventoryHoldingDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.inventoryHoldingDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.inventoryHoldingDataGridView.ThemeStyle.HeaderStyle.Height = 35;
			this.inventoryHoldingDataGridView.ThemeStyle.ReadOnly = false;
			this.inventoryHoldingDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
			this.inventoryHoldingDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.inventoryHoldingDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.inventoryHoldingDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.inventoryHoldingDataGridView.ThemeStyle.RowsStyle.Height = 30;
			this.inventoryHoldingDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
			this.inventoryHoldingDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.inventoryHoldingDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryHoldingDataGridView_CellClick);
			this.inventoryHoldingDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryHoldingDataGridView_CellDoubleClick);
			this.inventoryHoldingDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryHoldingDataGridView_CellValueChanged);
			// 
			// idDataGridViewTextBoxColumn1
			// 
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn1.FillWeight = 50F;
			this.idDataGridViewTextBoxColumn1.HeaderText = "ردیف";
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			// 
			// productNameDataGridViewTextBoxColumn1
			// 
			this.productNameDataGridViewTextBoxColumn1.DataPropertyName = "Product_Name";
			this.productNameDataGridViewTextBoxColumn1.FillWeight = 250F;
			this.productNameDataGridViewTextBoxColumn1.HeaderText = "نام کالا";
			this.productNameDataGridViewTextBoxColumn1.Name = "productNameDataGridViewTextBoxColumn1";
			// 
			// productSalePriceDataGridViewTextBoxColumn1
			// 
			this.productSalePriceDataGridViewTextBoxColumn1.DataPropertyName = "Product_Sale_Price";
			this.productSalePriceDataGridViewTextBoxColumn1.HeaderText = "قیمت فروش کالا";
			this.productSalePriceDataGridViewTextBoxColumn1.Name = "productSalePriceDataGridViewTextBoxColumn1";
			// 
			// productQuantityDataGridViewTextBoxColumn1
			// 
			this.productQuantityDataGridViewTextBoxColumn1.DataPropertyName = "Product_Quantity";
			this.productQuantityDataGridViewTextBoxColumn1.FillWeight = 50F;
			this.productQuantityDataGridViewTextBoxColumn1.HeaderText = "تعداد کالا";
			this.productQuantityDataGridViewTextBoxColumn1.Name = "productQuantityDataGridViewTextBoxColumn1";
			// 
			// productUnitDataGridViewTextBoxColumn1
			// 
			this.productUnitDataGridViewTextBoxColumn1.DataPropertyName = "Product_Unit";
			this.productUnitDataGridViewTextBoxColumn1.FillWeight = 75F;
			this.productUnitDataGridViewTextBoxColumn1.HeaderText = "واحد کالا";
			this.productUnitDataGridViewTextBoxColumn1.Name = "productUnitDataGridViewTextBoxColumn1";
			// 
			// Number_Orders
			// 
			// 
			// 
			// 
			this.Number_Orders.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
			this.Number_Orders.BackgroundStyle.Class = "DataGridViewNumericBorder";
			this.Number_Orders.BackgroundStyle.CornerDiameter = 15;
			this.Number_Orders.BackgroundStyle.CornerType = Stimulsoft.Controls.Win.DotNetBar.eCornerType.Rounded;
			this.Number_Orders.BackgroundStyle.TextAlignment = Stimulsoft.Controls.Win.DotNetBar.eStyleTextAlignment.Center;
			this.Number_Orders.BackgroundStyle.TextColor = System.Drawing.Color.Black;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("IRANSansFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Number_Orders.DefaultCellStyle = dataGridViewCellStyle12;
			this.Number_Orders.HeaderText = "تعداد سفارش";
			this.Number_Orders.InputHorizontalAlignment = Stimulsoft.Controls.Win.Editors.eHorizontalAlignment.Center;
			this.Number_Orders.MinValue = 0;
			this.Number_Orders.Name = "Number_Orders";
			this.Number_Orders.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Number_Orders.ShowUpDown = true;
			// 
			// productImageDataGridViewImageColumn
			// 
			this.productImageDataGridViewImageColumn.DataPropertyName = "Product_Image";
			this.productImageDataGridViewImageColumn.HeaderText = "تصویر کالا";
			this.productImageDataGridViewImageColumn.Name = "productImageDataGridViewImageColumn";
			// 
			// inventoryHoldingBindingSource
			// 
			this.inventoryHoldingBindingSource.DataSource = typeof(Models.InventoryHolding);
			// 
			// searckPanel
			// 
			this.searckPanel.Controls.Add(this.searchProducteTextBox);
			this.searckPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.searckPanel.Location = new System.Drawing.Point(0, 30);
			this.searckPanel.Name = "searckPanel";
			this.searckPanel.ShadowDecoration.Parent = this.searckPanel;
			this.searckPanel.Size = new System.Drawing.Size(1350, 52);
			this.searckPanel.TabIndex = 0;
			// 
			// searchProducteTextBox
			// 
			this.searchProducteTextBox.AcceptsReturn = false;
			this.searchProducteTextBox.AcceptsTab = false;
			this.searchProducteTextBox.AnimationSpeed = 200;
			this.searchProducteTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.searchProducteTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.searchProducteTextBox.BackColor = System.Drawing.Color.Transparent;
			this.searchProducteTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchProducteTextBox.BackgroundImage")));
			this.searchProducteTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.searchProducteTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.searchProducteTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.searchProducteTextBox.BorderColorIdle = System.Drawing.Color.Silver;
			this.searchProducteTextBox.BorderRadius = 25;
			this.searchProducteTextBox.BorderThickness = 1;
			this.searchProducteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.searchProducteTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.searchProducteTextBox.DefaultFont = new System.Drawing.Font("IRANSansFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchProducteTextBox.DefaultText = "";
			this.searchProducteTextBox.FillColor = System.Drawing.Color.White;
			this.searchProducteTextBox.HideSelection = true;
			this.searchProducteTextBox.IconLeft = null;
			this.searchProducteTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchProducteTextBox.IconPadding = 7;
			this.searchProducteTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("searchProducteTextBox.IconRight")));
			this.searchProducteTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchProducteTextBox.Lines = new string[0];
			this.searchProducteTextBox.Location = new System.Drawing.Point(12, 9);
			this.searchProducteTextBox.MaxLength = 32767;
			this.searchProducteTextBox.MinimumSize = new System.Drawing.Size(100, 35);
			this.searchProducteTextBox.Modified = false;
			this.searchProducteTextBox.Multiline = false;
			this.searchProducteTextBox.Name = "searchProducteTextBox";
			stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties9.FillColor = System.Drawing.Color.Empty;
			stateProperties9.ForeColor = System.Drawing.Color.Empty;
			stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchProducteTextBox.OnActiveState = stateProperties9;
			stateProperties10.BorderColor = System.Drawing.Color.Empty;
			stateProperties10.FillColor = System.Drawing.Color.White;
			stateProperties10.ForeColor = System.Drawing.Color.Empty;
			stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.searchProducteTextBox.OnDisabledState = stateProperties10;
			stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties11.FillColor = System.Drawing.Color.Empty;
			stateProperties11.ForeColor = System.Drawing.Color.Empty;
			stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchProducteTextBox.OnHoverState = stateProperties11;
			stateProperties12.BorderColor = System.Drawing.Color.Silver;
			stateProperties12.FillColor = System.Drawing.Color.White;
			stateProperties12.ForeColor = System.Drawing.Color.Empty;
			stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchProducteTextBox.OnIdleState = stateProperties12;
			this.searchProducteTextBox.PasswordChar = '\0';
			this.searchProducteTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.searchProducteTextBox.PlaceholderText = "جستجوی نام کالا...";
			this.searchProducteTextBox.ReadOnly = false;
			this.searchProducteTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.searchProducteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.searchProducteTextBox.SelectedText = "";
			this.searchProducteTextBox.SelectionLength = 0;
			this.searchProducteTextBox.SelectionStart = 0;
			this.searchProducteTextBox.ShortcutsEnabled = true;
			this.searchProducteTextBox.Size = new System.Drawing.Size(1326, 35);
			this.searchProducteTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
			this.searchProducteTextBox.TabIndex = 0;
			this.searchProducteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.searchProducteTextBox.TextMarginBottom = 0;
			this.searchProducteTextBox.TextMarginLeft = 5;
			this.searchProducteTextBox.TextMarginTop = 0;
			this.searchProducteTextBox.TextPlaceholder = "جستجوی نام کالا...";
			this.searchProducteTextBox.UseSystemPasswordChar = false;
			this.searchProducteTextBox.WordWrap = true;
			// 
			// ListProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1350, 552);
			this.Controls.Add(this.inventoryHoldingDataGridView);
			this.Controls.Add(this.searckPanel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.sendToBillButton);
			this.Controls.Add(this.topPanel);
			this.Font = new System.Drawing.Font("IRANSansXFaNum", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "ListProductForm";
			this.Text = "listProductForm";
			this.Load += new System.EventHandler(this.ListProductForm_Load);
			this.topPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.inventoryHoldingDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryHoldingBindingSource)).EndInit();
			this.searckPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Mbb.Windows.Forms.Panel topPanel;
		private Guna.UI2.WinForms.Guna2Button minimizeButton;
		private Guna.UI2.WinForms.Guna2Button closeButton;
		private Guna.UI2.WinForms.Guna2GradientButton sendToBillButton;
		private Guna.UI2.WinForms.Guna2GradientButton cancelButton;
		private Guna.UI2.WinForms.Guna2Elipse inventoryHoldingDataGridViewElipse;
		private Guna.UI2.WinForms.Guna2Panel searckPanel;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchProducteTextBox;
		private System.Windows.Forms.BindingSource inventoryHoldingBindingSource;
		private Guna.UI2.WinForms.Guna2DataGridView inventoryHoldingDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn productSalePriceDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn productUnitDataGridViewTextBoxColumn1;
		private Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewIntegerInputColumn Number_Orders;
		private System.Windows.Forms.DataGridViewImageColumn productImageDataGridViewImageColumn;
	}
}
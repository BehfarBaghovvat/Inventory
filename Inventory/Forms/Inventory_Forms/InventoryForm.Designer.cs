
namespace Inventory_Forms
{
	partial class InventoryForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.inventoryHoldingDataGridView = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productPurchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Product_Sale_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Product_Image = new System.Windows.Forms.DataGridViewImageColumn();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventoryHoldingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productNameSearchTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.inventoryHoldingDataGridViewElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.inventoryHoldingDataGridView)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.inventoryHoldingBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.Transparent;
			this.mainPanel.BorderColor = System.Drawing.Color.Indigo;
			this.mainPanel.BorderRadius = 15;
			this.mainPanel.BorderThickness = 5;
			this.mainPanel.Controls.Add(this.inventoryHoldingDataGridView);
			this.mainPanel.Controls.Add(this.productNameSearchTextBox);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.mainPanel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
			this.mainPanel.Size = new System.Drawing.Size(1150, 650);
			this.mainPanel.TabIndex = 0;
			this.mainPanel.UseTransparentBackground = true;
			// 
			// inventoryHoldingDataGridView
			// 
			this.inventoryHoldingDataGridView.AllowUserToAddRows = false;
			this.inventoryHoldingDataGridView.AllowUserToDeleteRows = false;
			this.inventoryHoldingDataGridView.AllowUserToResizeColumns = false;
			this.inventoryHoldingDataGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.inventoryHoldingDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.inventoryHoldingDataGridView.AutoGenerateColumns = false;
			this.inventoryHoldingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.inventoryHoldingDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.inventoryHoldingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inventoryHoldingDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.inventoryHoldingDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.inventoryHoldingDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.inventoryHoldingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.inventoryHoldingDataGridView.ColumnHeadersHeight = 35;
			this.inventoryHoldingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.inventoryHoldingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn,
            this.productUnitDataGridViewTextBoxColumn,
            this.productPurchasePriceDataGridViewTextBoxColumn,
            this.Product_Sale_Price,
            this.registrationDateDataGridViewTextBoxColumn,
            this.registrationTimeDataGridViewTextBoxColumn,
            this.Product_Image});
			this.inventoryHoldingDataGridView.ContextMenuStrip = this.contextMenuStrip;
			this.inventoryHoldingDataGridView.DataSource = this.inventoryHoldingBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.inventoryHoldingDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.inventoryHoldingDataGridView.EnableHeadersVisualStyles = false;
			this.inventoryHoldingDataGridView.Location = new System.Drawing.Point(13, 58);
			this.inventoryHoldingDataGridView.MultiSelect = false;
			this.inventoryHoldingDataGridView.Name = "inventoryHoldingDataGridView";
			this.inventoryHoldingDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.inventoryHoldingDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.inventoryHoldingDataGridView.RowHeadersVisible = false;
			this.inventoryHoldingDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			this.inventoryHoldingDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.inventoryHoldingDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.inventoryHoldingDataGridView.RowTemplate.Height = 50;
			this.inventoryHoldingDataGridView.RowTemplate.ReadOnly = true;
			this.inventoryHoldingDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.inventoryHoldingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.inventoryHoldingDataGridView.Size = new System.Drawing.Size(1124, 582);
			this.inventoryHoldingDataGridView.TabIndex = 1;
			this.inventoryHoldingDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryHoldingDataGridView_CellClick);
			this.inventoryHoldingDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryHoldingDataGridView_CellDoubleClick);
			this.inventoryHoldingDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryHoldingDataGridView_CellValueChanged);
			this.inventoryHoldingDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryHoldingDataGridView_RowEnter);
			this.inventoryHoldingDataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryHoldingDataGridView_RowLeave);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.FillWeight = 50F;
			this.idDataGridViewTextBoxColumn.HeaderText = "ردیف";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
			this.productNameDataGridViewTextBoxColumn.FillWeight = 150F;
			this.productNameDataGridViewTextBoxColumn.HeaderText = "نام کالا";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			// 
			// productQuantityDataGridViewTextBoxColumn
			// 
			this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "Product_Quantity";
			this.productQuantityDataGridViewTextBoxColumn.FillWeight = 50F;
			this.productQuantityDataGridViewTextBoxColumn.HeaderText = "تعداد کالا";
			this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
			// 
			// productUnitDataGridViewTextBoxColumn
			// 
			this.productUnitDataGridViewTextBoxColumn.DataPropertyName = "Product_Unit";
			this.productUnitDataGridViewTextBoxColumn.FillWeight = 50F;
			this.productUnitDataGridViewTextBoxColumn.HeaderText = "واحد کالا";
			this.productUnitDataGridViewTextBoxColumn.Name = "productUnitDataGridViewTextBoxColumn";
			// 
			// productPurchasePriceDataGridViewTextBoxColumn
			// 
			this.productPurchasePriceDataGridViewTextBoxColumn.DataPropertyName = "Product_Purchase_Price";
			this.productPurchasePriceDataGridViewTextBoxColumn.HeaderText = "قیمت خرید کالا";
			this.productPurchasePriceDataGridViewTextBoxColumn.Name = "productPurchasePriceDataGridViewTextBoxColumn";
			// 
			// Product_Sale_Price
			// 
			this.Product_Sale_Price.DataPropertyName = "Product_Sale_Price";
			this.Product_Sale_Price.HeaderText = "قیمت فروش کالا";
			this.Product_Sale_Price.Name = "Product_Sale_Price";
			// 
			// registrationDateDataGridViewTextBoxColumn
			// 
			this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "Registration_Date";
			this.registrationDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
			this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
			// 
			// registrationTimeDataGridViewTextBoxColumn
			// 
			this.registrationTimeDataGridViewTextBoxColumn.DataPropertyName = "Registration_Time";
			this.registrationTimeDataGridViewTextBoxColumn.HeaderText = "زمان ثبت";
			this.registrationTimeDataGridViewTextBoxColumn.Name = "registrationTimeDataGridViewTextBoxColumn";
			// 
			// Product_Image
			// 
			this.Product_Image.DataPropertyName = "Product_Image";
			this.Product_Image.HeaderText = "تصویر کالا";
			this.Product_Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Product_Image.Name = "Product_Image";
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showImageToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.contextMenuStrip.Size = new System.Drawing.Size(166, 26);
			// 
			// showImageToolStripMenuItem
			// 
			this.showImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showImageToolStripMenuItem.Image")));
			this.showImageToolStripMenuItem.Name = "showImageToolStripMenuItem";
			this.showImageToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.showImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
			this.showImageToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.showImageToolStripMenuItem.Text = "نمایش عکس";
			this.showImageToolStripMenuItem.Click += new System.EventHandler(this.ShowImageToolStripMenuItem_Click);
			// 
			// inventoryHoldingBindingSource
			// 
			this.inventoryHoldingBindingSource.DataSource = typeof(Models.InventoryHolding);
			// 
			// productNameSearchTextBox
			// 
			this.productNameSearchTextBox.AcceptsReturn = false;
			this.productNameSearchTextBox.AcceptsTab = false;
			this.productNameSearchTextBox.AnimationSpeed = 200;
			this.productNameSearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.productNameSearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.productNameSearchTextBox.BackColor = System.Drawing.Color.Transparent;
			this.productNameSearchTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productNameSearchTextBox.BackgroundImage")));
			this.productNameSearchTextBox.BorderColorActive = System.Drawing.Color.Fuchsia;
			this.productNameSearchTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.productNameSearchTextBox.BorderColorHover = System.Drawing.Color.Aqua;
			this.productNameSearchTextBox.BorderColorIdle = System.Drawing.Color.Gray;
			this.productNameSearchTextBox.BorderRadius = 30;
			this.productNameSearchTextBox.BorderThickness = 2;
			this.productNameSearchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.productNameSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.productNameSearchTextBox.DefaultFont = new System.Drawing.Font("IRANSansFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productNameSearchTextBox.DefaultText = "";
			this.productNameSearchTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.productNameSearchTextBox.ForeColor = System.Drawing.Color.White;
			this.productNameSearchTextBox.HideSelection = true;
			this.productNameSearchTextBox.IconLeft = null;
			this.productNameSearchTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.productNameSearchTextBox.IconPadding = 7;
			this.productNameSearchTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("productNameSearchTextBox.IconRight")));
			this.productNameSearchTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.productNameSearchTextBox.Lines = new string[0];
			this.productNameSearchTextBox.Location = new System.Drawing.Point(13, 12);
			this.productNameSearchTextBox.MaxLength = 32767;
			this.productNameSearchTextBox.MinimumSize = new System.Drawing.Size(100, 35);
			this.productNameSearchTextBox.Modified = false;
			this.productNameSearchTextBox.Multiline = false;
			this.productNameSearchTextBox.Name = "productNameSearchTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.Fuchsia;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.productNameSearchTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.productNameSearchTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.Aqua;
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.productNameSearchTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Gray;
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties4.ForeColor = System.Drawing.Color.White;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.productNameSearchTextBox.OnIdleState = stateProperties4;
			this.productNameSearchTextBox.PasswordChar = '\0';
			this.productNameSearchTextBox.PlaceholderForeColor = System.Drawing.Color.LightGray;
			this.productNameSearchTextBox.PlaceholderText = "...جستجوی نام کالا";
			this.productNameSearchTextBox.ReadOnly = false;
			this.productNameSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.productNameSearchTextBox.SelectedText = "";
			this.productNameSearchTextBox.SelectionLength = 0;
			this.productNameSearchTextBox.SelectionStart = 0;
			this.productNameSearchTextBox.ShortcutsEnabled = true;
			this.productNameSearchTextBox.Size = new System.Drawing.Size(1124, 40);
			this.productNameSearchTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
			this.productNameSearchTextBox.TabIndex = 0;
			this.productNameSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.productNameSearchTextBox.TextMarginBottom = 0;
			this.productNameSearchTextBox.TextMarginLeft = 5;
			this.productNameSearchTextBox.TextMarginTop = 0;
			this.productNameSearchTextBox.TextPlaceholder = "...جستجوی نام کالا";
			this.productNameSearchTextBox.UseSystemPasswordChar = false;
			this.productNameSearchTextBox.WordWrap = true;
			this.productNameSearchTextBox.TextChange += new System.EventHandler(this.ProductNameSearchTextBox_TextChange);
			this.productNameSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductNameSearchTextBox_KeyPress);
			this.productNameSearchTextBox.Enter += new System.EventHandler(this.ProductNameSearchTextBox_Enter);
			// 
			// inventoryHoldingDataGridViewElipse
			// 
			this.inventoryHoldingDataGridViewElipse.BorderRadius = 20;
			this.inventoryHoldingDataGridViewElipse.TargetControl = this.inventoryHoldingDataGridView;
			// 
			// InventoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(1150, 650);
			this.Controls.Add(this.mainPanel);
			this.Name = "InventoryForm";
			this.Text = "InventoryForm";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.inventoryHoldingDataGridView)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.inventoryHoldingBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel mainPanel;
		private System.Windows.Forms.DataGridView inventoryHoldingDataGridView;
		private System.Windows.Forms.BindingSource inventoryHoldingBindingSource;
		private Guna.UI2.WinForms.Guna2Elipse inventoryHoldingDataGridViewElipse;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox productNameSearchTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn editDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn editTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem showImageToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productUnitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productPurchasePriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product_Sale_Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn Product_Image;
	}
}
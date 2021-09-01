
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
			this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inventoryHoldingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productNameSearchTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.inventoryHoldingDataGridViewElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.inventoryHoldingDataGridView)).BeginInit();
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
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
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
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlueViolet;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.inventoryHoldingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.inventoryHoldingDataGridView.ColumnHeadersHeight = 40;
			this.inventoryHoldingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.inventoryHoldingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn,
            this.productUnitDataGridViewTextBoxColumn,
            this.productPurchasePriceDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.registrationTimeDataGridViewTextBoxColumn});
			this.inventoryHoldingDataGridView.DataSource = this.inventoryHoldingBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Violet;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkViolet;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.inventoryHoldingDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.inventoryHoldingDataGridView.EnableHeadersVisualStyles = false;
			this.inventoryHoldingDataGridView.Location = new System.Drawing.Point(13, 53);
			this.inventoryHoldingDataGridView.MultiSelect = false;
			this.inventoryHoldingDataGridView.Name = "inventoryHoldingDataGridView";
			this.inventoryHoldingDataGridView.ReadOnly = true;
			this.inventoryHoldingDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.inventoryHoldingDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.inventoryHoldingDataGridView.RowHeadersVisible = false;
			this.inventoryHoldingDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(184)))), ((int)(((byte)(245)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(113)))), ((int)(((byte)(235)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.inventoryHoldingDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.inventoryHoldingDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.inventoryHoldingDataGridView.RowTemplate.Height = 25;
			this.inventoryHoldingDataGridView.RowTemplate.ReadOnly = true;
			this.inventoryHoldingDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.inventoryHoldingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.inventoryHoldingDataGridView.Size = new System.Drawing.Size(1124, 587);
			this.inventoryHoldingDataGridView.TabIndex = 0;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.FillWeight = 50F;
			this.idDataGridViewTextBoxColumn.HeaderText = "ردیف";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
			this.productNameDataGridViewTextBoxColumn.FillWeight = 200F;
			this.productNameDataGridViewTextBoxColumn.HeaderText = "نام کالا";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productQuantityDataGridViewTextBoxColumn
			// 
			this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "Product_Quantity";
			this.productQuantityDataGridViewTextBoxColumn.FillWeight = 50F;
			this.productQuantityDataGridViewTextBoxColumn.HeaderText = "تعداد کالا";
			this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
			this.productQuantityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productUnitDataGridViewTextBoxColumn
			// 
			this.productUnitDataGridViewTextBoxColumn.DataPropertyName = "Product_Unit";
			this.productUnitDataGridViewTextBoxColumn.FillWeight = 50F;
			this.productUnitDataGridViewTextBoxColumn.HeaderText = "واحد کالا";
			this.productUnitDataGridViewTextBoxColumn.Name = "productUnitDataGridViewTextBoxColumn";
			this.productUnitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productPurchasePriceDataGridViewTextBoxColumn
			// 
			this.productPurchasePriceDataGridViewTextBoxColumn.DataPropertyName = "Product_Purchase_Price";
			this.productPurchasePriceDataGridViewTextBoxColumn.HeaderText = "قیمت خرید کالا";
			this.productPurchasePriceDataGridViewTextBoxColumn.Name = "productPurchasePriceDataGridViewTextBoxColumn";
			this.productPurchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// registrationDateDataGridViewTextBoxColumn
			// 
			this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "Registration_Date";
			this.registrationDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
			this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
			this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// registrationTimeDataGridViewTextBoxColumn
			// 
			this.registrationTimeDataGridViewTextBoxColumn.DataPropertyName = "Registration_Time";
			this.registrationTimeDataGridViewTextBoxColumn.HeaderText = "زمان ثبت";
			this.registrationTimeDataGridViewTextBoxColumn.Name = "registrationTimeDataGridViewTextBoxColumn";
			this.registrationTimeDataGridViewTextBoxColumn.ReadOnly = true;
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
			this.productNameSearchTextBox.BorderThickness = 1;
			this.productNameSearchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.productNameSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.productNameSearchTextBox.DefaultFont = new System.Drawing.Font("IRANSansFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productNameSearchTextBox.DefaultText = "";
			this.productNameSearchTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
			this.productNameSearchTextBox.Size = new System.Drawing.Size(1124, 35);
			this.productNameSearchTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
			this.productNameSearchTextBox.TabIndex = 1;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productUnitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productPurchasePriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationTimeDataGridViewTextBoxColumn;
	}
}
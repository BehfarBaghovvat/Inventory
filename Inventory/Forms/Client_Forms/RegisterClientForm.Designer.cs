
namespace Client_Forms
{
	partial class RegisterClientForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterClientForm));
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
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.searchTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.phonNumberTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.licensePlateTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.clientNameTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.saveButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.listClientDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.licensePlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.clientEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allClientsDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.listClientDataGridView)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BorderColor = System.Drawing.Color.Indigo;
			this.mainPanel.BorderRadius = 15;
			this.mainPanel.BorderThickness = 3;
			this.mainPanel.Controls.Add(this.searchTextBox);
			this.mainPanel.Controls.Add(this.phonNumberTextBox);
			this.mainPanel.Controls.Add(this.licensePlateTextBox);
			this.mainPanel.Controls.Add(this.clientNameTextBox);
			this.mainPanel.Controls.Add(this.saveButton);
			this.mainPanel.Controls.Add(this.listClientDataGridView);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
			this.mainPanel.Size = new System.Drawing.Size(1150, 650);
			this.mainPanel.TabIndex = 0;
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
			this.searchTextBox.BorderColorActive = System.Drawing.Color.Indigo;
			this.searchTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.searchTextBox.BorderColorHover = System.Drawing.Color.RoyalBlue;
			this.searchTextBox.BorderColorIdle = System.Drawing.Color.Silver;
			this.searchTextBox.BorderRadius = 25;
			this.searchTextBox.BorderThickness = 2;
			this.searchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.searchTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.searchTextBox.DefaultText = "";
			this.searchTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.searchTextBox.ForeColor = System.Drawing.Color.White;
			this.searchTextBox.HideSelection = true;
			this.searchTextBox.IconLeft = null;
			this.searchTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchTextBox.IconPadding = 7;
			this.searchTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("searchTextBox.IconRight")));
			this.searchTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.searchTextBox.Lines = new string[0];
			this.searchTextBox.Location = new System.Drawing.Point(488, 130);
			this.searchTextBox.MaximumSize = new System.Drawing.Size(650, 35);
			this.searchTextBox.MaxLength = 32767;
			this.searchTextBox.MinimumSize = new System.Drawing.Size(650, 35);
			this.searchTextBox.Modified = false;
			this.searchTextBox.Multiline = false;
			this.searchTextBox.Name = "searchTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.Indigo;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.searchTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.RoyalBlue;
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Silver;
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties4.ForeColor = System.Drawing.Color.White;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.searchTextBox.OnIdleState = stateProperties4;
			this.searchTextBox.PasswordChar = '\0';
			this.searchTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.searchTextBox.PlaceholderText = "جستجوی مشتری ( شماره پلاک، شماره تماس)";
			this.searchTextBox.ReadOnly = false;
			this.searchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.searchTextBox.SelectedText = "";
			this.searchTextBox.SelectionLength = 0;
			this.searchTextBox.SelectionStart = 0;
			this.searchTextBox.ShortcutsEnabled = true;
			this.searchTextBox.Size = new System.Drawing.Size(650, 35);
			this.searchTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
			this.searchTextBox.TabIndex = 5;
			this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.searchTextBox.TextMarginBottom = 0;
			this.searchTextBox.TextMarginLeft = 5;
			this.searchTextBox.TextMarginTop = 1;
			this.searchTextBox.TextPlaceholder = "جستجوی مشتری ( شماره پلاک، شماره تماس)";
			this.searchTextBox.UseSystemPasswordChar = false;
			this.searchTextBox.WordWrap = true;
			this.searchTextBox.TextChange += new System.EventHandler(this.SearchTextBox_TextChange);
			this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
			this.searchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
			// 
			// phonNumberTextBox
			// 
			this.phonNumberTextBox.AcceptsReturn = false;
			this.phonNumberTextBox.AcceptsTab = false;
			this.phonNumberTextBox.AnimationSpeed = 200;
			this.phonNumberTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.phonNumberTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.phonNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.phonNumberTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("phonNumberTextBox.BackgroundImage")));
			this.phonNumberTextBox.BorderColorActive = System.Drawing.Color.Indigo;
			this.phonNumberTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.phonNumberTextBox.BorderColorHover = System.Drawing.Color.RoyalBlue;
			this.phonNumberTextBox.BorderColorIdle = System.Drawing.Color.Silver;
			this.phonNumberTextBox.BorderRadius = 1;
			this.phonNumberTextBox.BorderThickness = 3;
			this.phonNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.phonNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.phonNumberTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.phonNumberTextBox.DefaultText = "";
			this.phonNumberTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.phonNumberTextBox.ForeColor = System.Drawing.Color.White;
			this.phonNumberTextBox.HideSelection = true;
			this.phonNumberTextBox.IconLeft = null;
			this.phonNumberTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.phonNumberTextBox.IconPadding = 10;
			this.phonNumberTextBox.IconRight = null;
			this.phonNumberTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.phonNumberTextBox.Lines = new string[0];
			this.phonNumberTextBox.Location = new System.Drawing.Point(94, 47);
			this.phonNumberTextBox.MaximumSize = new System.Drawing.Size(300, 35);
			this.phonNumberTextBox.MaxLength = 32767;
			this.phonNumberTextBox.MinimumSize = new System.Drawing.Size(300, 35);
			this.phonNumberTextBox.Modified = false;
			this.phonNumberTextBox.Multiline = false;
			this.phonNumberTextBox.Name = "phonNumberTextBox";
			stateProperties5.BorderColor = System.Drawing.Color.Indigo;
			stateProperties5.FillColor = System.Drawing.Color.Empty;
			stateProperties5.ForeColor = System.Drawing.Color.Empty;
			stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.phonNumberTextBox.OnActiveState = stateProperties5;
			stateProperties6.BorderColor = System.Drawing.Color.Empty;
			stateProperties6.FillColor = System.Drawing.Color.White;
			stateProperties6.ForeColor = System.Drawing.Color.Empty;
			stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.phonNumberTextBox.OnDisabledState = stateProperties6;
			stateProperties7.BorderColor = System.Drawing.Color.RoyalBlue;
			stateProperties7.FillColor = System.Drawing.Color.Empty;
			stateProperties7.ForeColor = System.Drawing.Color.Empty;
			stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.phonNumberTextBox.OnHoverState = stateProperties7;
			stateProperties8.BorderColor = System.Drawing.Color.Silver;
			stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties8.ForeColor = System.Drawing.Color.White;
			stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.phonNumberTextBox.OnIdleState = stateProperties8;
			this.phonNumberTextBox.PasswordChar = '\0';
			this.phonNumberTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.phonNumberTextBox.PlaceholderText = "شماره تماس";
			this.phonNumberTextBox.ReadOnly = false;
			this.phonNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.phonNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.phonNumberTextBox.SelectedText = "";
			this.phonNumberTextBox.SelectionLength = 0;
			this.phonNumberTextBox.SelectionStart = 0;
			this.phonNumberTextBox.ShortcutsEnabled = true;
			this.phonNumberTextBox.Size = new System.Drawing.Size(300, 35);
			this.phonNumberTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.phonNumberTextBox.TabIndex = 4;
			this.phonNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.phonNumberTextBox.TextMarginBottom = 0;
			this.phonNumberTextBox.TextMarginLeft = 5;
			this.phonNumberTextBox.TextMarginTop = 0;
			this.phonNumberTextBox.TextPlaceholder = "شماره تماس";
			this.phonNumberTextBox.UseSystemPasswordChar = false;
			this.phonNumberTextBox.WordWrap = true;
			this.phonNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhonNumberTextBox_KeyPress);
			this.phonNumberTextBox.Enter += new System.EventHandler(this.PhonNumberTextBox_Enter);
			this.phonNumberTextBox.Leave += new System.EventHandler(this.PhonNumberTextBox_Leave);
			// 
			// licensePlateTextBox
			// 
			this.licensePlateTextBox.AcceptsReturn = false;
			this.licensePlateTextBox.AcceptsTab = false;
			this.licensePlateTextBox.AnimationSpeed = 200;
			this.licensePlateTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.licensePlateTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.licensePlateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.licensePlateTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("licensePlateTextBox.BackgroundImage")));
			this.licensePlateTextBox.BorderColorActive = System.Drawing.Color.Indigo;
			this.licensePlateTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.licensePlateTextBox.BorderColorHover = System.Drawing.Color.RoyalBlue;
			this.licensePlateTextBox.BorderColorIdle = System.Drawing.Color.Silver;
			this.licensePlateTextBox.BorderRadius = 1;
			this.licensePlateTextBox.BorderThickness = 3;
			this.licensePlateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.licensePlateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.licensePlateTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.licensePlateTextBox.DefaultText = "";
			this.licensePlateTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.licensePlateTextBox.ForeColor = System.Drawing.Color.White;
			this.licensePlateTextBox.HideSelection = true;
			this.licensePlateTextBox.IconLeft = null;
			this.licensePlateTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.licensePlateTextBox.IconPadding = 10;
			this.licensePlateTextBox.IconRight = null;
			this.licensePlateTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.licensePlateTextBox.Lines = new string[0];
			this.licensePlateTextBox.Location = new System.Drawing.Point(430, 47);
			this.licensePlateTextBox.MaximumSize = new System.Drawing.Size(300, 35);
			this.licensePlateTextBox.MaxLength = 32767;
			this.licensePlateTextBox.MinimumSize = new System.Drawing.Size(300, 35);
			this.licensePlateTextBox.Modified = false;
			this.licensePlateTextBox.Multiline = false;
			this.licensePlateTextBox.Name = "licensePlateTextBox";
			stateProperties9.BorderColor = System.Drawing.Color.Indigo;
			stateProperties9.FillColor = System.Drawing.Color.Empty;
			stateProperties9.ForeColor = System.Drawing.Color.Empty;
			stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.licensePlateTextBox.OnActiveState = stateProperties9;
			stateProperties10.BorderColor = System.Drawing.Color.Empty;
			stateProperties10.FillColor = System.Drawing.Color.White;
			stateProperties10.ForeColor = System.Drawing.Color.Empty;
			stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.licensePlateTextBox.OnDisabledState = stateProperties10;
			stateProperties11.BorderColor = System.Drawing.Color.RoyalBlue;
			stateProperties11.FillColor = System.Drawing.Color.Empty;
			stateProperties11.ForeColor = System.Drawing.Color.Empty;
			stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.licensePlateTextBox.OnHoverState = stateProperties11;
			stateProperties12.BorderColor = System.Drawing.Color.Silver;
			stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties12.ForeColor = System.Drawing.Color.White;
			stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.licensePlateTextBox.OnIdleState = stateProperties12;
			this.licensePlateTextBox.PasswordChar = '\0';
			this.licensePlateTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.licensePlateTextBox.PlaceholderText = "شماره پلاک وسیله نقلیه";
			this.licensePlateTextBox.ReadOnly = false;
			this.licensePlateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.licensePlateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.licensePlateTextBox.SelectedText = "";
			this.licensePlateTextBox.SelectionLength = 0;
			this.licensePlateTextBox.SelectionStart = 0;
			this.licensePlateTextBox.ShortcutsEnabled = true;
			this.licensePlateTextBox.Size = new System.Drawing.Size(300, 35);
			this.licensePlateTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.licensePlateTextBox.TabIndex = 3;
			this.licensePlateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.licensePlateTextBox.TextMarginBottom = 0;
			this.licensePlateTextBox.TextMarginLeft = 5;
			this.licensePlateTextBox.TextMarginTop = 0;
			this.licensePlateTextBox.TextPlaceholder = "شماره پلاک وسیله نقلیه";
			this.licensePlateTextBox.UseSystemPasswordChar = false;
			this.licensePlateTextBox.WordWrap = true;
			this.licensePlateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LicensePlateTextBox_KeyPress);
			this.licensePlateTextBox.Enter += new System.EventHandler(this.LicensePlateTextBox_Enter);
			this.licensePlateTextBox.Leave += new System.EventHandler(this.LicensePlateTextBox_Leave);
			// 
			// clientNameTextBox
			// 
			this.clientNameTextBox.AcceptsReturn = false;
			this.clientNameTextBox.AcceptsTab = false;
			this.clientNameTextBox.AnimationSpeed = 200;
			this.clientNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.clientNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.clientNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.clientNameTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clientNameTextBox.BackgroundImage")));
			this.clientNameTextBox.BorderColorActive = System.Drawing.Color.Indigo;
			this.clientNameTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.clientNameTextBox.BorderColorHover = System.Drawing.Color.RoyalBlue;
			this.clientNameTextBox.BorderColorIdle = System.Drawing.Color.Silver;
			this.clientNameTextBox.BorderRadius = 1;
			this.clientNameTextBox.BorderThickness = 3;
			this.clientNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.clientNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.clientNameTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientNameTextBox.DefaultText = "";
			this.clientNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.clientNameTextBox.ForeColor = System.Drawing.Color.White;
			this.clientNameTextBox.HideSelection = true;
			this.clientNameTextBox.IconLeft = null;
			this.clientNameTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.clientNameTextBox.IconPadding = 10;
			this.clientNameTextBox.IconRight = null;
			this.clientNameTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.clientNameTextBox.Lines = new string[0];
			this.clientNameTextBox.Location = new System.Drawing.Point(756, 47);
			this.clientNameTextBox.MaximumSize = new System.Drawing.Size(300, 35);
			this.clientNameTextBox.MaxLength = 32767;
			this.clientNameTextBox.MinimumSize = new System.Drawing.Size(300, 35);
			this.clientNameTextBox.Modified = false;
			this.clientNameTextBox.Multiline = false;
			this.clientNameTextBox.Name = "clientNameTextBox";
			stateProperties13.BorderColor = System.Drawing.Color.Indigo;
			stateProperties13.FillColor = System.Drawing.Color.Empty;
			stateProperties13.ForeColor = System.Drawing.Color.Empty;
			stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.clientNameTextBox.OnActiveState = stateProperties13;
			stateProperties14.BorderColor = System.Drawing.Color.Empty;
			stateProperties14.FillColor = System.Drawing.Color.White;
			stateProperties14.ForeColor = System.Drawing.Color.Empty;
			stateProperties14.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.clientNameTextBox.OnDisabledState = stateProperties14;
			stateProperties15.BorderColor = System.Drawing.Color.RoyalBlue;
			stateProperties15.FillColor = System.Drawing.Color.Empty;
			stateProperties15.ForeColor = System.Drawing.Color.Empty;
			stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.clientNameTextBox.OnHoverState = stateProperties15;
			stateProperties16.BorderColor = System.Drawing.Color.Silver;
			stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties16.ForeColor = System.Drawing.Color.White;
			stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.clientNameTextBox.OnIdleState = stateProperties16;
			this.clientNameTextBox.PasswordChar = '\0';
			this.clientNameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.clientNameTextBox.PlaceholderText = "نام مشتری";
			this.clientNameTextBox.ReadOnly = false;
			this.clientNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.clientNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.clientNameTextBox.SelectedText = "";
			this.clientNameTextBox.SelectionLength = 0;
			this.clientNameTextBox.SelectionStart = 0;
			this.clientNameTextBox.ShortcutsEnabled = true;
			this.clientNameTextBox.Size = new System.Drawing.Size(300, 35);
			this.clientNameTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.clientNameTextBox.TabIndex = 2;
			this.clientNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.clientNameTextBox.TextMarginBottom = 0;
			this.clientNameTextBox.TextMarginLeft = 5;
			this.clientNameTextBox.TextMarginTop = 0;
			this.clientNameTextBox.TextPlaceholder = "نام مشتری";
			this.clientNameTextBox.UseSystemPasswordChar = false;
			this.clientNameTextBox.WordWrap = true;
			this.clientNameTextBox.TextChange += new System.EventHandler(this.ClientNameTextBox_TextChange);
			this.clientNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientNameTextBox_KeyPress);
			this.clientNameTextBox.Enter += new System.EventHandler(this.ClientNameTextBox_Enter);
			// 
			// saveButton
			// 
			this.saveButton.Animated = true;
			this.saveButton.BorderRadius = 5;
			this.saveButton.CheckedState.Parent = this.saveButton;
			this.saveButton.CustomImages.Parent = this.saveButton;
			this.saveButton.FillColor = System.Drawing.Color.Indigo;
			this.saveButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.saveButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.saveButton.HoverState.FillColor2 = System.Drawing.Color.Indigo;
			this.saveButton.HoverState.Parent = this.saveButton;
			this.saveButton.Location = new System.Drawing.Point(12, 130);
			this.saveButton.Name = "saveButton";
			this.saveButton.PressedColor = System.Drawing.Color.White;
			this.saveButton.ShadowDecoration.Parent = this.saveButton;
			this.saveButton.Size = new System.Drawing.Size(180, 35);
			this.saveButton.TabIndex = 0;
			this.saveButton.Text = "ثبت مشتری";
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// listClientDataGridView
			// 
			this.listClientDataGridView.AllowUserToAddRows = false;
			this.listClientDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.listClientDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.listClientDataGridView.AutoGenerateColumns = false;
			this.listClientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.listClientDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.listClientDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listClientDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listClientDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.listClientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.listClientDataGridView.ColumnHeadersHeight = 30;
			this.listClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.listClientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.licensePlateDataGridViewTextBoxColumn});
			this.listClientDataGridView.ContextMenuStrip = this.contextMenuStrip;
			this.listClientDataGridView.DataSource = this.clientBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.listClientDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.listClientDataGridView.EnableHeadersVisualStyles = false;
			this.listClientDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.listClientDataGridView.Location = new System.Drawing.Point(12, 171);
			this.listClientDataGridView.Name = "listClientDataGridView";
			this.listClientDataGridView.ReadOnly = true;
			this.listClientDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.listClientDataGridView.RowHeadersVisible = false;
			this.listClientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listClientDataGridView.Size = new System.Drawing.Size(1126, 467);
			this.listClientDataGridView.TabIndex = 1;
			this.listClientDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.listClientDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.listClientDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.listClientDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.listClientDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.listClientDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.listClientDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.listClientDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.listClientDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.listClientDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.listClientDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.listClientDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.listClientDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.listClientDataGridView.ThemeStyle.HeaderStyle.Height = 30;
			this.listClientDataGridView.ThemeStyle.ReadOnly = true;
			this.listClientDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.listClientDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listClientDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.listClientDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.listClientDataGridView.ThemeStyle.RowsStyle.Height = 22;
			this.listClientDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.listClientDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
			this.clientNameDataGridViewTextBoxColumn.FillWeight = 150F;
			this.clientNameDataGridViewTextBoxColumn.HeaderText = "نام مشتری";
			this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
			this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "شماره تماس";
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// licensePlateDataGridViewTextBoxColumn
			// 
			this.licensePlateDataGridViewTextBoxColumn.DataPropertyName = "License_Plate";
			this.licensePlateDataGridViewTextBoxColumn.HeaderText = "پلاک وسیله نقیله";
			this.licensePlateDataGridViewTextBoxColumn.Name = "licensePlateDataGridViewTextBoxColumn";
			this.licensePlateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientEditToolStripMenuItem,
            this.clientDeleteToolStripMenuItem,
            this.allClientsDeleteToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.contextMenuStrip.Size = new System.Drawing.Size(212, 70);
			// 
			// clientEditToolStripMenuItem
			// 
			this.clientEditToolStripMenuItem.Name = "clientEditToolStripMenuItem";
			this.clientEditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.clientEditToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.clientEditToolStripMenuItem.Text = "ویرایش مشتری";
			this.clientEditToolStripMenuItem.Click += new System.EventHandler(this.ClientEditToolStripMenuItem_Click);
			// 
			// clientDeleteToolStripMenuItem
			// 
			this.clientDeleteToolStripMenuItem.Name = "clientDeleteToolStripMenuItem";
			this.clientDeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.clientDeleteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.clientDeleteToolStripMenuItem.Text = "حذف مشتری";
			this.clientDeleteToolStripMenuItem.Click += new System.EventHandler(this.ClientDeleteToolStripMenuItem_Click);
			// 
			// allClientsDeleteToolStripMenuItem
			// 
			this.allClientsDeleteToolStripMenuItem.Name = "allClientsDeleteToolStripMenuItem";
			this.allClientsDeleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
			this.allClientsDeleteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.allClientsDeleteToolStripMenuItem.Text = "حذف همه مشتریان";
			this.allClientsDeleteToolStripMenuItem.Click += new System.EventHandler(this.AllClientsDeleteToolStripMenuItem_Click);
			// 
			// clientBindingSource
			// 
			this.clientBindingSource.DataSource = typeof(Models.Client);
			// 
			// RegisterClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(1150, 650);
			this.Controls.Add(this.mainPanel);
			this.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "RegisterClientForm";
			this.Text = "RegisterClientForm";
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.listClientDataGridView)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel mainPanel;
		private Guna.UI2.WinForms.Guna2DataGridView listClientDataGridView;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox phonNumberTextBox;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox licensePlateTextBox;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox clientNameTextBox;
		private Guna.UI2.WinForms.Guna2GradientButton saveButton;
		private System.Windows.Forms.BindingSource clientBindingSource;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem clientEditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientDeleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allClientsDeleteToolStripMenuItem;
	}
}
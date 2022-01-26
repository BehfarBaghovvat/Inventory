
namespace Manegment_Setting
{
	partial class LoginControlUC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControlUC));
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.listLogHistoryDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.logoutTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userSearchTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.printButton = new Guna.UI2.WinForms.Guna2GradientButton();
			((System.ComponentModel.ISupportInitialize)(this.listLogHistoryDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.loginHistoryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// listLogHistoryDataGridView
			// 
			this.listLogHistoryDataGridView.AllowUserToAddRows = false;
			this.listLogHistoryDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansFaNum", 8F);
			this.listLogHistoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.listLogHistoryDataGridView.AutoGenerateColumns = false;
			this.listLogHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.listLogHistoryDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.listLogHistoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listLogHistoryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listLogHistoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.listLogHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.listLogHistoryDataGridView.ColumnHeadersHeight = 35;
			this.listLogHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.listLogHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.loginTimeDataGridViewTextBoxColumn,
            this.logoutTimeDataGridViewTextBoxColumn});
			this.listLogHistoryDataGridView.DataSource = this.loginHistoryBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.listLogHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.listLogHistoryDataGridView.EnableHeadersVisualStyles = false;
			this.listLogHistoryDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
			this.listLogHistoryDataGridView.Location = new System.Drawing.Point(12, 54);
			this.listLogHistoryDataGridView.Name = "listLogHistoryDataGridView";
			this.listLogHistoryDataGridView.ReadOnly = true;
			this.listLogHistoryDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.listLogHistoryDataGridView.RowHeadersVisible = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.listLogHistoryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.listLogHistoryDataGridView.RowTemplate.Height = 20;
			this.listLogHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listLogHistoryDataGridView.Size = new System.Drawing.Size(1100, 502);
			this.listLogHistoryDataGridView.TabIndex = 0;
			this.listLogHistoryDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
			this.listLogHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
			this.listLogHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("IRANSansFaNum", 8F);
			this.listLogHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.listLogHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.listLogHistoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.listLogHistoryDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.listLogHistoryDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
			this.listLogHistoryDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
			this.listLogHistoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.listLogHistoryDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.listLogHistoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.listLogHistoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.listLogHistoryDataGridView.ThemeStyle.HeaderStyle.Height = 35;
			this.listLogHistoryDataGridView.ThemeStyle.ReadOnly = true;
			this.listLogHistoryDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
			this.listLogHistoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listLogHistoryDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.listLogHistoryDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.listLogHistoryDataGridView.ThemeStyle.RowsStyle.Height = 20;
			this.listLogHistoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
			this.listLogHistoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.FillWeight = 50F;
			this.idDataGridViewTextBoxColumn.HeaderText = "ردیف";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// usernameDataGridViewTextBoxColumn
			// 
			this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
			this.usernameDataGridViewTextBoxColumn.FillWeight = 200F;
			this.usernameDataGridViewTextBoxColumn.HeaderText = "شناسه کاربری";
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
			this.usernameDataGridViewTextBoxColumn.Visible = false;
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "نام کاربر";
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// loginTimeDataGridViewTextBoxColumn
			// 
			this.loginTimeDataGridViewTextBoxColumn.DataPropertyName = "Login_Time";
			this.loginTimeDataGridViewTextBoxColumn.FillWeight = 75F;
			this.loginTimeDataGridViewTextBoxColumn.HeaderText = "زمان ورود";
			this.loginTimeDataGridViewTextBoxColumn.Name = "loginTimeDataGridViewTextBoxColumn";
			this.loginTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// logoutTimeDataGridViewTextBoxColumn
			// 
			this.logoutTimeDataGridViewTextBoxColumn.DataPropertyName = "Logout_Time";
			this.logoutTimeDataGridViewTextBoxColumn.FillWeight = 75F;
			this.logoutTimeDataGridViewTextBoxColumn.HeaderText = "زمان خروج";
			this.logoutTimeDataGridViewTextBoxColumn.Name = "logoutTimeDataGridViewTextBoxColumn";
			this.logoutTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// loginHistoryBindingSource
			// 
			this.loginHistoryBindingSource.DataSource = typeof(Models.LoginHistory);
			// 
			// userSearchTextBox
			// 
			this.userSearchTextBox.AcceptsReturn = false;
			this.userSearchTextBox.AcceptsTab = false;
			this.userSearchTextBox.AnimationSpeed = 200;
			this.userSearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.userSearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.userSearchTextBox.BackColor = System.Drawing.Color.Transparent;
			this.userSearchTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userSearchTextBox.BackgroundImage")));
			this.userSearchTextBox.BorderColorActive = System.Drawing.Color.Indigo;
			this.userSearchTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.userSearchTextBox.BorderColorHover = System.Drawing.Color.RoyalBlue;
			this.userSearchTextBox.BorderColorIdle = System.Drawing.Color.DimGray;
			this.userSearchTextBox.BorderRadius = 25;
			this.userSearchTextBox.BorderThickness = 2;
			this.userSearchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.userSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.userSearchTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.userSearchTextBox.DefaultText = "";
			this.userSearchTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.userSearchTextBox.ForeColor = System.Drawing.Color.White;
			this.userSearchTextBox.HideSelection = true;
			this.userSearchTextBox.IconLeft = null;
			this.userSearchTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.userSearchTextBox.IconPadding = 7;
			this.userSearchTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("userSearchTextBox.IconRight")));
			this.userSearchTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.userSearchTextBox.Lines = new string[0];
			this.userSearchTextBox.Location = new System.Drawing.Point(562, 10);
			this.userSearchTextBox.MaximumSize = new System.Drawing.Size(550, 35);
			this.userSearchTextBox.MaxLength = 32767;
			this.userSearchTextBox.MinimumSize = new System.Drawing.Size(550, 35);
			this.userSearchTextBox.Modified = false;
			this.userSearchTextBox.Multiline = false;
			this.userSearchTextBox.Name = "userSearchTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.Indigo;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.userSearchTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.userSearchTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.RoyalBlue;
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.userSearchTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.DimGray;
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties4.ForeColor = System.Drawing.Color.White;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.userSearchTextBox.OnIdleState = stateProperties4;
			this.userSearchTextBox.PasswordChar = '\0';
			this.userSearchTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.userSearchTextBox.PlaceholderText = "جستجوی کاربر...";
			this.userSearchTextBox.ReadOnly = false;
			this.userSearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.userSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.userSearchTextBox.SelectedText = "";
			this.userSearchTextBox.SelectionLength = 0;
			this.userSearchTextBox.SelectionStart = 0;
			this.userSearchTextBox.ShortcutsEnabled = true;
			this.userSearchTextBox.Size = new System.Drawing.Size(550, 35);
			this.userSearchTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
			this.userSearchTextBox.TabIndex = 1;
			this.userSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.userSearchTextBox.TextMarginBottom = 0;
			this.userSearchTextBox.TextMarginLeft = 5;
			this.userSearchTextBox.TextMarginTop = 0;
			this.userSearchTextBox.TextPlaceholder = "جستجوی کاربر...";
			this.userSearchTextBox.UseSystemPasswordChar = false;
			this.userSearchTextBox.WordWrap = true;
			this.userSearchTextBox.TextChange += new System.EventHandler(this.UserSearchTextBox_TextChange);
			this.userSearchTextBox.Enter += new System.EventHandler(this.UserSearchTextBox_Enter);
			// 
			// printButton
			// 
			this.printButton.Animated = true;
			this.printButton.CheckedState.Parent = this.printButton;
			this.printButton.CustomImages.Parent = this.printButton;
			this.printButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.printButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.printButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.printButton.ForeColor = System.Drawing.Color.White;
			this.printButton.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
			this.printButton.HoverState.FillColor2 = System.Drawing.Color.RoyalBlue;
			this.printButton.HoverState.Parent = this.printButton;
			this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
			this.printButton.Location = new System.Drawing.Point(12, 10);
			this.printButton.Name = "printButton";
			this.printButton.PressedColor = System.Drawing.Color.White;
			this.printButton.ShadowDecoration.Parent = this.printButton;
			this.printButton.Size = new System.Drawing.Size(35, 35);
			this.printButton.TabIndex = 2;
			this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// LoginControlUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.Controls.Add(this.printButton);
			this.Controls.Add(this.userSearchTextBox);
			this.Controls.Add(this.listLogHistoryDataGridView);
			this.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximumSize = new System.Drawing.Size(1125, 570);
			this.MinimumSize = new System.Drawing.Size(1125, 570);
			this.Name = "LoginControlUC";
			this.Size = new System.Drawing.Size(1125, 570);
			this.Load += new System.EventHandler(this.LoginControlUC_Load);
			((System.ComponentModel.ISupportInitialize)(this.listLogHistoryDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.loginHistoryBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2DataGridView listLogHistoryDataGridView;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox userSearchTextBox;
		private Guna.UI2.WinForms.Guna2GradientButton printButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn logoutTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource loginHistoryBindingSource;
	}
}

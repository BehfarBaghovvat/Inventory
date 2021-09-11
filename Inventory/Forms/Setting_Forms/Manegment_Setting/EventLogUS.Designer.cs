
namespace Manegment_Setting
{
	partial class EventLogUS
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventLogUS));
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.printButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.userSearchTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.listEventLogDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eventTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eventLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.listEventLogDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eventLogBindingSource)).BeginInit();
			this.SuspendLayout();
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
			this.printButton.Location = new System.Drawing.Point(12, 12);
			this.printButton.Name = "printButton";
			this.printButton.PressedColor = System.Drawing.Color.White;
			this.printButton.ShadowDecoration.Parent = this.printButton;
			this.printButton.Size = new System.Drawing.Size(35, 35);
			this.printButton.TabIndex = 5;
			this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
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
			this.userSearchTextBox.Location = new System.Drawing.Point(562, 12);
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
			this.userSearchTextBox.TabIndex = 4;
			this.userSearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.userSearchTextBox.TextMarginBottom = 0;
			this.userSearchTextBox.TextMarginLeft = 5;
			this.userSearchTextBox.TextMarginTop = 0;
			this.userSearchTextBox.TextPlaceholder = "جستجوی کاربر...";
			this.userSearchTextBox.UseSystemPasswordChar = false;
			this.userSearchTextBox.WordWrap = true;
			this.userSearchTextBox.TextChange += new System.EventHandler(this.UserSearchTextBox_TextChange);
			this.userSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserSearchTextBox_KeyPress);
			this.userSearchTextBox.Enter += new System.EventHandler(this.UserSearchTextBox_Enter);
			// 
			// listEventLogDataGridView
			// 
			this.listEventLogDataGridView.AllowUserToAddRows = false;
			this.listEventLogDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
			this.listEventLogDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.listEventLogDataGridView.AutoGenerateColumns = false;
			this.listEventLogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.listEventLogDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.listEventLogDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listEventLogDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listEventLogDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.listEventLogDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.listEventLogDataGridView.ColumnHeadersHeight = 35;
			this.listEventLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.listEventLogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.eventTimeDataGridViewTextBoxColumn});
			this.listEventLogDataGridView.DataSource = this.eventLogBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.listEventLogDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.listEventLogDataGridView.EnableHeadersVisualStyles = false;
			this.listEventLogDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
			this.listEventLogDataGridView.Location = new System.Drawing.Point(12, 56);
			this.listEventLogDataGridView.Name = "listEventLogDataGridView";
			this.listEventLogDataGridView.ReadOnly = true;
			this.listEventLogDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.listEventLogDataGridView.RowHeadersVisible = false;
			this.listEventLogDataGridView.RowTemplate.Height = 20;
			this.listEventLogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.listEventLogDataGridView.Size = new System.Drawing.Size(1100, 502);
			this.listEventLogDataGridView.TabIndex = 3;
			this.listEventLogDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
			this.listEventLogDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
			this.listEventLogDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.listEventLogDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.listEventLogDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.listEventLogDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.listEventLogDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.listEventLogDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
			this.listEventLogDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
			this.listEventLogDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.listEventLogDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.listEventLogDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.listEventLogDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.listEventLogDataGridView.ThemeStyle.HeaderStyle.Height = 35;
			this.listEventLogDataGridView.ThemeStyle.ReadOnly = true;
			this.listEventLogDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
			this.listEventLogDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.listEventLogDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.listEventLogDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.listEventLogDataGridView.ThemeStyle.RowsStyle.Height = 20;
			this.listEventLogDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
			this.listEventLogDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
			this.usernameDataGridViewTextBoxColumn.HeaderText = "شناسه کاربری";
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
			this.usernameDataGridViewTextBoxColumn.Visible = false;
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.FillWeight = 200F;
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "توضیحات";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// eventDateDataGridViewTextBoxColumn
			// 
			this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "Event_Date";
			this.eventDateDataGridViewTextBoxColumn.FillWeight = 75F;
			this.eventDateDataGridViewTextBoxColumn.HeaderText = "تاریخ رخداد";
			this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
			this.eventDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// eventTimeDataGridViewTextBoxColumn
			// 
			this.eventTimeDataGridViewTextBoxColumn.DataPropertyName = "Event_Time";
			this.eventTimeDataGridViewTextBoxColumn.FillWeight = 75F;
			this.eventTimeDataGridViewTextBoxColumn.HeaderText = "زمان رخداد";
			this.eventTimeDataGridViewTextBoxColumn.Name = "eventTimeDataGridViewTextBoxColumn";
			this.eventTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// eventLogBindingSource
			// 
			this.eventLogBindingSource.DataSource = typeof(Models.EventLog);
			// 
			// EventLogUS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.Controls.Add(this.printButton);
			this.Controls.Add(this.userSearchTextBox);
			this.Controls.Add(this.listEventLogDataGridView);
			this.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximumSize = new System.Drawing.Size(1125, 570);
			this.MinimumSize = new System.Drawing.Size(1125, 570);
			this.Name = "EventLogUS";
			this.Size = new System.Drawing.Size(1125, 570);
			((System.ComponentModel.ISupportInitialize)(this.listEventLogDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eventLogBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientButton printButton;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox userSearchTextBox;
		private Guna.UI2.WinForms.Guna2DataGridView listEventLogDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn eventTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource eventLogBindingSource;
	}
}

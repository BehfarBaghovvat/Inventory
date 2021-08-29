
namespace Financial_Order
{
	partial class DispositUC
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.dispositDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.journalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount_Received = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dispositDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.dispositDataGridView);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.FillColor2 = System.Drawing.Color.DarkSlateBlue;
			this.mainPanel.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.mainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
			this.mainPanel.Size = new System.Drawing.Size(1125, 470);
			this.mainPanel.TabIndex = 0;
			// 
			// dispositDataGridView
			// 
			this.dispositDataGridView.AllowUserToAddRows = false;
			this.dispositDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
			this.dispositDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dispositDataGridView.AutoGenerateColumns = false;
			this.dispositDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dispositDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.dispositDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dispositDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dispositDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dispositDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dispositDataGridView.ColumnHeadersHeight = 30;
			this.dispositDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dispositDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.Amount_Received,
            this.registrationDateDataGridViewTextBoxColumn,
            this.registrationTimeDataGridViewTextBoxColumn});
			this.dispositDataGridView.DataSource = this.journalBindingSource;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dispositDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
			this.dispositDataGridView.EnableHeadersVisualStyles = false;
			this.dispositDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
			this.dispositDataGridView.Location = new System.Drawing.Point(12, 15);
			this.dispositDataGridView.Name = "dispositDataGridView";
			this.dispositDataGridView.ReadOnly = true;
			this.dispositDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dispositDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dispositDataGridView.RowHeadersVisible = false;
			this.dispositDataGridView.RowHeadersWidth = 40;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dispositDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dispositDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dispositDataGridView.Size = new System.Drawing.Size(1100, 440);
			this.dispositDataGridView.TabIndex = 0;
			this.dispositDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
			this.dispositDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
			this.dispositDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dispositDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dispositDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dispositDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dispositDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dispositDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
			this.dispositDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
			this.dispositDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dispositDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.dispositDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dispositDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dispositDataGridView.ThemeStyle.HeaderStyle.Height = 30;
			this.dispositDataGridView.ThemeStyle.ReadOnly = true;
			this.dispositDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
			this.dispositDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dispositDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.dispositDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.dispositDataGridView.ThemeStyle.RowsStyle.Height = 22;
			this.dispositDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
			this.dispositDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// journalBindingSource
			// 
			this.journalBindingSource.DataSource = typeof(Models.Journal);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.FillWeight = 50F;
			this.idDataGridViewTextBoxColumn.HeaderText = "ردیف";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.descriptionDataGridViewTextBoxColumn.FillWeight = 200F;
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "شرح";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Amount_Received
			// 
			this.Amount_Received.DataPropertyName = "Amount_Received";
			this.Amount_Received.HeaderText = "دریافتی";
			this.Amount_Received.Name = "Amount_Received";
			this.Amount_Received.ReadOnly = true;
			// 
			// registrationDateDataGridViewTextBoxColumn
			// 
			this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "Registration_Date";
			this.registrationDateDataGridViewTextBoxColumn.FillWeight = 75F;
			this.registrationDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
			this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
			this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// registrationTimeDataGridViewTextBoxColumn
			// 
			this.registrationTimeDataGridViewTextBoxColumn.DataPropertyName = "Registration_Time";
			this.registrationTimeDataGridViewTextBoxColumn.FillWeight = 75F;
			this.registrationTimeDataGridViewTextBoxColumn.HeaderText = "زمان ثبت";
			this.registrationTimeDataGridViewTextBoxColumn.Name = "registrationTimeDataGridViewTextBoxColumn";
			this.registrationTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// DispositUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainPanel);
			this.MaximumSize = new System.Drawing.Size(1125, 470);
			this.MinimumSize = new System.Drawing.Size(1125, 470);
			this.Name = "DispositUC";
			this.Size = new System.Drawing.Size(1125, 470);
			this.Load += new System.EventHandler(this.DispositUC_Load);
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dispositDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientPanel mainPanel;
		private Guna.UI2.WinForms.Guna2DataGridView dispositDataGridView;
		private System.Windows.Forms.BindingSource journalBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn agentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Received;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationTimeDataGridViewTextBoxColumn;
	}
}

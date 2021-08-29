
namespace Financial_Order
{
	partial class PaymentUC
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.paymentDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.journalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.paymentDataGridView);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.FillColor2 = System.Drawing.Color.DarkSlateBlue;
			this.mainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
			this.mainPanel.Size = new System.Drawing.Size(1125, 470);
			this.mainPanel.TabIndex = 0;
			// 
			// paymentDataGridView
			// 
			this.paymentDataGridView.AllowUserToAddRows = false;
			this.paymentDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.paymentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.paymentDataGridView.AutoGenerateColumns = false;
			this.paymentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.paymentDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.paymentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.paymentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.paymentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansXFaNum", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.paymentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.paymentDataGridView.ColumnHeadersHeight = 30;
			this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.paymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.registrationTimeDataGridViewTextBoxColumn});
			this.paymentDataGridView.DataSource = this.journalBindingSource;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSansXFaNum", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.paymentDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
			this.paymentDataGridView.EnableHeadersVisualStyles = false;
			this.paymentDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.paymentDataGridView.Location = new System.Drawing.Point(12, 15);
			this.paymentDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.paymentDataGridView.Name = "paymentDataGridView";
			this.paymentDataGridView.ReadOnly = true;
			this.paymentDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.paymentDataGridView.RowHeadersVisible = false;
			this.paymentDataGridView.RowHeadersWidth = 30;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.paymentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.paymentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.paymentDataGridView.Size = new System.Drawing.Size(1100, 440);
			this.paymentDataGridView.TabIndex = 0;
			this.paymentDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.paymentDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.paymentDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.paymentDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.paymentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.paymentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.paymentDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.paymentDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.paymentDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.paymentDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.paymentDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.paymentDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.paymentDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.paymentDataGridView.ThemeStyle.HeaderStyle.Height = 30;
			this.paymentDataGridView.ThemeStyle.ReadOnly = true;
			this.paymentDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.paymentDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.paymentDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.paymentDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.paymentDataGridView.ThemeStyle.RowsStyle.Height = 22;
			this.paymentDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.paymentDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
			this.descriptionDataGridViewTextBoxColumn.FillWeight = 200F;
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "شرح";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// amountPaidDataGridViewTextBoxColumn
			// 
			this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_Paid";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.amountPaidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.amountPaidDataGridViewTextBoxColumn.HeaderText = "پرداختی";
			this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
			this.amountPaidDataGridViewTextBoxColumn.ReadOnly = true;
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
			// PaymentUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainPanel);
			this.Font = new System.Drawing.Font("IRANSansXFaNum", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximumSize = new System.Drawing.Size(1125, 470);
			this.MinimumSize = new System.Drawing.Size(1125, 470);
			this.Name = "PaymentUC";
			this.Size = new System.Drawing.Size(1125, 470);
			this.Load += new System.EventHandler(this.PaymentUC_Load);
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientPanel mainPanel;
		private Guna.UI2.WinForms.Guna2DataGridView paymentDataGridView;
		private System.Windows.Forms.BindingSource journalBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn agentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationTimeDataGridViewTextBoxColumn;
	}
}


namespace Financial_Order
{
	partial class AncillaryCostsUC
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ancillaryCostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ancillaryCostsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.costNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.namePayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.ancillaryCostsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ancillaryCostsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// ancillaryCostsBindingSource
			// 
			this.ancillaryCostsBindingSource.DataSource = typeof(Models.AncillaryCosts);
			// 
			// ancillaryCostsDataGridView
			// 
			this.ancillaryCostsDataGridView.AllowUserToAddRows = false;
			this.ancillaryCostsDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
			this.ancillaryCostsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.ancillaryCostsDataGridView.AutoGenerateColumns = false;
			this.ancillaryCostsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ancillaryCostsDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.ancillaryCostsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ancillaryCostsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ancillaryCostsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ancillaryCostsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.ancillaryCostsDataGridView.ColumnHeadersHeight = 30;
			this.ancillaryCostsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ancillaryCostsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.costNameDataGridViewTextBoxColumn,
            this.namePayerDataGridViewTextBoxColumn,
            this.amountPaymentDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.registrationTimeDataGridViewTextBoxColumn});
			this.ancillaryCostsDataGridView.DataSource = this.ancillaryCostsBindingSource;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ancillaryCostsDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
			this.ancillaryCostsDataGridView.EnableHeadersVisualStyles = false;
			this.ancillaryCostsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
			this.ancillaryCostsDataGridView.Location = new System.Drawing.Point(12, 15);
			this.ancillaryCostsDataGridView.Name = "ancillaryCostsDataGridView";
			this.ancillaryCostsDataGridView.ReadOnly = true;
			this.ancillaryCostsDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ancillaryCostsDataGridView.RowHeadersVisible = false;
			this.ancillaryCostsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ancillaryCostsDataGridView.Size = new System.Drawing.Size(1100, 440);
			this.ancillaryCostsDataGridView.TabIndex = 1;
			this.ancillaryCostsDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
			this.ancillaryCostsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(233)))));
			this.ancillaryCostsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.ancillaryCostsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.ancillaryCostsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.ancillaryCostsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.ancillaryCostsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.ancillaryCostsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
			this.ancillaryCostsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
			this.ancillaryCostsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ancillaryCostsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ancillaryCostsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.ancillaryCostsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ancillaryCostsDataGridView.ThemeStyle.HeaderStyle.Height = 30;
			this.ancillaryCostsDataGridView.ThemeStyle.ReadOnly = true;
			this.ancillaryCostsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
			this.ancillaryCostsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ancillaryCostsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ancillaryCostsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.ancillaryCostsDataGridView.ThemeStyle.RowsStyle.Height = 22;
			this.ancillaryCostsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
			this.ancillaryCostsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "ردیف";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// costNameDataGridViewTextBoxColumn
			// 
			this.costNameDataGridViewTextBoxColumn.DataPropertyName = "Cost_Name";
			this.costNameDataGridViewTextBoxColumn.HeaderText = "نام هزینه صورت گرفته";
			this.costNameDataGridViewTextBoxColumn.Name = "costNameDataGridViewTextBoxColumn";
			this.costNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// namePayerDataGridViewTextBoxColumn
			// 
			this.namePayerDataGridViewTextBoxColumn.DataPropertyName = "Name_Payer";
			this.namePayerDataGridViewTextBoxColumn.HeaderText = "نام پرداخت کننده";
			this.namePayerDataGridViewTextBoxColumn.Name = "namePayerDataGridViewTextBoxColumn";
			this.namePayerDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// amountPaymentDataGridViewTextBoxColumn
			// 
			this.amountPaymentDataGridViewTextBoxColumn.DataPropertyName = "Amount_Payment";
			this.amountPaymentDataGridViewTextBoxColumn.HeaderText = "مبلغ پرداختی";
			this.amountPaymentDataGridViewTextBoxColumn.Name = "amountPaymentDataGridViewTextBoxColumn";
			this.amountPaymentDataGridViewTextBoxColumn.ReadOnly = true;
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
			// AncillaryCostsUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.Controls.Add(this.ancillaryCostsDataGridView);
			this.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximumSize = new System.Drawing.Size(1125, 470);
			this.MinimumSize = new System.Drawing.Size(1125, 470);
			this.Name = "AncillaryCostsUC";
			this.Size = new System.Drawing.Size(1125, 470);
			((System.ComponentModel.ISupportInitialize)(this.ancillaryCostsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ancillaryCostsDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource ancillaryCostsBindingSource;
		private Guna.UI2.WinForms.Guna2DataGridView ancillaryCostsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn costNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn namePayerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountPaymentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationTimeDataGridViewTextBoxColumn;
	}
}

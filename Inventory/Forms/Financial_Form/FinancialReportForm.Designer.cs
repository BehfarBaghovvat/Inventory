
namespace Financial_Form
{
	partial class FinancialReportForm
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
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.bottomPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.ancillaryCostsPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.ancillaryCostsButton = new Guna.UI2.WinForms.Guna2Button();
			this.ancillaryCostsLabel = new System.Windows.Forms.Label();
			this.capitalOutflowPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.capitalInflowButton = new Guna.UI2.WinForms.Guna2Button();
			this.capitalOutflowLabelLabel = new System.Windows.Forms.Label();
			this.capitalInflowPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.capitalOutflowButton = new Guna.UI2.WinForms.Guna2Button();
			this.capitalInflowLabel = new System.Windows.Forms.Label();
			this.capitalFundPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.capitalChartButton = new Guna.UI2.WinForms.Guna2Button();
			this.capitalFundLabel = new System.Windows.Forms.Label();
			this.guna2Panel1.SuspendLayout();
			this.ancillaryCostsPanel.SuspendLayout();
			this.capitalOutflowPanel.SuspendLayout();
			this.capitalInflowPanel.SuspendLayout();
			this.capitalFundPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BorderColor = System.Drawing.Color.Indigo;
			this.guna2Panel1.BorderRadius = 15;
			this.guna2Panel1.BorderThickness = 3;
			this.guna2Panel1.Controls.Add(this.bottomPanel);
			this.guna2Panel1.Controls.Add(this.ancillaryCostsPanel);
			this.guna2Panel1.Controls.Add(this.capitalOutflowPanel);
			this.guna2Panel1.Controls.Add(this.capitalInflowPanel);
			this.guna2Panel1.Controls.Add(this.capitalFundPanel);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(1150, 650);
			this.guna2Panel1.TabIndex = 0;
			// 
			// bottomPanel
			// 
			this.bottomPanel.BorderRadius = 15;
			this.bottomPanel.FillColor = System.Drawing.Color.Transparent;
			this.bottomPanel.FillColor2 = System.Drawing.Color.Transparent;
			this.bottomPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.bottomPanel.Location = new System.Drawing.Point(12, 168);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.ShadowDecoration.Parent = this.bottomPanel;
			this.bottomPanel.Size = new System.Drawing.Size(1125, 470);
			this.bottomPanel.TabIndex = 5;
			// 
			// ancillaryCostsPanel
			// 
			this.ancillaryCostsPanel.BorderColor = System.Drawing.Color.Orange;
			this.ancillaryCostsPanel.BorderRadius = 10;
			this.ancillaryCostsPanel.BorderThickness = 3;
			this.ancillaryCostsPanel.Controls.Add(this.ancillaryCostsButton);
			this.ancillaryCostsPanel.Controls.Add(this.ancillaryCostsLabel);
			this.ancillaryCostsPanel.Location = new System.Drawing.Point(312, 13);
			this.ancillaryCostsPanel.Name = "ancillaryCostsPanel";
			this.ancillaryCostsPanel.ShadowDecoration.Parent = this.ancillaryCostsPanel;
			this.ancillaryCostsPanel.Size = new System.Drawing.Size(250, 145);
			this.ancillaryCostsPanel.TabIndex = 1;
			// 
			// ancillaryCostsButton
			// 
			this.ancillaryCostsButton.Animated = true;
			this.ancillaryCostsButton.BorderColor = System.Drawing.Color.Transparent;
			this.ancillaryCostsButton.BorderRadius = 5;
			this.ancillaryCostsButton.BorderThickness = 2;
			this.ancillaryCostsButton.CheckedState.Parent = this.ancillaryCostsButton;
			this.ancillaryCostsButton.CustomImages.Parent = this.ancillaryCostsButton;
			this.ancillaryCostsButton.FillColor = System.Drawing.Color.Transparent;
			this.ancillaryCostsButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ancillaryCostsButton.ForeColor = System.Drawing.Color.White;
			this.ancillaryCostsButton.HoverState.FillColor = System.Drawing.Color.Indigo;
			this.ancillaryCostsButton.HoverState.Parent = this.ancillaryCostsButton;
			this.ancillaryCostsButton.Location = new System.Drawing.Point(8, 89);
			this.ancillaryCostsButton.Name = "ancillaryCostsButton";
			this.ancillaryCostsButton.PressedColor = System.Drawing.Color.White;
			this.ancillaryCostsButton.ShadowDecoration.Parent = this.ancillaryCostsButton;
			this.ancillaryCostsButton.Size = new System.Drawing.Size(235, 45);
			this.ancillaryCostsButton.TabIndex = 1;
			this.ancillaryCostsButton.Text = "نمایش هزینه های جانبی";
			this.ancillaryCostsButton.Click += new System.EventHandler(this.AncillaryCostsButton_Click);
			// 
			// ancillaryCostsLabel
			// 
			this.ancillaryCostsLabel.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ancillaryCostsLabel.ForeColor = System.Drawing.Color.White;
			this.ancillaryCostsLabel.Location = new System.Drawing.Point(10, 10);
			this.ancillaryCostsLabel.Name = "ancillaryCostsLabel";
			this.ancillaryCostsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ancillaryCostsLabel.Size = new System.Drawing.Size(230, 32);
			this.ancillaryCostsLabel.TabIndex = 0;
			this.ancillaryCostsLabel.Text = "0 تومان";
			this.ancillaryCostsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// capitalOutflowPanel
			// 
			this.capitalOutflowPanel.BorderColor = System.Drawing.Color.Orange;
			this.capitalOutflowPanel.BorderRadius = 10;
			this.capitalOutflowPanel.BorderThickness = 3;
			this.capitalOutflowPanel.Controls.Add(this.capitalInflowButton);
			this.capitalOutflowPanel.Controls.Add(this.capitalOutflowLabelLabel);
			this.capitalOutflowPanel.Location = new System.Drawing.Point(864, 13);
			this.capitalOutflowPanel.Name = "capitalOutflowPanel";
			this.capitalOutflowPanel.ShadowDecoration.Parent = this.capitalOutflowPanel;
			this.capitalOutflowPanel.Size = new System.Drawing.Size(250, 145);
			this.capitalOutflowPanel.TabIndex = 2;
			// 
			// capitalInflowButton
			// 
			this.capitalInflowButton.Animated = true;
			this.capitalInflowButton.BorderColor = System.Drawing.Color.Transparent;
			this.capitalInflowButton.BorderRadius = 5;
			this.capitalInflowButton.BorderThickness = 2;
			this.capitalInflowButton.CheckedState.Parent = this.capitalInflowButton;
			this.capitalInflowButton.CustomImages.Parent = this.capitalInflowButton;
			this.capitalInflowButton.FillColor = System.Drawing.Color.Transparent;
			this.capitalInflowButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.capitalInflowButton.ForeColor = System.Drawing.Color.White;
			this.capitalInflowButton.HoverState.FillColor = System.Drawing.Color.Indigo;
			this.capitalInflowButton.HoverState.Parent = this.capitalInflowButton;
			this.capitalInflowButton.Location = new System.Drawing.Point(8, 89);
			this.capitalInflowButton.Name = "capitalInflowButton";
			this.capitalInflowButton.PressedColor = System.Drawing.Color.White;
			this.capitalInflowButton.ShadowDecoration.Parent = this.capitalInflowButton;
			this.capitalInflowButton.Size = new System.Drawing.Size(235, 45);
			this.capitalInflowButton.TabIndex = 1;
			this.capitalInflowButton.Text = "نمایش خروج سرمایه";
			this.capitalInflowButton.Click += new System.EventHandler(this.CapitalOutflowButton_Click);
			// 
			// capitalOutflowLabelLabel
			// 
			this.capitalOutflowLabelLabel.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.capitalOutflowLabelLabel.ForeColor = System.Drawing.Color.White;
			this.capitalOutflowLabelLabel.Location = new System.Drawing.Point(10, 10);
			this.capitalOutflowLabelLabel.Name = "capitalOutflowLabelLabel";
			this.capitalOutflowLabelLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.capitalOutflowLabelLabel.Size = new System.Drawing.Size(230, 32);
			this.capitalOutflowLabelLabel.TabIndex = 0;
			this.capitalOutflowLabelLabel.Text = "0 تومان";
			this.capitalOutflowLabelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// capitalInflowPanel
			// 
			this.capitalInflowPanel.BorderColor = System.Drawing.Color.Orange;
			this.capitalInflowPanel.BorderRadius = 10;
			this.capitalInflowPanel.BorderThickness = 3;
			this.capitalInflowPanel.Controls.Add(this.capitalOutflowButton);
			this.capitalInflowPanel.Controls.Add(this.capitalInflowLabel);
			this.capitalInflowPanel.Location = new System.Drawing.Point(588, 13);
			this.capitalInflowPanel.Name = "capitalInflowPanel";
			this.capitalInflowPanel.ShadowDecoration.Parent = this.capitalInflowPanel;
			this.capitalInflowPanel.Size = new System.Drawing.Size(250, 145);
			this.capitalInflowPanel.TabIndex = 3;
			// 
			// capitalOutflowButton
			// 
			this.capitalOutflowButton.Animated = true;
			this.capitalOutflowButton.BorderColor = System.Drawing.Color.Transparent;
			this.capitalOutflowButton.BorderRadius = 5;
			this.capitalOutflowButton.BorderThickness = 2;
			this.capitalOutflowButton.CheckedState.Parent = this.capitalOutflowButton;
			this.capitalOutflowButton.CustomImages.Parent = this.capitalOutflowButton;
			this.capitalOutflowButton.FillColor = System.Drawing.Color.Transparent;
			this.capitalOutflowButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.capitalOutflowButton.ForeColor = System.Drawing.Color.White;
			this.capitalOutflowButton.HoverState.FillColor = System.Drawing.Color.Indigo;
			this.capitalOutflowButton.HoverState.Parent = this.capitalOutflowButton;
			this.capitalOutflowButton.Location = new System.Drawing.Point(8, 89);
			this.capitalOutflowButton.Name = "capitalOutflowButton";
			this.capitalOutflowButton.PressedColor = System.Drawing.Color.White;
			this.capitalOutflowButton.ShadowDecoration.Parent = this.capitalOutflowButton;
			this.capitalOutflowButton.Size = new System.Drawing.Size(235, 45);
			this.capitalOutflowButton.TabIndex = 1;
			this.capitalOutflowButton.Text = "نمایش ورود سرمایه";
			this.capitalOutflowButton.Click += new System.EventHandler(this.CapitalInflowButton_Click);
			// 
			// capitalInflowLabel
			// 
			this.capitalInflowLabel.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.capitalInflowLabel.ForeColor = System.Drawing.Color.White;
			this.capitalInflowLabel.Location = new System.Drawing.Point(10, 10);
			this.capitalInflowLabel.Name = "capitalInflowLabel";
			this.capitalInflowLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.capitalInflowLabel.Size = new System.Drawing.Size(230, 32);
			this.capitalInflowLabel.TabIndex = 0;
			this.capitalInflowLabel.Text = "0 تومان";
			this.capitalInflowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// capitalFundPanel
			// 
			this.capitalFundPanel.BorderColor = System.Drawing.Color.Orange;
			this.capitalFundPanel.BorderRadius = 10;
			this.capitalFundPanel.BorderThickness = 3;
			this.capitalFundPanel.Controls.Add(this.capitalChartButton);
			this.capitalFundPanel.Controls.Add(this.capitalFundLabel);
			this.capitalFundPanel.Location = new System.Drawing.Point(36, 13);
			this.capitalFundPanel.Name = "capitalFundPanel";
			this.capitalFundPanel.ShadowDecoration.Parent = this.capitalFundPanel;
			this.capitalFundPanel.Size = new System.Drawing.Size(250, 145);
			this.capitalFundPanel.TabIndex = 4;
			// 
			// capitalChartButton
			// 
			this.capitalChartButton.Animated = true;
			this.capitalChartButton.BorderColor = System.Drawing.Color.Transparent;
			this.capitalChartButton.BorderRadius = 5;
			this.capitalChartButton.BorderThickness = 2;
			this.capitalChartButton.CheckedState.Parent = this.capitalChartButton;
			this.capitalChartButton.CustomImages.Parent = this.capitalChartButton;
			this.capitalChartButton.FillColor = System.Drawing.Color.Transparent;
			this.capitalChartButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.capitalChartButton.ForeColor = System.Drawing.Color.White;
			this.capitalChartButton.HoverState.FillColor = System.Drawing.Color.Indigo;
			this.capitalChartButton.HoverState.Parent = this.capitalChartButton;
			this.capitalChartButton.Location = new System.Drawing.Point(8, 89);
			this.capitalChartButton.Name = "capitalChartButton";
			this.capitalChartButton.PressedColor = System.Drawing.Color.White;
			this.capitalChartButton.ShadowDecoration.Parent = this.capitalChartButton;
			this.capitalChartButton.Size = new System.Drawing.Size(235, 45);
			this.capitalChartButton.TabIndex = 1;
			this.capitalChartButton.Text = "نمایش نمودار سرمایه";
			this.capitalChartButton.Click += new System.EventHandler(this.CapitalChartButton_Click);
			// 
			// capitalFundLabel
			// 
			this.capitalFundLabel.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.capitalFundLabel.ForeColor = System.Drawing.Color.White;
			this.capitalFundLabel.Location = new System.Drawing.Point(10, 10);
			this.capitalFundLabel.Name = "capitalFundLabel";
			this.capitalFundLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.capitalFundLabel.Size = new System.Drawing.Size(230, 32);
			this.capitalFundLabel.TabIndex = 0;
			this.capitalFundLabel.Text = "0 تومان";
			this.capitalFundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FinancialReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(1150, 650);
			this.Controls.Add(this.guna2Panel1);
			this.Name = "FinancialReportForm";
			this.Text = "FinancialReportForm";
			this.guna2Panel1.ResumeLayout(false);
			this.ancillaryCostsPanel.ResumeLayout(false);
			this.capitalOutflowPanel.ResumeLayout(false);
			this.capitalInflowPanel.ResumeLayout(false);
			this.capitalFundPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2GradientPanel ancillaryCostsPanel;
		private Guna.UI2.WinForms.Guna2Button ancillaryCostsButton;
		private System.Windows.Forms.Label ancillaryCostsLabel;
		private Guna.UI2.WinForms.Guna2GradientPanel capitalOutflowPanel;
		private Guna.UI2.WinForms.Guna2Button capitalInflowButton;
		private System.Windows.Forms.Label capitalOutflowLabelLabel;
		private Guna.UI2.WinForms.Guna2GradientPanel capitalInflowPanel;
		private Guna.UI2.WinForms.Guna2Button capitalOutflowButton;
		private System.Windows.Forms.Label capitalInflowLabel;
		private Guna.UI2.WinForms.Guna2GradientPanel capitalFundPanel;
		private Guna.UI2.WinForms.Guna2Button capitalChartButton;
		private System.Windows.Forms.Label capitalFundLabel;
		private Guna.UI2.WinForms.Guna2GradientPanel bottomPanel;
	}
}
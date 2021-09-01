
namespace Financial_Form
{
	partial class SectionChequeBankForm
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
			this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.chequaPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.getChequaButton = new Guna.UI2.WinForms.Guna2Button();
			this.issuanceChequaButton = new Guna.UI2.WinForms.Guna2Button();
			this.listChequasBankButton = new Guna.UI2.WinForms.Guna2Button();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BorderColor = System.Drawing.Color.Indigo;
			this.mainPanel.BorderRadius = 15;
			this.mainPanel.BorderThickness = 3;
			this.mainPanel.Controls.Add(this.chequaPanel);
			this.mainPanel.Controls.Add(this.getChequaButton);
			this.mainPanel.Controls.Add(this.issuanceChequaButton);
			this.mainPanel.Controls.Add(this.listChequasBankButton);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
			this.mainPanel.Size = new System.Drawing.Size(1134, 611);
			this.mainPanel.TabIndex = 0;
			// 
			// chequaPanel
			// 
			this.chequaPanel.BorderColor = System.Drawing.Color.RoyalBlue;
			this.chequaPanel.Location = new System.Drawing.Point(12, 79);
			this.chequaPanel.Name = "chequaPanel";
			this.chequaPanel.ShadowDecoration.Parent = this.chequaPanel;
			this.chequaPanel.Size = new System.Drawing.Size(1110, 520);
			this.chequaPanel.TabIndex = 0;
			// 
			// getChequaButton
			// 
			this.getChequaButton.Animated = true;
			this.getChequaButton.BorderRadius = 15;
			this.getChequaButton.CheckedState.FillColor = System.Drawing.Color.BlueViolet;
			this.getChequaButton.CheckedState.Parent = this.getChequaButton;
			this.getChequaButton.CustomImages.Parent = this.getChequaButton;
			this.getChequaButton.FillColor = System.Drawing.Color.RoyalBlue;
			this.getChequaButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.getChequaButton.ForeColor = System.Drawing.Color.White;
			this.getChequaButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
			this.getChequaButton.HoverState.Parent = this.getChequaButton;
			this.getChequaButton.Location = new System.Drawing.Point(735, 35);
			this.getChequaButton.Name = "getChequaButton";
			this.getChequaButton.ShadowDecoration.Parent = this.getChequaButton;
			this.getChequaButton.Size = new System.Drawing.Size(180, 70);
			this.getChequaButton.TabIndex = 1;
			this.getChequaButton.Text = "دریافت چک";
			this.getChequaButton.TextOffset = new System.Drawing.Point(0, -10);
			this.getChequaButton.Click += new System.EventHandler(this.GetChequaButton_Click);
			// 
			// issuanceChequaButton
			// 
			this.issuanceChequaButton.Animated = true;
			this.issuanceChequaButton.BorderRadius = 15;
			this.issuanceChequaButton.Checked = true;
			this.issuanceChequaButton.CheckedState.FillColor = System.Drawing.Color.BlueViolet;
			this.issuanceChequaButton.CheckedState.Parent = this.issuanceChequaButton;
			this.issuanceChequaButton.CustomImages.Parent = this.issuanceChequaButton;
			this.issuanceChequaButton.FillColor = System.Drawing.Color.RoyalBlue;
			this.issuanceChequaButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.issuanceChequaButton.ForeColor = System.Drawing.Color.White;
			this.issuanceChequaButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
			this.issuanceChequaButton.HoverState.Parent = this.issuanceChequaButton;
			this.issuanceChequaButton.Location = new System.Drawing.Point(921, 35);
			this.issuanceChequaButton.Name = "issuanceChequaButton";
			this.issuanceChequaButton.ShadowDecoration.Parent = this.issuanceChequaButton;
			this.issuanceChequaButton.Size = new System.Drawing.Size(180, 70);
			this.issuanceChequaButton.TabIndex = 1;
			this.issuanceChequaButton.Text = "صدور چک";
			this.issuanceChequaButton.TextOffset = new System.Drawing.Point(0, -10);
			this.issuanceChequaButton.Click += new System.EventHandler(this.IssuanceChequaButton_Click);
			// 
			// listChequasBankButton
			// 
			this.listChequasBankButton.Animated = true;
			this.listChequasBankButton.BorderRadius = 15;
			this.listChequasBankButton.CheckedState.FillColor = System.Drawing.Color.BlueViolet;
			this.listChequasBankButton.CheckedState.Parent = this.listChequasBankButton;
			this.listChequasBankButton.CustomImages.Parent = this.listChequasBankButton;
			this.listChequasBankButton.FillColor = System.Drawing.Color.RoyalBlue;
			this.listChequasBankButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listChequasBankButton.ForeColor = System.Drawing.Color.White;
			this.listChequasBankButton.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
			this.listChequasBankButton.HoverState.Parent = this.listChequasBankButton;
			this.listChequasBankButton.Location = new System.Drawing.Point(549, 35);
			this.listChequasBankButton.Name = "listChequasBankButton";
			this.listChequasBankButton.ShadowDecoration.Parent = this.listChequasBankButton;
			this.listChequasBankButton.Size = new System.Drawing.Size(180, 70);
			this.listChequasBankButton.TabIndex = 2;
			this.listChequasBankButton.Text = "لیست چکهای بانکی";
			this.listChequasBankButton.TextOffset = new System.Drawing.Point(0, -10);
			this.listChequasBankButton.Click += new System.EventHandler(this.ListChequasBankButton_Click);
			// 
			// SectionChequeBankForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(1134, 611);
			this.Controls.Add(this.mainPanel);
			this.Font = new System.Drawing.Font("IRANSansXFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "SectionChequeBankForm";
			this.Text = "SectionChequeBankForm";
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel mainPanel;
		private Guna.UI2.WinForms.Guna2Panel chequaPanel;
		private Guna.UI2.WinForms.Guna2Button getChequaButton;
		private Guna.UI2.WinForms.Guna2Button issuanceChequaButton;
		private Guna.UI2.WinForms.Guna2Button listChequasBankButton;
	}
}
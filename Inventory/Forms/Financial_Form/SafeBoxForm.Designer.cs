
namespace Financial_Form
{
	partial class SafeBoxForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeBoxForm));
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.acceptButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.entryFuneTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.funeLabel = new Mbb.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BorderColor = System.Drawing.Color.Indigo;
			this.mainPanel.BorderRadius = 15;
			this.mainPanel.BorderThickness = 3;
			this.mainPanel.Controls.Add(this.acceptButton);
			this.mainPanel.Controls.Add(this.entryFuneTextBox);
			this.mainPanel.Controls.Add(this.funeLabel);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
			this.mainPanel.Size = new System.Drawing.Size(1150, 650);
			this.mainPanel.TabIndex = 0;
			// 
			// acceptButton
			// 
			this.acceptButton.Animated = true;
			this.acceptButton.BackColor = System.Drawing.Color.Transparent;
			this.acceptButton.BorderRadius = 20;
			this.acceptButton.CheckedState.Parent = this.acceptButton;
			this.acceptButton.CustomImages.Parent = this.acceptButton;
			this.acceptButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.acceptButton.FillColor2 = System.Drawing.Color.RoyalBlue;
			this.acceptButton.Font = new System.Drawing.Font("IRANSansX", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.acceptButton.ForeColor = System.Drawing.Color.White;
			this.acceptButton.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
			this.acceptButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.acceptButton.HoverState.Parent = this.acceptButton;
			this.acceptButton.Location = new System.Drawing.Point(450, 386);
			this.acceptButton.Name = "acceptButton";
			this.acceptButton.ShadowDecoration.BorderRadius = 15;
			this.acceptButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.acceptButton.ShadowDecoration.Parent = this.acceptButton;
			this.acceptButton.Size = new System.Drawing.Size(250, 45);
			this.acceptButton.TabIndex = 2;
			this.acceptButton.Text = "واریز مبلغ";
			this.acceptButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
			// 
			// entryFuneTextBox
			// 
			this.entryFuneTextBox.AcceptsReturn = false;
			this.entryFuneTextBox.AcceptsTab = false;
			this.entryFuneTextBox.AnimationSpeed = 200;
			this.entryFuneTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.entryFuneTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.entryFuneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.entryFuneTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entryFuneTextBox.BackgroundImage")));
			this.entryFuneTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.entryFuneTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.entryFuneTextBox.BorderColorHover = System.Drawing.Color.Purple;
			this.entryFuneTextBox.BorderColorIdle = System.Drawing.Color.RoyalBlue;
			this.entryFuneTextBox.BorderRadius = 1;
			this.entryFuneTextBox.BorderThickness = 3;
			this.entryFuneTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.entryFuneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.entryFuneTextBox.DefaultFont = new System.Drawing.Font("IRANSansXFaNum", 12F);
			this.entryFuneTextBox.DefaultText = "";
			this.entryFuneTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.entryFuneTextBox.ForeColor = System.Drawing.Color.White;
			this.entryFuneTextBox.HideSelection = true;
			this.entryFuneTextBox.IconLeft = null;
			this.entryFuneTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.entryFuneTextBox.IconPadding = 10;
			this.entryFuneTextBox.IconRight = null;
			this.entryFuneTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.entryFuneTextBox.Lines = new string[0];
			this.entryFuneTextBox.Location = new System.Drawing.Point(374, 284);
			this.entryFuneTextBox.MaxLength = 32767;
			this.entryFuneTextBox.MinimumSize = new System.Drawing.Size(100, 35);
			this.entryFuneTextBox.Modified = false;
			this.entryFuneTextBox.Multiline = false;
			this.entryFuneTextBox.Name = "entryFuneTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.entryFuneTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.entryFuneTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.Purple;
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.entryFuneTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.RoyalBlue;
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			stateProperties4.ForeColor = System.Drawing.Color.White;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.entryFuneTextBox.OnIdleState = stateProperties4;
			this.entryFuneTextBox.PasswordChar = '\0';
			this.entryFuneTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.entryFuneTextBox.PlaceholderText = "مبلغ جدید را وارد نمایید...";
			this.entryFuneTextBox.ReadOnly = false;
			this.entryFuneTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.entryFuneTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.entryFuneTextBox.SelectedText = "";
			this.entryFuneTextBox.SelectionLength = 0;
			this.entryFuneTextBox.SelectionStart = 0;
			this.entryFuneTextBox.ShortcutsEnabled = true;
			this.entryFuneTextBox.Size = new System.Drawing.Size(402, 51);
			this.entryFuneTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.entryFuneTextBox.TabIndex = 1;
			this.entryFuneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.entryFuneTextBox.TextMarginBottom = 0;
			this.entryFuneTextBox.TextMarginLeft = 5;
			this.entryFuneTextBox.TextMarginTop = 0;
			this.entryFuneTextBox.TextPlaceholder = "مبلغ جدید را وارد نمایید...";
			this.entryFuneTextBox.UseSystemPasswordChar = false;
			this.entryFuneTextBox.WordWrap = true;
			this.entryFuneTextBox.TextChange += new System.EventHandler(this.EntryFuneTextBox_TextChange);
			this.entryFuneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntryFuneTextBox_KeyPress);
			this.entryFuneTextBox.Enter += new System.EventHandler(this.EntryFuneTextBox_Enter);
			this.entryFuneTextBox.Leave += new System.EventHandler(this.EntryFuneTextBox_Leave);
			// 
			// funeLabel
			// 
			this.funeLabel.Font = new System.Drawing.Font("IRANSansXFaNum", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.funeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.funeLabel.Location = new System.Drawing.Point(12, 107);
			this.funeLabel.Name = "funeLabel";
			this.funeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.funeLabel.Size = new System.Drawing.Size(1126, 141);
			this.funeLabel.TabIndex = 0;
			this.funeLabel.Text = "مبلغ سرمایه";
			this.funeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SafeBoxForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(1150, 650);
			this.Controls.Add(this.mainPanel);
			this.Name = "SafeBoxForm";
			this.Text = "SafeBoxForm";
			this.Load += new System.EventHandler(this.SafeBoxForm_Load);
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel mainPanel;
		private Guna.UI2.WinForms.Guna2GradientButton acceptButton;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox entryFuneTextBox;
		private Mbb.Windows.Forms.Label funeLabel;
	}
}
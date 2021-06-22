namespace StartPage
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.loginFormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.forgetPasswordLinkLabel = new Guna.UI.WinForms.GunaLinkLabel();
			this.fadeFormTimer = new System.Windows.Forms.Timer(this.components);
			this.fadeInMessageBoxLabelTimer = new System.Windows.Forms.Timer(this.components);
			this.userImagePicturBox = new Bunifu.UI.WinForms.BunifuPictureBox();
			this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
			this.backgorundPanel = new Mbb.Windows.Forms.Panel();
			this.messageBoxLabel = new Mbb.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).BeginInit();
			this.backgorundPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// loginFormElipse
			// 
			this.loginFormElipse.BorderRadius = 45;
			this.loginFormElipse.TargetControl = this;
			// 
			// forgetPasswordLinkLabel
			// 
			this.forgetPasswordLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.forgetPasswordLinkLabel.AutoSize = true;
			this.forgetPasswordLinkLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forgetPasswordLinkLabel.ForeColor = System.Drawing.Color.White;
			this.forgetPasswordLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.forgetPasswordLinkLabel.LinkColor = System.Drawing.Color.White;
			this.forgetPasswordLinkLabel.Location = new System.Drawing.Point(562, 356);
			this.forgetPasswordLinkLabel.Name = "forgetPasswordLinkLabel";
			this.forgetPasswordLinkLabel.Size = new System.Drawing.Size(157, 22);
			this.forgetPasswordLinkLabel.TabIndex = 3;
			this.forgetPasswordLinkLabel.TabStop = true;
			this.forgetPasswordLinkLabel.Text = "( رمز عبور را فراموش کردم )";
			this.forgetPasswordLinkLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
			// 
			// fadeFormTimer
			// 
			this.fadeFormTimer.Interval = 10;
			this.fadeFormTimer.Tick += new System.EventHandler(this.FadeFormTimer_Tick);
			// 
			// fadeInMessageBoxLabelTimer
			// 
			this.fadeInMessageBoxLabelTimer.Interval = 10;
			this.fadeInMessageBoxLabelTimer.Tick += new System.EventHandler(this.FadeInMessageBoxLabelTimer_Tick);
			// 
			// userImagePicturBox
			// 
			this.userImagePicturBox.AllowFocused = false;
			this.userImagePicturBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.userImagePicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.userImagePicturBox.BorderRadius = 100;
			this.userImagePicturBox.Image = global::Inventory.Properties.Resources.new_user_1080_Light_Gray;
			this.userImagePicturBox.IsCircle = false;
			this.userImagePicturBox.Location = new System.Drawing.Point(540, 21);
			this.userImagePicturBox.Name = "userImagePicturBox";
			this.userImagePicturBox.Size = new System.Drawing.Size(200, 200);
			this.userImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.userImagePicturBox.TabIndex = 4;
			this.userImagePicturBox.TabStop = false;
			this.userImagePicturBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Animated = true;
			this.passwordTextBox.AutoRoundedCorners = true;
			this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
			this.passwordTextBox.BorderColor = System.Drawing.Color.Aqua;
			this.passwordTextBox.BorderRadius = 19;
			this.passwordTextBox.BorderThickness = 2;
			this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.passwordTextBox.DefaultText = "";
			this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.passwordTextBox.DisabledState.Parent = this.passwordTextBox;
			this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.passwordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(216)))));
			this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
			this.passwordTextBox.FocusedState.ForeColor = System.Drawing.Color.White;
			this.passwordTextBox.FocusedState.Parent = this.passwordTextBox;
			this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.DarkMagenta;
			this.passwordTextBox.HoverState.Parent = this.passwordTextBox;
			this.passwordTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.IconLeft")));
			this.passwordTextBox.IconLeftOffset = new System.Drawing.Point(10, 0);
			this.passwordTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
			this.passwordTextBox.Location = new System.Drawing.Point(515, 295);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '\0';
			this.passwordTextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.passwordTextBox.PlaceholderText = "Password";
			this.passwordTextBox.SelectedText = "";
			this.passwordTextBox.ShadowDecoration.Parent = this.passwordTextBox;
			this.passwordTextBox.ShortcutsEnabled = false;
			this.passwordTextBox.Size = new System.Drawing.Size(250, 40);
			this.passwordTextBox.TabIndex = 2;
			this.passwordTextBox.TextOffset = new System.Drawing.Point(3, 0);
			this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
			this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Animated = true;
			this.usernameTextBox.AutoRoundedCorners = true;
			this.usernameTextBox.BackColor = System.Drawing.Color.Transparent;
			this.usernameTextBox.BorderColor = System.Drawing.Color.Aqua;
			this.usernameTextBox.BorderRadius = 19;
			this.usernameTextBox.BorderThickness = 2;
			this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.usernameTextBox.DefaultText = "";
			this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.usernameTextBox.DisabledState.Parent = this.usernameTextBox;
			this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.usernameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(216)))));
			this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
			this.usernameTextBox.FocusedState.ForeColor = System.Drawing.Color.White;
			this.usernameTextBox.FocusedState.Parent = this.usernameTextBox;
			this.usernameTextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.DarkMagenta;
			this.usernameTextBox.HoverState.Parent = this.usernameTextBox;
			this.usernameTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("usernameTextBox.IconLeft")));
			this.usernameTextBox.IconLeftOffset = new System.Drawing.Point(10, 0);
			this.usernameTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
			this.usernameTextBox.Location = new System.Drawing.Point(515, 240);
			this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.PasswordChar = '\0';
			this.usernameTextBox.PlaceholderForeColor = System.Drawing.Color.Transparent;
			this.usernameTextBox.PlaceholderText = "Username";
			this.usernameTextBox.SelectedText = "";
			this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
			this.usernameTextBox.ShortcutsEnabled = false;
			this.usernameTextBox.Size = new System.Drawing.Size(250, 40);
			this.usernameTextBox.TabIndex = 1;
			this.usernameTextBox.TextOffset = new System.Drawing.Point(3, 0);
			this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
			this.usernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
			this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTextBox_KeyPress);
			// 
			// backgorundPanel
			// 
			this.backgorundPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.backgorundPanel.BackColor = System.Drawing.Color.Transparent;
			this.backgorundPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgorundPanel.BackgroundImage")));
			this.backgorundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.backgorundPanel.Controls.Add(this.messageBoxLabel);
			this.backgorundPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.backgorundPanel.ForeColor = System.Drawing.Color.White;
			this.backgorundPanel.Location = new System.Drawing.Point(0, 0);
			this.backgorundPanel.Name = "backgorundPanel";
			this.backgorundPanel.Size = new System.Drawing.Size(600, 450);
			this.backgorundPanel.TabIndex = 0;
			// 
			// messageBoxLabel
			// 
			this.messageBoxLabel.AutoSize = true;
			this.messageBoxLabel.Font = new System.Drawing.Font("IRANSans Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageBoxLabel.ForeColor = System.Drawing.Color.Gold;
			this.messageBoxLabel.Location = new System.Drawing.Point(75, 200);
			this.messageBoxLabel.Name = "messageBoxLabel";
			this.messageBoxLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.messageBoxLabel.Size = new System.Drawing.Size(332, 53);
			this.messageBoxLabel.TabIndex = 0;
			this.messageBoxLabel.Text = "صبح بخیر کاربر گرامی";
			this.messageBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(88)))), ((int)(((byte)(216)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.userImagePicturBox);
			this.Controls.Add(this.forgetPasswordLinkLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.backgorundPanel);
			this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximumSize = new System.Drawing.Size(800, 450);
			this.MinimumSize = new System.Drawing.Size(800, 450);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).EndInit();
			this.backgorundPanel.ResumeLayout(false);
			this.backgorundPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.Panel backgorundPanel;
		private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
		private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
		private Guna.UI2.WinForms.Guna2Elipse loginFormElipse;
		private Guna.UI.WinForms.GunaLinkLabel forgetPasswordLinkLabel;
		private System.Windows.Forms.Timer fadeFormTimer;
		private System.Windows.Forms.Timer fadeInMessageBoxLabelTimer;
		private Mbb.Windows.Forms.Label messageBoxLabel;
		private Bunifu.UI.WinForms.BunifuPictureBox userImagePicturBox;
	}
}

namespace Entry_Forms
{
	partial class SingInForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingInForm));
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
			this.top = new Mbb.Windows.Forms.Panel();
			this.closeButton = new Guna.UI2.WinForms.Guna2Button();
			this.right = new Mbb.Windows.Forms.Panel();
			this.singUpButton = new Guna.UI2.WinForms.Guna2GradientButton();
			this.showPasswordPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
			this.userImagePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.passwordTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.usernameTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
			this.leftPanel = new System.Windows.Forms.Panel();
			this.backgroundPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.fadeInSingInFormTimer = new System.Windows.Forms.Timer(this.components);
			this.fadeOutSingInFormTimer = new System.Windows.Forms.Timer(this.components);
			this.fadeOutForSingUpTimer = new System.Windows.Forms.Timer(this.components);
			this.top.SuspendLayout();
			this.right.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.showPasswordPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).BeginInit();
			this.leftPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// top
			// 
			this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
			this.top.Controls.Add(this.closeButton);
			this.top.Dock = System.Windows.Forms.DockStyle.Top;
			this.top.Location = new System.Drawing.Point(0, 0);
			this.top.Name = "top";
			this.top.Size = new System.Drawing.Size(840, 30);
			this.top.TabIndex = 0;
			// 
			// closeButton
			// 
			this.closeButton.Animated = true;
			this.closeButton.CheckedState.Parent = this.closeButton;
			this.closeButton.CustomImages.Parent = this.closeButton;
			this.closeButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.HoverState.Parent = this.closeButton;
			this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
			this.closeButton.ImageSize = new System.Drawing.Size(15, 15);
			this.closeButton.Location = new System.Drawing.Point(0, 0);
			this.closeButton.Name = "closeButton";
			this.closeButton.PressedColor = System.Drawing.Color.White;
			this.closeButton.ShadowDecoration.Parent = this.closeButton;
			this.closeButton.Size = new System.Drawing.Size(50, 30);
			this.closeButton.TabIndex = 1;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// right
			// 
			this.right.BackColor = System.Drawing.Color.Transparent;
			this.right.Controls.Add(this.singUpButton);
			this.right.Controls.Add(this.showPasswordPictureBox);
			this.right.Controls.Add(this.userImagePictureBox);
			this.right.Controls.Add(this.passwordTextBox);
			this.right.Controls.Add(this.usernameTextBox);
			this.right.Dock = System.Windows.Forms.DockStyle.Right;
			this.right.Location = new System.Drawing.Point(380, 30);
			this.right.Name = "right";
			this.right.Size = new System.Drawing.Size(460, 280);
			this.right.TabIndex = 0;
			// 
			// singUpButton
			// 
			this.singUpButton.Animated = true;
			this.singUpButton.BorderRadius = 7;
			this.singUpButton.CheckedState.Parent = this.singUpButton;
			this.singUpButton.CustomImages.Parent = this.singUpButton;
			this.singUpButton.FillColor = System.Drawing.Color.MediumSlateBlue;
			this.singUpButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
			this.singUpButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.singUpButton.ForeColor = System.Drawing.Color.White;
			this.singUpButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
			this.singUpButton.HoverState.FillColor2 = System.Drawing.Color.MediumSlateBlue;
			this.singUpButton.HoverState.Parent = this.singUpButton;
			this.singUpButton.Location = new System.Drawing.Point(343, 6);
			this.singUpButton.Name = "singUpButton";
			this.singUpButton.PressedColor = System.Drawing.Color.White;
			this.singUpButton.ShadowDecoration.Parent = this.singUpButton;
			this.singUpButton.Size = new System.Drawing.Size(105, 34);
			this.singUpButton.TabIndex = 8;
			this.singUpButton.Text = "حساب جدید";
			this.singUpButton.Click += new System.EventHandler(this.SingUpButton_Click);
			// 
			// showPasswordPictureBox
			// 
			this.showPasswordPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.showPasswordPictureBox.Image = global::Inventory.Properties.Resources.show_512;
			this.showPasswordPictureBox.Location = new System.Drawing.Point(354, 201);
			this.showPasswordPictureBox.Name = "showPasswordPictureBox";
			this.showPasswordPictureBox.ShadowDecoration.Parent = this.showPasswordPictureBox;
			this.showPasswordPictureBox.Size = new System.Drawing.Size(30, 30);
			this.showPasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.showPasswordPictureBox.TabIndex = 7;
			this.showPasswordPictureBox.TabStop = false;
			this.showPasswordPictureBox.UseTransparentBackground = true;
			this.showPasswordPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordPictureBox_MouseDown);
			this.showPasswordPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordPictureBox_MouseUp);
			// 
			// userImagePictureBox
			// 
			this.userImagePictureBox.Image = global::Inventory.Properties.Resources.circled_user_male_skin_type_3_512px;
			this.userImagePictureBox.Location = new System.Drawing.Point(170, 6);
			this.userImagePictureBox.Name = "userImagePictureBox";
			this.userImagePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.userImagePictureBox.ShadowDecoration.Parent = this.userImagePictureBox;
			this.userImagePictureBox.Size = new System.Drawing.Size(120, 120);
			this.userImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userImagePictureBox.TabIndex = 5;
			this.userImagePictureBox.TabStop = false;
			this.userImagePictureBox.UseTransparentBackground = true;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.AcceptsReturn = false;
			this.passwordTextBox.AcceptsTab = false;
			this.passwordTextBox.AnimationSpeed = 200;
			this.passwordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.passwordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
			this.passwordTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.BackgroundImage")));
			this.passwordTextBox.BorderColorActive = System.Drawing.Color.White;
			this.passwordTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.passwordTextBox.BorderColorHover = System.Drawing.Color.Magenta;
			this.passwordTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.passwordTextBox.BorderRadius = 1;
			this.passwordTextBox.BorderThickness = 3;
			this.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.passwordTextBox.DefaultFont = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.DefaultText = "";
			this.passwordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
			this.passwordTextBox.ForeColor = System.Drawing.Color.White;
			this.passwordTextBox.HideSelection = true;
			this.passwordTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.IconLeft")));
			this.passwordTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.passwordTextBox.IconPadding = 6;
			this.passwordTextBox.IconRight = null;
			this.passwordTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.passwordTextBox.Lines = new string[0];
			this.passwordTextBox.Location = new System.Drawing.Point(70, 196);
			this.passwordTextBox.MaximumSize = new System.Drawing.Size(320, 40);
			this.passwordTextBox.MaxLength = 32767;
			this.passwordTextBox.MinimumSize = new System.Drawing.Size(320, 40);
			this.passwordTextBox.Modified = false;
			this.passwordTextBox.Multiline = false;
			this.passwordTextBox.Name = "passwordTextBox";
			stateProperties1.BorderColor = System.Drawing.Color.White;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.passwordTextBox.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.Empty;
			stateProperties2.FillColor = System.Drawing.Color.White;
			stateProperties2.ForeColor = System.Drawing.Color.Empty;
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.passwordTextBox.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.Magenta;
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.passwordTextBox.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
			stateProperties4.ForeColor = System.Drawing.Color.White;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.passwordTextBox.OnIdleState = stateProperties4;
			this.passwordTextBox.PasswordChar = '\0';
			this.passwordTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
			this.passwordTextBox.PlaceholderText = "Password";
			this.passwordTextBox.ReadOnly = false;
			this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.passwordTextBox.SelectedText = "";
			this.passwordTextBox.SelectionLength = 0;
			this.passwordTextBox.SelectionStart = 0;
			this.passwordTextBox.ShortcutsEnabled = true;
			this.passwordTextBox.Size = new System.Drawing.Size(320, 40);
			this.passwordTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.passwordTextBox.TabIndex = 1;
			this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.passwordTextBox.TextMarginBottom = 0;
			this.passwordTextBox.TextMarginLeft = 15;
			this.passwordTextBox.TextMarginTop = 0;
			this.passwordTextBox.TextPlaceholder = "Password";
			this.passwordTextBox.UseSystemPasswordChar = false;
			this.passwordTextBox.WordWrap = true;
			this.passwordTextBox.TextChange += new System.EventHandler(this.PasswordTextBox_TextChange);
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.AcceptsReturn = false;
			this.usernameTextBox.AcceptsTab = false;
			this.usernameTextBox.AnimationSpeed = 200;
			this.usernameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.usernameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
			this.usernameTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usernameTextBox.BackgroundImage")));
			this.usernameTextBox.BorderColorActive = System.Drawing.Color.White;
			this.usernameTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
			this.usernameTextBox.BorderColorHover = System.Drawing.Color.Magenta;
			this.usernameTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.usernameTextBox.BorderRadius = 1;
			this.usernameTextBox.BorderThickness = 3;
			this.usernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.usernameTextBox.DefaultFont = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.DefaultText = "";
			this.usernameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
			this.usernameTextBox.ForeColor = System.Drawing.Color.White;
			this.usernameTextBox.HideSelection = true;
			this.usernameTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("usernameTextBox.IconLeft")));
			this.usernameTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.usernameTextBox.IconPadding = 3;
			this.usernameTextBox.IconRight = null;
			this.usernameTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.usernameTextBox.Lines = new string[0];
			this.usernameTextBox.Location = new System.Drawing.Point(70, 135);
			this.usernameTextBox.MaximumSize = new System.Drawing.Size(320, 40);
			this.usernameTextBox.MaxLength = 32767;
			this.usernameTextBox.MinimumSize = new System.Drawing.Size(320, 40);
			this.usernameTextBox.Modified = false;
			this.usernameTextBox.Multiline = false;
			this.usernameTextBox.Name = "usernameTextBox";
			stateProperties5.BorderColor = System.Drawing.Color.White;
			stateProperties5.FillColor = System.Drawing.Color.Empty;
			stateProperties5.ForeColor = System.Drawing.Color.Empty;
			stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.usernameTextBox.OnActiveState = stateProperties5;
			stateProperties6.BorderColor = System.Drawing.Color.Empty;
			stateProperties6.FillColor = System.Drawing.Color.White;
			stateProperties6.ForeColor = System.Drawing.Color.Empty;
			stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.usernameTextBox.OnDisabledState = stateProperties6;
			stateProperties7.BorderColor = System.Drawing.Color.Magenta;
			stateProperties7.FillColor = System.Drawing.Color.Empty;
			stateProperties7.ForeColor = System.Drawing.Color.Empty;
			stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.usernameTextBox.OnHoverState = stateProperties7;
			stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
			stateProperties8.ForeColor = System.Drawing.Color.White;
			stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.usernameTextBox.OnIdleState = stateProperties8;
			this.usernameTextBox.PasswordChar = '\0';
			this.usernameTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
			this.usernameTextBox.PlaceholderText = "Username";
			this.usernameTextBox.ReadOnly = false;
			this.usernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.usernameTextBox.SelectedText = "";
			this.usernameTextBox.SelectionLength = 0;
			this.usernameTextBox.SelectionStart = 0;
			this.usernameTextBox.ShortcutsEnabled = true;
			this.usernameTextBox.Size = new System.Drawing.Size(320, 40);
			this.usernameTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
			this.usernameTextBox.TabIndex = 0;
			this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.usernameTextBox.TextMarginBottom = 0;
			this.usernameTextBox.TextMarginLeft = 15;
			this.usernameTextBox.TextMarginTop = 0;
			this.usernameTextBox.TextPlaceholder = "Username";
			this.usernameTextBox.UseSystemPasswordChar = false;
			this.usernameTextBox.WordWrap = true;
			this.usernameTextBox.TextChange += new System.EventHandler(this.UsernameTextBox_TextChange);
			this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTextBox_KeyPress);
			this.usernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
			// 
			// leftPanel
			// 
			this.leftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.leftPanel.Controls.Add(this.backgroundPictureBox);
			this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.leftPanel.Location = new System.Drawing.Point(0, 30);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(380, 280);
			this.leftPanel.TabIndex = 1;
			// 
			// backgroundPictureBox
			// 
			this.backgroundPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("backgroundPictureBox.Image")));
			this.backgroundPictureBox.Location = new System.Drawing.Point(3, 0);
			this.backgroundPictureBox.Name = "backgroundPictureBox";
			this.backgroundPictureBox.ShadowDecoration.Parent = this.backgroundPictureBox;
			this.backgroundPictureBox.Size = new System.Drawing.Size(377, 280);
			this.backgroundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.backgroundPictureBox.TabIndex = 0;
			this.backgroundPictureBox.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 30);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(420, 420);
			this.panel1.TabIndex = 1;
			// 
			// fadeInSingInFormTimer
			// 
			this.fadeInSingInFormTimer.Interval = 10;
			this.fadeInSingInFormTimer.Tick += new System.EventHandler(this.FadeInSingInFormTimer_Tick);
			// 
			// fadeOutSingInFormTimer
			// 
			this.fadeOutSingInFormTimer.Interval = 10;
			this.fadeOutSingInFormTimer.Tick += new System.EventHandler(this.FadeOutSingInFormTimer_Tick);
			// 
			// fadeOutForSingUpTimer
			// 
			this.fadeOutForSingUpTimer.Interval = 10;
			this.fadeOutForSingUpTimer.Tick += new System.EventHandler(this.FadeOutForSingUpTimer_Tick);
			// 
			// SingInForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
			this.ClientSize = new System.Drawing.Size(840, 310);
			this.Controls.Add(this.leftPanel);
			this.Controls.Add(this.right);
			this.Controls.Add(this.top);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SingInForm";
			this.Opacity = 0.95D;
			this.Text = "LoginForm";
			this.TransparencyKey = System.Drawing.SystemColors.Control;
			this.Load += new System.EventHandler(this.SingInForm_Load);
			this.top.ResumeLayout(false);
			this.right.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.showPasswordPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).EndInit();
			this.leftPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel top;
		private Mbb.Windows.Forms.Panel right;
		private Guna.UI2.WinForms.Guna2CirclePictureBox userImagePictureBox;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox passwordTextBox;
		private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox usernameTextBox;
		private Guna.UI2.WinForms.Guna2PictureBox showPasswordPictureBox;
		private System.Windows.Forms.Panel leftPanel;
		private Guna.UI2.WinForms.Guna2Button closeButton;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2GradientButton singUpButton;
		private Guna.UI2.WinForms.Guna2PictureBox backgroundPictureBox;
		private System.Windows.Forms.Timer fadeInSingInFormTimer;
		private System.Windows.Forms.Timer fadeOutSingInFormTimer;
		private System.Windows.Forms.Timer fadeOutForSingUpTimer;
	}
}
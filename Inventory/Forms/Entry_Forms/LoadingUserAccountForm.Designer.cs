
namespace Entry_Forms
{
	partial class LoadingUserAccountForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingUserAccountForm));
			this.userImagePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.welcomeMessageLabel = new Mbb.Windows.Forms.Label();
			this.label2 = new Mbb.Windows.Forms.Label();
			this.loadingPanel = new Guna.UI2.WinForms.Guna2Panel();
			this.loadingMessageLabel = new Mbb.Windows.Forms.Label();
			this.loadPercentLabel = new Mbb.Windows.Forms.Label();
			this.loaderProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
			this.logoPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
			this.fadeWelcomTitleTimer = new System.Windows.Forms.Timer(this.components);
			this.messageBoxLabel = new Mbb.Windows.Forms.Label();
			this.fadeMessageTitleTimer = new System.Windows.Forms.Timer(this.components);
			this.fadeLoadingPanelTimer = new System.Windows.Forms.Timer(this.components);
			this.fadeInTimer = new System.Windows.Forms.Timer(this.components);
			this.fadeOutTimer = new System.Windows.Forms.Timer(this.components);
			this.progressTimer = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.LoadingUserAccountFormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).BeginInit();
			this.loadingPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// userImagePictureBox
			// 
			this.userImagePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.userImagePictureBox.BackColor = System.Drawing.Color.Transparent;
			this.userImagePictureBox.Image = global::Inventory.Properties.Resources.new_user_1080_Light_Gray;
			this.userImagePictureBox.Location = new System.Drawing.Point(51, 163);
			this.userImagePictureBox.Name = "userImagePictureBox";
			this.userImagePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.userImagePictureBox.ShadowDecoration.Parent = this.userImagePictureBox;
			this.userImagePictureBox.Size = new System.Drawing.Size(125, 125);
			this.userImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.userImagePictureBox.TabIndex = 0;
			this.userImagePictureBox.TabStop = false;
			this.userImagePictureBox.UseTransparentBackground = true;
			// 
			// welcomeMessageLabel
			// 
			this.welcomeMessageLabel.AutoSize = true;
			this.welcomeMessageLabel.BackColor = System.Drawing.Color.Transparent;
			this.welcomeMessageLabel.Font = new System.Drawing.Font("IRANSans Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.welcomeMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(10)))), ((int)(((byte)(59)))));
			this.welcomeMessageLabel.Location = new System.Drawing.Point(44, 19);
			this.welcomeMessageLabel.Name = "welcomeMessageLabel";
			this.welcomeMessageLabel.Size = new System.Drawing.Size(144, 50);
			this.welcomeMessageLabel.TabIndex = 1;
			this.welcomeMessageLabel.Text = "Welcom";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("IRANSans Medium", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(556, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(426, 63);
			this.label2.TabIndex = 2;
			this.label2.Text = "نرم افزار جامع انبار داری";
			// 
			// loadingPanel
			// 
			this.loadingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.loadingPanel.BorderRadius = 15;
			this.loadingPanel.Controls.Add(this.loadingMessageLabel);
			this.loadingPanel.Controls.Add(this.loadPercentLabel);
			this.loadingPanel.Controls.Add(this.loaderProgressBar);
			this.loadingPanel.Controls.Add(this.logoPictureBox);
			this.loadingPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.loadingPanel.Location = new System.Drawing.Point(362, 153);
			this.loadingPanel.Name = "loadingPanel";
			this.loadingPanel.ShadowDecoration.Parent = this.loadingPanel;
			this.loadingPanel.Size = new System.Drawing.Size(620, 330);
			this.loadingPanel.TabIndex = 3;
			// 
			// loadingMessageLabel
			// 
			this.loadingMessageLabel.AutoSize = true;
			this.loadingMessageLabel.BackColor = System.Drawing.Color.Transparent;
			this.loadingMessageLabel.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.loadingMessageLabel.ForeColor = System.Drawing.Color.White;
			this.loadingMessageLabel.Location = new System.Drawing.Point(337, 282);
			this.loadingMessageLabel.Name = "loadingMessageLabel";
			this.loadingMessageLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.loadingMessageLabel.Size = new System.Drawing.Size(272, 21);
			this.loadingMessageLabel.TabIndex = 3;
			this.loadingMessageLabel.Text = "در حال بارگزاری حساب کاربری لطفا منتظر بمانید...";
			this.loadingMessageLabel.Visible = false;
			// 
			// loadPercentLabel
			// 
			this.loadPercentLabel.AutoSize = true;
			this.loadPercentLabel.BackColor = System.Drawing.Color.Transparent;
			this.loadPercentLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadPercentLabel.ForeColor = System.Drawing.Color.White;
			this.loadPercentLabel.Location = new System.Drawing.Point(12, 287);
			this.loadPercentLabel.Name = "loadPercentLabel";
			this.loadPercentLabel.Size = new System.Drawing.Size(75, 16);
			this.loadPercentLabel.TabIndex = 2;
			this.loadPercentLabel.Text = "Loading 0%";
			this.loadPercentLabel.Visible = false;
			// 
			// loaderProgressBar
			// 
			this.loaderProgressBar.BackColor = System.Drawing.Color.Transparent;
			this.loaderProgressBar.BorderColor = System.Drawing.Color.Transparent;
			this.loaderProgressBar.BorderRadius = 5;
			this.loaderProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.loaderProgressBar.Location = new System.Drawing.Point(15, 306);
			this.loaderProgressBar.Name = "loaderProgressBar";
			this.loaderProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
			this.loaderProgressBar.ProgressColor2 = System.Drawing.Color.SpringGreen;
			this.loaderProgressBar.ShadowDecoration.Parent = this.loaderProgressBar;
			this.loaderProgressBar.Size = new System.Drawing.Size(590, 15);
			this.loaderProgressBar.TabIndex = 1;
			this.loaderProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.loaderProgressBar.UseTransparentBackground = true;
			this.loaderProgressBar.Visible = false;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(173, 16);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.ShadowDecoration.Parent = this.logoPictureBox;
			this.logoPictureBox.Size = new System.Drawing.Size(270, 200);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logoPictureBox.TabIndex = 0;
			this.logoPictureBox.TabStop = false;
			this.logoPictureBox.UseTransparentBackground = true;
			this.logoPictureBox.Visible = false;
			// 
			// fadeWelcomTitleTimer
			// 
			this.fadeWelcomTitleTimer.Interval = 10;
			this.fadeWelcomTitleTimer.Tick += new System.EventHandler(this.FadeWelcomTitleTimer_Tick);
			// 
			// messageBoxLabel
			// 
			this.messageBoxLabel.Font = new System.Drawing.Font("IRANSans", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.messageBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.messageBoxLabel.Location = new System.Drawing.Point(12, 395);
			this.messageBoxLabel.Name = "messageBoxLabel";
			this.messageBoxLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.messageBoxLabel.Size = new System.Drawing.Size(344, 96);
			this.messageBoxLabel.TabIndex = 4;
			this.messageBoxLabel.Text = "وقت بخیر";
			this.messageBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fadeMessageTitleTimer
			// 
			this.fadeMessageTitleTimer.Interval = 10;
			this.fadeMessageTitleTimer.Tick += new System.EventHandler(this.FadeMessageTitleTimer_Tick);
			// 
			// fadeLoadingPanelTimer
			// 
			this.fadeLoadingPanelTimer.Interval = 15;
			this.fadeLoadingPanelTimer.Tick += new System.EventHandler(this.FadeLoadingPanelTimer_Tick);
			// 
			// fadeInTimer
			// 
			this.fadeInTimer.Interval = 10;
			this.fadeInTimer.Tick += new System.EventHandler(this.FadeInTimer_Tick);
			// 
			// fadeOutTimer
			// 
			this.fadeOutTimer.Interval = 10;
			this.fadeOutTimer.Tick += new System.EventHandler(this.FadeOutTimer_Tick);
			// 
			// progressTimer
			// 
			this.progressTimer.Interval = 150;
			this.progressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Kunstler Script", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(186, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(364, 116);
			this.label1.TabIndex = 5;
			this.label1.Text = "Dr.Lent";
			// 
			// LoadingUserAccountFormElipse
			// 
			this.LoadingUserAccountFormElipse.BorderRadius = 25;
			this.LoadingUserAccountFormElipse.TargetControl = this;
			// 
			// LoadingUserAccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1000, 500);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.messageBoxLabel);
			this.Controls.Add(this.loadingPanel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.welcomeMessageLabel);
			this.Controls.Add(this.userImagePictureBox);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoadingUserAccountForm";
			this.Opacity = 0.95D;
			this.Text = "LoadingUserAccountForm";
			this.Load += new System.EventHandler(this.LoadingUserAccountForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).EndInit();
			this.loadingPanel.ResumeLayout(false);
			this.loadingPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2CirclePictureBox userImagePictureBox;
		private Mbb.Windows.Forms.Label welcomeMessageLabel;
		private Mbb.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2Panel loadingPanel;
		private Mbb.Windows.Forms.Label loadingMessageLabel;
		private Mbb.Windows.Forms.Label loadPercentLabel;
		private Guna.UI2.WinForms.Guna2ProgressBar loaderProgressBar;
		private Guna.UI2.WinForms.Guna2PictureBox logoPictureBox;
		private System.Windows.Forms.Timer fadeWelcomTitleTimer;
		private Mbb.Windows.Forms.Label messageBoxLabel;
		private System.Windows.Forms.Timer fadeMessageTitleTimer;
		private System.Windows.Forms.Timer fadeLoadingPanelTimer;
		private System.Windows.Forms.Timer fadeInTimer;
		private System.Windows.Forms.Timer fadeOutTimer;
		private System.Windows.Forms.Timer progressTimer;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2Elipse LoadingUserAccountFormElipse;
	}
}
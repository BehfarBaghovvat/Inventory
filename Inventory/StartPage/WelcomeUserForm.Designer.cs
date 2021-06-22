namespace StartPage
{
	partial class WelcomeUserForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeUserForm));
			this.loaderProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
			this.progressTimer = new System.Windows.Forms.Timer(this.components);
			this.WelcomeUserFormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.messageBoxLabel = new Mbb.Windows.Forms.Label();
			this.fadeInTimer = new System.Windows.Forms.Timer(this.components);
			this.fadeOutTimer = new System.Windows.Forms.Timer(this.components);
			this.picturBox1 = new Mbb.Windows.Forms.PicturBox();
			this.fadeInMessageBoxLabelTimer = new System.Windows.Forms.Timer(this.components);
			this.welcomeMessageLabel = new Mbb.Windows.Forms.Label();
			this.userImagePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.fadeInWelcomeMessageLabelTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// loaderProgressBar
			// 
			this.loaderProgressBar.AutoRoundedCorners = true;
			this.loaderProgressBar.BorderRadius = 9;
			this.loaderProgressBar.FillColor = System.Drawing.Color.DarkSlateBlue;
			this.loaderProgressBar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loaderProgressBar.ForeColor = System.Drawing.Color.White;
			this.loaderProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.loaderProgressBar.Location = new System.Drawing.Point(12, 445);
			this.loaderProgressBar.Name = "loaderProgressBar";
			this.loaderProgressBar.ProgressColor = System.Drawing.Color.Indigo;
			this.loaderProgressBar.ProgressColor2 = System.Drawing.Color.Aqua;
			this.loaderProgressBar.ShadowDecoration.Parent = this.loaderProgressBar;
			this.loaderProgressBar.ShowPercentage = true;
			this.loaderProgressBar.Size = new System.Drawing.Size(832, 20);
			this.loaderProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.loaderProgressBar.TabIndex = 4;
			this.loaderProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.loaderProgressBar.Value = 50;
			// 
			// progressTimer
			// 
			this.progressTimer.Interval = 50;
			this.progressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
			// 
			// WelcomeUserFormElipse
			// 
			this.WelcomeUserFormElipse.BorderRadius = 50;
			this.WelcomeUserFormElipse.TargetControl = this;
			// 
			// messageBoxLabel
			// 
			this.messageBoxLabel.Font = new System.Drawing.Font("IRANSans", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.messageBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(12)))), ((int)(((byte)(64)))));
			this.messageBoxLabel.Location = new System.Drawing.Point(12, 221);
			this.messageBoxLabel.Name = "messageBoxLabel";
			this.messageBoxLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.messageBoxLabel.Size = new System.Drawing.Size(832, 71);
			this.messageBoxLabel.TabIndex = 5;
			this.messageBoxLabel.Text = "روز بخیر ...";
			this.messageBoxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
			// picturBox1
			// 
			this.picturBox1.Image = ((System.Drawing.Image)(resources.GetObject("picturBox1.Image")));
			this.picturBox1.Location = new System.Drawing.Point(-19, 362);
			this.picturBox1.Name = "picturBox1";
			this.picturBox1.Size = new System.Drawing.Size(145, 100);
			this.picturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picturBox1.TabIndex = 6;
			this.picturBox1.TabStop = false;
			// 
			// fadeInMessageBoxLabelTimer
			// 
			this.fadeInMessageBoxLabelTimer.Interval = 10;
			this.fadeInMessageBoxLabelTimer.Tick += new System.EventHandler(this.FadeInMessageBoxLabelTimer_Tick);
			// 
			// welcomeMessageLabel
			// 
			this.welcomeMessageLabel.Font = new System.Drawing.Font("IRANSans", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.welcomeMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(12)))), ((int)(((byte)(64)))));
			this.welcomeMessageLabel.Location = new System.Drawing.Point(12, 302);
			this.welcomeMessageLabel.Name = "welcomeMessageLabel";
			this.welcomeMessageLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.welcomeMessageLabel.Size = new System.Drawing.Size(832, 71);
			this.welcomeMessageLabel.TabIndex = 7;
			this.welcomeMessageLabel.Text = "خوش آمدید";
			this.welcomeMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// userImagePictureBox
			// 
			this.userImagePictureBox.Image = global::Inventory.Properties.Resources.new_user_1080_Light_Gray;
			this.userImagePictureBox.Location = new System.Drawing.Point(328, 15);
			this.userImagePictureBox.Name = "userImagePictureBox";
			this.userImagePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.userImagePictureBox.ShadowDecoration.Parent = this.userImagePictureBox;
			this.userImagePictureBox.Size = new System.Drawing.Size(200, 200);
			this.userImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.userImagePictureBox.TabIndex = 8;
			this.userImagePictureBox.TabStop = false;
			// 
			// fadeInWelcomeMessageLabelTimer
			// 
			this.fadeInWelcomeMessageLabelTimer.Interval = 10;
			this.fadeInWelcomeMessageLabelTimer.Tick += new System.EventHandler(this.FadeInWelcomeMessageLabelTimer_Tick);
			// 
			// WelcomeUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(12)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(856, 477);
			this.Controls.Add(this.userImagePictureBox);
			this.Controls.Add(this.loaderProgressBar);
			this.Controls.Add(this.messageBoxLabel);
			this.Controls.Add(this.picturBox1);
			this.Controls.Add(this.welcomeMessageLabel);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "WelcomeUserForm";
			this.Opacity = 0.9D;
			this.Text = "WelcomeUserForm";
			this.Load += new System.EventHandler(this.WelcomeUserForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Guna.UI2.WinForms.Guna2ProgressBar loaderProgressBar;
		private System.Windows.Forms.Timer progressTimer;
		private Guna.UI2.WinForms.Guna2Elipse WelcomeUserFormElipse;
		private Mbb.Windows.Forms.Label messageBoxLabel;
		private System.Windows.Forms.Timer fadeInTimer;
		private System.Windows.Forms.Timer fadeOutTimer;
		private Mbb.Windows.Forms.PicturBox picturBox1;
		private System.Windows.Forms.Timer fadeInMessageBoxLabelTimer;
		private Mbb.Windows.Forms.Label welcomeMessageLabel;
		private Guna.UI2.WinForms.Guna2CirclePictureBox userImagePictureBox;
		private System.Windows.Forms.Timer fadeInWelcomeMessageLabelTimer;
	}
}
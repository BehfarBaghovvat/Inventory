namespace Infrastructure
{
	partial class PopupNotificationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupNotificationForm));
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.messageLabel = new Mbb.Windows.Forms.Label();
			this.captionLabel = new Mbb.Windows.Forms.Label();
			this.cancelButton = new Mbb.Windows.Forms.Button();
			this.objectPictureBox = new Mbb.Windows.Forms.PicturBox();
			this.notificationStatusPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.PopupNotificationFormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			((System.ComponentModel.ISupportInitialize)(this.objectPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.notificationStatusPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// messageLabel
			// 
			this.messageLabel.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.messageLabel.ForeColor = System.Drawing.Color.White;
			this.messageLabel.Location = new System.Drawing.Point(57, 14);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(290, 56);
			this.messageLabel.TabIndex = 23;
			this.messageLabel.Text = "پیغام";
			this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// captionLabel
			// 
			this.captionLabel.Font = new System.Drawing.Font("IRANSans", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.captionLabel.ForeColor = System.Drawing.Color.White;
			this.captionLabel.Location = new System.Drawing.Point(11, -3);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(103, 18);
			this.captionLabel.TabIndex = 26;
			this.captionLabel.Text = "عنوان";
			this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.Transparent;
			this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
			this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Location = new System.Drawing.Point(401, 29);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(43, 27);
			this.cancelButton.TabIndex = 25;
			this.cancelButton.UseVisualStyleBackColor = false;
			// 
			// objectPictureBox
			// 
			this.objectPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.objectPictureBox.Location = new System.Drawing.Point(353, 20);
			this.objectPictureBox.Name = "objectPictureBox";
			this.objectPictureBox.Size = new System.Drawing.Size(43, 45);
			this.objectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.objectPictureBox.TabIndex = 24;
			this.objectPictureBox.TabStop = false;
			// 
			// notificationStatusPicturBox
			// 
			this.notificationStatusPicturBox.BackColor = System.Drawing.Color.Transparent;
			this.notificationStatusPicturBox.Image = global::Inventory.Properties.Resources.succes_512;
			this.notificationStatusPicturBox.Location = new System.Drawing.Point(9, 20);
			this.notificationStatusPicturBox.Name = "notificationStatusPicturBox";
			this.notificationStatusPicturBox.Size = new System.Drawing.Size(43, 45);
			this.notificationStatusPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.notificationStatusPicturBox.TabIndex = 22;
			this.notificationStatusPicturBox.TabStop = false;
			// 
			// PopupNotificationFormElipse
			// 
			this.PopupNotificationFormElipse.BorderRadius = 25;
			this.PopupNotificationFormElipse.TargetControl = this;
			// 
			// PopupNotificationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(450, 85);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.objectPictureBox);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.notificationStatusPicturBox);
			this.Controls.Add(this.captionLabel);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "PopupNotificationForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "PopupNotificationForm";
			((System.ComponentModel.ISupportInitialize)(this.objectPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.notificationStatusPicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Mbb.Windows.Forms.Button cancelButton;
		private Mbb.Windows.Forms.PicturBox objectPictureBox;
		private Mbb.Windows.Forms.Label messageLabel;
		private Mbb.Windows.Forms.PicturBox notificationStatusPicturBox;
		private Mbb.Windows.Forms.Label captionLabel;
		private System.Windows.Forms.Timer timer;
		private Guna.UI2.WinForms.Guna2Elipse PopupNotificationFormElipse;
	}
}

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
			this.PopupNotificationFormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.closeButton = new Guna.UI2.WinForms.Guna2CircleButton();
			this.captionLabel = new Mbb.Windows.Forms.Label();
			this.notificationStatusPicturBox = new System.Windows.Forms.PictureBox();
			this.messageLabel = new System.Windows.Forms.Label();
			this.objectPictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.notificationStatusPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.objectPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// PopupNotificationFormElipse
			// 
			this.PopupNotificationFormElipse.BorderRadius = 15;
			this.PopupNotificationFormElipse.TargetControl = this;
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.Transparent;
			this.closeButton.CheckedState.Parent = this.closeButton;
			this.closeButton.CustomImages.Parent = this.closeButton;
			this.closeButton.FillColor = System.Drawing.Color.Transparent;
			this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.HoverState.Parent = this.closeButton;
			this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
			this.closeButton.ImageOffset = new System.Drawing.Point(1, 0);
			this.closeButton.ImageSize = new System.Drawing.Size(30, 30);
			this.closeButton.Location = new System.Drawing.Point(408, 27);
			this.closeButton.Name = "closeButton";
			this.closeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.closeButton.ShadowDecoration.Parent = this.closeButton;
			this.closeButton.Size = new System.Drawing.Size(30, 30);
			this.closeButton.TabIndex = 0;
			this.closeButton.UseTransparentBackground = true;
			// 
			// captionLabel
			// 
			this.captionLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.captionLabel.Font = new System.Drawing.Font("IRANSans", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.captionLabel.ForeColor = System.Drawing.Color.White;
			this.captionLabel.Location = new System.Drawing.Point(0, 0);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.captionLabel.Size = new System.Drawing.Size(450, 15);
			this.captionLabel.TabIndex = 1;
			this.captionLabel.Text = "عنوان";
			// 
			// notificationStatusPicturBox
			// 
			this.notificationStatusPicturBox.Image = global::Inventory.Properties.Resources.succes_512;
			this.notificationStatusPicturBox.Location = new System.Drawing.Point(5, 20);
			this.notificationStatusPicturBox.Name = "notificationStatusPicturBox";
			this.notificationStatusPicturBox.Size = new System.Drawing.Size(45, 45);
			this.notificationStatusPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.notificationStatusPicturBox.TabIndex = 2;
			this.notificationStatusPicturBox.TabStop = false;
			// 
			// messageLabel
			// 
			this.messageLabel.ForeColor = System.Drawing.Color.White;
			this.messageLabel.Location = new System.Drawing.Point(56, 20);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(288, 45);
			this.messageLabel.TabIndex = 3;
			this.messageLabel.Text = "پیغام";
			this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// objectPictureBox
			// 
			this.objectPictureBox.Location = new System.Drawing.Point(350, 20);
			this.objectPictureBox.Name = "objectPictureBox";
			this.objectPictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.objectPictureBox.ShadowDecoration.Parent = this.objectPictureBox;
			this.objectPictureBox.Size = new System.Drawing.Size(45, 45);
			this.objectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.objectPictureBox.TabIndex = 4;
			this.objectPictureBox.TabStop = false;
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// PopupNotificationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(450, 85);
			this.Controls.Add(this.objectPictureBox);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.notificationStatusPicturBox);
			this.Controls.Add(this.captionLabel);
			this.Controls.Add(this.closeButton);
			this.Name = "PopupNotificationForm";
			this.Opacity = 0.9D;
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.Text = "PopupNotificationForm";
			((System.ComponentModel.ISupportInitialize)(this.notificationStatusPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.objectPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse PopupNotificationFormElipse;
		private Guna.UI2.WinForms.Guna2CircleButton closeButton;
		private Guna.UI2.WinForms.Guna2CirclePictureBox objectPictureBox;
		private System.Windows.Forms.Label messageLabel;
		private System.Windows.Forms.PictureBox notificationStatusPicturBox;
		private Mbb.Windows.Forms.Label captionLabel;
		private System.Windows.Forms.Timer timer;
	}
}
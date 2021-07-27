
namespace Mbb.Windows.Forms
{
	partial class PopupNotificationWindows
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
			this.messageLabel = new System.Windows.Forms.Label();
			this.closeButton = new Guna.UI2.WinForms.Guna2CircleButton();
			this.objectPictureBox = new Mbb.Windows.Forms.CircularPictureBox();
			this.notificationStatusPicturBox = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.fadeTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.objectPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.notificationStatusPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// messageLabel
			// 
			this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageLabel.ForeColor = System.Drawing.Color.White;
			this.messageLabel.Location = new System.Drawing.Point(88, 10);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(310, 35);
			this.messageLabel.TabIndex = 8;
			this.messageLabel.Text = "پیغام";
			this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.messageLabel.UseCompatibleTextRendering = true;
			// 
			// closeButton
			// 
			this.closeButton.Animated = true;
			this.closeButton.CheckedState.Parent = this.closeButton;
			this.closeButton.CustomImages.Parent = this.closeButton;
			this.closeButton.FillColor = System.Drawing.Color.Transparent;
			this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.HoverState.FillColor = System.Drawing.Color.White;
			this.closeButton.HoverState.Image = global::Mbb.Properties.Resources.cancel_512_black;
			this.closeButton.HoverState.Parent = this.closeButton;
			this.closeButton.Image = global::Mbb.Properties.Resources.cancel_512;
			this.closeButton.ImageOffset = new System.Drawing.Point(1, 1);
			this.closeButton.ImageSize = new System.Drawing.Size(25, 25);
			this.closeButton.Location = new System.Drawing.Point(6, 12);
			this.closeButton.Name = "closeButton";
			this.closeButton.PressedColor = System.Drawing.Color.White;
			this.closeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.closeButton.ShadowDecoration.Parent = this.closeButton;
			this.closeButton.Size = new System.Drawing.Size(30, 30);
			this.closeButton.TabIndex = 12;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// objectPictureBox
			// 
			this.objectPictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
			this.objectPictureBox.BorderColor1 = System.Drawing.Color.Lime;
			this.objectPictureBox.BorderColor2 = System.Drawing.Color.White;
			this.objectPictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.objectPictureBox.BordrSize = 0;
			this.objectPictureBox.GradiantAngle = 50F;
			this.objectPictureBox.Location = new System.Drawing.Point(42, 7);
			this.objectPictureBox.Name = "objectPictureBox";
			this.objectPictureBox.Size = new System.Drawing.Size(40, 40);
			this.objectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.objectPictureBox.TabIndex = 11;
			this.objectPictureBox.TabStop = false;
			// 
			// notificationStatusPicturBox
			// 
			this.notificationStatusPicturBox.Image = global::Mbb.Properties.Resources.succes_512;
			this.notificationStatusPicturBox.Location = new System.Drawing.Point(404, 10);
			this.notificationStatusPicturBox.Name = "notificationStatusPicturBox";
			this.notificationStatusPicturBox.ShadowDecoration.Parent = this.notificationStatusPicturBox;
			this.notificationStatusPicturBox.Size = new System.Drawing.Size(40, 35);
			this.notificationStatusPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.notificationStatusPicturBox.TabIndex = 13;
			this.notificationStatusPicturBox.TabStop = false;
			// 
			// fadeTimer
			// 
			this.fadeTimer.Tick += new System.EventHandler(this.FadeTimer_Tick);
			// 
			// PopupNotificationWindows
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaGreen;
			this.ClientSize = new System.Drawing.Size(450, 55);
			this.Controls.Add(this.notificationStatusPicturBox);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.objectPictureBox);
			this.Controls.Add(this.messageLabel);
			this.Font = new System.Drawing.Font("IRANSansX", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.MaximumSize = new System.Drawing.Size(450, 55);
			this.MinimumSize = new System.Drawing.Size(450, 55);
			this.Name = "PopupNotificationWindows";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = false;
			this.Text = "PopupNotificationWindows";
			((System.ComponentModel.ISupportInitialize)(this.objectPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.notificationStatusPicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label messageLabel;
		private CircularPictureBox objectPictureBox;
		private Guna.UI2.WinForms.Guna2CircleButton closeButton;
		private Guna.UI2.WinForms.Guna2PictureBox notificationStatusPicturBox;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
		private System.Windows.Forms.Timer fadeTimer;
	}
}
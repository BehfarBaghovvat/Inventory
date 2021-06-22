namespace Mbb.Windows.Forms
{
	partial class MessageBoxSoBForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxSoBForm));
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.captionLabel = new Mbb.Windows.Forms.Label();
			this.button1 = new Mbb.Windows.Forms.Button();
			this.messageLabel = new Mbb.Windows.Forms.Label();
			this.iconNotificationPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.cancelButton = new Mbb.Windows.Forms.Button();
			this.noButton = new Mbb.Windows.Forms.Button();
			this.yesButton = new Mbb.Windows.Forms.Button();
			this.titlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconNotificationPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.button1);
			this.titlePanel.Controls.Add(this.captionLabel);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(400, 35);
			this.titlePanel.TabIndex = 11;
			// 
			// captionLabel
			// 
			this.captionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.captionLabel.AutoSize = true;
			this.captionLabel.ForeColor = System.Drawing.Color.White;
			this.captionLabel.Location = new System.Drawing.Point(347, 9);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(33, 19);
			this.captionLabel.TabIndex = 0;
			this.captionLabel.Text = "عنوان";
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(12, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(15, 15);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// messageLabel
			// 
			this.messageLabel.AutoEllipsis = true;
			this.messageLabel.AutoSize = true;
			this.messageLabel.Font = new System.Drawing.Font("IRANSans", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.messageLabel.ForeColor = System.Drawing.Color.White;
			this.messageLabel.Location = new System.Drawing.Point(40, 50);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(29, 17);
			this.messageLabel.TabIndex = 15;
			this.messageLabel.Text = "پیغام";
			// 
			// iconNotificationPicturBox
			// 
			this.iconNotificationPicturBox.Location = new System.Drawing.Point(338, 41);
			this.iconNotificationPicturBox.Name = "iconNotificationPicturBox";
			this.iconNotificationPicturBox.Size = new System.Drawing.Size(50, 50);
			this.iconNotificationPicturBox.TabIndex = 16;
			this.iconNotificationPicturBox.TabStop = false;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cancelButton.BackColor = System.Drawing.Color.MediumBlue;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Retry;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.cancelButton.ForeColor = System.Drawing.Color.White;
			this.cancelButton.Location = new System.Drawing.Point(60, 135);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(90, 25);
			this.cancelButton.TabIndex = 19;
			this.cancelButton.Text = "تلاش مجدد";
			this.cancelButton.UseVisualStyleBackColor = false;
			// 
			// noButton
			// 
			this.noButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.noButton.BackColor = System.Drawing.Color.MediumBlue;
			this.noButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
			this.noButton.FlatAppearance.BorderSize = 0;
			this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.noButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.noButton.ForeColor = System.Drawing.Color.White;
			this.noButton.Location = new System.Drawing.Point(155, 135);
			this.noButton.Name = "noButton";
			this.noButton.Size = new System.Drawing.Size(90, 25);
			this.noButton.TabIndex = 18;
			this.noButton.Text = "قطع کردن";
			this.noButton.UseVisualStyleBackColor = false;
			// 
			// yesButton
			// 
			this.yesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.yesButton.BackColor = System.Drawing.Color.MediumBlue;
			this.yesButton.DialogResult = System.Windows.Forms.DialogResult.Ignore;
			this.yesButton.FlatAppearance.BorderSize = 0;
			this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.yesButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.yesButton.ForeColor = System.Drawing.Color.White;
			this.yesButton.Location = new System.Drawing.Point(251, 135);
			this.yesButton.Name = "yesButton";
			this.yesButton.Size = new System.Drawing.Size(90, 25);
			this.yesButton.TabIndex = 17;
			this.yesButton.Text = "چشم پوشی";
			this.yesButton.UseVisualStyleBackColor = false;
			// 
			// MessageBoxSoBForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Blue;
			this.ClientSize = new System.Drawing.Size(400, 175);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.noButton);
			this.Controls.Add(this.yesButton);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.iconNotificationPicturBox);
			this.Controls.Add(this.titlePanel);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "MessageBoxSoBForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "MessageBoxSoBForm";
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconNotificationPicturBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel titlePanel;
		private Button button1;
		private Label captionLabel;
		private Label messageLabel;
		private PicturBox iconNotificationPicturBox;
		private Button cancelButton;
		private Button noButton;
		private Button yesButton;
	}
}
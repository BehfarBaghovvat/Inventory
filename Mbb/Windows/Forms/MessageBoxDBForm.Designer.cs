namespace Mbb.Windows.Forms
{
	partial class MessageBoxDBForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxDBForm));
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.captionLabel = new Mbb.Windows.Forms.Label();
			this.messageLabel = new Mbb.Windows.Forms.Label();
			this.iconNotificationPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.cleseButton = new Mbb.Windows.Forms.Button();
			this.okButton = new Mbb.Windows.Forms.Button();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.titlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconNotificationPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// titlePanel
			// 
			this.titlePanel.Controls.Add(this.cleseButton);
			this.titlePanel.Controls.Add(this.captionLabel);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(400, 35);
			this.titlePanel.TabIndex = 0;
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
			// messageLabel
			// 
			this.messageLabel.AutoEllipsis = true;
			this.messageLabel.AutoSize = true;
			this.messageLabel.Font = new System.Drawing.Font("IRANSans", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.messageLabel.ForeColor = System.Drawing.Color.White;
			this.messageLabel.Location = new System.Drawing.Point(40, 50);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(29, 17);
			this.messageLabel.TabIndex = 3;
			this.messageLabel.Text = "پیغام";
			// 
			// iconNotificationPicturBox
			// 
			this.iconNotificationPicturBox.Location = new System.Drawing.Point(338, 41);
			this.iconNotificationPicturBox.Name = "iconNotificationPicturBox";
			this.iconNotificationPicturBox.Size = new System.Drawing.Size(50, 50);
			this.iconNotificationPicturBox.TabIndex = 4;
			this.iconNotificationPicturBox.TabStop = false;
			// 
			// cleseButton
			// 
			this.cleseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cleseButton.BackgroundImage")));
			this.cleseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cleseButton.FlatAppearance.BorderSize = 0;
			this.cleseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cleseButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.cleseButton.ForeColor = System.Drawing.Color.White;
			this.cleseButton.Location = new System.Drawing.Point(12, 10);
			this.cleseButton.Name = "cleseButton";
			this.cleseButton.Size = new System.Drawing.Size(15, 15);
			this.cleseButton.TabIndex = 1;
			this.cleseButton.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.Color.MediumBlue;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.ForeColor = System.Drawing.Color.White;
			this.okButton.Location = new System.Drawing.Point(155, 135);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(90, 25);
			this.okButton.TabIndex = 5;
			this.okButton.Text = "باشه";
			this.okButton.UseVisualStyleBackColor = false;
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 20;
			this.bunifuElipse1.TargetControl = this;
			// 
			// MessageBoxDBForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Blue;
			this.ClientSize = new System.Drawing.Size(400, 175);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.iconNotificationPicturBox);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.titlePanel);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "MessageBoxDBForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "MessageBoxForm";
			this.titlePanel.ResumeLayout(false);
			this.titlePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconNotificationPicturBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel titlePanel;
		private Button cleseButton;
		private Label captionLabel;
		private Label messageLabel;
		private PicturBox iconNotificationPicturBox;
		private Button okButton;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
	}
}
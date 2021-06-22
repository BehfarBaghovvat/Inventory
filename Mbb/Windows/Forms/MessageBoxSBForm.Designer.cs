namespace Mbb.Windows.Forms
{
	partial class MessageBoxSBForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxSBForm));
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.captionLabel = new Mbb.Windows.Forms.Label();
			this.messageLabel = new Mbb.Windows.Forms.Label();
			this.noButton = new Mbb.Windows.Forms.Button();
			this.yesButton = new Mbb.Windows.Forms.Button();
			this.button1 = new Mbb.Windows.Forms.Button();
			this.iconNotificationPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
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
			this.titlePanel.TabIndex = 5;
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
			this.messageLabel.TabIndex = 8;
			this.messageLabel.Text = "پیغام";
			// 
			// noButton
			// 
			this.noButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.noButton.BackColor = System.Drawing.Color.MediumBlue;
			this.noButton.DialogResult = System.Windows.Forms.DialogResult.No;
			this.noButton.FlatAppearance.BorderSize = 0;
			this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.noButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.noButton.ForeColor = System.Drawing.Color.White;
			this.noButton.Location = new System.Drawing.Point(107, 135);
			this.noButton.Name = "noButton";
			this.noButton.Size = new System.Drawing.Size(90, 25);
			this.noButton.TabIndex = 7;
			this.noButton.Text = "خیر";
			this.noButton.UseVisualStyleBackColor = false;
			// 
			// yesButton
			// 
			this.yesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.yesButton.BackColor = System.Drawing.Color.MediumBlue;
			this.yesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.yesButton.FlatAppearance.BorderSize = 0;
			this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.yesButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.yesButton.ForeColor = System.Drawing.Color.White;
			this.yesButton.Location = new System.Drawing.Point(203, 135);
			this.yesButton.Name = "yesButton";
			this.yesButton.Size = new System.Drawing.Size(90, 25);
			this.yesButton.TabIndex = 6;
			this.yesButton.Text = "بله";
			this.yesButton.UseVisualStyleBackColor = false;
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
			// iconNotificationPicturBox
			// 
			this.iconNotificationPicturBox.Location = new System.Drawing.Point(338, 41);
			this.iconNotificationPicturBox.Name = "iconNotificationPicturBox";
			this.iconNotificationPicturBox.Size = new System.Drawing.Size(50, 50);
			this.iconNotificationPicturBox.TabIndex = 9;
			this.iconNotificationPicturBox.TabStop = false;
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 20;
			this.bunifuElipse1.TargetControl = this;
			// 
			// MessageBoxSBForm
			// 
			this.AcceptButton = this.yesButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Blue;
			this.CancelButton = this.noButton;
			this.ClientSize = new System.Drawing.Size(400, 175);
			this.Controls.Add(this.titlePanel);
			this.Controls.Add(this.iconNotificationPicturBox);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.noButton);
			this.Controls.Add(this.yesButton);
			this.Name = "MessageBoxSBForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "MessageBoxSBForm";
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
		private PicturBox iconNotificationPicturBox;
		private Label messageLabel;
		private Button noButton;
		private Button yesButton;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
	}
}
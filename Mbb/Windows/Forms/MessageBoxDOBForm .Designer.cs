namespace Mbb.Windows.Forms
{
	partial class MessageBoxDOBForm
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
			this.messageLabel = new Mbb.Windows.Forms.Label();
			this.messageBoxDOBFormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.iconPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.yesButtonElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.yesButton = new Mbb.Windows.Forms.Button();
			this.noButton = new Mbb.Windows.Forms.Button();
			this.noButtonElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.captionLabel = new Mbb.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.iconPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// messageLabel
			// 
			this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.messageLabel.AutoEllipsis = true;
			this.messageLabel.Font = new System.Drawing.Font("IRANSans Light", 12F);
			this.messageLabel.ForeColor = System.Drawing.Color.White;
			this.messageLabel.Location = new System.Drawing.Point(12, 37);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(370, 56);
			this.messageLabel.TabIndex = 8;
			this.messageLabel.Text = "پیغام";
			// 
			// messageBoxDOBFormElipse
			// 
			this.messageBoxDOBFormElipse.BorderRadius = 20;
			this.messageBoxDOBFormElipse.TargetControl = this;
			// 
			// iconPicturBox
			// 
			this.iconPicturBox.Location = new System.Drawing.Point(388, 42);
			this.iconPicturBox.Name = "iconPicturBox";
			this.iconPicturBox.Size = new System.Drawing.Size(50, 50);
			this.iconPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.iconPicturBox.TabIndex = 11;
			this.iconPicturBox.TabStop = false;
			// 
			// yesButtonElipse
			// 
			this.yesButtonElipse.BorderRadius = 14;
			this.yesButtonElipse.TargetControl = this.yesButton;
			// 
			// yesButton
			// 
			this.yesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.yesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.yesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.yesButton.FlatAppearance.BorderSize = 0;
			this.yesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.yesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.yesButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.yesButton.ForeColor = System.Drawing.Color.White;
			this.yesButton.Location = new System.Drawing.Point(102, 99);
			this.yesButton.Name = "yesButton";
			this.yesButton.Size = new System.Drawing.Size(120, 30);
			this.yesButton.TabIndex = 14;
			this.yesButton.Text = "بله";
			this.yesButton.UseVisualStyleBackColor = false;
			// 
			// noButton
			// 
			this.noButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.noButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.noButton.DialogResult = System.Windows.Forms.DialogResult.No;
			this.noButton.FlatAppearance.BorderSize = 0;
			this.noButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.noButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.noButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.noButton.ForeColor = System.Drawing.Color.White;
			this.noButton.Location = new System.Drawing.Point(228, 99);
			this.noButton.Name = "noButton";
			this.noButton.Size = new System.Drawing.Size(120, 30);
			this.noButton.TabIndex = 13;
			this.noButton.Text = "خیر";
			this.noButton.UseVisualStyleBackColor = false;
			// 
			// noButtonElipse
			// 
			this.noButtonElipse.BorderRadius = 14;
			this.noButtonElipse.TargetControl = this.noButton;
			// 
			// captionLabel
			// 
			this.captionLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.captionLabel.Font = new System.Drawing.Font("IRANSans Light", 7F);
			this.captionLabel.ForeColor = System.Drawing.Color.White;
			this.captionLabel.Location = new System.Drawing.Point(0, 0);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(450, 25);
			this.captionLabel.TabIndex = 15;
			this.captionLabel.Text = "عنوان";
			this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MessageBoxDOBForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(450, 135);
			this.Controls.Add(this.yesButton);
			this.Controls.Add(this.noButton);
			this.Controls.Add(this.captionLabel);
			this.Controls.Add(this.iconPicturBox);
			this.Controls.Add(this.messageLabel);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(450, 135);
			this.Name = "MessageBoxDOBForm";
			this.Opacity = 0.9D;
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "MessageBoxSIBForm";
			this.Load += new System.EventHandler(this.MessageBoxDOBForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.iconPicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Label messageLabel;
		private Guna.UI2.WinForms.Guna2Elipse messageBoxDOBFormElipse;
		private PicturBox iconPicturBox;
		private Guna.UI2.WinForms.Guna2Elipse yesButtonElipse;
		private Button yesButton;
		private Button noButton;
		private Guna.UI2.WinForms.Guna2Elipse noButtonElipse;
		private Label captionLabel;
	}
}
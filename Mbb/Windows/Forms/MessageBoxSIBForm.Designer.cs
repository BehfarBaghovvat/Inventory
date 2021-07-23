namespace Mbb.Windows.Forms
{
	partial class MessageBoxSIBForm
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
			this.messageBoxSIBFormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.iconPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.okButton = new Mbb.Windows.Forms.Button();
			this.okButtonElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.captionLabel = new Mbb.Windows.Forms.Label();
			this.closeFormTimer = new System.Windows.Forms.Timer(this.components);
			this.showFormAnimateWindow = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
			this.showFaideTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.iconPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// messageLabel
			// 
			this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.messageLabel.AutoEllipsis = true;
			this.messageLabel.Font = new System.Drawing.Font("IRANSans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.messageLabel.ForeColor = System.Drawing.Color.White;
			this.messageLabel.Location = new System.Drawing.Point(12, 36);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(370, 56);
			this.messageLabel.TabIndex = 7;
			this.messageLabel.Text = "پیغام";
			// 
			// messageBoxSIBFormElipse
			// 
			this.messageBoxSIBFormElipse.BorderRadius = 20;
			this.messageBoxSIBFormElipse.TargetControl = this;
			// 
			// iconPicturBox
			// 
			this.iconPicturBox.Location = new System.Drawing.Point(388, 39);
			this.iconPicturBox.Name = "iconPicturBox";
			this.iconPicturBox.Size = new System.Drawing.Size(50, 50);
			this.iconPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.iconPicturBox.TabIndex = 13;
			this.iconPicturBox.TabStop = false;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.FlatAppearance.BorderSize = 0;
			this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.okButton.ForeColor = System.Drawing.Color.White;
			this.okButton.Location = new System.Drawing.Point(165, 100);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(120, 30);
			this.okButton.TabIndex = 14;
			this.okButton.Text = "بسیار خب";
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// okButtonElipse
			// 
			this.okButtonElipse.BorderRadius = 5;
			this.okButtonElipse.TargetControl = this.okButton;
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
			// closeFormTimer
			// 
			this.closeFormTimer.Interval = 5;
			this.closeFormTimer.Tick += new System.EventHandler(this.CloseFormTimer_Tick);
			// 
			// showFormAnimateWindow
			// 
			this.showFormAnimateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
			this.showFormAnimateWindow.Interval = 200;
			this.showFormAnimateWindow.TargetControl = null;
			// 
			// showFaideTimer
			// 
			this.showFaideTimer.Tick += new System.EventHandler(this.ShowFaideTimer_Tick);
			// 
			// MessageBoxSIBForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(450, 135);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.captionLabel);
			this.Controls.Add(this.iconPicturBox);
			this.Controls.Add(this.messageLabel);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.MinimumSize = new System.Drawing.Size(450, 135);
			this.Name = "MessageBoxSIBForm";
			this.Opacity = 0.9D;
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "MessageBoxSIBForm";
			this.Load += new System.EventHandler(this.MessageBoxSIBForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.iconPicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Label messageLabel;
		private Guna.UI2.WinForms.Guna2Elipse messageBoxSIBFormElipse;
		private PicturBox iconPicturBox;
		private Button okButton;
		private Guna.UI2.WinForms.Guna2Elipse okButtonElipse;
		private Label captionLabel;
		private System.Windows.Forms.Timer closeFormTimer;
		private Guna.UI.WinForms.GunaAnimateWindow showFormAnimateWindow;
		private System.Windows.Forms.Timer showFaideTimer;
	}
}
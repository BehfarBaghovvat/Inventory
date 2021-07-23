
namespace Mbb.Windows.Forms
{
	partial class TextBox
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.iconLeftBox = new System.Windows.Forms.PictureBox();
			this.iconRightBox = new System.Windows.Forms.PictureBox();
			this.offsetLeft = new Mbb.Windows.Forms.Panel();
			this.offsetRight = new Mbb.Windows.Forms.Panel();
			this.captionLabel = new System.Windows.Forms.Label();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.iconLeftBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconRightBox)).BeginInit();
			this.SuspendLayout();
			// 
			// iconLeftBox
			// 
			this.iconLeftBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.iconLeftBox.Location = new System.Drawing.Point(10, 10);
			this.iconLeftBox.Name = "iconLeftBox";
			this.iconLeftBox.Size = new System.Drawing.Size(15, 15);
			this.iconLeftBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.iconLeftBox.TabIndex = 2;
			this.iconLeftBox.TabStop = false;
			this.iconLeftBox.Visible = false;
			this.iconLeftBox.Click += new System.EventHandler(this.IconLeftBox_Click);
			this.iconLeftBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconLeftBox_MouseDown);
			this.iconLeftBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IconLeftBox_MouseUp);
			// 
			// iconRightBox
			// 
			this.iconRightBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.iconRightBox.Location = new System.Drawing.Point(275, 10);
			this.iconRightBox.Name = "iconRightBox";
			this.iconRightBox.Size = new System.Drawing.Size(15, 15);
			this.iconRightBox.TabIndex = 3;
			this.iconRightBox.TabStop = false;
			this.iconRightBox.Click += new System.EventHandler(this.IconRightBox_Click);
			this.iconRightBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconRightBox_MouseDown);
			this.iconRightBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IconRightBox_MouseUp);
			// 
			// offsetLeft
			// 
			this.offsetLeft.BackColor = System.Drawing.Color.Transparent;
			this.offsetLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.offsetLeft.Location = new System.Drawing.Point(25, 10);
			this.offsetLeft.Name = "offsetLeft";
			this.offsetLeft.Size = new System.Drawing.Size(3, 15);
			this.offsetLeft.TabIndex = 4;
			// 
			// offsetRight
			// 
			this.offsetRight.BackColor = System.Drawing.Color.Transparent;
			this.offsetRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.offsetRight.Location = new System.Drawing.Point(272, 10);
			this.offsetRight.Name = "offsetRight";
			this.offsetRight.Size = new System.Drawing.Size(3, 15);
			this.offsetRight.TabIndex = 5;
			// 
			// captionLabel
			// 
			this.captionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.captionLabel.Location = new System.Drawing.Point(28, 10);
			this.captionLabel.Margin = new System.Windows.Forms.Padding(3);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(244, 15);
			this.captionLabel.TabIndex = 8;
			// 
			// inputTextBox
			// 
			this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputTextBox.Location = new System.Drawing.Point(28, 10);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(244, 15);
			this.inputTextBox.TabIndex = 7;
			// 
			// TextBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.captionLabel);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.offsetRight);
			this.Controls.Add(this.offsetLeft);
			this.Controls.Add(this.iconLeftBox);
			this.Controls.Add(this.iconRightBox);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ForeColor = System.Drawing.Color.DimGray;
			this.Name = "TextBox";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(300, 35);
			this.Load += new System.EventHandler(this.TextBox_Load);
			this.Enter += new System.EventHandler(this.TextBox_Enter);
			this.Leave += new System.EventHandler(this.TextBox_Leave);
			this.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
			((System.ComponentModel.ISupportInitialize)(this.iconLeftBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconRightBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox iconLeftBox;
		private System.Windows.Forms.PictureBox iconRightBox;
		private Panel offsetLeft;
		private Panel offsetRight;
		private System.Windows.Forms.Label captionLabel;
		private System.Windows.Forms.TextBox inputTextBox;
	}
}

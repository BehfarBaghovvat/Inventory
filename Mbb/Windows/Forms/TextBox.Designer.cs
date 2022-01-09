
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
			this.iconLeft = new System.Windows.Forms.PictureBox();
			this.offsetLeft = new System.Windows.Forms.Panel();
			this.offsetRight = new System.Windows.Forms.Panel();
			this.iconRight = new System.Windows.Forms.PictureBox();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.captionLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.iconLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconRight)).BeginInit();
			this.SuspendLayout();
			// 
			// iconLeft
			// 
			this.iconLeft.BackColor = System.Drawing.Color.Transparent;
			this.iconLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.iconLeft.Location = new System.Drawing.Point(13, 10);
			this.iconLeft.Name = "iconLeft";
			this.iconLeft.Size = new System.Drawing.Size(15, 15);
			this.iconLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.iconLeft.TabIndex = 0;
			this.iconLeft.TabStop = false;
			this.iconLeft.Visible = false;
			this.iconLeft.Click += new System.EventHandler(this.IconLeftBox_Click);
			this.iconLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconLeftBox_MouseDown);
			this.iconLeft.MouseEnter += new System.EventHandler(this.IconLeftBox_MouseEnter);
			this.iconLeft.MouseLeave += new System.EventHandler(this.IconLeftBox_MouseLeave);
			this.iconLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IconLeftBox_MouseUp);
			// 
			// offsetLeft
			// 
			this.offsetLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.offsetLeft.Location = new System.Drawing.Point(28, 10);
			this.offsetLeft.Name = "offsetLeft";
			this.offsetLeft.Size = new System.Drawing.Size(2, 15);
			this.offsetLeft.TabIndex = 1;
			// 
			// offsetRight
			// 
			this.offsetRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.offsetRight.Location = new System.Drawing.Point(270, 10);
			this.offsetRight.Name = "offsetRight";
			this.offsetRight.Size = new System.Drawing.Size(2, 15);
			this.offsetRight.TabIndex = 3;
			// 
			// iconRight
			// 
			this.iconRight.BackColor = System.Drawing.Color.Transparent;
			this.iconRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.iconRight.Location = new System.Drawing.Point(272, 10);
			this.iconRight.Name = "iconRight";
			this.iconRight.Size = new System.Drawing.Size(15, 15);
			this.iconRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.iconRight.TabIndex = 2;
			this.iconRight.TabStop = false;
			this.iconRight.Visible = false;
			this.iconRight.Click += new System.EventHandler(this.IconRightBox_Click);
			this.iconRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconRightBox_MouseDown);
			this.iconRight.MouseEnter += new System.EventHandler(this.IconRightBox_MouseEnter);
			this.iconRight.MouseLeave += new System.EventHandler(this.IconRightBox_MouseLeave);
			this.iconRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IconRightBox_MouseUp);
			// 
			// inputTextBox
			// 
			this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputTextBox.Location = new System.Drawing.Point(30, 10);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(240, 15);
			this.inputTextBox.TabIndex = 4;
			this.inputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
			this.inputTextBox.Enter += new System.EventHandler(this.InputTextBox_Enter);
			this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
			this.inputTextBox.Leave += new System.EventHandler(this.InputTextBox_Leave);
			this.inputTextBox.MouseEnter += new System.EventHandler(this.InputTextBox_MouseEnter);
			this.inputTextBox.MouseLeave += new System.EventHandler(this.InputTextBox_MouseLeave);
			// 
			// captionLabel
			// 
			this.captionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.captionLabel.Location = new System.Drawing.Point(30, 10);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(240, 15);
			this.captionLabel.TabIndex = 5;
			this.captionLabel.TextChanged += new System.EventHandler(this.CaptionLabel_TextChanged);
			this.captionLabel.Click += new System.EventHandler(this.CaptionLabel_Click);
			this.captionLabel.Enter += new System.EventHandler(this.CaptionLabel_Enter);
			this.captionLabel.Leave += new System.EventHandler(this.CaptionLabel_Leave);
			this.captionLabel.MouseEnter += new System.EventHandler(this.CaptionLabel_MouseEnter);
			this.captionLabel.MouseLeave += new System.EventHandler(this.CaptionLabel_MouseLeave);
			// 
			// TextBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.captionLabel);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.offsetRight);
			this.Controls.Add(this.iconRight);
			this.Controls.Add(this.offsetLeft);
			this.Controls.Add(this.iconLeft);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ForeColor = System.Drawing.Color.DimGray;
			this.Name = "TextBox";
			this.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
			this.Size = new System.Drawing.Size(300, 35);
			this.Load += new System.EventHandler(this.TextBox_Load);
			this.Enter += new System.EventHandler(this.TextBox_Enter);
			this.Leave += new System.EventHandler(this.TextBox_Leave);
			this.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
			((System.ComponentModel.ISupportInitialize)(this.iconLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconRight)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox iconLeft;
		private System.Windows.Forms.Panel offsetLeft;
		private System.Windows.Forms.Panel offsetRight;
		private System.Windows.Forms.PictureBox iconRight;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Label captionLabel;
	}
}

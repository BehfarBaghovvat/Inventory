
namespace Inventory
{
	partial class TestControlForm
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
			this.textBox1 = new Mbb.Windows.Forms.TextBox();
			this.button1 = new Mbb.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Window;
			this.textBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
			this.textBox1.BorderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
			this.textBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
			this.textBox1.BorderRadius = 0;
			this.textBox1.BorderSize = 2;
			this.textBox1.Caption = "Enter Text";
			this.textBox1.CaptionFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
			this.textBox1.CaptionForeColor = System.Drawing.Color.Silver;
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.textBox1.ForeColor = System.Drawing.Color.DimGray;
			this.textBox1.IconLeft = null;
			this.textBox1.IconLeftMousClick = null;
			this.textBox1.IconLeftMousDown = null;
			this.textBox1.IconLeftMousUp = null;
			this.textBox1.IconRight = null;
			this.textBox1.IconRightMousClick = null;
			this.textBox1.IconRightMousDown = null;
			this.textBox1.IconRightMousUp = null;
			this.textBox1.InputWrite = Mbb.Windows.Forms.TextBox._InputWrite.Decimal_Number;
			this.textBox1.Location = new System.Drawing.Point(314, 87);
			this.textBox1.MultiLine = false;
			this.textBox1.Name = "textBox1";
			this.textBox1.OffsetLeft = 1;
			this.textBox1.OffsetRight = 1;
			this.textBox1.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
			this.textBox1.PasswordChae = false;
			this.textBox1.Size = new System.Drawing.Size(300, 35);
			this.textBox1.Style = Mbb.Windows.Forms.TextBox._Style.DefaultStyle;
			this.textBox1.TabIndex = 0;
			this.textBox1.TextAling = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBox1.Texts = "";
			this.textBox1.WritingLanguage = Mbb.Windows.Forms.TextBox._WritingLanguage.زبان_فارسی;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(339, 192);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(191, 46);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TestControlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(942, 591);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "TestControlForm";
			this.Text = " ";
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.TextBox textBox1;
		private Mbb.Windows.Forms.Button button1;
	}
}
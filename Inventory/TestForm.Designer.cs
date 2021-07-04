
namespace Inventory
{
	partial class TestForm
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
			this.invoiceNumberLabel = new System.Windows.Forms.Label();
			this.invoiceNumberTextBox = new System.Windows.Forms.Label();
			this.invoiceNumber2TextBox = new System.Windows.Forms.Label();
			this.invoiceNumber3TextBox = new System.Windows.Forms.Label();
			this.invoiceNumber4TextBox = new System.Windows.Forms.Label();
			this.button1 = new Mbb.Windows.Forms.Button();
			this.button2 = new Mbb.Windows.Forms.Button();
			this.button3 = new Mbb.Windows.Forms.Button();
			this.button4 = new Mbb.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// invoiceNumberLabel
			// 
			this.invoiceNumberLabel.AutoSize = true;
			this.invoiceNumberLabel.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.invoiceNumberLabel.Location = new System.Drawing.Point(215, 109);
			this.invoiceNumberLabel.Name = "invoiceNumberLabel";
			this.invoiceNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.invoiceNumberLabel.Size = new System.Drawing.Size(113, 31);
			this.invoiceNumberLabel.TabIndex = 1;
			this.invoiceNumberLabel.Text = "شماره فاکتور:";
			// 
			// invoiceNumberTextBox
			// 
			this.invoiceNumberTextBox.Font = new System.Drawing.Font("IRANSans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.invoiceNumberTextBox.Location = new System.Drawing.Point(28, 140);
			this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
			this.invoiceNumberTextBox.Size = new System.Drawing.Size(306, 31);
			this.invoiceNumberTextBox.TabIndex = 2;
			this.invoiceNumberTextBox.Text = "-";
			this.invoiceNumberTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// invoiceNumber2TextBox
			// 
			this.invoiceNumber2TextBox.Font = new System.Drawing.Font("IRANSans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.invoiceNumber2TextBox.Location = new System.Drawing.Point(28, 171);
			this.invoiceNumber2TextBox.Name = "invoiceNumber2TextBox";
			this.invoiceNumber2TextBox.Size = new System.Drawing.Size(306, 31);
			this.invoiceNumber2TextBox.TabIndex = 2;
			this.invoiceNumber2TextBox.Text = "-";
			this.invoiceNumber2TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// invoiceNumber3TextBox
			// 
			this.invoiceNumber3TextBox.Font = new System.Drawing.Font("IRANSans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.invoiceNumber3TextBox.Location = new System.Drawing.Point(28, 202);
			this.invoiceNumber3TextBox.Name = "invoiceNumber3TextBox";
			this.invoiceNumber3TextBox.Size = new System.Drawing.Size(306, 31);
			this.invoiceNumber3TextBox.TabIndex = 2;
			this.invoiceNumber3TextBox.Text = "-";
			this.invoiceNumber3TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// invoiceNumber4TextBox
			// 
			this.invoiceNumber4TextBox.Font = new System.Drawing.Font("IRANSans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.invoiceNumber4TextBox.Location = new System.Drawing.Point(28, 233);
			this.invoiceNumber4TextBox.Name = "invoiceNumber4TextBox";
			this.invoiceNumber4TextBox.Size = new System.Drawing.Size(306, 31);
			this.invoiceNumber4TextBox.TabIndex = 2;
			this.invoiceNumber4TextBox.Text = "-";
			this.invoiceNumber4TextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(598, 132);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(174, 39);
			this.button1.TabIndex = 3;
			this.button1.Text = "تولید سریال فاکتور";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(598, 177);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(174, 39);
			this.button2.TabIndex = 3;
			this.button2.Text = "تولید سریال فاکتور";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(598, 222);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(174, 39);
			this.button3.TabIndex = 3;
			this.button3.Text = "تولید سریال فاکتور";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(598, 267);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(174, 39);
			this.button4.TabIndex = 3;
			this.button4.Text = "تولید سریال فاکتور";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.ClientSize = new System.Drawing.Size(900, 700);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.invoiceNumber4TextBox);
			this.Controls.Add(this.invoiceNumber3TextBox);
			this.Controls.Add(this.invoiceNumber2TextBox);
			this.Controls.Add(this.invoiceNumberTextBox);
			this.Controls.Add(this.invoiceNumberLabel);
			this.Name = "TestForm";
			this.Controls.SetChildIndex(this.invoiceNumberLabel, 0);
			this.Controls.SetChildIndex(this.invoiceNumberTextBox, 0);
			this.Controls.SetChildIndex(this.invoiceNumber2TextBox, 0);
			this.Controls.SetChildIndex(this.invoiceNumber3TextBox, 0);
			this.Controls.SetChildIndex(this.invoiceNumber4TextBox, 0);
			this.Controls.SetChildIndex(this.button1, 0);
			this.Controls.SetChildIndex(this.button2, 0);
			this.Controls.SetChildIndex(this.button3, 0);
			this.Controls.SetChildIndex(this.button4, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label invoiceNumberLabel;
		private System.Windows.Forms.Label invoiceNumberTextBox;
		private System.Windows.Forms.Label invoiceNumber2TextBox;
		private System.Windows.Forms.Label invoiceNumber3TextBox;
		private System.Windows.Forms.Label invoiceNumber4TextBox;
		private Mbb.Windows.Forms.Button button1;
		private Mbb.Windows.Forms.Button button2;
		private Mbb.Windows.Forms.Button button3;
		private Mbb.Windows.Forms.Button button4;
	}
}
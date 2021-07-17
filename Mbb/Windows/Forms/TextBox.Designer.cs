
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
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.captionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// inputTextBox
			// 
			this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputTextBox.Location = new System.Drawing.Point(10, 10);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(230, 15);
			this.inputTextBox.TabIndex = 0;
			// 
			// captionLabel
			// 
			this.captionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.captionLabel.ForeColor = System.Drawing.Color.Silver;
			this.captionLabel.Location = new System.Drawing.Point(10, 10);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(230, 15);
			this.captionLabel.TabIndex = 1;
			this.captionLabel.Text = "Enter Text";
			// 
			// TextBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.captionLabel);
			this.Controls.Add(this.inputTextBox);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ForeColor = System.Drawing.Color.DimGray;
			this.Name = "TextBox";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(250, 35);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Label captionLabel;
	}
}

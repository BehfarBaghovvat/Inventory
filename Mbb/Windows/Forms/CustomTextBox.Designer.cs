﻿
namespace Mbb.Windows.Forms
{
	partial class CustomTextBox
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
			this.SuspendLayout();
			// 
			// CustomTextBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "CustomTextBox";
			this.Size = new System.Drawing.Size(250, 35);
			this.Load += new System.EventHandler(this.CustomTextBox_Load);
			this.BackColorChanged += new System.EventHandler(this.CustomTextBox_BackColorChanged);
			this.RightToLeftChanged += new System.EventHandler(this.CustomTextBox_RightToLeftChanged);
			this.SizeChanged += new System.EventHandler(this.CustomTextBox_SizeChanged);
			this.ResumeLayout(false);

		}

		#endregion
	}
}

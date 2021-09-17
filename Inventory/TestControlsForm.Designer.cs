
namespace Inventory
{
	partial class TestControlsForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dayOfWeekComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(611, 146);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 44);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(611, 96);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(150, 44);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(686, 67);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dayOfWeekComboBox
			// 
			this.dayOfWeekComboBox.Animated = true;
			this.dayOfWeekComboBox.BackColor = System.Drawing.Color.Transparent;
			this.dayOfWeekComboBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.dayOfWeekComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.dayOfWeekComboBox.DropDownHeight = 100;
			this.dayOfWeekComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dayOfWeekComboBox.DropDownWidth = 124;
			this.dayOfWeekComboBox.FocusedColor = System.Drawing.Color.Empty;
			this.dayOfWeekComboBox.FocusedState.Parent = this.dayOfWeekComboBox;
			this.dayOfWeekComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.dayOfWeekComboBox.ForeColor = System.Drawing.Color.Black;
			this.dayOfWeekComboBox.FormattingEnabled = true;
			this.dayOfWeekComboBox.HoverState.Parent = this.dayOfWeekComboBox;
			this.dayOfWeekComboBox.IntegralHeight = false;
			this.dayOfWeekComboBox.ItemHeight = 22;
			this.dayOfWeekComboBox.Items.AddRange(new object[] {
            "شنبه",
            "یکشنبه",
            "دوشنبه",
            "سه شنبه",
            "چهار شنبه",
            "پنچ شنبه",
            "جمعه"});
			this.dayOfWeekComboBox.ItemsAppearance.Parent = this.dayOfWeekComboBox;
			this.dayOfWeekComboBox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
			this.dayOfWeekComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
			this.dayOfWeekComboBox.Location = new System.Drawing.Point(600, 33);
			this.dayOfWeekComboBox.Name = "dayOfWeekComboBox";
			this.dayOfWeekComboBox.ShadowDecoration.Parent = this.dayOfWeekComboBox;
			this.dayOfWeekComboBox.Size = new System.Drawing.Size(161, 28);
			this.dayOfWeekComboBox.TabIndex = 3;
			this.dayOfWeekComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.dayOfWeekComboBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			// 
			// TestControlsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dayOfWeekComboBox);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "TestControlsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TestControlsForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private Guna.UI2.WinForms.Guna2ComboBox dayOfWeekComboBox;
	}
}
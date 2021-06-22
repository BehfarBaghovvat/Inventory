
namespace Mbb.Windows.Forms
{
	partial class VisualForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualForm));
			this.topLayer = new Mbb.Windows.Forms.Panel();
			this.title = new Mbb.Windows.Forms.Label();
			this.underlineTitle = new Mbb.Windows.Forms.Panel();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.minimized = new Mbb.Windows.Forms.Button();
			this.close = new Mbb.Windows.Forms.Button();
			this.topLayer.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// topLayer
			// 
			this.topLayer.Controls.Add(this.title);
			this.topLayer.Controls.Add(this.underlineTitle);
			this.topLayer.Controls.Add(this.panel1);
			this.topLayer.Dock = System.Windows.Forms.DockStyle.Top;
			this.topLayer.Location = new System.Drawing.Point(0, 0);
			this.topLayer.MinimumSize = new System.Drawing.Size(800, 50);
			this.topLayer.Name = "topLayer";
			this.topLayer.Size = new System.Drawing.Size(1300, 100);
			this.topLayer.TabIndex = 1;
			// 
			// title
			// 
			this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.title.BackColor = System.Drawing.Color.Transparent;
			this.title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.title.Location = new System.Drawing.Point(663, 44);
			this.title.Name = "title";
			this.title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.title.Size = new System.Drawing.Size(625, 40);
			this.title.TabIndex = 2;
			this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.title.UseCompatibleTextRendering = true;
			// 
			// underlineTitle
			// 
			this.underlineTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.underlineTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.underlineTitle.Location = new System.Drawing.Point(0, 90);
			this.underlineTitle.Name = "underlineTitle";
			this.underlineTitle.Size = new System.Drawing.Size(1300, 10);
			this.underlineTitle.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.minimized);
			this.panel1.Controls.Add(this.close);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(100, 30);
			this.panel1.TabIndex = 0;
			// 
			// minimized
			// 
			this.minimized.BackColor = System.Drawing.Color.DarkGray;
			this.minimized.Dock = System.Windows.Forms.DockStyle.Left;
			this.minimized.FlatAppearance.BorderSize = 0;
			this.minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimized.Image = ((System.Drawing.Image)(resources.GetObject("minimized.Image")));
			this.minimized.Location = new System.Drawing.Point(50, 0);
			this.minimized.Name = "minimized";
			this.minimized.Size = new System.Drawing.Size(50, 30);
			this.minimized.TabIndex = 1;
			this.minimized.UseVisualStyleBackColor = false;
			// 
			// close
			// 
			this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.close.Dock = System.Windows.Forms.DockStyle.Left;
			this.close.FlatAppearance.BorderSize = 0;
			this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
			this.close.Location = new System.Drawing.Point(0, 0);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(50, 30);
			this.close.TabIndex = 0;
			this.close.UseVisualStyleBackColor = false;
			// 
			// VisualForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1300, 800);
			this.Controls.Add(this.topLayer);
			this.MaximumSize = new System.Drawing.Size(1920, 1080);
			this.Name = "VisualForm";
			this.Text = "نام فرم";
			this.topLayer.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Panel panel1;
		private Button minimized;
		private Button close;
		public Panel topLayer;
		public Label title;
		public Panel underlineTitle;
	}
}
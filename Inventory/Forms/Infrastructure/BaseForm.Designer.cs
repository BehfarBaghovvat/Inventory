
namespace Infrastructure
{
	partial class BaseForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
			this.topLayer = new System.Windows.Forms.Panel();
			this.minimizedButton = new Guna.UI2.WinForms.Guna2Button();
			this.exitButton = new Guna.UI2.WinForms.Guna2Button();
			this.captionLine = new Mbb.Windows.Forms.Panel();
			this.caption = new System.Windows.Forms.Label();
			this.side = new System.Windows.Forms.Panel();
			this.exitTimer = new System.Windows.Forms.Timer(this.components);
			this.topLayer.SuspendLayout();
			this.SuspendLayout();
			// 
			// topLayer
			// 
			this.topLayer.BackColor = System.Drawing.Color.Teal;
			this.topLayer.Controls.Add(this.minimizedButton);
			this.topLayer.Controls.Add(this.exitButton);
			this.topLayer.Controls.Add(this.captionLine);
			this.topLayer.Controls.Add(this.caption);
			this.topLayer.Controls.Add(this.side);
			this.topLayer.Dock = System.Windows.Forms.DockStyle.Top;
			this.topLayer.ForeColor = System.Drawing.Color.White;
			this.topLayer.Location = new System.Drawing.Point(0, 0);
			this.topLayer.Name = "topLayer";
			this.topLayer.Size = new System.Drawing.Size(900, 60);
			this.topLayer.TabIndex = 0;
			this.topLayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_MouseDown);
			// 
			// minimizedButton
			// 
			this.minimizedButton.Animated = true;
			this.minimizedButton.BackColor = System.Drawing.Color.Transparent;
			this.minimizedButton.CheckedState.Parent = this.minimizedButton;
			this.minimizedButton.CustomImages.Parent = this.minimizedButton;
			this.minimizedButton.FillColor = System.Drawing.Color.Transparent;
			this.minimizedButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.minimizedButton.ForeColor = System.Drawing.Color.White;
			this.minimizedButton.HoverState.FillColor = System.Drawing.Color.Silver;
			this.minimizedButton.HoverState.Parent = this.minimizedButton;
			this.minimizedButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizedButton.Image")));
			this.minimizedButton.ImageSize = new System.Drawing.Size(15, 15);
			this.minimizedButton.Location = new System.Drawing.Point(53, 0);
			this.minimizedButton.Name = "minimizedButton";
			this.minimizedButton.PressedColor = System.Drawing.Color.White;
			this.minimizedButton.ShadowDecoration.Parent = this.minimizedButton;
			this.minimizedButton.Size = new System.Drawing.Size(50, 30);
			this.minimizedButton.TabIndex = 8;
			this.minimizedButton.UseTransparentBackground = true;
			this.minimizedButton.Click += new System.EventHandler(this.Minimized_Click);
			// 
			// exitButton
			// 
			this.exitButton.Animated = true;
			this.exitButton.BackColor = System.Drawing.Color.Transparent;
			this.exitButton.CheckedState.Parent = this.exitButton;
			this.exitButton.CustomImages.Parent = this.exitButton;
			this.exitButton.FillColor = System.Drawing.Color.Transparent;
			this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.exitButton.ForeColor = System.Drawing.Color.White;
			this.exitButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.exitButton.HoverState.Parent = this.exitButton;
			this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
			this.exitButton.Location = new System.Drawing.Point(0, 0);
			this.exitButton.Name = "exitButton";
			this.exitButton.PressedColor = System.Drawing.Color.White;
			this.exitButton.ShadowDecoration.Parent = this.exitButton;
			this.exitButton.Size = new System.Drawing.Size(50, 30);
			this.exitButton.TabIndex = 7;
			this.exitButton.UseTransparentBackground = true;
			this.exitButton.Click += new System.EventHandler(this.Exit_Click);
			// 
			// captionLine
			// 
			this.captionLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.captionLine.BackColor = System.Drawing.Color.Indigo;
			this.captionLine.Location = new System.Drawing.Point(584, 45);
			this.captionLine.Name = "captionLine";
			this.captionLine.Size = new System.Drawing.Size(300, 5);
			this.captionLine.TabIndex = 6;
			// 
			// caption
			// 
			this.caption.BackColor = System.Drawing.Color.Transparent;
			this.caption.Dock = System.Windows.Forms.DockStyle.Right;
			this.caption.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.caption.ForeColor = System.Drawing.SystemColors.Menu;
			this.caption.Location = new System.Drawing.Point(585, 0);
			this.caption.Name = "caption";
			this.caption.Padding = new System.Windows.Forms.Padding(0, 15, 5, 0);
			this.caption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.caption.Size = new System.Drawing.Size(305, 60);
			this.caption.TabIndex = 1;
			this.caption.Text = "عنوان فرم";
			this.caption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Caption_MouseDown);
			// 
			// side
			// 
			this.side.BackColor = System.Drawing.Color.Purple;
			this.side.Dock = System.Windows.Forms.DockStyle.Right;
			this.side.Location = new System.Drawing.Point(890, 0);
			this.side.Name = "side";
			this.side.Size = new System.Drawing.Size(10, 60);
			this.side.TabIndex = 3;
			// 
			// exitTimer
			// 
			this.exitTimer.Interval = 10;
			this.exitTimer.Tick += new System.EventHandler(this.ExitTimer_Tick);
			// 
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(900, 700);
			this.Controls.Add(this.topLayer);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximumSize = new System.Drawing.Size(1920, 1080);
			this.MinimumSize = new System.Drawing.Size(350, 0);
			this.Name = "BaseForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "عنوان فرم";
			this.Load += new System.EventHandler(this.BaseForm_Load);
			this.topLayer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel topLayer;
		private System.Windows.Forms.Label caption;
		private System.Windows.Forms.Panel side;
		private Mbb.Windows.Forms.Panel captionLine;
		private Guna.UI2.WinForms.Guna2Button minimizedButton;
		private Guna.UI2.WinForms.Guna2Button exitButton;
		private System.Windows.Forms.Timer exitTimer;
	}
}
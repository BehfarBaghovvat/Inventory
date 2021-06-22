
namespace Entry_Forms
{
	partial class StartUpForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.loadingProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
			this.loadingLabel = new Mbb.Windows.Forms.Label();
			this.showTimer = new System.Windows.Forms.Timer(this.components);
			this.hideTimer = new System.Windows.Forms.Timer(this.components);
			this.loadingTimer = new System.Windows.Forms.Timer(this.components);
			this.counterTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(225, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(250, 250);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 218);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(700, 241);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// loadingProgressBar
			// 
			this.loadingProgressBar.BackColor = System.Drawing.Color.Transparent;
			this.loadingProgressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.loadingProgressBar.BorderColor = System.Drawing.Color.Transparent;
			this.loadingProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.loadingProgressBar.FillColor = System.Drawing.Color.Transparent;
			this.loadingProgressBar.ForeColor = System.Drawing.Color.Transparent;
			this.loadingProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.loadingProgressBar.Location = new System.Drawing.Point(0, 445);
			this.loadingProgressBar.Name = "loadingProgressBar";
			this.loadingProgressBar.ProgressColor = System.Drawing.Color.SlateBlue;
			this.loadingProgressBar.ProgressColor2 = System.Drawing.Color.Transparent;
			this.loadingProgressBar.ShadowDecoration.Parent = this.loadingProgressBar;
			this.loadingProgressBar.Size = new System.Drawing.Size(700, 15);
			this.loadingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.loadingProgressBar.TabIndex = 3;
			this.loadingProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.loadingProgressBar.UseTransparentBackground = true;
			// 
			// loadingLabel
			// 
			this.loadingLabel.AutoSize = true;
			this.loadingLabel.BackColor = System.Drawing.Color.Transparent;
			this.loadingLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadingLabel.ForeColor = System.Drawing.Color.White;
			this.loadingLabel.Location = new System.Drawing.Point(12, 419);
			this.loadingLabel.Name = "loadingLabel";
			this.loadingLabel.Size = new System.Drawing.Size(77, 19);
			this.loadingLabel.TabIndex = 4;
			this.loadingLabel.Text = "Loading...";
			// 
			// showTimer
			// 
			this.showTimer.Interval = 10;
			this.showTimer.Tick += new System.EventHandler(this.ShowTimer_Tick);
			// 
			// hideTimer
			// 
			this.hideTimer.Interval = 1;
			this.hideTimer.Tick += new System.EventHandler(this.HideTimer_Tick);
			// 
			// loadingTimer
			// 
			this.loadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
			// 
			// counterTimer
			// 
			this.counterTimer.Tick += new System.EventHandler(this.CounterTimer_Tick);
			// 
			// StartUpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(700, 460);
			this.ControlBox = false;
			this.Controls.Add(this.loadingLabel);
			this.Controls.Add(this.loadingProgressBar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "StartUpForm";
			this.Text = "StartUpForm";
			this.Load += new System.EventHandler(this.StartUpForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private Guna.UI2.WinForms.Guna2ProgressBar loadingProgressBar;
		private Mbb.Windows.Forms.Label loadingLabel;
		private System.Windows.Forms.Timer showTimer;
		private System.Windows.Forms.Timer hideTimer;
		private System.Windows.Forms.Timer loadingTimer;
		private System.Windows.Forms.Timer counterTimer;
	}
}
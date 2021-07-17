using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mbb.Windows.Forms
{
	public partial class TextBox : UserControl
	{
		//Enums
		public enum _TypeWrite
		{
			English,
			EnglishAndNumber,
			EnglishNumber,
			Persian,
			PersianAndNumber,
			PersianNumber,
		}

		public enum _Style
		{
			DefaultStyle,
			MaterialStyle,
		}

		//Fields
		private Color borderColor = Color.MediumSlateBlue;
		private int borderSize = 2;
		private string text = string.Empty;
		private _Style _style = _Style.DefaultStyle;


		private PictureBox icoLeft = new PictureBox { SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage };
		private PictureBox icoRight = new PictureBox { SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage };

		//Constructor
		public TextBox()
		{
			InitializeComponent();
		}

		//Properties
		public Color BorderColor
		{
			get
			{
				return borderColor;
			}

			set
			{
				borderColor = value;
				this.Invalidate();
			}
		}

		public int BorderSize
		{
			get
			{
				return borderSize;
			}

			set
			{
				borderSize = value;
				this.Invalidate();
			}
		}

		public string Caption
		{
			get
			{
				return captionLabel.Text;
			}
			set
			{
				captionLabel.Text = value;
				this.Invalidate();

				if (string.IsNullOrWhiteSpace(value))
					captionLabel.Visible = false;
				else
					captionLabel.Visible = true;
			}
		}

		public Color CaptionForeColor
		{
			get
			{
				return captionLabel.ForeColor;
			}
			set
			{
				captionLabel.ForeColor = value;
				this.Invalidate();
			}
		}


		public _Style Style
		{
			get
			{
				return _style;
			}

			set
			{
				_style = value;
				this.Invalidate();
			}

		}

		public bool PasswordChae
		{ 
			get
			{
				return inputTextBox.UseSystemPasswordChar;
			}
			set
			{
				inputTextBox.UseSystemPasswordChar = value;
			}
		}

		public bool MultiLine 
		{ 
			get
			{ 
				return inputTextBox.Multiline;
			} 
			set
			{
				inputTextBox.Multiline = value;
			}
		}

		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}

			set
			{
				base.BackColor = value;
				inputTextBox.BackColor = value;
			}
		}

		public override Color ForeColor
		{
			get
			{
				return base.ForeColor;
			}

			set
			{
				base.ForeColor = value;
				inputTextBox.ForeColor = value;
			}
		}

		public override Font Font
		{
			get
			{
				return base.Font;
			}

			set
			{
				base.Font = value;
				inputTextBox.Font = value;

				if (this.DesignMode)
				{
					UpdateControlHeight();
				}
			}
		}

		
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.Editor(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string Text
		{
			get
			{
				text = inputTextBox.Text;
				return text;
			}
			set
			{
				text = value;
				inputTextBox.Text = text;
				this.Invalidate();
				this.Text = string.Empty;

				if (string.IsNullOrWhiteSpace(text))
					captionLabel.Visible = true;
				else
					captionLabel.Visible = false;
			}
		}

		//Override Methods
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;

			//Drawing border
			using(Pen penBorder = new Pen(borderColor, borderSize))
			{
				penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

				if (_style == _Style.MaterialStyle)//Line Style
				{
					graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
				}
				else//Normal Style
				{
					graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
				}
			}
		}

		

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if(this.DesignMode)
				UpdateControlHeight();

			if (base.Width < 100)
			{
				base.Width = 100;
			}

			if (base.Height < 35)
			{
				base.Height = 35;
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			UpdateControlHeight();
		}

		//Privat Methods
		private void UpdateControlHeight()
		{
			if (inputTextBox.Multiline == false)
			{
				int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
				inputTextBox.Multiline = true;
				inputTextBox.MinimumSize = new Size(0, txtHeight);
				inputTextBox.Multiline = false;

				this.Height = inputTextBox.Height + this.Padding.Top + this.Padding.Bottom;

			}
		}


	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mbb.Windows.Forms
{
	[DefaultEvent("TextChanged")]
	public partial class TextBox : UserControl
	{
		//======================================================================= Enums
		public enum _InputWrite
		{
			FreeType,
			English,
			English_And_EnglishNumber,
			فارسی,
			فارسی_و_اعداد_فارسی,
			Number,
			Decimal_Number
		}
		public enum _Style
		{
			DefaultStyle,
			MaterialStyle,
		}
		public enum _WritingLanguage
		{
			English_Language,
			Free_Language,
			زبان_فارسی,
		}

		//======================================================================= Fields
		private System.Drawing.Color _borderColor = System.Drawing.Color.MediumSlateBlue;
		private int _borderSize = 2;
		private System.Drawing.Color _borderColorHover = System.Drawing.Color.FromArgb(220, 20, 60);
		private System.Drawing.Color _borderColorFocus = System.Drawing.Color.FromArgb(123, 104, 238);
		private System.Drawing.Font _captionFont = new System.Drawing.Font(familyName: "Century Gothic", emSize: 9F, FontStyle.Italic);
		private System.Drawing.Color _captionForColor = System.Drawing.Color.Silver;

		private _InputWrite _inputWirte = _InputWrite.FreeType;
		private bool _isFocus = false;
		private bool _isHover = false;

		private int _borderRadius = 0;

		private System.Windows.Forms.HorizontalAlignment _textAling = HorizontalAlignment.Left;

		private System.Drawing.Image _iconLeft;
		private System.Drawing.Image _iconLeftMousClick;
		private System.Drawing.Image _iconLeftMousDown;
		private System.Drawing.Image _iconLeftMousUp;



		private System.Drawing.Image _iconRight;
		private System.Drawing.Image _iconRightMousClick;
		private System.Drawing.Image _iconRightMousDown;
		private System.Drawing.Image _iconRightMousUp;


		private int _offsetLeft = 1;
		private int _offsetRight = 1;


		private _Style _style = _Style.DefaultStyle;
		private _WritingLanguage _writingLanguage = _WritingLanguage.Free_Language;

		//======================================================================= Constructor
		public TextBox()
		{
			InitializeComponent();
			Caption = "Enter Text";
			captionLabel.Font = _captionFont;
			captionLabel.ForeColor = _captionForColor;
		}

		//======================================================================= Properties
		[Category("MBB Advance Properties")]
		public Color BorderColor
		{
			get
			{
				return _borderColor;
			}

			set
			{
				_borderColor = value;
				this.Invalidate();
			}
		}
		[Category("MBB Advance Properties")]
		public int BorderSize
		{
			get
			{
				return _borderSize;
			}

			set
			{
				_borderSize = value;
				this.Invalidate();
			}
		}
		[Category("MBB Advance Properties")]
		public Color BorderColorHover
		{
			get
			{
				return _borderColorHover;
			}

			set
			{
				_borderColorHover = value;
			}
		}
		[Category("MBB Advance Properties")]
		public Color BorderColorFocus
		{
			get
			{
				return _borderColorFocus;
			}

			set
			{
				_borderColorFocus = value;
			}
		}
		[Category("MBB Advance Properties")]
		[Description("مقدار انحنای کنترل متن را تعیین میکند")]

		public int BorderRadius
		{
			get
			{
				return _borderRadius;
			}

			set
			{

				if (value >= 0)
				{
					_borderRadius = value;
					this.Invalidate();
				}
			}
		}
		[Category("MBB Advance Properties")]
		[Description("نوع ورودی که کاربر برای وارد کردن داده از آن استفاده میکند را انتخاب میکند. \n این ورودی می تواند متن یا عدد به صورت انگلیسی یا فارسی باشد.")]
		public _InputWrite InputWrite
		{
			get
			{
				return _inputWirte;
			}
			set
			{
				_inputWirte = value;
			}
		}
		[Category("MBB Advance Properties")]
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
		[Category("MBB Advance Properties")]
		[Description("زبان نوشتاری کنترل را تعیین می نمایید")]
		public _WritingLanguage WritingLanguage
		{
			get
			{
				return _writingLanguage;
			}

			set
			{
				_writingLanguage = value;
			}
		}
		[Category("MBB Advance Properties")]
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
			}
		}
		[Category("MBB Advance Properties")]
		public Font CaptionFont
		{
			get
			{

				return _captionFont;
			}

			set
			{
				_captionFont = value;
				captionLabel.Font = _captionFont;
			}
		}
		[Category("MBB Advance Properties")]
		public Color CaptionForeColor
		{
			get
			{
				return _captionForColor;
			}
			set
			{
				_captionForColor = value;
				captionLabel.ForeColor = _captionForColor;
				this.Invalidate();
			}
		}
		[Category("MBB Advance Properties")]
		public System.Drawing.Image IconLeft
		{
			get
			{
				return _iconLeft;
			}
			set
			{
				_iconLeft = value;
				
				if (value == null)
				{
					iconLeft.Visible = false;
					iconLeft.Image = null;
				}
				else
				{
					iconLeft.Visible = true;
					iconLeft.Image = value;
				}
			}
		}
		[Category("MBB Advance Properties")]
		public System.Drawing.Image IconLeftMousClick
		{
			get 
			{ 
				return _iconLeftMousClick;
			}
			set
			{
				_iconLeftMousClick = value;
			}
		}
		[Category("MBB Advance Properties")]
		public System.Drawing.Image IconLeftMousDown
		{
			get 
			{ 
				return _iconLeftMousDown;
			}
			set
			{
				_iconLeftMousDown = value;
			}
		}
		[Category("MBB Advance Properties")]
		public System.Drawing.Image IconLeftMousUp
		{
			get 
			{ 
				return _iconLeftMousUp;
			}
			set
			{
				_iconLeftMousUp = value;
			}
		}
		[Category("MBB Advance Properties")]
		public Image IconRight
		{
			get
			{
				return _iconRight;
			}

			set
			{
				_iconRight = value;
			}
		}
		public System.Drawing.Image IconRightMousClick
		{
			get
			{
				return _iconLeftMousClick;
			}
			set
			{
				_iconLeftMousClick = value;
			}
		}
		[Category("MBB Advance Properties")]
		public System.Drawing.Image IconRightMousDown
		{
			get
			{
				return _iconLeftMousDown;
			}
			set
			{
				_iconLeftMousDown = value;
			}
		}
		[Category("MBB Advance Properties")]
		public System.Drawing.Image IconRightMousUp
		{
			get
			{
				return _iconLeftMousUp;
			}
			set
			{
				_iconLeftMousUp = value;
			}
		}
		[Category("MBB Advance Properties")]
		public int OffsetLeft
		{
			get
			{
				return _offsetLeft;
			}
			set
			{
				_offsetLeft = value;
				if (_offsetLeft > 5)
				{
					return;
				}
				else
				{
					offsetLeft.Width = _offsetLeft;
				}
			}
		}
		[Category("MBB Advance Properties")]
		public int OffsetRight
		{
			get
			{
				return _offsetRight;
			}

			set
			{
				_offsetRight = value;
				if (_offsetRight > 5)
				{
					return;
				}
				else
				{
					offsetRight.Width = _offsetRight;
				}
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
				captionLabel.BackColor = value;
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
		public string Texts
		{
			get
			{
				return inputTextBox.Text;
			}

			set
			{
				inputTextBox.Text = value;
				this.Invalidate();
			}
		}
		public System.Windows.Forms.HorizontalAlignment TextAling
		{
			get { return _textAling; }
			set
			{
				_textAling = value;

				inputTextBox.TextAlign = _textAling;
				if (_textAling == System.Windows.Forms.HorizontalAlignment.Right)
				{
					captionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
				}
				else if (_textAling == System.Windows.Forms.HorizontalAlignment.Left)
				{
					captionLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
				}
				else if (_textAling == System.Windows.Forms.HorizontalAlignment.Center)
				{
					captionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
				}
			}
		}





		//======================================================================= Override Methods
		private GraphicsPath GetFigurePath(Rectangle rect, int radius)
		{
			GraphicsPath path = new GraphicsPath();
			float curveSize = radius * 2F;

			path.StartFigure();
			path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
			path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
			path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
			path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
			return path;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			UpdateControlHeight();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;


			if (_borderRadius > 1) //Round TextBox
			{
				//_Fields
				var rectBorderSmooth = this.ClientRectangle;
				var rectBorder = Rectangle.Inflate(rectBorderSmooth, -_borderSize, -_borderSize);
				int smoothSize = _borderSize > 0 ? _borderSize : 1;

				using(GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, _borderRadius))
				using(GraphicsPath pathBorder = GetFigurePath(rectBorder, _borderRadius - _borderSize))
				using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
				using (Pen penBorder = new Pen(_borderColor, _borderSize))
				{
					//-Drawing

					this.Region = new Region(pathBorderSmooth);
					if (_borderRadius > 15)
					{
						SetTextBoxRoundedRegion();//Set the rounded of TextBox component
					}
					graphics.SmoothingMode = SmoothingMode.HighQuality;
					penBorder.Alignment = PenAlignment.Center;

					penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

					if (!_isFocus)
					{
						if (_style == _Style.MaterialStyle)//Line Style
						{
							//Draw border smoothing
							graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
							//Draw border
							graphics.SmoothingMode = SmoothingMode.None;
							graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
						}
						else//Normal Style
						{
							//Draw border smoothing
							graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
							//Draw border
							graphics.DrawPath(penBorder, pathBorder);

						}
					}
					else
					{
						penBorder.Color = BorderColorFocus;
						if (_style == _Style.MaterialStyle)//Line Style
						{
							graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
						}
						else//Normal Style
						{
							graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
						}
					}

					if (!_isHover)
					{
						if (_style == _Style.MaterialStyle)//Line Style
						{
							graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
						}
						else//Normal Style
						{
							graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
						}
					}
					else
					{
						penBorder.Color = BorderColorHover;
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
			}
			else//Square/Normal TextBox
			{
				//Drawing border
				using (Pen penBorder = new Pen(_borderColor, _borderSize))
				{
					this.Region = new Region(this.ClientRectangle);
					penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
					if (!_isFocus)
					{
						if (_style == _Style.MaterialStyle)//Line Style
						{
							graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
						}
						else//Normal Style
						{
							graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
						}
					}
					else
					{
						penBorder.Color = BorderColorFocus;
						if (_style == _Style.MaterialStyle)//Line Style
						{
							graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
						}
						else//Normal Style
						{
							graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
						}
					}

					if (!_isHover)
					{
						if (_style == _Style.MaterialStyle)//Line Style
						{
							graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
						}
						else//Normal Style
						{
							graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
						}
					}
					else
					{
						penBorder.Color = BorderColorHover;
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
			}

			
		}

		private void SetTextBoxRoundedRegion()
		{
			GraphicsPath pathTxt;
			if (MultiLine)
			{
				pathTxt = GetFigurePath(captionLabel.ClientRectangle, _borderRadius - _borderSize);
				captionLabel.Region = new Region(pathTxt);
				pathTxt = GetFigurePath(inputTextBox.ClientRectangle, _borderRadius - _borderSize);
				inputTextBox.Region = new Region(pathTxt);
			}
			else
			{
				pathTxt = GetFigurePath(captionLabel.ClientRectangle, _borderSize * 2);
				captionLabel.Region = new Region(pathTxt);
				pathTxt = GetFigurePath(inputTextBox.ClientRectangle, _borderSize * 2);
				inputTextBox.Region = new Region(pathTxt);
			}
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this.DesignMode)
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

		

		//======================================================================= Privat Methods
		#region DecimalNumberInputType
		private void DecimalNumberInputType(System.Windows.Forms.KeyPressEventArgs e, string text)
		{
			char ch = e.KeyChar;

			if (ch == 47 && text.IndexOf('/') != -1)
			{
				e.Handled = true;
				return;
			}

			if (!char.IsDigit(ch) && ch != 8 && ch != 47)
			{
				e.Handled = true;
			}
		}
		#endregion

		#region EnglishLanguage
		/// <summary>
		/// Function to change Persian to English
		/// </summary>
		private void EnglishLanguage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture =
				new System.Globalization.CultureInfo("en-us");

			System.Threading.Thread.CurrentThread.CurrentUICulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			System.Windows.Forms.InputLanguage.CurrentInputLanguage =
				System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-us"));
		}
		#endregion /EnglishLanguage

		#region PersianLanguage
		/// <summary>
		/// Function to change English to Persian
		/// </summary>
		private void PersianLanguage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture =
				new System.Globalization.CultureInfo("fa-ir");

			System.Threading.Thread.CurrentThread.CurrentUICulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			System.Windows.Forms.InputLanguage.CurrentInputLanguage =
				System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("fa-ir"));
		}
		#endregion /PersianLanguage

		#region UpdateControlHeight
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
		#endregion /UpdateControlHeight

		#region EnglishInputType
		private void EnglishInputType(KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 'آ' && e.KeyChar <= 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
			{
				e.Handled = true;
			}
		}
		#endregion /EnglishType

		#region EnglishAndEnglishNumberInputType
		private void EnglishAndEnglishNumberInputType(KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
			{
				e.Handled = true;
			}
		}
		#endregion /EnglishAndEnglishNumberInputType

		#region PersianInputType
		private void PersianInputType(KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
			{
				e.Handled = true;
			}
		}
		#endregion /PersianInputType

		#region PersianAndNunberInputType
		private void PersianAndNunberInputType(KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
			{
				e.Handled = true;
			}
		}
		#endregion /PersianAndPersianNunberInputType

		#region NumberInputType
		private void NumberInputType(KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}
		#endregion /NumberInputType


		//======================================================================= Eevents

		//creat event _TextChanges for TextBox contorol.
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.Editor(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public event EventHandler TextChanged;
		[System.ComponentModel.Browsable(false)]
		public event EventHandler Load;

		private void TextBox_Load(object sender, EventArgs e)
		{
			if (TextChanged != null)
			{
				TextChanged.Invoke(sender, e);
			}
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			_isFocus = true;
			this.Invalidate();
		}

		private void TextBox_Leave(object sender, EventArgs e)
		{
			_isFocus = false;
			this.Invalidate();
		}

		private void TextBox_MouseEnter(object sender, EventArgs e)
		{
			_isHover = true;
			this.Invalidate();
		}

		private void TextBox_MouseLeave(object sender, EventArgs e)
		{
			_isHover = false;
			this.Invalidate();
		}

		private void InputTextBox_Enter(object sender, EventArgs e)
		{
			_isFocus = true;
			this.Invalidate();
			if (WritingLanguage == _WritingLanguage.English_Language)
			{
				EnglishLanguage();
			}
			else if (WritingLanguage == _WritingLanguage.English_Language)
			{
				PersianLanguage();
			}
		}

		private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (InputWrite == _InputWrite.FreeType)
			{
				return;
			}
			else if (InputWrite == _InputWrite.English)
			{
				EnglishInputType(e);
			}
			else if (InputWrite == _InputWrite.English_And_EnglishNumber)
			{
				EnglishAndEnglishNumberInputType(e);
			}
			else if (InputWrite == _InputWrite.فارسی)
			{
				PersianInputType(e);
			}
			else if (InputWrite == _InputWrite.فارسی_و_اعداد_فارسی)
			{
				PersianAndNunberInputType(e);
			}
			else if (InputWrite == _InputWrite.Number)
			{
				NumberInputType(e);
			}
			else if (InputWrite == _InputWrite.Decimal_Number)
			{
				DecimalNumberInputType(e, inputTextBox.Text);
			}
		}

		private void InputTextBox_Leave(object sender, EventArgs e)
		{
			_isFocus = false;
			this.Invalidate();

			if (string.IsNullOrWhiteSpace(inputTextBox.Text))
			{
				captionLabel.BringToFront();
			}
			else
			{
				captionLabel.SendToBack();
			}

		}

		private void InputTextBox_MouseEnter(object sender, EventArgs e)
		{
			_isHover = true;
			this.Invalidate();
		}

		private void InputTextBox_MouseLeave(object sender, EventArgs e)
		{
			_isHover = false;
			this.Invalidate();
		}

		private void InputTextBox_TextChanged(object sender, EventArgs e)
		{
			if (TextChanged != null)
			{
				TextChanged.Invoke(sender, e);
			}

			//if (!string.IsNullOrWhiteSpace(inputTextBox.Text))
			//{
			//	captionLabel.Visible = false;
			//}
			//else
			//{
			//	captionLabel.Visible = true;
			//}
		}

		private void CaptionLabel_Click(object sender, EventArgs e)
		{
			_isFocus = true;
			inputTextBox.Focus();

			captionLabel.SendToBack();

			if (WritingLanguage == _WritingLanguage.Free_Language)
			{
				return;
			}
			else if (WritingLanguage == _WritingLanguage.English_Language)
			{
				EnglishLanguage();
			}
			else if (WritingLanguage == _WritingLanguage.زبان_فارسی)
			{
				PersianLanguage();
			}
		}

		private void CaptionLabel_Enter(object sender, EventArgs e)
		{
			_isFocus = true;
			this.Invalidate();
		}

		private void CaptionLabel_Leave(object sender, EventArgs e)
		{
			_isFocus = false;
			this.Invalidate();
		}

		private void CaptionLabel_MouseEnter(object sender, EventArgs e)
		{
			_isHover = true;
			this.Invalidate();
		}

		private void CaptionLabel_MouseLeave(object sender, EventArgs e)
		{
			_isHover = false;
			this.Invalidate();
		}

		private void CaptionLabel_TextChanged(object sender, EventArgs e)
		{

		}

		private void IconLeftBox_Click(object sender, EventArgs e)
		{
			if (IconLeft != null)
			{
				if (IconLeftMousClick == null)
				{
					return;
				}
				else
				{
					iconLeft.Image = IconLeftMousClick;
				} 
			}
			else
			{
				return;
			}
		}

		private void IconLeftBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (IconLeft != null)
			{
				if (IconLeftMousDown == null)
				{
					return;
				}
				else
				{
					iconLeft.Image = IconLeftMousDown;
				}
			}
			else
			{
				return;
			}
			
		}

		private void IconLeftBox_MouseEnter(object sender, EventArgs e)
		{
			_isHover = true;
			this.Invalidate();
		}

		private void IconLeftBox_MouseLeave(object sender, EventArgs e)
		{
			_isHover = false;
			this.Invalidate();
		}

		private void IconLeftBox_MouseUp(object sender, MouseEventArgs e)
		{
			if (IconLeft != null)
			{
				if (IconLeftMousUp == null)
				{
					return;
				}
				else
				{
					iconLeft.Image = IconLeftMousUp;
				}
			}
			else
			{
				return;
			}
		}

		private void IconRightBox_Click(object sender, EventArgs e)
		{
			if (IconRight != null)
			{
				if (IconRightMousClick == null)
				{
					return;
				}
				else
				{
					iconRight.Image = IconLeftMousClick;
				}
			}
			else
			{
				return;
			}
		}

		private void IconRightBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (IconRight != null)
			{
				if (IconRightMousDown == null)
				{
					return;
				}
				else
				{
					iconRight.Image = IconRightMousDown;
				}
			}
			else
			{
				return;
			}
		}

		private void IconRightBox_MouseEnter(object sender, EventArgs e)
		{
			_isHover = true;
			this.Invalidate();
		}

		private void IconRightBox_MouseLeave(object sender, EventArgs e)
		{
			_isHover = false;
			this.Invalidate();
		}

		private void IconRightBox_MouseUp(object sender, MouseEventArgs e)
		{
			if (IconRight != null)
			{
				if (IconRightMousUp == null)
				{
					return;
				}
				else
				{
					iconRight.Image = IconRightMousUp;
				}
			}
			else
			{
				return;
			}
		}

		
	}
}

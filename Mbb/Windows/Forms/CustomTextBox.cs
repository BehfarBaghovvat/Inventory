using System.Drawing;

namespace Mbb.Windows.Forms
{
	[System.ComponentModel.DefaultEvent("TextChanged")]
	public partial class CustomTextBox : System.Windows.Forms.UserControl
	{
		//----------------------------------------------------   Properties ansd Fields

		#region Properties ansd Fields

		private bool _focus = false;
		private bool _iconLeftActive = false;
		private bool _iconRightActive = false;



		//----------------------------------------------------   Cotrols Layer
		#region CotrolsLayer
		private System.Windows.Forms.TextBox _inputTextBox = new System.Windows.Forms.TextBox { BorderStyle = System.Windows.Forms.BorderStyle.None, BackColor = default, };
		private System.Windows.Forms.Label _captionLabel = new System.Windows.Forms.Label { BackColor = default, };
		private System.Windows.Forms.Panel MaterialBorder = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Bottom, };

		private System.Windows.Forms.Panel TopBorder = new System.Windows.Forms.Panel();
		private System.Windows.Forms.Panel LeftBorder = new System.Windows.Forms.Panel();
		private System.Windows.Forms.Panel RightBorder = new System.Windows.Forms.Panel();
		private System.Windows.Forms.Panel BottomBorder = new System.Windows.Forms.Panel();

		private System.Windows.Forms.PictureBox _iconLeftBox = new System.Windows.Forms.PictureBox { SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
		private System.Windows.Forms.PictureBox _iconRightBox = new System.Windows.Forms.PictureBox { SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };

		#endregion /CotrolsLayer
		//----------------------------------------------------   Enums
		#region Enums
		public enum TypeWrite
		{
			English,
			EnglishAndNumber,
			EnglishNumber,
			Persian,
			PersianAndNumber,
			PersianNumber,
		}
		public enum Style
		{
			Default,
			MaterialStyle,
		}
		#endregion /Enums

		//----------------------------------------------------   Properties
		private System.Drawing.Color _borderColorIdle = System.Drawing.Color.Silver;
		public System.Drawing.Color BorderColorIdle
		{
			get { return _borderColorIdle; }
			set
			{
				_borderColorIdle = value;

				if (_styleTextBox == Style.Default)
				{
					DefaultBorderColor(_borderColorIdle);
				}
				else if (_styleTextBox == Style.MaterialStyle)
				{
					MaterialBorderColor(_borderColorIdle);
				}
			}
		}

		private System.Drawing.Color _borderColorFocus = System.Drawing.Color.Silver;
		public System.Drawing.Color BorderColorFocus
		{
			get { return _borderColorFocus; }
			set
			{
				_borderColorFocus = value;
			}
		}

		private System.Drawing.Color _borderColorHover = System.Drawing.Color.Silver;
		public System.Drawing.Color BorderColorHover
		{
			get { return _borderColorHover; }
			set
			{
				_borderColorHover = value;
			}
		}

		private int _borderThickness = 1;
		public int BorderThickness
		{
			get { return _borderThickness; }
			set
			{
				if (value >= 0 || value <= 5)
				{
					_borderThickness = value;
				}
				else
				{
					return;
				}

				if (_styleTextBox == Style.Default)
				{
					DefaultBorderThickness(_borderThickness);
				}
				else if (_styleTextBox == Style.MaterialStyle)
				{
					MaterialBorderThickness(_borderThickness);
				}
			}
		}

		private string _caption = "Enter text";
		public string Caption
		{
			get
			{
				return _caption;
			}
			set
			{
				_caption = value;

				if (string.IsNullOrEmpty(_caption))
				{
					this.Controls.Remove(_captionLabel);
				}
				else
				{
					GetCaption(_caption);
				}
			}
		}

		private System.Drawing.Color _captionForeColor = System.Drawing.Color.Silver;
		public System.Drawing.Color CaptionForeColor
		{
			get
			{
				return _captionForeColor;
			}
			set
			{
				_captionForeColor = value;

				_captionLabel.ForeColor = _captionForeColor;
			}
		}

		private System.Drawing.Image _iconLeft;
		public System.Drawing.Image IconLeft
		{
			get { return _iconLeft; }
			set
			{
				_iconLeft = value;

				if (_iconLeft != null)
				{
					
					GetIconLeft(size: IconLeftSize, location: IconLeftOffset, _iconLeft);
				}
				else
				{
					
					RemoveIconLeft();
				}
			}
		}

		private System.Drawing.Image _iconLeftMousClick;
		public System.Drawing.Image IconLeftMousClick
		{
			get { return _iconLeftMousClick; }
			set
			{
				_iconLeftMousClick = value;
			}
		}

		private System.Drawing.Image _iconLeftMousDown;
		public System.Drawing.Image IconLeftMousDown
		{
			get { return _iconLeftMousDown; }
			set
			{
				_iconLeftMousDown = value;
			}
		}

		private System.Drawing.Image _iconLeftMousUp;
		public System.Drawing.Image IconLeftMousUp
		{
			get { return _iconLeftMousUp; }
			set
			{
				_iconLeftMousUp = value;
			}
		}

		private System.Drawing.Point _iconLeftOffset = new System.Drawing.Point(x: 8, y: 7);
		public System.Drawing.Point IconLeftOffset
		{
			get { return _iconLeftOffset; }
			set
			{
				_iconLeftOffset = value;

				_iconLeftBox.Location = new System.Drawing.Point(x: _iconLeftOffset.X, y: _iconLeftOffset.Y);
			}
		}

		private int _iconLeftSize = 20;
		public int IconLeftSize
		{
			get { return _iconLeftSize; }
			set
			{
				if (value >= 20 || value <= 40)
				{
					_iconLeftSize = value;
				}
				else
				{
					return;
				}
			}
		}

		private System.Drawing.Image _iconRight;
		public System.Drawing.Image IconRight
		{
			get { return _iconRight; }
			set
			{
				_iconRight = value;

				if (_iconRight != null)
				{
					GetIconRight(size: IconRightSize, location: IconRightOffset, icon: _iconRight);
				}
				else
				{
					RemoveIconRight();
				}
			}
		}

		private System.Drawing.Point _iconRightOffset = new System.Drawing.Point(x: 222, y: 7);
		public System.Drawing.Point IconRightOffset
		{
			get { return _iconRightOffset; }
			set
			{
				_iconRightOffset = value;

				_iconRightBox.Location = new System.Drawing.Point(x: _iconRightOffset.X, y: _iconRightOffset.Y);
			}
		}

		private int _iconRightSize = 20;
		public int IconRightSize
		{
			get { return _iconRightSize; }
			set
			{
				if (value >= 20 || value <= 40)
				{
					_iconRightSize = value;
				}
				else
				{
					return;
				}
			}
		}
		
		public bool Multiline
		{
			get 
			{ 
				return _inputTextBox.Multiline;
			}
			set
			{
				_inputTextBox.Multiline = value;

				if (value == true)
				{
					_captionLabel.Location = _inputTextBox.Location = new Point(x: 10, y: 9);

					_captionLabel.Size = _inputTextBox.Size = new Size(width: this.Width - 20, height: this.Height - 18);
					_captionLabel.Anchor = _inputTextBox.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
					
					if (_inputTextBox.TextAlign == System.Windows.Forms.HorizontalAlignment.Left)
					{
						_captionLabel.TextAlign = ContentAlignment.TopLeft;
					}
					else if (_inputTextBox.TextAlign == System.Windows.Forms.HorizontalAlignment.Center)
					{
						_captionLabel.TextAlign = ContentAlignment.TopCenter;
					}
					else if (_inputTextBox.TextAlign == System.Windows.Forms.HorizontalAlignment.Right)
					{
						_captionLabel.TextAlign = ContentAlignment.TopRight;
					}
				}
				else if (value == false)
				{
					//this.Height = 35;
					_captionLabel.Location = _inputTextBox.Location = new Point(x: 10, y: (this.Height / 2) - (_inputTextBox.Height / 2));

					_captionLabel.Anchor = _inputTextBox.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

					_captionLabel.Size = _inputTextBox.Size = new Size(width: this.Width - 20, height: 17);
				}

			}
		}

		private Style _styleTextBox = Style.Default;
		public Style StyleTextBox
		{
			get { return _styleTextBox; }
			set
			{
				if (_styleTextBox == Style.Default)
				{
					GetInputTextBox();
					DefaultBorderStyle();
					MaterialBorderRemove();
				}
				else if (_styleTextBox == Style.MaterialStyle)
				{
					DefaultBorderRemove();
					MaterialBorderStyle();
				}
			}
		}

		private System.Windows.Forms.HorizontalAlignment _textAling;
		public System.Windows.Forms.HorizontalAlignment TextAling
		{
			get { return _textAling; }
			set
			{
				_textAling = value;

				_inputTextBox.TextAlign = _textAling;


				if (!Multiline)
				{
					if (_textAling == System.Windows.Forms.HorizontalAlignment.Right)
					{

						_captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					}
					else if (_textAling == System.Windows.Forms.HorizontalAlignment.Left)
					{
						_captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
					}
					else if (_textAling == System.Windows.Forms.HorizontalAlignment.Center)
					{
						_captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
					}
				}
				else
				{
					if (_textAling == System.Windows.Forms.HorizontalAlignment.Right)
					{
						_captionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
					}
					else if (_textAling == System.Windows.Forms.HorizontalAlignment.Left)
					{
						_captionLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
					}
					else if (_textAling == System.Windows.Forms.HorizontalAlignment.Center)
					{
						_captionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
					}
				}

				
			}
		}

		private string _text;
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.DisplayName("Text")]
		[System.ComponentModel.Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public new string Text
		{
			get
			{
				_text = _inputTextBox.Text;
				return _text;
			}
			set
			{
				_text = value;
				_inputTextBox.Text = _text;

				if (string.IsNullOrEmpty(_text))
				{
					GetCaption(Caption);
				}
				else
				{
					this.Controls.Remove(_captionLabel);
				}
			}
		}

		private TypeWrite _typeWriteLanguage = TypeWrite.English;
		public TypeWrite TypeWriteLanguage
		{
			get
			{ return _typeWriteLanguage; }
			set
			{
				_typeWriteLanguage = value;
			}
		}

		

		#endregion /Properties ansd Fields



		//----------------------------------------------------   Constracture

		#region CustomTextBox
		public CustomTextBox()
		{
			InitializeComponent();
			//=============================================
			DefaultBorderStyle();
			GetInputTextBox();
			GetCaption(Caption);

			_iconLeftBox.MouseClick += IconLeftBox_MouseClick;
			_iconLeftBox.MouseDown += IconLeftBox_MouseDown;
			_iconLeftBox.MouseUp += IconLeftBox_MouseUp;

			_captionLabel.Click += CaptionLabel_Click;
			_captionLabel.MouseEnter += CaptionLabel_MouseEnter;
			_captionLabel.MouseLeave += CaptionLabel_MouseLeave;

			_inputTextBox.Enter += InputTextBox_Enter;
			_inputTextBox.KeyPress += InputBox_KeyPress;
			_inputTextBox.Leave += InputTextBox_Leave;
			_inputTextBox.MouseEnter += InputTextBox_MouseEnter;
			_inputTextBox.MouseLeave += InputTextBox_MouseLeave;
			_inputTextBox.TextChanged += InputBox_TextChanged;
		}
		#endregion /CustomTextBox



		//----------------------------------------------------   Events Handler

		#region Events Handler
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.Description("Occurs when the property 'Text' changes.")]
		public event System.EventHandler TextChanged;
		#endregion /Events Handler


		//----------------------------------------------------   Events Controls

		#region CustomTextBox_BackColorChanged
		private void CustomTextBox_BackColorChanged(object sender, System.EventArgs e)
		{
			_inputTextBox.BackColor = this.BackColor;
			_captionLabel.BackColor = this.BackColor;
		}
		#endregion /CustomTextBox_BackColorChanged

		#region CustomTextBox_Click
		private void CustomTextBox_Click(object sender, System.EventArgs e)
		{
			_focus = true;
			_inputTextBox.Focus();

		}
		#endregion /CustomTextBox_Click

		#region CustomTextBox_Enter
		private void CustomTextBox_Enter(object sender, System.EventArgs e)
		{
			_focus = true;
			if (_styleTextBox == Style.Default)
			{
				DefaultBorderColor(_borderColorFocus);
			}
			else if (_styleTextBox == Style.MaterialStyle)
			{
				MaterialBorderColor(_borderColorFocus);
			}
		}
		#endregion /CustomTextBox_Enter

		#region CustomTextBox_ForeColorChanged
		private void CustomTextBox_ForeColorChanged(object sender, System.EventArgs e)
		{
			_inputTextBox.ForeColor = this.ForeColor;
		}
		#endregion /CustomTextBox_ForeColorChanged

		#region CustomTextBox_Leave
		private void CustomTextBox_Leave(object sender, System.EventArgs e)
		{
			_focus = false;

			if (_styleTextBox == Style.Default)
			{
				DefaultBorderColor(_borderColorIdle);
			}
			else if (_styleTextBox == Style.MaterialStyle)
			{
				MaterialBorderColor(_borderColorIdle);
			}
		}
		#endregion /CustomTextBox_Leave

		#region CustomTextBox_Load
		private void CustomTextBox_Load(object sender, System.EventArgs e)
		{
			base.Text = string.Empty;

			if (this.Controls.Contains(_iconLeftBox))
			{
				_iconLeftBox.Location = new System.Drawing.Point(x: 8, y: 7);
				_inputTextBox.Location = new System.Drawing.Point(x: 34, y: 9);
				_inputTextBox.Width = 200;
				_captionLabel.Location = _inputTextBox.Location;
				_captionLabel.Width = _inputTextBox.Width - 3;
			}
			else
			{
				return;
			}

			if (this.Controls.Contains(_iconRightBox))
			{
				_iconRightBox.Location = new System.Drawing.Point(x: 222, y: 7);

				_inputTextBox.Width -= 52;
				_captionLabel.Width = _inputTextBox.Width;
			}
			else
			{
				return;
			}
		}
		#endregion /CustomTextBox_Load

		#region CustomTextBox_MouseEnter
		private void CustomTextBox_MouseEnter(object sender, System.EventArgs e)
		{
			if (_styleTextBox == Style.Default)
			{
				DefaultBorderColor(_borderColorHover);
			}
			else if (_styleTextBox == Style.MaterialStyle)
			{
				MaterialBorderColor(_borderColorHover);
			}
		}
		#endregion /CustomTextBox_MouseEnter

		#region CustomTextBox_MouseLeave
		private void CustomTextBox_MouseLeave(object sender, System.EventArgs e)
		{
			if (_focus)
			{
				if (_styleTextBox == Style.Default)
				{
					DefaultBorderColor(_borderColorFocus);
				}
				else if (_styleTextBox == Style.MaterialStyle)
				{
					MaterialBorderColor(_borderColorFocus);
				}
			}
			else
			{
				if (_styleTextBox == Style.Default)
				{
					DefaultBorderColor(_borderColorIdle);
				}
				else if (_styleTextBox == Style.MaterialStyle)
				{
					MaterialBorderColor(_borderColorIdle);
				}
			}

		}
		#endregion /CustomTextBox_MouseLeave

		#region CustomTextBox_Resize
		private void CustomTextBox_Resize(object sender, System.EventArgs e)
		{
			if (this.Height < 35)
			{
				this.Height = 35;
			}
			if (this.Width < 100)
			{
				this.Width = 100;
			}
		}
		#endregion /CustomTextBox_Resize

		#region CustomTextBox_RightToLeftChanged
		private void CustomTextBox_RightToLeftChanged(object sender, System.EventArgs e)
		{
			_inputTextBox.RightToLeft = this.RightToLeft;
			_captionLabel.RightToLeft = this.RightToLeft;

			StatusControls();

		}
		#endregion /CustomTextBox_RightToLeftChanged

		//----------------------------------------------------

		#region CaptionLabel_Click
		private void CaptionLabel_Click(object sender, System.EventArgs e)
		{
			_focus = true;
			_inputTextBox.Focus();

			if (_styleTextBox == Style.Default)
			{
				DefaultBorderColor(_borderColorFocus);
			}
			else if (_styleTextBox == Style.MaterialStyle)
			{
				MaterialBorderColor(_borderColorFocus);
			}
		}
		#endregion /CaptionLabel_Click

		#region CaptionLabel_MouseEnter
		private void CaptionLabel_MouseEnter(object sender, System.EventArgs e)
		{
			if (_styleTextBox == Style.Default)
			{
				DefaultBorderColor(_borderColorHover);
			}
			else if (_styleTextBox == Style.MaterialStyle)
			{
				MaterialBorderColor(_borderColorHover);
			}
		}
		#endregion /CaptionLabel_MouseEnter

		#region CaptionLabel_MouseLeave
		private void CaptionLabel_MouseLeave(object sender, System.EventArgs e)
		{
			if (_focus)
			{
				if (_styleTextBox == Style.Default)
				{
					DefaultBorderColor(_borderColorFocus);
				}
				else if (_styleTextBox == Style.MaterialStyle)
				{
					MaterialBorderColor(_borderColorFocus);
				}
			}
			else
			{
				if (_styleTextBox == Style.Default)
				{
					DefaultBorderColor(_borderColorIdle);
				}
				else if (_styleTextBox == Style.MaterialStyle)
				{
					MaterialBorderColor(_borderColorIdle);
				}
			}
		}
		#endregion /CaptionLabel_MouseLeave

		//----------------------------------------------------

		#region InputBox_KeyPress
		public void InputBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (TypeWriteLanguage == TypeWrite.English)
			{
				if ((e.KeyChar > 'آ' && e.KeyChar <= 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
				{
					e.Handled = true;
				}
				return;
			}
		}
		#endregion /InputBox_KeyPress

		#region InputTextBox_Enter
		private void InputTextBox_Enter(object sender, System.EventArgs e)
		{
			_focus = true;

			if (_styleTextBox == Style.Default)
			{
				DefaultBorderColor(_borderColorFocus);
			}
			else if (_styleTextBox == Style.MaterialStyle)
			{
				MaterialBorderColor(_borderColorFocus);
			}
		}
		#endregion /InputTextBox_Enter

		#region InputTextBox_Leave
		private void InputTextBox_Leave(object sender, System.EventArgs e)
		{
			_focus = false;
			if (_styleTextBox == Style.Default)
			{
				DefaultBorderColor(_borderColorIdle);
			}
			else if (_styleTextBox == Style.MaterialStyle)
			{
				MaterialBorderColor(_borderColorIdle);
			}
		}
		#endregion /InputTextBox_Leave

		#region InputTextBox_MouseEnter
		private void InputTextBox_MouseEnter(object sender, System.EventArgs e)
		{

			if (_styleTextBox == Style.Default)
			{
				DefaultBorderColor(_borderColorHover);
			}
			else if (_styleTextBox == Style.MaterialStyle)
			{
				MaterialBorderColor(_borderColorHover);
			}
		}
		#endregion /InputTextBox_MouseEnter

		#region InputTextBox_MouseLeave
		private void InputTextBox_MouseLeave(object sender, System.EventArgs e)
		{
			if (_focus)
			{
				if (_styleTextBox == Style.Default)
				{
					DefaultBorderColor(_borderColorFocus);
				}
				else if (_styleTextBox == Style.MaterialStyle)
				{
					MaterialBorderColor(_borderColorFocus);
				}
			}
			else
			{
				if (_styleTextBox == Style.Default)
				{
					DefaultBorderColor(_borderColorIdle);
				}
				else if (_styleTextBox == Style.MaterialStyle)
				{
					MaterialBorderColor(_borderColorIdle);
				}
			}
		}
		#endregion /InputTextBox_MouseLeave

		#region InputBox_TextChanged
		public void InputBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(_inputTextBox.Text))
			{
				GetCaption(Caption);
			}
			else
			{
				this.Controls.Remove(_captionLabel);
			}
		}
		#endregion /InputBox_TextChanged


		#region IcoLeft_MouseDown
		private void IconLeftBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (IconLeftMousDown == null)
			{
				return;
			}
			else
			{
				_iconLeftBox.Image = IconLeftMousDown;
			}
		}
		#endregion /IcoLeft_MouseDown

		#region IconLeftBox_MouseUp
		private void IconLeftBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (IconLeftMousUp == null)
			{
				return;
			}
			else
			{
				_iconLeftBox.Image = IconLeftMousUp;
			}
		}
		#endregion /IconLeftBox_MouseUp

		#region IconLeftBox_MouseClick
		private void IconLeftBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (IconLeftMousClick == null)
			{
				return;
			}
			else
			{

			}
		}
		#endregion /IconLeftBox_MouseClick















		#region Override_Methods
		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);
		}
		protected override void OnResize(System.EventArgs e)
		{
			base.OnResize(e);
			
		}
		#endregion /Override_Methods



		//----------------------------------------------------   Privat Methods

		

		#region Clear
		public void Clear()
		{
			this.Text = string.Empty;
		}
		#endregion /Clear

		#region RemoveIconLeft
		private void RemoveIconLeft()
		{
			_iconLeftActive = false;
			this.Controls.Remove(_iconLeftBox);

			if (this.Controls.Contains(_iconRightBox))
			{
				_captionLabel.Location = _inputTextBox.Location = new System.Drawing.Point(x: _iconLeftBox.Location.X + 26, y: 9);
				_captionLabel.Width = _inputTextBox.Width = (_inputTextBox.Width - (_iconLeftBox.Width - 3));
			}
			else
			{
				_captionLabel.Location =_inputTextBox.Location = new System.Drawing.Point(x: 10, y: 9);
				_captionLabel.Width = _inputTextBox.Width = 230;
			}
		}
		#endregion /RemoveIconLeft

		#region RemoveIconRight
		private void RemoveIconRight()
		{
			_iconRightActive = false;
			this.Controls.Remove(_iconRightBox);
			_inputTextBox.Width += 52;

			if (this.Controls.Contains(_iconLeftBox))
			{
				_captionLabel.Location = _inputTextBox.Location = new System.Drawing.Point(x: _iconRightBox.Location.X + 26, y: 9);

				_captionLabel.Width =_inputTextBox.Width += 33 ;
			}
			else
			{
				_captionLabel.Location = _inputTextBox.Location = new System.Drawing.Point(x: 10, y: 9);
				_captionLabel.Width = _inputTextBox.Width += 230;
			}
		}
		#endregion /RemoveIconRight

		#region DefaultBorderColor
		private void DefaultBorderColor(System.Drawing.Color borderColor)
		{
			TopBorder.BackColor = borderColor;
			LeftBorder.BackColor = borderColor;
			RightBorder.BackColor = borderColor;
			BottomBorder.BackColor = borderColor;
		}
		#endregion /DefaultBorderColor

		#region DefaultBorderStyle
		private void DefaultBorderStyle()
		{
			this.Controls.Add(TopBorder);
			TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
			TopBorder.Height = BorderThickness;
			TopBorder.BackColor = BorderColorIdle;

			this.Controls.Add(LeftBorder);
			LeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
			LeftBorder.Width = BorderThickness;
			LeftBorder.BackColor = BorderColorIdle;

			this.Controls.Add(RightBorder);
			RightBorder.Dock = System.Windows.Forms.DockStyle.Right;
			RightBorder.Width = BorderThickness;
			RightBorder.BackColor = BorderColorIdle;

			this.Controls.Add(BottomBorder);
			BottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			BottomBorder.Height = BorderThickness;
			BottomBorder.BackColor = BorderColorIdle;
		}
		#endregion /DefaultBorderStyle

		#region DefaultBorderThickness
		private void DefaultBorderThickness(int borderThickness)
		{
			TopBorder.Height = borderThickness;
			LeftBorder.Width = borderThickness;
			RightBorder.Width = borderThickness;
			BottomBorder.Height = borderThickness;
		}
		#endregion /DefaultBorderThickness

		#region DefaultBorderRemove
		private void DefaultBorderRemove()
		{
			this.Controls.Remove(TopBorder);
			this.Controls.Remove(LeftBorder);
			this.Controls.Remove(RightBorder);
			this.Controls.Remove(BottomBorder);
		}
		#endregion /DefaultBorderRemove

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

		#region GetCaption
		private void GetCaption(string watermark)
		{
			if (string.IsNullOrEmpty(base.Text))
			{
				this.Controls.Add(_captionLabel);
                _captionLabel.BringToFront();
                _captionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
                _captionLabel.AutoSize = false;
                _captionLabel.Size = _inputTextBox.Size;
                _captionLabel.Text = watermark;
                _captionLabel.TextAlign = ContentAlignment.TopLeft;
                _captionLabel.Location = _inputTextBox.Location;
                _captionLabel.ForeColor = CaptionForeColor;
                _captionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			}
			else
			{
				this.Controls.Remove(_captionLabel);
			}

			_captionLabel.ForeColor = CaptionForeColor;
		}
		#endregion /GetCaption

		#region GetIconLeft
		private void GetIconLeft(int size, System.Drawing.Point location, System.Drawing.Image icon)
		{
			_iconLeftActive = true;
			if (this.Controls.Contains(_iconLeftBox))
			{
				_iconLeftBox.Image = icon;
				return;
			}
			else
			{
				this.Controls.Add(_iconLeftBox);
				_iconLeftBox.BringToFront();
				_iconLeftBox.Location = new System.Drawing.Point(x: 8, y: 7);
				_iconLeftBox.Size = new System.Drawing.Size(width: size, height: size);
				_iconLeftBox.Image = icon;
				_iconLeftBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
				_captionLabel.Location = _inputTextBox.Location = new System.Drawing.Point(x: _iconLeftBox.Location.X + 26, y: 9);
				_captionLabel.Width = _inputTextBox.Width = (_inputTextBox.Width - (_iconLeftBox.Width - 3));
			}
		}
		#endregion GetIconLeft

		#region GetIconRight
		private void GetIconRight(int size, System.Drawing.Point location, System.Drawing.Image icon)
		{
			_iconRightActive = true;
			if (this.Controls.Contains(_iconRightBox))
			{
				_iconRightBox.Image = icon;
				return;
			}
			else
			{
				this.Controls.Add(_iconRightBox);
				_iconRightBox.BringToFront();
				_iconRightBox.Location = new System.Drawing.Point(x: 222, y: 7);
				_iconRightBox.Size = new System.Drawing.Size(width: size, height: size);
				_iconRightBox.Image = icon;
				_iconRightBox.Anchor = (System.Windows.Forms.AnchorStyles.Right);

				_captionLabel.Width = _inputTextBox.Width = (_inputTextBox.Width - (_iconRightBox.Width - 3));
			}
			
		}
		#endregion /GetIconRight

		#region GetInputTextBox
		private void GetInputTextBox()
		{
			this.Controls.Add(_inputTextBox);
			_inputTextBox.SendToBack();
			_inputTextBox.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			_inputTextBox.Multiline = false;
			_inputTextBox.Location = new System.Drawing.Point(x: 10, y: 9);
			_inputTextBox.Size = new System.Drawing.Size(width: 230, height: 17);
			_inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
		}
		#endregion /GetInputTextBox

		#region MaterialBorderColor
		private void MaterialBorderColor(System.Drawing.Color borderColor)
		{
			MaterialBorder.BackColor = borderColor;
		}
		#endregion /MaterialBorderColor

		#region MaterialBorderStyle
		private void MaterialBorderStyle()
		{
			this.Controls.Add(MaterialBorder);
			MaterialBorder.BackColor = BorderColorIdle;
			MaterialBorder.Height = BorderThickness;
		}
		#endregion /MaterialBorderStyle

		#region MaterialBorderThickness
		private void MaterialBorderThickness(int borderThickness)
		{
			MaterialBorder.Height = borderThickness;
		}
		#endregion /MaterialBorderThickness

		#region MaterialBorderRemove
		private void MaterialBorderRemove()
		{
			this.Controls.Remove(MaterialBorder);
		}
		#endregion /MaterialBorderRemove

		#region PersianLanguage
		/// <summary>
		/// Function to change English to Persian
		/// </summary>
		public static void PersianLanguage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture =
				new System.Globalization.CultureInfo("fa-ir");

			System.Threading.Thread.CurrentThread.CurrentUICulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			System.Windows.Forms.InputLanguage.CurrentInputLanguage =
				System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("fa-ir"));
		}






		#endregion /PersianLanguage

		#region StatusControls
		private void StatusControls()
		{
			System.Windows.Forms.MessageBox.Show($"InputBox Width is: {_inputTextBox.Width}" +
				$"\nCaptionLabel Width is: {_captionLabel.Width}" +
				$"\nInputBox Position X is: {_inputTextBox.Location.X}" +
				$"\nInputBox Position Y is: {_inputTextBox.Location.Y}" +
				$"\nCaptionLabel Location X is: {_captionLabel.Location.X}" +
				$"\nCaptionLabel Location X is: {_captionLabel.Location.Y}");
		}
		#endregion /StatusControls










	}
}

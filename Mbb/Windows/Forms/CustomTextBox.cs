using System.ComponentModel.Design;

namespace Mbb.Windows.Forms
{
	public partial class CustomTextBox : System.Windows.Forms.UserControl
	{
		#region Properties

		#region CotrolsLayer
		private System.Windows.Forms.TextBox InputBox = new System.Windows.Forms.TextBox { BorderStyle = System.Windows.Forms.BorderStyle.None, BackColor = default, };
		private System.Windows.Forms.Label WaterMarkLabel = new System.Windows.Forms.Label { BackColor = default, };
		private System.Windows.Forms.Panel MaterialBorder = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Bottom, };

		private System.Windows.Forms.Panel TopBorder = new System.Windows.Forms.Panel();
		private System.Windows.Forms.Panel LeftBorder = new System.Windows.Forms.Panel();
		private System.Windows.Forms.Panel RightBorder = new System.Windows.Forms.Panel();
		private System.Windows.Forms.Panel BottomBorder = new System.Windows.Forms.Panel();


		private System.Windows.Forms.PictureBox IcoLeft = new System.Windows.Forms.PictureBox { SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };
		private System.Windows.Forms.PictureBox IcoRight = new System.Windows.Forms.PictureBox { SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom };

		#endregion /CotrolsLayer

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

				if (_styleTextBox == Style.Default)
				{
					DefaultBorderColor(_borderColorFocus);
				}
				else if (_styleTextBox == Style.MaterialStyle)
				{
					MaterialBorderColor(_borderColorFocus);
				}
			}
		}

		private System.Drawing.Color _borderColorHover = System.Drawing.Color.Silver;
		public System.Drawing.Color BorderColorHover
		{
			get { return _borderColorHover; }
			set
			{
				_borderColorHover = value;

				if (_styleTextBox == Style.Default)
				{
					DefaultBorderColor(_borderColorHover);
				}
				else if (_styleTextBox == Style.MaterialStyle)
				{
					MaterialBorderColor(_borderColorHover);
				}
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

		private System.Drawing.Image _iconLeft;
		public System.Drawing.Image IconLeft
		{
			get { return _iconLeft; }
			set
			{
				_iconLeft = value;

				if (_iconLeft != null)
				{
					CreateIconLeft(size: IconLeftSize, location: IconLeftOffset, _iconLeft);
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

				IcoLeft.Location = new System.Drawing.Point(x: _iconLeftOffset.X, y: _iconLeftOffset.Y);
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
					CreateIconRight(size: IconRightSize, location: IconRightOffset, icon: _iconRight);
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

				IcoRight.Location = new System.Drawing.Point(x: _iconRightOffset.X, y: _iconRightOffset.Y);
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

		private Style _styleTextBox = Style.Default;
		public Style StyleTextBox
		{
			get { return _styleTextBox; }
			set
			{
				if (_styleTextBox == Style.Default)
				{
					CreateTextBox();
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

				InputBox.TextAlign = _textAling;

				if (_textAling == System.Windows.Forms.HorizontalAlignment.Right)
				{
					//WaterMarkLabel.Location = new System.Drawing.Point(x: Box.Width - WaterMarkLabel.Text.Length, y: 9);
					WaterMarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
				}
				else if (_textAling == System.Windows.Forms.HorizontalAlignment.Left)
				{
					//WaterMarkLabel.Location = new System.Drawing.Point(x: 8, y: 9);
					WaterMarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				}
			}
		}

		private string _text;
		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.Editor(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string Text
		{
			get
			{
				_text = InputBox.Text;
				return _text;
			}
			set
			{
				_text = value;
				InputBox.Text = _text;

				if (string.IsNullOrEmpty(_text))
				{
					ShowWaterMark(WaterMark);
				}
				else
				{
					this.Controls.Remove(WaterMarkLabel);
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

		private string _waterMark = "Enter text";
		public string WaterMark
		{
			get
			{
				return _waterMark;
			}
			set
			{
				_waterMark = value;

				if (string.IsNullOrEmpty(_waterMark))
				{
					this.Controls.Remove(WaterMarkLabel);
				}
				else
				{
					ShowWaterMark(_waterMark);
				}
			}
		}

		private System.Drawing.Color _waterMarkColor = System.Drawing.Color.DimGray;
		public System.Drawing.Color WaterMarkColor
		{
			get
			{
				return _waterMarkColor;
			}
			set
			{
				_waterMarkColor = value;

				WaterMarkLabel.ForeColor = _waterMarkColor;
			}
		}

		#endregion /Properties

		public CustomTextBox()
		{
			InitializeComponent();
			//=============================================
			DefaultBorderStyle();
			CreateTextBox();
			ShowWaterMark(WaterMark);
			IcoLeft.MouseClick += IcoLeft_MouseClick;
			IcoLeft.MouseDown += IcoLeft_MouseDown;
			IcoLeft.MouseUp += IcoLeft_MouseUp;
			WaterMarkLabel.Click += WaterMarkLabel_Click;
			InputBox.KeyPress += InputBox_KeyPress;
			InputBox.TextChanged += InputBox_TextChanged;
		}

		#region Events

		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.Description("Occurs when the property 'Text' changes.")]
		public event System.EventHandler TextChanged;

		

		#endregion /Events

		#region CustomTextBox_Load
		private void CustomTextBox_Load(object sender, System.EventArgs e)
		{
			if (this.Controls.Contains(IcoLeft))
			{
				IcoLeft.Location = new System.Drawing.Point(x: 8, y: 7);
				InputBox.Location = new System.Drawing.Point(x: 34, y: 9);
				InputBox.Width = 200;
				WaterMarkLabel.Location = InputBox.Location;
				WaterMarkLabel.Width = InputBox.Width - 3;
			}
			else
			{
				return;
			}

			if (this.Controls.Contains(IcoRight))
			{
				IcoRight.Location = new System.Drawing.Point(x: 222, y: 7);

				InputBox.Width -= 52;
				WaterMarkLabel.Width = InputBox.Width;
			}
			else
			{
				return;
			}
		}
		#endregion /CustomTextBox_Load

		#region InputBox_TextChanged
		public void InputBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(InputBox.Text))
			{
				ShowWaterMark(WaterMark);
			}
			else
			{
				this.Controls.Remove(WaterMarkLabel);
			}
		}
		#endregion /InputBox_TextChanged

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

		#region WaterMarkLabel_Click
		private void WaterMarkLabel_Click(object sender, System.EventArgs e)
		{
			InputBox.Focus();
		}
		#endregion /WaterMarkLabel_Click

		#region IcoLeft_MouseDown
		private void IcoLeft_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (IconLeftMousDown == null)
			{
				return;
			}
			else
			{
				IcoLeft.Image = IconLeftMousDown;
			}
		}
		#endregion /IcoLeft_MouseDown

		#region IcoLeft_MouseUp
		private void IcoLeft_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (IconLeftMousUp == null)
			{
				return;
			}
			else
			{
				IcoLeft.Image = IconLeftMousUp;
			}
		}
		#endregion /IcoLeft_MouseUp

		#region IcoLeft_MouseClick
		private void IcoLeft_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (IconLeftMousClick == null)
			{
				return;
			}
			else
			{

			}
		}
		#endregion /IcoLeft_MouseClick

		#region CustomTextBox_BackColorChanged
		private void CustomTextBox_BackColorChanged(object sender, System.EventArgs e)
		{
			InputBox.BackColor = this.BackColor;
			WaterMarkLabel.BackColor = this.BackColor;
		}
		#endregion /CustomTextBox_BackColorChanged

		#region CustomTextBox_RightToLeftChanged
		private void CustomTextBox_RightToLeftChanged(object sender, System.EventArgs e)
		{
			InputBox.RightToLeft = this.RightToLeft;
			WaterMarkLabel.RightToLeft = this.RightToLeft;
		}
		#endregion /CustomTextBox_RightToLeftChanged

		#region CustomTextBox_SizeChanged
		private void CustomTextBox_SizeChanged(object sender, System.EventArgs e)
		{
			if (this.Width <= 100)
			{
				this.Width = 100;
			}
			if (this.Height <= 35)
			{
				this.Height = 35;
			}
		}
		#endregion /CustomTextBox_SizeChanged

		//----------End of code!----------

		#region CreateIconLeft
		private void CreateIconLeft(int size, System.Drawing.Point location, System.Drawing.Image icon)
		{
			this.Controls.Add(IcoLeft);
			IcoLeft.BringToFront();
			IcoLeft.Location = new System.Drawing.Point(x: 8, y: 7);
			IcoLeft.Size = new System.Drawing.Size(width: size, height: size);
			IcoLeft.Image = icon;
			IcoLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
			InputBox.Location = new System.Drawing.Point(x: 34, y: 9);
			InputBox.Width = 200;
			WaterMarkLabel.Location = InputBox.Location;
			WaterMarkLabel.Width = InputBox.Width - 3;
		}
		#endregion CreateIconLeft

		#region Clear
		public void Clear()
		{
			this.Text = string.Empty;
		}
		#endregion /Clear

		#region RemoveIconLeft
		private void RemoveIconLeft()
		{
			this.Controls.Remove(IcoLeft);
			InputBox.Location = new System.Drawing.Point(x: 8, y: 9);
			InputBox.Width = 234;
			WaterMarkLabel.Location = new System.Drawing.Point(x: 8, y: 9);
		}
		#endregion /RemoveIconLeft

		#region CreateIconRight
		private void CreateIconRight(int size, System.Drawing.Point location, System.Drawing.Image icon)
		{
			this.Controls.Add(IcoRight);
			IcoRight.BringToFront();
			IcoRight.Location = new System.Drawing.Point(x: 222, y: 7);
			IcoRight.Size = new System.Drawing.Size(width: size, height: size);
			IcoRight.Image = icon;
			IcoRight.Anchor = System.Windows.Forms.AnchorStyles.Left;

			InputBox.Width -= 52;
			WaterMarkLabel.Width = InputBox.Width;
		}
		#endregion /CreateIconRight

		#region RemoveIconRight
		private void RemoveIconRight()
		{
			this.Controls.Remove(IcoRight);
			InputBox.Width += 52;
		}
		#endregion /RemoveIconRight

		#region CreateTextBox
		private void CreateTextBox()
		{
			this.Controls.Add(InputBox);
			InputBox.SendToBack();
			InputBox.Location = new System.Drawing.Point(x: 8, y: 9);
			InputBox.Size = new System.Drawing.Size(width: 230, height: 17);
			InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			InputBox.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
		}
		#endregion /CreateTextBox

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

		#region MaterialBorderThickness
		private void MaterialBorderRemove()
		{
			this.Controls.Remove(MaterialBorder);
		}
		#endregion /MaterialBorderThickness

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

		#region ShowWaterMark
		private void ShowWaterMark(string watermark)
		{
			if (string.IsNullOrEmpty(Text))
			{
				this.Controls.Add(WaterMarkLabel);
				WaterMarkLabel.BringToFront();
				WaterMarkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
				WaterMarkLabel.AutoSize = false;
				WaterMarkLabel.Size = InputBox.Size;
				WaterMarkLabel.Text = watermark;
				WaterMarkLabel.Location = InputBox.Location;
				WaterMarkLabel.ForeColor = _waterMarkColor;
			}
			else
			{
				this.Controls.Remove(WaterMarkLabel);
			}

			WaterMarkLabel.ForeColor = WaterMarkColor;
		}
		#endregion /ShowWaterMark
	}
}

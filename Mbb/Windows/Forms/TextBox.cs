using System;

namespace Mbb.Windows.Forms
{
	public class TextBox : System.Windows.Forms.TextBox
	{
		#region Properties
		#region CotrolsLayer
		private System.Windows.Forms.Label WaterMarkLabel = new System.Windows.Forms.Label { Dock = System.Windows.Forms.DockStyle.Fill, };
		private System.Windows.Forms.Panel MaterialBorder = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Bottom, };

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

		private System.Drawing.Color _materialBorderColor = System.Drawing.Color.DimGray;
		public System.Drawing.Color MaterialBorderColor
		{
			get { return _materialBorderColor; }
			set 
			{ 
				_materialBorderColor = value;

				MaterialBorder.BackColor = _materialBorderColor;
			}
		}

		private System.Drawing.Color _materialBorderColorFocus = System.Drawing.Color.DimGray;
		public System.Drawing.Color MaterialBorderColorFocus
		{
			get { return _materialBorderColorFocus; }
			set
			{
				_materialBorderColorFocus = value;

				MaterialBorder.BackColor = _materialBorderColorFocus;
			}
		}

		private int _materialBorderHeight = 1;
		public int MaterialBorderHeight
		{
			get { return _materialBorderHeight; }
			set
			{
				_materialBorderHeight = value;

				MaterialBorder.Height = _materialBorderHeight;
			}
		}

		private System.Drawing.Color _materialBorderColorHover = System.Drawing.Color.DimGray;
		public System.Drawing.Color MaterialBorderColorHover
		{
			get { return _materialBorderColorHover; }
			set
			{
				_materialBorderColorHover = value;

				MaterialBorder.BackColor = _materialBorderColorHover;
			}
		}

		private Style _styleTextBox = Style.Default;

		public Style StyleTextBox
		{
			get { return _styleTextBox; }
			set
			{
				_styleTextBox = value;

				if (_styleTextBox == Style.Default)
				{
					this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
					this.Controls.Remove(MaterialBorder);
				}
				else if (_styleTextBox == Style.MaterialStyle)
				{
					this.BorderStyle = System.Windows.Forms.BorderStyle.None;
					ShowMaterialBorder();
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

		private string _waterMark = "Enter WaterMark";
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
					ShowWaterMark(WaterMark);
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

		public TextBox() : base()
		{

		}

		#region ShowWaterMark
		private void ShowWaterMark(string watermark)
		{
			if (string.IsNullOrEmpty(this.Text))
			{
				this.Controls.Add(WaterMarkLabel);
				WaterMarkLabel.BringToFront();
				WaterMarkLabel.AutoSize = false;
				WaterMarkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
				WaterMarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				WaterMarkLabel.Text = watermark;
				WaterMarkLabel.ForeColor = _waterMarkColor;
			}
			else
			{
				this.Controls.Remove(WaterMarkLabel);
			}

			//WaterMarkLabel.ForeColor = CaptionColor;

		}
		#endregion /ShowWaterMark



		private void ShowMaterialBorder()
		{
			this.Controls.Add(MaterialBorder);
			MaterialBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			MaterialBorder.BackColor = MaterialBorderColor;
			MaterialBorder.Height = MaterialBorderHeight;
		}

	}
}

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System;

namespace Mbb.Windows.Forms
{
	public class CircularPictureBox: PictureBox
	{
		//Fields
		private int bordrSize = 2;
		private Color borderColor1 = Color.RoyalBlue;
		private Color borderColor2 = Color.HotPink;
		private DashStyle borderLineStyle = DashStyle.Solid;
		private DashCap borderCapStyle = DashCap.Flat;
		private float gradiantAngle = 50F;

		public CircularPictureBox()
		{
			this.Size = new Size(100, 100);
			this.SizeMode = PictureBoxSizeMode.StretchImage;
		}


		//Properties
		public int BordrSize
		{
			get
			{
				return bordrSize;
			}

			set
			{
				bordrSize = value;
				this.Invalidate();
			}
		}

		public Color BorderColor1
		{
			get
			{
				return borderColor1;
			}

			set
			{
				borderColor1 = value;
				this.Invalidate();
			}
		}

		public Color BorderColor2
		{
			get
			{
				return borderColor2;
			}

			set
			{
				borderColor2 = value;
				this.Invalidate();
			}
		}

		public DashStyle BorderLineStyle
		{
			get
			{
				return borderLineStyle;
			}

			set
			{
				borderLineStyle = value;
				this.Invalidate();
			}
		}

		public DashCap BorderCapStyle
		{
			get
			{
				return borderCapStyle;
			}

			set
			{
				borderCapStyle = value;
				this.Invalidate();
			}
		}

		public float GradiantAngle
		{
			get
			{
				return gradiantAngle;
			}

			set
			{
				gradiantAngle = value;
				this.Invalidate();
			}
		}


		//Overriden Methods

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Size = new Size(this.Width, this.Width);
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			//Fields
			var graph = pe.Graphics;
			var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
			var recBorder = Rectangle.Inflate(rectContourSmooth, -bordrSize, -bordrSize);
			var smoothSize = bordrSize > 0 ? bordrSize * 3 : 3;
			using (var borderGColor = new LinearGradientBrush(recBorder, BorderColor1, BorderColor2, gradiantAngle))
			using (var pathRegion = new GraphicsPath())
			using (var penSmooth = new Pen(this.Parent.BackColor, smoothSize))
			using (var penBorder = new Pen(borderGColor, bordrSize))
			{
				penBorder.DashStyle = borderLineStyle;
				penBorder.DashCap = borderCapStyle;
				pathRegion.AddEllipse(rectContourSmooth);
				this.Region = new Region(pathRegion);
				graph.SmoothingMode = SmoothingMode.AntiAlias;


				//Drawing
				graph.DrawEllipse(penSmooth, rectContourSmooth);
				if (bordrSize > 0 )
				{
					graph.DrawEllipse(penBorder, recBorder);
				}

			}
		}
	}
}

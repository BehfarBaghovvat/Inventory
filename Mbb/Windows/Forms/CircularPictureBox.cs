using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mbb.Windows.Forms
{
	public class CircularPictureBox: System.Windows.Forms.PictureBox
	{
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs pe)
		{
			System.Drawing.Drawing2D.GraphicsPath graphics =
				new System.Drawing.Drawing2D.GraphicsPath();
			graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
			this.Region = new System.Drawing.Region(graphics);
			base.OnPaint(pe);
		}
	}
}

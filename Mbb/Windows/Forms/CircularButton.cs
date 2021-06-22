namespace Mbb.Windows.Forms
{
	public class CircularButton : System.Windows.Forms.Button
	{
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs paint)
		{
			System.Drawing.Drawing2D.GraphicsPath graphics =
				new System.Drawing.Drawing2D.GraphicsPath();
			graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
			this.Region = new System.Drawing.Region(graphics);
			base.OnPaint(paint);
		}
	}
}

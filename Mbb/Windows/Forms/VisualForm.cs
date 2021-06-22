namespace Mbb.Windows.Forms
{
	public partial class VisualForm : Form
	{
		#region        "     Properties     "

		#region Text
		private string _text;
		public string Text
		{
			get { return _text; }
			set 
			{ 
				_text = value;

				title.Text = _text;
			}
		}

		#endregion /Text

		#region TitleColor
		private System.Drawing.Color _titleColor;

		public System.Drawing.Color TitleColor
		{
			get { return _titleColor; }
			set 
			{
				_titleColor = value;
				title.ForeColor = _titleColor;
			}
		}

		#endregion /TitleColor

		#region TopLayerBackgtound
		private System.Drawing.Image _topLayerBackground;
		public System.Drawing.Image TopLayerBackgtound
		{
			get { return _topLayerBackground; }
			set 
			{
				_topLayerBackground = value;
				topLayer.BackgroundImage = _topLayerBackground;
				topLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			}
		}
		#endregion /TopLayerBackgtound

		#region UnderlineTitleColor
		private System.Drawing.Color _underlineTitleColor;
		public System.Drawing.Color UnderlineTitleColor
		{
			get { return _underlineTitleColor; }
			set
			{
				_underlineTitleColor = value;

				underlineTitle.BackColor = _underlineTitleColor;
			}
		}
		#endregion /UnderlineTitleColor
		
		

		#endregion        /"     Properties     "

		public VisualForm()
		{
			InitializeComponent();
		}

	}
}

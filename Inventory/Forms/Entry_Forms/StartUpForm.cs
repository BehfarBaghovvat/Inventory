namespace Entry_Forms
{
	public partial class StartUpForm : Infrastructure.EmptyForm
	{
		#region Properties
		private System.Random random = new System.Random(0);
		private int number;
		#endregion /Properties

		public StartUpForm()
		{
			InitializeComponent();
		}

		//----------Beginning of the code!----------

		#region StartUpForm_Load
		private void StartUpForm_Load(object sender, System.EventArgs e)
		{
			this.Opacity = 0.0;
			loadingLabel.Hide();
			showTimer.Start();
		}
		#endregion StartUpForm_Load

		#region ShowTimer_Tick
		private void ShowTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity += 0.01;

			if (this.Opacity >= 0.9)
			{
				showTimer.Stop();
				loadingTimer.Start();
				loadingLabel.Show();
			}
		}
		#endregion /ShowTimer_Tick

		#region LoadingTimer_Tick
		private void LoadingTimer_Tick(object sender, System.EventArgs e)
		{
			loadingProgressBar.Value += NumberLoadRandom();
			loadingLabel.Text = $"Loading... {loadingProgressBar.Value} % ";

			if (loadingProgressBar.Value == 100)
			{
				loadingTimer.Stop();
				counterTimer.Start();
			}
		}
		#endregion /LoadingTimer_Tick

		#region CounterTimer_Tick
		private void CounterTimer_Tick(object sender, System.EventArgs e)
		{
			counterTimer.Interval += 50;

			if (counterTimer.Interval == 150)
			{
				counterTimer.Stop();
				hideTimer.Start();
			}
		}
		#endregion /CounterTimer_Tick

		#region HideTimer_Tick
		private void HideTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.01;

			if (this.Opacity <= 0.0)
			{
				hideTimer.Stop();
				this.Hide();
				Inventory.Program.SingInLoaded();
			}
		}
		#endregion /HideTimer_Tick

		//----------End of code!----------

		#region Founction
		//===================

		#region NumberLoadRandom
		public int NumberLoadRandom()
		{
			for (int i = 1; i <= 100; i++)
			{
				number = random.Next(4);
			}
			return number;
		}

		#endregion /NumberLoadRandom

		//===================
		#endregion /Founction
	}
}

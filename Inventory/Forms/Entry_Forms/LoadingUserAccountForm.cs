

namespace Entry_Forms
{
	public partial class LoadingUserAccountForm : Infrastructure.EmptyForm
	{
		#region Properties
		private int[] targetColor1 = { 255, 255, 255 }; //----The desired color is Blue.
		private int[] targetColor2 = { 64, 64, 64 };
		private int[] targetColor3 = { 0, 41, 49 };
		private int[] fadeColor1 = new int[3];
		private int[] fadeColor2 = new int[3];
		private int[] fadeColor3 = new int[3];
		private int number;

		private System.Random random = new System.Random(0);

		public int Hour { get; private set; }
		public string Message { get; set; }
		#endregion /Properties

		public LoadingUserAccountForm()
		{
			InitializeComponent();
		}

		//----------Beginning of the code!----------

		#region LoadingUserAccountForm_Load
		private void LoadingUserAccountForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
			this.Opacity = 0.0;
			fadeInTimer.Start();
		}
		#endregion /LoadingUserAccountForm_Load

		#region FadeInTimer_Tick
		private void FadeInTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity += 0.01;

			if (this.Opacity >= 0.9)
			{
				fadeInTimer.Stop();
				fadeWelcomTitleTimer.Start();
			}
		}
		#endregion /FadeInTimer_Tick

		#region FadeOutTimer_Tick
		private void FadeOutTimer_Tick(object sender, System.EventArgs e)
		{
			FadeOut();
		}
		#endregion /FadeOutTimer_Tick

		#region ProgressTimer_Tick
		private void ProgressTimer_Tick(object sender, System.EventArgs e)
		{
			loaderProgressBar.Value += NumberLoadRandom();

			if (loaderProgressBar.Value > 0)
			{
				loadPercentLabel.Visible = true;
				loadingMessageLabel.Visible = true;
			}

			loadPercentLabel.Text = $"Loading {loaderProgressBar.Value}%";
			if (loaderProgressBar.Value == 100)
			{
				progressTimer.Stop();
				fadeOutTimer.Start();
			}
		}
		#endregion /ProgressTimer_Tick

		#region FadeLoadingTimer_Tick
		private void FadeLoadingPanelTimer_Tick(object sender, System.EventArgs e)
		{
			FadeInLoadingPanle();
		}
		#endregion /FadeLoadingTimer_Tick

		#region FadeMessageTitleTimer_Tick
		private void FadeMessageTitleTimer_Tick(object sender, System.EventArgs e)
		{
			FadeInMessageLabel();
		}
		#endregion /FadeMessageTitleTimer_Tick

		#region FadeWelcomTitleTimer_Tick
		private void FadeWelcomTitleTimer_Tick(object sender, System.EventArgs e)
		{
			FadeInWelcomeLabel();
		}
		#endregion /FadeWelcomTitleTimer_Tick

		//----------End of code!----------

		#region Founction
		//-----
		#region DayDivision
		private string DayDivision()
		{
			Hour = System.DateTime.Now.Hour;
			string message = null;
			if (Hour >= 00 && Hour < 04)
			{
				message = "بامداد بخیر";
			}
			else if (Hour >= 04 && Hour < 10)
			{
				message = "صبح بخیر";
			}
			else if (Hour >= 10 && Hour < 12)
			{
				message = "روز بخیر";
			}
			else if (Hour >= 12 && Hour < 16)
			{
				message = "ظهر بخیر";
			}
			else if (Hour >= 16 && Hour < 19)
			{
				message = "عصر بخیر";
			}
			else if (Hour >= 19 && Hour <= 23)
			{
				message = "شب بخیر";
			}

			return message;
		}
		#endregion /DayDivision

		#region Initialize
		public void Initialize()
		{
			string name =
				$"{Inventory.Program.UserAuthentication.Full_Name}";

			if (string.IsNullOrWhiteSpace(name))
			{
				name =
					$"{Inventory.Program.UserAuthentication.Username}";
			}
			messageBoxLabel.Text = $"{DayDivision()} {name.Trim()}";

			var byteImage =
				Inventory.Program.UserAuthentication.User_Image;

			if (byteImage != null)
			{
				using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
				{
					userImagePictureBox.Image = System.Drawing.Image.FromStream(ms);
				}
			}
			else
			{
				return;
			}
		}
		#endregion /Initialize

		#region FadeInMessageBoxLabel
		private void FadeInWelcomeLabel()
		{
			fadeColor1[0] = welcomeMessageLabel.ForeColor.R;
			fadeColor1[1] = welcomeMessageLabel.ForeColor.G;
			fadeColor1[2] = welcomeMessageLabel.ForeColor.B;

			if (fadeColor1[0] > targetColor1[0])
				fadeColor1[0]--;
			else if (fadeColor1[0] < targetColor1[0])
				fadeColor1[0]++;
			if (fadeColor1[1] > targetColor1[1])
				fadeColor1[1]--;
			else if (fadeColor1[1] < targetColor1[1])
				fadeColor1[1]++;
			if (fadeColor1[2] > targetColor1[2])
				fadeColor1[2]--;
			else if (fadeColor1[2] < targetColor1[2])
				fadeColor1[2]++;

			if (fadeColor1[1] >= 64)
			{
				fadeMessageTitleTimer.Start();
			}

			if (fadeColor1[0] == targetColor1[0] && fadeColor1[1] == targetColor1[1] && fadeColor1[2] == targetColor1[2])
			{
				fadeWelcomTitleTimer.Stop();
			}
			welcomeMessageLabel.ForeColor = System.Drawing.Color.FromArgb(fadeColor1[0], fadeColor1[1], fadeColor1[2]);

		}
		#endregion /FadeInMessageBoxLabel

		#region FadeInWelcomeMessageLabel
		private void FadeInMessageLabel()
		{
			fadeColor2[0] = messageBoxLabel.ForeColor.R;
			fadeColor2[1] = messageBoxLabel.ForeColor.G;
			fadeColor2[2] = messageBoxLabel.ForeColor.B;

			if (fadeColor2[0] > targetColor2[0])
				fadeColor2[0]--;
			else if (fadeColor2[0] < targetColor2[0])
				fadeColor2[0]++;
			if (fadeColor2[1] > targetColor2[1])
				fadeColor2[1]--;
			else if (fadeColor2[1] < targetColor2[1])
				fadeColor2[1]++;
			if (fadeColor2[2] > targetColor2[2])
				fadeColor2[2]--;
			else if (fadeColor2[2] < targetColor2[2])
				fadeColor2[2]++;

			if (fadeColor2[1] >= 64)
			{
				fadeLoadingPanelTimer.Start();
			}

			if (fadeColor2[0] == targetColor2[0] && fadeColor2[1] == targetColor2[1] && fadeColor2[2] == targetColor2[2])
			{
				fadeMessageTitleTimer.Stop();


			}
			messageBoxLabel.ForeColor = System.Drawing.Color.FromArgb(fadeColor2[0], fadeColor2[1], fadeColor2[2]);
		}
		#endregion /FadeInWelcomeMessageLabel

		#region FadeInWelcomeMessageLabel
		private void FadeInLoadingPanle()
		{
			fadeColor3[0] = loadingPanel.FillColor.R;
			fadeColor3[1] = loadingPanel.FillColor.G;
			fadeColor3[2] = loadingPanel.FillColor.B;

			if (fadeColor3[0] > targetColor3[0])
				fadeColor3[0]--;
			else if (fadeColor3[0] < targetColor3[0])
				fadeColor3[0]++;
			if (fadeColor3[1] > targetColor3[1])
				fadeColor3[1]--;
			else if (fadeColor3[1] < targetColor3[1])
				fadeColor3[1]++;
			if (fadeColor3[2] > targetColor3[2])
				fadeColor3[2]--;
			else if (fadeColor3[2] < targetColor3[2])
				fadeColor3[2]++;

			if (fadeColor3[0] == targetColor3[0] && fadeColor3[1] == targetColor3[1] && fadeColor3[2] == targetColor3[2])
			{
				fadeMessageTitleTimer.Stop();
				progressTimer.Start();
				logoPictureBox.Visible = true;
				loaderProgressBar.Visible = true;
			}
			loadingPanel.FillColor = System.Drawing.Color.FromArgb(fadeColor3[0], fadeColor3[1], fadeColor3[2]);
		}
		#endregion /FadeInWelcomeMessageLabel

		#region FadeOut
		private void FadeOut()
		{
			this.Opacity -= 0.01;

			if (this.Opacity <= 0.0)
			{
				fadeOutTimer.Stop();
				this.Dispose();
				Inventory.Program.MainFormShow();
			}
		}
		#endregion /FadeOut

		#region NumberLoadRandom
		public int NumberLoadRandom()
		{
			for (int i = 1; i <= 100; i++)
			{
				number = random.Next(3);
			}
			return number;
		}
		#endregion /NumberLoadRandom
		//-----
		#endregion /Founction

		
	}
}

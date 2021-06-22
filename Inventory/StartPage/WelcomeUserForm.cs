using System.Security.Cryptography;

namespace StartPage
{
	public partial class WelcomeUserForm : Infrastructure.BaseForm
	{
		#region Properties
		private int[] targetColor1 = { 255, 255, 255 };
		private int[] targetColor2 = { 255, 0, 255 };
		private int[] fadeColor1 = new int[3];
		private int[] fadeColor2 = new int[3];
		private int number;

		private System.Random random = new System.Random(0);

		public int Hour { get; private set; }
		public string Message { get; set; }
		#endregion /Properties

		public WelcomeUserForm()
		{
			InitializeComponent();
		}

		//-----Beginig of codes!

		#region WelcomeUserForm_Load
		private void WelcomeUserForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
			InputSettingsControls();

			loaderProgressBar.Value = 0;
			loaderProgressBar.Maximum = 100;
			this.Opacity = 0.0;
			fadeInTimer.Start();
		}
		#endregion /WelcomeUserForm_Load

		#region ProgressTimer_Tick
		private void ProgressTimer_Tick(object sender, System.EventArgs e)
		{
			loaderProgressBar.Value += NumberLoadRandom();

			if (loaderProgressBar.Value == 100)
			{
				progressTimer.Stop();
				fadeOutTimer.Start();
			}
		}
		#endregion /ProgressTimer_Tick

		#region FadeInTimer_Tick
		private void FadeInTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity += 0.05;

			if (this.Opacity >= 0.9)
			{
				fadeInTimer.Stop();
				fadeInMessageBoxLabelTimer.Start();
			}
		}
		#endregion /FadeInTimer_Tick

		#region FadeOutTimer_Tick
		private void FadeOutTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.05;

			if (this.Opacity <= 0.0)
			{
				fadeOutTimer.Stop();
				this.Close();
				Inventory.Program.PrimeShow();
			}
		}
		#endregion /FadeOutTimer_Tick

		#region FadeInMessageBoxLabelTimer_Tick
		private void FadeInMessageBoxLabelTimer_Tick(object sender, System.EventArgs e)
		{
			FadeInMessageBoxLabel();
		}
		#endregion /FadeInMessageBoxLabelTimer_Tick

		#region FadeOutWelcomeMessageLabelTimer_Tick
		private void FadeInWelcomeMessageLabelTimer_Tick(object sender, System.EventArgs e)
		{
			FadeInWelcomeMessageLabel();
		}
		#endregion /FadeOutWelcomeMessageLabelTimer_Tick

		//-----End of codes!

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
				$"{Inventory.Program.AuthenticatedUser.First_Name} {Inventory.Program.AuthenticatedUser.Last_Name}";

			if (string.IsNullOrWhiteSpace(name))
			{
				name =
					$"{Inventory.Program.AuthenticatedUser.Username}";
			}
			messageBoxLabel.Text = $"{DayDivision()} {name.Trim()}";

			var byteImage =
				Inventory.Program.AuthenticatedUser.User_Image;

			if (byteImage.Length != 0)
			{
				using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
				{
					userImagePictureBox.Image = System.Drawing.Image.FromStream(ms);
				}
			}
			else
			{
				userImagePictureBox.Image = Inventory.Properties.Resources.new_user_1080_Light_Gray;
			}
		}
		#endregion /Initialize

		#region InputSettingsControls
		private void InputSettingsControls()
		{
			userImagePictureBox.Location = new System.Drawing.Point(328, 15);
		}
		#endregion /InputSettingsControls

		#region FadeInMessageBoxLabel
		private void FadeInMessageBoxLabel()
		{
			fadeColor1[0] = messageBoxLabel.ForeColor.R;
			fadeColor1[1] = messageBoxLabel.ForeColor.G;
			fadeColor1[2] = messageBoxLabel.ForeColor.B;
			
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

			if (fadeColor1[1] == 64)
			{
				fadeInWelcomeMessageLabelTimer.Start();
			}

			if (fadeColor1[0] == targetColor1[0] && fadeColor1[1] == targetColor1[1] && fadeColor1[2] == targetColor1[2])
			{
				fadeInMessageBoxLabelTimer.Stop();
			}
			messageBoxLabel.ForeColor = System.Drawing.Color.FromArgb(fadeColor1[0], fadeColor1[1], fadeColor1[2]);

		}
		#endregion /FadeInMessageBoxLabel

		#region FadeInWelcomeMessageLabel
		private void FadeInWelcomeMessageLabel()
		{
			fadeColor2[0] = welcomeMessageLabel.ForeColor.R;
			fadeColor2[1] = welcomeMessageLabel.ForeColor.G;
			fadeColor2[2] = welcomeMessageLabel.ForeColor.B;

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

			if (fadeColor2[0] == targetColor2[0] && fadeColor2[1] == targetColor2[1] && fadeColor2[2] == targetColor2[2])
			{
				fadeInWelcomeMessageLabelTimer.Stop();
				progressTimer.Start();
			}
			welcomeMessageLabel.ForeColor = System.Drawing.Color.FromArgb(fadeColor2[0], fadeColor2[1], fadeColor2[2]);
		}
		#endregion /FadeInWelcomeMessageLabel

		#region NumberLoadRandom
		public int NumberLoadRandom()
		{
			for (int i = 1; i <= 100; i++)
			{
				number = random.Next(6);
			}
			return number;
		}
		#endregion /NumberLoadRandom
		//-----
		#endregion /Founction
	}
}

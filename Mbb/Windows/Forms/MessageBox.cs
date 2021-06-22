namespace Mbb.Windows.Forms
{
	public class MessageBox
	{
		//----------Beginning of the code!----------

		#region Show
		public static System.Windows.Forms.DialogResult Show(string text, string caption, MessageBoxIcon icon, MessageBoxButtons button )
		{
			System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.DialogResult.None;
			//----Single Button
			if (icon == MessageBoxIcon.Success && button == MessageBoxButtons.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.succes_512;
					messageBox.BackColor = System.Drawing.Color.SeaGreen;
					messageBox.OKBackColor = System.Drawing.Color.FromArgb(0, 19, 0);
					messageBox.OKName = "باشه";
					dialogResult =  messageBox.ShowDialog();
				}
			}
			else if (icon == MessageBoxIcon.Information && button == MessageBoxButtons.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.info_512;
					messageBox.BackColor = System.Drawing.Color.RoyalBlue;
					messageBox.OKBackColor = System.Drawing.Color.FromArgb(12, 128, 255);
					messageBox.OKName = "باشه";
					dialogResult = messageBox.ShowDialog();
				}
			}
			else if (icon == MessageBoxIcon.None && button == MessageBoxButtons.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.none_512;
					messageBox.BackColor = System.Drawing.Color.DarkGray;
					messageBox.OKBackColor = System.Drawing.Color.WhiteSmoke;
					messageBox.OKName = "باشه";
					dialogResult = messageBox.ShowDialog();
				}
			}
			else if (icon == MessageBoxIcon.Error && button == MessageBoxButtons.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.error_512;
					messageBox.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
					messageBox.OKBackColor = System.Drawing.Color.FromArgb(192, 64, 0);
					messageBox.OKName = "باشه";
					dialogResult = messageBox.ShowDialog();
				}
			}
			else if (icon == MessageBoxIcon.Warning && button == MessageBoxButtons.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.warning_512;
					messageBox.BackColor = System.Drawing.Color.FromArgb(251, 66, 54);
					messageBox.OKBackColor = System.Drawing.Color.FromArgb(128, 128, 255);
					messageBox.OKName = "باشه";
					dialogResult = messageBox.ShowDialog();
				}
			}

			//-----Double Buttons
			if (icon == MessageBoxIcon.Question && button == MessageBoxButtons.YesNo)
			{
				using (MessageBoxDOBForm messageBox = new MessageBoxDOBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.question_512;
					messageBox.BackColor = System.Drawing.Color.RoyalBlue;
					messageBox.YesBackColor = System.Drawing.Color.FromArgb(128, 128, 255);
					messageBox.YesName = "بله";
					messageBox.NoBackColor = System.Drawing.Color.FromArgb(128, 128, 255);
					messageBox.NoName = "خیر";
					dialogResult = messageBox.ShowDialog();
				}
			}
			else if (icon == MessageBoxIcon.Alert && button == MessageBoxButtons.YesNo)
			{
				using (MessageBoxDOBForm messageBox = new MessageBoxDOBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.alert_512px;
					messageBox.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
					messageBox.YesBackColor = System.Drawing.Color.FromArgb(192, 64, 0);
					messageBox.YesName = "بله";
					messageBox.NoBackColor = System.Drawing.Color.FromArgb(192, 64, 0);
					messageBox.NoName = "خیر";
					dialogResult = messageBox.ShowDialog();
				}
			}
			else if (icon == MessageBoxIcon.Warning && button == MessageBoxButtons.YesNo)
			{
				using (MessageBoxDOBForm messageBox = new MessageBoxDOBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.warning_512;
					messageBox.BackColor = System.Drawing.Color.FromArgb(251, 66, 54);
					messageBox.YesBackColor = System.Drawing.Color.Red;
					messageBox.YesName = "بله";
					messageBox.YesBackColor = System.Drawing.Color.Red;
					messageBox.NoName = "خیر";
					dialogResult = messageBox.ShowDialog();
				}
			}

			//-----Sobel Buttons
			return dialogResult;
		}
		#endregion /Show
	}
}

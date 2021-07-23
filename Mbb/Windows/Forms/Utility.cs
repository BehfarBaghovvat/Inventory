using System.Linq;
namespace Mbb.Windows.Forms
{
	public static class Utility
	{
		//---------------------------------------- Properties
		
		private static string[] formatEmail = new string[10];
		private static string messageEmail;
		private static string passwordSenderEmail;
		private static string registerDate;
		private static string registerTime;
		private static string senderEmail;
		private static bool status;
		private static bool TFStatus;




		//----------------------------------------Public Methods

		#region ADCalendar
		/// <summary>
		/// AD calendar with month names...
		/// </summary>
		/// <returns></returns>
		public static string ADCalendar()
		{
			string adCalendar;
			string nameMonth = string.Empty;

			System.Globalization.GregorianCalendar gregorianCalendar =
				new System.Globalization.GregorianCalendar();

			int years = gregorianCalendar.GetYear(System.DateTime.Now);
			int months = gregorianCalendar.GetMonth(System.DateTime.Now);
			int day = gregorianCalendar.GetDayOfMonth(System.DateTime.Now);

			switch (months)
			{
				case 1:
				nameMonth = "January";
				break;
				case 2:
				nameMonth = "February";
				break;
				case 3:
				nameMonth = "March";
				break;
				case 4:
				nameMonth = "April";
				break;
				case 5:
				nameMonth = "May";
				break;
				case 6:
				nameMonth = "June";
				break;
				case 7:
				nameMonth = "Julay";
				break;
				case 8:
				nameMonth = "August";
				break;
				case 9:
				nameMonth = "September";
				break;
				case 10:
				nameMonth = "October";
				break;
				case 11:
				nameMonth = "November";
				break;
				case 12:
				nameMonth = "Decemder";
				break;

				default:
				break;
			}

			adCalendar =
				nameMonth + " / " +
				day.ToString().PadLeft(2, '0') + " / " +
				years.ToString();

			return adCalendar;

		}

		#endregion /ADCalendar

		#region ADCalendar
		/// <summary>
		/// This function has an input value that is the date of your device's system.
		/// So try to keep your system up to date.
		/// </summary>
		/// <param name="dateTime"></param>
		/// <returns>Gregorian date</returns>
		public static string ADCalendar(System.DateTime dateTime)
		{
			string adCalendar;

			System.Globalization.GregorianCalendar gregorianCalendar =
				new System.Globalization.GregorianCalendar();

			int years = gregorianCalendar.GetYear(dateTime);
			int months = gregorianCalendar.GetMonth(dateTime);
			int day = gregorianCalendar.GetDayOfMonth(dateTime);

			adCalendar =
				months.ToString().PadLeft(2, '0') + " / " +
				day.ToString().PadLeft(2, '0') + " / " +
				years.ToString();

			return adCalendar;

		}
		#endregion /ADCalendar

		#region EmailChecker
		/// <summary>
		/// بررسی صحت و درستی ایمیل وارد شده توسط کاربر
		/// </summary>
		/// <param name="email"></param>
		/// <returns>A Bool value is returned to confirm the email</returns>
		public static bool EmailChecker(string email)
		{
			formatEmail[0] = ".com";
			formatEmail[1] = ".org";
			formatEmail[2] = ".ir";
			formatEmail[3] = ".net";

			if ((email).Contains("@") == true)
			{
				for (int i = 0; i < formatEmail.Length; i++)
				{
					status = email.EndsWith(formatEmail[i]);

					if (status == true)
					{
						TFStatus = status;
						break;
					}
					else if (status == false)
					{
						Mbb.Windows.Forms.MessageBox.Show
							(text: "عدم همخوانی قالب ایمیل!",
							caption: "خطای ورودی",
							icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
							button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						TFStatus = status;
						break;
					}
				}
			}
			else
			{
				Mbb.Windows.Forms.MessageBox.Show
					(text: "عدم همخوانی قالب ایمیل!",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				TFStatus = false;
			}

			return TFStatus;
		}
		#endregion /EmailChecker

		#region ExceptionShow
		public static void ExceptionShow(System.Exception ex)
		{
			Mbb.Windows.Forms.MessageBox.Show
				(text: ex.Message,
				caption: "Exception Erorr",
				icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
				button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
		}
		#endregion /ExceptionShow

		#region PasswordSet
		/// <summary>
		/// This function will be used when you want to make sure that the two passwords are correct.
		/// </summary>
		/// <param name="password"></param>
		/// <param name="passwordConfirm"></param>
		/// <returns>The return value is a boolean value</returns>
		public static bool PasswordSet(string password, string passwordConfirm)
		{
			bool statusPawword;
			if (string.Compare(password, passwordConfirm, true) == 0)
			{
				statusPawword = true;
			}
			else
			{
				statusPawword = false;
			}
			return statusPawword;
		}
		#endregion /PasswordSet

		#region PersianCalendar
		/// <summary>
		/// View Persian calendar with month names.
		/// </summary>
		/// <returns></returns>
		public static string PersianCalendar()
		{
			string farsiCalendar;
			string nameMonth = string.Empty;

			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int years = persianCalendar.GetYear(System.DateTime.Now);
			int month = persianCalendar.GetMonth(System.DateTime.Now);
			int day = persianCalendar.GetDayOfMonth(System.DateTime.Now);

			switch (month)
			{
				case 1:
				nameMonth = "فروردین";
				break;
				case 2:
				nameMonth = "اردیبهشت";
				break;
				case 3:
				nameMonth = "خرداد";
				break;
				case 4:
				nameMonth = "تیر";
				break;
				case 5:
				nameMonth = "مرداد";
				break;
				case 6:
				nameMonth = "شهریور";
				break;
				case 7:
				nameMonth = "مهر";
				break;
				case 8:
				nameMonth = "آبان";
				break;
				case 9:
				nameMonth = "آذر";
				break;
				case 10:
				nameMonth = "دی";
				break;
				case 11:
				nameMonth = "بهمن";
				break;
				case 12:
				nameMonth = "اسفند";
				break;

				default:
				break;
			}

			farsiCalendar =
				day.ToString().PadLeft(2, '0') + " / " + nameMonth + " / " + years.ToString();

			return farsiCalendar;
		}
		#endregion /PersianCalendar

		#region PersianCalendar
		/// <summary>
		/// View Persian Calendar.
		/// </summary>
		/// <param name="dateTime">Calendar entry</param>
		/// <returns></returns>
		public static string PersianCalendar(System.DateTime dateTime)
		{
			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(dateTime);
			int month = persianCalendar.GetMonth(dateTime);
			int day = persianCalendar.GetDayOfMonth(dateTime);

			string showCalendar =
				year.ToString() + "/" +
				month.ToString().PadLeft(2, '0') + "/" +
				day.ToString().PadLeft(2, '0');

			return showCalendar;
		}
		#endregion / PersianCalendar

		#region RegisterAccount
		/// <summary>
		/// Registration of user information to be entered in the system.
		/// </summary>
		/// <param name="userAccount"></param>
		/// <returns></returns>
		public static bool RegisterAccount(Models.User userAccount)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Windows.Forms.DialogResult dialogResult;
				string message = $"نام کاربری {userAccount.Username} ذخیره گردد؟.";

				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: message,
						caption: "ذخیره اطلاعات",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
						button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.User user =
								dataBaseContext.Users
								.Where(current => string.Compare(current.Username, userAccount.Username) == 0)
								.FirstOrDefault();

					if (user != null)
					{
						Mbb.Windows.Forms.MessageBox.Show
						(text: $"نام کاربری {userAccount.Username} در سیستم موجود میباشد. لطفا از نام دیگری استفاده نمایید.",
						caption: "اطلاعات مشابه",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Information,
						button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						return false;
					}
					else
					{
						registerDate = Utility.PersianCalendar(System.DateTime.Now);
						registerTime = Utility.ShowTime();

						user =
							new Models.User
							{
								Is_Active = userAccount.Is_Active,
								Access_Level = userAccount.Access_Level,
								Username = userAccount.Username,
								Password = userAccount.Password,
								Full_Name = userAccount.Full_Name,
								Registration_Date = userAccount.Registration_Date,
								Registration_Time = userAccount.Registration_Time,
								User_Image = userAccount.User_Image,
							};

						dataBaseContext.Users.Add(user);
						dataBaseContext.SaveChanges();

						return true;
					}
				}
				else
				{
					return false;
				}
			}
			catch (System.Exception ex)
			{
				ExceptionShow(ex);
				return false;
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /RegisterAccount

		#region SendSecurityCode
		/// <summary>
		/// با این تابع شما میتوانید یک کد امنیتی به ایمیل کاربر ارسال نمایید
		/// </summary>
		/// <param name="securityCode"></param>
		/// <param name="recipientEmail"></param>
		/// <returns></returns>
		public static bool SendSecurityCode(string securityCode, string recipientEmail)
		{
			try
			{
				System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();

				senderEmail = "setnewcode@gmail.com";
				passwordSenderEmail = "B@9#077a+";
				messageEmail =
					$"کد تغییر رمز عبور {securityCode} میباشد. \n اگر این ایمیل برای شما نمیباشد. \n لطفا این ایمیل را نادیده بگیرید.";

				mailMessage.From = new System.Net.Mail.MailAddress(senderEmail);
				mailMessage.To.Add(recipientEmail);
				mailMessage.Subject = "Reset Password";
				mailMessage.Body = messageEmail;
				mailMessage.IsBodyHtml = true;

				System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
				smtp.EnableSsl = true;
				smtp.Port = 587;
				smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
				smtp.Credentials = new System.Net.NetworkCredential(senderEmail, passwordSenderEmail);
				smtp.Send(message: mailMessage);

				MessageBox.Show(text: "کد به پست الکترونیک شما ارسال گردید.\n لطفا پست الکترونیک خود را بررسی نمایید",
					caption: "ارسال کد امنیتی", icon: MessageBoxIcon.Information, button: MessageBoxButtons.Ok);
				return true;
			}
			catch (System.Exception ex)
			{
				ExceptionShow(ex);
				return false;
			}
		}
		#endregion /SendSecurityCode

		#region ShowTime
		/// <summary>
		/// A function that displays the clock.
		/// </summary>
		/// <returns>The device's system clock output</returns>
		public static string ShowTime()
		{
			string timeNow =
				System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8);

			return timeNow;
		}
		#endregion /ShowTime

		#region ShowTime
		/// <summary>
		/// Function for displaying time with display format.
		/// </summary>
		/// <returns>The device's system clock output</returns>
		public static string ShowTime(string format)
		{
			string timeNow =
				System.DateTime.Now.ToString(format);

			return timeNow;
		}
		#endregion /ShowTime

		//#region WindowsNotification
		///// <summary>
		///// A nice notification to display short messages that have three inputs.
		///// Message, Caption and Picture
		///// </summary>
		///// <param name="message"></param>
		///// <param name="caption"></param>
		///// <param name="picture">Photo input is an array of bytes</param>
		//public static void POPUPNotification(string message, PopupNotificationForm.Caption caption, byte[] picture)
		//{
		//	PopupNotificationForm popupNotification =
		//		new PopupNotificationForm();

		//	popupNotification.ShowAlert(message: message, caption: caption, picture: picture);
		//}
		//#endregion /WindowsNotification

		//#region WindowsNotification
		///// <summary>
		///// A nice notification to display short messages that have three inputs.
		///// Message, Caption and Picture
		///// </summary>
		///// <param name="message"></param>
		///// <param name="caption"></param>
		///// <param name="picture"></param>
		//public static void POPUPNotification(string message, PopupNotificationForm.Caption caption, string picture)
		//{
		//	PopupNotificationForm popupNotification =
		//		new PopupNotificationForm();

		//	popupNotification.ShowAlert(message: message, caption: caption, picture: picture);
		//}
		//#endregion /WindowsNotification

		//#region WindowsNotification
		///// <summary>
		///// A nice notification to display short messages that have three inputs.
		///// Message and Caption.
		///// </summary>
		///// <param name="message"></param>
		///// <param name="caption"></param>
		//public static void POPUPNotification(string message, Infrastructure.PopupNotificationForm.Caption caption)
		//{
		//	Infrastructure.PopupNotificationForm popupNotification =
		//		new Infrastructure.PopupNotificationForm();

		//	popupNotification.ShowAlert(message: message, caption: caption);
		//}
		//#endregion /WindowsNotification
	}
}

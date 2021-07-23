using System.Linq;

namespace Infrastructure
{
	public class Utility
	{
		#region Properties
		//====================

		private static string[] formatEmail1 = new string[4];
		
		private static string registerDate;
		private static string registerTime;
		private static bool Status { get; set; }
		private static bool TrueStatus { get; set; }
		//====================
		#endregion /Properties

		public Utility() : base()
		{

		}

		//----------Beginning of the code!----------

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

		#region BlackColor
		/// <summary>
		/// This function returns a color.
		/// </summary>
		/// <returns>BlackColor Color</returns>
		public static System.Drawing.Color BlackColor()
		{
			System.Drawing.Color color = System.Drawing.Color.Black;

			return color;
		}
		#endregion /BlackColor

		#region CenturyGothicFont
		/// <summary>
		/// This function returns one font.
		/// </summary>
		/// <param name="emSize"></param>
		/// <returns>CenturyGothic Font</returns>
		public static System.Drawing.Font CenturyGothicFont(float emSize)
		{
			System.Drawing.Font font = new System.Drawing.Font(familyName: "Century Gothic", emSize: emSize);
			return font;
		}
		#endregion /CenturyGothicFont

		#region DarkOrchidColor
		/// <summary>
		/// This function returns a color.
		/// </summary>
		/// <returns>DarkOrchid Color</returns>
		public static System.Drawing.Color DarkOrchidColor()
		{
			System.Drawing.Color color = System.Drawing.Color.DarkOrchid;

			return color;
		}
		#endregion /DarkOrchidColor

		#region DarkDimGrayColor
		/// <summary>
		/// This function returns a DarkDimGary color.
		/// </summary>
		/// <returns></returns>
		public static System.Drawing.Color DarkDimGary()
		{
			System.Drawing.Color color = System.Drawing.Color.FromArgb(64, 64, 64);
			return color;
		}
		#endregion

		#region DarkGrayColor
		/// <summary>
		/// This function returns a DarkGary color.
		/// </summary>
		/// <returns>color</returns>
		public static System.Drawing.Color DarkGrayColor()
		{
			System.Drawing.Color color = System.Drawing.Color.DarkGray;
			return color;
		}
		#endregion /DarkGrayColor

		#region DimGrayColor
		/// <summary>
		/// This function returns DimGrayColor color.
		/// </summary>
		/// <returns>DimGray Color</returns>
		public static System.Drawing.Color DimGrayColor()
		{
			System.Drawing.Color color = System.Drawing.Color.DimGray;

			return color;
		}
		#endregion /DimGrayColor

		#region EditAccount
		public static bool EditAccount(Models.User editAccount)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Windows.Forms.DialogResult dialogResult;
				string message = $"ویرایش  {editAccount.Username} انجام گردد؟.";

				dialogResult = Mbb.Windows.Forms.MessageBox.Show
					(text: message,
						caption: "ویرایش اطلاعات",
						icon: Mbb.Windows.Forms.MessageBoxIcon.Question,
						button: Mbb.Windows.Forms.MessageBoxButtons.YesNo);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.User user =
								dataBaseContext.Users
								.Where(current => string.Compare(current.Username, editAccount.Username) == 0)
								.FirstOrDefault();

					if (user != null)
					{
						user =
							new Models.User
							{
								Password = editAccount.Password,
								Full_Name = editAccount.Full_Name,
								User_Image = editAccount.User_Image,
							};
						dataBaseContext.SaveChanges();
					}
					return true;
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
		#endregion EditAccount

		#region EmailChecker1
		/// <summary>
		/// Check incoming emails.
		/// According to the defined templates, if the input email is not correct,
		/// the appropriate message will be displayed
		/// </summary>
		/// <param name="email"></param>
		/// <returns>A Bool value is returned to confirm the email</returns>
		public static bool EmailChecker1(string email)
		{
			formatEmail1[0] = ".com";
			formatEmail1[1] = ".org";
			formatEmail1[2] = ".ir";
			formatEmail1[3] = ".net";

			if ((email).Contains("@") == true)
			{
				for (int i = 0; i < formatEmail1.Length; i++)
				{
					Status = email.EndsWith(formatEmail1[i]);

					if (Status == true)
					{
						TrueStatus = Status;
						break;
					}
					else if (Status == false)
					{
						Mbb.Windows.Forms.MessageBox.Show
					(text: "عدم همخوانی قالب ایمیل!",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);
						TrueStatus = Status;
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

				TrueStatus = false;
			}

			return TrueStatus;
		}
		#endregion /EmailChecker1

		#region EmailChecker2
		/// <summary>
		/// Check incoming emails.
		/// According to the defined templates, if the input email is not correct,
		/// the appropriate message will be displayed
		/// </summary>
		/// <param name="email"></param>
		/// <returns>A Bool value is returned to confirm the email</returns>
		public static bool EmailChecker2(string email)
		{
			formatEmail1[0] = ".com";
			formatEmail1[1] = ".org";
			formatEmail1[2] = ".ir";
			formatEmail1[3] = ".net";

			if ((email).Contains("@") == true)
			{
				for (int i = 0; i < formatEmail1.Length; i++)
				{
					Status = email.EndsWith(formatEmail1[i]);

					if (Status == true)
					{
						TrueStatus = Status;
						break;
					}
					else if (Status == false)
					{
						TrueStatus = Status;
						break;
					}
				}
			}
			else
			{
				TrueStatus = false;
			}

			return TrueStatus;
		}
		#endregion /EmailChecker2

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

		#region Exit
		/// <summary>
		/// You will receive a message to exit the program.
		/// </summary>
		public static void Exit()
		{
			System.Windows.Forms.DialogResult dialogResult;

			dialogResult = System.Windows.Forms.MessageBox.Show(
				text: "آیا قصد خروج از برنامه را دارید؟",
				caption: "اطلاع",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /Exit

		#region EnglishAndNumberTyping
		/// <summary>
		/// It is a function that allows only English and numeric characters to be typed while typing.
		/// </summary>
		/// <param name="e"></param>
		public static void EnglishAndNumberTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'آ' && e.KeyChar <= 'ی'))
			{
				e.Handled = true;
			}
		}
		#endregion EnglishAndNumberTyping

		#region EnglishLanguage
		/// <summary>
		/// Function to change Persian to English
		/// </summary>
		public static void EnglishLanguage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture =
				new System.Globalization.CultureInfo("en-us");

			System.Threading.Thread.CurrentThread.CurrentUICulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			System.Windows.Forms.InputLanguage.CurrentInputLanguage =
				System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-us"));
		}
		#endregion /EnglishLanguage

		#region EnglishTyping
		/// <summary>
		/// A function used to type English
		/// </summary>
		/// <param name="e"></param>
		public static void EnglishTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'آ' && e.KeyChar <= 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
			{
				e.Handled = true;
			}
		}
		#endregion /EnglishTyping

		#region EventLog
		/// <summary>
		/// ---- تمام فعالیتهایی که توسط متصدی صورت گرفته است ثبت میگردد!
		/// </summary>
		/// <param name="username"></param>
		/// <param name="fullName"></param>
		/// <param name="eventRegisterDate"></param>
		/// <param name="eventTitle"></param>
		public static void EventLog(Models.EventLog inputEventLog)
		{
			if (string.Compare(inputEventLog.Username, "admin") == 0)//-----اگر شناسه کاربری برابر با administrator باشد یعنی در حال حاضر حساب مدیریت وارد سیستم شده
			{
				return;
			}
			else //----- در غیر این صورت سایر حسابها وارد سیستم شده اند.
			{
				Models.DataBaseContext dataBaseContext = null;
				try
				{
					dataBaseContext =
						new Models.DataBaseContext();

					Models.EventLog eventLog =
						dataBaseContext.EventLogs
						.OrderByDescending(current => current.Event_Date)
						.OrderByDescending(current => current.Event_Time)
						.FirstOrDefault();

					eventLog =
					   new Models.EventLog()
					   {
						   Username = inputEventLog.Username,
						   Full_Name = inputEventLog.Full_Name,
						   Event_Date = inputEventLog.Event_Date,
						   Event_Time = inputEventLog.Event_Time,
						   Description = inputEventLog.Description,

					   };
					dataBaseContext.EventLogs.Add(eventLog);
					dataBaseContext.SaveChanges();
				}
				catch (System.Exception ex)
				{
					Infrastructure.Utility.ExceptionShow(ex);
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
		}
		#endregion /EventLog

		#region ForestGreenColor
		/// <summary>
		/// This function returns a color.
		/// </summary>
		/// <returns>ForestGreen Color</returns>

		public static System.Drawing.Color ForestGreenColor()
		{
			System.Drawing.Color color = System.Drawing.Color.ForestGreen;

			return color;
		}
		#endregion /ForestGreenColor

		#region GeneratInvoiceSerialNumber
		/// <summary>
		/// تابعی که به تعداد 7 کاراکتر حروف و عدد به صورت تصادوفی
		///  و ترکیبی ایجاد کرده و به ما بر میگرداند.
		/// </summary>
		/// <returns>ممبر letter که حاصل دریافت ترکیبی عدد و حرف میباشد نتیجه این تابع میباشد. </returns>
		public static string GeneratInvoiceSerialNumber(int numberSection)
		{
			int count, number1, number2;

			string[] text = new string[3];
			string letter = string.Empty;

			System.Random randomCount = new System.Random();
			System.Random randomNumber = new System.Random();
			System.Random random = new System.Random();
			if (numberSection == 1)
			{
				for (int i = 1; i <= 5; i++)
				{
					count = randomCount.Next(0, 2);

					if (count == 0)
					{
						number1 = randomNumber.Next(0, 10);
						letter += number1.ToString();
					}
					else if (count == 1)
					{
						for (int k = 0; k < 1; k++)
						{
							number2 = random.Next(65, 91);
							text[k] = System.Convert.ToChar(number2).ToString();
							letter += text[k];
						}
					}
				}

				for (int i = 1; i < 6; i++)
				{
					if (i % 6 == 0)
					{
						letter = letter.Insert(i - 1, "-");
					}
				}
			}

			else if (numberSection == 2)
			{
				for (int i = 1; i <= 10; i++)
				{
					count = randomCount.Next(0, 2);

					if (count == 0)
					{
						number1 = randomNumber.Next(0, 10);
						letter += number1.ToString();
					}
					else if (count == 1)
					{
						for (int k = 0; k < 1; k++)
						{
							number2 = random.Next(65, 91);
							text[k] = System.Convert.ToChar(number2).ToString();
							letter += text[k];
						}
					}
				}

				for (int i = 1; i < 11; i++)
				{
					if (i % 6 == 0)
					{
						letter = letter.Insert(i - 1, "-");
					}
				}
			}

			else if (numberSection == 3)
			{
				for (int i = 1; i <= 15; i++)
				{
					count = randomCount.Next(0, 2);

					if (count == 0)
					{
						number1 = randomNumber.Next(0, 10);
						letter += number1.ToString();
					}
					else if (count == 1)
					{
						for (int k = 0; k < 1; k++)
						{
							number2 = random.Next(65, 91);
							text[k] = System.Convert.ToChar(number2).ToString();
							letter += text[k];
						}
					}
				}

				for (int i = 1; i < 16; i++)
				{
					if (i % 6 == 0)
					{
						letter = letter.Insert(i - 1, "-");
					}
				}
			}

			else if (numberSection == 4)
			{
				for (int i = 1; i <= 20; i++)
				{
					count = randomCount.Next(0, 2);

					if (count == 0)
					{
						number1 = randomNumber.Next(0, 10);
						letter += number1.ToString();
					}
					else if (count == 1)
					{
						for (int k = 0; k < 1; k++)
						{
							number2 = random.Next(65, 91);
							text[k] = System.Convert.ToChar(number2).ToString();
							letter += text[k];
						}
					}
				}

				for (int i = 1; i < 21; i++)
				{
					if (i % 6 == 0)
					{
						letter = letter.Insert(i - 1, "-");
					}
				}
			}

			else if (numberSection >= 5)
			{
				letter = string.Empty;
			}
			return letter;

			//for (int i = 1; i <= 20; i++)
			//{
			//	count = randomCount.Next(0, 2);

			//	if (count == 0)
			//	{
			//		number1 = randomNumber.Next(0, 10);
			//		letter += number1.ToString();
			//	}
			//	else if (count == 1)
			//	{
			//		for (int k = 0; k < 1; k++)
			//		{
			//			number2 = random.Next(65, 91);
			//			text[k] = System.Convert.ToChar(number2).ToString();
			//			letter += text[k];
			//		}
			//	}
			//}

			//for (int i = 1; i < 21; i++)
			//{
			//	if (i % 6 == 0)
			//	{
			//		letter = letter.Insert(i - 1, "-");
			//	}
			//}
			//return letter;
		}
		#endregion /GeneratInvoiceSerialNumber

		#region GrayColor
		/// <summary>
		/// This function returns a color.
		/// </summary>
		/// <returns>Gray Color</returns>
		public static System.Drawing.Color GrayColor()
		{
			System.Drawing.Color color = System.Drawing.Color.Gray;

			return color;
		}
		#endregion /GrayColor

		#region InsertDcimalNumbers
		/// <summary>
		/// Function for inserting decimal numbers
		/// </summary>
		/// <param name="e"></param>
		/// <param name="text"></param>
		public static void InsertDcimalNumbers(System.Windows.Forms.KeyPressEventArgs e, string text)
		{
			char ch = e.KeyChar;

			if (ch == 47 && text.IndexOf('/') != -1)
			{
				e.Handled = true;
				return;
			}

			if (!char.IsDigit(ch) && ch != 8 && ch != 47)
			{
				e.Handled = true;
			}
		}
		#endregion /InsertDcimalNumbers

		#region InsertOnlyNumber
		/// <summary>
		/// A function used to type a Number
		/// </summary>
		/// <param name="e"></param>
		public static void InsertOnlyNumber(System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}
		#endregion /InsertOnlyNumber

		#region IranSansFont
		/// <summary>
		/// A function that returns the Persian font of Iran Sense.
		/// </summary>
		/// <param name="emSize"></param>
		/// <returns>IranSans Font</returns>
		public static System.Drawing.Font IranSansFont(float emSize)
		{
			System.Drawing.Font font = new System.Drawing.Font(familyName: "IRANSans", emSize: emSize);

			return font;
		}
		#endregion /IranSansFont

		#region LimeColor
		/// <summary>
		/// This function returns a color.
		/// </summary>
		/// <returns>Lime Color</returns>
		public static System.Drawing.Color LimeColor()
		{
			System.Drawing.Color color = System.Drawing.Color.Lime;
			return color;
		}
		#endregion /LimeColor

		#region MediumSlateBlueColor
		/// <summary>
		/// This function returns a color.
		/// </summary>
		/// <returns>MediumSlateBlue Color</returns>
		public static System.Drawing.Color MediumSlateBlueColor()
		{
			System.Drawing.Color color = System.Drawing.Color.FromArgb(128, 128, 255);

			return color;
		}
		#endregion /MediumSlateBlueColor

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

		#region Payment
		/// <summary>
		///  Calculate the cost of purchasing commodity.
		/// </summary>
		/// <param name="quatity"></param>
		/// <param name="price"></param>
		/// <returns></returns>
		public static decimal Payment(decimal quatity, decimal price)
		{
			decimal payment;

			payment = quatity * price;

			return payment;
		}
		#endregion /Payment

		#region PersianAndNumberTyping
		/// <summary>
		/// A function used to type Farsi
		/// </summary>
		/// <param name="e"></param>
		public static void PersianAndNumberTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'a' && e.KeyChar <= 'z') || (e.KeyChar > 'A' && e.KeyChar <= 'Z'))
			{
				e.Handled = true;
			}
		}
		#endregion /PersianAndNumberTyping

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

		#region PersianLanguage
		/// <summary>
		/// Function to change English to Persian
		/// </summary>
		public static void PersianLanguage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture =
				new System.Globalization.CultureInfo("fa-ir");

			System.Threading.Thread.CurrentThread.CurrentUICulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			System.Windows.Forms.InputLanguage.CurrentInputLanguage =
				System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("fa-ir"));
		}
		#endregion /PersianLanguage

		#region PersianTyping
		/// <summary>
		/// A function used to type Farsi
		/// </summary>
		/// <param name="e"></param>
		public static void PersianTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'a' && e.KeyChar <= 'z') || (e.KeyChar > 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
			{
				e.Handled = true;
			}
		}
		#endregion /PersianTyping

		#region PopupNotification
		/// <summary>
		/// A nice notification to display short messages that have three inputs.
		/// Message, Caption and Picture
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		/// <param name="picture">Photo input is an array of bytes</param>
		public static void PopupNotification(string message, PopupNotificationForm.Caption caption, byte[] picture)
		{
			PopupNotificationForm popupNotification =
				new PopupNotificationForm();

			popupNotification.ShowAlert(message: message, caption: caption, picture: picture);
		}
		#endregion /PopupNotification

		#region PopupNotification
		/// <summary>
		/// A nice notification to display short messages that have three inputs.
		/// Message, Caption and Picture
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		/// <param name="picture"></param>
		public static void PopupNotification(string message, PopupNotificationForm.Caption caption, string picture)
		{
			PopupNotificationForm popupNotification =
				new PopupNotificationForm();

			popupNotification.ShowAlert(message: message, caption: caption, picture: picture);
		}
		#endregion /PopupNotification

		#region PopupNotification
		/// <summary>
		/// A nice notification to display short messages that have three inputs.
		/// Message and Caption.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		public static void PopupNotification(string message, Infrastructure.PopupNotificationForm.Caption caption)
		{
			Infrastructure.PopupNotificationForm popupNotification =
				new Infrastructure.PopupNotificationForm();

			popupNotification.ShowAlert(message: message, caption: caption);
		}
		#endregion /PopupNotification

		#region PurpleColor
		/// <summary>
		/// This function returns a color.
		/// </summary>
		/// <returns>PurpleColor Color</returns>
		public static System.Drawing.Color PurpleColor()
		{
			System.Drawing.Color color = System.Drawing.Color.FromArgb(128, 128, 255);

			return color;
		}
		#endregion /PurpleColor

		#region RedColor
		/// <summary>
		/// This function returns a color.
		/// </summary>
		/// <returns>PurpleColor Color</returns>
		public static System.Drawing.Color RedColor()
		{
			System.Drawing.Color color = System.Drawing.Color.Red;
			return color;
		}
		#endregion /RedColor

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
						registerDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
						registerTime = Infrastructure.Utility.ShowTime();

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

		#region Segoe UI
		/// <summary>
		/// A function that returns the English font of Segoe UI.
		/// </summary>
		/// <param name="emSize"></param>
		/// <returns>Segoe UI Font</returns>
		public static System.Drawing.Font SegoeUI(float emSize)
		{
			System.Drawing.Font font = new System.Drawing.Font(familyName: "Segoe UI", emSize: emSize);

			return font;
		}
		#endregion /Segoe UI

		#region TextFixed
		/// <summary>
		/// A function that removes the excess distance of a text from both sides.
		/// </summary>
		/// <param name="text"></param>
		/// <returns>The output is a spaceless text.</returns>
		public static string TextFixed(string text)
		{
			if (text == null)
			{
				return string.Empty;
			}

			text.Trim();

			if (text == string.Empty)
			{
				return string.Empty;
			}

			while (text == "  ")
			{
				text =
					text.Replace("  ", " ");
			}
			return text;
		}
		#endregion

		#region UserCheck1
		/// <summary>
		/// This function can be used to create a username with a specific form.
		/// This function allows you to have two digits of your username.
		/// </summary>
		/// <param name="text"></param>
		/// <returns>The output value is a boolean value.</returns>
		public static bool UserCheck1(string username)
		{
			int length = username.Length;
			int num = 0;
			string[] textAray = new string[length];
			string firstValue;

			bool statusCheck;

			for (int i = 0; i <= length - 1; i++)
			{
				textAray[i] = username.Substring(i, 1);
			}

			for (int i = 0; i <= length - 1; i++)
			{
				firstValue = textAray[i];

				for (int y = 0; y <= 9; y++)
				{
					if (string.Compare(firstValue, y.ToString(), false) == 0)
					{
						num++;
					}
				}
			}

			if (num < 2)
			{
				Mbb.Windows.Forms.MessageBox.Show
					(text: "نام کاربری باید دارای حداقل 2 عدد باشد!",
					caption: "خطای ورودی",
					icon: Mbb.Windows.Forms.MessageBoxIcon.Error,
					button: Mbb.Windows.Forms.MessageBoxButtons.Ok);

				statusCheck = false;
			}
			else
			{
				statusCheck = true;
			}

			return statusCheck;
		}
		#endregion /UserCheck1

		#region UserCheck2
		/// <summary>
		/// This function can be used to create a username with a specific form.
		/// This function allows you to have two digits of your username.
		/// </summary>
		/// <param name="text"></param>
		/// <returns>The output value is a boolean value.</returns>
		public static bool UserCheck2(string username)
		{
			int length = username.Length;
			int num = 0;
			string[] textAray = new string[length];
			string firstValue;

			bool statusCheck;

			for (int i = 0; i <= length - 1; i++)
			{
				textAray[i] = username.Substring(i, 1);
			}

			for (int i = 0; i <= length - 1; i++)
			{
				firstValue = textAray[i];

				for (int y = 0; y <= 9; y++)
				{
					if (string.Compare(firstValue, y.ToString(), false) == 0)
					{
						num++;
					}
				}
			}

			if (num < 2)
			{
				statusCheck = false;
			}
			else
			{
				statusCheck = true;
			}

			return statusCheck;
		}
		#endregion /UserCheck2

		#region SaveLogOutTime
		public static void SaveLogOutTime(Models.LoginHistory log)
		{
			string logOutTime = null;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.LoginHistory logHistory =
					dataBaseContext.LoginHistories
					.Where(current => string.Compare(current.Username, log.Username) == 0)
					.OrderByDescending(current => current.Login_Time)
					.SingleOrDefault(current => current.Id == log.Id);

				if (logHistory != null)
				{
					logOutTime = $"{Infrastructure.Utility.ShowTime()}" +
						$"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} ";

					logHistory.Logout_Time = logOutTime;

					dataBaseContext.SaveChanges();
				}
				else
				{
					return;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
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
		#endregion /SaveLogOutTime

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

		#region WindowsNotification
		/// <summary>
		/// A nice notification to display short messages that have three inputs.
		/// Message, Caption and Picture
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		/// <param name="picture">Photo input is an array of bytes</param>
		public static void WindowsNotification(string message, PopupNotificationForm.Caption caption, byte[] picture)
		{
			PopupNotificationForm popupNotification =
				new PopupNotificationForm();

			popupNotification.ShowAlert(message: message, caption: caption, picture: picture);
		}
		#endregion /WindowsNotification

		#region WindowsNotification
		/// <summary>
		/// A nice notification to display short messages that have three inputs.
		/// Message, Caption and Picture
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		/// <param name="picture"></param>
		public static void WindowsNotification(string message, PopupNotificationForm.Caption caption, string picture)
		{
			PopupNotificationForm popupNotification =
				new PopupNotificationForm();

			popupNotification.ShowAlert(message: message, caption: caption, picture: picture);
		}
		#endregion /WindowsNotification

		#region WindowsNotification
		/// <summary>
		/// A nice notification to display short messages that have three inputs.
		/// Message and Caption.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		public static void WindowsNotification(string message, Infrastructure.PopupNotificationForm.Caption caption)
		{
			Infrastructure.PopupNotificationForm popupNotification =
				new Infrastructure.PopupNotificationForm();

			popupNotification.ShowAlert(message: message, caption: caption);
		}
		#endregion /WindowsNotification

		#region WhiteColor
		/// <summary>
		/// This function returns a color.
		/// </summary>
		/// <returns>White Color</returns>
		public static System.Drawing.Color WhiteColor()
		{
			System.Drawing.Color color = System.Drawing.Color.White;
			return color;
		}
		#endregion /WhiteColor
	}
}

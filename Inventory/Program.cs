using System.Linq;

namespace Inventory
{
	static class Program
	{
		public static Models.User UserAuthentication { get; set; }
		public static Models.LoginHistory SavaLogHistory { get; set; }

		//------------------------------------------------------------------

		#region Administrator
		/// <summary>
		/// ثبت خودکار کاربر ادمین در صورت حذف دیتابیس
		/// </summary>
		private static void Administrator()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string adminPic = System.IO.Directory.GetCurrentDirectory() + "\\Administrator.png";

				Models.User adminUser =
					dataBaseContext.Users
					.Where(current => string.Compare(current.Username, "admin", true) == 0)
					.FirstOrDefault();

				if (adminUser == null)
				{
					adminUser =
						new Models.User
						{
							Is_Active = true,
							Access_Level = Models.User.AccessLeve.مدیریت,
							Username = "admin",
							Password = "admin",
							User_Image = System.IO.File.ReadAllBytes(adminPic),
							Full_Name = "Administrator",
							Registration_Time = null,
							Registration_Date = null,
							Edit_Time = null,
							Edit_Date = null,
						};
					dataBaseContext.Users.Add(adminUser);
				}
				else
				{
					if (adminUser.Is_Active == false)
					{
						adminUser.Is_Active = true;
					}
					if (adminUser.Access_Level != Models.User.AccessLeve.مدیریت)
					{
						adminUser.Access_Level = Models.User.AccessLeve.مدیریت;
					}
				}
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
		#endregion /Administrator

		#region InitialAmountCapital
		/// <summary>
		/// ثبت خودکار مبلغ اولیه 0 در صورت حذف دیتابیس
		/// </summary>
		private static void InitialAmountCapital()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.CapitalFund capitalFund =
					dataBaseContext.CapitalFunds
					.FirstOrDefault();

				if (capitalFund == null)
				{
					capitalFund =
						new Models.CapitalFund()
						{
							Capital_Fund = "0 تومان",
						};
					dataBaseContext.CapitalFunds.Add(capitalFund);
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
		#endregion /InitialAmountCapital

		#region MainForm
		private static MainForm _mainForm;

		public static MainForm MainForm
		{
			get 
			{
				if (_mainForm == null || _mainForm.IsDisposed == true)
				{
					_mainForm =
						new MainForm();
				}
				return _mainForm;
			}
		}

		public static void MainFormShow()
		{
			MainForm.Show();
		}
		#endregion /MainForm

		#region SingInForm
		/// <summary>
		/// Create SingIn Form properties.
		/// </summary>
		private static Entry_Forms.SingInForm _singInForm;
		public static Entry_Forms.SingInForm MySingInForm
		{
			get 
			{
				if (_singInForm == null || _singInForm.IsDisposed == true)
				{
					_singInForm =
						new Entry_Forms.SingInForm();
				}
				return _singInForm;
			}
		}

		/// <summary>
		/// Show Singin Form
		/// </summary>
		public static void SingInLoaded()
		{
			MySingInForm.Show();
		}
		#endregion /SingInForm

		#region SingUpForm
		private static Entry_Forms.SingUpForm _singUpForm;
		public static Entry_Forms.SingUpForm MySingUpForm
		{
			get
			{
				if (_singUpForm == null || _singUpForm.IsDisposed == true)
				{
					_singUpForm =
						new Entry_Forms.SingUpForm();
				}
				return _singUpForm;
			}
		}

		/// <summary>
		/// Show SingUp Form
		/// </summary>
		public static void SingUpLoaded()
		{
			MySingUpForm.Show();
		}
		#endregion /SingUpForm

		#region BillBuyReportForm
		private static Inventory_Forms.BillBuyReportForm _billBuyReportForm;

		public static Inventory_Forms.BillBuyReportForm BillBuyReportForm
		{
			get 
			{
				if (_billBuyReportForm == null || _billBuyReportForm.IsDisposed == true)
				{
					_billBuyReportForm =
						new Inventory_Forms.BillBuyReportForm();
				}
				return _billBuyReportForm;
			}
		}

		#endregion /BillBuyReportForm


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[System.STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			Administrator();
			InitialAmountCapital();
			//System.Windows.Forms.Application.Run(new Entry_Forms.StartUpForm());
			System.Windows.Forms.Application.Run(new TestControlsForm());
			//System.Windows.Forms.Application.Run(new Inventory_Forms.ListProductForm());
		}
	}
}

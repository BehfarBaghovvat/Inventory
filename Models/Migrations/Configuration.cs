using System.Data.Entity;
using System.Linq;

namespace Models.Migrations
{
	internal sealed class Configuration :
		System.Data.Entity.Migrations.DbMigrationsConfiguration<DataBaseContext>
	{
		public Configuration()
		{
			ContextKey = "Models.DataBaseContext";

			AutomaticMigrationsEnabled = false;
			AutomaticMigrationDataLossAllowed = false;
		}

		protected override void Seed(DataBaseContext dataBaseContext)
		{
			base.Seed(dataBaseContext);

			if (dataBaseContext.Users.Count() != 0)
			{
				return;
			}

			try
			{
				DataBaseContextInitializer.Seed(dataBaseContext);
			}
			catch
			{
			}
		}
	}
}


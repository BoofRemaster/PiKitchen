using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PiKitchen.Dal.Entities;

namespace PiKitchen.Dal.DataContext
{
    public class DatabaseContext : DbContext
    {
        public class OptionsBuild
        {
            public OptionsBuild()
            {
                _appSettings = new AppConfiguration();
                optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

                optionsBuilder.UseSqlServer(_appSettings.sqlConnectionString);
                dbOptions = optionsBuilder.Options;
            }

            public DbContextOptionsBuilder<DatabaseContext> optionsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> dbOptions { get; set; }

            private AppConfiguration _appSettings { get; set; }
        }

        public static OptionsBuild options = new OptionsBuild();

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        // Database Tables go here
        public DbSet<User> Users { get; set; }
        public DbSet<AuthenticationLevel> AuthenticationLevels { get; set; }
    }
}

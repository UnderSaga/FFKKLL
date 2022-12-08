using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Что_то_на_казахском
{
    internal class ApplicationContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public Microsoft.EntityFrameworkCore.DbSet<Employer> Employers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\repos\\Что-то на казахском\\DataBase.db");
        }

    }
}

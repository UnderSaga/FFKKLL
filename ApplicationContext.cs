using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Что_то_на_казахском
{
    internal class ApplicationContext: DbContext
    {

        public DbSet<Employer> Employers { get; set; }

        public ApplicationContext() : base("DefaultConnection") { }

    }
}

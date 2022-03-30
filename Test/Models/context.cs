using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public class context : DbContext
    {
        public context() : base("sql") { }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Gender> Genders { get; set; }

        private static context _context;
        public static context GetContext()
        {
            if (_context == null)
                _context = new context();
            return _context;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public class People
    {
        [Key]
        public int idPeople { get; set; }
        public string Login { get; set; }
        public string pwd { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthday {get; set;}
        public int idGender { get; set; }
        public virtual Gender Gender { get; set; }
    }
}

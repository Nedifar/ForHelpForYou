using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Gender
    {
        [Key]
        public int idGender { get; set; }
        public string Name { get; set; }
        public virtual List<People> Peoples { get; set; } = new List<People>();
    }
}

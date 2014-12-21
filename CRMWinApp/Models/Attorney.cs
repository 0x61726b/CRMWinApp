using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMWinApp.Models
{
    public class Attorney
    {
        public int Id { get;set; }

        public string Name { get;set; }

        public string Surname { get;set; }

        public int Age { get; set; }

        public string GraduateSchool { get; set; }

        public byte[] Picture { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}

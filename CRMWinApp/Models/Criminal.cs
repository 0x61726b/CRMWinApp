using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMWinApp.Models
{
    public class Criminal
    {
        public int Id { get;set; }

        public string Name { get;set; }

        public string Surname { get;set; }

        public int Height { get;set; }
        public int Weight { get;set; }
        public string Gender { get;set; }
        public string EyeColor { get;set; }
        public string HairColor { get;set; }
        public string Race { get;set; }
        public string Country { get;set; }
        public string State { get;set; }
        public DateTime CustodyStart { get;set; }
        public DateTime CustodyEnd { get;set; }

        public virtual ICollection<Meeting> Meetings { get;set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMWinApp.Models
{
    public class Charge
    {
        public int Id { get;set; }

        public virtual Attorney Attorney { get;set; }

        public Criminal Against { get;set; }

        public Cite Cite { get;set; }
    }
}

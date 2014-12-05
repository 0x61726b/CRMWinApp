using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMWinApp.Models
{
    public class Cite
    {
        public int Id { get; set; }

        public virtual CiteType Type { get; set; }
        public virtual User Officer { get; set; }

        public string Note { get; set; }
    }
}

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

        public virtual Criminal Against { get;set; }

        public virtual Cite Cite { get;set; }

        public virtual Sentence Sentence { get; set; }

        public DateTime Date { get;set; }
    }
}

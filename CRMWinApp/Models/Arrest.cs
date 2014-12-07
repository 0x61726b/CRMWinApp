using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMWinApp.Models;

namespace CRMWinApp.Models
{
    public class Arrest
    {
        public int Id { get;set; }

        public virtual CrimeType Type { get;set; }

        public virtual Criminal Criminal { get;set; }

        public string Location { get;set; }

        public DateTime Date { get;set; }

        public virtual Agency Agency { get;set; }

        public string Description { get;set; }

    }
}

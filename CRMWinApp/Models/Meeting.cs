using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMWinApp.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        public virtual Outsider Outsider { get;set; }

        public DateTime Date { get;set; }

        public string Location { get;set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMWinApp.Models
{
    public class Cell
    {
        public int Id { get;set; }

        public string Number { get;set; }

        public bool Status { get; set; }

        public Criminal Criminal { get;set; }

        public int X { get;set; }
        public int Y { get;set; }
    }
}

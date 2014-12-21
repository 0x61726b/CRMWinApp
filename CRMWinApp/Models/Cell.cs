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

        public virtual Criminal Criminal { get;set; }

        public int X { get;set; }
        public int Y { get;set; }

        public int Width { get; set; }
        public int Height { get; set; }
    }
}

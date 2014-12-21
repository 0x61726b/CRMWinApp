using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMWinApp.Models
{
    public class Transfer
    {
        public int Id { get; set; }

        public virtual Criminal Criminal { get; set; }

        public DateTime Date { get; set; }

        public Cell From { get; set; }

        public Cell To { get; set; }

        public virtual User TransferGuy {get;set;}


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMWinApp.Models
{
    public class Jail
    {
        public int Id { get;set; }

        public string Name { get;set; }

        public string Location { get;set; }

        public User Supervisor { get;set; }

        public int TotalCellCount { get;set; }

        public int CurrentPrisonerCount { get;set; }

        public ICollection< Criminal > Criminals { get;set; }

        public ICollection< Cell > Cells { get;set; }
    }
}

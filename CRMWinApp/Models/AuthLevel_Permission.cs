using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMWinApp.Models
{
    public class AuthLevel_Permission
    {
        public int Id { get; set; }

        public int AuthLevel { get; set; }
        
        public virtual Permission Permission { get; set; }

        
    }
}

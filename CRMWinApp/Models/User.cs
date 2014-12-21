using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMWinApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [MaxLength(18),MinLength(6)]
        public string Pass { get; set; }

        public int AuthLevel { get; set; }


    }
}

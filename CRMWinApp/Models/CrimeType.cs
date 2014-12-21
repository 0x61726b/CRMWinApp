using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMWinApp.Models
{
    public class CrimeType
    {
        public int Id { get;set; }

        [Required]
        [MinLength(5,ErrorMessage="Crime Type Name must be at least 5 characters.")]
        [RegularExpression(@"^[a-z A-Z]+$",ErrorMessage="Crime Type should be letters only.")]
        public string Name { get;set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMWinApp.Models
{
    public class Criminal
    {
        public int Id { get;set; }

        [Required]
        public string Name { get;set; }

        [Required]
        public string Surname { get;set; }

        [Range(50, 250, ErrorMessage = "Height has to be between 50 and 250")]
        public int Height { get;set; }

        [Range(30, 250, ErrorMessage = "Weight has to be between 30 and 250")]
        public int Weight { get;set; }

        [Range(0, 120, ErrorMessage = "Age has to be between 0 and 120")]
        public int Age { get; set; }
        public string Gender { get;set; }
        public string EyeColor { get;set; }
        public string HairColor { get;set; }
        public string Race { get;set; }
        public string Country { get;set; }
        public string State { get;set; }
        public byte[] PictureFront { get; set; }
        public byte[] PictureLeft { get; set; }
        public byte[] PictureRight { get; set; }

        public virtual ICollection<Meeting> Meetings { get;set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJMST.Domain.Models
{
    public class Googooli : Base.Entity
    {
        public Googooli() : base()
        {
        }

        [Required]
        public string GoogooliName { get; set; }
         

         
        [Required]
        public string LastName { get; set; }
         

         
        [Required]
        public string FirstName { get; set; }
         

         
        [Required]
        public string EmailAddress { get; set; }
         

        [Required]
        public string Password { get; set; }
         
         
    }
}

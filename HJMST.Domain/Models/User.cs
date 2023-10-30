using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJMST.Domain.Models
{
    public class User : Base.Entity
    {
        public User() : base()
        {
        }

        [Required]
        public string UserName { get; set; }
         

         
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

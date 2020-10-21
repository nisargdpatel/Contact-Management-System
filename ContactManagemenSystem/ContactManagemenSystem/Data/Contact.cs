using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagemenSystem.Data
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }     //Primary key - Contact Id

        [Required]
        public string FirstName { get; set; }       //Required variable - First Name

        [Required]
        public string LastName { get; set; }        //Required variable - Last Name

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }     //Required variable - Phone Number

        [Required]
        public DateTime BirthDate { get; set; }     //Required variable - Birth Date
    }
}

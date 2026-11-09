using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Entities
{
    public class Person : BaseModel
    {
        [Key]
        public int PersonId { get; set; }
        
        
        [Required(ErrorMessage ="First name is required")]
        [MaxLength(20,ErrorMessage ="First name cannot exceed 20 characters")]
        public string FirstName { get; set; }
       
        
        [Required(ErrorMessage ="Second name is required")]
        [MaxLength(20,ErrorMessage ="Second name cannot exceed 20 characters")]
        public string SecondName { get; set; }
        
        
        [MaxLength(20,ErrorMessage ="Third name cannot exceed 20 characters")]
        public string ThirdName { get; set; }
        
        
        [Required(ErrorMessage ="Last name is required")]
        [MaxLength(20,ErrorMessage ="Last name cannot exceed 20 characters")]
        public string LastName { get; set; }
        

        public  DateTime DateOfBirth { get; set; }


        [Required(ErrorMessage ="Gender is required ")]
        [Range(0, 1, ErrorMessage = "Invalid gender")]
        public byte Gender { get; set; }


        [MaxLength(500,ErrorMessage ="Address cannot exceed 500 characters")]
        public string Address { get; set; }


        [EmailAddress(ErrorMessage = "Invalid email format")]
        [MaxLength(50,ErrorMessage ="Email cannot exceed 50 characters")]
        public string Email { get; set; }


        [Required(ErrorMessage ="Phone is required")]
        [MaxLength(20,ErrorMessage ="Phone cannot exceed 20 characters")]
        [RegularExpression(@"^\+?\d{9,20}$", ErrorMessage = "Invalid phone number format")]
        public string Phone { get; set; }


        [Required(ErrorMessage ="Nationality is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid nationality")]
        public int NationalityId { get; set; }


        [MaxLength(250,ErrorMessage ="Image path cannot exceed 250 characters")]
        public string ImagePath { get; set; }


    }
}

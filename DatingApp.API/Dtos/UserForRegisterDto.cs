using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
       public string Username { get; set; } 
       [Required]
       [StringLength(12,MinimumLength=8,ErrorMessage="You must specify password between 8-12 characters")]
       public string Password { get; set; }     
        
    }
}
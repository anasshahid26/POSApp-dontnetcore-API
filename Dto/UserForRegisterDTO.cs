using System.ComponentModel.DataAnnotations;

namespace POSApp.API.Dto
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username {get;set;}
        
        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="Password 4 to 8 character")]
        public string Password {get;set;}
    }
}
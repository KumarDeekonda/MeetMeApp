using System.ComponentModel.DataAnnotations;

namespace MeetMeApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 character length")]
        public string Password { get; set; }
    }
}
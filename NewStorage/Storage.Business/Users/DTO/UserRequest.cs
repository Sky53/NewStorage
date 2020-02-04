using System;
using System.ComponentModel.DataAnnotations;

namespace Storage.Business.Users.DTO
{
    public class UserRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
    }
}

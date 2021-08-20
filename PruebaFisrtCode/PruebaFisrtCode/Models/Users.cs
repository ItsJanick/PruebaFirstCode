using System.ComponentModel.DataAnnotations;

namespace PruebaFisrtCode.Models
{
    public class Users
    {

        [Key]
        public int UserId { get; set; }
        public string IdentificationCard { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }


    }
}

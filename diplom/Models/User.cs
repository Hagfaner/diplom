using Microsoft.AspNetCore.Identity;

namespace diplom.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string Firstname { get; set; } = "";
        public string Lastname { get; set; } = "";
       
    }

}

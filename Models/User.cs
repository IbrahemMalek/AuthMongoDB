using System.ComponentModel.DataAnnotations;

namespace AuthMongoDB.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string email { get; set; }
        public string password { get; set; }
    }
}

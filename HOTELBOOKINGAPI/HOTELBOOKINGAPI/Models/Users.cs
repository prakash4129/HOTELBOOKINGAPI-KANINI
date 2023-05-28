using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HOTELBOOKINGAPI.Models

{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }
        public string? UserName { get; set; }

        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string? Roles { get; set; }
    }
}
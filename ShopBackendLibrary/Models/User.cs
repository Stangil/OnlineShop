using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBackendLibrary.Models
{
    public class User
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("UserIDClass")]
        public Guid UserId { get; set; }
        [Required]
        [Column("UserName")]
        public string UserName { get; set; }
        [Required]
        [Column("Password")]
        public string Password { get; set; }
        [Required]
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Required]
        [Column("LastName")]
        public string? LastName { get; set; }
        [Required]
        [Column("Email")]
        public string? Email { get; set; }
        public string? Role { get; set; } = "Default";
        public string? CreatedBy { get; set; }
        public string? LastUpdatedBy { get; set; }
    }
    public class UserPassword
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
    public class UserIDClass
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public Guid UserID { get; set; }
    }
}

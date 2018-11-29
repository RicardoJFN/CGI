using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CGI.Entity.User
{
    [Table("UserSignIn", Schema = "dbo")]
    public class UserEntity
    {
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Password")]
        public string Password { get; set; }

        [Column("LoginByPin")]
        public bool LoginByPin { get; set; }
         
        [Column("PinCode")]
        public int? PinCode { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace WebCRUDMVCSQL.Models
{
    [Table("usuario")]
    public class login
    {
        public string Id { get; set; }
        [Column("email")]
        [Display(Name = "email")]
        private string Email { get; set; }
        [Column("senha")]
        [Display(Name = "senha")]
        private string Password { get; set; }

    }
}

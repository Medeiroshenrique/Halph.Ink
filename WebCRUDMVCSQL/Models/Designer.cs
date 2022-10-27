using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebCRUDMVCSQL.Models
{
    [Table("projeto")]
    public class Designer : Pessoa
    {
        public string Id { get; set; }
        private ArrayList _formacao = new ArrayList();
        [Column("comissao")]
        [Display(Name = "comissao")]
        
        private float _comissao;
        [Column("status")]
        [Display(Name = "status")]
        
        private string _status;
        private ArrayList _projeto = new ArrayList();
    }
}

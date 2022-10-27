using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebCRUDMVCSQL.Models
{
    [Table("servico")]
    public class Servico
    {
        [Column("nome")]
        [Display(Name = "nome")]
        private string _nome;
        [Column("id")]
        [Display(Name = "id")]
        private int _id;
        [Column("valor")]
        [Display(Name = "valor")]
        private float _valor;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public float Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
    }
}

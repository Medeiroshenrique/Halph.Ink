using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebCRUDMVCSQL.Models
{
    [Table("formacao")]
    public class Formacao
    {
        public string Id { get; set; }
        [Column("tipo")]
        [Display(Name = "tipo")]
        private string _tipo;
        [Column("area")]
        [Display(Name = "area")]
        private string _area;
        [Column("especializacao")]
        [Display(Name = "especializacao")]
        private string _especializacao;
        [Column("andamento")]
        [Display(Name = "andamento")]
        private string _andamento;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public string Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public string Especializacao
        {
            get { return _especializacao; }
            set { _especializacao = value; }
        }

        public string Andamento
        {
            get { return _andamento; }
            set { _andamento = value; }
        }
    }
}

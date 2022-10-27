using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebCRUDMVCSQL.Models
{
    [Table("projeto")]
    public class Projeto
        {
            
            [Column("id")]
            [Display(Name = "id")]
            private int _id;
            [Column("name")]
            [Display(Name = "name")]
            private string _name;

            private ArrayList _servico = new ArrayList();
            private string _status;
            private ArrayList _cliente = new ArrayList();
            private ArrayList _designer = new ArrayList();
            [Column("total")]
            [Display(Name = "total")]
            private float _total;
            [Column("datacriacao")]
            [Display(Name = "datacriacao")]
            private DateTime _dataCriacao;
            [Column("prazo")]
            [Display(Name = "prazo")]
            private DateTime _prazo;

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public string Status
            {
                get { return _status; }
                set { _status = value; }
            }
            public float Total
            {
                get { return _total; }
                set { _total = value; }
            }
        }
    
}

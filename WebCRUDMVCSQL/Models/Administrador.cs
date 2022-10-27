using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUDMVCSQL.Models
{
    [Table("administrador")]
    public class Administrador : Pessoa
    {
        public string Id { get; set; } 
        private ArrayList _projetos = new ArrayList();
        private ArrayList _clientes = new ArrayList();
        private ArrayList _designers = new ArrayList();

        public void VinculaEntidades() { }
        public void DesvinculaEntidades() { }
        public void EditaServicosProjeto() { }
        public void EditaStatusProjeto() { }
        public void PagaDesigner() { }
        public void ReembolsaCliente() { }
    }
}

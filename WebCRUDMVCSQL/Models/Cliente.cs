using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUDMVCSQL.Models
{
    [Table("cliente")]
    public class Cliente : Pessoa
    {
        public string Id { get; set; }
        private ArrayList _projeto = new ArrayList();

        public void AdicionarProjeto(Projeto projeto)
        {
            _projeto.Add(projeto);
        }
        public void RemoverProjeto(Projeto projeto)
        {
            _projeto.Remove(projeto);
        }
        public float pedirOrcamento(Projeto projeto)
        {
            return projeto.Total;
        }
        public Projeto ConsultarProjeto(Projeto p)
        {

            int posicao = _projeto.IndexOf(p);
            return (Projeto)_projeto[posicao];
        }

    }
}

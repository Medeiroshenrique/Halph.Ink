namespace WebCRUDMVCSQL.Models
{
    public abstract class Pessoa
    {
        protected string _nome;
        protected string _cpf;
        protected string _email;
        protected int _telefone;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
    }
}

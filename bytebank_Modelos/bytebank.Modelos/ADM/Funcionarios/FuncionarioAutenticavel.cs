using bytebank.Modelos.ADM.SistemaInterno;
using bytebank_ATENDIMENTO.bytebank.Util;

namespace bytebank.Modelos.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario
    {
        public string Senha { get; set; }
        private AutenticacaoUtil Autenticador;


        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }
        public bool VerificaSenha(string senha)
        {
            return Autenticador.VerificarSenha(this.Senha, senha);
        }
    }
}

using bytebank.Modelos.ADM.SistemaInterno;
using bytebank_ATENDIMENTO.bytebank.Util;

namespace bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial
    {
        public string Senha { get; set; }
        private AutenticacaoUtil Autenticador { get; set; }
      
        public bool Autenticar(string senha)
        {
            return Autenticador.VerificarSenha(this.Senha, senha);
        }
    }
}

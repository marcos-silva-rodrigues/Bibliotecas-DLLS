using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    internal class AutenticacaoUtil
    {
        public bool VerificarSenha(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira.Equals(senhaTentativa);
        }
    }
}

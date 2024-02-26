using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastClient.Entid
{
    public class CadastEntid
    {
        //Campos para método.

        private int idpessoafisica;
        private string nomecomplet;

        //Método de envio e recebimento.

        public int Idpessoafisica { get => idpessoafisica; set => idpessoafisica = value; }
        public string Nomecomplet { get => nomecomplet; set => nomecomplet = value; }

    }
}

﻿using System;
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
        private string dataincluscadast;
        private string nomecomplet;
        private string cpf;
       

        //Método de envio e recebimento.

        public int Idpessoafisica { get => idpessoafisica; set => idpessoafisica = value; }
        public string Dataincluscadast { get => dataincluscadast; set => dataincluscadast = value; }
        public string Nomecomplet { get => nomecomplet; set => nomecomplet = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        
    }
}

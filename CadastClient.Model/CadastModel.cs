﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastClient.DAO;
using CadastClient.Entid;

namespace CadastClient.Model
{
    public class CadastModel
    {
        public static int Inserir(CadastEntid objTabela)
        {
            return new CadastDAO().Inserir(objTabela);
        }
    }
}

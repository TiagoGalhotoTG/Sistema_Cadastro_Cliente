using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastClient.Entid;
using CadastClient.Model;

namespace CadastClient.View
{
    public partial class FrmCadastView : Form
    {
        CadastEntid ObjTabela = new CadastEntid();
        public FrmCadastView()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Botao = "Novo";
            Iniciar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Botao = "Salvar";
            Iniciar();
        }

        private string Botao = "";

        private void HabilitarCampos()
        {
            txtNomeComplet.Enabled = true;
        }

        private void LimparCampos ()
        {
            txtNomeComplet.Text = "";
        }

        private void Iniciar()
        {
            switch (Botao)
            {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    break;

                case "Salvar":
                    try
                    {
                        ObjTabela.Nomecomplet = txtNomeComplet.Text;
                        int X = CadastModel.Inserir(ObjTabela);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar");
                        throw;

                    }
                    break;

            }
        }

        private void FrmCadastView_Load(object sender, EventArgs e)
        {

        }
    }
}

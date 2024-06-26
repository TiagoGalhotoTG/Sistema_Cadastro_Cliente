﻿using System;
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


           txtDataInclustcadast.Text = DateTime.Now.ToShortDateString();

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
            txtCpf.Enabled = true;
            txtRg.Enabled = true;
            txtProfissao.Enabled = true;
            txtRichTextBox.Enabled = true;
        }

        private void LimparCampos ()
        {
            txtNomeComplet.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtProfissao.Text = "";
            txtRichTextBox.Text = "";
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
                        ObjTabela.Dataincluscadast = txtDataInclustcadast.Text; 
                        ObjTabela.Nomecomplet = txtNomeComplet.Text;
                        ObjTabela.Cpf = txtCpf.Text;
                        ObjTabela.Rg = txtRg.Text;
                        ObjTabela.Profissao = txtProfissao.Text;
                        ObjTabela.Observacoes = txtRichTextBox.Text;
                        ObjTabela.Datanasciment = txtDatanasciment.Text;
                        int X = CadastModel.Inserir(ObjTabela);
                        if (X > 0)
                        {
                            MessageBox.Show("{0} Salvo Com Sucesso !", txtNomeComplet.Text);
                        }
                        else
                        {
                            MessageBox.Show("Erro Ao Salvo !");
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Ocorreu um Erro ao salvar !"+ Ex.Message);
                    }
                    break;
                
            }
        }

        private void txtRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

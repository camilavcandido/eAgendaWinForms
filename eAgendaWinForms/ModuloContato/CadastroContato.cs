
using eAgenda.Dominio;
using System.Windows.Forms;
using System;
using eAgenda.Infra.Arquivos;
using System.Collections.Generic;

namespace eAgendaWinForms.ModuloContato
{
    public partial class CadastroContato : Form
    {
        private RepositorioContatoEmArquivo repositorioContato;

        private Contato contato;
        public CadastroContato()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                txtNomeContato.Text = Contato.Nome;
                txtEmailContato.Text = Contato.Email;
                txtTelefoneContato.Text = Contato.Telefone;
                txtEmpresaContato.Text = Contato.Empresa;
                txtCargoContato.Text = Contato.Cargo;
            }
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            Contato.Nome = txtNomeContato.Text;
            Contato.Email = txtEmailContato.Text;
            Contato.Telefone = txtTelefoneContato.Text;
            Contato.Empresa = txtEmpresaContato.Text;
            Contato.Cargo = txtCargoContato.Text;

        }
    }
}

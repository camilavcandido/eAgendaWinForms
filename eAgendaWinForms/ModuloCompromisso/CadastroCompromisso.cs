using eAgenda.Dominio;
using eAgenda.Infra.Arquivos;
using eAgendaWinForms.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgendaWinForms.ModuloCompromisso
{
    public partial class CadastroCompromisso : Form
    {

        private Compromisso compromisso;
        private RepositorioContato repositorioContato;

        public CadastroCompromisso()
        {
            repositorioContato = new RepositorioContato();
            InitializeComponent();
        }


        public Compromisso Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
                compromisso = value;
                txtAssuntoCompromisso.Text = compromisso.Assunto;
                txtLocalCompromisso.Text = compromisso.Local;
                txtDataCompromisso.Value = txtDataCompromisso.Value;

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contatoSelecionado = (Contato)listContatosCompromisso.SelectedItem;

                Compromisso.Assunto = txtAssuntoCompromisso.Text;
                Compromisso.Local = txtLocalCompromisso.Text;
                compromisso.DataCompromisso = txtDataCompromisso.Value;
                compromisso.HoraInicio = Convert.ToDateTime(txtHoraInicio.Text);
                compromisso.HoraTermino = Convert.ToDateTime(txtHoraTermino.Text);
                compromisso.Contato = contatoSelecionado;
            }
            catch
            {

            }
        }

    }
}

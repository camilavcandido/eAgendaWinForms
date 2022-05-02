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
        private readonly ISerializador serializador;

        private Compromisso compromisso;
        private RepositorioContato repositorioContato;

        public CadastroCompromisso()
        {
            serializador = new SerializadorJson();
            repositorioContato = new RepositorioContato(serializador);
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
            int intIDcontato = Convert.ToInt32(txtContatoCompromisso.Text);
            Contato contato = repositorioContato.SelecionarRegistro(intIDcontato);
            try
            {
                Compromisso.Assunto = txtAssuntoCompromisso.Text;
                Compromisso.Local = txtLocalCompromisso.Text;
                compromisso.DataCompromisso = txtDataCompromisso.Value;
                compromisso.HoraInicio = Convert.ToDateTime(txtHoraInicio.Text);
                compromisso.HoraTermino = Convert.ToDateTime(txtHoraTermino.Text);
                compromisso.Contato = contato;
            }
            catch
            {

            }
        }


    }
}

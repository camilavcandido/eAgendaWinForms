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
        private RepositorioContatoEmArquivo repositorioContato;

        public CadastroCompromisso()
        {
            InitializeComponent();
          
            serializador = new SerializadorEmJsonDotnet();
            DataContext dataContext = new DataContext();
            repositorioContato = new RepositorioContatoEmArquivo(serializador, dataContext);
            CarregarContatos();

        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            foreach (Contato c in contatos)
            {
                comboBoxContatos.Items.Add(c.Nome);

            }
        }

        public Compromisso Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
                Contato contatoSelecionado = (Contato)comboBoxContatos.SelectedItem;

                compromisso = value;
                txtAssuntoCompromisso.Text = compromisso.Assunto;
                txtLocalCompromisso.Text = compromisso.Local;
                if (compromisso.DataCompromisso < txtDataCompromisso.MinDate)
                {
                    txtDataCompromisso.Value = DateTime.Now;
                }
                else
                {
                    txtDataCompromisso.Value = compromisso.DataCompromisso;
                }
                txtHoraInicio.Text = compromisso.HoraInicio.ToString();
                txtHoraTermino.Text = compromisso.HoraTermino.ToString();

                if (!String.IsNullOrEmpty(comboBoxContatos.Text))
                {
                    comboBoxContatos.Text = compromisso.Contato.Nome;

                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {


            Compromisso.Assunto = txtAssuntoCompromisso.Text;
            Compromisso.Local = txtLocalCompromisso.Text;
            compromisso.DataCompromisso = txtDataCompromisso.Value;
            compromisso.HoraInicio = TimeSpan.Parse(txtHoraInicio.Text);
            compromisso.HoraTermino = TimeSpan.Parse(txtHoraTermino.Text);
            compromisso.Contato = ReceberContato(comboBoxContatos.Text);


        }

        private Contato ReceberContato(string nome)
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            foreach (Contato contato in contatos)
            {
                if (contato.Nome == nome)
                    return contato;
            }

            return null;
        }
    }
}

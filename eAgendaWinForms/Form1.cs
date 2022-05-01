using eAgendaWinForms.ModuloCompromisso;
using eAgendaWinForms.ModuloContato;
using eAgendaWinForms.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgendaWinForms
{
    public partial class Form1 : Form
    {
        private Form formAtivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarTelaFormulario(Form frm)
        {
            formAtivo = frm;
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnMenuTelaTarefas_Click(object sender, EventArgs e)
        {
            FormTarefa tela = new FormTarefa();
            formAtivo = tela;
            MostrarTelaFormulario(formAtivo);

        }


        private void btnMenuTelaContatos_Click(object sender, EventArgs e)
        {
            FormContato tela = new FormContato();
            formAtivo = tela;
            MostrarTelaFormulario(formAtivo);
        }

        private void btnMenuTelaCompromissos_Click(object sender, EventArgs e)
        {
            FormCompromisso tela = new FormCompromisso();
            formAtivo = tela;
            MostrarTelaFormulario(formAtivo);
        }


    }
}

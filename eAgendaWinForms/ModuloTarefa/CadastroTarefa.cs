using eAgenda.Dominio;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using eAgenda.Infra.Arquivos;
using System.Text;

namespace eAgendaWinForms.ModuloTarefa
{
    public partial class CadastroTarefa : Form
    {
        private Tarefa tarefa;
      
        public CadastroTarefa()
        {
            InitializeComponent();
          
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                txtNumero.Text = tarefa.Numero.ToString();
                txtTitulo.Text = tarefa.Titulo;

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

                tarefa.Titulo = txtTitulo.Text;
                tarefa.Prioridade = ObtemValorPrioridade();
           
        }


        private int ObtemValorPrioridade()
        {
            int prioridade = 0;
            if (radioBtnBaixa.Checked)
                prioridade = 1;
            else if (radioBtnMedia.Checked)
                prioridade = 2;
            else if (radioBtnAlta.Checked)
                prioridade = 3;

            return prioridade;
        }



    }
}

using eAgenda.Dominio;
using eAgenda.Infra.Arquivos;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace eAgendaWinForms.ModuloContato
{
    public partial class FormContato : Form
    {
        private RepositorioContato repositorioContato;

        public FormContato()
        {
            SerializadorJson serializador = new SerializadorJson();
            repositorioContato = new RepositorioContato(serializador);
            InitializeComponent();
            CarregarContatos();
        }

        private void CarregarContatos()
        {
                       
                List<Contato> contatos = repositorioContato.SelecionarTodos();
            listContatos.Items.Clear();

            foreach (Contato c in contatos)
            {
                listContatos.Items.Add(c);
            }

           var contatosAgrupados = repositorioContato.SelecionarTodos().GroupBy(x => x.Cargo);
           listContatosAgrupados.Items.Clear();

            foreach (var contatoAgrupado in contatosAgrupados)
            {
                string nomeCargo = contatoAgrupado.Key.ToUpper();
                listContatosAgrupados.Items.Add(nomeCargo);

                foreach (Contato contatoDisponivel in contatos)
                {
                    if (contatoDisponivel.Cargo.Length > 0)
                    {
                        if (contatoDisponivel.Cargo == contatoAgrupado.Key)
                            listContatosAgrupados.Items.Add(contatoDisponivel);
                    }
                }
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroContato tela = new CadastroContato();
            tela.Contato = new Contato();


            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string resultadoValidacao = tela.Contato.Validar();

                if (resultadoValidacao == "REGISTRO_VALIDO")
                {
                    repositorioContato.Inserir(tela.Contato);
                    MessageBox.Show("Contato cadastrada com sucesso!", "Cadastro de Contatos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"{resultadoValidacao}", "Cadastro de Contatos",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CarregarContatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione uma contato primeiro",
                "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroContato tela = new();

            tela.Contato = contatoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarregarContatos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listContatos.SelectedItem;

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um contato primeiro",
                "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o contato?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }




    }
}

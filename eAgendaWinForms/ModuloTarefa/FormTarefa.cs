using eAgenda.Dominio;
using eAgenda.Infra.Arquivos;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgendaWinForms.ModuloTarefa
{
    public partial class FormTarefa : Form
    {

        protected RepositorioTarefa repositorioTarefa;

        public FormTarefa()
        {
            SerializadorJson serializador = new SerializadorJson();
            repositorioTarefa = new RepositorioTarefa(serializador);

            InitializeComponent();
            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefasConcluidas = repositorioTarefa.SelecionarTarefasConcluidas();

            listTarefasConcluidas.Items.Clear();

            foreach (Tarefa t in tarefasConcluidas)
            {
                listTarefasConcluidas.Items.Add(t);
            }

            List<Tarefa> tarefasPendentes = repositorioTarefa.SelecionarTarefasPendentes();

            listTarefasPendentes.Items.Clear();

            foreach (Tarefa t in tarefasPendentes)
            {
                listTarefasPendentes.Items.Add(t);
            }
        }

        private void btnInserir_Click(object sender, System.EventArgs e)
        {

            CadastroTarefa tela = new CadastroTarefa();
            tela.Tarefa = new Tarefa();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (ValidarTituloExiste(tela.Tarefa) == true)
                {
                    MessageBox.Show("Título já cadastrado. Por favor, informe outro título.", "Cadastro de Tarefas",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string resultadoValidacao = tela.Tarefa.Validar();

                    if (resultadoValidacao == "REGISTRO_VALIDO")
                    {
                        repositorioTarefa.Inserir(tela.Tarefa);
                        MessageBox.Show("Tarefa cadastrada com sucesso!", "Cadastro de Tarefas",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"{resultadoValidacao}", "Cadastro de Tarefas",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    CarregarTarefas();
                }
            }
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {

            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroTarefa tela = new CadastroTarefa();

            tela.Tarefa = tarefaSelecionada;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (ValidarTituloExiste(tela.Tarefa) == true)
                {
                    MessageBox.Show("Título já cadastrado. Por favor, informe outro título.", "Edição de Tarefas",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string resultadoValidacao = tela.Tarefa.Validar();

                    if (resultadoValidacao == "REGISTRO_VALIDO")
                    {
                        repositorioTarefa.Editar(tela.Tarefa);
                        MessageBox.Show("Tarefa Editada com sucesso!", "Edição de Tarefas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{resultadoValidacao}", "Edição de Tarefas",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    CarregarTarefas();
                }
            }
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);
                MessageBox.Show("Tarefa Excluída com sucesso", "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarTarefas();
            }
        }

        private void btnAdicionarItem_Click(object sender, System.EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroItensTarefa tela = new CadastroItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

                CarregarTarefas();
            }
        }

        private void btnAtualizarItem_Click(object sender, System.EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listTarefasPendentes.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            AtualizacaoItensTarefa tela = new AtualizacaoItensTarefa(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;

                List<ItemTarefa> itensPendentes = tela.ItensPendentes;

                repositorioTarefa.AtualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);
                CarregarTarefas();
            }
        }

        public bool ValidarTituloExiste(Tarefa tarefa)
        {
            bool tituloExiste = false;

            List<Tarefa> tarefas = repositorioTarefa.SelecionarTarefasPendentes();
            foreach (Tarefa t in tarefas)
            {
                if (t.Titulo.ToLower() == tarefa.Titulo.ToLower())
                {
                    tituloExiste = true;
                }
            }

            return tituloExiste;
        }
    }
}

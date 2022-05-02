using eAgenda.Dominio;
using eAgenda.Infra.Arquivos;
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
    public partial class FormCompromisso : Form
    {
        private RepositorioCompromisso repositorioCompromisso;
        private RepositorioContato repositorioContato;
        public FormCompromisso()
        {
            InitializeComponent();
            SerializadorJson serializador = new SerializadorJson();
            repositorioCompromisso = new RepositorioCompromisso(serializador);
            repositorioContato = new RepositorioContato(serializador);
            CarregarCompromissos();
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissosFuturos = repositorioCompromisso.SelecionarCompromissosFuturos();
            listCompromissosFuturos.Items.Clear();

            foreach (Compromisso c in compromissosFuturos)
            {
                listCompromissosFuturos.Items.Add(c);
            }

            List<Compromisso> compromissosPassados = repositorioCompromisso.SelecionarCompromissosPassados();
            listCompromissosPassados.Items.Clear();

            foreach (Compromisso c in compromissosPassados)
            {
                listCompromissosPassados.Items.Add(c);
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroCompromisso tela = new();
            tela.Compromisso = new Compromisso();

            DialogResult resultado = tela.ShowDialog();


            if (resultado == DialogResult.OK)
            {
                bool horarioDisponivel = ValidarHorarioCompromisso(tela.Compromisso);
                if (horarioDisponivel == false)
                {
                    MessageBox.Show("Já existe um compromisso neste intervalo de tempo", "Cadastro de Compromissos",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    bool contatoValido = ValidarContato(tela.Compromisso);
                    if (contatoValido == false)
                    {
                        MessageBox.Show("ID do contato não encotrado. Verifique a lista de contatos e tente novamente", "Cadastro de Compromissos",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string resultadoValidacao = tela.Compromisso.Validar();

                        if (resultadoValidacao == "REGISTRO_VALIDO")
                        {
                            repositorioCompromisso.Inserir(tela.Compromisso);
                            MessageBox.Show("Compromisso cadastrado com sucesso!", "Cadastro de Compromissos",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show($"{resultadoValidacao}", "Cadastro de Compromissos",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    CarregarCompromissos();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            List<Contato> c = repositorioContato.SelecionarTodos();

            Compromisso compromissoSelecionado = (Compromisso)listCompromissosFuturos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Edição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroCompromisso tela = new();

            tela.Compromisso = compromissoSelecionado;

            DialogResult resultado = tela.ShowDialog();

            bool contatoValido = ValidarContato(tela.Compromisso);

            if (contatoValido == false)
            {
                MessageBox.Show("ID do contato não encotrado. Verifique a lista de contatos e tente novamente", "Cadastro de Compromissos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Editar(tela.Compromisso);
                CarregarCompromissos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listCompromissosFuturos.SelectedItem;

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro",
                "Exclusão de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o compromisso?",
                "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromissos();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime dataI = dataInicioFiltro.Value;
            DateTime dataF = dataFinalFiltro.Value;

            List<Compromisso> compromissos =
                repositorioCompromisso.SelecionarCompromissosPorPeriodo(dataI, dataF);

            listCompromissosFuturos.Items.Clear();

            foreach (Compromisso c in compromissos)
            {
                listCompromissosFuturos.Items.Add(c);
            }



        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            List<Compromisso> compromissosFuturos = repositorioCompromisso.SelecionarCompromissosFuturos();
            listCompromissosFuturos.Items.Clear();

            foreach (Compromisso c in compromissosFuturos)
            {
                listCompromissosFuturos.Items.Add(c);
            }
        }

        private bool ValidarContato(Compromisso compromisso)
        {
            bool contatoValido = false;
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            foreach (Contato c in contatos)
            {
                if (compromisso.Contato != null)
                {
                    if (c.Numero == compromisso.Contato.Numero)
                    {
                        contatoValido = true;
                    }
                }

            }

            return contatoValido;
        }

        private bool ValidarHorarioCompromisso(Compromisso compromisso)
        {
            bool horarioDisponivel = true;

           //verifica se o horário de inicio do novo compromisso está entre o horario de inicio e termino de um compromisso já cadastrado no mesmo dia;
            List<Compromisso> compromissosFuturos = repositorioCompromisso.SelecionarCompromissosFuturos();
            foreach (Compromisso c in compromissosFuturos)
            {
                if(c.DataCompromisso == compromisso.DataCompromisso)
                {
                    if (compromisso.HoraInicio >= c.HoraInicio && compromisso.HoraInicio <= c.HoraTermino)
                        horarioDisponivel = false;
                    break;
                }

            }

            return horarioDisponivel;
        }


    }
}

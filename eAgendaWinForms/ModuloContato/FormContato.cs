using eAgenda.Dominio;
using eAgenda.Infra.Arquivos;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eAgendaWinForms.ModuloContato
{
    public partial class FormContato : Form
    {
        private RepositorioContato repositorioContato;
        private RepositorioCompromisso repositorioCompromisso;

        public FormContato()
        {
            SerializadorJson serializador = new SerializadorJson();
            repositorioContato = new RepositorioContato(serializador);
            repositorioCompromisso = new RepositorioCompromisso(serializador);
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
                string validacaoCampos = ValidarCampos(tela.Contato);
                if (validacaoCampos != "CAMPOS_VALIDOS")
                {
                    MessageBox.Show($"{validacaoCampos}", "Cadastro de Contatos",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
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
                }
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
                string validacaoCampos = ValidarCampos(tela.Contato);
                if (validacaoCampos != "CAMPOS_VALIDOS")
                {
                    MessageBox.Show($"{validacaoCampos}", "Cadastro de Contatos",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    string resultadoValidacao = tela.Contato.Validar();

                    if (resultadoValidacao == "REGISTRO_VALIDO")
                    {
                        repositorioContato.Editar(tela.Contato);
                        MessageBox.Show("Contato Editado com sucesso!", "Cadastro de Contatos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarContatos();

                    }
                    else
                        MessageBox.Show($"{resultadoValidacao}", "Cadastro de Contatos",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

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

            bool contatoPossuiCompromisso = false;
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarCompromissosFuturos();
            foreach (Compromisso c in compromissos)
            {
                if (contatoSelecionado.Numero == c.Contato.Numero)
                    contatoPossuiCompromisso = true;
                break;

            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o contato?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (contatoPossuiCompromisso == true)
            {
                MessageBox.Show("Não é possível excluir contato relacionado a um compromisso futuro",
               "Exclusão de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarregarContatos();
            }
        }

        #region validacoes

        //verifica que se o nome, email e telefone já estão sendo utilizados;
        private string ValidarCampos(Contato contato)
        {
            bool nomeExiste = false, emailExiste = false, telefoneExiste = false;

            List<Contato> contatos = repositorioContato.SelecionarTodos();

            foreach (Contato c in contatos)
            {
                try
                {
                    if (c.Numero != contato.Numero)
                    {
                        if (c.Nome.ToLower() == contato.Nome.ToLower())
                            nomeExiste = true;
                        if (c.Email.ToLower() == contato.Email.ToLower())
                            emailExiste = true;
                        if (c.Telefone.ToLower() == contato.Telefone.ToLower())
                            telefoneExiste = true;
                    }

                }
                catch { }

            }

            StringBuilder sb = new StringBuilder();
            if (nomeExiste)
                sb.AppendLine("Nome já utilizado");
            if (emailExiste)
                sb.AppendLine("Email já utilizado");
            if (telefoneExiste)
                sb.AppendLine("Telefone já utilizado");

            if (sb.Length == 0)
                sb.Append("CAMPOS_VALIDOS");

            return sb.ToString();
        }


        #endregion


    }
}

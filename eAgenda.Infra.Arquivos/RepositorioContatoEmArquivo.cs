using eAgenda.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Arquivos
{
    public class RepositorioContatoEmArquivo
    {
        private readonly ISerializador serializador;
        private readonly DataContext dataContext;
        private int contador = 0;

        public RepositorioContatoEmArquivo(ISerializador serializador, DataContext dataContext)
        {
            this.serializador = serializador;
            this.dataContext = dataContext;
            dataContext.Contatos.AddRange(serializador.CarregarDadosDoArquivo().Contatos);
        }

        public List<Contato> SelecionarTodos()
        {
            return dataContext.Contatos;
        }

        public void Inserir(Contato novoContato)
        {
            novoContato.Numero = ++contador;

            dataContext.Contatos.Add(novoContato);

            serializador.GravarDadosEmArquivo(dataContext);
        }

        public void Editar(Contato contato)
        {
            foreach (var item in dataContext.Contatos)
            {
                if (item.Numero == contato.Numero)
                {
                    item.Nome = contato.Nome;
                    item.Email = contato.Email;
                    item.Telefone = contato.Telefone;
                    item.Empresa = contato.Empresa;
                    item.Cargo = contato.Cargo;
                    serializador.GravarDadosEmArquivo(dataContext);
                    break;
                }
            }

           

        }

        public void Excluir(Contato contato)
        {
            dataContext.Contatos.Remove(contato);

            serializador.GravarDadosEmArquivo(dataContext);
        }

        public Contato SelecionarRegistro(int idSelecionado)
        {
            foreach (Contato c in dataContext.Contatos)
            {
                if (idSelecionado == c.Numero)
                    return c;
            }

            return null;
        }

    }
}

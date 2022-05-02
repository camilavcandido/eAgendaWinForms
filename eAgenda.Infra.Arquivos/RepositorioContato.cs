using eAgenda.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Arquivos
{
    public class RepositorioContato
    {
        private readonly ISerializador serializador;
        List<Contato> contatos;
        private int contador = 0;



        public RepositorioContato(ISerializador serializador)
        {
            this.serializador = serializador;

            contatos = serializador.CarregarContatosDoArquivo();

            if (contatos.Count > 0)
                contador = contatos.Max(x => x.Numero);
        }

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Inserir(Contato novoContato)
        {
            novoContato.Numero = ++contador;

            contatos.Add(novoContato);

            serializador.GravarContatosEmArquivo(contatos);
        }

        public void Editar(Contato contato)
        {
            foreach (var item in contatos)
            {
                if (item.Numero == contato.Numero)
                {
                    item.Nome = contato.Nome;

                    break;
                }
            }

            serializador.GravarContatosEmArquivo(contatos);
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);

            serializador.GravarContatosEmArquivo(contatos);
        }

        public Contato SelecionarRegistro(int idSelecionado)
        {
            foreach (Contato c in contatos)
            {
                if (idSelecionado == c.Numero)
                    return c;
            }

            return null;
        }

    }
}

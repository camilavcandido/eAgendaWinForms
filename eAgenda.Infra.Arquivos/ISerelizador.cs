using eAgenda.Dominio;
using System.Collections.Generic;

namespace eAgenda.Infra.Arquivos
{
    public interface ISerializador
    {
        List<Tarefa> CarregarTarefasDoArquivo();
        List<Contato> CarregarContatosDoArquivo();
        List<Compromisso> CarregarCompromissosDoArquivo();

        void GravarTarefasEmArquivo(List<Tarefa> tarefas);
        void GravarContatosEmArquivo(List<Contato> contatos);
        void GravarCompromissosEmArquivo(List<Compromisso> compromissos);


    }
}

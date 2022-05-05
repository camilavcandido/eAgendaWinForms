using eAgenda.Dominio;
using System.Collections.Generic;

namespace eAgenda.Infra.Arquivos
{
    public class DataContext
    {

        public DataContext()
        {
            Tarefas = new List<Tarefa>();

            Contatos = new List<Contato>();

            Compromissos = new List<Compromisso>();
        }

        public List<Tarefa> Tarefas { get; set; }

        public List<Contato> Contatos { get; set; }

        public List<Compromisso> Compromissos { get; set; }

    }
}

using eAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Infra.Arquivos
{
    public class RepositorioCompromissoEmArquivo
    {

        private readonly ISerializador serializador;
        private readonly DataContext dataContext;
        private int contador = 0;


        public RepositorioCompromissoEmArquivo(ISerializador serializador, DataContext dataContext)
        {
            this.serializador = serializador;
            this.dataContext = dataContext;
            dataContext.Compromissos.AddRange(serializador.CarregarDadosDoArquivo().Compromissos);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return dataContext.Compromissos;
        }

        public void Inserir(Compromisso novoCompromisso)
        {
            novoCompromisso.Numero = ++contador;

            dataContext.Compromissos.Add(novoCompromisso);

            serializador.GravarDadosEmArquivo(dataContext);
        }

        public void Editar(Compromisso compromisso)
        {
            foreach (var item in dataContext.Compromissos)
            {
                if (item.Numero == compromisso.Numero)
                {
                    item.Assunto = compromisso.Assunto;
                    item.Local = compromisso.Local;
                    item.DataCompromisso = compromisso.DataCompromisso;
                    item.HoraInicio = compromisso.HoraInicio;
                    item.HoraTermino = compromisso.HoraTermino;
                    serializador.GravarDadosEmArquivo(dataContext);
                    break;
                }
            }
            

        }

        public void Excluir(Compromisso compromisso)
        {
            dataContext.Compromissos.Remove(compromisso);

            serializador.GravarDadosEmArquivo(dataContext);

        }


        public List<Compromisso> SelecionarCompromissosFuturos()
        {

            return dataContext.Compromissos.Where(x => x.DataCompromisso.Date >= DateTime.Now.Date
            && x.HoraInicio > DateTime.Now.TimeOfDay)
                .OrderBy(d => d.DataCompromisso).ToList();
        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {

            return dataContext.Compromissos.Where(x => x.DataCompromisso.Date <= DateTime.Now.Date && x.HoraInicio > DateTime.Now.TimeOfDay).ToList();


        }

        public List<Compromisso> SelecionarCompromissosPorPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            return Filtrar(compromisso => (compromisso.DataCompromisso > dataInicio && compromisso.DataCompromisso < dataTermino) );
        }

        public List<Compromisso> Filtrar(Predicate<Compromisso> condicao)
        {
            List<Compromisso> registrosFiltrados = new List<Compromisso>();

            foreach (Compromisso registro in dataContext.Compromissos)
                if (condicao(registro))
                    registrosFiltrados.Add(registro);

            return registrosFiltrados;
        }

    }
}

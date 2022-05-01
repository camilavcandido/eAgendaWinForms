using eAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Infra.Arquivos
{
    public class RepositorioCompromisso
    {

        private readonly ISerializador serializador;
        List<Compromisso> compromissos;
        private int contador = 0;


        public RepositorioCompromisso(ISerializador serializador)
        {
            this.serializador = serializador;

            compromissos = serializador.CarregarCompromissosDoArquivo();

            if (compromissos.Count > 0)
                contador = compromissos.Max(x => x.Numero);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        public void Inserir(Compromisso novoCompromisso)
        {
            novoCompromisso.Numero = ++contador;

            compromissos.Add(novoCompromisso);

            serializador.GravarCompromissosEmArquivo(compromissos);
        }

        public void Editar(Compromisso compromisso)
        {
            foreach (var item in compromissos)
            {
                if (item.Numero == compromisso.Numero)
                {
                    item.Assunto = compromisso.Assunto;
                    item.Local = compromisso.Local;
                    item.DataCompromisso = compromisso.DataCompromisso;
                    item.HoraInicio = compromisso.HoraInicio;
                    item.HoraTermino = compromisso.HoraTermino;
                    break;
                }
            }
            serializador.GravarCompromissosEmArquivo(compromissos);

        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);

            serializador.GravarCompromissosEmArquivo(compromissos);

        }


        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            return compromissos.Where(x => x.DataCompromisso > DateTime.Now).ToList();


        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {

            return compromissos.Where(x => x.DataCompromisso < DateTime.Now).ToList();


        }

        public List<Compromisso> SelecionarCompromissosPorPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            return Filtrar(compromisso => compromisso.DataCompromisso >= dataInicio && compromisso.DataCompromisso <= dataTermino);
        }

        public List<Compromisso> Filtrar(Predicate<Compromisso> condicao)
        {
            List<Compromisso> registrosFiltrados = new List<Compromisso>();

            foreach (Compromisso registro in compromissos)
                if (condicao(registro))
                    registrosFiltrados.Add(registro);

            return registrosFiltrados;
        }

    }
}

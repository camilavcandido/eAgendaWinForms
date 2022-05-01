using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Dominio
{
    public class Compromisso
    {
        public int Numero { get; set; }
        public string Assunto { get; set; }
        public string Local { get; set; }

        public DateTime DataCompromisso { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public Contato Contato { get; set; }

        public Compromisso()
        {
        }
        public Compromisso(int numero, string assunto, string local,
            DateTime dataCompromisso, DateTime horaInicio, DateTime horaTermino,
            Contato contato) : this()
        {
            Numero = numero;
            Assunto = assunto;
            Local = local;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            DataCompromisso = dataCompromisso;
            Contato = contato;
        }

        public string Validar()
        {
            StringBuilder sb = new StringBuilder();

            
            if (string.IsNullOrEmpty(Assunto))
                sb.AppendLine("O Assunto é obrigatório!");
            if (string.IsNullOrEmpty(Local))
                sb.AppendLine("O Local o é obrigatório!");
            if (ValidarHorario() == false)
                sb.AppendLine("O horário de início deve ser menor que o horário de término");
          
            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }


        public bool ValidarHorario()
        {
            if (HoraInicio < HoraTermino)
            {
                return true;
            }
            else
                return false;
        }



        public override string ToString()
        {
            string contatoRelacionado = Contato is null ? "Não disponível" : Contato.Nome;

            return $"{Numero} | {Assunto} | {Local} | " +
                $"{DataCompromisso.ToShortDateString()}" +
                $"| {HoraInicio.ToShortTimeString()} | {HoraTermino.ToShortTimeString()} |{contatoRelacionado}";
        }



    }
}

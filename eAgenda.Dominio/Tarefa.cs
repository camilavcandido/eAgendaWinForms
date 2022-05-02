using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eAgenda.Dominio
{
    public class Tarefa
    {
      
        private List<ItemTarefa> itens = new List<ItemTarefa>();
        public int Numero { get; set; }
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public int Prioridade { get; set; }
        public List<ItemTarefa> Itens { get { return itens; } }

        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }

        public Tarefa(int n, string t, int p) : this()
        {
            Numero = n;
            Titulo = t;
            Prioridade = p;
            DataConclusao = null;
        }

        public void AdicionarItem(ItemTarefa item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }
        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluido();

            if (percentual == 100)
                DataConclusao = DateTime.Now;
        }
        public void MarcarPendente(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();
        }
        public decimal CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
                return 0;

            int qtdConcluidas = itens.Count(x => x.Concluido);

            var percentualConcluido = (qtdConcluidas / (decimal)itens.Count()) * 100;

            return Math.Round(percentualConcluido, 2);
        }
        public string Validar()
        {

            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Titulo))
                sb.AppendLine("O título da tarefa é obrigatório!"); 

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }
        public override string ToString()
        {
            string strPrioridade = "";

            if (Prioridade == 1)
                strPrioridade = "Baixa";
            else if (Prioridade == 2)
                strPrioridade = "Media";
            else if (Prioridade == 3)
                strPrioridade = "Alta";

            var percentual = CalcularPercentualConcluido();

            if (DataConclusao.HasValue)
            {
                return $"Número {Numero}  | Título: {Titulo}, Percentual: {percentual}%, " +
                    $"Concluída: {DataConclusao.Value.ToShortDateString()}";
            }

            return $"Número { Numero}  | Título: {Titulo},  Prioridade: {strPrioridade}, " +
                $"Data Criação: {DataCriacao.ToShortDateString()}, Percentual: {percentual}%";
        }

    }
}


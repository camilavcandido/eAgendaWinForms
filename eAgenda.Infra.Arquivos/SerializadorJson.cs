using eAgenda.Dominio;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace eAgenda.Infra.Arquivos
{
    public class SerializadorJson : ISerializador
    {
        private const string arquivoTarefas = @"C:\temp\eAgendaTarefas.json";
        private const string arquivoContatos = @"C:\temp\eAgendaContatos.json";
        private const string arquivoCompromissos = @"C:\temp\eAgendaCompromissos.json";

        public List<Tarefa> CarregarTarefasDoArquivo()
        {
            if (File.Exists(arquivoTarefas) == false)
                return new List<Tarefa>();

            string tarefasJson = File.ReadAllText(arquivoTarefas);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Tarefa>>(tarefasJson, settings);
        }

        public List<Contato> CarregarContatosDoArquivo()
        {
            if (File.Exists(arquivoContatos) == false)
                return new List<Contato>();

            string contatosJson = File.ReadAllText(arquivoContatos);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Contato>>(contatosJson, settings);
        }

        public List<Compromisso> CarregarCompromissosDoArquivo()
        {
            if (File.Exists(arquivoCompromissos) == false)
                return new List<Compromisso>();

            string compromissosJson = File.ReadAllText(arquivoCompromissos);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Compromisso>>(compromissosJson, settings);
        }

        public void GravarTarefasEmArquivo(List<Tarefa> tarefas)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string tarefasJson = JsonConvert.SerializeObject(tarefas, settings);

            File.WriteAllText(arquivoTarefas, tarefasJson);
        }

        public void GravarContatosEmArquivo(List<Contato> contatos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string contatosJson = JsonConvert.SerializeObject(contatos, settings);

            File.WriteAllText(arquivoContatos, contatosJson);
        }

        public void GravarCompromissosEmArquivo(List<Compromisso> compromissos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string compromissosJson = JsonConvert.SerializeObject(compromissos, settings);

            File.WriteAllText(arquivoCompromissos, compromissosJson);
        }
    }
}

﻿using eAgenda.Dominio;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace eAgenda.Infra.Arquivos
{
    public class SerializadorEmJsonDotnet : ISerializador
    {
        private const string arquivo = @"C:\temp\eAgendaDados.json";

        public DataContext CarregarDadosDoArquivo()
        {
            if (File.Exists(arquivo) == false)
                return new DataContext();

            string arquivoJson = File.ReadAllText(arquivo);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;
            settings.PreserveReferencesHandling = PreserveReferencesHandling.All;

            return JsonConvert.DeserializeObject<DataContext>(arquivoJson, settings);
        }

        public void GravarDadosEmArquivo(DataContext dados)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;
            settings.PreserveReferencesHandling = PreserveReferencesHandling.All;

            string arquivoJson = JsonConvert.SerializeObject(dados, settings);

            File.WriteAllText(arquivo, arquivoJson);
        }
    }
}

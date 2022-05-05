using eAgenda.Dominio;
using System.Collections.Generic;

namespace eAgenda.Infra.Arquivos
{
    public interface ISerializador
    {
        DataContext CarregarDadosDoArquivo();

        void GravarDadosEmArquivo(DataContext dados);
    }
}

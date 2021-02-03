using System.Collections.Generic;
using Projeto_de_Avaliacao_Senai.Models;

namespace Projeto_de_Avaliacao_Senai.Interfaces
{
    public interface IPublicacao
    {

        /*Exemplo*/
        /*
        void Create(Usuario u);

        List<Usuario> ReadAll();

        void Update(Usuario u);

        void Delete(int id);
        */        

        void CriarPublicacao(Publicacao p);
        List<Publicacao> ListarPublicacoes();
        void EditarPublicacao(Publicacao p);  
        void ExcluirPublicao(int id);  
        void Curtir(int id);

    }
}
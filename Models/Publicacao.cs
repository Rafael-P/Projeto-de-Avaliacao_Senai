using System.Collections.Generic;
using Projeto_de_Avaliacao_Senai.Interfaces;

namespace Projeto_de_Avaliacao_Senai.Models
{
    public class Publicacao : InstaBase, IPublicacao
    {
        
        public int IdPublicacao { get; set; }
        public string Imagem { get; set; }
        public string Legenda { get; set; }
        public int IdUsuario { get; set; }
        public int Likes { get; set; }

        /*Este PATH é criado para dar um nome ao Folder e File, sendo assim possível chamar o método que está na superclasse para cria-los*/
        private const string PATH = "Database/Publicacao.csv";
        public Publicacao(){
            CreateFolderAndFile(PATH);
        }


        public void CriarPublicacao(Publicacao p)
        {
            throw new System.NotImplementedException();
        }

        public void Curtir(int id)
        {
            throw new System.NotImplementedException();
        }

        public void EditarPublicacao(Publicacao p)
        {
            throw new System.NotImplementedException();
        }

        public void ExcluirPublicao(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Publicacao> ListarPublicacoes()
        {
            throw new System.NotImplementedException();
        }
    }
}
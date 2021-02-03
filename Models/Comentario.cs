using System.Collections.Generic;
using Projeto_de_Avaliacao_Senai.Interfaces;

namespace Projeto_de_Avaliacao_Senai.Models
{
    public class Comentario : InstaBase, IComentario
    {
        
        public int IdComentario { get; set; }
        public string Mensagem { get; set; }
        public int IdUsuario { get; set; }
        public int IdPublicacao { get; set; }

        /*Este PATH é criado para dar um nome ao Folder e File, sendo assim possível chamar o método que está na superclasse para cria-los*/
        private const string PATH = "Database/Comentario.csv";
        public Comentario(){
            CreateFolderAndFile(PATH);
        }


        public void CriarComentario(Comentario c)
        {
            throw new System.NotImplementedException();
        }

        public void EditarComentario(Comentario c)
        {
            throw new System.NotImplementedException();
        }

        public void ExcluirComentario(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Comentario> ListarComentarios()
        {
            throw new System.NotImplementedException();
        }
    }
}
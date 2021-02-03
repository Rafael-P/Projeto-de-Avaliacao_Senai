using System.Collections.Generic;
using Projeto_de_Avaliacao_Senai.Models;

namespace Projeto_de_Avaliacao_Senai.Interfaces
{
    public interface IComentario
    {

        /*Exemplo*/
        /*
        void Create(Usuario u);

        List<Usuario> ReadAll();

        void Update(Usuario u);

        void Delete(int id);
        */ 
        
        void CriarComentario(Comentario c);  
        List<Comentario> ListarComentarios();       
        void EditarComentario(Comentario c);
        void ExcluirComentario(int id); 

    }
}
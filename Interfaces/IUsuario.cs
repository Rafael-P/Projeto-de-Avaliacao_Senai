using System.Collections.Generic;
using Projeto_de_Avaliacao_Senai.Models;

namespace Projeto_de_Avaliacao_Senai.Interfaces
{
    public interface IUsuario
    {
        /*Exemplo*/
        /*
        void Create(Usuario u);

        List<Usuario> ReadAll();

        void Update(Usuario u);

        void Delete(int id);
        */

        void CadastrarUsuario(Usuario u);     
        Usuario MostrarUsuario(int id);    
        void EditarUsuario(Usuario u);               
        void DeletarUsuario(int id);
        List<Usuario> ListarUsuario();          
        Usuario Logar(string email, string senha); 
        void Seguir(int id);              
       
    }
}
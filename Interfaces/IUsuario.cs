using System.Collections.Generic;
using Projeto_de_Avaliacao_Senai.Models;

namespace Projeto_de_Avaliacao_Senai.Interfaces
{
    public interface IUsuario
    {
         void CadastrarUsuario(Usuario u);     
        Usuario MostrarUsuario(int id);    
        void EditarUsuario(Usuario u);               
        void DeletarUsuario(int id);
        List<Usuario> ListarUsuario();          
        void Seguir(int id);  
       
    }
}
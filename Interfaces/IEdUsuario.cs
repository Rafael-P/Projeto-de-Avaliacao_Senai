using System.Collections.Generic;
using Projeto_de_Avaliacao_Senai.Models;

namespace Projeto_de_Avaliacao_Senai.Interfaces
{
    public class IEdUsuario
    {
        
        //Contrato - Crud
        void Update(Usuario u);

        void Delete(string email);

    }
}
using System.Collections.Generic;
using System.IO;
using Projeto_de_Avaliacao_Senai.Interfaces;

namespace Projeto_de_Avaliacao_Senai.Models
{
    public class EdUsuario : InstaBase , IEdUsuario
    {
        
        public string Nome { get; set; }
        public string NUsuario { get; set; }
        public string Email { get; set; }
        
        private const string PATH = "Database/Equipe.csv";
        
        public EdUsuario()
        {
            CreateFolderAndFile(PATH);
        }
        
        //Criar linha CSV
        public string Prepare(EdUsuario u)
        {
            return $"{e.Nome};{e.NUsuario};{e.Email}";
        }

        

    }
}
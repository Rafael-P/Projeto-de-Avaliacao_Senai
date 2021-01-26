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
            return $"{u.Nome};{u.NUsuario};{u.Email}";
        }

        public void Delete(string email)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);

            //remove a linha com o email comparado
            linhas.RemoveAll( x => x.Split(";")[2] == email() );
        }

        public void Update(EdUsuario u)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);

            //remove a linha com o email comparado
            linhas.RemoveAll( x => x.Split(";")[2] == u.Email() );

            //adiciona novos dados na lista
            linhas.Add( Prepare(u) );

            //reescreve o csv com a lista alterada
            RewriteCSV(PATH, linhas);
        }


    }
}
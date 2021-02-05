using System;
using System.Collections.Generic;
using System.IO;
using Projeto_de_Avaliacao_Senai.Interfaces;

namespace Projeto_de_Avaliacao_Senai.Models
{
    public class Usuario : InstaBase, IUsuario
    {
        
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Seguidos { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }


        /*Este PATH é criado para dar um nome ao Folder e File, sendo assim possível chamar o método que está na superclasse para cria-los*/
        private const string PATH = "Database/Usuario.csv";
        public Usuario()
        {
            CreateFolderAndFile(PATH);
        }

        /*Abaixo será criado um metódo para preparar a linha do CSV*/
        public string Prepare(Usuario u)
        {
            /*Aqui vamos retornar todos as "caracteristicas" necessarias para criar um usuario para colocar no csv*/
            return $"{u.IdUsuario};{u.Nome};{u.Foto};{u.DataNascimento};{u.Seguidos};{u.Email};{u.Username};{u.Senha}";
        }
        public void CadastrarUsuario(Usuario u)
        {
            string[] linha = {Prepare(u)};
            File.AppendAllLines(PATH, linha);
        }

        public void DeletarUsuario(int id)
        {

            List<string> linhas = ReadAllLinesCSV(PATH);

            //remove a linha que tiver o id igual ao comparado
            linhas.RemoveAll( x => x.Split(";")[0] == IdUsuario.ToString() );

        public List<Usuario> ListarUsuario()
        {
            
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll( x => x.Split(";")[0] == u.IdUsuario.ToString() );
            linhas.Add( Prepare(u) );
            RewriteCSV(PATH, linhas);

        }

        public void EditarUsuario(Usuario u)
        {
            
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll( x => x.Split(";")[0] == u.IdUsuario.ToString() );
            linhas.Add( Prepare(u) );
            RewriteCSV(PATH, linhas);

        }

        public Usuario Logar(string email, string senha)
        {
            throw new NotImplementedException();
        }

       /*Abaixo será criado um metódo para preparar a linha do CSV*/
        public string Prepare(Usuario u)
        {
            /*Aqui vamos retornar todos as "caracteristicas" necessarias para criar um usuario para colocar no csv*/
            return $"{u.IdUsuario};{u.Foto};{u.Nome};{u.Seguidos};{u.Username}";
        }

        public void CadastrarUsuario(Usuario u)
        {
            string[] linha = {Prepare(u)};
            File.AppendAllLines(PATH, linha);
        }
        
        //Perfil
        public List<Usuario> MostrarUsuario(int id) 
        {
            List<Usuario> usuarios = new List<Usuario>();
            string[] linhas = File.ReadAllLines(PATH);
            
            foreach (var item in linhas)
            {
                string [] linha = item.Split(";");

                Usuario usuario   = new Usuario();
                usuario.IdUsuario       = int.Parse (linha[0]);
                usuario.Foto            = linha[1];
                usuario.Nome            = linha[2];
                usuario.Seguidos        = Int32.Parse (linha[3]);
                usuario.Username        = linha[4];
            }
            return usuarios;
        }

        public string Prepare(Usuario u)
        {
            throw new NotImplementedException();
        }

        public void Seguir(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
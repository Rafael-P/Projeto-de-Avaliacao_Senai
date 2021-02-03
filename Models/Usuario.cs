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

        private const string PATH = "Database/Usuario.csv";
        public Usuario()
        {
            CreateFolderAndFile(PATH);
        }
        public string Prepare(Usuario u)
        {
            return $"{u.IdUsuario};{u.Nome};{u.Foto};{u.DataNascimento};{u.Seguidos};{u.Email};{u.Username};{u.Senha}";
        }
       

        public void CadastrarUsuario(Usuario u)
        {
            
            string[] linha = {Prepare(u)};
            File.AppendAllLines(PATH, linha);
        }

        public Usuario MostrarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public void EditarUsuario(Usuario u)
        {
            throw new NotImplementedException();
        }

        public void DeletarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListarUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Usuario usuario = new Usuario();
                usuario.IdUsuario = Int32.Parse(linha[0]);
                usuario.Email = linha[1];
                usuario.DataNascimento = DateTime.Parse(linha[2]);
                usuario.Nome = linha[3];
                usuario.Username = linha[4];
                usuario.Senha = linha[5];
                
            }
            return usuarios;
        }

        public void Seguir(int id)
        {
            throw new NotImplementedException();
        }
    }
}
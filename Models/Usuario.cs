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
        public string Name { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }

        public void Create(Usuario u)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario u)
        {
            throw new NotImplementedException();
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
                usuario.IdUsuario = linha[];
                usuario.Nome      = linha[];
                usuario.Foto      = linha[];
                usuario.Seguidos  = linha[];
                
            }
            return usuarios;
        }


    }
}
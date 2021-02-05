using System;
using System.Collections.Generic;
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


        internal dynamic ReadAll()
        {
            throw new NotImplementedException();
        }
        public void CadastrarUsuario(Usuario u)
        {
            throw new NotImplementedException();
        }

        public void DeletarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public void EditarUsuario(Usuario u)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListarUsuario()
        {
            throw new NotImplementedException();
        }

        public Usuario Logar(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Usuario MostrarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public string Prepare(Usuario u)
        {
            throw new NotImplementedException();
        }

        public void Seguir(int id)
        {
            throw new NotImplementedException();
        }
    }
}
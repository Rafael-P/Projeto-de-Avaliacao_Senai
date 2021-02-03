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


        /*Este PATH é criado para dar um nome ao Folder e File, sendo assim possível chamar o método que está na superclasse para cria-los*/
        private const string PATH = "Database/Usuario.csv";
        public Usuario(){
            CreateFolderAndFile(PATH);
        }

        /*Abaixo será criado um metódo para preparar a linha do CSV*/
        public string Prepare(Usuario u)
        {
            /*Aqui vamos retornar todos as "caracteristicas" necessarias para criar um usuario para colocar no csv*/
            return "";
        }

        public void CadastrarUsuario(Usuario u)
        {
            
        }

        public void DeletarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public void EditarUsuario(Usuario u)
        {
            throw new NotImplementedException();
        }

        public void Logar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> MostrarUsuario()
        {
            throw new NotImplementedException();
        }

        public void Seguir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListarUsuario()
        {
            throw new NotImplementedException();
        }

        public Usuario MostrarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Logar(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [TempData] public string Mensagem { get; set; }


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

        /*Foi criado essa função para buscar os comentarios feitos na IdPublicacao especifica*/
        public Usuario MostrarUsuario(int IdUsuario)
        {
            /*Colocar só o find, pois estará procurando só um IdUsuario*/
            Usuario usuario = ListarUsuario().Find(x => x.IdUsuario == IdUsuario);

            return usuario;
        }  

        public void EditarUsuario(Usuario u)
        {
            
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll( x => x.Split(";")[0] == u.IdUsuario.ToString() );
            linhas.Add( Prepare(u) );
            RewriteCSV(PATH, linhas);

        }

        public void DeletarUsuario(int id)
        {

            List<string> linhas = ReadAllLinesCSV(PATH);

            //remove a linha que tiver o id igual ao comparado
            linhas.RemoveAll( x => x.Split(";")[0] == id.ToString() );
            RewriteCSV(PATH, linhas);
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
                usuario.Nome = linha[1];
                usuario.Foto = linha[2];
                usuario.DataNascimento = DateTime.Parse(linha[3]);
                usuario.Seguidos = Int32.Parse(linha[4]);
                usuario.Email = linha[5];
                usuario.Username = linha[6];
                usuario.Senha = linha[7];
                
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public void Seguir(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Logar(string email, string senha)
        {
            //Leitura de todos os arquivos CSV
            List<string> csv = ReadAllLinesCSV("Database/Usuario.csv");

            // Verificação das informações passadas na lista de string
            var linhaCSV = csv.Find(
            x => 
            x.Split(";")[2] == email && 
            x.Split(";")[3] == senha
            );

            string[] UsuarioLinha = linhaCSV.Split(";");

            Usuario usuarioBuscado = new Usuario();

            usuarioBuscado.IdUsuario = int.Parse(UsuarioLinha[0]);
            usuarioBuscado.Nome = UsuarioLinha[1];
            usuarioBuscado.Email= UsuarioLinha[5];
            usuarioBuscado.Senha = UsuarioLinha[7];
            usuarioBuscado.DataNascimento = DateTime.Parse(UsuarioLinha[3]);

            //Retorno dos usuários encontradas 
            return usuarioBuscado;
        } 

    }
}
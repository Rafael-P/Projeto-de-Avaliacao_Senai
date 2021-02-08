using System.Collections.Generic;
using System.IO;
using Projeto_de_Avaliacao_Senai.Interfaces;

namespace Projeto_de_Avaliacao_Senai.Models
{
    public class Comentario : InstaBase, IComentario
    {
        
        public int IdComentario { get; set; }
        public string Mensagem { get; set; }
        public int IdUsuario { get; set; }
        public int IdPublicacao { get; set; }

        /*Este PATH é criado para dar um nome ao Folder e File, sendo assim possível chamar o método que está na superclasse para cria-los*/
        private const string PATH = "Database/Comentario.csv";
        public Comentario(){
            CreateFolderAndFile(PATH);
        }

    
        public string Prepare(Comentario c){
            return $"{c.IdComentario};{c.Mensagem};{c.IdUsuario};{c.IdPublicacao}";
        }

        public void CriarComentario(Comentario c)
        {
            /*Foi preparado um array de string para armazenar o Prepare*/
            string[] linhas = {Prepare(c)};
            /*Acrecentamos uma nova linha na PATH*/
            File.AppendAllLines(PATH, linhas);
        }

        public List<Comentario> ListarComentarios()
        {
            
            List<Comentario> comentarios = new List<Comentario>();

            /*Array para ler todas a linhas od CSV*/
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string item in linhas)
            {
                string[] linha = item.Split(";");

                Comentario novoComentario = new Comentario();

                novoComentario.IdComentario = int.Parse(linha[0]);
                novoComentario.Mensagem = linha[1];
                novoComentario.IdUsuario = int.Parse(linha[2]);
                novoComentario.IdPublicacao = int.Parse(linha[3]);
            
                comentarios.Add(novoComentario);
            }

            return comentarios;
        }

        public void EditarComentario(Comentario c)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            /*Foi removido a linha pela comparação abaixo*/
            linhas.RemoveAll(x => x.Split(";")[0] == c.IdComentario.ToString());
            /*Adicionamos a linha alterada*/
            linhas.Add(Prepare(c));
            /*Reescrevemos o cvs com a linha alterada*/
            RewriteCSV(PATH, linhas);
        }

        public void ExcluirComentario(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            /*Foi removido a linha pela comparação abaixo*/
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            /*Reescrevemos o cvs com a linha alterada*/
            RewriteCSV(PATH, linhas);
        }

        /*Foi criado uma função adicional para buscar os comentarios feitos na IdPublicacao especifica*/
        public List<Comentario> BuscarPorId(int IdPublicacao)
        {
            
            List<Comentario> comentarios = ListarComentarios().FindAll(x => x.IdPublicacao == IdPublicacao);

            return comentarios;
        }
    }
}
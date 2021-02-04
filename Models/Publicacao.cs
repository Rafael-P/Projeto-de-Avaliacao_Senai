using System.Collections.Generic;
using System.IO;
using Projeto_de_Avaliacao_Senai.Interfaces;

namespace Projeto_de_Avaliacao_Senai.Models
{
    public class Publicacao : InstaBase, IPublicacao
    {
        
        public int IdPublicacao { get; set; }
        public string Imagem { get; set; }
        public string Legenda { get; set; }
        public int IdUsuario { get; set; }
        public int Likes { get; set; }

        /*Este PATH é criado para dar um nome ao Folder e File, sendo assim possível chamar o método que está na superclasse para cria-los*/
        private const string PATH = "Database/Publicacao.csv";
        public Publicacao(){
            CreateFolderAndFile(PATH);
        }


        public string Prepare(Publicacao p){
            return $"{p.IdPublicacao};{p.Imagem};{p.Legenda};{p.IdUsuario};{p.Likes}";
        }
        
        public void CriarPublicacao(Publicacao p)
        {
            /*Foi preparado um array de string para armazenar o Prepare*/
            string[] linhas = {Prepare(p)};
            /*Acrecentamos uma nova linha na PATH*/
            File.AppendAllLines(PATH, linhas);
        }        
        
        public List<Publicacao> ListarPublicacoes()
        {
            
            List<Publicacao> publicacoes = new List<Publicacao>();

            /*Array para ler todas a linhas od CSV*/
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string item in linhas)
            {
                string[] linha = item.Split(";");

                Publicacao novaPublicacao = new Publicacao();

                novaPublicacao.IdPublicacao = int.Parse(linha[0]);
                novaPublicacao.Imagem = linha[1];
                novaPublicacao.Legenda = linha[2];
                novaPublicacao.IdUsuario = int.Parse(linha[3]);
                novaPublicacao.Likes = int.Parse(linha[4]);

                publicacoes.Add(novaPublicacao);
            }

            return publicacoes;
        }
        public void EditarPublicacao(Publicacao p)
        {
            throw new System.NotImplementedException();
        }
        public void ExcluirPublicao(int id)
        {
            throw new System.NotImplementedException();
        }

    
        public void Curtir(int id)
        {
            throw new System.NotImplementedException();
        }




    }
}
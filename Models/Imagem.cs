namespace Projeto_de_Avaliacao_Senai.Models
{
    public class Imagem : InstaBase

    
    {
        public string Imagens { get; set; }


        private const string PATH = "Database/Imagens.csv";
        public Imagem()
        {
            CreateFolderAndFile(PATH);
        }

        public string Prepare(Imagem m){
            return $"{m.Imagens}";
        }


    }
}
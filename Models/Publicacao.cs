namespace Projeto_de_Avaliacao_Senai.Models
{
    public class Publicacao
    {
        
        public int IdPublicacao { get; set; }
        public string Imagem { get; set; }
        public string Legenda { get; set; }
        public int IdUsuario { get; set; }
        public int Likes { get; set; }
        
    }
}
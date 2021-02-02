namespace Projeto_de_Avaliacao_Senai.Models
{
    public class Comentario
    {
        
        public int IdComentario { get; set; }
        public string Mensagem { get; set; }
        public int IdUsuario { get; set; }
        public int IdPublicacao { get; set; }

    }
}
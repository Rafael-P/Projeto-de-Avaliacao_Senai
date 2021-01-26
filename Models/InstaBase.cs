using System.Collections.Generic;
using System.IO;

namespace Projeto_de_Avaliacao_Senai.Models
{
    public class InstaBase
    {
        
        public void RewriteCSV(string path, List<string> linhas)
        {
            //StreamWriter -> escreve dados em um arquivo
            using(StreamWriter output = new StreamWriter(path))
            {
                foreach (var item in linhas)
                {
                    output.Write(item + '\n');
                }
            }
        }
        

    }
}
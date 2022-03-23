using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SopaDeLetras
{
   public class Jogador
    {   
        public string nome;
        public string tempo;
       
        public Jogador(string nome,string tempo)
        {
            this.nome = nome;
            this.tempo = tempo;          
        }

        public string Nome { get => nome; set => nome = value; }
        public string Tempo { get => tempo; set => tempo = value; }
    }
}

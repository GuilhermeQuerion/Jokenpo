using ConsoleApp1.NewFolder1;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    public class Jokenpo : IRegras {

        public string Jogador1 { get; set; }
        public string Jogador2 { get; set; }

        public Jokenpo(string jogador1,string jogador2)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;
        }

        private readonly string[] Opcoes = { "pedra", "papel", "tesoura" };
        private readonly string[] Resultados  = { "Empate", "Jogador1 venceu!", "Jogador2 venceu!" };

        public int CalcularResultado()
        {
            int indexJogador1 = Array.IndexOf(Opcoes, Jogador1.ToLower());
            int indexJogador2 = Array.IndexOf(Opcoes, Jogador2.ToLower());

            return (indexJogador1 - indexJogador2 + Opcoes.Length) % Opcoes.Length == 1 ? 1 :
                   (indexJogador2 - indexJogador1 + Opcoes.Length) % Opcoes.Length == 1 ? 2 :
                   0;
        }

        public string ResultadoPartida()
        {
            var resultado = this.CalcularResultado();
            return this.Resultados[resultado];
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args)
        {

            var usr1 = "pedra";
            var user2= "papel";

            Jokenpo jokepo = new Jokenpo(usr1,user2);
            var resultado = jokepo.ResultadoPartida();
            Console.WriteLine(resultado);

            Thread.Sleep(10000);
        }
    }
}
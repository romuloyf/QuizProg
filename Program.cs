using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuiz
{
    class Program
    {
        static string Pergunta1;
        static string Pergunta2;
        static string Pergunta3;
        static string Pergunta4;
        static string Pergunta5;


        static void Main(string[] args)
        {
            Perguntas();
            Console.Read();
        }

        public static void Perguntas()
        {
            //Quiz1
            Console.WriteLine("Qual Animal faz Miau?");
            Pergunta1 = Console.ReadLine();
            if (Pergunta1 == "gato")
            {
                Console.WriteLine("Acertou");
                
            }
            else
            {
                Console.WriteLine("Errou, a resposta era GATO");
            }

            

            //Quiz2
            Console.WriteLine("Qual Animal faz AuAu?");
            Pergunta2 = Console.ReadLine();
            if (Pergunta2 == "cachorro")
            {
                Console.WriteLine("Acertou");
            }
            else
            {
                Console.WriteLine("Errou, a resposta era CACHORRO");
            }


            //Quiz3
            Console.WriteLine("Qual Animal é conhecido como O HAMSTER GIGANTE BRASILEIRO?");
            Pergunta3 = Console.ReadLine();
            if (Pergunta3 == "capivara")
            {
                Console.WriteLine("Acertou");
            }
            else
            {
                Console.WriteLine("Errou, a resposta era CAPIVARA");
            }

            //Quiz4
            Console.WriteLine("Qual Animal estará na nota de REAL de R$200?");
            Pergunta4 = Console.ReadLine();
            if (Pergunta4 == "lobo guará")
            {
                Console.WriteLine("Acertou");
            }
            else
            {
                Console.WriteLine("Errou, a resposta é o LOBO GUARÁ");
            }

            //Quiz5
            Console.WriteLine("Qual Animal é o maior felino do Mundo?");
            Pergunta5 = Console.ReadLine();
            if (Pergunta5 == "tigre")
            {
                Console.WriteLine("Acertou");
            }
            else
            {
                Console.WriteLine("Errou, a resposta é TIGRE");
            }

        }

    }
}

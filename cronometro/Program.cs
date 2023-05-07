using System;
using System.Threading;

namespace cronometro {  
    class Program { 
        static void Main(string[] args) {
            MenuCronometro();
        }
        static void MenuCronometro() {
            Console.Clear();
            Console.WriteLine("Quando colocar S ele será convertido para 10, valendo 10 segundos na contagem");
            Console.WriteLine("Quando colocar M ele será convertido para 60, valendo 60 segundos na contagem");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int tempo = int.Parse(data.Substring(0, data.Length - 1));
            int valorMinutos = 1;

            if (type == 'm') valorMinutos = 60;
            if (tempo == 0) System.Environment.Exit(0);

            PreComeco(tempo * valorMinutos);
        }
        static void PreComeco(int tempo) {
            Console.Clear();
            Console.Write("Ready");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(500);
            Console.Clear();
            Console.Write("Set");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(500);
            Console.Clear();
            Console.Write("Go!");
            Thread.Sleep(1000);

            Comeco(tempo);
        }
        static void Comeco(int tempo) {
            int tempoCorrendo = 0;
            
            while (tempoCorrendo != tempo) {
                Console.Clear();
                tempoCorrendo++;
                Console.WriteLine(tempoCorrendo);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronometro Finalizado");
            Thread.Sleep(2500);
            MenuCronometro();
        }
    }
}
using System;
using System.Threading;

namespace cronometro {  
    class Program { 
        static void Main(string[] args) {
            MenuCronometro();
        }
        static void MenuCronometro() {


            PreComeco();
        }
        static void PreComeco() {

            Comeco();
        }
        static void Comeco() {

            MenuCronometro();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Ejercicio01
    {
        //retornar numeros
        void Imprimir(int x)
        {
            Console.Write(x + " ");
            Imprimir(x - 1);
        }

        static void Main(string[] args)
        {
            Ejercicio01 re = new Ejercicio01();
            re.Imprimir(5);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arreglo = new int[12];
            string cadena;
            for (int i = 0; i < 12; i++)
            {
                cadena = Console.ReadLine();
                Arreglo[i] = Convert.ToInt32(cadena);
            }
            for (int i = 0; i < 12; i++)
            {   
                //Imprimer lo que contiene este arreglo
                Console.WriteLine("{0}", Arreglo[i]);
            }
            //Detenga la pantalla fuera del 
            Console.ReadKey();
        }
    }
}

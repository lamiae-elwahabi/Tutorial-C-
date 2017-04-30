using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion10
{
    public class clsMatrices
    {
        private int[,] Matriz;
        //Constructor 
        public clsMatrices()
        {
            //Arreglo de dos diminsiones
            Matriz = new int[4, 2];
        }
        //Metodo
        public void IncializaMatriz()
        {
            for (int i = 0; i <4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Matriz[i, j] = 2;
                }
            }
        }
        public void ImprimeMatriz()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", Matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

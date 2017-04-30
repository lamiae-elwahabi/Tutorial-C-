using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion11
{
    class clsMostrarArrayList
    {
        ArrayList Lista = new ArrayList();

        //Constructor para poder instanciar
        public clsMostrarArrayList()
        {
          }
        //Metodos
        public void CapturarDatos()
        {
            string cadena;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Dame el dato {0}: ", i + 1);
                cadena = Console.ReadLine();
                Lista.Add(cadena);

            }
        }
        public void ImprimeDatos()
        {
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

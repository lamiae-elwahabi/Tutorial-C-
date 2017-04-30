using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion8
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesConContacto cliente = new clsClientesConContacto(0, "Lamiae EL Wahabi",
                                                            "001", "HERM",
                                                            1, "Lamiae EL Wahabi",
                                                            "627263524", "", "lamkj@hotmail.com", "Calle tomas rullan", "119",
                                                            "", "La cueva del jaguer", "Palma", "Son Gotleu", "07008");
            //Instanciar  el objeto impresion de la interfaz                           
            intSalidas Impresion;
            string cadena = Console.ReadLine();
            if (cadena == "1")
                Impresion = new clsImpresion();
            else
                Impresion = new clsArchivos();
            try
            {
                Impresion.ImprimeCliente(cliente);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ocurrio un error: " + e.Message);
                Console.ReadKey();
            }
        }
    }
}

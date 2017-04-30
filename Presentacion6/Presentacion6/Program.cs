using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion6
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Instanciar el objeto cliente de la clase clsClientesVentas
            clsClientesVentas Cliente = new clsClientesVentas();
            //Asignar el valor de las propiedades de las clases
            Cliente.IdCliente = 123;
            Cliente.Apellido = "EL Wahabi";
            Cliente.Nombres = "Lamiae";
            Cliente.RFC = "HFF";
            Cliente.Direccion = "Calle Tomas Rullan Nº56 PISO 03 PTA 15";
            Cliente.Colonia = "La cueva de Hercules";
            Cliente.Municipio = "Palma de Mallorca";
            Cliente.EsCredito = true;
            //Imprimer estos valores por pantalla
            Console.WriteLine(Cliente.Apellido + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia + " " + Cliente.Municipio);
            Console.WriteLine(Cliente.RFC);
            if (Cliente.EsCredito)
                Console.WriteLine("El cliente tiene credito");
            else
                Console.WriteLine("El cliente no tiene credito");
            Console.ReadKey();



        }
    }
}

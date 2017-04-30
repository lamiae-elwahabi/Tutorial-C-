using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion6
{
    public  class clsClientes
    {   
        //Propiedades 
        private int _IdCliente;
        private string _Nombres;
        private string _Apellidos;
        //Getters y Setters
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellido { get => _Apellidos; set => _Apellidos = value; }
    }
}

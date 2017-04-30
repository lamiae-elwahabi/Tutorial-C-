using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{
    class clsArchivos : intSalidas
    {
        public void ImprimeCliente(clsAbsClientes cliente)
        {
            StreamWriter ar = new StreamWriter(@"C:\Users\Lamiae\Documents\ArchaBitacora.log", true);
            ar.WriteLine(cliente.Clave + " " + cliente.Nombre);
            if (cliente.TipoRegimen == 1)
                ar.WriteLine("Tipo: PERSONA FISICA");
            else
                ar.WriteLine("Tipo: PERSONA MORAL");
            ar.WriteLine("RFC: " + cliente.RFC);
            ar.Close();
        }
        public void ImprimeDireccion(clsDirecciones direccion)
        {
            StreamWriter ar = new StreamWriter(@"C:\Users\Lamiae\Documents\ArchaBitacora.log", true);
            ar.Close();

        }

    }
}

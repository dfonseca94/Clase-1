using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NombreFormateado
    {
        private string elNombreEnMayuscula;

        public NombreFormateado(string elNombre)
        {
            elNombreEnMayuscula = elNombre.ToUpper();
        }

        public string ConUnSaludo()
        {
            return "Hola " + elNombreEnMayuscula;
        }
    }
}

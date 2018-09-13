using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Reptil: Animal
    {
        public string cambioPiel()
        {
            return Nombre + " cambio piel";
        }

        override public string desplazar()
        {
            return Nombre + " esta caminando";
        }
    }
}

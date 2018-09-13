using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract class Animal
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }

        abstract public string desplazar();
        
    }
}

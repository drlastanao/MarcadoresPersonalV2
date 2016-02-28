using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMarcadoresV2
{
    [Serializable()]
    public class NodoPrincipal
    {

        public List<Carpeta> carpetas;
        public List<Enlace> enlaces;

        public NodoPrincipal()
        {
            carpetas = new List<Carpeta>();
            enlaces = new List<Enlace>();

        }
    }
}

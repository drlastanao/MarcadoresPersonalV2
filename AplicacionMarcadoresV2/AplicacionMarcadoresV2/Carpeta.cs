using System;
using System.Collections.Generic;

namespace AplicacionMarcadoresV2
{
    [Serializable]
    public class Carpeta
    {

        public string tipo = "Carpeta";
        public string ruta;
        public string descripcion;
        public List<string> subcarpetas;


        public Carpeta()
        {
            subcarpetas = new List<string>();
        }

        public bool buscar(String texto)
        {
            return Utiles.Contains(tipo, texto, StringComparison.CurrentCultureIgnoreCase) ||
                   Utiles.Contains(ruta, texto, StringComparison.CurrentCultureIgnoreCase) ||
                   Utiles.Contains(descripcion, texto, StringComparison.CurrentCultureIgnoreCase) ||
                   buscarSubCarpetas(texto);

        }

        private bool buscarSubCarpetas(string texto)
        {
            bool encontrado = false;

            foreach (var item in subcarpetas)
            {
                if (Utiles.Contains(item, texto, StringComparison.CurrentCultureIgnoreCase))
                {
                    encontrado = true;
                    break;

                }
            }

            return encontrado;

        }
    }
}
using System;
using System.Collections.Generic;

namespace AplicacionMarcadoresV2
{
    [Serializable()]
    public class Carpeta
    {

        public String tipo { get; set; }
        public String ruta { get; set; }
        public String descripcion { get; set; }
    public List<String> subcarpetas;


        public Carpeta()
        {
            tipo = "Carpeta";

            subcarpetas = new List<String>();
        }

        public bool buscar(String texto)
        {
            return texto==""||
                   Utiles.Contains(tipo, texto, StringComparison.CurrentCultureIgnoreCase) ||
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
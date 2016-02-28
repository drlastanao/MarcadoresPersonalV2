using System;
using System.Collections.Generic;

namespace AplicacionMarcadoresV2
{
    [Serializable()]
    public class Enlace
    {
        public String tipo { get; set; }
        public String url{ get; set; }
    public String descripcion { get; set; }
        public List<String> subenlaces;



        public Enlace()
        {
            tipo = "Enlace";
            subenlaces = new List<String>();
        }


        public bool buscar(String texto)
        {
            return texto=="" ||
                   Utiles.Contains(tipo, texto, StringComparison.CurrentCultureIgnoreCase) ||
                   Utiles.Contains(url, texto, StringComparison.CurrentCultureIgnoreCase) ||
                   Utiles.Contains(descripcion, texto, StringComparison.CurrentCultureIgnoreCase) ||
                   buscarSubEnlaces(texto);

        }

        private bool buscarSubEnlaces(string texto)
        {
            bool encontrado = false;

            foreach (var item in subenlaces)
            {
                if (Utiles.Contains(item,texto,StringComparison.CurrentCultureIgnoreCase))
                {
                    encontrado = true;
                    break;

                }
            }

            return encontrado;

            }
        }

       
}
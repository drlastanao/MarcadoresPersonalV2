﻿using System;
using System.Collections.Generic;

namespace AplicacionMarcadoresV2
{
    [Serializable]
    public class Enlace
    {
        public string tipo = "Carpeta";
        public string url;
        public string descripcion;
        public List<string> subenlaces;



        public Enlace()
        {
            subenlaces = new List<string>();
        }


        public bool buscar(String texto)
        {
            return Utiles.Contains(tipo, texto, StringComparison.CurrentCultureIgnoreCase) ||
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
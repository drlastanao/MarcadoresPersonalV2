using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace AplicacionMarcadoresV2
{
    public partial class Principal : Form
    {
        private NodoPrincipal nodo = new NodoPrincipal();
        private string fichero = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\datos.xml";
        private Boolean cambios = false;


        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            CargarFichero();

            //codigo de pruebas

            Enlace enlace = new Enlace();
            enlace.url = "http://www.google.es";
            enlace.descripcion = "El mejor buscador";

            nodo.enlaces.Add(enlace);


            Carpeta carpeta = new Carpeta();
            carpeta.ruta="c:\\pu\\";
            carpeta.descripcion = "Pruebas";

            nodo.carpetas.Add(carpeta);




        }

        private void CargarFichero()
        {
            XmlTextReader xmlReader = new XmlTextReader(fichero) ;

            try
            {
                XmlSerializer objreader = new XmlSerializer(nodo.GetType());
                nodo = (NodoPrincipal)objreader.Deserialize(xmlReader);


            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar fichero, ojo! al salir");
            }
            finally
            {
                xmlReader.Close();
            }
        }


        public void GuardarFichero()
        {
            if (cambios == true)
            {
                XmlSerializer objWriter = new XmlSerializer(nodo.GetType());
                StreamWriter objfile = new StreamWriter(fichero);
                objWriter.Serialize(objfile, nodo);
                objfile.Close();
            }

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarFichero();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            String texto = textBox1.Text.Trim();

            List<Enlace> auxEnlaces = new List<Enlace>();

            foreach (var enlace in nodo.enlaces)
                if (enlace.buscar(texto))
                    auxEnlaces.Add(enlace);


            dataGridView1.DataSource = auxEnlaces;
   

            List<Carpeta> auxCarpetas = new List<Carpeta>();

            foreach (var carpeta in nodo.carpetas)
                if (carpeta.buscar(texto))
                    auxCarpetas.Add(carpeta);


            dataGridView2.DataSource = auxCarpetas;


        }
    }
}

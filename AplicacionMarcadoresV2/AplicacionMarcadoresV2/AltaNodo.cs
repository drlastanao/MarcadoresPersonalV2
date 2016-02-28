using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Diagnostics;

namespace AplicacionMarcadoresV2
{
    public partial class AltaNodo : Form
    {
        public Carpeta carpeta = null;
        public Enlace enlace = null;
        public bool guardar = false;
        public AltaNodo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = Interaction.InputBox("Introduzca carpetas/rutas separadas por ; " , "Introducir Subnodos", "");

            if (resultado != "")
                listBox1.Items.AddRange(resultado.Split(';'));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void AltaNodo_Load(object sender, EventArgs e)
        {
            if (carpeta != null)
            {
                btDirectorios.Visible = true;

                 textBox1.Text= carpeta.ruta ;
                 textBox2.Text= carpeta.descripcion;
                
                foreach (var item in carpeta.subcarpetas)
                    listBox1.Items.Add(item.ToString());


            }
            if (enlace!=null)
            {
                btAdd.Visible = true;
                btQuitar.Visible = true;

                textBox1.Text = enlace.url;
                textBox2.Text = enlace.descripcion;

                foreach (var item in enlace.subenlaces)
                    listBox1.Items.Add(item.ToString());

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<String> resultado = RecorrerDirectorios(textBox1.Text);

            foreach (var item in resultado)
                listBox1.Items.Add(item);

        }


        public List<String>  RecorrerDirectorios (string ruta)
        {
            
            System.IO.DirectoryInfo[] subDirs = null;
            List<String> directorios = new List<String>();


            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(ruta);

            try
            {
                
              

                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    directorios.Add(dirInfo.FullName);
                }

                return directorios;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al recorrer ruta!");
                return new List<string>();
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guardar = true;
            if (carpeta!=null)
            {
                carpeta.ruta = textBox1.Text;
                carpeta.descripcion = textBox2.Text;
                carpeta.subcarpetas.Clear();
                foreach (var item in listBox1.Items)
                    carpeta.subcarpetas.Add(item.ToString());
                
            }

            if (enlace != null)
            {
                enlace.url = textBox1.Text;
                enlace.descripcion = textBox2.Text;
                enlace.subenlaces.Clear();
                foreach (var item in listBox1.Items)
                    enlace.subenlaces.Add(item.ToString());

            }
            Close();
        }

        

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>-1)
                Process.Start(listBox1.Items[listBox1.SelectedIndex].ToString());

        }
    }
}

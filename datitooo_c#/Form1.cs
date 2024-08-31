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

namespace datitooo_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            string edad = tbEdad.Text;
            string estatura = tbEstatura.Text;
            string telefono = tbTelefono.Text;

            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }

            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }

            string datos = $"Nombre: {nombre} \r\nApellidos: {apellido} \r\nEdad: {edad} \r\nTelefono: {telefono}  \r\nEstatura: {estatura} \r\nGenero: {genero}";
            string rutaArchivos = "C:\\Users\\fernanda\\Documents\\TXT.txt";
            //File.WriteAllText(rutaArchivos,datos);

            bool archivoExiste = File.Exists(rutaArchivos);

            using (StreamWriter writer = new StreamWriter(rutaArchivos, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);
            }
            MessageBox.Show("Datos Guardados:\n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();   
            tbApellido.Clear(); 
            tbEdad.Clear(); 
            tbEstatura.Clear();
            tbTelefono.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;    
        }
    }
}

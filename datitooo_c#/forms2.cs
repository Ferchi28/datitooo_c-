﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datitooo_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbNombre.Leave += checkNames;
            tbApellido.Leave += checkNames;
            tbEdad.Leave += checkAge;
            tbEstatura.Leave += checkHeight;
            //tbPhone.TextChanged += checkPhone;
            tbTelefono.Leave += checkPhone;
        }
        private bool isValidInt(string str)
        {
            int result;
            return int.TryParse(str, out result);
        }
        private bool isValidFloat(string str)
        {
            decimal result;
            return decimal.TryParse(str, out result);
        }
        private bool isValidTenDigitNum(string str)
        {
            long result;
            return long.TryParse(str, out result) && str.Length == 10;
        }
        private bool isValidText(string str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z\s]+$");
        }

        private void checkAge(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length != 0)
            {
                if (!isValidInt(textBox.Text))
                {
                    MessageBox.Show("Ingrese un valor valido para edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
        }

        private void checkHeight(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length != 0)
            {
                if (!isValidFloat(textBox.Text))
                {
                    MessageBox.Show("Ingrese un valor valido para altura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
        }

        private void checkNames(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length != 0)
            {
                if (!isValidText(textBox.Text))
                {
                    MessageBox.Show("Ingrese un valor valido para nombre y apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
        }

        private void checkPhone(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length != 0)
            {
                if (!isValidTenDigitNum(textBox.Text))
                {
                    MessageBox.Show("Ingrese un valor valido para un número de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
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
            string rutaArchivos = "C:\\Users\\CHIOH\\Documents\\TXT.txt";
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

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
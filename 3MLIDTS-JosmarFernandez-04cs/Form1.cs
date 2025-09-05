using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3MLIDTS_JosmarFernandez_04cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtEdad.Clear();
            txtEstatura.Clear();
            txtTelefono.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            rbnMasculino.Checked = false;
            rbnFemenino.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Text;
            string apellido = txtApellido.Text;
            string est = txtEstatura.Text;
            string num = txtTelefono.Text;
            string edad = txtEdad.Text;
            string genero = "";
            if (rbnMasculino.Checked)
            {
                genero = "Hombre";
            }
            else if (rbnFemenino.Checked)
            {

                genero = "Mujer";
            }
            if (!string.IsNullOrEmpty(txtEdad.Text) || !string.IsNullOrEmpty(txtEstatura.Text) || !string.IsNullOrEmpty(txtNombre.Text) || !string.IsNullOrEmpty(txtTelefono.Text) || !string.IsNullOrEmpty(txtApellido.Text))
            {
                String datos = $"Nombre:{name}\n\rApellido:{apellido}\n\r Edad:{edad} \n\r Altura: {est} \n\r Telefono: {num} \n\r Sex: {genero}";
                string ruta = @"C:\Users\craft\Documents\Códigos\txt\Datos3MAgosto2025.txt";
                bool archivoExt = File.Exists(ruta);
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    if (archivoExt)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }
                MessageBox.Show(datos, "Informacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                // String datos = $"Nombre:{name}\n\rAPellido:{sur}\n\r Edad:{age} \n\r Altura: {altura} \n\r Telefono: {cel} \n\r Sex: {genero}";
                MessageBox.Show("ingrese valores a los espacios en blanco", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}

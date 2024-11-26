using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobleCLickDatagribview
{
    public partial class Form2 : Form
    {

        private DataGridViewRow selectedRow;

        public Form2(DataGridViewRow row, string nombre, string apellido, string telefono, string direccion)
        {
            InitializeComponent();

            textBoxNombre.Text = nombre;
            textBoxApellido.Text = apellido;
            textBoxTelefono.Text = telefono;
            textBoxDireccion.Text = direccion;

            selectedRow = row;


        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxApellido.Text) || string.IsNullOrEmpty(textBoxTelefono.Text) || string.IsNullOrEmpty(textBoxDireccion.Text))
            {

                MessageBox.Show("Todos los campos deven estar rellenos");
                return;

            }

            selectedRow.Cells["Nombre"].Value = textBoxNombre.Text;
            selectedRow.Cells["Apellido"].Value = textBoxApellido.Text;
            selectedRow.Cells["Telefono"].Value = textBoxTelefono.Text;
            selectedRow.Cells["Direccion"].Value = textBoxDireccion.Text;

            this.Close();

        }
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace DobleCLickDatagribview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, System.EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellidos = textBoxApellido.Text;
            string telefono = textBoxTelefono.Text;
            string direccion = textBoxDireccion.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidos) ||
                string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(direccion))
            {

                MessageBox.Show("Todos los campos deven estar rellenos");
                return;

            }
            else if (telefono.Length != 9)
            {

                MessageBox.Show("El campo telefono deve tener 9 digitos");
                return;

            }

            dataGridView1.Rows.Add(nombre, apellidos, telefono, direccion);

            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxTelefono.Clear();
            textBoxDireccion.Clear();

            textBoxTelefono.BackColor = Color.White;


        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int rowIndex = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(rowIndex);

            }
            else
            {
                MessageBox.Show("Debes de selecciona una fila para poder eliminarla");
            }
        }

        private void textBoxTelefono_TextChanged(object sender, System.EventArgs e)
        {

            if (textBoxTelefono.TextLength == 9 || textBoxTelefono.TextLength == 0)
            {

                textBoxTelefono.BackColor = Color.White;

            }
            else
            {
                textBoxTelefono.BackColor = Color.Red;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                string nombre = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                string apellido = dataGridView1.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                string telefono = dataGridView1.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                string direccion = dataGridView1.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                Form2 form2 = new Form2(selectedRow, nombre, apellido, telefono, direccion);
                form2.ShowDialog();



            }

        }
    }
}

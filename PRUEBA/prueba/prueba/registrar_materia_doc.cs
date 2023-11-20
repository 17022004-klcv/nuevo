using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class registrar_materia_doc : Form
    {
        public registrar_materia_doc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                
                string itemSeleccionado = comboBox1.SelectedItem.ToString();
                MessageBox.Show("Materia: " + itemSeleccionado + " asignada correctamente");
            }
            else
            {
                // Mostrar si no se ha seleccionado ningún elemento
                MessageBox.Show("Por favor, selecciona un elemeto.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_creation User_creation = new User_creation();
            this.Hide();
            User_creation.ShowDialog();
            this.Close();
        }
    }
}

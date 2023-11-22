using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prueba
{
    public partial class Asignación__materia_do : Form
    {
        private Conexion nConexion;
        public Asignación__materia_do()
        {
            InitializeComponent();
            nConexion = new Conexion();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_docente_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si los campos no estan vacios
            if (!string.IsNullOrEmpty(Usuario_docente.Text) && comboBox1.SelectedItem != null)
            {
                
                string textoIngresado = Usuario_docente.Text;
                string itemSeleccionado = comboBox1.SelectedItem.ToString();
                MessageBox.Show("La materia: " + itemSeleccionado + " ha sido asignada al docente: "+ textoIngresado);
            }
            else
            {
                // Mostrar si el TextBox está vacío
                MessageBox.Show("Por favor, llene todos los campos.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opciones_admin admin = new Opciones_admin();
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }
    }
}

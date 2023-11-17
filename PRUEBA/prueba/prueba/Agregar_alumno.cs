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
    public partial class Agregar_alumno : Form
    {
        public Agregar_alumno()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            validacion_de_campos();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void validacion_de_campos()
        {
           

            if (String.IsNullOrEmpty(txt_name_Estudiante.Text) ||
               String.IsNullOrEmpty(txt_name_Materia.Text))
            {
                MessageBox.Show("Porfavor llene todos los campos");
            }
            else
            {


                Subir_notas subir_notas = new Subir_notas();
                subir_notas.Show();

            }
        }

    }
}

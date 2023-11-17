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
    public partial class Registro_alumno : Form
    {
        public Registro_alumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Registrar_usuario.Text) ||
                  String.IsNullOrEmpty(txt_name_Materia.Text))
            {
                MessageBox.Show("Porfavor llene todos los campos");
            }
            else
            {
           
            }
        }
    }
}

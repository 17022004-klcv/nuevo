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
    public partial class User_creation : Form
    {
        public User_creation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validacion_de_campos_admin();

            if (raBut_Dosente.Checked)
            {
                registrar_materia_doc registrar_materia_doc = new registrar_materia_doc();
                registrar_materia_doc.ShowDialog();
            }


        }





        private void Validacion_de_campos_admin()
        {
            if (String.IsNullOrEmpty(txt_Apellidos.Text) ||
                String.IsNullOrEmpty(txt_Name.Text) ||
                String.IsNullOrEmpty(txt_Correo.Text) ||


                raBut_Dosente.Checked == false &&
                raBtn_Alumno.Checked == false)
            {
                MessageBox.Show("Porfavor llene todos los campos");
            }
            else
            {

            }
        }



    }
}

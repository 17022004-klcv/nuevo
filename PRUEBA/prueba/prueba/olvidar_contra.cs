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
    public partial class olvidar_contra : Form
    {
        public olvidar_contra()
        {
            InitializeComponent();
        }

        private void bt_ingresar_Click(object sender, EventArgs e)
        {
           if ( String.IsNullOrEmpty(txt_usuario.Text))
            {
                MessageBox.Show("Ingrese su correo electronico");
            }
            else 
            {

                MessageBox.Show("Querido usuario, dentro de 24 horas se le enviara un enlace a su correo electronico\n\n" +
                    "Seguir los pasos que ahi se le indiquen para poder reestablecer su contraseña");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nlogin Nlogin = new Nlogin();
            this.Hide();
            Nlogin.ShowDialog();
            this.Close();
        }
    }
}

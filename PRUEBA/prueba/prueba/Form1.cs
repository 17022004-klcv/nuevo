using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        

        //admin
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Nlogin loginForm = new Nlogin();

        }

        //boton docente
        private void button1_Click(object sender, EventArgs e)
        {
            loginDocente loginnuevo = new loginDocente();
            this.Hide();
            loginnuevo.ShowDialog();
            this.Close();
        }
        //boton estudiante
        private void button2_Click(object sender, EventArgs e)
        {
            loginStudent loginnuevo = new loginStudent();
            this.Hide();
            loginnuevo.ShowDialog();
            this.Close();

        }
        //boton admin
        private void button3_Click(object sender, EventArgs e)
        {
            Nlogin loginnuevo = new Nlogin();
            this.Hide();
            loginnuevo.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

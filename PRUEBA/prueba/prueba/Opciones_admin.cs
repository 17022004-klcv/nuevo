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
    public partial class Opciones_admin : Form
    {
        public Opciones_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_creation creacion = new User_creation();
            creacion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Asignación__materia_do asignacion = new Asignación__materia_do();
            asignacion.Show();
        }
    }
}

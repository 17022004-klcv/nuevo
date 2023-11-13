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
    public partial class pajina_principal : Form
    {
        public pajina_principal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pajina_principal_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso_docente dc = new ingreso_docente();
            dc.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ingreso_docente dc = new ingreso_docente();
            dc.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Opciones_admin admin = new Opciones_admin();
            admin.Show();
        }
    }
}

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

            ingreso_docente ingreso_docente = new ingreso_docente();
            ingreso_docente.ShowDialog();



        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Opciones_admin Opciones_admin = new Opciones_admin();
            Opciones_admin.ShowDialog();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tabla_de_notas Tabla__de__notas = new Tabla_de_notas();
            Tabla__de__notas.ShowDialog();
        }
    }
}

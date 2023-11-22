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
    public partial class Tabla_de_notas : Form
    {
        public Tabla_de_notas()
        {
            InitializeComponent();
            ConfiguracionDataGrid();
        }

        private void ConfiguracionDataGrid()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //esta parte del codigo hacer retoceder al antiguo formulario 
        private void button1_Click(object sender, EventArgs e)
        {
            Nlogin Nlogin = new Nlogin();
            this.Hide();
            Nlogin.ShowDialog();
            this.Close();
        }
    }
}

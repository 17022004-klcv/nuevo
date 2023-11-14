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
            if (radioButton1.Checked)
            {
                registrar_materia_doc registrar_materia_doc = new registrar_materia_doc();
                registrar_materia_doc.ShowDialog();
            }
        }
    }
}

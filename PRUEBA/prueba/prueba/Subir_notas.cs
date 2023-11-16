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
    public partial class Subir_notas : Form
    {
        public Subir_notas()
        {
            InitializeComponent();

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void butt_Ingresar_Click(object sender, EventArgs e)
        {
            Validacion_de_campos();







        }

        public void Validacion_de_campos()
        {


            //balidacion aqui se valida que las casillas contenga datos 
            if (!double.TryParse(txt_Nota1.Text, out double nota01) ||
                !double.TryParse(txt_Nota2.Text, out double nota02) ||
                !double.TryParse(txt_Nota3.Text, out double nota03) ||
                !double.TryParse(txt_Nota4.Text, out double nota04) ||

                !double.TryParse(txt_Porse1.Text, out double porse1) ||
                !double.TryParse(txt_Porse2.Text, out double porse2) ||
                !double.TryParse(txt_Porse3.Text, out double porse3) ||
                !double.TryParse(txt_Porse4.Text, out double porse4) ||
                !double.TryParse(txt_Parcial.Text, out double Parcial))
            {
                MessageBox.Show("Llene los campos correspondientes o\nAsegurese que no vaya un dato de topo caracter");
            }
            else
            {
                MessageBox.Show("Los cambios se an enviado correcgta mente");
            }
          
        }

        private void butt_Calcular_Click(object sender, EventArgs e)
        {
            Validacion_de_campos();
        }
    }
}

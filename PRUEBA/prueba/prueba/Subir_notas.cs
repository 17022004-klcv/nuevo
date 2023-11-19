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
                !double.TryParse(txt_Parcial.Text, out double Parcial) ||

                raBut_periodo1.Checked == false &&
                raBut_periodo2.Checked == false &&
                raBut_periodo3.Checked == false)
            {
                MessageBox.Show("Llene los campos correspondientes o\nAsegurese que no vaya un dato de topo caracter");
            }
            else
            {
                Valiar_nota_porse();


            }

        }

        private void butt_Calcular_Click(object sender, EventArgs e)
        {
            Validacion_de_campos();
            //Valiar_nota_porse();
        }

        private void Valiar_nota_porse()
        {
            //declaracion de variables de las notas
            double nota1 = double.Parse(txt_Nota1.Text);
            double nota2 = double.Parse(txt_Nota2.Text);
            double nota3 = double.Parse(txt_Nota3.Text);
            double nota4 = double.Parse(txt_Nota4.Text);
            double parcial = double.Parse(txt_Parcial.Text);
            //declaracion de varibles para los porsentajes

            double porsentaje1 = double.Parse(txt_Porse1.Text);
            double porsentaje2 = double.Parse(txt_Porse2.Text);
            double porsentaje3 = double.Parse(txt_Porse3.Text); 
            double porsentaje4 = double.Parse(txt_Porse4.Text); 

            //sesuma los porsentajes para ver el valor que suman 
            double suma_porsentaje = 0;
            suma_porsentaje = (porsentaje1 + porsentaje2 + porsentaje3 + porsentaje4);

            //validacion del posentaje 
            if (suma_porsentaje == 50)
            {

                //validacion de notas 
                if (nota1 >= 0 && nota1 <= 10 &&
                    nota2 >= 0 && nota2 <= 10 &&
                    nota3 >= 0 && nota3 <= 10 &&
                    nota4 >= 0 && nota4 <= 10 &&
                    parcial >=0 && parcial <=10)
                {

                    MessageBox.Show("Los cambios se an enviado correcgta mente");
                }
                else
                {
                    MessageBox.Show("La nota esta fuera de ragango");
                }

            }
            else
            {
                MessageBox.Show("El posentaje tiene que ser igual a 50% ");
            }
        }




    }
}

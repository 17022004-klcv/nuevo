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
            validar_campo_ingrsar();
        }

        private void validar_campo_ingrsar()
        {

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
                        parcial >= 0 && parcial <= 10)
                    {
                        Agregar_alumno Agregar_alumno = new Agregar_alumno();
                        this.Hide();
                        Agregar_alumno.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La nota esta fuera de ragango");
                    }

                }

            }

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
            //se llama el metodo, este metodo lo que hoce es que valida los campos 
            Validacion_de_campos();

        }


        //en este metodo se valida la notas y los porsentajes 

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
                    parcial >= 0 && parcial <= 10)
                {

                    // aca se balida que siclo a elejudo el usuario  y 
                    //se llama el metodo que calcula la nota del estudiante y muestra que periodo es
                    if (raBut_periodo1.Checked == true)
                    {

                        Calcular_nota();
                        MessageBox.Show("Periodo 1");
                    }
                    else
                    {
                        if (raBut_periodo2.Checked == true)
                        {
                            Calcular_nota();
                            MessageBox.Show("Periodo 2");
                        }
                        else
                        {
                            if (raBut_periodo3.Checked == true)
                            {
                                Calcular_nota();
                                MessageBox.Show("Periodo 3");
                            }
                        }
                    }

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


        // aqui se calcula la nota del estudiante 
        private void Calcular_nota()
        {
            //se grean las variabes y se les de el valor de los textBox tamto para las notas como para los poesentajes 
            double nota_1 = double.Parse(txt_Nota1.Text);
            double nota_2 = double.Parse(txt_Nota2.Text);
            double nota_3 = double.Parse(txt_Nota3.Text);
            double nota_4 = double.Parse(txt_Nota4.Text);
            double parcial = double.Parse(txt_Parcial.Text);


            double porsentaje_1 = double.Parse(txt_Porse1.Text);
            double porsentaje_2 = double.Parse(txt_Porse2.Text);
            double porsentaje_3 = double.Parse(txt_Porse3.Text);
            double porsentaje_4 = double.Parse(txt_Porse4.Text);


            //se calcula la nota con el porsentaje 
            double NotaCon_porse_1 = (nota_1 * (porsentaje_1 / 100));
            double NotaCon_porse_2 = (nota_2 * (porsentaje_2 / 100));
            double NotaCon_porse_3 = (nota_3 * (porsentaje_3 / 100));
            double NotaCon_porse_4 = (nota_4 * (porsentaje_4 / 100));

            double Nota_parcial = parcial * 0.5;


            // Aqui se daca el promedio final 
            double Nota_final = 0;
            Nota_final = (NotaCon_porse_1 + NotaCon_porse_2 + NotaCon_porse_3 + NotaCon_porse_4 + Nota_parcial);


            if (Nota_final > 7)
            {
                MessageBox.Show("su nota es " + Nota_final);
            }
            else
            {
                MessageBox.Show("su nota es mala " + Nota_final);
            }

        }

        private void raBut_periodo1_CheckedChanged(object sender, EventArgs e)
        {

        }


        //esta parte del codigo hacer retoceder al antiguo formulario 
        private void button1_Click(object sender, EventArgs e)
        {
            ingreso_docente ingreso_docente = new ingreso_docente();
            this.Hide();
            ingreso_docente.ShowDialog();
            this.Close();
        }
    }
}

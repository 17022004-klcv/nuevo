﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prueba
{
    public partial class Agregar_alumno : Form
    {
        public Agregar_alumno()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Validaciondebotones1())
            {
                MessageBox.Show("Las notas fueron asignadas correctamente al estudiante: " + txt_name_Estudiante.Text);
            }
            else
            {
                
                MessageBox.Show("Todos los campos deben estar llenos", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Validaciondebotones1()
        {
            return !string.IsNullOrEmpty(txt_name_Estudiante.Text) && !string.IsNullOrEmpty(txt_name_Estudiante.Text);
        }

    }
}

﻿using System;
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
    public partial class ingreso_docente : Form
    {
        public ingreso_docente()
        {
            InitializeComponent();
        }

        public ingreso_docente(string bt)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Registro_alumno registro_Alumno = new Registro_alumno();
            this.Hide();
            registro_Alumno.ShowDialog();
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Subir_notas Subir_notas = new Subir_notas();
            this.Hide();
            Subir_notas.ShowDialog();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

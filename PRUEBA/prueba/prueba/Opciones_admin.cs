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
    public partial class Opciones_admin : Form
    {
        public Opciones_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            User_creation User_creation = new User_creation();
            this.Hide();
            User_creation.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Asignación__materia_do Asignación__materia_do = new Asignación__materia_do();
            this.Hide();
            Asignación__materia_do.ShowDialog();
            this.Close();

            
        }


        //esta parte del codigo hacer retoceder al antiguo formulario 
        private void button2_Click_1(object sender, EventArgs e)
        {
            Nlogin Nlogin = new Nlogin();
            this.Hide();
            Nlogin.ShowDialog();
            this.Close();
        }

        private void Opciones_admin_Load(object sender, EventArgs e)
        {

        }
    }
}

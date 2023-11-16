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
    public partial class Nlogin : Form
    {
        public Nlogin()
        {
            InitializeComponent();
            bt_ingresar.Enabled  = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Validar campos nulos
        private void Validar_valores()
        {

            var nulo = (!string.IsNullOrEmpty(txt_usuario.Text) && !string.IsNullOrEmpty(txt_contrasena.Text));


            bt_ingresar.Enabled = nulo;
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;

            usuario = txt_usuario.Text;
            contraseña = txt_contrasena.Text;

            //usuario y contraseña para admin
            if (usuario == "admin" && contraseña == "admin4")
            {
                Opciones_admin admin = new Opciones_admin();
                admin.Show();
            }else
            //usuario y contraseña para estudiante
            if (usuario == "1" && contraseña == "2")
            {
                Tabla_de_notas estudiante = new Tabla_de_notas();
                estudiante.Show();
            }else
            //usuario y contraseña para docente
            if (usuario == "3" && contraseña == "4")
            {
                ingreso_docente docente = new ingreso_docente();
                docente.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalidos!");
            }
        }
        //validar valor nulo en el usuario
        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            Validar_valores();
        }
        //validar valor nulo en contraseña
        private void txt_contrasena_TextChanged(object sender, EventArgs e)
        {
            Validar_valores();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            olvidar_contra olvido = new olvidar_contra();
            olvido.Show();
        }
    }
}

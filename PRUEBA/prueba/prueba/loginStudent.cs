using MySql.Data.MySqlClient;
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
    public partial class loginStudent : Form
    {
        private Conexion nConexion;

        public loginStudent()
        {
            InitializeComponent();
            nConexion = new Conexion();
            //bt_ingresar.Enabled = false;


        }
        //Validar campos nulos
        private void Validar_valores()
        {

            var nulo = (!string.IsNullOrEmpty(txt_usuario.Text) && !string.IsNullOrEmpty(txt_contrasena.Text));

            bt_ingresar.Enabled = nulo;

        }
        private void bt_ingresar_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;

            usuario = txt_usuario.Text;
            contraseña = txt_contrasena.Text;

            //conexion a la base de datos

            MySqlDataReader mySqlDataReader = null;
            string consulta1 = "SELECT * FROM `students` WHERE user_student ='" + usuario + "' AND PASSWORD ='" + contraseña + "';";

            if (nConexion.getConexion() != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta1);
                mySqlCommand.Connection = nConexion.getConexion();
                mySqlDataReader = mySqlCommand.ExecuteReader();

            }
            else
            {
                MessageBox.Show("Error al conectar la base de datos");
            }

            if (mySqlDataReader.Read())
            {

                Tabla_de_notas estudiante = new Tabla_de_notas();
                this.Hide();
                estudiante.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Error al ingresar los datos");

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            olvidar_contra olvido = new olvidar_contra();
            this.Hide();
            olvido.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.ShowDialog();
            this.Close();
        }
        //boton - olvido contraseña
        private void button2_Click_1(object sender, EventArgs e)
        {
            olvidar_contra olvido = new olvidar_contra();
            this.Hide();
            olvido.ShowDialog();
            this.Close();
        }
    }
}

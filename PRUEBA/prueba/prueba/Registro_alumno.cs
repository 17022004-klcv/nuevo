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
using System.Xml.Linq;

namespace prueba
{
    public partial class Registro_alumno : Form
    {
        private Conexion nConexion;
        public Registro_alumno()
        {
            InitializeComponent();
        nConexion = new Conexion();

    }

    private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Registrar_usuario.Text) ||
                  String.IsNullOrEmpty(txt_name_Materia.Text))
            {
                MessageBox.Show("Porfavor llene todos los campos");
            }
            else
            {
                //declaracion de variables
                string usuario = txt_Registrar_usuario.Text;
                string materia = txt_name_Materia.Text;
                string docente = txt_docente.Text;


                //conexion a la base de datos
                MySqlDataReader mySqlDataReader = null;
                string consulta = "SELECT * FROM students;";

                if (nConexion.getConexion() != null)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = nConexion.getConexion();
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    string id_grade = GenerarNumeroAleatorio();

                    string consulta3 = "INSERT INTO `subject` " +
                    "(`id_grade`, `name_subject`,`user_student`, `user_teacher`" +
                "VALUES " +
                "('" + id_grade + "', '" + materia + "', '" + usuario + "', '" + docente + "');";

                    MessageBox.Show(usuario + " " + ", se a asignado a la materia: " + materia +
                       ", con un id: " + id_grade);
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos");
                }

                //while (mySqlDataReader.Read())
                //{
                //    string id_grade = GenerarNumeroAleatorio();

                //    string consulta3 = "INSERT INTO `subject` " +
                //    "(`id_grade`, `name_subject`,`user_student`, `user_teacher`" +
                //"VALUES " +
                //"('" + id_grade + "', '" + materia + "', '" + usuario + "', '" + docente + "');";

                //    MessageBox.Show(usuario + " " + ", se a asignado a la materia: " + materia +
                //       ", con un id: " + id_grade);

                //}

                //fin conexion

            }
        }
        //generar id
        public string GenerarAleatorio(int longitud)
        {
            string caracteres = "0123456789";
            StringBuilder numerosAleatorios = new StringBuilder();

            for (int i = 0; i < longitud; i++)
            {
                int indice = random.Next(0, caracteres.Length);
                numerosAleatorios.Append(caracteres[indice]);
            }

            return numerosAleatorios.ToString();
        }

        private Random random = new Random();

        public string GenerarNumeroAleatorio()
        {
            string primeros4Digitos = "900";
            string ultimos4Digitos = GenerarAleatorio(3);

            string numeroAleatorio = primeros4Digitos + ultimos4Digitos;

            return numeroAleatorio;
        }
        private void Registro_alumno_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

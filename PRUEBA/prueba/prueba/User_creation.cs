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
    public partial class User_creation : Form
    {
        private Conexion nConexion;
        public User_creation()
        {
            InitializeComponent();
            nConexion = new Conexion();

        }

        //boton ingresar
        private void button1_Click(object sender, EventArgs e)
        {
            Validacion_de_campos_admin();

            Validacion_de_campos_admin();

            string nombre, apellido, email;
            string id;
            string usuario;
            string contra;

            nombre = txt_Name.Text;
            apellido = txt_Apellidos.Text;
            email = txt_Correo.Text;
            contra = GenerarContraseña();

            //validar registro de identidad
            if (raBut_Dosente.Checked == true)
            {
                id = GenerarNumeroAleatorio();
                usuario = GenerarCodigo();

                //conexion a la base de datos

                MySqlDataReader mySqlDataReader = null;
                string consulta = "INSERT INTO `educational_teacher` " +
                    "(`id_teacher`, `name_teacher`, `last_nameTeacher`, `email`, `user_teacher`, `password`) " +
                    "VALUES " +
                    "('" + id + "', '" + nombre + "', '" + apellido + "', '" + email + "', '" + usuario + "', '" + contra + "');";

                MessageBox.Show(nombre + " " + apellido + ", se a creado con usuario: " + usuario +
                   ", y contraseña: " + contra);

                if (nConexion.getConexion() != null)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = nConexion.getConexion();
                    mySqlDataReader = mySqlCommand.ExecuteReader();
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos");
                }
            }
            else if (raBtn_Alumno.Checked == true)
            {
                id = GenerarNumeroAleatorioStudent();
                usuario = GenerarUsuarioStudent();

                //conexion a la base de datos

                MySqlDataReader mySqlDataReader = null;
                string consulta = "INSERT INTO `students` " +
                        "(`id_student`, `name_student`, `last_name_student`, `email`, `user_student`, `password`) " +
                        "VALUES " +
                        "('" + id + "', '" + nombre + "', '" + apellido + "', '" + email + "', '" + usuario + "', '" + contra + "');";

                MessageBox.Show(nombre + " " + apellido + ", se a creado con usuario: " + usuario +
                       ", y contraseña: " + contra);

                if (nConexion.getConexion() != null)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = nConexion.getConexion();
                    mySqlDataReader = mySqlCommand.ExecuteReader();
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos");
                }
            }
            }


        //Generar id del docente randoms
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
            string primeros4Digitos = "1001";
            string ultimos4Digitos = GenerarAleatorio(4);

            string numeroAleatorio = primeros4Digitos + ultimos4Digitos;

            return numeroAleatorio;
        }

        //Generar el id del estudiante random


        public string GenerarAleatorioStudent(int longitud)
        {
            string caracteres = "0123456789";
            StringBuilder numerosAleatorios = new StringBuilder();

            for (int i = 0; i < longitud; i++)
            {
                int indice = randomStudent.Next(0, caracteres.Length);
                numerosAleatorios.Append(caracteres[indice]);
            }

            return numerosAleatorios.ToString();
        }

        private Random randomStudent = new Random();

        public string GenerarNumeroAleatorioStudent()
        {
            string primeros4Digitos = "2002";
            string ultimos4Digitos = GenerarAleatorioStudent(4);

            string numeroAleatorio = primeros4Digitos + ultimos4Digitos;

            return numeroAleatorio;
        }

        //Generar el usuario docente ramdom
        public string GenerarId(int longitud)
        {
            string caracteres = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder aleatorios = new StringBuilder();

            for (int i = 0; i < longitud; i++)
            {
                int indice = randomS.Next(0, caracteres.Length);
                aleatorios.Append(caracteres[indice]);
            }

            return aleatorios.ToString();
        }

        private Random randomS = new Random();

        public string GenerarCodigo()
        {
            string numerosAleatorios = GenerarId(3);
            string letrasAleatorias = GenerarId(2);

            string codigo = numerosAleatorios + letrasAleatorias + GenerarId(3);

            return codigo;
        }

        //Generar el usuario estudiante ramdom
        public string GenerarIdStudent(int longitud)
        {
            string caracteres = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder aleatorios = new StringBuilder();

            for (int i = 0; i < longitud; i++)
            {
                int indice = randomStudentt.Next(0, caracteres.Length);
                aleatorios.Append(caracteres[indice]);
            }

            return aleatorios.ToString();
        }

        private Random randomStudentt = new Random();

        public string GenerarUsuarioStudent()
        {
            string numerosAleatorios = GenerarId(3);
            string letrasAleatorias = GenerarId(2);

            string codigo = numerosAleatorios + letrasAleatorias + GenerarIdStudent(3);

            return codigo;
        }



        //metodo para generar la contraseña
        public string GenerarContra(int longitud)
        {
            string caracteres = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder aleatorios = new StringBuilder();

            for (int i = 0; i < longitud; i++)
            {
                int indice = randomc.Next(0, caracteres.Length);
                aleatorios.Append(caracteres[indice]);
            }

            return aleatorios.ToString();
        }

        private Random randomc = new Random();

        public string GenerarContraseña()
        {
            string contraseña = GenerarContra(8);

            return contraseña;
        }
        //metodo para validar campos nulos
        private void Validacion_de_campos_admin()
        {
            if (String.IsNullOrEmpty(txt_Apellidos.Text) ||
                String.IsNullOrEmpty(txt_Name.Text) ||
                String.IsNullOrEmpty(txt_Correo.Text) ||


                raBut_Dosente.Checked == false &&
                raBtn_Alumno.Checked == false)
            {
                MessageBox.Show("Porfavor llene todos los campos");
            }
            else
            {
                if (raBut_Dosente.Checked)
                {
                    registrar_materia_doc registrar_materia_doc = new registrar_materia_doc();
                    this.Hide();
                    registrar_materia_doc.ShowDialog();
                    this.Close();
                }
            }
        }


        //esta parte del codigo hacer retoceder al antiguo formulario 
        private void button2_Click(object sender, EventArgs e)
        {
            Opciones_admin Opciones_admin = new Opciones_admin();
            this.Hide();
            Opciones_admin.ShowDialog();
            this.Close();
        }
    }
}

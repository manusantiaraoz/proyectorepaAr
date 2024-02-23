using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace repa.AR
{
    public partial class repaAr : MaterialSkin.Controls.MaterialForm
    {
        public repaAr()
        {
            InitializeComponent();
        }
        SqlConnection conect = new SqlConnection("server= DESKTOP-RIS98MF ; database= repaArbd ;integrated security = true");

        //codigo auxiliar de conexiones y consultas
        private void abrirConexion()
        {
            conect.Close();
            conect.Open();

        }

        private SqlDataReader mostrarDatos(String table) 
        {
            abrirConexion();
            String query = "SELECT * FROM "+ table;
            SqlCommand comando = new SqlCommand(query, conect);
            SqlDataReader respuesta = comando.ExecuteReader();
           
            return respuesta;
        }

        private void mostrarDatosAdmin()
        {
            SqlDataReader admin = mostrarDatos("ADMIN");

            while (admin.Read())
            {
                adminNombre.Text = admin["nombre"].ToString();
                adminApellido.Text = admin["apellido"].ToString();
                adminCuil.Text = admin["cuil"].ToString();
                adminDireccion.Text = admin["direccion"].ToString(); 
                adminEmpresa.Text = admin["empresa"].ToString();   
                adminTelefono.Text = admin["telefono"].ToString();
            }
            conect.Close();
        } 

        private void guardarCmbiosAdmin()
        {
            String nombre = adminNombre.Text;
            String apellido = adminApellido.Text;
            long cuil = long.Parse (adminCuil.Text);
            String direccion = adminDireccion.Text;
            String empresa = adminEmpresa.Text;
            long telefono = long.Parse(adminTelefono.Text);

            abrirConexion();

            String query = "UPDATE admin SET nombre = '"+nombre+"' ,apellido= '" +apellido+ "' ,cuil= "+ cuil + " ,direccion= '"+direccion+"' ,empresa = '"+empresa+"' ,telefono = " + telefono + " WHERE id_admin = 1";
            SqlCommand comando = new SqlCommand (query, conect);
            comando.ExecuteReader();
            mostrarDatosAdmin();
            MessageBox.Show("se modifico administrador con exito");
            conect.Close(); 
        }

        private void inicio_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            guardarCmbiosAdmin();
        }

        private void administrador_Click(object sender, EventArgs e)
        {
            mostrarDatosAdmin();
        }
    }
}

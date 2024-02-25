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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void mostrarRepuestos()
        {
            abrirConexion();
            String query = "SELECT r.id_repuesto, r.nombre, r.precio_venta, r.precio_compra, r.detalle, f.nombre_fabricante FROM repuesto AS r INNER JOIN fabricante AS f on r.fabricante = f.id_fabricante ";
            SqlCommand comando = new SqlCommand(query, conect);
            SqlDataReader respuesta = comando.ExecuteReader();


            while (respuesta.Read())
            {
                ListViewItem rep = new ListViewItem(respuesta["nombre"].ToString());
                rep.SubItems.Add(respuesta["precio_compra"].ToString());
                rep.SubItems.Add(respuesta["precio_venta"].ToString());
                rep.SubItems.Add(respuesta["detalle"].ToString());
                rep.SubItems.Add(respuesta["nombre_fabricante"].ToString());
                rep.SubItems.Add(respuesta["id_repuesto"].ToString());

                materialListRepuesto.Items.Add(rep);

            }
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

        private void repuestos_Click(object sender, EventArgs e)
        {
            mostrarRepuestos();
        }

        private void materialListRepuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListRepuesto.SelectedItems.Count>0)
            {
                ListViewItem selectedItem = materialListRepuesto.SelectedItems[0];

                nombreRepuesto.Text = selectedItem.SubItems[0].Text;
                precioRepuesto.Text = selectedItem.SubItems[1].Text;
                precioVRepuesta.Text = selectedItem.SubItems[2].Text;
                descripcionRepuesto.Text = selectedItem.SubItems[3].Text;
                comboBox1.Text = selectedItem.SubItems[4].Text;




            }
        }

        private void btnBorrarRep_Click(object sender, EventArgs e)
        {
            if (materialListRepuesto.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = materialListRepuesto.SelectedItems[0];

               int id_repuestoDelete = int.Parse(selectedItem.SubItems[5].Text);
                


                abrirConexion();

                String query = "DELETE repuesto WHERE id_repuesto = " + id_repuestoDelete;
                SqlCommand comando = new SqlCommand(query, conect);
                comando.ExecuteReader();
                MessageBox.Show("se elimino el producto con exito");
                materialListRepuesto.Items.Clear();
                mostrarRepuestos();
                conect.Close();


            }

            
        }
    }
}

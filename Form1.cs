﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace repa.AR
{
    public partial class repaAr : MaterialSkin.Controls.MaterialForm
    {
        public repaAr()
        {
            InitializeComponent();
        }
        SqlConnection conect = new SqlConnection("server= DESKTOP-RIS98MF ; database= repaArbd ;integrated security = true");


        private List<string> repuestoLista = new List<string>();
        int codigoPresupuesto = 0;
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
            String query = "SELECT r.id_repuesto, r.nombre, r.precio_venta, r.precio_compra, r.detalle, f.nombre_fabricante, f.id_fabricante FROM repuesto AS r INNER JOIN fabricante AS f on r.fabricante = f.id_fabricante ";
            SqlCommand comando = new SqlCommand(query, conect);
            SqlDataReader respuesta = comando.ExecuteReader();


            while (respuesta.Read())
            {
                ListViewItem rep = new ListViewItem(respuesta["nombre"].ToString());
                rep.SubItems.Add(respuesta["precio_compra"].ToString());
                rep.SubItems.Add(respuesta["precio_venta"].ToString());
                rep.SubItems.Add(respuesta["detalle"].ToString());
                rep.SubItems.Add(respuesta["id_fabricante"].ToString() + "-" + respuesta["nombre_fabricante"].ToString());
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

        private void mostrarDatosCliente()
        {
            abrirConexion();
            String query = "SELECT id_cliente, nombre, apellido, cuil, telefono, direccion   FROM cliente ";
            SqlCommand comando = new SqlCommand(query, conect);
            SqlDataReader respuesta = comando.ExecuteReader();


            while (respuesta.Read())
            {
                ListViewItem rep = new ListViewItem(respuesta["nombre"].ToString());
                rep.SubItems.Add(respuesta["apellido"].ToString());
                rep.SubItems.Add(respuesta["cuil"].ToString());
                rep.SubItems.Add(respuesta["telefono"].ToString());
                rep.SubItems.Add(respuesta["direccion"].ToString());
                rep.SubItems.Add(respuesta["id_cliente"].ToString());

                materialListClientes.Items.Add(rep);

            }
            conect.Close();
        }

        private void mostrarDatosFabricante()
        {
            abrirConexion();
            String query = "SELECT id_fabricante, nombre_fabricante FROM fabricante";
            SqlCommand comando = new SqlCommand(query, conect);
            SqlDataReader respuesta = comando.ExecuteReader();


            while (respuesta.Read())
            {
                ListViewItem rep = new ListViewItem(respuesta["nombre_fabricante"].ToString());
                rep.SubItems.Add(respuesta["id_fabricante"].ToString());
                
                materialListFabricante.Items.Add(rep);

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



        private void limpiarCamposRepuesto()
        {
            nombreRepuesto.Clear();
            precioRepuesto.Clear();
            precioVRepuesta.Clear(); 
            descripcionRepuesto.Clear(); 
            comboBox1.Items.Clear(); 
        }

        private void limpiarCamposCliente()
        {
            campoNombreCliente.Clear();
            campoApellidoCliente.Clear();
            campoCuilCliente.Clear();
            campoDireccionCliente.Clear();
            campoTelefonoCliente.Clear();
        }

        private void limpiarCampoFabricante()
        {
            campoNombreFabricante.Clear();
            
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
         
        }

        private void materialListRepuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListRepuesto.SelectedItems.Count>0)
            {
                ListViewItem selectedItem = materialListRepuesto.SelectedItems[0];

               String precioRep = selectedItem.SubItems[1].Text;
                String precioVenta = selectedItem.SubItems[2].Text;

                 precioRep = precioRep.Replace(",",".");
                precioVenta = precioVenta.Replace(",", ".");

                nombreRepuesto.Text = selectedItem.SubItems[0].Text;
                precioRepuesto.Text = precioRep;
                precioVRepuesta.Text = precioVenta;
                descripcionRepuesto.Text = selectedItem.SubItems[3].Text;
                comboBox1.Text = "seleccionar categoria";




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

        private void btnAgregarRep_Click(object sender, EventArgs e)
        {
          

            String nombreRep = nombreRepuesto.Text;
            String precioRep = precioRepuesto.Text;
            String precioRepVenta = precioVRepuesta.Text;
            String descriRep = descripcionRepuesto.Text;
            int codigoFabricante = 1;
            String elementoSelec = comboBox1.SelectedItem.ToString();

            if (elementoSelec != null)
            {



                int sacarGuion = elementoSelec.IndexOf(" - ");

                if (sacarGuion > -1)
                {
                    codigoFabricante = int.Parse(elementoSelec.Substring(0, sacarGuion).Trim());

                }
            }
           
           

            abrirConexion();

            String query = "INSERT INTO repuesto (nombre, fabricante, precio_compra, precio_venta, detalle) VALUES ('"+nombreRep+"' ,"+ codigoFabricante + ", "+precioRep + ", " + precioRepVenta + ", '"+ descriRep+"')";
            
            SqlCommand comando = new SqlCommand(query,conect);
             comando.ExecuteReader();
            MessageBox.Show("se cargo el nuevo repuesto");
            limpiarCamposRepuesto();
            materialListRepuesto.Items.Clear();
            mostrarRepuestos();
        }

        private void btnCambiosRep_Click(object sender, EventArgs e)
        {
            

            
            
            ListViewItem selectedItem = materialListRepuesto.SelectedItems[0];

            int idRepuestoMod = int.Parse(selectedItem.SubItems[5].Text);
                

            

            String nombreRep = nombreRepuesto.Text;
            String precioRep = precioRepuesto.Text;
            String precioRepVenta = precioVRepuesta.Text;
            String descriRep = descripcionRepuesto.Text;
            int codigoFabricante = 1;
            String elementoSelec = comboBox1.SelectedItem.ToString();

            if (elementoSelec != null)
            {



                int sacarGuion = elementoSelec.IndexOf(" - ");

                if (sacarGuion > -1)
                {
                    codigoFabricante = int.Parse(elementoSelec.Substring(0, sacarGuion).Trim());

                }
            }

            abrirConexion();

            String query = "UPDATE repuesto SET nombre = '" + nombreRep + "' ,fabricante= " + codigoFabricante + " ,precio_compra= " + precioRep + " ,precio_venta= " + precioRepVenta + " ,detalle = '" + descriRep + "'  WHERE id_repuesto = " + idRepuestoMod+";";
            Console.WriteLine(query );
            SqlCommand comando = new SqlCommand(query, conect);
            comando.ExecuteReader();
            MessageBox.Show("se modifico con exito el repuesto");
            limpiarCamposRepuesto();
            materialListRepuesto.Items.Clear();
            mostrarRepuestos();
        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SqlDataReader fabricantes = mostrarDatos("fabricante");

            while (fabricantes.Read())
            {
                comboBox1.Items.Add(fabricantes["id_fabricante"].ToString() + " - " + fabricantes["nombre_fabricante"].ToString());
            }
            materialListRepuesto.Items.Clear();
            mostrarRepuestos();
        }

        private void cargarClientes_Click(object sender, EventArgs e)
        {
            mostrarDatosCliente();
        }

        private void materialListClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListClientes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = materialListClientes.SelectedItems[0];

                campoNombreCliente.Text = selectedItem.SubItems[0].Text;
                campoApellidoCliente.Text = selectedItem.SubItems[1].Text;
                campoCuilCliente.Text = selectedItem.SubItems[2].Text;
                campoTelefonoCliente.Text = selectedItem.SubItems[3].Text;
                campoDireccionCliente.Text = selectedItem.SubItems[4].Text;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

            int id_cliente = 0;
            if (materialListClientes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = materialListClientes.SelectedItems[0];

                id_cliente = int.Parse(selectedItem.SubItems[5].Text);
            }


            String nombreCliente = campoNombreCliente.Text;
            String apellidoCliente = campoApellidoCliente.Text;
            String cuilCliente = campoCuilCliente.Text;
            String telefonoCliente = campoTelefonoCliente.Text;
            String direCliente = campoDireccionCliente.Text;
           
         

            abrirConexion();

            String query = "UPDATE cliente SET nombre = '" + nombreCliente + "' ,apellido= '" + apellidoCliente + "' ,cuil= " + cuilCliente + " ,telefono= " + telefonoCliente + " ,direccion = '" + direCliente + "'  WHERE id_cliente = " + id_cliente + ";";
           
            SqlCommand comando = new SqlCommand(query, conect);
           comando.ExecuteReader();
             MessageBox.Show("se modifico cliente con exito");
            limpiarCamposCliente();
            materialListClientes.Items.Clear();
            mostrarDatosCliente();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            int id_cliente = 0;
            if (materialListClientes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = materialListClientes.SelectedItems[0];

                id_cliente = int.Parse(selectedItem.SubItems[5].Text);
            }

            abrirConexion();

            String query = "DELETE cliente WHERE id_cliente = "+id_cliente + ";";
            
            SqlCommand comando = new SqlCommand(query, conect);
            comando.ExecuteReader();
            MessageBox.Show("se modifico cliente con exito");
            limpiarCamposCliente();
            materialListClientes.Items.Clear();
            mostrarDatosCliente();

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {

            String nombreCliente = campoNombreCliente.Text;
            String apellidoCliente = campoApellidoCliente.Text;
            String cuilCliente = campoCuilCliente.Text;
            String telefonoCliente = campoTelefonoCliente.Text;
            String direCliente = campoDireccionCliente.Text;

            abrirConexion();

            String query = "insert into cliente (nombre, apellido, cuil, telefono, direccion) VALUES ('" + nombreCliente + "', '" + apellidoCliente + "', " +cuilCliente +", "+telefonoCliente +",'"+ direCliente+ "');";
           
            SqlCommand comando = new SqlCommand(query, conect);
           comando.ExecuteReader();
            MessageBox.Show("se agrego cliente con exito");
            limpiarCamposCliente();
            materialListClientes.Items.Clear();
            mostrarDatosCliente();


        }

        private void materialButton12_Click(object sender, EventArgs e)
        {
            mostrarDatosFabricante();
        }

        private void materialListFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_fab = 0;
            if (materialListFabricante.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = materialListFabricante.SelectedItems[0];

                campoNombreFabricante.Text = selectedItem.SubItems[0].Text;
                id_fab = int.Parse(selectedItem.SubItems[1].Text);
               
            }
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            int id_fab = 0;
            if (materialListFabricante.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = materialListFabricante.SelectedItems[0];
                id_fab = int.Parse(selectedItem.SubItems[1].Text);

            }

            abrirConexion();

            String query = "DELETE fabricante WHERE id_fabricante = " + id_fab + ";";
           
            SqlCommand comando = new SqlCommand(query, conect);
            comando.ExecuteReader();
            MessageBox.Show("se elimino fabricante con exito");
            limpiarCampoFabricante();
            materialListFabricante.Items.Clear();
            mostrarDatosFabricante();


        }

        private void materialButton7_Click(object sender, EventArgs e)
        {

            String campoNombre = campoNombreFabricante.Text;

            abrirConexion();

            String query = "insert into fabricante (nombre_fabricante) VALUES ('" + campoNombre + "');";

            SqlCommand comando = new SqlCommand(query, conect);
            comando.ExecuteReader();
            MessageBox.Show("se agrego cliente con exito");
            limpiarCampoFabricante();
            materialListFabricante.Items.Clear();
            mostrarDatosFabricante();

        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            int id_fab = 0;
            if (materialListFabricante.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = materialListFabricante.SelectedItems[0];
                id_fab = int.Parse(selectedItem.SubItems[1].Text);

            }

           String nombre_fab = campoNombreFabricante.Text;

            abrirConexion();

            String query = "UPDATE fabricante SET nombre_fabricante = '" + nombre_fab+ "'  WHERE id_fabricante = " + id_fab + ";";
            
            SqlCommand comando = new SqlCommand(query, conect);
            comando.ExecuteReader();
            MessageBox.Show("se modifico cliente con exito");
            limpiarCampoFabricante();
            materialListFabricante.Items.Clear();
            mostrarDatosFabricante();
        }





        private void materialButton13_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlDataReader clientes = mostrarDatos("cliente");

            while (clientes.Read())
            {
                comboBox2.Items.Add(clientes["nombre"].ToString() + " " + clientes["apellido"].ToString() + ";  cuil:" + clientes["cuil"].ToString() + " - " + clientes["id_cliente"].ToString());
            }


            checkedListBox1.Items.Clear();

            abrirConexion();
            String query = "SELECT r.id_repuesto, r.nombre, r.precio_venta, r.precio_compra, r.detalle, f.nombre_fabricante, f.id_fabricante FROM repuesto AS r INNER JOIN fabricante AS f on r.fabricante = f.id_fabricante ";
            SqlCommand comando = new SqlCommand(query, conect);
            SqlDataReader repuestos = comando.ExecuteReader();

            while (repuestos.Read())
            {
                checkedListBox1.Items.Add("nombre: " + repuestos["nombre"].ToString() + "; " + "fabricante:" + repuestos["nombre_fabricante"].ToString() + " precio: $" + repuestos["precio_venta"].ToString() + " - " + repuestos["id_repuesto"].ToString());
            }

            conect.Close();


            //mostrar informacion del presupuestos creados 
            abrirConexion();
            String datosPresupuesto = "select cl.nombre, cl.apellido, cl.cuil,cl.telefono, cl.direccion, p.fecha, p.descripcion, p.total, p.id_presupuesto FROM presupuestotb AS p INNER JOIN cliente AS cl on p.id_cliente = cl.id_cliente ;";
            SqlCommand cmd = new SqlCommand(datosPresupuesto, conect);
            SqlDataReader respCmd = cmd.ExecuteReader();

            while (respCmd.Read())
            {
                ListViewItem rep = new ListViewItem(respCmd["nombre"].ToString()+" "+ respCmd["apellido"].ToString());
                rep.SubItems.Add(respCmd["telefono"].ToString());
                rep.SubItems.Add(respCmd["descripcion"].ToString());
                rep.SubItems.Add(respCmd["fecha"].ToString());
                rep.SubItems.Add(respCmd["total"].ToString());
                rep.SubItems.Add(respCmd["id_presupuesto"].ToString());

                materialListPresupuesto.Items.Add(rep);
            }
        
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }





        private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = checkedListBox1.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                // Agregar al array cuando se selecciona
                repuestoLista.Add(item);

            }
            else
            {
                // Eliminar del array cuando se deselecciona
                repuestoLista.Remove(item);

            }


            decimal subTotal = 0;
            foreach (var items in repuestoLista)
            {
                string input = items.ToLower();


                string priceString = input.Substring(input.IndexOf('$') + 1, input.IndexOf('-') - input.IndexOf('$') - 1);


                if (decimal.TryParse(priceString, out decimal price))
                {
                    subTotal = subTotal + price;
                }
                else
                {
                    Console.WriteLine("No se pudo extraer el precio correctamente.");
                }

            }
            String cambioPunto = subTotal.ToString().Replace(",",".");
            campoSubTotal.Text = cambioPunto;


        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            List<string> codigoProducto = new List<string>();

                foreach (String item in repuestoLista)
            {
                String Input  = item.ToLower();

                String codigo = Input.Substring(Input.IndexOf("-") +1) ;

                codigoProducto.Add(codigo);
            }


            //datos ceteados para la consulta
                //codigo Cliente
            String datoClienteCrudo = comboBox2.Text;
            String codigoCliente = datoClienteCrudo.Substring(datoClienteCrudo.IndexOf("-") + 1);

                
            //campo de informacion adicional (descripcion)
            String campoDetalle = materialMultiLineTextBox1.Text;
                
            //campo total a ingresar
            String campoTotal = campoSubTotal.Text;

            //fecha de creacion del presupuesto
            DateTime fechaActual = DateTime.Now.Date;
            String formatoFecha = "yyyy-MM-dd";
            string fechaFormateada = fechaActual.ToString(formatoFecha);

            // para cargar los datos, vamos a hacer una transaccion, con la finalidad de que se realice las 2 consultas o ninguna, haremos el insert en tabla presupuesto y otra en poducto presupuesto


            try
            {
                abrirConexion();

                SqlTransaction transaction = conect.BeginTransaction();

                try
                {
                    //insertar presupuesto
                    string query = "INSERT INTO presupuestotb (id_admin, id_cliente, fecha, descripcion, total ) VALUES (1, " + codigoCliente + ", '" + fechaFormateada + "', '" + campoDetalle + "', " + campoTotal + " ); SELECT SCOPE_IDENTITY(); ";

                    SqlCommand comando = new SqlCommand(query, conect, transaction);
                    int idPresupuesto = Convert.ToInt32(comando.ExecuteScalar());

                    foreach (var codigo in codigoProducto)
                    {
                        string insertProducto = "INSERT INTO prodPresupuesto (id_presupuesto, id_productos) VALUES (" + idPresupuesto + "," + codigo + ")";

                        SqlCommand cmdRepuesto = new SqlCommand(insertProducto, conect, transaction);
                        cmdRepuesto.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("presupúesto creado con exito");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                

            }
            catch (Exception ex) {

                Console.WriteLine("Error al guardar los datos: " + ex.Message);
            }
        }

        private void materialListPresupuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListPresupuesto.SelectedItems.Count > 0)
            {
                btnDetalleP.Enabled = true;
                ListViewItem selectedItem = materialListPresupuesto.SelectedItems[0];

                codigoPresupuesto = int.Parse(selectedItem.SubItems[5].Text);

            }
           
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            String nombreAdmin = "";
            String apellidoAdmin = "";
            String cuilAdmin = "";
            String direccionAdmin = "";
            String telefonoAdmin = "";
            String empresaAdmin = "";

            SqlDataReader adminDatos=  mostrarDatos("admin");

            while(adminDatos.Read())
            {
                nombreAdmin = adminDatos["nombre"].ToString();
                apellidoAdmin = adminDatos["apellido"].ToString();
                cuilAdmin = adminDatos["cuil"].ToString();
                direccionAdmin = adminDatos["direccion"].ToString();
                telefonoAdmin = adminDatos["telefono"].ToString();
                empresaAdmin = adminDatos["empresa"].ToString().ToUpper();
                
            }

            String datosAdministrados = nombreAdmin+" "+apellidoAdmin+"\n cuil:"+cuilAdmin+"\n"+direccionAdmin+"\n telefono:"+telefonoAdmin;

          Document presupuesto = new Document();
            PdfWriter.GetInstance(presupuesto, new FileStream("presupuesto.pdf", FileMode.Create));

            presupuesto.Open();
            Paragraph empresa = new Paragraph(empresaAdmin);
            empresa.Font.Size = 12;
            empresa.Alignment = Element.ALIGN_LEFT; 
            Paragraph centrar = new Paragraph(datosAdministrados);
            centrar.Alignment = Element.ALIGN_RIGHT;
            centrar.Font.Size = 9;

            presupuesto.Add(empresa);
            presupuesto.Add(centrar);

            presupuesto.Close();
            Process.Start("presupuesto.pdf");
        }
    }
}

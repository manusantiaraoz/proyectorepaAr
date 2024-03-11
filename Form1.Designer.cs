namespace repa.AR
{
    partial class repaAr
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        ///private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialForm components=null;
        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialSkin.Controls.MaterialLabel materialLabel1;
            MaterialSkin.Controls.MaterialLabel materialLabel2;
            MaterialSkin.Controls.MaterialLabel materialLabel3;
            MaterialSkin.Controls.MaterialLabel materialLabel4;
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.inicio = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.administrador = new System.Windows.Forms.TabPage();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.adminEmpresa = new MaterialSkin.Controls.MaterialTextBox2();
            this.adminTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.adminDireccion = new MaterialSkin.Controls.MaterialTextBox2();
            this.adminCuil = new MaterialSkin.Controls.MaterialTextBox2();
            this.adminApellido = new MaterialSkin.Controls.MaterialTextBox2();
            this.adminNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.repuestos = new System.Windows.Forms.TabPage();
            this.materialButton11 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialListRepuesto = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcionRepuesto = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnCambiosRep = new MaterialSkin.Controls.MaterialButton();
            this.btnBorrarRep = new MaterialSkin.Controls.MaterialButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAgregarRep = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.precioRepuesto = new MaterialSkin.Controls.MaterialTextBox2();
            this.precioVRepuesta = new MaterialSkin.Controls.MaterialTextBox2();
            this.nombreRepuesto = new MaterialSkin.Controls.MaterialTextBox2();
            this.clientes = new System.Windows.Forms.TabPage();
            this.cargarClientes = new MaterialSkin.Controls.MaterialButton();
            this.materialListClientes = new MaterialSkin.Controls.MaterialListView();
            this.nombreCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apellidoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cuilCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefonoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.direccionCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.campoTelefonoCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.campoDireccionCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.campoCuilCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.campoApellidoCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.campoNombreCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.fabricantes = new System.Windows.Forms.TabPage();
            this.materialButton12 = new MaterialSkin.Controls.MaterialButton();
            this.materialListFabricante = new MaterialSkin.Controls.MaterialListView();
            this.nombreFabricante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_Fabricante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            this.campoNombreFabricante = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel30 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel31 = new MaterialSkin.Controls.MaterialLabel();
            this.presupuestos = new System.Windows.Forms.TabPage();
            this.materialListPresupuesto = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.campoSubTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialButton13 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel32 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDetalleP = new MaterialSkin.Controls.MaterialButton();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton10 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel33 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.inicio.SuspendLayout();
            this.administrador.SuspendLayout();
            this.repuestos.SuspendLayout();
            this.clientes.SuspendLayout();
            this.fabricantes.SuspendLayout();
            this.presupuestos.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            materialLabel1.BackColor = System.Drawing.SystemColors.WindowText;
            materialLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            materialLabel1.Depth = 0;
            materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            materialLabel1.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            materialLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            materialLabel1.Location = new System.Drawing.Point(284, 11);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new System.Drawing.Size(221, 94);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "repa.Ar";
            materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            materialLabel2.BackColor = System.Drawing.SystemColors.WindowText;
            materialLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            materialLabel2.Depth = 0;
            materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            materialLabel2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            materialLabel2.Location = new System.Drawing.Point(284, 107);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new System.Drawing.Size(221, 34);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "tu organizador digital";
            materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            materialLabel3.BackColor = System.Drawing.SystemColors.WindowText;
            materialLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            materialLabel3.Depth = 0;
            materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            materialLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            materialLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            materialLabel3.Location = new System.Drawing.Point(-1, 328);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new System.Drawing.Size(239, 26);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "proyecto final: taller de programación";
            materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel4
            // 
            materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            materialLabel4.BackColor = System.Drawing.SystemColors.WindowText;
            materialLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            materialLabel4.Depth = 0;
            materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            materialLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            materialLabel4.Location = new System.Drawing.Point(544, 328);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new System.Drawing.Size(239, 26);
            materialLabel4.TabIndex = 3;
            materialLabel4.Text = "alumno: Santi Araoz Daniel Emmanuel";
            materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.materialTabControl1.Controls.Add(this.inicio);
            this.materialTabControl1.Controls.Add(this.administrador);
            this.materialTabControl1.Controls.Add(this.repuestos);
            this.materialTabControl1.Controls.Add(this.clientes);
            this.materialTabControl1.Controls.Add(this.fabricantes);
            this.materialTabControl1.Controls.Add(this.presupuestos);
            this.materialTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.HotTrack = true;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl1.TabIndex = 0;
            // 
            // inicio
            // 
            this.inicio.BackColor = System.Drawing.Color.White;
            this.inicio.Controls.Add(this.label1);
            this.inicio.Controls.Add(materialLabel4);
            this.inicio.Controls.Add(materialLabel3);
            this.inicio.Controls.Add(materialLabel2);
            this.inicio.Controls.Add(materialLabel1);
            this.inicio.Location = new System.Drawing.Point(4, 4);
            this.inicio.Name = "inicio";
            this.inicio.Padding = new System.Windows.Forms.Padding(3);
            this.inicio.Size = new System.Drawing.Size(786, 357);
            this.inicio.TabIndex = 0;
            this.inicio.Text = "inicio";
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // label1
            // 
            this.label1.Image = global::repa.AR.Properties.Resources.OIP;
            this.label1.Location = new System.Drawing.Point(314, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 161);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // administrador
            // 
            this.administrador.Controls.Add(this.materialLabel26);
            this.administrador.Controls.Add(this.materialButton1);
            this.administrador.Controls.Add(this.materialLabel11);
            this.administrador.Controls.Add(this.materialLabel10);
            this.administrador.Controls.Add(this.materialLabel9);
            this.administrador.Controls.Add(this.materialLabel8);
            this.administrador.Controls.Add(this.materialLabel7);
            this.administrador.Controls.Add(this.materialLabel6);
            this.administrador.Controls.Add(this.materialLabel5);
            this.administrador.Controls.Add(this.adminEmpresa);
            this.administrador.Controls.Add(this.adminTelefono);
            this.administrador.Controls.Add(this.adminDireccion);
            this.administrador.Controls.Add(this.adminCuil);
            this.administrador.Controls.Add(this.adminApellido);
            this.administrador.Controls.Add(this.adminNombre);
            this.administrador.Location = new System.Drawing.Point(4, 4);
            this.administrador.Name = "administrador";
            this.administrador.Padding = new System.Windows.Forms.Padding(3);
            this.administrador.Size = new System.Drawing.Size(786, 357);
            this.administrador.TabIndex = 1;
            this.administrador.Text = "administrador";
            this.administrador.UseVisualStyleBackColor = true;
            this.administrador.Click += new System.EventHandler(this.administrador_Click);
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.BackColor = System.Drawing.Color.White;
            this.materialLabel26.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialLabel26.Location = new System.Drawing.Point(179, 324);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(501, 19);
            this.materialLabel26.TabIndex = 14;
            this.materialLabel26.Text = "⚠ reliza un click en cualquier parte de la pantalla para cargar los datos";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(331, 245);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(157, 36);
            this.materialButton1.TabIndex = 13;
            this.materialButton1.Text = "Guardar cambios";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel11
            // 
            this.materialLabel11.BackColor = System.Drawing.Color.Azure;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.ForeColor = System.Drawing.Color.Black;
            this.materialLabel11.Location = new System.Drawing.Point(66, 148);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(221, 19);
            this.materialLabel11.TabIndex = 12;
            this.materialLabel11.Text = "direccion";
            this.materialLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel10
            // 
            this.materialLabel10.BackColor = System.Drawing.Color.Azure;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.ForeColor = System.Drawing.Color.Black;
            this.materialLabel10.Location = new System.Drawing.Point(307, 148);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(225, 19);
            this.materialLabel10.TabIndex = 11;
            this.materialLabel10.Text = "empresa";
            this.materialLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel9
            // 
            this.materialLabel9.BackColor = System.Drawing.Color.Azure;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.Color.Black;
            this.materialLabel9.Location = new System.Drawing.Point(560, 148);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(123, 19);
            this.materialLabel9.TabIndex = 10;
            this.materialLabel9.Text = "telefono";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel8
            // 
            this.materialLabel8.BackColor = System.Drawing.Color.Azure;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ForeColor = System.Drawing.Color.Black;
            this.materialLabel8.Location = new System.Drawing.Point(560, 78);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(123, 21);
            this.materialLabel8.TabIndex = 9;
            this.materialLabel8.Text = "cuil";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel7
            // 
            this.materialLabel7.BackColor = System.Drawing.Color.Azure;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.Color.Black;
            this.materialLabel7.Location = new System.Drawing.Point(307, 78);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(227, 21);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Text = "apellido/s";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel6
            // 
            this.materialLabel6.BackColor = System.Drawing.Color.Azure;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.Black;
            this.materialLabel6.Location = new System.Drawing.Point(65, 78);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(225, 21);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "nombre/s";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            this.materialLabel5.BackColor = System.Drawing.Color.Azure;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel5.ForeColor = System.Drawing.Color.Black;
            this.materialLabel5.Location = new System.Drawing.Point(296, 26);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(225, 32);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Datos del Operador";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminEmpresa
            // 
            this.adminEmpresa.AnimateReadOnly = false;
            this.adminEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminEmpresa.CausesValidation = false;
            this.adminEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adminEmpresa.Cursor = System.Windows.Forms.Cursors.Default;
            this.adminEmpresa.Depth = 0;
            this.adminEmpresa.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEmpresa.HideSelection = true;
            this.adminEmpresa.LeadingIcon = null;
            this.adminEmpresa.Location = new System.Drawing.Point(310, 167);
            this.adminEmpresa.Margin = new System.Windows.Forms.Padding(0);
            this.adminEmpresa.MaxLength = 32767;
            this.adminEmpresa.MouseState = MaterialSkin.MouseState.OUT;
            this.adminEmpresa.Name = "adminEmpresa";
            this.adminEmpresa.PasswordChar = '\0';
            this.adminEmpresa.PrefixSuffixText = null;
            this.adminEmpresa.ReadOnly = false;
            this.adminEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminEmpresa.SelectedText = "";
            this.adminEmpresa.SelectionLength = 0;
            this.adminEmpresa.SelectionStart = 0;
            this.adminEmpresa.ShortcutsEnabled = false;
            this.adminEmpresa.Size = new System.Drawing.Size(222, 36);
            this.adminEmpresa.TabIndex = 5;
            this.adminEmpresa.TabStop = false;
            this.adminEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminEmpresa.TrailingIcon = null;
            this.adminEmpresa.UseAccent = false;
            this.adminEmpresa.UseSystemPasswordChar = false;
            this.adminEmpresa.UseTallSize = false;
            // 
            // adminTelefono
            // 
            this.adminTelefono.AnimateReadOnly = false;
            this.adminTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adminTelefono.Cursor = System.Windows.Forms.Cursors.Default;
            this.adminTelefono.Depth = 0;
            this.adminTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTelefono.HideSelection = true;
            this.adminTelefono.LeadingIcon = null;
            this.adminTelefono.Location = new System.Drawing.Point(560, 167);
            this.adminTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.adminTelefono.MaxLength = 32767;
            this.adminTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.adminTelefono.Name = "adminTelefono";
            this.adminTelefono.PasswordChar = '\0';
            this.adminTelefono.PrefixSuffixText = null;
            this.adminTelefono.ReadOnly = false;
            this.adminTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminTelefono.SelectedText = "";
            this.adminTelefono.SelectionLength = 0;
            this.adminTelefono.SelectionStart = 0;
            this.adminTelefono.ShortcutsEnabled = false;
            this.adminTelefono.Size = new System.Drawing.Size(170, 36);
            this.adminTelefono.TabIndex = 6;
            this.adminTelefono.TabStop = false;
            this.adminTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminTelefono.TrailingIcon = null;
            this.adminTelefono.UseAccent = false;
            this.adminTelefono.UseSystemPasswordChar = false;
            this.adminTelefono.UseTallSize = false;
            // 
            // adminDireccion
            // 
            this.adminDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminDireccion.AnimateReadOnly = false;
            this.adminDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminDireccion.CausesValidation = false;
            this.adminDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adminDireccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.adminDireccion.Depth = 0;
            this.adminDireccion.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDireccion.HideSelection = true;
            this.adminDireccion.LeadingIcon = null;
            this.adminDireccion.Location = new System.Drawing.Point(69, 167);
            this.adminDireccion.Margin = new System.Windows.Forms.Padding(0);
            this.adminDireccion.MaxLength = 32767;
            this.adminDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.adminDireccion.Name = "adminDireccion";
            this.adminDireccion.PasswordChar = '\0';
            this.adminDireccion.PrefixSuffixText = null;
            this.adminDireccion.ReadOnly = false;
            this.adminDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminDireccion.SelectedText = "";
            this.adminDireccion.SelectionLength = 0;
            this.adminDireccion.SelectionStart = 0;
            this.adminDireccion.ShortcutsEnabled = false;
            this.adminDireccion.Size = new System.Drawing.Size(215, 36);
            this.adminDireccion.TabIndex = 3;
            this.adminDireccion.TabStop = false;
            this.adminDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminDireccion.TrailingIcon = null;
            this.adminDireccion.UseAccent = false;
            this.adminDireccion.UseSystemPasswordChar = false;
            this.adminDireccion.UseTallSize = false;
            // 
            // adminCuil
            // 
            this.adminCuil.AnimateReadOnly = false;
            this.adminCuil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminCuil.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adminCuil.Cursor = System.Windows.Forms.Cursors.Default;
            this.adminCuil.Depth = 0;
            this.adminCuil.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCuil.HideSelection = true;
            this.adminCuil.LeadingIcon = null;
            this.adminCuil.Location = new System.Drawing.Point(560, 99);
            this.adminCuil.Margin = new System.Windows.Forms.Padding(0);
            this.adminCuil.MaxLength = 32767;
            this.adminCuil.MouseState = MaterialSkin.MouseState.OUT;
            this.adminCuil.Name = "adminCuil";
            this.adminCuil.PasswordChar = '\0';
            this.adminCuil.PrefixSuffixText = null;
            this.adminCuil.ReadOnly = false;
            this.adminCuil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminCuil.SelectedText = "";
            this.adminCuil.SelectionLength = 0;
            this.adminCuil.SelectionStart = 0;
            this.adminCuil.ShortcutsEnabled = false;
            this.adminCuil.Size = new System.Drawing.Size(170, 36);
            this.adminCuil.TabIndex = 2;
            this.adminCuil.TabStop = false;
            this.adminCuil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminCuil.TrailingIcon = null;
            this.adminCuil.UseAccent = false;
            this.adminCuil.UseSystemPasswordChar = false;
            this.adminCuil.UseTallSize = false;
            // 
            // adminApellido
            // 
            this.adminApellido.AnimateReadOnly = false;
            this.adminApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adminApellido.Cursor = System.Windows.Forms.Cursors.Default;
            this.adminApellido.Depth = 0;
            this.adminApellido.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminApellido.HideSelection = true;
            this.adminApellido.LeadingIcon = null;
            this.adminApellido.Location = new System.Drawing.Point(310, 99);
            this.adminApellido.Margin = new System.Windows.Forms.Padding(0);
            this.adminApellido.MaxLength = 32767;
            this.adminApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.adminApellido.Name = "adminApellido";
            this.adminApellido.PasswordChar = '\0';
            this.adminApellido.PrefixSuffixText = null;
            this.adminApellido.ReadOnly = false;
            this.adminApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminApellido.SelectedText = "";
            this.adminApellido.SelectionLength = 0;
            this.adminApellido.SelectionStart = 0;
            this.adminApellido.ShortcutsEnabled = false;
            this.adminApellido.Size = new System.Drawing.Size(224, 36);
            this.adminApellido.TabIndex = 1;
            this.adminApellido.TabStop = false;
            this.adminApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminApellido.TrailingIcon = null;
            this.adminApellido.UseAccent = false;
            this.adminApellido.UseSystemPasswordChar = false;
            this.adminApellido.UseTallSize = false;
            // 
            // adminNombre
            // 
            this.adminNombre.AnimateReadOnly = false;
            this.adminNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adminNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.adminNombre.Depth = 0;
            this.adminNombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminNombre.HideSelection = true;
            this.adminNombre.LeadingIcon = null;
            this.adminNombre.Location = new System.Drawing.Point(69, 99);
            this.adminNombre.Margin = new System.Windows.Forms.Padding(0);
            this.adminNombre.MaxLength = 32767;
            this.adminNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.adminNombre.Name = "adminNombre";
            this.adminNombre.PasswordChar = '\0';
            this.adminNombre.PrefixSuffixText = null;
            this.adminNombre.ReadOnly = false;
            this.adminNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminNombre.SelectedText = "";
            this.adminNombre.SelectionLength = 0;
            this.adminNombre.SelectionStart = 0;
            this.adminNombre.ShortcutsEnabled = false;
            this.adminNombre.Size = new System.Drawing.Size(221, 36);
            this.adminNombre.TabIndex = 0;
            this.adminNombre.TabStop = false;
            this.adminNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminNombre.TrailingIcon = null;
            this.adminNombre.UseAccent = false;
            this.adminNombre.UseSystemPasswordChar = false;
            this.adminNombre.UseTallSize = false;
            // 
            // repuestos
            // 
            this.repuestos.Controls.Add(this.materialButton11);
            this.repuestos.Controls.Add(this.materialLabel12);
            this.repuestos.Controls.Add(this.materialLabel14);
            this.repuestos.Controls.Add(this.materialListRepuesto);
            this.repuestos.Controls.Add(this.descripcionRepuesto);
            this.repuestos.Controls.Add(this.btnCambiosRep);
            this.repuestos.Controls.Add(this.btnBorrarRep);
            this.repuestos.Controls.Add(this.comboBox1);
            this.repuestos.Controls.Add(this.btnAgregarRep);
            this.repuestos.Controls.Add(this.materialLabel13);
            this.repuestos.Controls.Add(this.materialLabel15);
            this.repuestos.Controls.Add(this.materialLabel17);
            this.repuestos.Controls.Add(this.materialLabel19);
            this.repuestos.Controls.Add(this.precioRepuesto);
            this.repuestos.Controls.Add(this.precioVRepuesta);
            this.repuestos.Controls.Add(this.nombreRepuesto);
            this.repuestos.Location = new System.Drawing.Point(4, 4);
            this.repuestos.Name = "repuestos";
            this.repuestos.Padding = new System.Windows.Forms.Padding(3);
            this.repuestos.Size = new System.Drawing.Size(786, 357);
            this.repuestos.TabIndex = 2;
            this.repuestos.Text = "repuestos";
            this.repuestos.UseVisualStyleBackColor = true;
            this.repuestos.Click += new System.EventHandler(this.repuestos_Click);
            // 
            // materialButton11
            // 
            this.materialButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton11.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton11.Depth = 0;
            this.materialButton11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton11.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.materialButton11.HighEmphasis = true;
            this.materialButton11.Icon = null;
            this.materialButton11.Location = new System.Drawing.Point(715, 312);
            this.materialButton11.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton11.Name = "materialButton11";
            this.materialButton11.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton11.Size = new System.Drawing.Size(64, 36);
            this.materialButton11.TabIndex = 35;
            this.materialButton11.Text = "🔄";
            this.materialButton11.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton11.UseAccentColor = false;
            this.materialButton11.UseVisualStyleBackColor = true;
            this.materialButton11.Click += new System.EventHandler(this.materialButton11_Click);
            // 
            // materialLabel12
            // 
            this.materialLabel12.BackColor = System.Drawing.Color.Azure;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.ForeColor = System.Drawing.Color.Black;
            this.materialLabel12.Location = new System.Drawing.Point(348, 219);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(143, 19);
            this.materialLabel12.TabIndex = 34;
            this.materialLabel12.Text = "descripcion";
            this.materialLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel14
            // 
            this.materialLabel14.BackColor = System.Drawing.Color.Azure;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.ForeColor = System.Drawing.Color.Black;
            this.materialLabel14.Location = new System.Drawing.Point(226, 146);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(143, 19);
            this.materialLabel14.TabIndex = 33;
            this.materialLabel14.Text = "precio compra";
            this.materialLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialListRepuesto
            // 
            this.materialListRepuesto.AutoSizeTable = false;
            this.materialListRepuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListRepuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListRepuesto.CausesValidation = false;
            this.materialListRepuesto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.materialListRepuesto.Depth = 0;
            this.materialListRepuesto.FullRowSelect = true;
            this.materialListRepuesto.HideSelection = false;
            this.materialListRepuesto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialListRepuesto.Location = new System.Drawing.Point(11, 6);
            this.materialListRepuesto.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListRepuesto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListRepuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListRepuesto.MultiSelect = false;
            this.materialListRepuesto.Name = "materialListRepuesto";
            this.materialListRepuesto.OwnerDraw = true;
            this.materialListRepuesto.Size = new System.Drawing.Size(769, 108);
            this.materialListRepuesto.TabIndex = 32;
            this.materialListRepuesto.UseCompatibleStateImageBehavior = false;
            this.materialListRepuesto.View = System.Windows.Forms.View.Details;
            this.materialListRepuesto.SelectedIndexChanged += new System.EventHandler(this.materialListRepuesto_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "nombre";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "$ compra";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "$ venta";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "descripcion";
            this.columnHeader4.Width = 232;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "fabricante";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "id";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descripcionRepuesto
            // 
            this.descripcionRepuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionRepuesto.AnimateReadOnly = false;
            this.descripcionRepuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.descripcionRepuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.descripcionRepuesto.Depth = 0;
            this.descripcionRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descripcionRepuesto.HideSelection = true;
            this.descripcionRepuesto.LeadingIcon = null;
            this.descripcionRepuesto.Location = new System.Drawing.Point(18, 241);
            this.descripcionRepuesto.MaxLength = 200;
            this.descripcionRepuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.descripcionRepuesto.Name = "descripcionRepuesto";
            this.descripcionRepuesto.PasswordChar = '\0';
            this.descripcionRepuesto.PrefixSuffixText = null;
            this.descripcionRepuesto.ReadOnly = false;
            this.descripcionRepuesto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descripcionRepuesto.SelectedText = "";
            this.descripcionRepuesto.SelectionLength = 0;
            this.descripcionRepuesto.SelectionStart = 0;
            this.descripcionRepuesto.ShortcutsEnabled = true;
            this.descripcionRepuesto.Size = new System.Drawing.Size(741, 48);
            this.descripcionRepuesto.TabIndex = 31;
            this.descripcionRepuesto.TabStop = false;
            this.descripcionRepuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.descripcionRepuesto.TrailingIcon = null;
            this.descripcionRepuesto.UseSystemPasswordChar = false;
            // 
            // btnCambiosRep
            // 
            this.btnCambiosRep.AutoSize = false;
            this.btnCambiosRep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCambiosRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCambiosRep.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnCambiosRep.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnCambiosRep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCambiosRep.Depth = 0;
            this.btnCambiosRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiosRep.HighEmphasis = true;
            this.btnCambiosRep.Icon = null;
            this.btnCambiosRep.Location = new System.Drawing.Point(470, 312);
            this.btnCambiosRep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCambiosRep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCambiosRep.Name = "btnCambiosRep";
            this.btnCambiosRep.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCambiosRep.Size = new System.Drawing.Size(110, 36);
            this.btnCambiosRep.TabIndex = 30;
            this.btnCambiosRep.Text = "modificar";
            this.btnCambiosRep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCambiosRep.UseAccentColor = false;
            this.btnCambiosRep.UseVisualStyleBackColor = true;
            this.btnCambiosRep.UseWaitCursor = true;
            this.btnCambiosRep.Click += new System.EventHandler(this.btnCambiosRep_Click);
            // 
            // btnBorrarRep
            // 
            this.btnBorrarRep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBorrarRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBorrarRep.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnBorrarRep.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnBorrarRep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBorrarRep.Depth = 0;
            this.btnBorrarRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarRep.HighEmphasis = true;
            this.btnBorrarRep.Icon = null;
            this.btnBorrarRep.Location = new System.Drawing.Point(371, 312);
            this.btnBorrarRep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBorrarRep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBorrarRep.Name = "btnBorrarRep";
            this.btnBorrarRep.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBorrarRep.Size = new System.Drawing.Size(78, 36);
            this.btnBorrarRep.TabIndex = 29;
            this.btnBorrarRep.Text = "borrar";
            this.btnBorrarRep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBorrarRep.UseAccentColor = false;
            this.btnBorrarRep.UseVisualStyleBackColor = true;
            this.btnBorrarRep.UseWaitCursor = true;
            this.btnBorrarRep.Click += new System.EventHandler(this.btnBorrarRep_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(574, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // btnAgregarRep
            // 
            this.btnAgregarRep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarRep.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnAgregarRep.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAgregarRep.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarRep.Depth = 0;
            this.btnAgregarRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRep.HighEmphasis = true;
            this.btnAgregarRep.Icon = null;
            this.btnAgregarRep.Location = new System.Drawing.Point(260, 312);
            this.btnAgregarRep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarRep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarRep.Name = "btnAgregarRep";
            this.btnAgregarRep.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarRep.Size = new System.Drawing.Size(88, 36);
            this.btnAgregarRep.TabIndex = 27;
            this.btnAgregarRep.Text = "agregar";
            this.btnAgregarRep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarRep.UseAccentColor = false;
            this.btnAgregarRep.UseVisualStyleBackColor = true;
            this.btnAgregarRep.UseWaitCursor = true;
            this.btnAgregarRep.Click += new System.EventHandler(this.btnAgregarRep_Click);
            // 
            // materialLabel13
            // 
            this.materialLabel13.BackColor = System.Drawing.Color.Azure;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.ForeColor = System.Drawing.Color.Black;
            this.materialLabel13.Location = new System.Drawing.Point(31, 148);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(172, 19);
            this.materialLabel13.TabIndex = 26;
            this.materialLabel13.Text = "nombre";
            this.materialLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel15
            // 
            this.materialLabel15.BackColor = System.Drawing.Color.Azure;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.ForeColor = System.Drawing.Color.Black;
            this.materialLabel15.Location = new System.Drawing.Point(396, 146);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(143, 19);
            this.materialLabel15.TabIndex = 24;
            this.materialLabel15.Text = "precio venta";
            this.materialLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel17
            // 
            this.materialLabel17.BackColor = System.Drawing.Color.Azure;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.ForeColor = System.Drawing.Color.Black;
            this.materialLabel17.Location = new System.Drawing.Point(574, 149);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(185, 21);
            this.materialLabel17.TabIndex = 22;
            this.materialLabel17.Text = "fabricante";
            this.materialLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel19
            // 
            this.materialLabel19.BackColor = System.Drawing.Color.Azure;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel19.ForeColor = System.Drawing.Color.Black;
            this.materialLabel19.Location = new System.Drawing.Point(247, 114);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(292, 32);
            this.materialLabel19.TabIndex = 19;
            this.materialLabel19.Text = "datos de servicios-repuesto";
            this.materialLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precioRepuesto
            // 
            this.precioRepuesto.AnimateReadOnly = false;
            this.precioRepuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.precioRepuesto.CausesValidation = false;
            this.precioRepuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.precioRepuesto.Cursor = System.Windows.Forms.Cursors.Default;
            this.precioRepuesto.Depth = 0;
            this.precioRepuesto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioRepuesto.HelperText = "agrega el dato con \". \" no con \".\"";
            this.precioRepuesto.HideSelection = true;
            this.precioRepuesto.LeadingIcon = null;
            this.precioRepuesto.Location = new System.Drawing.Point(226, 168);
            this.precioRepuesto.Margin = new System.Windows.Forms.Padding(0);
            this.precioRepuesto.MaxLength = 32767;
            this.precioRepuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.precioRepuesto.Name = "precioRepuesto";
            this.precioRepuesto.PasswordChar = '\0';
            this.precioRepuesto.PrefixSuffixText = null;
            this.precioRepuesto.ReadOnly = false;
            this.precioRepuesto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.precioRepuesto.SelectedText = "";
            this.precioRepuesto.SelectionLength = 0;
            this.precioRepuesto.SelectionStart = 0;
            this.precioRepuesto.ShortcutsEnabled = false;
            this.precioRepuesto.Size = new System.Drawing.Size(143, 36);
            this.precioRepuesto.TabIndex = 18;
            this.precioRepuesto.TabStop = false;
            this.precioRepuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.precioRepuesto.TrailingIcon = null;
            this.precioRepuesto.UseAccent = false;
            this.precioRepuesto.UseSystemPasswordChar = false;
            this.precioRepuesto.UseTallSize = false;
            // 
            // precioVRepuesta
            // 
            this.precioVRepuesta.AnimateReadOnly = false;
            this.precioVRepuesta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.precioVRepuesta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.precioVRepuesta.Cursor = System.Windows.Forms.Cursors.Default;
            this.precioVRepuesta.Depth = 0;
            this.precioVRepuesta.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioVRepuesta.HideSelection = true;
            this.precioVRepuesta.LeadingIcon = null;
            this.precioVRepuesta.Location = new System.Drawing.Point(396, 167);
            this.precioVRepuesta.Margin = new System.Windows.Forms.Padding(0);
            this.precioVRepuesta.MaxLength = 32767;
            this.precioVRepuesta.MouseState = MaterialSkin.MouseState.OUT;
            this.precioVRepuesta.Name = "precioVRepuesta";
            this.precioVRepuesta.PasswordChar = '\0';
            this.precioVRepuesta.PrefixSuffixText = null;
            this.precioVRepuesta.ReadOnly = false;
            this.precioVRepuesta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.precioVRepuesta.SelectedText = "";
            this.precioVRepuesta.SelectionLength = 0;
            this.precioVRepuesta.SelectionStart = 0;
            this.precioVRepuesta.ShortcutsEnabled = false;
            this.precioVRepuesta.Size = new System.Drawing.Size(143, 36);
            this.precioVRepuesta.TabIndex = 20;
            this.precioVRepuesta.TabStop = false;
            this.precioVRepuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.precioVRepuesta.TrailingIcon = null;
            this.precioVRepuesta.UseAccent = false;
            this.precioVRepuesta.UseSystemPasswordChar = false;
            this.precioVRepuesta.UseTallSize = false;
            // 
            // nombreRepuesto
            // 
            this.nombreRepuesto.AnimateReadOnly = false;
            this.nombreRepuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nombreRepuesto.CausesValidation = false;
            this.nombreRepuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nombreRepuesto.Cursor = System.Windows.Forms.Cursors.Default;
            this.nombreRepuesto.Depth = 0;
            this.nombreRepuesto.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreRepuesto.HideSelection = true;
            this.nombreRepuesto.LeadingIcon = null;
            this.nombreRepuesto.Location = new System.Drawing.Point(34, 167);
            this.nombreRepuesto.Margin = new System.Windows.Forms.Padding(0);
            this.nombreRepuesto.MaxLength = 32767;
            this.nombreRepuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.nombreRepuesto.Name = "nombreRepuesto";
            this.nombreRepuesto.PasswordChar = '\0';
            this.nombreRepuesto.PrefixSuffixText = null;
            this.nombreRepuesto.ReadOnly = false;
            this.nombreRepuesto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nombreRepuesto.SelectedText = "";
            this.nombreRepuesto.SelectionLength = 0;
            this.nombreRepuesto.SelectionStart = 0;
            this.nombreRepuesto.ShortcutsEnabled = false;
            this.nombreRepuesto.Size = new System.Drawing.Size(169, 36);
            this.nombreRepuesto.TabIndex = 17;
            this.nombreRepuesto.TabStop = false;
            this.nombreRepuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nombreRepuesto.TrailingIcon = null;
            this.nombreRepuesto.UseAccent = false;
            this.nombreRepuesto.UseSystemPasswordChar = false;
            this.nombreRepuesto.UseTallSize = false;
            // 
            // clientes
            // 
            this.clientes.Controls.Add(this.cargarClientes);
            this.clientes.Controls.Add(this.materialListClientes);
            this.clientes.Controls.Add(this.materialLabel16);
            this.clientes.Controls.Add(this.materialLabel20);
            this.clientes.Controls.Add(this.materialLabel21);
            this.clientes.Controls.Add(this.materialLabel24);
            this.clientes.Controls.Add(this.materialLabel25);
            this.clientes.Controls.Add(this.campoTelefonoCliente);
            this.clientes.Controls.Add(this.campoDireccionCliente);
            this.clientes.Controls.Add(this.campoCuilCliente);
            this.clientes.Controls.Add(this.campoApellidoCliente);
            this.clientes.Controls.Add(this.campoNombreCliente);
            this.clientes.Controls.Add(this.materialButton2);
            this.clientes.Controls.Add(this.materialButton3);
            this.clientes.Controls.Add(this.materialButton4);
            this.clientes.Controls.Add(this.materialLabel22);
            this.clientes.Controls.Add(this.materialLabel23);
            this.clientes.Location = new System.Drawing.Point(4, 4);
            this.clientes.Name = "clientes";
            this.clientes.Padding = new System.Windows.Forms.Padding(3);
            this.clientes.Size = new System.Drawing.Size(786, 357);
            this.clientes.TabIndex = 3;
            this.clientes.Text = "clientes";
            this.clientes.UseVisualStyleBackColor = true;
            // 
            // cargarClientes
            // 
            this.cargarClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cargarClientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cargarClientes.Depth = 0;
            this.cargarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cargarClientes.HighEmphasis = true;
            this.cargarClientes.Icon = null;
            this.cargarClientes.Location = new System.Drawing.Point(282, 9);
            this.cargarClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cargarClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.cargarClientes.Name = "cargarClientes";
            this.cargarClientes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cargarClientes.Size = new System.Drawing.Size(64, 36);
            this.cargarClientes.TabIndex = 58;
            this.cargarClientes.Text = "🔄";
            this.cargarClientes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cargarClientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cargarClientes.UseAccentColor = false;
            this.cargarClientes.UseVisualStyleBackColor = true;
            this.cargarClientes.Click += new System.EventHandler(this.cargarClientes_Click);
            // 
            // materialListClientes
            // 
            this.materialListClientes.AutoSizeTable = false;
            this.materialListClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombreCliente,
            this.apellidoCliente,
            this.cuilCliente,
            this.telefonoCliente,
            this.direccionCliente,
            this.id_cliente});
            this.materialListClientes.Depth = 0;
            this.materialListClientes.FullRowSelect = true;
            this.materialListClientes.HideSelection = false;
            this.materialListClientes.Location = new System.Drawing.Point(12, 45);
            this.materialListClientes.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListClientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListClientes.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListClientes.Name = "materialListClientes";
            this.materialListClientes.OwnerDraw = true;
            this.materialListClientes.Size = new System.Drawing.Size(263, 288);
            this.materialListClientes.TabIndex = 57;
            this.materialListClientes.UseCompatibleStateImageBehavior = false;
            this.materialListClientes.View = System.Windows.Forms.View.Details;
            this.materialListClientes.SelectedIndexChanged += new System.EventHandler(this.materialListClientes_SelectedIndexChanged);
            // 
            // nombreCliente
            // 
            this.nombreCliente.Text = "nombre";
            this.nombreCliente.Width = 129;
            // 
            // apellidoCliente
            // 
            this.apellidoCliente.Text = "apellido";
            this.apellidoCliente.Width = 137;
            // 
            // cuilCliente
            // 
            this.cuilCliente.Text = "cuil";
            this.cuilCliente.Width = 84;
            // 
            // telefonoCliente
            // 
            this.telefonoCliente.Text = "telefono";
            this.telefonoCliente.Width = 113;
            // 
            // direccionCliente
            // 
            this.direccionCliente.Text = "direccion";
            this.direccionCliente.Width = 165;
            // 
            // id_cliente
            // 
            this.id_cliente.Text = "id_cliente";
            // 
            // materialLabel16
            // 
            this.materialLabel16.BackColor = System.Drawing.Color.Azure;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.ForeColor = System.Drawing.Color.Black;
            this.materialLabel16.Location = new System.Drawing.Point(426, 138);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(221, 19);
            this.materialLabel16.TabIndex = 56;
            this.materialLabel16.Text = "direccion";
            this.materialLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel20
            // 
            this.materialLabel20.BackColor = System.Drawing.Color.Azure;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.ForeColor = System.Drawing.Color.Black;
            this.materialLabel20.Location = new System.Drawing.Point(587, 200);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(123, 19);
            this.materialLabel20.TabIndex = 54;
            this.materialLabel20.Text = "telefono";
            this.materialLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel21
            // 
            this.materialLabel21.BackColor = System.Drawing.Color.Azure;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.ForeColor = System.Drawing.Color.Black;
            this.materialLabel21.Location = new System.Drawing.Point(364, 198);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(123, 21);
            this.materialLabel21.TabIndex = 53;
            this.materialLabel21.Text = "cuil";
            this.materialLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel24
            // 
            this.materialLabel24.BackColor = System.Drawing.Color.Azure;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel24.ForeColor = System.Drawing.Color.Black;
            this.materialLabel24.Location = new System.Drawing.Point(539, 68);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(227, 21);
            this.materialLabel24.TabIndex = 52;
            this.materialLabel24.Text = "apellido/s";
            this.materialLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel25
            // 
            this.materialLabel25.BackColor = System.Drawing.Color.Azure;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.ForeColor = System.Drawing.Color.Black;
            this.materialLabel25.Location = new System.Drawing.Point(297, 68);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(225, 21);
            this.materialLabel25.TabIndex = 51;
            this.materialLabel25.Text = "nombre/s";
            this.materialLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoTelefonoCliente
            // 
            this.campoTelefonoCliente.AnimateReadOnly = false;
            this.campoTelefonoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campoTelefonoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.campoTelefonoCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.campoTelefonoCliente.Depth = 0;
            this.campoTelefonoCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTelefonoCliente.HideSelection = true;
            this.campoTelefonoCliente.LeadingIcon = null;
            this.campoTelefonoCliente.Location = new System.Drawing.Point(587, 219);
            this.campoTelefonoCliente.Margin = new System.Windows.Forms.Padding(0);
            this.campoTelefonoCliente.MaxLength = 32767;
            this.campoTelefonoCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.campoTelefonoCliente.Name = "campoTelefonoCliente";
            this.campoTelefonoCliente.PasswordChar = '\0';
            this.campoTelefonoCliente.PrefixSuffixText = null;
            this.campoTelefonoCliente.ReadOnly = false;
            this.campoTelefonoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campoTelefonoCliente.SelectedText = "";
            this.campoTelefonoCliente.SelectionLength = 0;
            this.campoTelefonoCliente.SelectionStart = 0;
            this.campoTelefonoCliente.ShortcutsEnabled = false;
            this.campoTelefonoCliente.Size = new System.Drawing.Size(123, 36);
            this.campoTelefonoCliente.TabIndex = 49;
            this.campoTelefonoCliente.TabStop = false;
            this.campoTelefonoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.campoTelefonoCliente.TrailingIcon = null;
            this.campoTelefonoCliente.UseAccent = false;
            this.campoTelefonoCliente.UseSystemPasswordChar = false;
            this.campoTelefonoCliente.UseTallSize = false;
            // 
            // campoDireccionCliente
            // 
            this.campoDireccionCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.campoDireccionCliente.AnimateReadOnly = false;
            this.campoDireccionCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campoDireccionCliente.CausesValidation = false;
            this.campoDireccionCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.campoDireccionCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.campoDireccionCliente.Depth = 0;
            this.campoDireccionCliente.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDireccionCliente.HideSelection = true;
            this.campoDireccionCliente.LeadingIcon = null;
            this.campoDireccionCliente.Location = new System.Drawing.Point(429, 157);
            this.campoDireccionCliente.Margin = new System.Windows.Forms.Padding(0);
            this.campoDireccionCliente.MaxLength = 32767;
            this.campoDireccionCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.campoDireccionCliente.Name = "campoDireccionCliente";
            this.campoDireccionCliente.PasswordChar = '\0';
            this.campoDireccionCliente.PrefixSuffixText = null;
            this.campoDireccionCliente.ReadOnly = false;
            this.campoDireccionCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campoDireccionCliente.SelectedText = "";
            this.campoDireccionCliente.SelectionLength = 0;
            this.campoDireccionCliente.SelectionStart = 0;
            this.campoDireccionCliente.ShortcutsEnabled = false;
            this.campoDireccionCliente.Size = new System.Drawing.Size(215, 36);
            this.campoDireccionCliente.TabIndex = 47;
            this.campoDireccionCliente.TabStop = false;
            this.campoDireccionCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.campoDireccionCliente.TrailingIcon = null;
            this.campoDireccionCliente.UseAccent = false;
            this.campoDireccionCliente.UseSystemPasswordChar = false;
            this.campoDireccionCliente.UseTallSize = false;
            // 
            // campoCuilCliente
            // 
            this.campoCuilCliente.AnimateReadOnly = false;
            this.campoCuilCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campoCuilCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.campoCuilCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.campoCuilCliente.Depth = 0;
            this.campoCuilCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCuilCliente.HideSelection = true;
            this.campoCuilCliente.LeadingIcon = null;
            this.campoCuilCliente.Location = new System.Drawing.Point(364, 219);
            this.campoCuilCliente.Margin = new System.Windows.Forms.Padding(0);
            this.campoCuilCliente.MaxLength = 32767;
            this.campoCuilCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.campoCuilCliente.Name = "campoCuilCliente";
            this.campoCuilCliente.PasswordChar = '\0';
            this.campoCuilCliente.PrefixSuffixText = null;
            this.campoCuilCliente.ReadOnly = false;
            this.campoCuilCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campoCuilCliente.SelectedText = "";
            this.campoCuilCliente.SelectionLength = 0;
            this.campoCuilCliente.SelectionStart = 0;
            this.campoCuilCliente.ShortcutsEnabled = false;
            this.campoCuilCliente.Size = new System.Drawing.Size(123, 36);
            this.campoCuilCliente.TabIndex = 48;
            this.campoCuilCliente.TabStop = false;
            this.campoCuilCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.campoCuilCliente.TrailingIcon = null;
            this.campoCuilCliente.UseAccent = false;
            this.campoCuilCliente.UseSystemPasswordChar = false;
            this.campoCuilCliente.UseTallSize = false;
            // 
            // campoApellidoCliente
            // 
            this.campoApellidoCliente.AnimateReadOnly = false;
            this.campoApellidoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campoApellidoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.campoApellidoCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.campoApellidoCliente.Depth = 0;
            this.campoApellidoCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoApellidoCliente.HideSelection = true;
            this.campoApellidoCliente.LeadingIcon = null;
            this.campoApellidoCliente.Location = new System.Drawing.Point(542, 89);
            this.campoApellidoCliente.Margin = new System.Windows.Forms.Padding(0);
            this.campoApellidoCliente.MaxLength = 32767;
            this.campoApellidoCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.campoApellidoCliente.Name = "campoApellidoCliente";
            this.campoApellidoCliente.PasswordChar = '\0';
            this.campoApellidoCliente.PrefixSuffixText = null;
            this.campoApellidoCliente.ReadOnly = false;
            this.campoApellidoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campoApellidoCliente.SelectedText = "";
            this.campoApellidoCliente.SelectionLength = 0;
            this.campoApellidoCliente.SelectionStart = 0;
            this.campoApellidoCliente.ShortcutsEnabled = false;
            this.campoApellidoCliente.Size = new System.Drawing.Size(224, 36);
            this.campoApellidoCliente.TabIndex = 46;
            this.campoApellidoCliente.TabStop = false;
            this.campoApellidoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.campoApellidoCliente.TrailingIcon = null;
            this.campoApellidoCliente.UseAccent = false;
            this.campoApellidoCliente.UseSystemPasswordChar = false;
            this.campoApellidoCliente.UseTallSize = false;
            // 
            // campoNombreCliente
            // 
            this.campoNombreCliente.AnimateReadOnly = false;
            this.campoNombreCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campoNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.campoNombreCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.campoNombreCliente.Depth = 0;
            this.campoNombreCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNombreCliente.HideSelection = true;
            this.campoNombreCliente.LeadingIcon = null;
            this.campoNombreCliente.Location = new System.Drawing.Point(301, 89);
            this.campoNombreCliente.Margin = new System.Windows.Forms.Padding(0);
            this.campoNombreCliente.MaxLength = 32767;
            this.campoNombreCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.campoNombreCliente.Name = "campoNombreCliente";
            this.campoNombreCliente.PasswordChar = '\0';
            this.campoNombreCliente.PrefixSuffixText = null;
            this.campoNombreCliente.ReadOnly = false;
            this.campoNombreCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campoNombreCliente.SelectedText = "";
            this.campoNombreCliente.SelectionLength = 0;
            this.campoNombreCliente.SelectionStart = 0;
            this.campoNombreCliente.ShortcutsEnabled = false;
            this.campoNombreCliente.Size = new System.Drawing.Size(221, 36);
            this.campoNombreCliente.TabIndex = 45;
            this.campoNombreCliente.TabStop = false;
            this.campoNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.campoNombreCliente.TrailingIcon = null;
            this.campoNombreCliente.UseAccent = false;
            this.campoNombreCliente.UseSystemPasswordChar = false;
            this.campoNombreCliente.UseTallSize = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.BackColor = System.Drawing.Color.BlueViolet;
            this.materialButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.materialButton2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.materialButton2.ForeColor = System.Drawing.Color.Aquamarine;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialButton2.Location = new System.Drawing.Point(606, 282);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(99, 36);
            this.materialButton2.TabIndex = 44;
            this.materialButton2.Text = "modificar";
            this.materialButton2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.UseWaitCursor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.BackColor = System.Drawing.Color.BlueViolet;
            this.materialButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.materialButton3.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.materialButton3.ForeColor = System.Drawing.Color.Aquamarine;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialButton3.Location = new System.Drawing.Point(495, 282);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(78, 36);
            this.materialButton3.TabIndex = 43;
            this.materialButton3.Text = "borrar";
            this.materialButton3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.UseWaitCursor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.BackColor = System.Drawing.Color.BlueViolet;
            this.materialButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.materialButton4.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.materialButton4.ForeColor = System.Drawing.Color.Aquamarine;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialButton4.Location = new System.Drawing.Point(364, 282);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(88, 36);
            this.materialButton4.TabIndex = 41;
            this.materialButton4.Text = "agregar";
            this.materialButton4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.UseWaitCursor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialLabel22
            // 
            this.materialLabel22.BackColor = System.Drawing.Color.Azure;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel22.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel22.ForeColor = System.Drawing.Color.Black;
            this.materialLabel22.Location = new System.Drawing.Point(401, 14);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(225, 32);
            this.materialLabel22.TabIndex = 35;
            this.materialLabel22.Text = "datos de clientes";
            this.materialLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel23
            // 
            this.materialLabel23.BackColor = System.Drawing.Color.Azure;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel23.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel23.ForeColor = System.Drawing.Color.Black;
            this.materialLabel23.Location = new System.Drawing.Point(27, 10);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(225, 32);
            this.materialLabel23.TabIndex = 31;
            this.materialLabel23.Text = "listado ";
            this.materialLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fabricantes
            // 
            this.fabricantes.Controls.Add(this.materialButton12);
            this.fabricantes.Controls.Add(this.materialListFabricante);
            this.fabricantes.Controls.Add(this.materialLabel29);
            this.fabricantes.Controls.Add(this.campoNombreFabricante);
            this.fabricantes.Controls.Add(this.materialButton5);
            this.fabricantes.Controls.Add(this.materialButton6);
            this.fabricantes.Controls.Add(this.materialButton7);
            this.fabricantes.Controls.Add(this.materialLabel30);
            this.fabricantes.Controls.Add(this.materialLabel31);
            this.fabricantes.Location = new System.Drawing.Point(4, 4);
            this.fabricantes.Name = "fabricantes";
            this.fabricantes.Padding = new System.Windows.Forms.Padding(3);
            this.fabricantes.Size = new System.Drawing.Size(786, 357);
            this.fabricantes.TabIndex = 4;
            this.fabricantes.Text = "fabricantes";
            this.fabricantes.UseVisualStyleBackColor = true;
            // 
            // materialButton12
            // 
            this.materialButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton12.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton12.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton12.Depth = 0;
            this.materialButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton12.HighEmphasis = true;
            this.materialButton12.Icon = null;
            this.materialButton12.Location = new System.Drawing.Point(296, 9);
            this.materialButton12.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton12.Name = "materialButton12";
            this.materialButton12.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton12.Size = new System.Drawing.Size(64, 36);
            this.materialButton12.TabIndex = 70;
            this.materialButton12.Text = "🔄";
            this.materialButton12.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton12.UseAccentColor = false;
            this.materialButton12.UseVisualStyleBackColor = true;
            this.materialButton12.Click += new System.EventHandler(this.materialButton12_Click);
            // 
            // materialListFabricante
            // 
            this.materialListFabricante.AutoSizeTable = false;
            this.materialListFabricante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListFabricante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListFabricante.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombreFabricante,
            this.id_Fabricante});
            this.materialListFabricante.Depth = 0;
            this.materialListFabricante.FullRowSelect = true;
            this.materialListFabricante.HideSelection = false;
            this.materialListFabricante.Location = new System.Drawing.Point(25, 59);
            this.materialListFabricante.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListFabricante.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListFabricante.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListFabricante.MultiSelect = false;
            this.materialListFabricante.Name = "materialListFabricante";
            this.materialListFabricante.OwnerDraw = true;
            this.materialListFabricante.Size = new System.Drawing.Size(258, 262);
            this.materialListFabricante.TabIndex = 69;
            this.materialListFabricante.UseCompatibleStateImageBehavior = false;
            this.materialListFabricante.View = System.Windows.Forms.View.Details;
            this.materialListFabricante.SelectedIndexChanged += new System.EventHandler(this.materialListFabricante_SelectedIndexChanged);
            // 
            // nombreFabricante
            // 
            this.nombreFabricante.Text = "nombre";
            this.nombreFabricante.Width = 136;
            // 
            // id_Fabricante
            // 
            this.id_Fabricante.Text = "identificador";
            this.id_Fabricante.Width = 123;
            // 
            // materialLabel29
            // 
            this.materialLabel29.BackColor = System.Drawing.Color.Azure;
            this.materialLabel29.Depth = 0;
            this.materialLabel29.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel29.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel29.ForeColor = System.Drawing.Color.Black;
            this.materialLabel29.Location = new System.Drawing.Point(424, 100);
            this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel29.Name = "materialLabel29";
            this.materialLabel29.Size = new System.Drawing.Size(225, 21);
            this.materialLabel29.TabIndex = 68;
            this.materialLabel29.Text = "nombre Fabricante";
            this.materialLabel29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoNombreFabricante
            // 
            this.campoNombreFabricante.AnimateReadOnly = false;
            this.campoNombreFabricante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campoNombreFabricante.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.campoNombreFabricante.Cursor = System.Windows.Forms.Cursors.Default;
            this.campoNombreFabricante.Depth = 0;
            this.campoNombreFabricante.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNombreFabricante.HideSelection = true;
            this.campoNombreFabricante.LeadingIcon = null;
            this.campoNombreFabricante.Location = new System.Drawing.Point(428, 121);
            this.campoNombreFabricante.Margin = new System.Windows.Forms.Padding(0);
            this.campoNombreFabricante.MaxLength = 32767;
            this.campoNombreFabricante.MouseState = MaterialSkin.MouseState.OUT;
            this.campoNombreFabricante.Name = "campoNombreFabricante";
            this.campoNombreFabricante.PasswordChar = '\0';
            this.campoNombreFabricante.PrefixSuffixText = null;
            this.campoNombreFabricante.ReadOnly = false;
            this.campoNombreFabricante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campoNombreFabricante.SelectedText = "";
            this.campoNombreFabricante.SelectionLength = 0;
            this.campoNombreFabricante.SelectionStart = 0;
            this.campoNombreFabricante.ShortcutsEnabled = false;
            this.campoNombreFabricante.Size = new System.Drawing.Size(221, 36);
            this.campoNombreFabricante.TabIndex = 63;
            this.campoNombreFabricante.TabStop = false;
            this.campoNombreFabricante.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.campoNombreFabricante.TrailingIcon = null;
            this.campoNombreFabricante.UseAccent = false;
            this.campoNombreFabricante.UseSystemPasswordChar = false;
            this.campoNombreFabricante.UseTallSize = false;
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(612, 204);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(99, 36);
            this.materialButton5.TabIndex = 62;
            this.materialButton5.Text = "modificar";
            this.materialButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // materialButton6
            // 
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(503, 204);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(78, 36);
            this.materialButton6.TabIndex = 61;
            this.materialButton6.Text = "borrar";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            this.materialButton6.Click += new System.EventHandler(this.materialButton6_Click);
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton7.Depth = 0;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(383, 204);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton7.Size = new System.Drawing.Size(88, 36);
            this.materialButton7.TabIndex = 60;
            this.materialButton7.Text = "agregar";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // materialLabel30
            // 
            this.materialLabel30.BackColor = System.Drawing.Color.Azure;
            this.materialLabel30.Depth = 0;
            this.materialLabel30.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel30.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel30.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel30.ForeColor = System.Drawing.Color.Black;
            this.materialLabel30.Location = new System.Drawing.Point(424, 24);
            this.materialLabel30.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel30.Name = "materialLabel30";
            this.materialLabel30.Size = new System.Drawing.Size(225, 32);
            this.materialLabel30.TabIndex = 59;
            this.materialLabel30.Text = "datos fabricantes";
            this.materialLabel30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel31
            // 
            this.materialLabel31.BackColor = System.Drawing.Color.Azure;
            this.materialLabel31.Depth = 0;
            this.materialLabel31.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel31.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel31.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel31.ForeColor = System.Drawing.Color.Black;
            this.materialLabel31.Location = new System.Drawing.Point(21, 24);
            this.materialLabel31.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel31.Name = "materialLabel31";
            this.materialLabel31.Size = new System.Drawing.Size(225, 32);
            this.materialLabel31.TabIndex = 57;
            this.materialLabel31.Text = "listado ";
            this.materialLabel31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // presupuestos
            // 
            this.presupuestos.Controls.Add(this.materialListPresupuesto);
            this.presupuestos.Controls.Add(this.materialLabel27);
            this.presupuestos.Controls.Add(this.campoSubTotal);
            this.presupuestos.Controls.Add(this.materialMultiLineTextBox1);
            this.presupuestos.Controls.Add(this.materialButton13);
            this.presupuestos.Controls.Add(this.materialLabel18);
            this.presupuestos.Controls.Add(this.comboBox2);
            this.presupuestos.Controls.Add(this.checkedListBox1);
            this.presupuestos.Controls.Add(this.materialLabel28);
            this.presupuestos.Controls.Add(this.materialLabel32);
            this.presupuestos.Controls.Add(this.btnDetalleP);
            this.presupuestos.Controls.Add(this.materialButton9);
            this.presupuestos.Controls.Add(this.materialButton10);
            this.presupuestos.Controls.Add(this.materialLabel33);
            this.presupuestos.Controls.Add(this.materialLabel34);
            this.presupuestos.Location = new System.Drawing.Point(4, 4);
            this.presupuestos.Name = "presupuestos";
            this.presupuestos.Padding = new System.Windows.Forms.Padding(3);
            this.presupuestos.Size = new System.Drawing.Size(786, 357);
            this.presupuestos.TabIndex = 5;
            this.presupuestos.Text = "presupuestos";
            this.presupuestos.UseVisualStyleBackColor = true;
            // 
            // materialListPresupuesto
            // 
            this.materialListPresupuesto.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.materialListPresupuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialListPresupuesto.AutoArrange = false;
            this.materialListPresupuesto.AutoSizeTable = false;
            this.materialListPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListPresupuesto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader8});
            this.materialListPresupuesto.Depth = 0;
            this.materialListPresupuesto.FullRowSelect = true;
            this.materialListPresupuesto.HideSelection = false;
            this.materialListPresupuesto.Location = new System.Drawing.Point(3, 45);
            this.materialListPresupuesto.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListPresupuesto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListPresupuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListPresupuesto.MultiSelect = false;
            this.materialListPresupuesto.Name = "materialListPresupuesto";
            this.materialListPresupuesto.OwnerDraw = true;
            this.materialListPresupuesto.Size = new System.Drawing.Size(263, 192);
            this.materialListPresupuesto.TabIndex = 78;
            this.materialListPresupuesto.UseCompatibleStateImageBehavior = false;
            this.materialListPresupuesto.View = System.Windows.Forms.View.Details;
            this.materialListPresupuesto.SelectedIndexChanged += new System.EventHandler(this.materialListPresupuesto_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "nombre y apellido";
            this.columnHeader7.Width = 160;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "telefono";
            this.columnHeader9.Width = 99;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "descripcion";
            this.columnHeader10.Width = 195;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "fecha";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "total";
            this.columnHeader12.Width = 114;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "id";
            this.columnHeader13.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "id_cl";
            // 
            // materialLabel27
            // 
            this.materialLabel27.BackColor = System.Drawing.Color.Azure;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel27.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel27.ForeColor = System.Drawing.Color.Black;
            this.materialLabel27.Location = new System.Drawing.Point(493, 223);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Size = new System.Drawing.Size(126, 21);
            this.materialLabel27.TabIndex = 77;
            this.materialLabel27.Text = "sub total";
            this.materialLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoSubTotal
            // 
            this.campoSubTotal.AnimateReadOnly = false;
            this.campoSubTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campoSubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.campoSubTotal.Depth = 0;
            this.campoSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.campoSubTotal.HideSelection = true;
            this.campoSubTotal.LeadingIcon = null;
            this.campoSubTotal.Location = new System.Drawing.Point(493, 247);
            this.campoSubTotal.MaxLength = 12;
            this.campoSubTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.campoSubTotal.Name = "campoSubTotal";
            this.campoSubTotal.PasswordChar = '\0';
            this.campoSubTotal.PrefixSuffixText = null;
            this.campoSubTotal.ReadOnly = true;
            this.campoSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.campoSubTotal.SelectedText = "";
            this.campoSubTotal.SelectionLength = 0;
            this.campoSubTotal.SelectionStart = 0;
            this.campoSubTotal.ShortcutsEnabled = true;
            this.campoSubTotal.Size = new System.Drawing.Size(126, 48);
            this.campoSubTotal.TabIndex = 76;
            this.campoSubTotal.TabStop = false;
            this.campoSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.campoSubTotal.TrailingIcon = null;
            this.campoSubTotal.UseSystemPasswordChar = false;
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(566, 149);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(194, 65);
            this.materialMultiLineTextBox1.TabIndex = 75;
            this.materialMultiLineTextBox1.Text = "";
            // 
            // materialButton13
            // 
            this.materialButton13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton13.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton13.Depth = 0;
            this.materialButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.materialButton13.HighEmphasis = true;
            this.materialButton13.Icon = null;
            this.materialButton13.Location = new System.Drawing.Point(306, 10);
            this.materialButton13.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton13.Name = "materialButton13";
            this.materialButton13.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton13.Size = new System.Drawing.Size(64, 36);
            this.materialButton13.TabIndex = 74;
            this.materialButton13.Text = "🔄";
            this.materialButton13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialButton13.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton13.UseAccentColor = true;
            this.materialButton13.UseVisualStyleBackColor = true;
            this.materialButton13.Click += new System.EventHandler(this.materialButton13_Click);
            // 
            // materialLabel18
            // 
            this.materialLabel18.BackColor = System.Drawing.Color.Azure;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.ForeColor = System.Drawing.Color.Black;
            this.materialLabel18.Location = new System.Drawing.Point(566, 126);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(193, 21);
            this.materialLabel18.TabIndex = 72;
            this.materialLabel18.Text = "observaciones";
            this.materialLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(465, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 71;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(340, 150);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(198, 64);
            this.checkedListBox1.TabIndex = 70;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox1_ItemCheck);
            // 
            // materialLabel28
            // 
            this.materialLabel28.BackColor = System.Drawing.Color.Azure;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel28.ForeColor = System.Drawing.Color.Black;
            this.materialLabel28.Location = new System.Drawing.Point(340, 126);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(198, 21);
            this.materialLabel28.TabIndex = 69;
            this.materialLabel28.Text = "servicio-repuesto";
            this.materialLabel28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel32
            // 
            this.materialLabel32.BackColor = System.Drawing.Color.Azure;
            this.materialLabel32.Depth = 0;
            this.materialLabel32.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel32.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel32.ForeColor = System.Drawing.Color.Black;
            this.materialLabel32.Location = new System.Drawing.Point(464, 64);
            this.materialLabel32.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel32.Name = "materialLabel32";
            this.materialLabel32.Size = new System.Drawing.Size(201, 21);
            this.materialLabel32.TabIndex = 68;
            this.materialLabel32.Text = "cliente";
            this.materialLabel32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDetalleP
            // 
            this.btnDetalleP.AutoSize = false;
            this.btnDetalleP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetalleP.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnDetalleP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnDetalleP.Depth = 0;
            this.btnDetalleP.Enabled = false;
            this.btnDetalleP.HighEmphasis = true;
            this.btnDetalleP.Icon = null;
            this.btnDetalleP.Location = new System.Drawing.Point(51, 273);
            this.btnDetalleP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDetalleP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetalleP.Name = "btnDetalleP";
            this.btnDetalleP.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDetalleP.Size = new System.Drawing.Size(180, 32);
            this.btnDetalleP.TabIndex = 62;
            this.btnDetalleP.Text = "detalle";
            this.btnDetalleP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalleP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetalleP.UseAccentColor = false;
            this.btnDetalleP.UseVisualStyleBackColor = true;
            this.btnDetalleP.Click += new System.EventHandler(this.materialButton8_Click);
            // 
            // materialButton9
            // 
            this.materialButton9.AutoSize = false;
            this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton9.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton9.Depth = 0;
            this.materialButton9.Enabled = false;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = null;
            this.materialButton9.Location = new System.Drawing.Point(51, 312);
            this.materialButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton9.Size = new System.Drawing.Size(180, 32);
            this.materialButton9.TabIndex = 61;
            this.materialButton9.Text = "borrar";
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            this.materialButton9.Click += new System.EventHandler(this.materialButton9_Click);
            // 
            // materialButton10
            // 
            this.materialButton10.AutoSize = false;
            this.materialButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton10.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton10.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton10.Depth = 0;
            this.materialButton10.HighEmphasis = true;
            this.materialButton10.Icon = null;
            this.materialButton10.Location = new System.Drawing.Point(465, 312);
            this.materialButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton10.Name = "materialButton10";
            this.materialButton10.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton10.Size = new System.Drawing.Size(168, 36);
            this.materialButton10.TabIndex = 60;
            this.materialButton10.Text = "agregar";
            this.materialButton10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton10.UseAccentColor = false;
            this.materialButton10.UseVisualStyleBackColor = true;
            this.materialButton10.Click += new System.EventHandler(this.materialButton10_Click);
            // 
            // materialLabel33
            // 
            this.materialLabel33.BackColor = System.Drawing.Color.Azure;
            this.materialLabel33.Depth = 0;
            this.materialLabel33.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel33.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel33.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel33.ForeColor = System.Drawing.Color.Black;
            this.materialLabel33.Location = new System.Drawing.Point(451, 32);
            this.materialLabel33.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel33.Name = "materialLabel33";
            this.materialLabel33.Size = new System.Drawing.Size(225, 32);
            this.materialLabel33.TabIndex = 59;
            this.materialLabel33.Text = "datos de presupuestos";
            this.materialLabel33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel34
            // 
            this.materialLabel34.BackColor = System.Drawing.Color.Azure;
            this.materialLabel34.Depth = 0;
            this.materialLabel34.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel34.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel34.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel34.ForeColor = System.Drawing.Color.Black;
            this.materialLabel34.Location = new System.Drawing.Point(6, 10);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(225, 32);
            this.materialLabel34.TabIndex = 57;
            this.materialLabel34.Text = "listado de presupuestos";
            this.materialLabel34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repaAr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerHighlightWithAccent = false;
            this.DrawerTabControl = this.materialTabControl1;
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Name = "repaAr";
            this.Text = "repa.Ar";
            this.materialTabControl1.ResumeLayout(false);
            this.inicio.ResumeLayout(false);
            this.administrador.ResumeLayout(false);
            this.administrador.PerformLayout();
            this.repuestos.ResumeLayout(false);
            this.repuestos.PerformLayout();
            this.clientes.ResumeLayout(false);
            this.clientes.PerformLayout();
            this.fabricantes.ResumeLayout(false);
            this.fabricantes.PerformLayout();
            this.presupuestos.ResumeLayout(false);
            this.presupuestos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage inicio;
        private System.Windows.Forms.TabPage administrador;
        private System.Windows.Forms.TabPage repuestos;
        private System.Windows.Forms.TabPage clientes;
        private System.Windows.Forms.TabPage fabricantes;
        private System.Windows.Forms.TabPage presupuestos;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 adminNombre;
        private MaterialSkin.Controls.MaterialTextBox2 adminDireccion;
        private MaterialSkin.Controls.MaterialTextBox2 adminCuil;
        private MaterialSkin.Controls.MaterialTextBox2 adminApellido;
        private MaterialSkin.Controls.MaterialTextBox2 adminEmpresa;
        private MaterialSkin.Controls.MaterialTextBox2 adminTelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialTextBox2 precioRepuesto;
        private MaterialSkin.Controls.MaterialTextBox2 precioVRepuesta;
        private MaterialSkin.Controls.MaterialTextBox2 nombreRepuesto;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialTextBox2 campoTelefonoCliente;
        private MaterialSkin.Controls.MaterialTextBox2 campoDireccionCliente;
        private MaterialSkin.Controls.MaterialTextBox2 campoCuilCliente;
        private MaterialSkin.Controls.MaterialTextBox2 campoApellidoCliente;
        private MaterialSkin.Controls.MaterialTextBox2 campoNombreCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private MaterialSkin.Controls.MaterialLabel materialLabel29;
        private MaterialSkin.Controls.MaterialTextBox2 campoNombreFabricante;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialLabel materialLabel30;
        private MaterialSkin.Controls.MaterialLabel materialLabel31;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private MaterialSkin.Controls.MaterialLabel materialLabel32;
        private MaterialSkin.Controls.MaterialButton btnDetalleP;
        private MaterialSkin.Controls.MaterialButton materialButton9;
        private MaterialSkin.Controls.MaterialButton materialButton10;
        private MaterialSkin.Controls.MaterialLabel materialLabel33;
        private MaterialSkin.Controls.MaterialLabel materialLabel34;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private System.Windows.Forms.ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialTextBox2 descripcionRepuesto;
        private MaterialSkin.Controls.MaterialListView materialListRepuesto;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialButton materialButton11;
        private MaterialSkin.Controls.MaterialListView materialListClientes;
        private System.Windows.Forms.ColumnHeader nombreCliente;
        private System.Windows.Forms.ColumnHeader apellidoCliente;
        private System.Windows.Forms.ColumnHeader cuilCliente;
        private System.Windows.Forms.ColumnHeader telefonoCliente;
        private System.Windows.Forms.ColumnHeader direccionCliente;
        private MaterialSkin.Controls.MaterialButton cargarClientes;
        private System.Windows.Forms.ColumnHeader id_cliente;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton btnCambiosRep;
        private MaterialSkin.Controls.MaterialButton btnBorrarRep;
        private MaterialSkin.Controls.MaterialButton btnAgregarRep;
        private MaterialSkin.Controls.MaterialButton materialButton12;
        private MaterialSkin.Controls.MaterialListView materialListFabricante;
        private System.Windows.Forms.ColumnHeader nombreFabricante;
        private System.Windows.Forms.ColumnHeader id_Fabricante;
        private MaterialSkin.Controls.MaterialButton materialButton13;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialTextBox2 campoSubTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel27;
        private MaterialSkin.Controls.MaterialListView materialListPresupuesto;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}


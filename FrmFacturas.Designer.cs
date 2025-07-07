namespace GestiónClientesyFacturación
{
    partial class FrmFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturas));
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            this.btnLimpiarDataGrid = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNombreyUsuario = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.btbBorrarLineaDataGrid = new System.Windows.Forms.Button();
            this.btnAnadirCliente = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnCierreCaja = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoOtroPago = new System.Windows.Forms.TextBox();
            this.groupBusca = new System.Windows.Forms.GroupBox();
            this.lblDevuelta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCambioUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarProducto.Location = new System.Drawing.Point(31, 528);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(85, 25);
            this.btnBuscarProducto.TabIndex = 17;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.AllowUserToAddRows = false;
            this.dataGridViewVenta.AllowUserToDeleteRows = false;
            this.dataGridViewVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewVenta.Location = new System.Drawing.Point(12, 219);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.ReadOnly = true;
            this.dataGridViewVenta.RowHeadersVisible = false;
            this.dataGridViewVenta.Size = new System.Drawing.Size(822, 264);
            this.dataGridViewVenta.TabIndex = 1;
            this.dataGridViewVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVenta_CellContentClick);
            // 
            // btnLimpiarDataGrid
            // 
            this.btnLimpiarDataGrid.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiarDataGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDataGrid.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDataGrid.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarDataGrid.Location = new System.Drawing.Point(120, 528);
            this.btnLimpiarDataGrid.Name = "btnLimpiarDataGrid";
            this.btnLimpiarDataGrid.Size = new System.Drawing.Size(117, 25);
            this.btnLimpiarDataGrid.TabIndex = 18;
            this.btnLimpiarDataGrid.Text = "LIMPIAR PANTALLA";
            this.btnLimpiarDataGrid.UseVisualStyleBackColor = false;
            this.btnLimpiarDataGrid.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // lblNombreyUsuario
            // 
            this.lblNombreyUsuario.AutoSize = true;
            this.lblNombreyUsuario.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreyUsuario.Location = new System.Drawing.Point(79, 70);
            this.lblNombreyUsuario.Name = "lblNombreyUsuario";
            this.lblNombreyUsuario.Size = new System.Drawing.Size(101, 14);
            this.lblNombreyUsuario.TabIndex = 21;
            this.lblNombreyUsuario.Text = "Nombre y Usuario";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(79, 87);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(42, 14);
            this.lblVendedor.TabIndex = 22;
            this.lblVendedor.Text = "Puesto";
            // 
            // btn7
            // 
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Location = new System.Drawing.Point(666, 94);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(31, 27);
            this.btn7.TabIndex = 26;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Location = new System.Drawing.Point(697, 94);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(31, 27);
            this.btn8.TabIndex = 27;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Location = new System.Drawing.Point(728, 94);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(31, 27);
            this.btn9.TabIndex = 28;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Location = new System.Drawing.Point(728, 121);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(31, 27);
            this.btn6.TabIndex = 31;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Location = new System.Drawing.Point(697, 121);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(31, 27);
            this.btn5.TabIndex = 30;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Location = new System.Drawing.Point(666, 121);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(31, 27);
            this.btn4.TabIndex = 29;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Location = new System.Drawing.Point(728, 148);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(31, 27);
            this.btn3.TabIndex = 34;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Location = new System.Drawing.Point(697, 148);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(31, 27);
            this.btn2.TabIndex = 33;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Location = new System.Drawing.Point(666, 148);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(31, 27);
            this.btn1.TabIndex = 32;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.Location = new System.Drawing.Point(666, 175);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(62, 27);
            this.btn0.TabIndex = 35;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Location = new System.Drawing.Point(759, 174);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(62, 27);
            this.btnEnter.TabIndex = 37;
            this.btnEnter.Text = "=";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuma.Location = new System.Drawing.Point(759, 94);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(31, 27);
            this.btnSuma.TabIndex = 40;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(790, 94);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(31, 27);
            this.btnResta.TabIndex = 39;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplica.Location = new System.Drawing.Point(759, 121);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(31, 27);
            this.btnMultiplica.TabIndex = 38;
            this.btnMultiplica.Text = "*";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            this.btnMultiplica.Click += new System.EventHandler(this.btnMultiplica_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(759, 148);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(31, 27);
            this.btnDivide.TabIndex = 41;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(790, 121);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 27);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(728, 174);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(31, 27);
            this.btnPunto.TabIndex = 43;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Location = new System.Drawing.Point(790, 148);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(31, 27);
            this.btnBorrar.TabIndex = 44;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtScreen
            // 
            this.txtScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScreen.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScreen.ForeColor = System.Drawing.Color.Black;
            this.txtScreen.Location = new System.Drawing.Point(666, 57);
            this.txtScreen.Multiline = true;
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.Size = new System.Drawing.Size(155, 34);
            this.txtScreen.TabIndex = 45;
            this.txtScreen.Text = "0";
            this.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearFactura.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFactura.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCrearFactura.Location = new System.Drawing.Point(493, 47);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(110, 24);
            this.btnCrearFactura.TabIndex = 16;
            this.btnCrearFactura.Text = "FACTURAR";
            this.btnCrearFactura.UseVisualStyleBackColor = false;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // btbBorrarLineaDataGrid
            // 
            this.btbBorrarLineaDataGrid.BackColor = System.Drawing.Color.DarkCyan;
            this.btbBorrarLineaDataGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbBorrarLineaDataGrid.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBorrarLineaDataGrid.ForeColor = System.Drawing.SystemColors.Window;
            this.btbBorrarLineaDataGrid.Location = new System.Drawing.Point(243, 528);
            this.btbBorrarLineaDataGrid.Name = "btbBorrarLineaDataGrid";
            this.btbBorrarLineaDataGrid.Size = new System.Drawing.Size(111, 25);
            this.btbBorrarLineaDataGrid.TabIndex = 49;
            this.btbBorrarLineaDataGrid.Text = "BORRAR LINEA";
            this.btbBorrarLineaDataGrid.UseVisualStyleBackColor = false;
            this.btbBorrarLineaDataGrid.Click += new System.EventHandler(this.btbBorrarLineaDataGrid_Click);
            // 
            // btnAnadirCliente
            // 
            this.btnAnadirCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAnadirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadirCliente.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAnadirCliente.Location = new System.Drawing.Point(497, 528);
            this.btnAnadirCliente.Name = "btnAnadirCliente";
            this.btnAnadirCliente.Size = new System.Drawing.Size(111, 25);
            this.btnAnadirCliente.TabIndex = 50;
            this.btnAnadirCliente.Text = "AÑADIR CLIENTE";
            this.btnAnadirCliente.UseVisualStyleBackColor = false;
            this.btnAnadirCliente.Click += new System.EventHandler(this.btnAnadirCliente_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.DarkCyan;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInventario.Location = new System.Drawing.Point(614, 528);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(94, 25);
            this.btnInventario.TabIndex = 51;
            this.btnInventario.Text = "INVENTARIO";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierreCaja.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreCaja.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCierreCaja.Location = new System.Drawing.Point(715, 528);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(99, 25);
            this.btnCierreCaja.TabIndex = 52;
            this.btnCierreCaja.Text = "CIERRE DE CAJA";
            this.btnCierreCaja.UseVisualStyleBackColor = false;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(11, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(90, 14);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "Metodo de Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total a pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Efectivo";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEfectivo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.ForeColor = System.Drawing.Color.Black;
            this.txtEfectivo.Location = new System.Drawing.Point(285, 19);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(135, 18);
            this.txtEfectivo.TabIndex = 26;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "Por otro pago";
            // 
            // txtMontoOtroPago
            // 
            this.txtMontoOtroPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoOtroPago.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoOtroPago.ForeColor = System.Drawing.Color.Black;
            this.txtMontoOtroPago.Location = new System.Drawing.Point(314, 45);
            this.txtMontoOtroPago.Name = "txtMontoOtroPago";
            this.txtMontoOtroPago.Size = new System.Drawing.Size(106, 18);
            this.txtMontoOtroPago.TabIndex = 28;
            this.txtMontoOtroPago.TextChanged += new System.EventHandler(this.txtMontoOtroPago_TextChanged);
            // 
            // groupBusca
            // 
            this.groupBusca.Controls.Add(this.lblDevuelta);
            this.groupBusca.Controls.Add(this.label4);
            this.groupBusca.Controls.Add(this.cmbMetodoPago);
            this.groupBusca.Controls.Add(this.txtTotalPagar);
            this.groupBusca.Controls.Add(this.txtMontoOtroPago);
            this.groupBusca.Controls.Add(this.label2);
            this.groupBusca.Controls.Add(this.txtEfectivo);
            this.groupBusca.Controls.Add(this.label3);
            this.groupBusca.Controls.Add(this.label1);
            this.groupBusca.Controls.Add(this.lblCodigo);
            this.groupBusca.Controls.Add(this.btnCrearFactura);
            this.groupBusca.Location = new System.Drawing.Point(12, 120);
            this.groupBusca.Name = "groupBusca";
            this.groupBusca.Size = new System.Drawing.Size(629, 81);
            this.groupBusca.TabIndex = 46;
            this.groupBusca.TabStop = false;
            this.groupBusca.Text = "Facturación";
            // 
            // lblDevuelta
            // 
            this.lblDevuelta.AutoSize = true;
            this.lblDevuelta.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevuelta.Location = new System.Drawing.Point(505, 21);
            this.lblDevuelta.Name = "lblDevuelta";
            this.lblDevuelta.Size = new System.Drawing.Size(11, 14);
            this.lblDevuelta.TabIndex = 33;
            this.lblDevuelta.Text = "-";
            this.lblDevuelta.Click += new System.EventHandler(this.lblDevuelta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 32;
            this.label4.Text = "Devolver";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Transferencia"});
            this.cmbMetodoPago.Location = new System.Drawing.Point(104, 18);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodoPago.TabIndex = 31;
            this.cmbMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cmbMetodoPago_SelectedIndexChanged);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPagar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPagar.Location = new System.Drawing.Point(91, 47);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(134, 18);
            this.txtTotalPagar.TabIndex = 30;
            this.txtTotalPagar.TextChanged += new System.EventHandler(this.txtTotalPagar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(802, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(846, 45);
            this.panel2.TabIndex = 53;
            // 
            // btnCambioUsuario
            // 
            this.btnCambioUsuario.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCambioUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambioUsuario.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCambioUsuario.Location = new System.Drawing.Point(360, 528);
            this.btnCambioUsuario.Name = "btnCambioUsuario";
            this.btnCambioUsuario.Size = new System.Drawing.Size(131, 25);
            this.btnCambioUsuario.TabIndex = 54;
            this.btnCambioUsuario.Text = "CAMBIAR DE USUARIO";
            this.btnCambioUsuario.UseVisualStyleBackColor = false;
            this.btnCambioUsuario.Click += new System.EventHandler(this.btnCambioUsuario_Click);
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 565);
            this.Controls.Add(this.btnCambioUsuario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCierreCaja);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnAnadirCliente);
            this.Controls.Add(this.btbBorrarLineaDataGrid);
            this.Controls.Add(this.groupBusca);
            this.Controls.Add(this.txtScreen);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblNombreyUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLimpiarDataGrid);
            this.Controls.Add(this.dataGridViewVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacturas";
            this.Load += new System.EventHandler(this.FrmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBusca.ResumeLayout(false);
            this.groupBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewVenta;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnLimpiarDataGrid;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNombreyUsuario;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtScreen;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Button btbBorrarLineaDataGrid;
        private System.Windows.Forms.Button btnAnadirCliente;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnCierreCaja;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoOtroPago;
        private System.Windows.Forms.GroupBox groupBusca;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCambioUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDevuelta;
    }
}
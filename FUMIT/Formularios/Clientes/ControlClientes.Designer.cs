namespace FUMIT.Formularios.Clientes
{
    partial class ControlClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlClientes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarCliente = new System.Windows.Forms.ToolStripButton();
            this.btnEditarCliente = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarEdicion = new System.Windows.Forms.ToolStripButton();
            this.btnAceptarAgregar = new System.Windows.Forms.ToolStripButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblClaveCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarPorClave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEsMoroso = new System.Windows.Forms.Label();
            this.txtTrue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBloqueado = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblOtrasSucursales = new System.Windows.Forms.Label();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.borradoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarCliente,
            this.btnEditarCliente,
            this.btnCancelarEdicion,
            this.btnAceptarAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCliente.Image")));
            this.btnAgregarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(69, 22);
            this.btnAgregarCliente.Text = "Agregar";
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCliente.Image")));
            this.btnEditarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(57, 22);
            this.btnEditarCliente.Text = "Editar";
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.Enabled = false;
            this.btnCancelarEdicion.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarEdicion.Image")));
            this.btnCancelarEdicion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(73, 22);
            this.btnCancelarEdicion.Text = "Cancelar";
            this.btnCancelarEdicion.Visible = false;
            // 
            // btnAceptarAgregar
            // 
            this.btnAceptarAgregar.Enabled = false;
            this.btnAceptarAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarAgregar.Image")));
            this.btnAceptarAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAceptarAgregar.Name = "btnAceptarAgregar";
            this.btnAceptarAgregar.Size = new System.Drawing.Size(68, 22);
            this.btnAceptarAgregar.Text = "Aceptar";
            this.btnAceptarAgregar.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(320, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(8, 78);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 13;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(237, 22);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(31, 13);
            this.lblRFC.TabIndex = 14;
            this.lblRFC.Text = "RFC:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(8, 104);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(5, 22);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(53, 13);
            this.lblContacto.TabIndex = 17;
            this.lblContacto.Text = "Contacto:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(5, 48);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 18;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(6, 73);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 19;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(140, 20);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 20;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(84, 75);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(357, 20);
            this.txtSucursal.TabIndex = 21;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(274, 19);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(100, 20);
            this.txtRFC.TabIndex = 22;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(84, 101);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(357, 20);
            this.txtDireccion.TabIndex = 23;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(64, 70);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(239, 20);
            this.txtCorreo.TabIndex = 24;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(227, 17);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(529, 91);
            this.txtObservaciones.TabIndex = 25;
            // 
            // txtTelefono
            // 
            this.txtTelefono.CausesValidation = false;
            this.txtTelefono.Location = new System.Drawing.Point(64, 44);
            this.txtTelefono.Mask = "(999)000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(239, 20);
            this.txtTelefono.TabIndex = 26;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(64, 19);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(239, 20);
            this.txtContacto.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnBuscarPorClave);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblClaveCliente);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblSucursal);
            this.groupBox1.Controls.Add(this.lblRFC);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtSucursal);
            this.groupBox1.Controls.Add(this.txtRFC);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 138);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtContacto);
            this.groupBox2.Controls.Add(this.lblContacto);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.lblCorreo);
            this.groupBox2.Controls.Add(this.lblTelefono);
            this.groupBox2.Location = new System.Drawing.Point(465, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 137);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBloqueado);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTrue);
            this.groupBox3.Controls.Add(this.lblEsMoroso);
            this.groupBox3.Controls.Add(this.txtObservaciones);
            this.groupBox3.Controls.Add(this.lblObservaciones);
            this.groupBox3.Location = new System.Drawing.Point(12, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 124);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observaciones";
            // 
            // lblClaveCliente
            // 
            this.lblClaveCliente.AutoSize = true;
            this.lblClaveCliente.Location = new System.Drawing.Point(7, 20);
            this.lblClaveCliente.Name = "lblClaveCliente";
            this.lblClaveCliente.Size = new System.Drawing.Size(71, 13);
            this.lblClaveCliente.TabIndex = 24;
            this.lblClaveCliente.Text = "Clave cliente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            // 
            // btnBuscarPorClave
            // 
            this.btnBuscarPorClave.Image = global::FUMIT.Recursos.search;
            this.btnBuscarPorClave.Location = new System.Drawing.Point(190, 17);
            this.btnBuscarPorClave.Name = "btnBuscarPorClave";
            this.btnBuscarPorClave.Size = new System.Drawing.Size(31, 23);
            this.btnBuscarPorClave.TabIndex = 26;
            this.btnBuscarPorClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPorClave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::FUMIT.Recursos.search;
            this.button1.Location = new System.Drawing.Point(410, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 27;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblEsMoroso
            // 
            this.lblEsMoroso.AutoSize = true;
            this.lblEsMoroso.Location = new System.Drawing.Point(11, 20);
            this.lblEsMoroso.Name = "lblEsMoroso";
            this.lblEsMoroso.Size = new System.Drawing.Size(59, 13);
            this.lblEsMoroso.TabIndex = 26;
            this.lblEsMoroso.Text = "Es moroso:";
            // 
            // txtTrue
            // 
            this.txtTrue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrue.Location = new System.Drawing.Point(77, 20);
            this.txtTrue.Name = "txtTrue";
            this.txtTrue.ReadOnly = true;
            this.txtTrue.Size = new System.Drawing.Size(25, 13);
            this.txtTrue.TabIndex = 27;
            this.txtTrue.Text = "No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bloqueado:";
            // 
            // txtBloqueado
            // 
            this.txtBloqueado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBloqueado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBloqueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloqueado.Location = new System.Drawing.Point(79, 42);
            this.txtBloqueado.Name = "txtBloqueado";
            this.txtBloqueado.ReadOnly = true;
            this.txtBloqueado.Size = new System.Drawing.Size(23, 13);
            this.txtBloqueado.TabIndex = 29;
            this.txtBloqueado.Text = "No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.borradoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(587, 98);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblOtrasSucursales
            // 
            this.lblOtrasSucursales.AutoSize = true;
            this.lblOtrasSucursales.Location = new System.Drawing.Point(9, 332);
            this.lblOtrasSucursales.Name = "lblOtrasSucursales";
            this.lblOtrasSucursales.Size = new System.Drawing.Size(88, 13);
            this.lblOtrasSucursales.TabIndex = 32;
            this.lblOtrasSucursales.Text = "Otras sucursales:";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // borradoDataGridViewCheckBoxColumn
            // 
            this.borradoDataGridViewCheckBoxColumn.DataPropertyName = "Borrado";
            this.borradoDataGridViewCheckBoxColumn.HeaderText = "Borrado";
            this.borradoDataGridViewCheckBoxColumn.Name = "borradoDataGridViewCheckBoxColumn";
            this.borradoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(FUMIT.Entidades.Cliente);
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(FUMIT.Entidades.Sucursal);
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataSource = typeof(FUMIT.Entidades.Cliente);
            // 
            // ControlClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 789);
            this.Controls.Add(this.lblOtrasSucursales);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ControlClientes";
            this.Text = "Clientes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregarCliente;
        private System.Windows.Forms.ToolStripButton btnEditarCliente;
        private System.Windows.Forms.ToolStripButton btnCancelarEdicion;
        private System.Windows.Forms.ToolStripButton btnAceptarAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarPorClave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblClaveCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBloqueado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrue;
        private System.Windows.Forms.Label lblEsMoroso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn borradoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private System.Windows.Forms.Label lblOtrasSucursales;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
    }
}
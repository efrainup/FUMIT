namespace FUMIT.Formularios.Catalogos
{
    partial class Sucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursales));
            this.ListaSucursales = new System.Windows.Forms.DataGridView();
            this.lblSucursales = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarSucursal = new System.Windows.Forms.ToolStripButton();
            this.btnEditarSucursal = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarEdicion = new System.Windows.Forms.ToolStripButton();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtSucursales = new System.Windows.Forms.TextBox();
            this.btnBuscarNumero = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAceptarAgregar = new System.Windows.Forms.ToolStripButton();
            this.colSucursalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListaSucursales)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaSucursales
            // 
            this.ListaSucursales.AllowUserToAddRows = false;
            this.ListaSucursales.AllowUserToDeleteRows = false;
            this.ListaSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSucursalId,
            this.colNumero,
            this.colSucursal,
            this.colEstado,
            this.colCiudad,
            this.colDireccion,
            this.colActivo});
            this.ListaSucursales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListaSucursales.Location = new System.Drawing.Point(12, 110);
            this.ListaSucursales.Name = "ListaSucursales";
            this.ListaSucursales.Size = new System.Drawing.Size(725, 167);
            this.ListaSucursales.TabIndex = 0;
            this.ListaSucursales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaSucursales_CellValueChanged);
            this.ListaSucursales.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ListaSucursales_UserAddedRow);
            this.ListaSucursales.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ListaSucursales_UserDeletedRow);
            // 
            // lblSucursales
            // 
            this.lblSucursales.AutoSize = true;
            this.lblSucursales.Location = new System.Drawing.Point(12, 94);
            this.lblSucursales.Name = "lblSucursales";
            this.lblSucursales.Size = new System.Drawing.Size(112, 13);
            this.lblSucursales.TabIndex = 1;
            this.lblSucursales.Text = "Sucursales existentes:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(581, 283);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(662, 283);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarSucursal,
            this.btnEditarSucursal,
            this.btnCancelarEdicion,
            this.btnAceptarAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(749, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregarSucursal
            // 
            this.btnAgregarSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarSucursal.Image")));
            this.btnAgregarSucursal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarSucursal.Name = "btnAgregarSucursal";
            this.btnAgregarSucursal.Size = new System.Drawing.Size(69, 22);
            this.btnAgregarSucursal.Text = "Agregar";
            this.btnAgregarSucursal.Click += new System.EventHandler(this.btnAgregarSucursal_Click);
            // 
            // btnEditarSucursal
            // 
            this.btnEditarSucursal.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarSucursal.Image")));
            this.btnEditarSucursal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarSucursal.Name = "btnEditarSucursal";
            this.btnEditarSucursal.Size = new System.Drawing.Size(57, 22);
            this.btnEditarSucursal.Text = "Editar";
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
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(12, 58);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 10;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(66, 34);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 11;
            // 
            // txtSucursales
            // 
            this.txtSucursales.Location = new System.Drawing.Point(66, 58);
            this.txtSucursales.Name = "txtSucursales";
            this.txtSucursales.Size = new System.Drawing.Size(210, 20);
            this.txtSucursales.TabIndex = 12;
            // 
            // btnBuscarNumero
            // 
            this.btnBuscarNumero.Image = global::FUMIT.Recursos.search;
            this.btnBuscarNumero.Location = new System.Drawing.Point(172, 32);
            this.btnBuscarNumero.Name = "btnBuscarNumero";
            this.btnBuscarNumero.Size = new System.Drawing.Size(29, 23);
            this.btnBuscarNumero.TabIndex = 13;
            this.btnBuscarNumero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarNumero.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::FUMIT.Recursos.search;
            this.button1.Location = new System.Drawing.Point(282, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 14;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAceptarAgregar
            // 
            this.btnAceptarAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptarAgregar.Image")));
            this.btnAceptarAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAceptarAgregar.Name = "btnAceptarAgregar";
            this.btnAceptarAgregar.Size = new System.Drawing.Size(68, 22);
            this.btnAceptarAgregar.Text = "Aceptar";
            this.btnAceptarAgregar.Click += new System.EventHandler(this.btnAceptarAgregar_Click);
            // 
            // colSucursalId
            // 
            this.colSucursalId.HeaderText = "SucursalId";
            this.colSucursalId.Name = "colSucursalId";
            this.colSucursalId.ReadOnly = true;
            this.colSucursalId.Visible = false;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Numero";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            // 
            // colSucursal
            // 
            this.colSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSucursal.HeaderText = "Nombre";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colCiudad
            // 
            this.colCiudad.HeaderText = "Ciudad";
            this.colCiudad.Name = "colCiudad";
            this.colCiudad.ReadOnly = true;
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            // 
            // colActivo
            // 
            this.colActivo.HeaderText = "Activo";
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            // 
            // Sucursales
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(749, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarNumero);
            this.Controls.Add(this.txtSucursales);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblSucursales);
            this.Controls.Add(this.ListaSucursales);
            this.Name = "Sucursales";
            this.Text = "Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.ListaSucursales)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaSucursales;
        private System.Windows.Forms.Label lblSucursales;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregarSucursal;
        private System.Windows.Forms.ToolStripButton btnEditarSucursal;
        private System.Windows.Forms.ToolStripButton btnCancelarEdicion;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtSucursales;
        private System.Windows.Forms.Button btnBuscarNumero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSucursalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActivo;
        private System.Windows.Forms.ToolStripButton btnAceptarAgregar;
    }
}
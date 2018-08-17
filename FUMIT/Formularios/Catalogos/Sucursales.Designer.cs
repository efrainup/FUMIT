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
            this.ListaSucursales = new System.Windows.Forms.DataGridView();
            this.SucursalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblSucursales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarSucursal = new System.Windows.Forms.ToolStripButton();
            this.btnEditarSucursal = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarEdicion = new System.Windows.Forms.ToolStripButton();
            this.btnAceptarAgregar = new System.Windows.Forms.ToolStripButton();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarNumero = new System.Windows.Forms.Button();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdSucursal = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
            this.SucursalId,
            this.Numero,
            this.Nombre,
            this.Estado,
            this.Ciudad,
            this.Direccion,
            this.Activo});
            this.ListaSucursales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListaSucursales.Location = new System.Drawing.Point(12, 102);
            this.ListaSucursales.Name = "ListaSucursales";
            this.ListaSucursales.ReadOnly = true;
            this.ListaSucursales.Size = new System.Drawing.Size(725, 136);
            this.ListaSucursales.TabIndex = 0;
            this.ListaSucursales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaSucursales_CellValueChanged);
            this.ListaSucursales.SelectionChanged += new System.EventHandler(this.ListaSucursales_SelectionChanged);
            this.ListaSucursales.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ListaSucursales_UserAddedRow);
            this.ListaSucursales.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ListaSucursales_UserDeletedRow);
            // 
            // SucursalId
            // 
            this.SucursalId.HeaderText = "SucursalId";
            this.SucursalId.Name = "SucursalId";
            this.SucursalId.ReadOnly = true;
            this.SucursalId.Visible = false;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // lblSucursales
            // 
            this.lblSucursales.AutoSize = true;
            this.lblSucursales.Location = new System.Drawing.Point(12, 86);
            this.lblSucursales.Name = "lblSucursales";
            this.lblSucursales.Size = new System.Drawing.Size(112, 13);
            this.lblSucursales.TabIndex = 1;
            this.lblSucursales.Text = "Sucursales existentes:";
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
            this.btnAceptarAgregar,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(749, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregarSucursal
            // 
            this.btnAgregarSucursal.Image = global::FUMIT.Recursos.add;
            this.btnAgregarSucursal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarSucursal.Name = "btnAgregarSucursal";
            this.btnAgregarSucursal.Size = new System.Drawing.Size(69, 22);
            this.btnAgregarSucursal.Text = "Agregar";
            this.btnAgregarSucursal.Click += new System.EventHandler(this.btnAgregarSucursal_Click);
            // 
            // btnEditarSucursal
            // 
            this.btnEditarSucursal.Image = global::FUMIT.Recursos.edit_add;
            this.btnEditarSucursal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarSucursal.Name = "btnEditarSucursal";
            this.btnEditarSucursal.Size = new System.Drawing.Size(57, 22);
            this.btnEditarSucursal.Text = "Editar";
            this.btnEditarSucursal.Click += new System.EventHandler(this.btnEditarSucursal_Click);
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.Enabled = false;
            this.btnCancelarEdicion.Image = global::FUMIT.Recursos.cancel;
            this.btnCancelarEdicion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(73, 22);
            this.btnCancelarEdicion.Text = "Cancelar";
            this.btnCancelarEdicion.Visible = false;
            this.btnCancelarEdicion.Click += new System.EventHandler(this.btnCancelarEdicion_Click);
            // 
            // btnAceptarAgregar
            // 
            this.btnAceptarAgregar.Enabled = false;
            this.btnAceptarAgregar.Image = global::FUMIT.Recursos.check1;
            this.btnAceptarAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAceptarAgregar.Name = "btnAceptarAgregar";
            this.btnAceptarAgregar.Size = new System.Drawing.Size(68, 22);
            this.btnAceptarAgregar.Text = "Aceptar";
            this.btnAceptarAgregar.Visible = false;
            this.btnAceptarAgregar.Click += new System.EventHandler(this.btnAceptarAgregar_Click);
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(12, 58);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(47, 13);
            this.lblSucursal.TabIndex = 10;
            this.lblSucursal.Text = "Nombre:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(66, 34);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 20);
            this.txtNombre.TabIndex = 12;
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
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Image = global::FUMIT.Recursos.search;
            this.btnBuscarNombre.Location = new System.Drawing.Point(282, 56);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(29, 23);
            this.btnBuscarNombre.TabIndex = 14;
            this.btnBuscarNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ciudad:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(482, 37);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 17;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(539, 34);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(198, 20);
            this.txtDireccion.TabIndex = 19;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(372, 35);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 20;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Location = new System.Drawing.Point(372, 58);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 21;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Enabled = false;
            this.chkActivo.Location = new System.Drawing.Point(485, 62);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 22;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Registro N°:";
            // 
            // lblIdSucursal
            // 
            this.lblIdSucursal.AutoSize = true;
            this.lblIdSucursal.Location = new System.Drawing.Point(714, 66);
            this.lblIdSucursal.Name = "lblIdSucursal";
            this.lblIdSucursal.Size = new System.Drawing.Size(13, 13);
            this.lblIdSucursal.TabIndex = 24;
            this.lblIdSucursal.Text = "0";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::FUMIT.Recursos.delete;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton1.Text = "Eliminar";
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 277);
            this.Controls.Add(this.lblIdSucursal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.btnBuscarNumero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregarSucursal;
        private System.Windows.Forms.ToolStripButton btnEditarSucursal;
        private System.Windows.Forms.ToolStripButton btnCancelarEdicion;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscarNumero;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.ToolStripButton btnAceptarAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucursalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
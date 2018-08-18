namespace FUMIT.Formularios.Catalogos
{
    partial class Servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios));
            this.GrdServicios = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblServicios = new System.Windows.Forms.Label();
            this.chckServicios = new System.Windows.Forms.CheckedListBox();
            this.lblSucursalesServicio = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarServicio = new System.Windows.Forms.ToolStripButton();
            this.btnEditarServicio = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarServicio = new System.Windows.Forms.ToolStripButton();
            this.btnGuardarServicio = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarServicio = new System.Windows.Forms.ToolStripButton();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdServicios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdServicios
            // 
            this.GrdServicios.AllowUserToAddRows = false;
            this.GrdServicios.AllowUserToDeleteRows = false;
            this.GrdServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colDescripcion,
            this.colActivo});
            this.GrdServicios.Location = new System.Drawing.Point(12, 101);
            this.GrdServicios.Name = "GrdServicios";
            this.GrdServicios.ReadOnly = true;
            this.GrdServicios.Size = new System.Drawing.Size(422, 154);
            this.GrdServicios.TabIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 179;
            // 
            // colActivo
            // 
            this.colActivo.HeaderText = "Activo";
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Location = new System.Drawing.Point(12, 85);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(108, 13);
            this.lblServicios.TabIndex = 1;
            this.lblServicios.Text = "Servicios disponibles:";
            // 
            // chckServicios
            // 
            this.chckServicios.FormattingEnabled = true;
            this.chckServicios.Location = new System.Drawing.Point(440, 101);
            this.chckServicios.Name = "chckServicios";
            this.chckServicios.Size = new System.Drawing.Size(194, 154);
            this.chckServicios.TabIndex = 2;
            // 
            // lblSucursalesServicio
            // 
            this.lblSucursalesServicio.AutoSize = true;
            this.lblSucursalesServicio.Location = new System.Drawing.Point(437, 85);
            this.lblSucursalesServicio.Name = "lblSucursalesServicio";
            this.lblSucursalesServicio.Size = new System.Drawing.Size(119, 13);
            this.lblSucursalesServicio.TabIndex = 3;
            this.lblSucursalesServicio.Text = "Sucursales con servicio";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarServicio,
            this.btnEditarServicio,
            this.btnEliminarServicio,
            this.btnGuardarServicio,
            this.btnCancelarServicio});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(646, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarServicio.Image")));
            this.btnAgregarServicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(69, 22);
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // btnEditarServicio
            // 
            this.btnEditarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarServicio.Image")));
            this.btnEditarServicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarServicio.Name = "btnEditarServicio";
            this.btnEditarServicio.Size = new System.Drawing.Size(57, 22);
            this.btnEditarServicio.Text = "Editar";
            this.btnEditarServicio.Click += new System.EventHandler(this.btnEditarServicio_Click);
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.Enabled = false;
            this.btnEliminarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarServicio.Image")));
            this.btnEliminarServicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(70, 22);
            this.btnEliminarServicio.Text = "Eliminar";
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // btnGuardarServicio
            // 
            this.btnGuardarServicio.Enabled = false;
            this.btnGuardarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarServicio.Image")));
            this.btnGuardarServicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardarServicio.Name = "btnGuardarServicio";
            this.btnGuardarServicio.Size = new System.Drawing.Size(69, 22);
            this.btnGuardarServicio.Text = "Guardar";
            this.btnGuardarServicio.Visible = false;
            this.btnGuardarServicio.Click += new System.EventHandler(this.btnGuardarServicio_Click);
            // 
            // btnCancelarServicio
            // 
            this.btnCancelarServicio.Enabled = false;
            this.btnCancelarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarServicio.Image")));
            this.btnCancelarServicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarServicio.Name = "btnCancelarServicio";
            this.btnCancelarServicio.Size = new System.Drawing.Size(73, 22);
            this.btnCancelarServicio.Text = "Cancelar";
            this.btnCancelarServicio.Visible = false;
            this.btnCancelarServicio.Click += new System.EventHandler(this.btnCancelarServicio_Click);
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Image = global::FUMIT.Recursos.search;
            this.btnBuscarNombre.Location = new System.Drawing.Point(300, 25);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(29, 23);
            this.btnBuscarNombre.TabIndex = 17;
            this.btnBuscarNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(84, 55);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(210, 20);
            this.txtDescripcion.TabIndex = 19;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 58);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Enabled = false;
            this.chkActivo.Location = new System.Drawing.Point(300, 58);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 23;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 262);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblSucursalesServicio);
            this.Controls.Add(this.chckServicios);
            this.Controls.Add(this.lblServicios);
            this.Controls.Add(this.GrdServicios);
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdServicios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdServicios;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.CheckedListBox chckServicios;
        private System.Windows.Forms.Label lblSucursalesServicio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregarServicio;
        private System.Windows.Forms.ToolStripButton btnEditarServicio;
        private System.Windows.Forms.ToolStripButton btnEliminarServicio;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.ToolStripButton btnGuardarServicio;
        private System.Windows.Forms.ToolStripButton btnCancelarServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActivo;
    }
}
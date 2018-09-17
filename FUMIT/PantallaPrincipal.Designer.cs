namespace FUMIT
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programacionDeServiciosSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaDeTicketsDeServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioDeServiciosProgramadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosProgramadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siniestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciclosDeFactuacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisionDeFacturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrementoDeTarifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifasDeServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeSiniestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEntregaDeTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbSucursalActiva = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.operacionToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.tsbSucursalActiva});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuPrincipal.Size = new System.Drawing.Size(800, 27);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sucursalesToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.equipoToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.catálogosToolStripMenuItem.Text = "Catálo&gos";
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sucursalesToolStripMenuItem.Text = "S&ucursales";
            this.sucursalesToolStripMenuItem.Click += new System.EventHandler(this.sucursalesToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.serviciosToolStripMenuItem.Text = "&Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.equipoToolStripMenuItem.Text = "&Equipo";
            this.equipoToolStripMenuItem.Click += new System.EventHandler(this.equipoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expedientesToolStripMenuItem,
            this.contratosToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            // 
            // expedientesToolStripMenuItem
            // 
            this.expedientesToolStripMenuItem.Name = "expedientesToolStripMenuItem";
            this.expedientesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.expedientesToolStripMenuItem.Text = "&Expedientes";
            this.expedientesToolStripMenuItem.ToolTipText = "Expendientes";
            this.expedientesToolStripMenuItem.Click += new System.EventHandler(this.ExpedientesToolStripMenuItem_Click);
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.contratosToolStripMenuItem.Text = "&Contratos";
            this.contratosToolStripMenuItem.Visible = false;
            // 
            // operacionToolStripMenuItem
            // 
            this.operacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programacionDeServiciosSucursalToolStripMenuItem,
            this.capturaDeTicketsDeServicioToolStripMenuItem,
            this.calendarioDeServiciosProgramadosToolStripMenuItem,
            this.serviciosProgramadosToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.siniestrosToolStripMenuItem});
            this.operacionToolStripMenuItem.Name = "operacionToolStripMenuItem";
            this.operacionToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.operacionToolStripMenuItem.Text = "&Operacion";
            // 
            // programacionDeServiciosSucursalToolStripMenuItem
            // 
            this.programacionDeServiciosSucursalToolStripMenuItem.Name = "programacionDeServiciosSucursalToolStripMenuItem";
            this.programacionDeServiciosSucursalToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.programacionDeServiciosSucursalToolStripMenuItem.Text = "Programacion de servicios sucursal";
            this.programacionDeServiciosSucursalToolStripMenuItem.Click += new System.EventHandler(this.programacionDeServiciosSucursalToolStripMenuItem_Click);
            // 
            // capturaDeTicketsDeServicioToolStripMenuItem
            // 
            this.capturaDeTicketsDeServicioToolStripMenuItem.Name = "capturaDeTicketsDeServicioToolStripMenuItem";
            this.capturaDeTicketsDeServicioToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.capturaDeTicketsDeServicioToolStripMenuItem.Text = "Captura de tickets de servicio";
            this.capturaDeTicketsDeServicioToolStripMenuItem.Click += new System.EventHandler(this.capturaDeTicketsDeServicioToolStripMenuItem_Click);
            // 
            // calendarioDeServiciosProgramadosToolStripMenuItem
            // 
            this.calendarioDeServiciosProgramadosToolStripMenuItem.Name = "calendarioDeServiciosProgramadosToolStripMenuItem";
            this.calendarioDeServiciosProgramadosToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.calendarioDeServiciosProgramadosToolStripMenuItem.Text = "Ca&lendario de servicios programados";
            this.calendarioDeServiciosProgramadosToolStripMenuItem.Click += new System.EventHandler(this.calendarioDeServiciosProgramadosToolStripMenuItem_Click);
            // 
            // serviciosProgramadosToolStripMenuItem
            // 
            this.serviciosProgramadosToolStripMenuItem.Name = "serviciosProgramadosToolStripMenuItem";
            this.serviciosProgramadosToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.serviciosProgramadosToolStripMenuItem.Text = "Servicios programados";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            this.mantenimientosToolStripMenuItem.Visible = false;
            // 
            // siniestrosToolStripMenuItem
            // 
            this.siniestrosToolStripMenuItem.Name = "siniestrosToolStripMenuItem";
            this.siniestrosToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.siniestrosToolStripMenuItem.Text = "Siniestros";
            this.siniestrosToolStripMenuItem.Visible = false;
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciclosDeFactuacionToolStripMenuItem,
            this.revisionDeFacturacionToolStripMenuItem,
            this.incrementoDeTarifasToolStripMenuItem,
            this.tarifasDeServicioToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // ciclosDeFactuacionToolStripMenuItem
            // 
            this.ciclosDeFactuacionToolStripMenuItem.Name = "ciclosDeFactuacionToolStripMenuItem";
            this.ciclosDeFactuacionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ciclosDeFactuacionToolStripMenuItem.Text = "Ciclos de facturacion";
            this.ciclosDeFactuacionToolStripMenuItem.Click += new System.EventHandler(this.ciclosDeFactuacionToolStripMenuItem_Click);
            // 
            // revisionDeFacturacionToolStripMenuItem
            // 
            this.revisionDeFacturacionToolStripMenuItem.Name = "revisionDeFacturacionToolStripMenuItem";
            this.revisionDeFacturacionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.revisionDeFacturacionToolStripMenuItem.Text = "Revision de facturacion";
            this.revisionDeFacturacionToolStripMenuItem.Visible = false;
            // 
            // incrementoDeTarifasToolStripMenuItem
            // 
            this.incrementoDeTarifasToolStripMenuItem.Name = "incrementoDeTarifasToolStripMenuItem";
            this.incrementoDeTarifasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.incrementoDeTarifasToolStripMenuItem.Text = "Incremento de tarifas";
            this.incrementoDeTarifasToolStripMenuItem.Visible = false;
            // 
            // tarifasDeServicioToolStripMenuItem
            // 
            this.tarifasDeServicioToolStripMenuItem.Name = "tarifasDeServicioToolStripMenuItem";
            this.tarifasDeServicioToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.tarifasDeServicioToolStripMenuItem.Text = "Tarifas de servicio";
            this.tarifasDeServicioToolStripMenuItem.Visible = false;
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeVentasToolStripMenuItem,
            this.reporteDeSiniestrosToolStripMenuItem,
            this.reporteDeMantenimientoToolStripMenuItem,
            this.reporteDeEntregaDeTicketsToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Visible = false;
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de ventas";
            // 
            // reporteDeSiniestrosToolStripMenuItem
            // 
            this.reporteDeSiniestrosToolStripMenuItem.Name = "reporteDeSiniestrosToolStripMenuItem";
            this.reporteDeSiniestrosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.reporteDeSiniestrosToolStripMenuItem.Text = "Reporte de siniestros";
            // 
            // reporteDeMantenimientoToolStripMenuItem
            // 
            this.reporteDeMantenimientoToolStripMenuItem.Name = "reporteDeMantenimientoToolStripMenuItem";
            this.reporteDeMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.reporteDeMantenimientoToolStripMenuItem.Text = "Reporte de mantenimiento";
            // 
            // reporteDeEntregaDeTicketsToolStripMenuItem
            // 
            this.reporteDeEntregaDeTicketsToolStripMenuItem.Name = "reporteDeEntregaDeTicketsToolStripMenuItem";
            this.reporteDeEntregaDeTicketsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.reporteDeEntregaDeTicketsToolStripMenuItem.Text = "Reporte de entrega de tickets";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // tsbSucursalActiva
            // 
            this.tsbSucursalActiva.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSucursalActiva.Name = "tsbSucursalActiva";
            this.tsbSucursalActiva.Size = new System.Drawing.Size(121, 23);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsbEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tsbEstado
            // 
            this.tsbEstado.AutoSize = false;
            this.tsbEstado.Name = "tsbEstado";
            this.tsbEstado.Size = new System.Drawing.Size(640, 17);
            this.tsbEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "PantallaPrincipal";
            this.Text = "Control de operaciones FUMIT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expedientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programacionDeServiciosSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciclosDeFactuacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturaDeTicketsDeServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioDeServiciosProgramadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosProgramadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siniestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisionDeFacturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incrementoDeTarifasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifasDeServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeSiniestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeMantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEntregaDeTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripComboBox tsbSucursalActiva;
        internal System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel tsbEstado;
    }
}


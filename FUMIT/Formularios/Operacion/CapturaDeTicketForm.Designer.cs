namespace FUMIT.Formularios.Operacion
{
    partial class CapturaDeTicketForm
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
            this.ticketsUC1 = new FUMIT.Formularios.Operacion.TicketsUC();
            this.SuspendLayout();
            // 
            // ticketsUC1
            // 
            this.ticketsUC1.CatalogoClientes = null;
            this.ticketsUC1.CatalogoEquipos = null;
            this.ticketsUC1.CatalogoOperadores = null;
            this.ticketsUC1.CatalogoServicios = null;
            this.ticketsUC1.ClientesRepositorio = null;
            this.ticketsUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketsUC1.EquiposRepositorio = null;
            this.ticketsUC1.FormExceptionManager = null;
            this.ticketsUC1.Location = new System.Drawing.Point(0, 0);
            this.ticketsUC1.ModoEdicion = false;
            this.ticketsUC1.Name = "ticketsUC1";
            this.ticketsUC1.Notificador = null;
            this.ticketsUC1.OperadoresRepositorio = null;
            this.ticketsUC1.ServiciosRepositorio = null;
            this.ticketsUC1.Size = new System.Drawing.Size(539, 502);
            this.ticketsUC1.SucursalesRepositorio = null;
            this.ticketsUC1.TabIndex = 0;
            this.ticketsUC1.TicketsRepositorio = null;
            this.ticketsUC1.TiposEquiposRepositorio = null;
            // 
            // CapturaDeTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 502);
            this.Controls.Add(this.ticketsUC1);
            this.Name = "CapturaDeTicketForm";
            this.Text = "Captura de tickets de servicio";
            this.Load += new System.EventHandler(this.CapturaDeTicketForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal TicketsUC ticketsUC1;
    }
}
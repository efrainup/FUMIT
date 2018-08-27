namespace FUMIT.Formularios.Operacion
{
    partial class EditarServicio
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
            this.serviciosProgramadosUC = new FUMIT.Formularios.Operacion.ServiciosProgramados();
            this.SuspendLayout();
            // 
            // serviciosProgramadosUC
            // 
            this.serviciosProgramadosUC.ClienteId = 0;
            this.serviciosProgramadosUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviciosProgramadosUC.Location = new System.Drawing.Point(0, 0);
            this.serviciosProgramadosUC.ModoEditar = false;
            this.serviciosProgramadosUC.Name = "serviciosProgramadosUC";
            this.serviciosProgramadosUC.Repositorio = null;
            this.serviciosProgramadosUC.Size = new System.Drawing.Size(550, 418);
            this.serviciosProgramadosUC.TabIndex = 0;
            // 
            // EditarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 418);
            this.Controls.Add(this.serviciosProgramadosUC);
            this.Name = "EditarServicio";
            this.Text = "Servicio";
            this.ResumeLayout(false);

        }

        #endregion

        internal ServiciosProgramados serviciosProgramadosUC;
    }
}
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
            this.serviciosProgramados1 = new FUMIT.Formularios.Operacion.ServiciosProgramados();
            this.SuspendLayout();
            // 
            // serviciosProgramados1
            // 
            this.serviciosProgramados1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviciosProgramados1.Location = new System.Drawing.Point(0, 0);
            this.serviciosProgramados1.Name = "serviciosProgramados1";
            this.serviciosProgramados1.Size = new System.Drawing.Size(550, 418);
            this.serviciosProgramados1.TabIndex = 0;
            // 
            // EditarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 418);
            this.Controls.Add(this.serviciosProgramados1);
            this.Name = "EditarServicio";
            this.Text = "Servicio";
            this.ResumeLayout(false);

        }

        #endregion

        private ServiciosProgramados serviciosProgramados1;
    }
}
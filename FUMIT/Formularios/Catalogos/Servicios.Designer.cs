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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblServicios = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblSucursalesServicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colDescripcion,
            this.colActivo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            // 
            // colActivo
            // 
            this.colActivo.HeaderText = "Activo";
            this.colActivo.Name = "colActivo";
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Location = new System.Drawing.Point(12, 13);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(108, 13);
            this.lblServicios.TabIndex = 1;
            this.lblServicios.Text = "Servicios disponibles:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(440, 29);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(194, 154);
            this.checkedListBox1.TabIndex = 2;
            // 
            // lblSucursalesServicio
            // 
            this.lblSucursalesServicio.AutoSize = true;
            this.lblSucursalesServicio.Location = new System.Drawing.Point(437, 13);
            this.lblSucursalesServicio.Name = "lblSucursalesServicio";
            this.lblSucursalesServicio.Size = new System.Drawing.Size(119, 13);
            this.lblSucursalesServicio.TabIndex = 3;
            this.lblSucursalesServicio.Text = "Sucursales con servicio";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 262);
            this.Controls.Add(this.lblSucursalesServicio);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblServicios);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Servicios";
            this.Text = "Servicios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActivo;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblSucursalesServicio;
    }
}
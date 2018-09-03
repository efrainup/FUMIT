namespace FUMIT.Formularios.Operacion
{
    partial class MantenimientoEquipoUC
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoEquipoUC));
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label borradoLabel;
            System.Windows.Forms.Label fechaEntradaMantenimientoLabel;
            System.Windows.Forms.Label fechaProgramadaLabel;
            System.Windows.Forms.Label fechaSalidaMantenimientoLabel;
            System.Windows.Forms.Label mantenimientoIdLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label realizadoLabel;
            this.mantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimientoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.mantenimientoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.borradoCheckBox = new System.Windows.Forms.CheckBox();
            this.fechaEntradaMantenimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaProgramadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaSalidaMantenimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mantenimientoIdTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.realizadoCheckBox = new System.Windows.Forms.CheckBox();
            activoLabel = new System.Windows.Forms.Label();
            borradoLabel = new System.Windows.Forms.Label();
            fechaEntradaMantenimientoLabel = new System.Windows.Forms.Label();
            fechaProgramadaLabel = new System.Windows.Forms.Label();
            fechaSalidaMantenimientoLabel = new System.Windows.Forms.Label();
            mantenimientoIdLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            realizadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingNavigator)).BeginInit();
            this.mantenimientoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mantenimientoBindingSource
            // 
            this.mantenimientoBindingSource.DataSource = typeof(FUMIT.Entidades.Mantenimiento);
            // 
            // mantenimientoBindingNavigator
            // 
            this.mantenimientoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mantenimientoBindingNavigator.BindingSource = this.mantenimientoBindingSource;
            this.mantenimientoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mantenimientoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mantenimientoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mantenimientoBindingNavigatorSaveItem});
            this.mantenimientoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mantenimientoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mantenimientoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mantenimientoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mantenimientoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mantenimientoBindingNavigator.Name = "mantenimientoBindingNavigator";
            this.mantenimientoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mantenimientoBindingNavigator.Size = new System.Drawing.Size(593, 25);
            this.mantenimientoBindingNavigator.TabIndex = 0;
            this.mantenimientoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // mantenimientoBindingNavigatorSaveItem
            // 
            this.mantenimientoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mantenimientoBindingNavigatorSaveItem.Enabled = false;
            this.mantenimientoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoBindingNavigatorSaveItem.Image")));
            this.mantenimientoBindingNavigatorSaveItem.Name = "mantenimientoBindingNavigatorSaveItem";
            this.mantenimientoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mantenimientoBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(63, 430);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mantenimientoBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(221, 425);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.Text = "checkBox1";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // borradoLabel
            // 
            borradoLabel.AutoSize = true;
            borradoLabel.Location = new System.Drawing.Point(63, 460);
            borradoLabel.Name = "borradoLabel";
            borradoLabel.Size = new System.Drawing.Size(47, 13);
            borradoLabel.TabIndex = 3;
            borradoLabel.Text = "Borrado:";
            // 
            // borradoCheckBox
            // 
            this.borradoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mantenimientoBindingSource, "Borrado", true));
            this.borradoCheckBox.Location = new System.Drawing.Point(221, 455);
            this.borradoCheckBox.Name = "borradoCheckBox";
            this.borradoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.borradoCheckBox.TabIndex = 4;
            this.borradoCheckBox.Text = "checkBox1";
            this.borradoCheckBox.UseVisualStyleBackColor = true;
            // 
            // fechaEntradaMantenimientoLabel
            // 
            fechaEntradaMantenimientoLabel.AutoSize = true;
            fechaEntradaMantenimientoLabel.Location = new System.Drawing.Point(63, 173);
            fechaEntradaMantenimientoLabel.Name = "fechaEntradaMantenimientoLabel";
            fechaEntradaMantenimientoLabel.Size = new System.Drawing.Size(152, 13);
            fechaEntradaMantenimientoLabel.TabIndex = 5;
            fechaEntradaMantenimientoLabel.Text = "Fecha Entrada Mantenimiento:";
            // 
            // fechaEntradaMantenimientoDateTimePicker
            // 
            this.fechaEntradaMantenimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mantenimientoBindingSource, "FechaEntradaMantenimiento", true));
            this.fechaEntradaMantenimientoDateTimePicker.Location = new System.Drawing.Point(221, 169);
            this.fechaEntradaMantenimientoDateTimePicker.Name = "fechaEntradaMantenimientoDateTimePicker";
            this.fechaEntradaMantenimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaEntradaMantenimientoDateTimePicker.TabIndex = 6;
            // 
            // fechaProgramadaLabel
            // 
            fechaProgramadaLabel.AutoSize = true;
            fechaProgramadaLabel.Location = new System.Drawing.Point(63, 199);
            fechaProgramadaLabel.Name = "fechaProgramadaLabel";
            fechaProgramadaLabel.Size = new System.Drawing.Size(100, 13);
            fechaProgramadaLabel.TabIndex = 7;
            fechaProgramadaLabel.Text = "Fecha Programada:";
            // 
            // fechaProgramadaDateTimePicker
            // 
            this.fechaProgramadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mantenimientoBindingSource, "FechaProgramada", true));
            this.fechaProgramadaDateTimePicker.Location = new System.Drawing.Point(221, 195);
            this.fechaProgramadaDateTimePicker.Name = "fechaProgramadaDateTimePicker";
            this.fechaProgramadaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaProgramadaDateTimePicker.TabIndex = 8;
            // 
            // fechaSalidaMantenimientoLabel
            // 
            fechaSalidaMantenimientoLabel.AutoSize = true;
            fechaSalidaMantenimientoLabel.Location = new System.Drawing.Point(63, 225);
            fechaSalidaMantenimientoLabel.Name = "fechaSalidaMantenimientoLabel";
            fechaSalidaMantenimientoLabel.Size = new System.Drawing.Size(144, 13);
            fechaSalidaMantenimientoLabel.TabIndex = 9;
            fechaSalidaMantenimientoLabel.Text = "Fecha Salida Mantenimiento:";
            // 
            // fechaSalidaMantenimientoDateTimePicker
            // 
            this.fechaSalidaMantenimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mantenimientoBindingSource, "FechaSalidaMantenimiento", true));
            this.fechaSalidaMantenimientoDateTimePicker.Location = new System.Drawing.Point(221, 221);
            this.fechaSalidaMantenimientoDateTimePicker.Name = "fechaSalidaMantenimientoDateTimePicker";
            this.fechaSalidaMantenimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaSalidaMantenimientoDateTimePicker.TabIndex = 10;
            // 
            // mantenimientoIdLabel
            // 
            mantenimientoIdLabel.AutoSize = true;
            mantenimientoIdLabel.Location = new System.Drawing.Point(63, 250);
            mantenimientoIdLabel.Name = "mantenimientoIdLabel";
            mantenimientoIdLabel.Size = new System.Drawing.Size(91, 13);
            mantenimientoIdLabel.TabIndex = 11;
            mantenimientoIdLabel.Text = "Mantenimiento Id:";
            // 
            // mantenimientoIdTextBox
            // 
            this.mantenimientoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "MantenimientoId", true));
            this.mantenimientoIdTextBox.Location = new System.Drawing.Point(221, 247);
            this.mantenimientoIdTextBox.Name = "mantenimientoIdTextBox";
            this.mantenimientoIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.mantenimientoIdTextBox.TabIndex = 12;
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(63, 276);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 13;
            observacionesLabel.Text = "Observaciones:";
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "Observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(221, 273);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.Size = new System.Drawing.Size(330, 116);
            this.observacionesTextBox.TabIndex = 14;
            // 
            // realizadoLabel
            // 
            realizadoLabel.AutoSize = true;
            realizadoLabel.Location = new System.Drawing.Point(63, 400);
            realizadoLabel.Name = "realizadoLabel";
            realizadoLabel.Size = new System.Drawing.Size(57, 13);
            realizadoLabel.TabIndex = 15;
            realizadoLabel.Text = "Realizado:";
            // 
            // realizadoCheckBox
            // 
            this.realizadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mantenimientoBindingSource, "Realizado", true));
            this.realizadoCheckBox.Location = new System.Drawing.Point(221, 395);
            this.realizadoCheckBox.Name = "realizadoCheckBox";
            this.realizadoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.realizadoCheckBox.TabIndex = 16;
            this.realizadoCheckBox.Text = "checkBox1";
            this.realizadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // MantenimientoEquipoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(borradoLabel);
            this.Controls.Add(this.borradoCheckBox);
            this.Controls.Add(fechaEntradaMantenimientoLabel);
            this.Controls.Add(this.fechaEntradaMantenimientoDateTimePicker);
            this.Controls.Add(fechaProgramadaLabel);
            this.Controls.Add(this.fechaProgramadaDateTimePicker);
            this.Controls.Add(fechaSalidaMantenimientoLabel);
            this.Controls.Add(this.fechaSalidaMantenimientoDateTimePicker);
            this.Controls.Add(mantenimientoIdLabel);
            this.Controls.Add(this.mantenimientoIdTextBox);
            this.Controls.Add(observacionesLabel);
            this.Controls.Add(this.observacionesTextBox);
            this.Controls.Add(realizadoLabel);
            this.Controls.Add(this.realizadoCheckBox);
            this.Controls.Add(this.mantenimientoBindingNavigator);
            this.Name = "MantenimientoEquipoUC";
            this.Size = new System.Drawing.Size(593, 508);
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingNavigator)).EndInit();
            this.mantenimientoBindingNavigator.ResumeLayout(false);
            this.mantenimientoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mantenimientoBindingSource;
        private System.Windows.Forms.BindingNavigator mantenimientoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mantenimientoBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.CheckBox borradoCheckBox;
        private System.Windows.Forms.DateTimePicker fechaEntradaMantenimientoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaProgramadaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaSalidaMantenimientoDateTimePicker;
        private System.Windows.Forms.TextBox mantenimientoIdTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.CheckBox realizadoCheckBox;
    }
}

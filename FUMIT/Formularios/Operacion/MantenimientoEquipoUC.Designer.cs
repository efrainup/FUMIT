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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label fechaEntradaMantenimientoLabel;
            System.Windows.Forms.Label fechaProgramadaLabel;
            System.Windows.Forms.Label fechaSalidaMantenimientoLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label realizadoLabel;
            System.Windows.Forms.Label numeroEconomicoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoEquipoUC));
            this.mantenimientoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.mantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.mantenimientoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.fechaEntradaMantenimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaProgramadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaSalidaMantenimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.realizadoCheckBox = new System.Windows.Forms.CheckBox();
            this.mantenimientosEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroEconomicoTextBox = new System.Windows.Forms.TextBox();
            activoLabel = new System.Windows.Forms.Label();
            fechaEntradaMantenimientoLabel = new System.Windows.Forms.Label();
            fechaProgramadaLabel = new System.Windows.Forms.Label();
            fechaSalidaMantenimientoLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            realizadoLabel = new System.Windows.Forms.Label();
            numeroEconomicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingNavigator)).BeginInit();
            this.mantenimientoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientosEquipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(21, 310);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // fechaEntradaMantenimientoLabel
            // 
            fechaEntradaMantenimientoLabel.AutoSize = true;
            fechaEntradaMantenimientoLabel.Location = new System.Drawing.Point(21, 79);
            fechaEntradaMantenimientoLabel.Name = "fechaEntradaMantenimientoLabel";
            fechaEntradaMantenimientoLabel.Size = new System.Drawing.Size(152, 13);
            fechaEntradaMantenimientoLabel.TabIndex = 5;
            fechaEntradaMantenimientoLabel.Text = "Fecha Entrada Mantenimiento:";
            // 
            // fechaProgramadaLabel
            // 
            fechaProgramadaLabel.AutoSize = true;
            fechaProgramadaLabel.Location = new System.Drawing.Point(21, 105);
            fechaProgramadaLabel.Name = "fechaProgramadaLabel";
            fechaProgramadaLabel.Size = new System.Drawing.Size(100, 13);
            fechaProgramadaLabel.TabIndex = 7;
            fechaProgramadaLabel.Text = "Fecha Programada:";
            // 
            // fechaSalidaMantenimientoLabel
            // 
            fechaSalidaMantenimientoLabel.AutoSize = true;
            fechaSalidaMantenimientoLabel.Location = new System.Drawing.Point(21, 131);
            fechaSalidaMantenimientoLabel.Name = "fechaSalidaMantenimientoLabel";
            fechaSalidaMantenimientoLabel.Size = new System.Drawing.Size(144, 13);
            fechaSalidaMantenimientoLabel.TabIndex = 9;
            fechaSalidaMantenimientoLabel.Text = "Fecha Salida Mantenimiento:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(21, 156);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 13;
            observacionesLabel.Text = "Observaciones:";
            // 
            // realizadoLabel
            // 
            realizadoLabel.AutoSize = true;
            realizadoLabel.Location = new System.Drawing.Point(21, 280);
            realizadoLabel.Name = "realizadoLabel";
            realizadoLabel.Size = new System.Drawing.Size(57, 13);
            realizadoLabel.TabIndex = 15;
            realizadoLabel.Text = "Realizado:";
            // 
            // numeroEconomicoLabel
            // 
            numeroEconomicoLabel.AutoSize = true;
            numeroEconomicoLabel.Location = new System.Drawing.Point(21, 46);
            numeroEconomicoLabel.Name = "numeroEconomicoLabel";
            numeroEconomicoLabel.Size = new System.Drawing.Size(103, 13);
            numeroEconomicoLabel.TabIndex = 16;
            numeroEconomicoLabel.Text = "Numero Economico:";
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
            this.tsbEditar,
            this.bindingNavigatorDeleteItem,
            this.mantenimientoBindingNavigatorSaveItem,
            this.tsbCancelar});
            this.mantenimientoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mantenimientoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mantenimientoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mantenimientoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mantenimientoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mantenimientoBindingNavigator.Name = "mantenimientoBindingNavigator";
            this.mantenimientoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mantenimientoBindingNavigator.Size = new System.Drawing.Size(630, 25);
            this.mantenimientoBindingNavigator.TabIndex = 0;
            this.mantenimientoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::FUMIT.Recursos.add;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(69, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // mantenimientoBindingSource
            // 
            this.mantenimientoBindingSource.DataSource = typeof(FUMIT.Entidades.Mantenimiento);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(70, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::FUMIT.Recursos.edit_add;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(57, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // mantenimientoBindingNavigatorSaveItem
            // 
            this.mantenimientoBindingNavigatorSaveItem.Enabled = false;
            this.mantenimientoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoBindingNavigatorSaveItem.Image")));
            this.mantenimientoBindingNavigatorSaveItem.Name = "mantenimientoBindingNavigatorSaveItem";
            this.mantenimientoBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.mantenimientoBindingNavigatorSaveItem.Text = "Guardar";
            this.mantenimientoBindingNavigatorSaveItem.Click += new System.EventHandler(this.mantenimientoBindingNavigatorSaveItem_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Enabled = false;
            this.tsbCancelar.Image = global::FUMIT.Recursos.cancel;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Visible = false;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mantenimientoBindingSource, "Activo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(179, 305);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // fechaEntradaMantenimientoDateTimePicker
            // 
            this.fechaEntradaMantenimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mantenimientoBindingSource, "FechaEntradaMantenimiento", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaEntradaMantenimientoDateTimePicker.Enabled = false;
            this.fechaEntradaMantenimientoDateTimePicker.Location = new System.Drawing.Point(179, 75);
            this.fechaEntradaMantenimientoDateTimePicker.Name = "fechaEntradaMantenimientoDateTimePicker";
            this.fechaEntradaMantenimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaEntradaMantenimientoDateTimePicker.TabIndex = 6;
            // 
            // fechaProgramadaDateTimePicker
            // 
            this.fechaProgramadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mantenimientoBindingSource, "FechaProgramada", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaProgramadaDateTimePicker.Enabled = false;
            this.fechaProgramadaDateTimePicker.Location = new System.Drawing.Point(179, 101);
            this.fechaProgramadaDateTimePicker.Name = "fechaProgramadaDateTimePicker";
            this.fechaProgramadaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaProgramadaDateTimePicker.TabIndex = 8;
            // 
            // fechaSalidaMantenimientoDateTimePicker
            // 
            this.fechaSalidaMantenimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mantenimientoBindingSource, "FechaSalidaMantenimiento", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaSalidaMantenimientoDateTimePicker.Enabled = false;
            this.fechaSalidaMantenimientoDateTimePicker.Location = new System.Drawing.Point(179, 127);
            this.fechaSalidaMantenimientoDateTimePicker.Name = "fechaSalidaMantenimientoDateTimePicker";
            this.fechaSalidaMantenimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaSalidaMantenimientoDateTimePicker.TabIndex = 10;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientoBindingSource, "Observaciones", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.observacionesTextBox.Location = new System.Drawing.Point(179, 153);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ReadOnly = true;
            this.observacionesTextBox.Size = new System.Drawing.Size(330, 116);
            this.observacionesTextBox.TabIndex = 14;
            // 
            // realizadoCheckBox
            // 
            this.realizadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mantenimientoBindingSource, "Realizado", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.realizadoCheckBox.Enabled = false;
            this.realizadoCheckBox.Location = new System.Drawing.Point(179, 275);
            this.realizadoCheckBox.Name = "realizadoCheckBox";
            this.realizadoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.realizadoCheckBox.TabIndex = 16;
            this.realizadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // mantenimientosEquipoBindingSource
            // 
            this.mantenimientosEquipoBindingSource.DataSource = typeof(FUMIT.Entidades.MantenimientosEquipo);
            // 
            // numeroEconomicoTextBox
            // 
            this.numeroEconomicoTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.numeroEconomicoTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.numeroEconomicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mantenimientosEquipoBindingSource, "Equipo.NumeroEconomico", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numeroEconomicoTextBox.Location = new System.Drawing.Point(179, 43);
            this.numeroEconomicoTextBox.Name = "numeroEconomicoTextBox";
            this.numeroEconomicoTextBox.ReadOnly = true;
            this.numeroEconomicoTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeroEconomicoTextBox.TabIndex = 17;
            this.numeroEconomicoTextBox.Validated += new System.EventHandler(this.numeroEconomicoTextBox_Validated);
            // 
            // MantenimientoEquipoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(numeroEconomicoLabel);
            this.Controls.Add(this.numeroEconomicoTextBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(fechaEntradaMantenimientoLabel);
            this.Controls.Add(this.fechaEntradaMantenimientoDateTimePicker);
            this.Controls.Add(fechaProgramadaLabel);
            this.Controls.Add(this.fechaProgramadaDateTimePicker);
            this.Controls.Add(fechaSalidaMantenimientoLabel);
            this.Controls.Add(this.fechaSalidaMantenimientoDateTimePicker);
            this.Controls.Add(observacionesLabel);
            this.Controls.Add(this.observacionesTextBox);
            this.Controls.Add(realizadoLabel);
            this.Controls.Add(this.realizadoCheckBox);
            this.Controls.Add(this.mantenimientoBindingNavigator);
            this.Name = "MantenimientoEquipoUC";
            this.Size = new System.Drawing.Size(630, 508);
            this.Load += new System.EventHandler(this.MantenimientoEquipoUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingNavigator)).EndInit();
            this.mantenimientoBindingNavigator.ResumeLayout(false);
            this.mantenimientoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientosEquipoBindingSource)).EndInit();
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
        private System.Windows.Forms.DateTimePicker fechaEntradaMantenimientoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaProgramadaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaSalidaMantenimientoDateTimePicker;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.CheckBox realizadoCheckBox;
        private System.Windows.Forms.BindingSource mantenimientosEquipoBindingSource;
        private System.Windows.Forms.TextBox numeroEconomicoTextBox;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
    }
}

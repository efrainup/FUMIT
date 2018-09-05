namespace FUMIT.Formularios.Clientes
{
    partial class AsignacionEquipos
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
            System.Windows.Forms.Label fechaAsignaciónLabel;
            System.Windows.Forms.Label fechaEntregaLabel;
            System.Windows.Forms.Label fechaRegresoLabel;
            System.Windows.Forms.Label numeroEconomicoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignacionEquipos));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaRegresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.asignacionesequipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaEntregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numeroEconomicoTextBox = new System.Windows.Forms.TextBox();
            this.fechaAsignaciónDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.asignacionesequipoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.asignacionesequipoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            fechaAsignaciónLabel = new System.Windows.Forms.Label();
            fechaEntregaLabel = new System.Windows.Forms.Label();
            fechaRegresoLabel = new System.Windows.Forms.Label();
            numeroEconomicoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionesequipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionesequipoBindingNavigator)).BeginInit();
            this.asignacionesequipoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechaAsignaciónLabel
            // 
            fechaAsignaciónLabel.AutoSize = true;
            fechaAsignaciónLabel.Location = new System.Drawing.Point(13, 49);
            fechaAsignaciónLabel.Name = "fechaAsignaciónLabel";
            fechaAsignaciónLabel.Size = new System.Drawing.Size(95, 13);
            fechaAsignaciónLabel.TabIndex = 6;
            fechaAsignaciónLabel.Text = "Fecha Asignación:";
            // 
            // fechaEntregaLabel
            // 
            fechaEntregaLabel.AutoSize = true;
            fechaEntregaLabel.Location = new System.Drawing.Point(13, 75);
            fechaEntregaLabel.Name = "fechaEntregaLabel";
            fechaEntregaLabel.Size = new System.Drawing.Size(80, 13);
            fechaEntregaLabel.TabIndex = 8;
            fechaEntregaLabel.Text = "Fecha Entrega:";
            // 
            // fechaRegresoLabel
            // 
            fechaRegresoLabel.AutoSize = true;
            fechaRegresoLabel.Location = new System.Drawing.Point(13, 101);
            fechaRegresoLabel.Name = "fechaRegresoLabel";
            fechaRegresoLabel.Size = new System.Drawing.Size(83, 13);
            fechaRegresoLabel.TabIndex = 10;
            fechaRegresoLabel.Text = "Fecha Regreso:";
            // 
            // numeroEconomicoLabel
            // 
            numeroEconomicoLabel.AutoSize = true;
            numeroEconomicoLabel.Location = new System.Drawing.Point(13, 22);
            numeroEconomicoLabel.Name = "numeroEconomicoLabel";
            numeroEconomicoLabel.Size = new System.Drawing.Size(103, 13);
            numeroEconomicoLabel.TabIndex = 14;
            numeroEconomicoLabel.Text = "Numero Economico:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 610);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(numeroEconomicoLabel);
            this.groupBox1.Controls.Add(this.fechaRegresoDateTimePicker);
            this.groupBox1.Controls.Add(fechaRegresoLabel);
            this.groupBox1.Controls.Add(this.fechaEntregaDateTimePicker);
            this.groupBox1.Controls.Add(this.numeroEconomicoTextBox);
            this.groupBox1.Controls.Add(fechaEntregaLabel);
            this.groupBox1.Controls.Add(this.fechaAsignaciónDateTimePicker);
            this.groupBox1.Controls.Add(fechaAsignaciónLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 277);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de asignación";
            // 
            // fechaRegresoDateTimePicker
            // 
            this.fechaRegresoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.asignacionesequipoBindingSource, "FechaRegreso", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaRegresoDateTimePicker.Enabled = false;
            this.fechaRegresoDateTimePicker.Location = new System.Drawing.Point(144, 97);
            this.fechaRegresoDateTimePicker.Name = "fechaRegresoDateTimePicker";
            this.fechaRegresoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaRegresoDateTimePicker.TabIndex = 11;
            // 
            // asignacionesequipoBindingSource
            // 
            this.asignacionesequipoBindingSource.DataSource = typeof(FUMIT.Entidades.Asignacionesequipo);
            // 
            // fechaEntregaDateTimePicker
            // 
            this.fechaEntregaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.asignacionesequipoBindingSource, "FechaEntrega", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaEntregaDateTimePicker.Enabled = false;
            this.fechaEntregaDateTimePicker.Location = new System.Drawing.Point(144, 71);
            this.fechaEntregaDateTimePicker.Name = "fechaEntregaDateTimePicker";
            this.fechaEntregaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaEntregaDateTimePicker.TabIndex = 9;
            // 
            // numeroEconomicoTextBox
            // 
            this.numeroEconomicoTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.numeroEconomicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asignacionesequipoBindingSource, "Equipo.NumeroEconomico", true));
            this.numeroEconomicoTextBox.Location = new System.Drawing.Point(144, 19);
            this.numeroEconomicoTextBox.Name = "numeroEconomicoTextBox";
            this.numeroEconomicoTextBox.ReadOnly = true;
            this.numeroEconomicoTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeroEconomicoTextBox.TabIndex = 15;
            this.numeroEconomicoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numeroEconomicoTextBox_Validating);
            // 
            // fechaAsignaciónDateTimePicker
            // 
            this.fechaAsignaciónDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.asignacionesequipoBindingSource, "FechaAsignación", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaAsignaciónDateTimePicker.Enabled = false;
            this.fechaAsignaciónDateTimePicker.Location = new System.Drawing.Point(144, 45);
            this.fechaAsignaciónDateTimePicker.Name = "fechaAsignaciónDateTimePicker";
            this.fechaAsignaciónDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaAsignaciónDateTimePicker.TabIndex = 7;
            // 
            // asignacionesequipoBindingNavigator
            // 
            this.asignacionesequipoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.asignacionesequipoBindingNavigator.BindingSource = this.asignacionesequipoBindingSource;
            this.asignacionesequipoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.asignacionesequipoBindingNavigator.DeleteItem = null;
            this.asignacionesequipoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tsbEditar,
            this.asignacionesequipoBindingNavigatorSaveItem,
            this.tsbCancelar});
            this.asignacionesequipoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.asignacionesequipoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.asignacionesequipoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.asignacionesequipoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.asignacionesequipoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.asignacionesequipoBindingNavigator.Name = "asignacionesequipoBindingNavigator";
            this.asignacionesequipoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.asignacionesequipoBindingNavigator.Size = new System.Drawing.Size(824, 25);
            this.asignacionesequipoBindingNavigator.TabIndex = 1;
            this.asignacionesequipoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(70, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // asignacionesequipoBindingNavigatorSaveItem
            // 
            this.asignacionesequipoBindingNavigatorSaveItem.Enabled = false;
            this.asignacionesequipoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("asignacionesequipoBindingNavigatorSaveItem.Image")));
            this.asignacionesequipoBindingNavigatorSaveItem.Name = "asignacionesequipoBindingNavigatorSaveItem";
            this.asignacionesequipoBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.asignacionesequipoBindingNavigatorSaveItem.Text = "Guardar";
            this.asignacionesequipoBindingNavigatorSaveItem.Click += new System.EventHandler(this.asignacionesequipoBindingNavigatorSaveItem_Click);
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
            // AsignacionEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.asignacionesequipoBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AsignacionEquipos";
            this.Size = new System.Drawing.Size(824, 610);
            this.Load += new System.EventHandler(this.AsignacionEquipos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionesequipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionesequipoBindingNavigator)).EndInit();
            this.asignacionesequipoBindingNavigator.ResumeLayout(false);
            this.asignacionesequipoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker fechaRegresoDateTimePicker;
        private System.Windows.Forms.BindingSource asignacionesequipoBindingSource;
        private System.Windows.Forms.DateTimePicker fechaEntregaDateTimePicker;
        private System.Windows.Forms.TextBox numeroEconomicoTextBox;
        private System.Windows.Forms.DateTimePicker fechaAsignaciónDateTimePicker;
        private System.Windows.Forms.BindingNavigator asignacionesequipoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton asignacionesequipoBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
    }
}

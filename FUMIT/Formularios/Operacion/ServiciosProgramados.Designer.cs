namespace FUMIT.Formularios.Operacion
{
    partial class ServiciosProgramados
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
            System.Windows.Forms.Label canceladoLabel;
            System.Windows.Forms.Label fechaServicioLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label prioridadLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label nombreClienteLabel;
            System.Windows.Forms.Label sucursalClienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiciosProgramados));
            this.serviciosprogramadoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.serviciosprogramadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.serviciosprogramadoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.canceladoCheckBox = new System.Windows.Forms.CheckBox();
            this.fechaServicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.prioridadTextBox = new System.Windows.Forms.TextBox();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.sucursalClienteTextBox = new System.Windows.Forms.TextBox();
            this.TipoServicioComboBox = new System.Windows.Forms.ComboBox();
            this.btnBusquedaSucursal = new System.Windows.Forms.Button();
            activoLabel = new System.Windows.Forms.Label();
            canceladoLabel = new System.Windows.Forms.Label();
            fechaServicioLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            prioridadLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            nombreClienteLabel = new System.Windows.Forms.Label();
            sucursalClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosprogramadoBindingNavigator)).BeginInit();
            this.serviciosprogramadoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosprogramadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(21, 186);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // canceladoLabel
            // 
            canceladoLabel.AutoSize = true;
            canceladoLabel.Location = new System.Drawing.Point(21, 216);
            canceladoLabel.Name = "canceladoLabel";
            canceladoLabel.Size = new System.Drawing.Size(61, 13);
            canceladoLabel.TabIndex = 3;
            canceladoLabel.Text = "Cancelado:";
            // 
            // fechaServicioLabel
            // 
            fechaServicioLabel.AutoSize = true;
            fechaServicioLabel.Location = new System.Drawing.Point(21, 101);
            fechaServicioLabel.Name = "fechaServicioLabel";
            fechaServicioLabel.Size = new System.Drawing.Size(81, 13);
            fechaServicioLabel.TabIndex = 5;
            fechaServicioLabel.Text = "Fecha Servicio:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(21, 244);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 7;
            observacionesLabel.Text = "Observaciones:";
            // 
            // prioridadLabel
            // 
            prioridadLabel.AutoSize = true;
            prioridadLabel.Location = new System.Drawing.Point(21, 126);
            prioridadLabel.Name = "prioridadLabel";
            prioridadLabel.Size = new System.Drawing.Size(51, 13);
            prioridadLabel.TabIndex = 9;
            prioridadLabel.Text = "Prioridad:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(21, 152);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 11;
            tipoLabel.Text = "Tipo:";
            // 
            // nombreClienteLabel
            // 
            nombreClienteLabel.AutoSize = true;
            nombreClienteLabel.Location = new System.Drawing.Point(21, 48);
            nombreClienteLabel.Name = "nombreClienteLabel";
            nombreClienteLabel.Size = new System.Drawing.Size(42, 13);
            nombreClienteLabel.TabIndex = 13;
            nombreClienteLabel.Text = "Cliente:";
            // 
            // sucursalClienteLabel
            // 
            sucursalClienteLabel.AutoSize = true;
            sucursalClienteLabel.Location = new System.Drawing.Point(21, 74);
            sucursalClienteLabel.Name = "sucursalClienteLabel";
            sucursalClienteLabel.Size = new System.Drawing.Size(51, 13);
            sucursalClienteLabel.TabIndex = 15;
            sucursalClienteLabel.Text = "Sucursal:";
            // 
            // serviciosprogramadoBindingNavigator
            // 
            this.serviciosprogramadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.serviciosprogramadoBindingNavigator.BindingSource = this.serviciosprogramadoBindingSource;
            this.serviciosprogramadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.serviciosprogramadoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.serviciosprogramadoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.serviciosprogramadoBindingNavigatorSaveItem,
            this.tsbCancelar});
            this.serviciosprogramadoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.serviciosprogramadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.serviciosprogramadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.serviciosprogramadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.serviciosprogramadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.serviciosprogramadoBindingNavigator.Name = "serviciosprogramadoBindingNavigator";
            this.serviciosprogramadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.serviciosprogramadoBindingNavigator.Size = new System.Drawing.Size(604, 25);
            this.serviciosprogramadoBindingNavigator.TabIndex = 0;
            this.serviciosprogramadoBindingNavigator.Text = "bindingNavigator1";
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
            // serviciosprogramadoBindingSource
            // 
            this.serviciosprogramadoBindingSource.DataSource = typeof(FUMIT.Entidades.Serviciosprogramado);
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
            // serviciosprogramadoBindingNavigatorSaveItem
            // 
            this.serviciosprogramadoBindingNavigatorSaveItem.Enabled = false;
            this.serviciosprogramadoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("serviciosprogramadoBindingNavigatorSaveItem.Image")));
            this.serviciosprogramadoBindingNavigatorSaveItem.Name = "serviciosprogramadoBindingNavigatorSaveItem";
            this.serviciosprogramadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.serviciosprogramadoBindingNavigatorSaveItem.Text = "Guardar";
            this.serviciosprogramadoBindingNavigatorSaveItem.Click += new System.EventHandler(this.serviciosprogramadoBindingNavigatorSaveItem_Click);
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
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.serviciosprogramadoBindingSource, "Activo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(113, 181);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox.TabIndex = 6;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // canceladoCheckBox
            // 
            this.canceladoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.serviciosprogramadoBindingSource, "Cancelado", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.canceladoCheckBox.Enabled = false;
            this.canceladoCheckBox.Location = new System.Drawing.Point(113, 211);
            this.canceladoCheckBox.Name = "canceladoCheckBox";
            this.canceladoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.canceladoCheckBox.TabIndex = 7;
            this.canceladoCheckBox.UseVisualStyleBackColor = true;
            // 
            // fechaServicioDateTimePicker
            // 
            this.fechaServicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.serviciosprogramadoBindingSource, "FechaServicio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaServicioDateTimePicker.Enabled = false;
            this.fechaServicioDateTimePicker.Location = new System.Drawing.Point(113, 97);
            this.fechaServicioDateTimePicker.Name = "fechaServicioDateTimePicker";
            this.fechaServicioDateTimePicker.Size = new System.Drawing.Size(215, 20);
            this.fechaServicioDateTimePicker.TabIndex = 3;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviciosprogramadoBindingSource, "Observaciones", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.observacionesTextBox.Location = new System.Drawing.Point(113, 241);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ReadOnly = true;
            this.observacionesTextBox.Size = new System.Drawing.Size(363, 133);
            this.observacionesTextBox.TabIndex = 8;
            // 
            // prioridadTextBox
            // 
            this.prioridadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviciosprogramadoBindingSource, "Prioridad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.prioridadTextBox.Location = new System.Drawing.Point(113, 123);
            this.prioridadTextBox.Name = "prioridadTextBox";
            this.prioridadTextBox.ReadOnly = true;
            this.prioridadTextBox.Size = new System.Drawing.Size(200, 20);
            this.prioridadTextBox.TabIndex = 4;
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviciosprogramadoBindingSource, "Clientes.Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nombreClienteTextBox.Location = new System.Drawing.Point(113, 45);
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.ReadOnly = true;
            this.nombreClienteTextBox.Size = new System.Drawing.Size(363, 20);
            this.nombreClienteTextBox.TabIndex = 1;
            // 
            // sucursalClienteTextBox
            // 
            this.sucursalClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviciosprogramadoBindingSource, "Clientes.SucursalCliente", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sucursalClienteTextBox.Location = new System.Drawing.Point(113, 71);
            this.sucursalClienteTextBox.Name = "sucursalClienteTextBox";
            this.sucursalClienteTextBox.ReadOnly = true;
            this.sucursalClienteTextBox.Size = new System.Drawing.Size(363, 20);
            this.sucursalClienteTextBox.TabIndex = 2;
            // 
            // TipoServicioComboBox
            // 
            this.TipoServicioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviciosprogramadoBindingSource, "Tipo", true));
            this.TipoServicioComboBox.Enabled = false;
            this.TipoServicioComboBox.FormattingEnabled = true;
            this.TipoServicioComboBox.Items.AddRange(new object[] {
            "Programado",
            "Express"});
            this.TipoServicioComboBox.Location = new System.Drawing.Point(113, 154);
            this.TipoServicioComboBox.Name = "TipoServicioComboBox";
            this.TipoServicioComboBox.Size = new System.Drawing.Size(200, 21);
            this.TipoServicioComboBox.TabIndex = 5;
            // 
            // btnBusquedaSucursal
            // 
            this.btnBusquedaSucursal.Enabled = false;
            this.btnBusquedaSucursal.Image = global::FUMIT.Recursos.search;
            this.btnBusquedaSucursal.Location = new System.Drawing.Point(482, 43);
            this.btnBusquedaSucursal.Name = "btnBusquedaSucursal";
            this.btnBusquedaSucursal.Size = new System.Drawing.Size(31, 23);
            this.btnBusquedaSucursal.TabIndex = 16;
            this.btnBusquedaSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusquedaSucursal.UseVisualStyleBackColor = true;
            // 
            // ServiciosProgramados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBusquedaSucursal);
            this.Controls.Add(this.TipoServicioComboBox);
            this.Controls.Add(nombreClienteLabel);
            this.Controls.Add(this.nombreClienteTextBox);
            this.Controls.Add(sucursalClienteLabel);
            this.Controls.Add(this.sucursalClienteTextBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(canceladoLabel);
            this.Controls.Add(this.canceladoCheckBox);
            this.Controls.Add(fechaServicioLabel);
            this.Controls.Add(this.fechaServicioDateTimePicker);
            this.Controls.Add(observacionesLabel);
            this.Controls.Add(this.observacionesTextBox);
            this.Controls.Add(prioridadLabel);
            this.Controls.Add(this.prioridadTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.serviciosprogramadoBindingNavigator);
            this.Name = "ServiciosProgramados";
            this.Size = new System.Drawing.Size(604, 406);
            this.Load += new System.EventHandler(this.ServiciosProgramados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviciosprogramadoBindingNavigator)).EndInit();
            this.serviciosprogramadoBindingNavigator.ResumeLayout(false);
            this.serviciosprogramadoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosprogramadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator serviciosprogramadoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton serviciosprogramadoBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.CheckBox canceladoCheckBox;
        private System.Windows.Forms.DateTimePicker fechaServicioDateTimePicker;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.TextBox prioridadTextBox;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.TextBox sucursalClienteTextBox;
        private System.Windows.Forms.ComboBox TipoServicioComboBox;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        internal System.Windows.Forms.BindingSource serviciosprogramadoBindingSource;
        private System.Windows.Forms.Button btnBusquedaSucursal;
    }
}

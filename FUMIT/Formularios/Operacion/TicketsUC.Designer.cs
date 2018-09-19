namespace FUMIT.Formularios.Operacion
{
    partial class TicketsUC
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label folioLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label unidadLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label horaEntradaLabel;
            System.Windows.Forms.Label horasalidaLabel;
            System.Windows.Forms.Label servicioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsUC));
            this.ticketBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ticketBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.folioTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.unidadTextBox = new System.Windows.Forms.TextBox();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.operadorTextBox = new System.Windows.Forms.TextBox();
            this.horaEntradaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.horaSalidaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedorTextBox = new System.Windows.Forms.TextBox();
            this.LevantesLabel = new System.Windows.Forms.Label();
            this.levantesUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contenedoresticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contenedoresDataGrid = new System.Windows.Forms.DataGridView();
            this.Contenedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Levantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgregarContenedorButton = new System.Windows.Forms.Button();
            this.eliminarContenedorButton = new System.Windows.Forms.Button();
            this.servicioTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            fechaLabel = new System.Windows.Forms.Label();
            folioLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            unidadLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            horaEntradaLabel = new System.Windows.Forms.Label();
            horasalidaLabel = new System.Windows.Forms.Label();
            servicioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingNavigator)).BeginInit();
            this.ticketBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levantesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenedoresticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenedoresDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(220, 58);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // folioLabel
            // 
            folioLabel.AutoSize = true;
            folioLabel.Location = new System.Drawing.Point(220, 31);
            folioLabel.Name = "folioLabel";
            folioLabel.Size = new System.Drawing.Size(32, 13);
            folioLabel.TabIndex = 7;
            folioLabel.Text = "Folio:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(21, 360);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 15;
            observacionesLabel.Text = "Observaciones:";
            // 
            // unidadLabel
            // 
            unidadLabel.AutoSize = true;
            unidadLabel.Location = new System.Drawing.Point(21, 308);
            unidadLabel.Name = "unidadLabel";
            unidadLabel.Size = new System.Drawing.Size(44, 13);
            unidadLabel.TabIndex = 21;
            unidadLabel.Text = "Unidad:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            nombreLabel.Location = new System.Drawing.Point(21, 101);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(42, 13);
            nombreLabel.TabIndex = 23;
            nombreLabel.Text = "Cliente:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Location = new System.Drawing.Point(21, 334);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(54, 13);
            nombreLabel1.TabIndex = 24;
            nombreLabel1.Text = "Operador:";
            // 
            // horaEntradaLabel
            // 
            horaEntradaLabel.AutoSize = true;
            horaEntradaLabel.Location = new System.Drawing.Point(21, 443);
            horaEntradaLabel.Name = "horaEntradaLabel";
            horaEntradaLabel.Size = new System.Drawing.Size(73, 13);
            horaEntradaLabel.TabIndex = 25;
            horaEntradaLabel.Text = "Hora Entrada:";
            // 
            // horasalidaLabel
            // 
            horasalidaLabel.AutoSize = true;
            horasalidaLabel.Location = new System.Drawing.Point(230, 443);
            horasalidaLabel.Name = "horasalidaLabel";
            horasalidaLabel.Size = new System.Drawing.Size(65, 13);
            horasalidaLabel.TabIndex = 26;
            horasalidaLabel.Text = "Hora Salida:";
            // 
            // servicioLabel
            // 
            servicioLabel.AutoSize = true;
            servicioLabel.Location = new System.Drawing.Point(336, 104);
            servicioLabel.Name = "servicioLabel";
            servicioLabel.Size = new System.Drawing.Size(48, 13);
            servicioLabel.TabIndex = 37;
            servicioLabel.Text = "Servicio:";
            // 
            // ticketBindingNavigator
            // 
            this.ticketBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ticketBindingNavigator.BindingSource = this.ticketBindingSource;
            this.ticketBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ticketBindingNavigator.DeleteItem = null;
            this.ticketBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ticketBindingNavigatorSaveItem,
            this.tsbCancelar});
            this.ticketBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ticketBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ticketBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ticketBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ticketBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ticketBindingNavigator.Name = "ticketBindingNavigator";
            this.ticketBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ticketBindingNavigator.Size = new System.Drawing.Size(584, 25);
            this.ticketBindingNavigator.TabIndex = 0;
            this.ticketBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::FUMIT.Recursos.add;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(69, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar";
            this.bindingNavigatorAddNewItem.ToolTipText = "Agregar (Ctrl+N)";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(FUMIT.Entidades.Ticket);
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
            // tsbEditar
            // 
            this.tsbEditar.Image = global::FUMIT.Recursos.edit_add;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(57, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.ToolTipText = "Editar (F2)";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(70, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.ToolTipText = "Eliminar (Supr)";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // ticketBindingNavigatorSaveItem
            // 
            this.ticketBindingNavigatorSaveItem.Enabled = false;
            this.ticketBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ticketBindingNavigatorSaveItem.Image")));
            this.ticketBindingNavigatorSaveItem.Name = "ticketBindingNavigatorSaveItem";
            this.ticketBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.ticketBindingNavigatorSaveItem.Text = "Guardar";
            this.ticketBindingNavigatorSaveItem.ToolTipText = "Guardar (Ctrl+G)";
            this.ticketBindingNavigatorSaveItem.Click += new System.EventHandler(this.ticketBindingNavigatorSaveItem_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Enabled = false;
            this.tsbCancelar.Image = global::FUMIT.Recursos.cancel;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.ToolTipText = "Cancelar (Esc)";
            this.tsbCancelar.Visible = false;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ticketBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Enabled = false;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(319, 54);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 2;
            this.fechaDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.fechaDateTimePicker_Validating);
            // 
            // folioTextBox
            // 
            this.folioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "Folio", true));
            this.folioTextBox.Location = new System.Drawing.Point(319, 28);
            this.folioTextBox.Name = "folioTextBox";
            this.folioTextBox.ReadOnly = true;
            this.folioTextBox.Size = new System.Drawing.Size(200, 20);
            this.folioTextBox.TabIndex = 1;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "Observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(108, 357);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ReadOnly = true;
            this.observacionesTextBox.Size = new System.Drawing.Size(293, 76);
            this.observacionesTextBox.TabIndex = 10;
            // 
            // unidadTextBox
            // 
            this.unidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "Unidad", true));
            this.unidadTextBox.Location = new System.Drawing.Point(108, 305);
            this.unidadTextBox.Name = "unidadTextBox";
            this.unidadTextBox.ReadOnly = true;
            this.unidadTextBox.Size = new System.Drawing.Size(200, 20);
            this.unidadTextBox.TabIndex = 8;
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.clienteTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "Clientes.Nombre", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.clienteTextBox.Location = new System.Drawing.Point(108, 101);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.ReadOnly = true;
            this.clienteTextBox.Size = new System.Drawing.Size(212, 20);
            this.clienteTextBox.TabIndex = 3;
            this.clienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.clienteTextBox_Validating);
            // 
            // operadorTextBox
            // 
            this.operadorTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.operadorTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.operadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "Operador.Nombre", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.operadorTextBox.Location = new System.Drawing.Point(108, 331);
            this.operadorTextBox.Name = "operadorTextBox";
            this.operadorTextBox.ReadOnly = true;
            this.operadorTextBox.Size = new System.Drawing.Size(200, 20);
            this.operadorTextBox.TabIndex = 9;
            this.operadorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.operadorTextBox_Validating);
            // 
            // horaEntradaMaskedTextBox
            // 
            this.horaEntradaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "HoraEntrada", true));
            this.horaEntradaMaskedTextBox.Location = new System.Drawing.Point(108, 439);
            this.horaEntradaMaskedTextBox.Mask = "00:00";
            this.horaEntradaMaskedTextBox.Name = "horaEntradaMaskedTextBox";
            this.horaEntradaMaskedTextBox.ReadOnly = true;
            this.horaEntradaMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.horaEntradaMaskedTextBox.TabIndex = 1;
            this.horaEntradaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // horaSalidaMaskedTextBox
            // 
            this.horaSalidaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "Horasalida", true));
            this.horaSalidaMaskedTextBox.Location = new System.Drawing.Point(301, 439);
            this.horaSalidaMaskedTextBox.Mask = "00:00";
            this.horaSalidaMaskedTextBox.Name = "horaSalidaMaskedTextBox";
            this.horaSalidaMaskedTextBox.ReadOnly = true;
            this.horaSalidaMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.horaSalidaMaskedTextBox.TabIndex = 12;
            this.horaSalidaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Contenedor #:";
            // 
            // contenedorTextBox
            // 
            this.contenedorTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.contenedorTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.contenedorTextBox.Location = new System.Drawing.Point(108, 145);
            this.contenedorTextBox.Name = "contenedorTextBox";
            this.contenedorTextBox.ReadOnly = true;
            this.contenedorTextBox.Size = new System.Drawing.Size(100, 20);
            this.contenedorTextBox.TabIndex = 5;
            this.contenedorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.contenedorTextBox_Validating);
            // 
            // LevantesLabel
            // 
            this.LevantesLabel.AutoSize = true;
            this.LevantesLabel.Location = new System.Drawing.Point(224, 148);
            this.LevantesLabel.Name = "LevantesLabel";
            this.LevantesLabel.Size = new System.Drawing.Size(54, 13);
            this.LevantesLabel.TabIndex = 32;
            this.LevantesLabel.Text = "Levantes:";
            // 
            // levantesUpDown
            // 
            this.levantesUpDown.Location = new System.Drawing.Point(285, 146);
            this.levantesUpDown.Name = "levantesUpDown";
            this.levantesUpDown.ReadOnly = true;
            this.levantesUpDown.Size = new System.Drawing.Size(120, 20);
            this.levantesUpDown.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FUMIT.Recursos.SmallLogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 45);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // contenedoresticketsBindingSource
            // 
            this.contenedoresticketsBindingSource.DataMember = "Contenedorestickets";
            this.contenedoresticketsBindingSource.DataSource = this.ticketBindingSource;
            // 
            // contenedoresDataGrid
            // 
            this.contenedoresDataGrid.AllowUserToAddRows = false;
            this.contenedoresDataGrid.AllowUserToDeleteRows = false;
            this.contenedoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contenedoresDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Contenedor,
            this.Levantes});
            this.contenedoresDataGrid.Location = new System.Drawing.Point(24, 185);
            this.contenedoresDataGrid.Name = "contenedoresDataGrid";
            this.contenedoresDataGrid.ReadOnly = true;
            this.contenedoresDataGrid.Size = new System.Drawing.Size(381, 101);
            this.contenedoresDataGrid.TabIndex = 35;
            this.contenedoresDataGrid.Validating += new System.ComponentModel.CancelEventHandler(this.contenedoresDataGrid_Validating);
            // 
            // Contenedor
            // 
            this.Contenedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contenedor.HeaderText = "Contenedor";
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.ReadOnly = true;
            // 
            // Levantes
            // 
            this.Levantes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Levantes.HeaderText = "Levantes";
            this.Levantes.Name = "Levantes";
            this.Levantes.ReadOnly = true;
            // 
            // AgregarContenedorButton
            // 
            this.AgregarContenedorButton.Image = global::FUMIT.Recursos.add;
            this.AgregarContenedorButton.Location = new System.Drawing.Point(411, 143);
            this.AgregarContenedorButton.Name = "AgregarContenedorButton";
            this.AgregarContenedorButton.Size = new System.Drawing.Size(29, 23);
            this.AgregarContenedorButton.TabIndex = 7;
            this.AgregarContenedorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarContenedorButton.UseVisualStyleBackColor = true;
            this.AgregarContenedorButton.Click += new System.EventHandler(this.AgregarContenedorButton_Click);
            // 
            // eliminarContenedorButton
            // 
            this.eliminarContenedorButton.Image = global::FUMIT.Recursos.delete;
            this.eliminarContenedorButton.Location = new System.Drawing.Point(412, 185);
            this.eliminarContenedorButton.Name = "eliminarContenedorButton";
            this.eliminarContenedorButton.Size = new System.Drawing.Size(28, 23);
            this.eliminarContenedorButton.TabIndex = 37;
            this.eliminarContenedorButton.TabStop = false;
            this.eliminarContenedorButton.UseVisualStyleBackColor = true;
            this.eliminarContenedorButton.Visible = false;
            this.eliminarContenedorButton.Click += new System.EventHandler(this.eliminarContenedorButton_Click);
            // 
            // servicioTextBox
            // 
            this.servicioTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.servicioTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.servicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "Servicio.Nombre", true));
            this.servicioTextBox.Location = new System.Drawing.Point(411, 101);
            this.servicioTextBox.Name = "servicioTextBox";
            this.servicioTextBox.ReadOnly = true;
            this.servicioTextBox.Size = new System.Drawing.Size(108, 20);
            this.servicioTextBox.TabIndex = 4;
            this.servicioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.servicioTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(servicioLabel);
            this.Controls.Add(this.servicioTextBox);
            this.Controls.Add(this.eliminarContenedorButton);
            this.Controls.Add(this.AgregarContenedorButton);
            this.Controls.Add(this.contenedoresDataGrid);
            this.Controls.Add(this.levantesUpDown);
            this.Controls.Add(this.LevantesLabel);
            this.Controls.Add(this.contenedorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.horaSalidaMaskedTextBox);
            this.Controls.Add(this.horaEntradaMaskedTextBox);
            this.Controls.Add(horasalidaLabel);
            this.Controls.Add(horaEntradaLabel);
            this.Controls.Add(nombreLabel1);
            this.Controls.Add(this.operadorTextBox);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.folioTextBox);
            this.Controls.Add(folioLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(observacionesLabel);
            this.Controls.Add(this.observacionesTextBox);
            this.Controls.Add(unidadLabel);
            this.Controls.Add(this.unidadTextBox);
            this.Controls.Add(this.ticketBindingNavigator);
            this.Name = "TicketsUC";
            this.Size = new System.Drawing.Size(584, 483);
            this.Load += new System.EventHandler(this.TicketsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingNavigator)).EndInit();
            this.ticketBindingNavigator.ResumeLayout(false);
            this.ticketBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levantesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenedoresticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenedoresDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.BindingNavigator ticketBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ticketBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox folioTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.TextBox unidadTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox operadorTextBox;
        private System.Windows.Forms.MaskedTextBox horaEntradaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox horaSalidaMaskedTextBox;
        private System.Windows.Forms.BindingSource contenedoresticketsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contenedorTextBox;
        private System.Windows.Forms.Label LevantesLabel;
        private System.Windows.Forms.NumericUpDown levantesUpDown;
        private System.Windows.Forms.DataGridView contenedoresDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contenedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Levantes;
        private System.Windows.Forms.Button AgregarContenedorButton;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.Button eliminarContenedorButton;
        private System.Windows.Forms.TextBox servicioTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

namespace FUMIT.Formularios.Clientes
{
    partial class ProgramacionServiciosClientes
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label areaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramacionServiciosClientes));
            this.programacionserviciosclienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.programacionserviciosclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.programacionserviciosclienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.btnBusquedaServicio = new System.Windows.Forms.Button();
            this.servicioTextBox = new System.Windows.Forms.TextBox();
            this.btnProgramarServicios = new System.Windows.Forms.Button();
            this.btnBusquedaHorario = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vsprogramacionserviciosclienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreHorarioProgramado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vsprogramacionserviciosclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            activoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.programacionserviciosclienteBindingNavigator)).BeginInit();
            this.programacionserviciosclienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programacionserviciosclienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsprogramacionserviciosclienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsprogramacionserviciosclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(9, 89);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 2;
            activoLabel.Text = "Activo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(9, 31);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(44, 13);
            nombreLabel.TabIndex = 18;
            nombreLabel.Text = "Horario:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Location = new System.Drawing.Point(9, 60);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(48, 13);
            nombreLabel1.TabIndex = 43;
            nombreLabel1.Text = "Servicio:";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new System.Drawing.Point(439, 31);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(32, 13);
            areaLabel.TabIndex = 44;
            areaLabel.Text = "Area:";
            // 
            // programacionserviciosclienteBindingNavigator
            // 
            this.programacionserviciosclienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.programacionserviciosclienteBindingNavigator.BindingSource = this.programacionserviciosclienteBindingSource;
            this.programacionserviciosclienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.programacionserviciosclienteBindingNavigator.DeleteItem = null;
            this.programacionserviciosclienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.programacionserviciosclienteBindingNavigatorSaveItem,
            this.tsbCancelar});
            this.programacionserviciosclienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.programacionserviciosclienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.programacionserviciosclienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.programacionserviciosclienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.programacionserviciosclienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.programacionserviciosclienteBindingNavigator.Name = "programacionserviciosclienteBindingNavigator";
            this.programacionserviciosclienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.programacionserviciosclienteBindingNavigator.Size = new System.Drawing.Size(854, 25);
            this.programacionserviciosclienteBindingNavigator.TabIndex = 0;
            this.programacionserviciosclienteBindingNavigator.Text = "bindingNavigator1";
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
            // programacionserviciosclienteBindingSource
            // 
            this.programacionserviciosclienteBindingSource.DataSource = typeof(FUMIT.Entidades.Programacionservicioscliente);
            this.programacionserviciosclienteBindingSource.CurrentItemChanged += new System.EventHandler(this.programacionserviciosclienteBindingSource_CurrentItemChanged);
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
            // programacionserviciosclienteBindingNavigatorSaveItem
            // 
            this.programacionserviciosclienteBindingNavigatorSaveItem.Enabled = false;
            this.programacionserviciosclienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("programacionserviciosclienteBindingNavigatorSaveItem.Image")));
            this.programacionserviciosclienteBindingNavigatorSaveItem.Name = "programacionserviciosclienteBindingNavigatorSaveItem";
            this.programacionserviciosclienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.programacionserviciosclienteBindingNavigatorSaveItem.Text = "Guardar";
            this.programacionserviciosclienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.programacionserviciosclienteBindingNavigatorSaveItem_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Enabled = false;
            this.tsbCancelar.Image = global::FUMIT.Recursos.cancel;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(73, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.programacionserviciosclienteBindingSource, "Activo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.activoCheckBox.Location = new System.Drawing.Point(62, 85);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(137, 24);
            this.activoCheckBox.TabIndex = 5;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programacionserviciosclienteBindingSource, "Programacionservicio.Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nombreTextBox.Location = new System.Drawing.Point(62, 28);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(291, 20);
            this.nombreTextBox.TabIndex = 19;
            this.nombreTextBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(areaLabel);
            this.groupBox1.Controls.Add(this.areaTextBox);
            this.groupBox1.Controls.Add(this.btnBusquedaServicio);
            this.groupBox1.Controls.Add(nombreLabel1);
            this.groupBox1.Controls.Add(this.servicioTextBox);
            this.groupBox1.Controls.Add(this.btnProgramarServicios);
            this.groupBox1.Controls.Add(this.btnBusquedaHorario);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(activoLabel);
            this.groupBox1.Controls.Add(this.activoCheckBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 188);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programacion de servicio";
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programacionserviciosclienteBindingSource, "Area", true));
            this.areaTextBox.Location = new System.Drawing.Point(477, 28);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.ReadOnly = true;
            this.areaTextBox.Size = new System.Drawing.Size(276, 20);
            this.areaTextBox.TabIndex = 45;
            // 
            // btnBusquedaServicio
            // 
            this.btnBusquedaServicio.Enabled = false;
            this.btnBusquedaServicio.Image = global::FUMIT.Recursos.search;
            this.btnBusquedaServicio.Location = new System.Drawing.Point(359, 54);
            this.btnBusquedaServicio.Name = "btnBusquedaServicio";
            this.btnBusquedaServicio.Size = new System.Drawing.Size(31, 23);
            this.btnBusquedaServicio.TabIndex = 4;
            this.btnBusquedaServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusquedaServicio.UseVisualStyleBackColor = true;
            this.btnBusquedaServicio.Click += new System.EventHandler(this.btnBusquedaServicio_Click);
            // 
            // servicioTextBox
            // 
            this.servicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programacionserviciosclienteBindingSource, "Servicio.Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.servicioTextBox.Location = new System.Drawing.Point(62, 57);
            this.servicioTextBox.Name = "servicioTextBox";
            this.servicioTextBox.ReadOnly = true;
            this.servicioTextBox.Size = new System.Drawing.Size(291, 20);
            this.servicioTextBox.TabIndex = 44;
            this.servicioTextBox.TabStop = false;
            this.servicioTextBox.TextChanged += new System.EventHandler(this.nombreTextBox1_TextChanged);
            // 
            // btnProgramarServicios
            // 
            this.btnProgramarServicios.Enabled = false;
            this.btnProgramarServicios.Location = new System.Drawing.Point(12, 126);
            this.btnProgramarServicios.Name = "btnProgramarServicios";
            this.btnProgramarServicios.Size = new System.Drawing.Size(142, 23);
            this.btnProgramarServicios.TabIndex = 42;
            this.btnProgramarServicios.Text = "Programar Servicios";
            this.btnProgramarServicios.UseVisualStyleBackColor = true;
            this.btnProgramarServicios.Visible = false;
            this.btnProgramarServicios.Click += new System.EventHandler(this.btnProgramarServicios_Click);
            // 
            // btnBusquedaHorario
            // 
            this.btnBusquedaHorario.Enabled = false;
            this.btnBusquedaHorario.Image = global::FUMIT.Recursos.search;
            this.btnBusquedaHorario.Location = new System.Drawing.Point(359, 26);
            this.btnBusquedaHorario.Name = "btnBusquedaHorario";
            this.btnBusquedaHorario.Size = new System.Drawing.Size(31, 23);
            this.btnBusquedaHorario.TabIndex = 3;
            this.btnBusquedaHorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusquedaHorario.UseVisualStyleBackColor = true;
            this.btnBusquedaHorario.Click += new System.EventHandler(this.btnBusquedaHorario_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.vsprogramacionserviciosclienteDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 409);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // vsprogramacionserviciosclienteDataGridView
            // 
            this.vsprogramacionserviciosclienteDataGridView.AllowUserToAddRows = false;
            this.vsprogramacionserviciosclienteDataGridView.AllowUserToDeleteRows = false;
            this.vsprogramacionserviciosclienteDataGridView.AutoGenerateColumns = false;
            this.vsprogramacionserviciosclienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vsprogramacionserviciosclienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.NombreHorarioProgramado,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.vsprogramacionserviciosclienteDataGridView.DataSource = this.vsprogramacionserviciosclienteBindingSource;
            this.vsprogramacionserviciosclienteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vsprogramacionserviciosclienteDataGridView.Location = new System.Drawing.Point(3, 197);
            this.vsprogramacionserviciosclienteDataGridView.Name = "vsprogramacionserviciosclienteDataGridView";
            this.vsprogramacionserviciosclienteDataGridView.ReadOnly = true;
            this.vsprogramacionserviciosclienteDataGridView.Size = new System.Drawing.Size(848, 188);
            this.vsprogramacionserviciosclienteDataGridView.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn12.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // NombreHorarioProgramado
            // 
            this.NombreHorarioProgramado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NombreHorarioProgramado.DataPropertyName = "NombreHorarioProgramado";
            this.NombreHorarioProgramado.HeaderText = "Horario";
            this.NombreHorarioProgramado.Name = "NombreHorarioProgramado";
            this.NombreHorarioProgramado.ReadOnly = true;
            this.NombreHorarioProgramado.Width = 66;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProgramacionServiciosClienteId";
            this.dataGridViewTextBoxColumn7.HeaderText = "ProgramacionServiciosClienteId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProgramacionServicioId";
            this.dataGridViewTextBoxColumn8.HeaderText = "ProgramacionServicioId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ClienteId";
            this.dataGridViewTextBoxColumn9.HeaderText = "ClienteId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FechaInicio";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fecha Inicio";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 83;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FechaTermino";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fecha Termino";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 95;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Width = 43;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Borrado";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Borrado";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Visible = false;
            // 
            // vsprogramacionserviciosclienteBindingSource
            // 
            this.vsprogramacionserviciosclienteBindingSource.DataSource = typeof(FUMIT.Entidades.Vsprogramacionservicioscliente);
            this.vsprogramacionserviciosclienteBindingSource.CurrentChanged += new System.EventHandler(this.vsprogramacionserviciosclienteBindingSource_CurrentChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // ProgramacionServiciosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.programacionserviciosclienteBindingNavigator);
            this.Name = "ProgramacionServiciosClientes";
            this.Size = new System.Drawing.Size(854, 434);
            this.Load += new System.EventHandler(this.ProgramacionServiciosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programacionserviciosclienteBindingNavigator)).EndInit();
            this.programacionserviciosclienteBindingNavigator.ResumeLayout(false);
            this.programacionserviciosclienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programacionserviciosclienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vsprogramacionserviciosclienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsprogramacionserviciosclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource programacionserviciosclienteBindingSource;
        private System.Windows.Forms.BindingNavigator programacionserviciosclienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton programacionserviciosclienteBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button btnBusquedaHorario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnProgramarServicios;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource vsprogramacionserviciosclienteBindingSource;
        private System.Windows.Forms.DataGridView vsprogramacionserviciosclienteDataGridView;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.TextBox servicioTextBox;
        private System.Windows.Forms.Button btnBusquedaServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreHorarioProgramado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.ToolStripButton tsbEditar;
    }
}

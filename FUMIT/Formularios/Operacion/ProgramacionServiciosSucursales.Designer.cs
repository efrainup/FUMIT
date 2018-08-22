namespace FUMIT.Formularios.Operacion
{
    partial class ProgramacionServiciosSucursales
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mesLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label programacionServicioIdLabel;
            System.Windows.Forms.Label semanaLabel;
            System.Windows.Forms.Label sucursalIdLabel;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label numeroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramacionServiciosSucursales));
            this.programacionservicioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.programacionservicioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.diasTextBox = new System.Windows.Forms.TextBox();
            this.mesTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.programacionServicioIdTextBox = new System.Windows.Forms.TextBox();
            this.semanaTextBox = new System.Windows.Forms.TextBox();
            this.sucursalIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox1 = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkListTipoProgramacion = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkListDiasSemana = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBusquedaSucursal = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.programacionServiciosSucursalesbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programacionservicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mesLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            programacionServicioIdLabel = new System.Windows.Forms.Label();
            semanaLabel = new System.Windows.Forms.Label();
            sucursalIdLabel = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.programacionservicioBindingNavigator)).BeginInit();
            this.programacionservicioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programacionServiciosSucursalesbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programacionservicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mesLabel
            // 
            mesLabel.AutoSize = true;
            mesLabel.Location = new System.Drawing.Point(549, 256);
            mesLabel.Name = "mesLabel";
            mesLabel.Size = new System.Drawing.Size(26, 13);
            mesLabel.TabIndex = 3;
            mesLabel.Text = "mes";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(16, 63);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // programacionServicioIdLabel
            // 
            programacionServicioIdLabel.AutoSize = true;
            programacionServicioIdLabel.Location = new System.Drawing.Point(16, 37);
            programacionServicioIdLabel.Name = "programacionServicioIdLabel";
            programacionServicioIdLabel.Size = new System.Drawing.Size(126, 13);
            programacionServicioIdLabel.TabIndex = 7;
            programacionServicioIdLabel.Text = "Programacion Servicio #:";
            // 
            // semanaLabel
            // 
            semanaLabel.AutoSize = true;
            semanaLabel.Location = new System.Drawing.Point(340, 256);
            semanaLabel.Name = "semanaLabel";
            semanaLabel.Size = new System.Drawing.Size(97, 13);
            semanaLabel.TabIndex = 9;
            semanaLabel.Text = "semana(s) de cada";
            // 
            // sucursalIdLabel
            // 
            sucursalIdLabel.AutoSize = true;
            sucursalIdLabel.Location = new System.Drawing.Point(363, 41);
            sucursalIdLabel.Name = "sucursalIdLabel";
            sucursalIdLabel.Size = new System.Drawing.Size(63, 13);
            sucursalIdLabel.TabIndex = 11;
            sucursalIdLabel.Text = "Sucursal Id:";
            sucursalIdLabel.Visible = false;
            sucursalIdLabel.Click += new System.EventHandler(this.sucursalIdLabel_Click);
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Location = new System.Drawing.Point(16, 120);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(51, 13);
            nombreLabel1.TabIndex = 13;
            nombreLabel1.Text = "Sucursal:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(16, 94);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(104, 13);
            numeroLabel.TabIndex = 15;
            numeroLabel.Text = "Numero de sucursal:";
            // 
            // programacionservicioBindingNavigator
            // 
            this.programacionservicioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.programacionservicioBindingNavigator.BindingSource = this.programacionservicioBindingSource;
            this.programacionservicioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.programacionservicioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.programacionservicioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton1,
            this.programacionservicioBindingNavigatorSaveItem,
            this.tsbCancelar});
            this.programacionservicioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.programacionservicioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.programacionservicioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.programacionservicioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.programacionservicioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.programacionservicioBindingNavigator.Name = "programacionservicioBindingNavigator";
            this.programacionservicioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.programacionservicioBindingNavigator.Size = new System.Drawing.Size(602, 25);
            this.programacionservicioBindingNavigator.TabIndex = 0;
            this.programacionservicioBindingNavigator.Text = "bindingNavigator1";
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
            // programacionservicioBindingNavigatorSaveItem
            // 
            this.programacionservicioBindingNavigatorSaveItem.Enabled = false;
            this.programacionservicioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("programacionservicioBindingNavigatorSaveItem.Image")));
            this.programacionservicioBindingNavigatorSaveItem.Name = "programacionservicioBindingNavigatorSaveItem";
            this.programacionservicioBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.programacionservicioBindingNavigatorSaveItem.Text = "Guardar";
            this.programacionservicioBindingNavigatorSaveItem.Click += new System.EventHandler(this.programacionservicioBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::FUMIT.Recursos.edit_add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton1.Text = "Editar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // diasTextBox
            // 
            this.diasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programacionservicioBindingSource, "Dias", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.diasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.programacionServiciosSucursalesbindingSource, "ModoNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.diasTextBox.Location = new System.Drawing.Point(76, 253);
            this.diasTextBox.Name = "diasTextBox";
            this.diasTextBox.ReadOnly = true;
            this.diasTextBox.Size = new System.Drawing.Size(100, 20);
            this.diasTextBox.TabIndex = 6;
            // 
            // mesTextBox
            // 
            this.mesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programacionservicioBindingSource, "Mes", true));
            this.mesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.programacionServiciosSucursalesbindingSource, "ModoNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mesTextBox.Location = new System.Drawing.Point(443, 253);
            this.mesTextBox.Name = "mesTextBox";
            this.mesTextBox.ReadOnly = true;
            this.mesTextBox.Size = new System.Drawing.Size(100, 20);
            this.mesTextBox.TabIndex = 8;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programacionservicioBindingSource, "Nombre", true));
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.programacionServiciosSucursalesbindingSource, "ModoNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nombreTextBox.Location = new System.Drawing.Point(150, 60);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(180, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // programacionServicioIdTextBox
            // 
            this.programacionServicioIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programacionservicioBindingSource, "ProgramacionServicioId", true));
            this.programacionServicioIdTextBox.Location = new System.Drawing.Point(150, 34);
            this.programacionServicioIdTextBox.Name = "programacionServicioIdTextBox";
            this.programacionServicioIdTextBox.ReadOnly = true;
            this.programacionServicioIdTextBox.Size = new System.Drawing.Size(78, 20);
            this.programacionServicioIdTextBox.TabIndex = 8;
            // 
            // semanaTextBox
            // 
            this.semanaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programacionservicioBindingSource, "Semana", true));
            this.semanaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.programacionServiciosSucursalesbindingSource, "ModoNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.semanaTextBox.Location = new System.Drawing.Point(234, 253);
            this.semanaTextBox.Name = "semanaTextBox";
            this.semanaTextBox.ReadOnly = true;
            this.semanaTextBox.Size = new System.Drawing.Size(100, 20);
            this.semanaTextBox.TabIndex = 7;
            this.semanaTextBox.TextChanged += new System.EventHandler(this.semanaTextBox_TextChanged);
            this.semanaTextBox.Leave += new System.EventHandler(this.semanaTextBox_Leave);
            // 
            // sucursalIdTextBox
            // 
            this.sucursalIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programacionservicioBindingSource, "SucursalId", true));
            this.sucursalIdTextBox.Location = new System.Drawing.Point(432, 38);
            this.sucursalIdTextBox.Name = "sucursalIdTextBox";
            this.sucursalIdTextBox.ReadOnly = true;
            this.sucursalIdTextBox.Size = new System.Drawing.Size(78, 20);
            this.sucursalIdTextBox.TabIndex = 3;
            this.sucursalIdTextBox.Visible = false;
            // 
            // nombreTextBox1
            // 
            this.nombreTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programacionservicioBindingSource, "Sucursal.Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nombreTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.programacionServiciosSucursalesbindingSource, "ModoNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nombreTextBox1.Location = new System.Drawing.Point(150, 117);
            this.nombreTextBox1.Name = "nombreTextBox1";
            this.nombreTextBox1.ReadOnly = true;
            this.nombreTextBox1.Size = new System.Drawing.Size(180, 20);
            this.nombreTextBox1.TabIndex = 4;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programacionservicioBindingSource, "Sucursal.Numero", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.programacionServiciosSucursalesbindingSource, "ModoNormal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numeroTextBox.Location = new System.Drawing.Point(150, 87);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.ReadOnly = true;
            this.numeroTextBox.Size = new System.Drawing.Size(180, 20);
            this.numeroTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Esta programación de servicios se realizará de manera:";
            // 
            // chkListTipoProgramacion
            // 
            this.chkListTipoProgramacion.CheckOnClick = true;
            this.chkListTipoProgramacion.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.programacionServiciosSucursalesbindingSource, "ModoEditar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkListTipoProgramacion.Enabled = false;
            this.chkListTipoProgramacion.FormattingEnabled = true;
            this.chkListTipoProgramacion.Items.AddRange(new object[] {
            "Diaria",
            "Semanal",
            "Mensual",
            "Otra"});
            this.chkListTipoProgramacion.Location = new System.Drawing.Point(19, 176);
            this.chkListTipoProgramacion.Name = "chkListTipoProgramacion";
            this.chkListTipoProgramacion.Size = new System.Drawing.Size(263, 64);
            this.chkListTipoProgramacion.TabIndex = 5;
            this.chkListTipoProgramacion.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListTipoProgramacion_ItemCheck);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Los días:";
            // 
            // chkListDiasSemana
            // 
            this.chkListDiasSemana.CheckOnClick = true;
            this.chkListDiasSemana.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.programacionServiciosSucursalesbindingSource, "ModoEditar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkListDiasSemana.Enabled = false;
            this.chkListDiasSemana.FormattingEnabled = true;
            this.chkListDiasSemana.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.chkListDiasSemana.Location = new System.Drawing.Point(19, 279);
            this.chkListDiasSemana.Name = "chkListDiasSemana";
            this.chkListDiasSemana.Size = new System.Drawing.Size(157, 109);
            this.chkListDiasSemana.TabIndex = 9;
            this.chkListDiasSemana.SelectedIndexChanged += new System.EventHandler(this.chkListDiasSemana_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "de cada";
            // 
            // btnBusquedaSucursal
            // 
            this.btnBusquedaSucursal.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.programacionServiciosSucursalesbindingSource, "ModoEditar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBusquedaSucursal.Enabled = false;
            this.btnBusquedaSucursal.Image = global::FUMIT.Recursos.search;
            this.btnBusquedaSucursal.Location = new System.Drawing.Point(336, 84);
            this.btnBusquedaSucursal.Name = "btnBusquedaSucursal";
            this.btnBusquedaSucursal.Size = new System.Drawing.Size(31, 23);
            this.btnBusquedaSucursal.TabIndex = 3;
            this.btnBusquedaSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusquedaSucursal.UseVisualStyleBackColor = true;
            this.btnBusquedaSucursal.Click += new System.EventHandler(this.btnBusquedaSucursal_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(500, 365);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 41;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Visible = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // programacionServiciosSucursalesbindingSource
            // 
            this.programacionServiciosSucursalesbindingSource.DataSource = typeof(FUMIT.Formularios.Operacion.ProgramacionServiciosSucursales);
            // 
            // programacionservicioBindingSource
            // 
            this.programacionservicioBindingSource.DataSource = typeof(FUMIT.Entidades.Programacionservicio);
            this.programacionservicioBindingSource.CurrentChanged += new System.EventHandler(this.programacionservicioBindingSource_CurrentChanged);
            // 
            // ProgramacionServiciosSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 403);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBusquedaSucursal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkListDiasSemana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkListTipoProgramacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(nombreLabel1);
            this.Controls.Add(this.nombreTextBox1);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.diasTextBox);
            this.Controls.Add(mesLabel);
            this.Controls.Add(this.mesTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(programacionServicioIdLabel);
            this.Controls.Add(this.programacionServicioIdTextBox);
            this.Controls.Add(semanaLabel);
            this.Controls.Add(this.semanaTextBox);
            this.Controls.Add(sucursalIdLabel);
            this.Controls.Add(this.sucursalIdTextBox);
            this.Controls.Add(this.programacionservicioBindingNavigator);
            this.Name = "ProgramacionServiciosSucursales";
            this.Text = "Programacion de servicios por sucursal";
            this.Load += new System.EventHandler(this.ProgramacionServiciosSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programacionservicioBindingNavigator)).EndInit();
            this.programacionservicioBindingNavigator.ResumeLayout(false);
            this.programacionservicioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programacionServiciosSucursalesbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programacionservicioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource programacionservicioBindingSource;
        private System.Windows.Forms.BindingNavigator programacionservicioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton programacionservicioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox diasTextBox;
        private System.Windows.Forms.TextBox mesTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox programacionServicioIdTextBox;
        private System.Windows.Forms.TextBox semanaTextBox;
        private System.Windows.Forms.TextBox sucursalIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox1;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListTipoProgramacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chkListDiasSemana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBusquedaSucursal;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.BindingSource programacionServiciosSucursalesbindingSource;
    }
}
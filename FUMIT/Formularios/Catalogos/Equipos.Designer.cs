namespace FUMIT.Formularios.Catalogos
{
    partial class Equipos
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label enMantenimientoLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label numeroEconomicoLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label requiereMantenimientoLabel;
            System.Windows.Forms.Label asignadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipos));
            this.equipoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.equipoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.enMantenimientoCheckBox = new System.Windows.Forms.CheckBox();
            this.numeroEconomicoTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.requiereMantenimientoCheckBox = new System.Windows.Forms.CheckBox();
            this.tiposEquiposComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.AgregarTipoEquipoBoton = new System.Windows.Forms.Button();
            this.asignadoCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDatosEquipo = new System.Windows.Forms.TabPage();
            this.tabMantenimientos = new System.Windows.Forms.TabPage();
            this.mantenimientoEquipoUC1 = new FUMIT.Formularios.Operacion.MantenimientoEquipoUC();
            activoLabel = new System.Windows.Forms.Label();
            enMantenimientoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            numeroEconomicoLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            requiereMantenimientoLabel = new System.Windows.Forms.Label();
            asignadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingNavigator)).BeginInit();
            this.equipoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDatosEquipo.SuspendLayout();
            this.tabMantenimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(10, 176);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // enMantenimientoLabel
            // 
            enMantenimientoLabel.AutoSize = true;
            enMantenimientoLabel.Location = new System.Drawing.Point(9, 146);
            enMantenimientoLabel.Name = "enMantenimientoLabel";
            enMantenimientoLabel.Size = new System.Drawing.Size(95, 13);
            enMantenimientoLabel.TabIndex = 3;
            enMantenimientoLabel.Text = "En Mantenimiento:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(9, 84);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 5;
            estadoLabel.Text = "Estado:";
            // 
            // numeroEconomicoLabel
            // 
            numeroEconomicoLabel.AutoSize = true;
            numeroEconomicoLabel.Location = new System.Drawing.Point(10, 58);
            numeroEconomicoLabel.Name = "numeroEconomicoLabel";
            numeroEconomicoLabel.Size = new System.Drawing.Size(103, 13);
            numeroEconomicoLabel.TabIndex = 7;
            numeroEconomicoLabel.Text = "Numero Economico:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(9, 226);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 9;
            observacionesLabel.Text = "Observaciones:";
            // 
            // requiereMantenimientoLabel
            // 
            requiereMantenimientoLabel.AutoSize = true;
            requiereMantenimientoLabel.Location = new System.Drawing.Point(9, 116);
            requiereMantenimientoLabel.Name = "requiereMantenimientoLabel";
            requiereMantenimientoLabel.Size = new System.Drawing.Size(125, 13);
            requiereMantenimientoLabel.TabIndex = 11;
            requiereMantenimientoLabel.Text = "Requiere Mantenimiento:";
            // 
            // asignadoLabel
            // 
            asignadoLabel.AutoSize = true;
            asignadoLabel.Location = new System.Drawing.Point(10, 201);
            asignadoLabel.Name = "asignadoLabel";
            asignadoLabel.Size = new System.Drawing.Size(54, 13);
            asignadoLabel.TabIndex = 18;
            asignadoLabel.Text = "Asignado:";
            // 
            // equipoBindingNavigator
            // 
            this.equipoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.equipoBindingNavigator.BindingSource = this.equipoBindingSource;
            this.equipoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.equipoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.equipoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.equipoBindingNavigatorSaveItem,
            this.tsbCancelar});
            this.equipoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.equipoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.equipoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.equipoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.equipoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.equipoBindingNavigator.Name = "equipoBindingNavigator";
            this.equipoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.equipoBindingNavigator.Size = new System.Drawing.Size(615, 25);
            this.equipoBindingNavigator.TabIndex = 0;
            this.equipoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::FUMIT.Recursos.add;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(69, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar";
            this.bindingNavigatorAddNewItem.ToolTipText = "Agregar";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(FUMIT.Entidades.Equipo);
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
            // equipoBindingNavigatorSaveItem
            // 
            this.equipoBindingNavigatorSaveItem.Enabled = false;
            this.equipoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("equipoBindingNavigatorSaveItem.Image")));
            this.equipoBindingNavigatorSaveItem.Name = "equipoBindingNavigatorSaveItem";
            this.equipoBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.equipoBindingNavigatorSaveItem.Text = "Guardar";
            this.equipoBindingNavigatorSaveItem.Click += new System.EventHandler(this.equipoBindingNavigatorSaveItem_Click);
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
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.equipoBindingSource, "Activo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(141, 171);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // enMantenimientoCheckBox
            // 
            this.enMantenimientoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.equipoBindingSource, "EnMantenimiento", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.enMantenimientoCheckBox.Enabled = false;
            this.enMantenimientoCheckBox.Location = new System.Drawing.Point(140, 141);
            this.enMantenimientoCheckBox.Name = "enMantenimientoCheckBox";
            this.enMantenimientoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.enMantenimientoCheckBox.TabIndex = 4;
            this.enMantenimientoCheckBox.UseVisualStyleBackColor = true;
            // 
            // numeroEconomicoTextBox
            // 
            this.numeroEconomicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "NumeroEconomico", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numeroEconomicoTextBox.Location = new System.Drawing.Point(141, 55);
            this.numeroEconomicoTextBox.Name = "numeroEconomicoTextBox";
            this.numeroEconomicoTextBox.ReadOnly = true;
            this.numeroEconomicoTextBox.Size = new System.Drawing.Size(274, 20);
            this.numeroEconomicoTextBox.TabIndex = 8;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "Observaciones", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.observacionesTextBox.Location = new System.Drawing.Point(140, 226);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ReadOnly = true;
            this.observacionesTextBox.Size = new System.Drawing.Size(423, 147);
            this.observacionesTextBox.TabIndex = 10;
            // 
            // requiereMantenimientoCheckBox
            // 
            this.requiereMantenimientoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.equipoBindingSource, "RequiereMantenimiento", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.requiereMantenimientoCheckBox.Enabled = false;
            this.requiereMantenimientoCheckBox.Location = new System.Drawing.Point(140, 111);
            this.requiereMantenimientoCheckBox.Name = "requiereMantenimientoCheckBox";
            this.requiereMantenimientoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.requiereMantenimientoCheckBox.TabIndex = 12;
            this.requiereMantenimientoCheckBox.UseVisualStyleBackColor = true;
            // 
            // tiposEquiposComboBox
            // 
            this.tiposEquiposComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "Tipoequipo.Nombre", true));
            this.tiposEquiposComboBox.Enabled = false;
            this.tiposEquiposComboBox.FormattingEnabled = true;
            this.tiposEquiposComboBox.Items.AddRange(new object[] {
            "<Nuevo tipo>"});
            this.tiposEquiposComboBox.Location = new System.Drawing.Point(140, 28);
            this.tiposEquiposComboBox.Name = "tiposEquiposComboBox";
            this.tiposEquiposComboBox.Size = new System.Drawing.Size(274, 21);
            this.tiposEquiposComboBox.TabIndex = 15;
            this.tiposEquiposComboBox.SelectedIndexChanged += new System.EventHandler(this.tiposEquiposComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo:";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "Estado", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.estadoComboBox.Enabled = false;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Bueno",
            "Dañado"});
            this.estadoComboBox.Location = new System.Drawing.Point(141, 84);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(274, 21);
            this.estadoComboBox.TabIndex = 17;
            // 
            // AgregarTipoEquipoBoton
            // 
            this.AgregarTipoEquipoBoton.Enabled = false;
            this.AgregarTipoEquipoBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarTipoEquipoBoton.Image = global::FUMIT.Recursos.add;
            this.AgregarTipoEquipoBoton.Location = new System.Drawing.Point(420, 26);
            this.AgregarTipoEquipoBoton.Name = "AgregarTipoEquipoBoton";
            this.AgregarTipoEquipoBoton.Size = new System.Drawing.Size(29, 23);
            this.AgregarTipoEquipoBoton.TabIndex = 18;
            this.AgregarTipoEquipoBoton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarTipoEquipoBoton.UseVisualStyleBackColor = true;
            this.AgregarTipoEquipoBoton.Click += new System.EventHandler(this.button1_Click);
            // 
            // asignadoCheckBox
            // 
            this.asignadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.equipoBindingSource, "Asignado", true));
            this.asignadoCheckBox.Enabled = false;
            this.asignadoCheckBox.Location = new System.Drawing.Point(140, 196);
            this.asignadoCheckBox.Name = "asignadoCheckBox";
            this.asignadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.asignadoCheckBox.TabIndex = 19;
            this.asignadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDatosEquipo);
            this.tabControl1.Controls.Add(this.tabMantenimientos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(615, 535);
            this.tabControl1.TabIndex = 20;
            // 
            // tabDatosEquipo
            // 
            this.tabDatosEquipo.Controls.Add(this.label1);
            this.tabDatosEquipo.Controls.Add(asignadoLabel);
            this.tabDatosEquipo.Controls.Add(this.requiereMantenimientoCheckBox);
            this.tabDatosEquipo.Controls.Add(this.asignadoCheckBox);
            this.tabDatosEquipo.Controls.Add(requiereMantenimientoLabel);
            this.tabDatosEquipo.Controls.Add(this.AgregarTipoEquipoBoton);
            this.tabDatosEquipo.Controls.Add(this.observacionesTextBox);
            this.tabDatosEquipo.Controls.Add(this.estadoComboBox);
            this.tabDatosEquipo.Controls.Add(observacionesLabel);
            this.tabDatosEquipo.Controls.Add(this.numeroEconomicoTextBox);
            this.tabDatosEquipo.Controls.Add(this.tiposEquiposComboBox);
            this.tabDatosEquipo.Controls.Add(numeroEconomicoLabel);
            this.tabDatosEquipo.Controls.Add(activoLabel);
            this.tabDatosEquipo.Controls.Add(estadoLabel);
            this.tabDatosEquipo.Controls.Add(this.activoCheckBox);
            this.tabDatosEquipo.Controls.Add(this.enMantenimientoCheckBox);
            this.tabDatosEquipo.Controls.Add(enMantenimientoLabel);
            this.tabDatosEquipo.Location = new System.Drawing.Point(4, 22);
            this.tabDatosEquipo.Name = "tabDatosEquipo";
            this.tabDatosEquipo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosEquipo.Size = new System.Drawing.Size(607, 509);
            this.tabDatosEquipo.TabIndex = 0;
            this.tabDatosEquipo.Text = "Datos del equipo";
            this.tabDatosEquipo.UseVisualStyleBackColor = true;
            // 
            // tabMantenimientos
            // 
            this.tabMantenimientos.Controls.Add(this.mantenimientoEquipoUC1);
            this.tabMantenimientos.Location = new System.Drawing.Point(4, 22);
            this.tabMantenimientos.Name = "tabMantenimientos";
            this.tabMantenimientos.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimientos.Size = new System.Drawing.Size(607, 509);
            this.tabMantenimientos.TabIndex = 1;
            this.tabMantenimientos.Text = "Mantenimientos";
            this.tabMantenimientos.UseVisualStyleBackColor = true;
            // 
            // mantenimientoEquipoUC1
            // 
            this.mantenimientoEquipoUC1.DataBindings.Add(new System.Windows.Forms.Binding("EquipoId", this.equipoBindingSource, "EquipoId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mantenimientoEquipoUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mantenimientoEquipoUC1.EquipoId = 0;
            this.mantenimientoEquipoUC1.EquipoSeleccionable = false;
            this.mantenimientoEquipoUC1.EquipoSeleccionado = null;
            this.mantenimientoEquipoUC1.EquiposRepositorioLocal = null;
            this.mantenimientoEquipoUC1.FormExceptionManager = null;
            this.mantenimientoEquipoUC1.ListaEquipos = null;
            this.mantenimientoEquipoUC1.Location = new System.Drawing.Point(3, 3);
            this.mantenimientoEquipoUC1.MantenimientosRepositorioLocal = null;
            this.mantenimientoEquipoUC1.ModoEdicion = false;
            this.mantenimientoEquipoUC1.Name = "mantenimientoEquipoUC1";
            this.mantenimientoEquipoUC1.Size = new System.Drawing.Size(601, 503);
            this.mantenimientoEquipoUC1.TabIndex = 0;
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 560);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.equipoBindingNavigator);
            this.Name = "Equipos";
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.Equipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingNavigator)).EndInit();
            this.equipoBindingNavigator.ResumeLayout(false);
            this.equipoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDatosEquipo.ResumeLayout(false);
            this.tabDatosEquipo.PerformLayout();
            this.tabMantenimientos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.BindingNavigator equipoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton equipoBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.CheckBox enMantenimientoCheckBox;
        private System.Windows.Forms.TextBox numeroEconomicoTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.CheckBox requiereMantenimientoCheckBox;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ComboBox tiposEquiposComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.Button AgregarTipoEquipoBoton;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.CheckBox asignadoCheckBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDatosEquipo;
        private System.Windows.Forms.TabPage tabMantenimientos;
        private Operacion.MantenimientoEquipoUC mantenimientoEquipoUC1;
    }
}
namespace FUMIT.Formularios.Catalogos
{
    partial class TiposEquipo
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiposEquipo));
            this.tipoequipoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tsbEditarButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tipoequipoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.BotonSeleccionar = new System.Windows.Forms.Button();
            this.tipoequipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descripcionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipoequipoBindingNavigator)).BeginInit();
            this.tipoequipoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoequipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(25, 71);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(25, 45);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // tipoequipoBindingNavigator
            // 
            this.tipoequipoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tipoequipoBindingNavigator.BindingSource = this.tipoequipoBindingSource;
            this.tipoequipoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tipoequipoBindingNavigator.DeleteItem = null;
            this.tipoequipoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tsbEditarButton,
            this.bindingNavigatorDeleteItem,
            this.tipoequipoBindingNavigatorSaveItem,
            this.tsbCancelar});
            this.tipoequipoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tipoequipoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tipoequipoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tipoequipoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tipoequipoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tipoequipoBindingNavigator.Name = "tipoequipoBindingNavigator";
            this.tipoequipoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tipoequipoBindingNavigator.Size = new System.Drawing.Size(625, 25);
            this.tipoequipoBindingNavigator.TabIndex = 0;
            this.tipoequipoBindingNavigator.Text = "bindingNavigator1";
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
            // tsbEditarButton
            // 
            this.tsbEditarButton.Image = global::FUMIT.Recursos.edit_add;
            this.tsbEditarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditarButton.Name = "tsbEditarButton";
            this.tsbEditarButton.Size = new System.Drawing.Size(57, 22);
            this.tsbEditarButton.Text = "Editar";
            this.tsbEditarButton.Click += new System.EventHandler(this.tsbEditarButton_Click);
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
            // tipoequipoBindingNavigatorSaveItem
            // 
            this.tipoequipoBindingNavigatorSaveItem.Enabled = false;
            this.tipoequipoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoequipoBindingNavigatorSaveItem.Image")));
            this.tipoequipoBindingNavigatorSaveItem.Name = "tipoequipoBindingNavigatorSaveItem";
            this.tipoequipoBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.tipoequipoBindingNavigatorSaveItem.Text = "Guardar";
            this.tipoequipoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tipoequipoBindingNavigatorSaveItem_Click);
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
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoequipoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(110, 68);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(485, 101);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoequipoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(110, 42);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(485, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // BotonSeleccionar
            // 
            this.BotonSeleccionar.Location = new System.Drawing.Point(520, 186);
            this.BotonSeleccionar.Name = "BotonSeleccionar";
            this.BotonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.BotonSeleccionar.TabIndex = 7;
            this.BotonSeleccionar.Text = "Seleccionar";
            this.BotonSeleccionar.UseVisualStyleBackColor = true;
            this.BotonSeleccionar.Visible = false;
            this.BotonSeleccionar.Click += new System.EventHandler(this.BotonSeleccionar_Click);
            // 
            // tipoequipoBindingSource
            // 
            this.tipoequipoBindingSource.DataSource = typeof(FUMIT.Entidades.Tipoequipo);
            // 
            // TiposEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 228);
            this.Controls.Add(this.BotonSeleccionar);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.tipoequipoBindingNavigator);
            this.Name = "TiposEquipo";
            this.Text = "Tipos de equipo";
            this.Load += new System.EventHandler(this.TiposEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoequipoBindingNavigator)).EndInit();
            this.tipoequipoBindingNavigator.ResumeLayout(false);
            this.tipoequipoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoequipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator tipoequipoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tipoequipoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button BotonSeleccionar;
        private System.Windows.Forms.ToolStripButton tsbEditarButton;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        internal System.Windows.Forms.BindingSource tipoequipoBindingSource;
    }
}
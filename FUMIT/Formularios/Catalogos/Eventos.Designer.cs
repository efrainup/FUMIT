namespace FUMIT.Formularios.Catalogos
{
    partial class Eventos
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
            System.Windows.Forms.Label borradoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label eventoClienteIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eventos));
            this.eventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eventoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.borradoCheckBox = new System.Windows.Forms.CheckBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.eventoClienteIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            borradoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            eventoClienteIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingNavigator)).BeginInit();
            this.eventoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // borradoLabel
            // 
            borradoLabel.AutoSize = true;
            borradoLabel.Location = new System.Drawing.Point(12, 234);
            borradoLabel.Name = "borradoLabel";
            borradoLabel.Size = new System.Drawing.Size(47, 13);
            borradoLabel.TabIndex = 1;
            borradoLabel.Text = "Borrado:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(247, 40);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 3;
            codigoLabel.Text = "Codigo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(12, 92);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // eventoClienteIdLabel
            // 
            eventoClienteIdLabel.AutoSize = true;
            eventoClienteIdLabel.Location = new System.Drawing.Point(12, 40);
            eventoClienteIdLabel.Name = "eventoClienteIdLabel";
            eventoClienteIdLabel.Size = new System.Drawing.Size(91, 13);
            eventoClienteIdLabel.TabIndex = 7;
            eventoClienteIdLabel.Text = "Evento Cliente Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 66);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // eventoBindingSource
            // 
            this.eventoBindingSource.DataSource = typeof(FUMIT.Entidades.Evento);
            // 
            // eventoBindingNavigator
            // 
            this.eventoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventoBindingNavigator.BindingSource = this.eventoBindingSource;
            this.eventoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventoBindingNavigatorSaveItem});
            this.eventoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventoBindingNavigator.Name = "eventoBindingNavigator";
            this.eventoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventoBindingNavigator.Size = new System.Drawing.Size(518, 25);
            this.eventoBindingNavigator.TabIndex = 0;
            this.eventoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // eventoBindingNavigatorSaveItem
            // 
            this.eventoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventoBindingNavigatorSaveItem.Enabled = false;
            this.eventoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventoBindingNavigatorSaveItem.Image")));
            this.eventoBindingNavigatorSaveItem.Name = "eventoBindingNavigatorSaveItem";
            this.eventoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eventoBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // borradoCheckBox
            // 
            this.borradoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eventoBindingSource, "Borrado", true));
            this.borradoCheckBox.Location = new System.Drawing.Point(109, 229);
            this.borradoCheckBox.Name = "borradoCheckBox";
            this.borradoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.borradoCheckBox.TabIndex = 2;
            this.borradoCheckBox.Text = "checkBox1";
            this.borradoCheckBox.UseVisualStyleBackColor = true;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(323, 37);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(104, 20);
            this.codigoTextBox.TabIndex = 4;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(109, 89);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(318, 123);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // eventoClienteIdTextBox
            // 
            this.eventoClienteIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoBindingSource, "EventoClienteId", true));
            this.eventoClienteIdTextBox.Location = new System.Drawing.Point(109, 37);
            this.eventoClienteIdTextBox.Name = "eventoClienteIdTextBox";
            this.eventoClienteIdTextBox.Size = new System.Drawing.Size(63, 20);
            this.eventoClienteIdTextBox.TabIndex = 8;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(109, 63);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(318, 20);
            this.nombreTextBox.TabIndex = 10;
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 323);
            this.Controls.Add(borradoLabel);
            this.Controls.Add(this.borradoCheckBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(eventoClienteIdLabel);
            this.Controls.Add(this.eventoClienteIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.eventoBindingNavigator);
            this.Name = "Eventos";
            this.Text = "Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingNavigator)).EndInit();
            this.eventoBindingNavigator.ResumeLayout(false);
            this.eventoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eventoBindingSource;
        private System.Windows.Forms.BindingNavigator eventoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eventoBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox borradoCheckBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox eventoClienteIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
    }
}
﻿using CommonServiceLocator;
using FUMIT.AccesoDatos;
using FUMIT.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUMIT.Formularios.Compartidos
{
    public partial class BusquedaClientes : Form
    {
        public IClientes ClientesRepositorio { get; set; }
        IEnumerable<Entidades.Cliente> ListadoClientes { get; set; }
        Cliente ClienteActual
        {
            get
            {
                return (clienteBindingSource.Current as Cliente);
            }
        }

        public event EventHandler<Cliente> ClienteSeleccionado;

        public BusquedaClientes()
        {
            InitializeComponent();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IEnumerable<Cliente> filtro = ListadoClientes;
            
            if (!string.IsNullOrEmpty(nombreTextBox.Text))
            {
                filtro = filtro.Where(w => w.Nombre.Contains(nombreTextBox.Text)).ToList();
            }


            clienteBindingSource.DataSource = filtro;

            clienteBindingSource.ResetBindings(false);
            clienteDataGridView.Refresh();
            clienteDataGridView.Update();


        }

        private void BusquedaClientes_Load(object sender, EventArgs e)
        {
            ClientesRepositorio = ServiceLocator.Current.GetInstance<IClientes>();
            ListadoClientes = ClientesRepositorio.Recuperar();

            clienteBindingSource.DataSource = ListadoClientes;

            nombreTextBox.Focus();

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ClienteSeleccionado.Invoke(this, ClienteActual);
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Enter)
            {
                if (nombreTextBox.Focused)
                {
                    btnBuscar.PerformClick();
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSeleccionar.PerformClick();
        }
    }
}

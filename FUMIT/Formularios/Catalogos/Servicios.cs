using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FUMIT.Formularios.Catalogos
{
    public partial class Servicios : Form, IModosEdicion
    {
        protected bool modoEditar = false;
        protected bool modoAgregar = false;

        public bool ModoAgregar
        {
            get
            {
                return modoAgregar;
            }
            set
            {
                modoAgregar = value;
                if (value)
                {
                    EntrarModoEdicion();
                }
                else
                {
                    SalirModoEdicion();
                }
            }
        }

        public Servicios()
        {
            InitializeComponent();
        }

        public void EntrarModoEdicion()
        {
            throw new NotImplementedException();
        }

        public void SalirModoEdicion()
        {
            throw new NotImplementedException();
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e) {
            Entrar_ModoAgregar();
        }

        private void btnEditarServicio_Click(object sender, EventArgs e) {
            Entrar_ModoEditar();
        }

        public void Entrar_ModoAgregar() {

            btnAgregarServicio.Enabled = false;
            btnEditarServicio.Enabled = false;
            btnGuardarServicio.Enabled = true;
            btnCancelarServicio.Enabled = true;
            btnBuscarNombre.Enabled = false;

            btnAgregarServicio.Visible = false;
            btnEditarServicio.Visible = false;
            btnGuardarServicio.Visible = true;
            btnCancelarServicio.Visible = true;
            btnBuscarNombre.Visible = false;
            txtDescripcion.Enabled = true;            
        }

        public void Entrar_ModoEditar() {

            btnAgregarServicio.Enabled = false;
            btnEditarServicio.Enabled = false;
            btnGuardarServicio.Enabled = true;
            btnCancelarServicio.Enabled = true;
            btnBuscarNombre.Enabled = true;

            btnAgregarServicio.Visible = false;
            btnEditarServicio.Visible = false;
            btnGuardarServicio.Visible = true;
            btnCancelarServicio.Visible = true;
            btnBuscarNombre.Visible = true;
            txtDescripcion.Enabled = true;
        }

        public void Entrar_ModoNormal() {

            btnAgregarServicio.Enabled = true;
            btnEditarServicio.Enabled = true;
            btnGuardarServicio.Enabled = false;
            btnCancelarServicio.Enabled = false;
            btnBuscarNombre.Enabled = true;

            btnAgregarServicio.Visible = true;
            btnEditarServicio.Visible = true;
            btnGuardarServicio.Visible = false;
            btnCancelarServicio.Visible = false;
            btnBuscarNombre.Visible = true;
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e) {
            Entrar_ModoNormal();
        }

        private void btnGuardarServicio_Click(object sender, EventArgs e) {
            Entrar_ModoNormal();
        }

        private void btnCancelarServicio_Click(object sender, EventArgs e) {
            Entrar_ModoNormal();
        }

        private void Buscar(string Query)
        {
            string Conexion = ConfigurationManager.ConnectionStrings["FUMIT"].ConnectionString;
            using (SqlConnection Connection = new SqlConnection(Conexion))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    using (SqlDataAdapter Adapter = new SqlDataAdapter(Command))
                    {
                        using (DataTable Tabla = new DataTable())
                        {
                            GrdServicios.DataSource = null;
                            GrdServicios.Rows.Clear();
                            Adapter.Fill(Tabla);
                            
                            GrdServicios.AutoGenerateColumns = false;
                            GrdServicios.ColumnCount = 3;

                            GrdServicios.Columns[0].Name = "Nombre";
                            GrdServicios.Columns[0].HeaderText = "Nombre";
                            GrdServicios.Columns[0].DataPropertyName = "Nombre";

                            GrdServicios.Columns[1].HeaderText = "Descripción";
                            GrdServicios.Columns[1].Name = "Descripcion";
                            GrdServicios.Columns[1].DataPropertyName = "Descripcion";

                            GrdServicios.Columns[2].Name = "Activo";
                            GrdServicios.Columns[2].HeaderText = "Activo";
                            GrdServicios.Columns[2].DataPropertyName = "Activo";
                            GrdServicios.DataSource = Tabla;
                        }
                    }
                }
            }
        }

        private void Sucursales(string Query)
        {
            string Conexion = ConfigurationManager.ConnectionStrings["FUMIT"].ConnectionString;
            using (SqlConnection Connection = new SqlConnection(Conexion))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    using (SqlDataAdapter Adapter = new SqlDataAdapter(Command))
                    {
                        using (DataTable Tabla = new DataTable())
                        {
                            Adapter.Fill(Tabla);
                            chckServicios.Items.Clear();
                            foreach (DataRow Fila in Tabla.Rows)
                            {
                                chckServicios.Items.Add(Fila[0].ToString());
                            }
                        }
                    }
                }
            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            
            if (txtNombre.Text != "")
            {
                Buscar("SELECT Nombre, Descripcion, Activo FROM Servicios WHERE Nombre = '" + txtNombre.Text + "'");
                Sucursales("SELECT Nombre, Descripcion, Activo FROM Servicios WHERE Nombre = '" + txtNombre.Text + "'");
            }
            else
            {
                Buscar("SELECT Nombre, Descripcion, Activo FROM Servicios");
            }
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            Buscar("SELECT Nombre, Descripcion, Activo FROM Servicios");
            Sucursales("SELECT Nombre FROM Sucursales WHERE Borrado=0");
        }        
    }
}

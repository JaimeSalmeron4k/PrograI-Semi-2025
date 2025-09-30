using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyectoCsharp
{
    public partial class FrmDocentes : Form
    {
        public FrmDocentes()
        {
            InitializeComponent();
        }
        Conexion objConexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();
        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objConexion.obtenerDatos();
            objDt = objDs.Tables["docentes"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idDocente"] };

            grdDocentes.DataSource = objDt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idDocente.Text = objDt.Rows[posicion]["idDocente"].ToString();
                txtCodigoDocente.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreDocente.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDuiDocente.Text = objDt.Rows[posicion]["dui"].ToString();
                txtEspecialidadDocente.Text = objDt.Rows[posicion]["especialidad"].ToString();
                txtCorreoDocente.Text = objDt.Rows[posicion]["correo"].ToString();
                txtTelefonoDocente.Text = objDt.Rows[posicion]["telefono"].ToString();
                txtDireccionDocente.Text = objDt.Rows[posicion]["direccion"].ToString();


                lblnRegistrosDocente.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }

        private void FrmDocentes_Load(object sender, EventArgs e)
        {
            actualizarDs();
            cboBuscarDocentes.SelectedIndex = 0;
        }

        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorDocente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoDocente_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPrimeroDocente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosDocente.Enabled = estado;
            grbNavegacionDocente.Enabled = !estado;
            btnEliminarDocente.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idDocente.Text = "";
            txtCodigoDocente.Text = "";
            txtNombreDocente.Text = "";
            txtDuiDocente.Text = "";
            txtEspecialidadDocente.Text = "";
            txtCorreoDocente.Text = "";
            txtTelefonoDocente.Text = "";
            txtDireccionDocente.Text = "";
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            if (btnAgregarDocente.Text == "Nuevo")
            {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] docentes = {
                    idDocente.Text, txtCodigoDocente.Text, txtNombreDocente.Text,
                    txtDuiDocente.Text, txtEspecialidadDocente.Text, txtCorreoDocente.Text,
                    txtTelefonoDocente.Text, txtDireccionDocente.Text
                };
                String respuesta = objConexion.administrarDatosDocentes(docentes, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar Docente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarDocente.Text = "Nuevo";
                    btnModificarDocente.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            if (btnModificarDocente.Text == "Modificar")
            {
                btnAgregarDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarDocente.Text = "Nuevo";
                btnModificarDocente.Text = "Modificar";
            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreDocente.Text,
               "Eliminando Docente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosAlumnos(
                    new String[] { idDocente.Text, "", "", "", "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void txtBuscarDocentes_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarDocentes.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void filtrarDatos(String valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;
                switch (cboBuscarDocentes.SelectedIndex)
                {
                    case 0: //codigo
                       objDv.RowFilter = "codigo like '%" + valor + "%'";
                        break;

                    case 1: //nombre
                        objDv.RowFilter = "nombre like '%" + valor + "%'";
                        break;
                    case 2: //especialidad
                        objDv.RowFilter = "especialidad like '%" + valor + "%'";
                        break;
                }
                grdDocentes.DataSource = objDv;
                seleccionarDocente();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void seleccionarDocente()

        {
            try
            {
                if (grdDocentes.CurrentRow == null)
                {
                    return;
                }
                string id = grdDocentes.CurrentRow.Cells["id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        
        }

        private void grdDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarDocente();
        }
    }
}



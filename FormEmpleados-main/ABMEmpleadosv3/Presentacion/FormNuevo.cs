using ABMEmpleadosv3.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMEmpleadosv3.Presentacion
{
    public partial class FormNuevo : Form
    {
        public FormNuevo()
        {
            InitializeComponent();
        }
    private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            //CargaCombo(cbDocumento, "Tipos_doc");
        }
        private void CargaCombo(ComboBox combo, string nombreTabla)
        {
            //DataTable tabla = oBD.ConsultarTabla(nombreTabla);
            //combo.DataSource = tabla;
            //combo.ValueMember = tabla.Columns[0].ColumnName;
            //combo.DisplayMember = tabla.Columns[1].ColumnName;
            //combo.DropDownStyle = ComboBoxStyle.DropDownList;
            //combo.SelectedIndex = -1;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void txbNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConexionBD oEmpleadoDB = new ConexionBD();
            try
            {
                oEmpleadoDB.Add( txtNombres.Text, txtApellidos.Text);
                this.Close();
                //NO TERMINADO
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar " + ex.Message);
            }
        }
    }
}

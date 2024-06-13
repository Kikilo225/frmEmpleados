using ABMEmpleadosv3.Datos;
using ABMEmpleadosv3.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMEmpleadosv3
{
    public partial class formEmpleados : Form
    {
        public formEmpleados()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            ConexionBD oEmpleadoDB = new ConexionBD();
            dataGridView1.DataSource = oEmpleadoDB.Get();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevo nuevo = new FormNuevo();
            nuevo.ShowDialog();
            Refrescar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}

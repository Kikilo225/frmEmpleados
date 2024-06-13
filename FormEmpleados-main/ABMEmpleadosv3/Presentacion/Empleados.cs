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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevo nuevo = new FormNuevo();

            nuevo.FormClosed += (s, args) => this.Show();

            nuevo.Show();

            this.Hide();
        }
    }
}

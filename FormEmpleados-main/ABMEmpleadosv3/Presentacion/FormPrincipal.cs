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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var desicion = MessageBox.Show("¿Seguro que deseas salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (desicion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void empleado1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEmpleados formEmpleados = new formEmpleados();

            formEmpleados.FormClosed += (s, args) => this.Show();

            formEmpleados.Show();

            this.Hide();
        }

        private void facundoNicolasGuzmánOlariagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFNGO formFNGO = new FrmFNGO();

            formFNGO.FormClosed += (s, args) => this.Show();

            formFNGO.Show();

            this.Hide();
        }

        private void sosaFedericoJavierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSFJ formSFJ = new FrmSFJ();

            formSFJ.FormClosed += (s, args) => this.Show();

            formSFJ.Show();

            this.Hide();
        }

        private void agustínEzequielArizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAEZ formAEZ = new FrmAEZ();

            formAEZ.FormClosed += (s, args) => this.Show();

            formAEZ.Show();

            this.Hide();
        }

        private void javierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJlG formJIG = new FrmJlG();

            formJIG.FormClosed += (s, args) => this.Show();

            formJIG.Show();

            this.Hide();
        }

        private void chaconMAximoAgustínToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCMA formCMA = new FrmCMA();

            formCMA.FormClosed += (s, args) => this.Show();

            formCMA.Show();

            this.Hide();
        }
    }
}

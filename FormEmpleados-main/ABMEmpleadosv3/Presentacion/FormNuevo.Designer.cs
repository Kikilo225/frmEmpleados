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
    partial class FormNuevo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.cbBarrio = new System.Windows.Forms.ComboBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.cbDocumento = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txbContacto = new System.Windows.Forms.TextBox();
            this.txbCargo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barrrio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo Contacto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Contacto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha ingreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Fecha Salida";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sucursal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Cargo";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(116, 37);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(135, 20);
            this.txtNombres.TabIndex = 0;
            this.txtNombres.TextChanged += new System.EventHandler(this.txbNombres_TextChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(345, 37);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(135, 20);
            this.txtApellidos.TabIndex = 1;
            // 
            // cbBarrio
            // 
            this.cbBarrio.FormattingEnabled = true;
            this.cbBarrio.Location = new System.Drawing.Point(116, 72);
            this.cbBarrio.Name = "cbBarrio";
            this.cbBarrio.Size = new System.Drawing.Size(135, 21);
            this.cbBarrio.TabIndex = 2;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(345, 72);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(135, 20);
            this.txbDireccion.TabIndex = 3;
            // 
            // cbDocumento
            // 
            this.cbDocumento.FormattingEnabled = true;
            this.cbDocumento.Location = new System.Drawing.Point(116, 108);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(135, 21);
            this.cbDocumento.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(116, 144);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(135, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(116, 181);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(135, 20);
            this.dtpIngreso.TabIndex = 8;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(116, 216);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(135, 20);
            this.dtpSalida.TabIndex = 9;
            // 
            // cbSucursal
            // 
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(116, 256);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(135, 21);
            this.cbSucursal.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(345, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 20);
            this.textBox4.TabIndex = 5;
            // 
            // txbContacto
            // 
            this.txbContacto.Location = new System.Drawing.Point(345, 144);
            this.txbContacto.Name = "txbContacto";
            this.txbContacto.Size = new System.Drawing.Size(135, 20);
            this.txbContacto.TabIndex = 7;
            // 
            // txbCargo
            // 
            this.txbCargo.Location = new System.Drawing.Point(345, 256);
            this.txbCargo.Name = "txbCargo";
            this.txbCargo.Size = new System.Drawing.Size(135, 20);
            this.txbCargo.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(187, 330);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 26);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(284, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 26);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 396);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbCargo);
            this.Controls.Add(this.txbContacto);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cbDocumento);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.cbBarrio);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private ComboBox cbBarrio;
        private TextBox txbDireccion;
        private ComboBox cbDocumento;
        private ComboBox comboBox3;
        private DateTimePicker dtpIngreso;
        private DateTimePicker dtpSalida;
        private ComboBox cbSucursal;
        private TextBox textBox4;
        private TextBox txbContacto;
        private TextBox txbCargo;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}

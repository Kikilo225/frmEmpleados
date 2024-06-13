namespace ABMEmpleadosv3.Presentacion
{
    partial class FrmFNGO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFNGO));
            this.button2 = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.legajo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(26, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 235);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salir.Location = new System.Drawing.Point(410, 216);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(107, 31);
            this.salir.TabIndex = 10;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            // 
            // legajo
            // 
            this.legajo.AutoSize = true;
            this.legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.legajo.Location = new System.Drawing.Point(262, 67);
            this.legajo.Name = "legajo";
            this.legajo.Size = new System.Drawing.Size(105, 20);
            this.legajo.TabIndex = 9;
            this.legajo.Text = "412304 - 1w2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Guzmán Olariaga Facundo Nicolás";
            // 
            // FrmFNGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 258);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.legajo);
            this.Controls.Add(this.label1);
            this.Name = "FrmFNGO";
            this.Text = "FrmFNGO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label legajo;
        private System.Windows.Forms.Label label1;
    }
}
namespace ABMEmpleadosv3.Presentacion
{
    partial class FrmJlG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJlG));
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
            this.button2.Location = new System.Drawing.Point(29, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 289);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salir.Location = new System.Drawing.Point(409, 270);
            this.salir.Margin = new System.Windows.Forms.Padding(4);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(143, 38);
            this.salir.TabIndex = 6;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // legajo
            // 
            this.legajo.AutoSize = true;
            this.legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.legajo.Location = new System.Drawing.Point(344, 86);
            this.legajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.legajo.Name = "legajo";
            this.legajo.Size = new System.Drawing.Size(131, 25);
            this.legajo.TabIndex = 5;
            this.legajo.Text = "405677 - 1w1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Julian Lautaro Garay";
            // 
            // FrmJlG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.legajo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmJlG";
            this.Text = "FrmJlG";
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
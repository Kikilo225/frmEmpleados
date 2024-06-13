namespace ABMEmpleadosv3.Presentacion
{
    partial class FrmAEZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAEZ));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.legajo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(23, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 235);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(322, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // legajo
            // 
            this.legajo.AutoSize = true;
            this.legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.legajo.Location = new System.Drawing.Point(261, 82);
            this.legajo.Name = "legajo";
            this.legajo.Size = new System.Drawing.Size(105, 20);
            this.legajo.TabIndex = 6;
            this.legajo.Text = "405120 - 1w1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agustín Ezequiel Ariza";
            // 
            // FrmAEZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.legajo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "FrmAEZ";
            this.Text = "FrmAEZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label legajo;
        private System.Windows.Forms.Label label1;
    }
}
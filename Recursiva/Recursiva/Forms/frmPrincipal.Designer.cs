namespace Recursiva
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ofdCsv = new System.Windows.Forms.OpenFileDialog();
            this.btnSelec = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblUno = new System.Windows.Forms.Label();
            this.lblDos = new System.Windows.Forms.Label();
            this.btnListados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el archivo";
            // 
            // ofdCsv
            // 
            this.ofdCsv.FileName = "openFileDialog1";
            // 
            // btnSelec
            // 
            this.btnSelec.Location = new System.Drawing.Point(162, 66);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(256, 23);
            this.btnSelec.TabIndex = 2;
            this.btnSelec.Text = "Seleccionar";
            this.btnSelec.UseVisualStyleBackColor = true;
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click_1);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(47, 131);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 13);
            this.lblResultados.TabIndex = 3;
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.Location = new System.Drawing.Point(22, 131);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(0, 13);
            this.lblUno.TabIndex = 4;
            // 
            // lblDos
            // 
            this.lblDos.AutoSize = true;
            this.lblDos.Location = new System.Drawing.Point(22, 159);
            this.lblDos.Name = "lblDos";
            this.lblDos.Size = new System.Drawing.Size(0, 13);
            this.lblDos.TabIndex = 8;
            // 
            // btnListados
            // 
            this.btnListados.Location = new System.Drawing.Point(343, 154);
            this.btnListados.Name = "btnListados";
            this.btnListados.Size = new System.Drawing.Size(75, 23);
            this.btnListados.TabIndex = 9;
            this.btnListados.Text = "Ver listados";
            this.btnListados.UseVisualStyleBackColor = true;
            this.btnListados.Click += new System.EventHandler(this.btnListados_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cargue un archivo .csv para procesar";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 197);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListados);
            this.Controls.Add(this.lblDos);
            this.Controls.Add(this.lblUno);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnSelec);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.Text = "Desafío Recursiva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdCsv;
        private System.Windows.Forms.Button btnSelec;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblUno;
        private System.Windows.Forms.Label lblDos;
        private System.Windows.Forms.Button btnListados;
        private System.Windows.Forms.Label label2;
    }
}


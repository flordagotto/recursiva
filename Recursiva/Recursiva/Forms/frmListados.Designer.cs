namespace Recursiva.Forms
{
    partial class frmListados
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
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv4 = new System.Windows.Forms.DataGridView();
            this._nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv5 = new System.Windows.Forms.DataGridView();
            this.club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.edad,
            this.equipo});
            this.dgv3.Location = new System.Drawing.Point(13, 39);
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(300, 399);
            this.dgv3.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // equipo
            // 
            this.equipo.HeaderText = "Equipo";
            this.equipo.Name = "equipo";
            this.equipo.ReadOnly = true;
            // 
            // dgv4
            // 
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._nombre});
            this.dgv4.Location = new System.Drawing.Point(319, 39);
            this.dgv4.Name = "dgv4";
            this.dgv4.Size = new System.Drawing.Size(164, 399);
            this.dgv4.TabIndex = 1;
            // 
            // _nombre
            // 
            this._nombre.HeaderText = "Nombre";
            this._nombre.Name = "_nombre";
            this._nombre.Width = 120;
            // 
            // dgv5
            // 
            this.dgv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.club,
            this.cantSocio,
            this.prom,
            this.min,
            this.max});
            this.dgv5.Location = new System.Drawing.Point(489, 39);
            this.dgv5.Name = "dgv5";
            this.dgv5.Size = new System.Drawing.Size(379, 399);
            this.dgv5.TabIndex = 2;
            // 
            // club
            // 
            this.club.HeaderText = "Equipo";
            this.club.Name = "club";
            // 
            // cantSocio
            // 
            this.cantSocio.HeaderText = "Cantidad de socios";
            this.cantSocio.Name = "cantSocio";
            this.cantSocio.ReadOnly = true;
            // 
            // prom
            // 
            this.prom.HeaderText = "Promedio edad";
            this.prom.Name = "prom";
            this.prom.ReadOnly = true;
            // 
            // min
            // 
            this.min.HeaderText = "Menor edad";
            this.min.Name = "min";
            this.min.ReadOnly = true;
            // 
            // max
            // 
            this.max.HeaderText = "Mayor edad";
            this.max.Name = "max";
            this.max.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado punto 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listado punto 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Listado punto 5";
            // 
            // frmListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv5);
            this.Controls.Add(this.dgv4);
            this.Controls.Add(this.dgv3);
            this.Name = "frmListados";
            this.Text = "Listados";
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.DataGridView dgv4;
        private System.Windows.Forms.DataGridView dgv5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn club;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn prom;
        private System.Windows.Forms.DataGridViewTextBoxColumn min;
        private System.Windows.Forms.DataGridViewTextBoxColumn max;
    }
}
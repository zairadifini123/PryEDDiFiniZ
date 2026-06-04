namespace PryEDDiFiniZ
{
    partial class frmBdRepaso
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblOperacionARealizar = new System.Windows.Forms.Label();
            this.dgvOperacionARealizar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacionARealizar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operación a realizar en la base de datos";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Items.AddRange(new object[] {
            "Proyeccion simple",
            "Juntar",
            "Interseccion",
            "Por convolución",
            "Diferencia"});
            this.cmbOperacion.Location = new System.Drawing.Point(291, 18);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(399, 21);
            this.cmbOperacion.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(696, 18);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(92, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblOperacionARealizar
            // 
            this.lblOperacionARealizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOperacionARealizar.Location = new System.Drawing.Point(15, 54);
            this.lblOperacionARealizar.Name = "lblOperacionARealizar";
            this.lblOperacionARealizar.Size = new System.Drawing.Size(773, 94);
            this.lblOperacionARealizar.TabIndex = 3;
            // 
            // dgvOperacionARealizar
            // 
            this.dgvOperacionARealizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperacionARealizar.Location = new System.Drawing.Point(15, 163);
            this.dgvOperacionARealizar.Name = "dgvOperacionARealizar";
            this.dgvOperacionARealizar.Size = new System.Drawing.Size(773, 275);
            this.dgvOperacionARealizar.TabIndex = 4;
            // 
            // frmBdRepaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOperacionARealizar);
            this.Controls.Add(this.lblOperacionARealizar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.label1);
            this.Name = "frmBdRepaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de Operaciones de Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacionARealizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblOperacionARealizar;
        private System.Windows.Forms.DataGridView dgvOperacionARealizar;
    }
}
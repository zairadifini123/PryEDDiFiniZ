namespace PryEDDiFiniZ
{
    partial class frmBdConsultaTablas
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
            this.dgvConsultaTablas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTablaBaseDatos = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaTablas
            // 
            this.dgvConsultaTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaTablas.Location = new System.Drawing.Point(12, 38);
            this.dgvConsultaTablas.Name = "dgvConsultaTablas";
            this.dgvConsultaTablas.Size = new System.Drawing.Size(776, 331);
            this.dgvConsultaTablas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabla de la base de datos:";
            // 
            // cmbTablaBaseDatos
            // 
            this.cmbTablaBaseDatos.FormattingEnabled = true;
            this.cmbTablaBaseDatos.Location = new System.Drawing.Point(585, 379);
            this.cmbTablaBaseDatos.Name = "cmbTablaBaseDatos";
            this.cmbTablaBaseDatos.Size = new System.Drawing.Size(97, 21);
            this.cmbTablaBaseDatos.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(688, 379);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 21);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // frmBdConsultaTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbTablaBaseDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultaTablas);
            this.Name = "frmBdConsultaTablas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBdConsultaTablas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaTablas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTablaBaseDatos;
        private System.Windows.Forms.Button btnListar;
    }
}
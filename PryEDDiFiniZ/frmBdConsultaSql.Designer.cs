namespace PryEDDiFiniZ
{
    partial class frmBdConsultaSql
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
            this.txtConsultaSql = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvConsultaSql = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSql)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta en SQL:";
            // 
            // txtConsultaSql
            // 
            this.txtConsultaSql.Location = new System.Drawing.Point(12, 37);
            this.txtConsultaSql.Multiline = true;
            this.txtConsultaSql.Name = "txtConsultaSql";
            this.txtConsultaSql.Size = new System.Drawing.Size(771, 132);
            this.txtConsultaSql.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(708, 175);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvConsultaSql
            // 
            this.dgvConsultaSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaSql.Location = new System.Drawing.Point(12, 204);
            this.dgvConsultaSql.Name = "dgvConsultaSql";
            this.dgvConsultaSql.Size = new System.Drawing.Size(771, 234);
            this.dgvConsultaSql.TabIndex = 3;
            // 
            // frmBdConsultaSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvConsultaSql);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtConsultaSql);
            this.Controls.Add(this.label1);
            this.Name = "frmBdConsultaSql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta en la base de datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsultaSql;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvConsultaSql;
    }
}
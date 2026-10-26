namespace ProyectoPOOreal
{
    partial class FormVerTablaPosiciones
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
            this.dgvPosiciones = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCampeon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPosiciones
            // 
            this.dgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiciones.Location = new System.Drawing.Point(205, 12);
            this.dgvPosiciones.Name = "dgvPosiciones";
            this.dgvPosiciones.Size = new System.Drawing.Size(583, 426);
            this.dgvPosiciones.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 30);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(187, 72);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Ver Tabla Posiciones";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCampeon
            // 
            this.btnCampeon.Location = new System.Drawing.Point(12, 108);
            this.btnCampeon.Name = "btnCampeon";
            this.btnCampeon.Size = new System.Drawing.Size(187, 72);
            this.btnCampeon.TabIndex = 4;
            this.btnCampeon.Text = "Ver Tabla Posiciones";
            this.btnCampeon.UseVisualStyleBackColor = true;
            this.btnCampeon.Click += new System.EventHandler(this.btnCampeon_Click);
            // 
            // FormVerTablaPosiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCampeon);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvPosiciones);
            this.Name = "FormVerTablaPosiciones";
            this.Text = "FormVerTablaPosiciones";
            this.Load += new System.EventHandler(this.FormVerTablaPosiciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosiciones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCampeon;
    }
}
namespace ProyectoPOOreal
{
    partial class FormIniciarCamp
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
            this.btnIniCamp = new System.Windows.Forms.Button();
            this.dgvPartidos = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniCamp
            // 
            this.btnIniCamp.Location = new System.Drawing.Point(28, 71);
            this.btnIniCamp.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniCamp.Name = "btnIniCamp";
            this.btnIniCamp.Size = new System.Drawing.Size(157, 87);
            this.btnIniCamp.TabIndex = 3;
            this.btnIniCamp.Text = "Iniciar Campeonato";
            this.btnIniCamp.UseVisualStyleBackColor = true;
            this.btnIniCamp.Click += new System.EventHandler(this.btnIniCamp_Click);
            // 
            // dgvPartidos
            // 
            this.dgvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidos.Location = new System.Drawing.Point(212, 12);
            this.dgvPartidos.Name = "dgvPartidos";
            this.dgvPartidos.Size = new System.Drawing.Size(576, 426);
            this.dgvPartidos.TabIndex = 4;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(28, 187);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(157, 87);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar Campeonato";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FormIniciarCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvPartidos);
            this.Controls.Add(this.btnIniCamp);
            this.Name = "FormIniciarCamp";
            this.Text = "FormIniciarCamp";
            this.Load += new System.EventHandler(this.FormIniciarCamp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniCamp;
        private System.Windows.Forms.DataGridView dgvPartidos;
        private System.Windows.Forms.Button btnBorrar;
    }
}
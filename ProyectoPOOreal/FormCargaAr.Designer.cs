namespace ProyectoPOOreal
{
    partial class FormCargaAr
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
            this.gbArbitro = new System.Windows.Forms.GroupBox();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbArbitro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbArbitro
            // 
            this.gbArbitro.Controls.Add(this.txt_matricula);
            this.gbArbitro.Controls.Add(this.lblMatricula);
            this.gbArbitro.Controls.Add(this.txt_dni);
            this.gbArbitro.Controls.Add(this.lblDNI);
            this.gbArbitro.Controls.Add(this.txtApellido);
            this.gbArbitro.Controls.Add(this.lblApellido);
            this.gbArbitro.Controls.Add(this.txtNombre);
            this.gbArbitro.Controls.Add(this.lblNombre);
            this.gbArbitro.Controls.Add(this.btnCargar);
            this.gbArbitro.Location = new System.Drawing.Point(13, 13);
            this.gbArbitro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbArbitro.Name = "gbArbitro";
            this.gbArbitro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbArbitro.Size = new System.Drawing.Size(336, 302);
            this.gbArbitro.TabIndex = 40;
            this.gbArbitro.TabStop = false;
            this.gbArbitro.Text = "Jugador";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(147, 177);
            this.txt_matricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(160, 22);
            this.txt_matricula.TabIndex = 38;
            this.txt_matricula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_matricula_KeyDown);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(8, 181);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(122, 16);
            this.lblMatricula.TabIndex = 37;
            this.lblMatricula.Text = "Matricula de Árbitro";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(147, 128);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(160, 22);
            this.txt_dni.TabIndex = 36;
            this.txt_dni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_dni_KeyDown);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(56, 132);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(30, 16);
            this.lblDNI.TabIndex = 35;
            this.lblDNI.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(147, 79);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(160, 22);
            this.txtApellido.TabIndex = 34;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(56, 82);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 16);
            this.lblApellido.TabIndex = 33;
            this.lblApellido.Text = "Nombre ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 31);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 22);
            this.txtNombre.TabIndex = 20;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(56, 34);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre ";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(208, 229);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 57);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "Cargar Jugador";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 529);
            this.dataGridView1.TabIndex = 41;
            // 
            // FormCargaAr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbArbitro);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCargaAr";
            this.Text = "FormCargaAr";
            this.Load += new System.EventHandler(this.FormCargaAr_Load);
            this.gbArbitro.ResumeLayout(false);
            this.gbArbitro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbArbitro;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
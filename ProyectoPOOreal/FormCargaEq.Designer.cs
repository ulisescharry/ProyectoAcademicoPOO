namespace ProyectoPOOreal
{
    partial class FormCargaEq
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
            this.btnIniciarCarga = new System.Windows.Forms.Button();
            this.gbJugador = new System.Windows.Forms.GroupBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.gbEquipo = new System.Windows.Forms.GroupBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtnombrest = new System.Windows.Forms.TextBox();
            this.lblNomEst = new System.Windows.Forms.Label();
            this.Btn_CargEst = new System.Windows.Forms.Button();
            this.gbJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbEquipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarCarga
            // 
            this.btnIniciarCarga.Location = new System.Drawing.Point(165, 80);
            this.btnIniciarCarga.Name = "btnIniciarCarga";
            this.btnIniciarCarga.Size = new System.Drawing.Size(75, 49);
            this.btnIniciarCarga.TabIndex = 40;
            this.btnIniciarCarga.Text = "Iniciar Carga de Equipo";
            this.btnIniciarCarga.UseVisualStyleBackColor = true;
            this.btnIniciarCarga.Click += new System.EventHandler(this.btnIniciarCarga_Click_1);
            // 
            // gbJugador
            // 
            this.gbJugador.Controls.Add(this.txt_dni);
            this.gbJugador.Controls.Add(this.label6);
            this.gbJugador.Controls.Add(this.txtApellido);
            this.gbJugador.Controls.Add(this.label5);
            this.gbJugador.Controls.Add(this.txtNombreJugador);
            this.gbJugador.Controls.Add(this.label2);
            this.gbJugador.Controls.Add(this.btnCargar);
            this.gbJugador.Location = new System.Drawing.Point(8, 135);
            this.gbJugador.Name = "gbJugador";
            this.gbJugador.Size = new System.Drawing.Size(256, 201);
            this.gbJugador.TabIndex = 39;
            this.gbJugador.TabStop = false;
            this.gbJugador.Text = "Jugador";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(102, 104);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(121, 20);
            this.txt_dni.TabIndex = 36;
            this.txt_dni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_dni_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(102, 67);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nombre ";
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Location = new System.Drawing.Point(102, 24);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(121, 20);
            this.txtNombreJugador.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre ";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(156, 141);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 46);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "Cargar Jugador";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre del equipo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(521, 411);
            this.dataGridView1.TabIndex = 36;
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(140, 54);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEquipo.TabIndex = 35;
            // 
            // gbEquipo
            // 
            this.gbEquipo.Controls.Add(this.txtCiudad);
            this.gbEquipo.Controls.Add(this.lblCiudad);
            this.gbEquipo.Controls.Add(this.txtnombrest);
            this.gbEquipo.Controls.Add(this.lblNomEst);
            this.gbEquipo.Controls.Add(this.Btn_CargEst);
            this.gbEquipo.Location = new System.Drawing.Point(8, 342);
            this.gbEquipo.Name = "gbEquipo";
            this.gbEquipo.Size = new System.Drawing.Size(256, 153);
            this.gbEquipo.TabIndex = 41;
            this.gbEquipo.TabStop = false;
            this.gbEquipo.Text = "Estadio";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(102, 67);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(121, 20);
            this.txtCiudad.TabIndex = 34;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(42, 70);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 33;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtnombrest
            // 
            this.txtnombrest.Location = new System.Drawing.Point(102, 24);
            this.txtnombrest.Name = "txtnombrest";
            this.txtnombrest.Size = new System.Drawing.Size(121, 20);
            this.txtnombrest.TabIndex = 20;
            // 
            // lblNomEst
            // 
            this.lblNomEst.AutoSize = true;
            this.lblNomEst.Location = new System.Drawing.Point(6, 27);
            this.lblNomEst.Name = "lblNomEst";
            this.lblNomEst.Size = new System.Drawing.Size(47, 13);
            this.lblNomEst.TabIndex = 21;
            this.lblNomEst.Text = "Nombre ";
            // 
            // Btn_CargEst
            // 
            this.Btn_CargEst.Location = new System.Drawing.Point(156, 100);
            this.Btn_CargEst.Name = "Btn_CargEst";
            this.Btn_CargEst.Size = new System.Drawing.Size(75, 46);
            this.Btn_CargEst.TabIndex = 18;
            this.Btn_CargEst.Text = "Cargar Jugador";
            this.Btn_CargEst.UseVisualStyleBackColor = true;
            this.Btn_CargEst.Click += new System.EventHandler(this.Btn_CargEst_Click);
            // 
            // FormCargaEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 526);
            this.Controls.Add(this.gbEquipo);
            this.Controls.Add(this.btnIniciarCarga);
            this.Controls.Add(this.gbJugador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNombreEquipo);
            this.Name = "FormCargaEq";
            this.Text = "Carga Equipo";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.gbJugador.ResumeLayout(false);
            this.gbJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbEquipo.ResumeLayout(false);
            this.gbEquipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarCarga;
        private System.Windows.Forms.GroupBox gbJugador;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbEquipo;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtnombrest;
        private System.Windows.Forms.Label lblNomEst;
        private System.Windows.Forms.Button Btn_CargEst;
    }
}
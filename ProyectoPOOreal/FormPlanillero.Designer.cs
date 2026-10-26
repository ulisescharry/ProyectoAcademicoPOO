namespace ProyectoPOOreal
{
    partial class FormPlanillero
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
            this.cmbPartidos = new System.Windows.Forms.ComboBox();
            this.cmbJugadores = new System.Windows.Forms.ComboBox();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.nudMinuto = new System.Windows.Forms.NumericUpDown();
            this.txtCausa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbJornadas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPosicion = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.listEventos = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnReprogPartido = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnIniRepro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuto)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPartidos
            // 
            this.cmbPartidos.FormattingEnabled = true;
            this.cmbPartidos.Location = new System.Drawing.Point(91, 62);
            this.cmbPartidos.Name = "cmbPartidos";
            this.cmbPartidos.Size = new System.Drawing.Size(148, 21);
            this.cmbPartidos.TabIndex = 0;
            this.cmbPartidos.SelectedIndexChanged += new System.EventHandler(this.cmbPartidos_SelectedIndexChanged);
            // 
            // cmbJugadores
            // 
            this.cmbJugadores.FormattingEnabled = true;
            this.cmbJugadores.Location = new System.Drawing.Point(91, 104);
            this.cmbJugadores.Name = "cmbJugadores";
            this.cmbJugadores.Size = new System.Drawing.Size(148, 21);
            this.cmbJugadores.TabIndex = 1;
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(91, 163);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(148, 21);
            this.cmbTipoEvento.TabIndex = 2;
            this.cmbTipoEvento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEvento_SelectedIndexChanged);
            // 
            // nudMinuto
            // 
            this.nudMinuto.Location = new System.Drawing.Point(91, 211);
            this.nudMinuto.Name = "nudMinuto";
            this.nudMinuto.Size = new System.Drawing.Size(148, 20);
            this.nudMinuto.TabIndex = 3;
            // 
            // txtCausa
            // 
            this.txtCausa.Location = new System.Drawing.Point(91, 257);
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.Size = new System.Drawing.Size(148, 20);
            this.txtCausa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Partidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jugadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo Evento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Minuto Evento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Causa Evento";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(21, 304);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(218, 57);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar Evento";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbJornadas
            // 
            this.cmbJornadas.FormattingEnabled = true;
            this.cmbJornadas.Location = new System.Drawing.Point(306, 62);
            this.cmbJornadas.Name = "cmbJornadas";
            this.cmbJornadas.Size = new System.Drawing.Size(148, 21);
            this.cmbJornadas.TabIndex = 11;
            this.cmbJornadas.SelectedIndexChanged += new System.EventHandler(this.cmbJornadas_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Jornada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Posición";
            // 
            // cmbPosicion
            // 
            this.cmbPosicion.FormattingEnabled = true;
            this.cmbPosicion.Location = new System.Drawing.Point(306, 104);
            this.cmbPosicion.Name = "cmbPosicion";
            this.cmbPosicion.Size = new System.Drawing.Size(148, 21);
            this.cmbPosicion.TabIndex = 13;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(261, 304);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(218, 57);
            this.btnFinalizar.TabIndex = 15;
            this.btnFinalizar.Text = "Finalizar carga del partido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(258, 163);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(218, 57);
            this.btnPosicion.TabIndex = 16;
            this.btnPosicion.Text = "Guardar posición para el partido";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // listEventos
            // 
            this.listEventos.FormattingEnabled = true;
            this.listEventos.Location = new System.Drawing.Point(487, 92);
            this.listEventos.Name = "listEventos";
            this.listEventos.Size = new System.Drawing.Size(295, 342);
            this.listEventos.TabIndex = 17;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(483, 57);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(60, 24);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = "label8";
            // 
            // btnReprogPartido
            // 
            this.btnReprogPartido.Location = new System.Drawing.Point(358, 394);
            this.btnReprogPartido.Name = "btnReprogPartido";
            this.btnReprogPartido.Size = new System.Drawing.Size(121, 40);
            this.btnReprogPartido.TabIndex = 19;
            this.btnReprogPartido.Text = "button1";
            this.btnReprogPartido.UseVisualStyleBackColor = true;
            this.btnReprogPartido.Click += new System.EventHandler(this.btnReprogPartido_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 402);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // BtnIniRepro
            // 
            this.BtnIniRepro.Location = new System.Drawing.Point(16, 394);
            this.BtnIniRepro.Name = "BtnIniRepro";
            this.BtnIniRepro.Size = new System.Drawing.Size(121, 40);
            this.BtnIniRepro.TabIndex = 21;
            this.BtnIniRepro.Text = "button1";
            this.BtnIniRepro.UseVisualStyleBackColor = true;
            this.BtnIniRepro.Click += new System.EventHandler(this.BtnIniRepro_Click);
            // 
            // FormPlanillero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnIniRepro);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnReprogPartido);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.listEventos);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbPosicion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbJornadas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCausa);
            this.Controls.Add(this.nudMinuto);
            this.Controls.Add(this.cmbTipoEvento);
            this.Controls.Add(this.cmbJugadores);
            this.Controls.Add(this.cmbPartidos);
            this.Name = "FormPlanillero";
            this.Text = "FormPlanillero";
            this.Load += new System.EventHandler(this.FormPlanillero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPartidos;
        private System.Windows.Forms.ComboBox cmbJugadores;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.NumericUpDown nudMinuto;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbJornadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPosicion;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.ListBox listEventos;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnReprogPartido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnIniRepro;
    }
}
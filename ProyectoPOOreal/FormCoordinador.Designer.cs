namespace ProyectoPOOreal
{
    partial class FormCoordinador
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
            this.cmb_idioma = new System.Windows.Forms.ComboBox();
            this.lbl_idioma = new System.Windows.Forms.Label();
            this.btn_equipo = new System.Windows.Forms.Button();
            this.btn_arbitro = new System.Windows.Forms.Button();
            this.btn_estadio = new System.Windows.Forms.Button();
            this.Btn_IniCamp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_idioma
            // 
            this.cmb_idioma.FormattingEnabled = true;
            this.cmb_idioma.Items.AddRange(new object[] {
            "Español",
            "English"});
            this.cmb_idioma.Location = new System.Drawing.Point(16, 31);
            this.cmb_idioma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_idioma.Name = "cmb_idioma";
            this.cmb_idioma.Size = new System.Drawing.Size(160, 24);
            this.cmb_idioma.TabIndex = 34;
            this.cmb_idioma.SelectedIndexChanged += new System.EventHandler(this.cmb_idioma_SelectedIndexChanged);
            // 
            // lbl_idioma
            // 
            this.lbl_idioma.AutoSize = true;
            this.lbl_idioma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_idioma.Location = new System.Drawing.Point(16, 11);
            this.lbl_idioma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idioma.Name = "lbl_idioma";
            this.lbl_idioma.Size = new System.Drawing.Size(56, 16);
            this.lbl_idioma.TabIndex = 35;
            this.lbl_idioma.Text = "Nombre";
            // 
            // btn_equipo
            // 
            this.btn_equipo.Location = new System.Drawing.Point(20, 92);
            this.btn_equipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_equipo.Name = "btn_equipo";
            this.btn_equipo.Size = new System.Drawing.Size(161, 69);
            this.btn_equipo.TabIndex = 36;
            this.btn_equipo.Text = "button1";
            this.btn_equipo.UseVisualStyleBackColor = true;
            this.btn_equipo.Click += new System.EventHandler(this.btn_equipo_Click);
            // 
            // btn_arbitro
            // 
            this.btn_arbitro.Location = new System.Drawing.Point(20, 183);
            this.btn_arbitro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_arbitro.Name = "btn_arbitro";
            this.btn_arbitro.Size = new System.Drawing.Size(161, 69);
            this.btn_arbitro.TabIndex = 38;
            this.btn_arbitro.Text = "button1";
            this.btn_arbitro.UseVisualStyleBackColor = true;
            this.btn_arbitro.Click += new System.EventHandler(this.btn_arbitro_Click);
            // 
            // btn_estadio
            // 
            this.btn_estadio.Location = new System.Drawing.Point(20, 279);
            this.btn_estadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_estadio.Name = "btn_estadio";
            this.btn_estadio.Size = new System.Drawing.Size(161, 69);
            this.btn_estadio.TabIndex = 39;
            this.btn_estadio.Text = "button1";
            this.btn_estadio.UseVisualStyleBackColor = true;
            // 
            // Btn_IniCamp
            // 
            this.Btn_IniCamp.Location = new System.Drawing.Point(260, 31);
            this.Btn_IniCamp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_IniCamp.Name = "Btn_IniCamp";
            this.Btn_IniCamp.Size = new System.Drawing.Size(161, 69);
            this.Btn_IniCamp.TabIndex = 41;
            this.Btn_IniCamp.UseVisualStyleBackColor = true;
            this.Btn_IniCamp.Click += new System.EventHandler(this.Btn_IniCamp_Click);
            // 
            // FormCoordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 686);
            this.Controls.Add(this.Btn_IniCamp);
            this.Controls.Add(this.btn_estadio);
            this.Controls.Add(this.btn_arbitro);
            this.Controls.Add(this.btn_equipo);
            this.Controls.Add(this.cmb_idioma);
            this.Controls.Add(this.lbl_idioma);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCoordinador";
            this.Text = "FormCoordinador";
            this.Load += new System.EventHandler(this.FormCoordinador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_idioma;
        private System.Windows.Forms.Label lbl_idioma;
        private System.Windows.Forms.Button btn_equipo;
        private System.Windows.Forms.Button btn_arbitro;
        private System.Windows.Forms.Button btn_estadio;
        private System.Windows.Forms.Button Btn_IniCamp;
    }
}
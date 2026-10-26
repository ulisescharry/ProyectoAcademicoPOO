namespace ProyectoPOOreal
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Combo_Idioma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(136, 303);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(271, 22);
            this.Txt_Usuario.TabIndex = 1;
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.Location = new System.Drawing.Point(136, 367);
            this.Txt_Contraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.Size = new System.Drawing.Size(271, 22);
            this.Txt_Contraseña.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "U";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Combo_Idioma
            // 
            this.Combo_Idioma.FormattingEnabled = true;
            this.Combo_Idioma.Items.AddRange(new object[] {
            "Español",
            "English"});
            this.Combo_Idioma.Location = new System.Drawing.Point(16, 36);
            this.Combo_Idioma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Combo_Idioma.Name = "Combo_Idioma";
            this.Combo_Idioma.Size = new System.Drawing.Size(128, 24);
            this.Combo_Idioma.TabIndex = 5;
            this.Combo_Idioma.Text = "Español";
            this.Combo_Idioma.SelectedIndexChanged += new System.EventHandler(this.Combo_Idioma_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Combo_Idioma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Contraseña);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Combo_Idioma;
        private System.Windows.Forms.Label label3;
    }
}


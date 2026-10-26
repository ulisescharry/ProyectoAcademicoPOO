namespace ProyectoPOOreal
{
    partial class FormAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Combo_Idioma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Combo_Roles = new System.Windows.Forms.ComboBox();
            this.Btn_Carga = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(267, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(340, 362);
            this.dataGridView1.TabIndex = 4;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(26, 46);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(184, 20);
            this.Txt_Usuario.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Combo_Idioma
            // 
            this.Combo_Idioma.FormattingEnabled = true;
            this.Combo_Idioma.Items.AddRange(new object[] {
            "Español",
            "English"});
            this.Combo_Idioma.Location = new System.Drawing.Point(11, 25);
            this.Combo_Idioma.Name = "Combo_Idioma";
            this.Combo_Idioma.Size = new System.Drawing.Size(97, 21);
            this.Combo_Idioma.TabIndex = 0;
            this.Combo_Idioma.Text = "Español";
            this.Combo_Idioma.SelectedIndexChanged += new System.EventHandler(this.Combo_Idioma_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Combo_Roles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Usuario);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DNI";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(24, 137);
            this.txtdni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(186, 20);
            this.txtdni.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // Combo_Roles
            // 
            this.Combo_Roles.FormattingEnabled = true;
            this.Combo_Roles.Location = new System.Drawing.Point(24, 91);
            this.Combo_Roles.Name = "Combo_Roles";
            this.Combo_Roles.Size = new System.Drawing.Size(186, 21);
            this.Combo_Roles.TabIndex = 2;
            // 
            // Btn_Carga
            // 
            this.Btn_Carga.Location = new System.Drawing.Point(41, 271);
            this.Btn_Carga.Name = "Btn_Carga";
            this.Btn_Carga.Size = new System.Drawing.Size(78, 43);
            this.Btn_Carga.TabIndex = 2;
            this.Btn_Carga.Text = "button1";
            this.Btn_Carga.UseVisualStyleBackColor = true;
            this.Btn_Carga.Click += new System.EventHandler(this.Btn_Carga_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(144, 271);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(78, 43);
            this.Btn_Eliminar.TabIndex = 3;
            this.Btn_Eliminar.Text = "button1";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 406);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Carga);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Combo_Idioma);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdmin";
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Combo_Idioma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Combo_Roles;
        private System.Windows.Forms.Button Btn_Carga;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdni;
    }
}
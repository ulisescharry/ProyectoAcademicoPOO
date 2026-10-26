namespace ProyectoPOOreal
{
    partial class FormCambiarContraseña
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
            this.txtContVieja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNueCon = new System.Windows.Forms.TextBox();
            this.txtConCon = new System.Windows.Forms.TextBox();
            this.btnCambiarCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContVieja
            // 
            this.txtContVieja.Location = new System.Drawing.Point(37, 75);
            this.txtContVieja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContVieja.Name = "txtContVieja";
            this.txtContVieja.Size = new System.Drawing.Size(358, 20);
            this.txtContVieja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmación de nueva contraseña";
            // 
            // txtNueCon
            // 
            this.txtNueCon.Location = new System.Drawing.Point(37, 128);
            this.txtNueCon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNueCon.Name = "txtNueCon";
            this.txtNueCon.Size = new System.Drawing.Size(358, 20);
            this.txtNueCon.TabIndex = 4;
            // 
            // txtConCon
            // 
            this.txtConCon.Location = new System.Drawing.Point(37, 184);
            this.txtConCon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConCon.Name = "txtConCon";
            this.txtConCon.Size = new System.Drawing.Size(358, 20);
            this.txtConCon.TabIndex = 5;
            // 
            // btnCambiarCon
            // 
            this.btnCambiarCon.Location = new System.Drawing.Point(46, 224);
            this.btnCambiarCon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCambiarCon.Name = "btnCambiarCon";
            this.btnCambiarCon.Size = new System.Drawing.Size(106, 44);
            this.btnCambiarCon.TabIndex = 6;
            this.btnCambiarCon.Text = "Cambiar contraseña";
            this.btnCambiarCon.UseVisualStyleBackColor = true;
            this.btnCambiarCon.Click += new System.EventHandler(this.btnCambiarCon_Click);
            // 
            // FormCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 299);
            this.Controls.Add(this.btnCambiarCon);
            this.Controls.Add(this.txtConCon);
            this.Controls.Add(this.txtNueCon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContVieja);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCambiarContraseña";
            this.Text = "FormCambiarContraseña";
            this.Load += new System.EventHandler(this.FormCambiarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContVieja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNueCon;
        private System.Windows.Forms.TextBox txtConCon;
        private System.Windows.Forms.Button btnCambiarCon;
    }
}
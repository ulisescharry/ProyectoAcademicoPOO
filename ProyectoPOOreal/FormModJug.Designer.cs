namespace ProyectoPOOreal
{
    partial class FormModJug
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
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.txtApellidoMod = new System.Windows.Forms.TextBox();
            this.txtDNIMod = new System.Windows.Forms.TextBox();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.lblNuevoApellido = new System.Windows.Forms.Label();
            this.lblNuevoDni = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.BtnOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(130, 53);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMod.TabIndex = 0;
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Location = new System.Drawing.Point(275, 12);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.Size = new System.Drawing.Size(515, 427);
            this.dgvJugadores.TabIndex = 1;
            this.dgvJugadores.SelectionChanged += new System.EventHandler(this.dgvJugadores_SelectionChanged);
            // 
            // txtApellidoMod
            // 
            this.txtApellidoMod.Location = new System.Drawing.Point(130, 92);
            this.txtApellidoMod.Name = "txtApellidoMod";
            this.txtApellidoMod.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoMod.TabIndex = 2;
            // 
            // txtDNIMod
            // 
            this.txtDNIMod.Location = new System.Drawing.Point(130, 134);
            this.txtDNIMod.Name = "txtDNIMod";
            this.txtDNIMod.Size = new System.Drawing.Size(100, 20);
            this.txtDNIMod.TabIndex = 3;
            this.txtDNIMod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDNIMod_KeyDown);
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(35, 56);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(79, 13);
            this.lblNuevoNombre.TabIndex = 4;
            this.lblNuevoNombre.Text = "Nuevo Nombre";
            // 
            // lblNuevoApellido
            // 
            this.lblNuevoApellido.AutoSize = true;
            this.lblNuevoApellido.Location = new System.Drawing.Point(34, 99);
            this.lblNuevoApellido.Name = "lblNuevoApellido";
            this.lblNuevoApellido.Size = new System.Drawing.Size(79, 13);
            this.lblNuevoApellido.TabIndex = 5;
            this.lblNuevoApellido.Text = "Nuevo Apellido";
            // 
            // lblNuevoDni
            // 
            this.lblNuevoDni.AutoSize = true;
            this.lblNuevoDni.Location = new System.Drawing.Point(35, 141);
            this.lblNuevoDni.Name = "lblNuevoDni";
            this.lblNuevoDni.Size = new System.Drawing.Size(61, 13);
            this.lblNuevoDni.TabIndex = 6;
            this.lblNuevoDni.Text = "Nuevo DNI";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(37, 219);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 42);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // BtnOrdenar
            // 
            this.BtnOrdenar.Location = new System.Drawing.Point(145, 219);
            this.BtnOrdenar.Name = "BtnOrdenar";
            this.BtnOrdenar.Size = new System.Drawing.Size(85, 42);
            this.BtnOrdenar.TabIndex = 8;
            this.BtnOrdenar.Text = "Modificar";
            this.BtnOrdenar.UseVisualStyleBackColor = true;
            this.BtnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // FormModJug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOrdenar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblNuevoDni);
            this.Controls.Add(this.lblNuevoApellido);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.txtDNIMod);
            this.Controls.Add(this.txtApellidoMod);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.txtNombreMod);
            this.Name = "FormModJug";
            this.Text = "FormModJug";
            this.Load += new System.EventHandler(this.FormModJug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.TextBox txtApellidoMod;
        private System.Windows.Forms.TextBox txtDNIMod;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.Label lblNuevoApellido;
        private System.Windows.Forms.Label lblNuevoDni;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button BtnOrdenar;
    }
}
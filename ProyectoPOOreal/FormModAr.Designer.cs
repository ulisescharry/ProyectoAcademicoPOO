namespace ProyectoPOOreal
{
    partial class FormModAr
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNuevoDni = new System.Windows.Forms.Label();
            this.lblNuevoApellido = new System.Windows.Forms.Label();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtDNIMod = new System.Windows.Forms.TextBox();
            this.txtApellidoMod = new System.Windows.Forms.TextBox();
            this.dgvArbitros = new System.Windows.Forms.DataGridView();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.BtnOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbitros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(33, 224);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 44);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNuevoDni
            // 
            this.lblNuevoDni.AutoSize = true;
            this.lblNuevoDni.Location = new System.Drawing.Point(31, 150);
            this.lblNuevoDni.Name = "lblNuevoDni";
            this.lblNuevoDni.Size = new System.Drawing.Size(61, 13);
            this.lblNuevoDni.TabIndex = 14;
            this.lblNuevoDni.Text = "Nuevo DNI";
            // 
            // lblNuevoApellido
            // 
            this.lblNuevoApellido.AutoSize = true;
            this.lblNuevoApellido.Location = new System.Drawing.Point(30, 108);
            this.lblNuevoApellido.Name = "lblNuevoApellido";
            this.lblNuevoApellido.Size = new System.Drawing.Size(79, 13);
            this.lblNuevoApellido.TabIndex = 13;
            this.lblNuevoApellido.Text = "Nuevo Apellido";
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(31, 65);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(79, 13);
            this.lblNuevoNombre.TabIndex = 12;
            this.lblNuevoNombre.Text = "Nuevo Nombre";
            // 
            // txtDNIMod
            // 
            this.txtDNIMod.Location = new System.Drawing.Point(126, 143);
            this.txtDNIMod.Name = "txtDNIMod";
            this.txtDNIMod.Size = new System.Drawing.Size(100, 20);
            this.txtDNIMod.TabIndex = 11;
            // 
            // txtApellidoMod
            // 
            this.txtApellidoMod.Location = new System.Drawing.Point(126, 101);
            this.txtApellidoMod.Name = "txtApellidoMod";
            this.txtApellidoMod.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoMod.TabIndex = 10;
            // 
            // dgvArbitros
            // 
            this.dgvArbitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbitros.Location = new System.Drawing.Point(258, 12);
            this.dgvArbitros.Name = "dgvArbitros";
            this.dgvArbitros.Size = new System.Drawing.Size(530, 426);
            this.dgvArbitros.TabIndex = 9;
            this.dgvArbitros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArbitros_CellContentClick);
            this.dgvArbitros.SelectionChanged += new System.EventHandler(this.dgvArbitros_SelectionChanged);
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(126, 62);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMod.TabIndex = 8;
            // 
            // BtnOrdenar
            // 
            this.BtnOrdenar.Location = new System.Drawing.Point(141, 224);
            this.BtnOrdenar.Name = "BtnOrdenar";
            this.BtnOrdenar.Size = new System.Drawing.Size(85, 44);
            this.BtnOrdenar.TabIndex = 16;
            this.BtnOrdenar.Text = "Modificar";
            this.BtnOrdenar.UseVisualStyleBackColor = true;
            this.BtnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // FormModAr
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
            this.Controls.Add(this.dgvArbitros);
            this.Controls.Add(this.txtNombreMod);
            this.Name = "FormModAr";
            this.Text = "FormModAr";
            this.Load += new System.EventHandler(this.FormModAr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblNuevoDni;
        private System.Windows.Forms.Label lblNuevoApellido;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txtDNIMod;
        private System.Windows.Forms.TextBox txtApellidoMod;
        private System.Windows.Forms.DataGridView dgvArbitros;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.Button BtnOrdenar;
    }
}
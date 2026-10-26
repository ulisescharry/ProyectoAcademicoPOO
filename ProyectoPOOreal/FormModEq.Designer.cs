namespace ProyectoPOOreal
{
    partial class FormModEq
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
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.lblNomEq = new System.Windows.Forms.Label();
            this.lblNomEst = new System.Windows.Forms.Label();
            this.txtNomEq = new System.Windows.Forms.TextBox();
            this.txtNomEst = new System.Windows.Forms.TextBox();
            this.gbEstadio = new System.Windows.Forms.GroupBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnElminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.gbEstadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Location = new System.Drawing.Point(294, 13);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.Size = new System.Drawing.Size(494, 425);
            this.dgvEquipos.TabIndex = 0;
            this.dgvEquipos.SelectionChanged += new System.EventHandler(this.dgvEquipos_SelectionChanged);
            // 
            // lblNomEq
            // 
            this.lblNomEq.AutoSize = true;
            this.lblNomEq.Location = new System.Drawing.Point(43, 44);
            this.lblNomEq.Name = "lblNomEq";
            this.lblNomEq.Size = new System.Drawing.Size(35, 13);
            this.lblNomEq.TabIndex = 1;
            this.lblNomEq.Text = "label1";
            // 
            // lblNomEst
            // 
            this.lblNomEst.AutoSize = true;
            this.lblNomEst.Location = new System.Drawing.Point(12, 30);
            this.lblNomEst.Name = "lblNomEst";
            this.lblNomEst.Size = new System.Drawing.Size(35, 13);
            this.lblNomEst.TabIndex = 2;
            this.lblNomEst.Text = "label2";
            // 
            // txtNomEq
            // 
            this.txtNomEq.Location = new System.Drawing.Point(31, 60);
            this.txtNomEq.Name = "txtNomEq";
            this.txtNomEq.Size = new System.Drawing.Size(217, 20);
            this.txtNomEq.TabIndex = 3;
            // 
            // txtNomEst
            // 
            this.txtNomEst.Location = new System.Drawing.Point(15, 46);
            this.txtNomEst.Name = "txtNomEst";
            this.txtNomEst.Size = new System.Drawing.Size(183, 20);
            this.txtNomEst.TabIndex = 4;
            // 
            // gbEstadio
            // 
            this.gbEstadio.Controls.Add(this.txtCiudad);
            this.gbEstadio.Controls.Add(this.lblCiudad);
            this.gbEstadio.Controls.Add(this.lblNomEst);
            this.gbEstadio.Controls.Add(this.txtNomEst);
            this.gbEstadio.Location = new System.Drawing.Point(31, 86);
            this.gbEstadio.Name = "gbEstadio";
            this.gbEstadio.Size = new System.Drawing.Size(217, 136);
            this.gbEstadio.TabIndex = 5;
            this.gbEstadio.TabStop = false;
            this.gbEstadio.Text = "groupBox1";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(15, 96);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(183, 20);
            this.txtCiudad.TabIndex = 6;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(12, 80);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(35, 13);
            this.lblCiudad.TabIndex = 5;
            this.lblCiudad.Text = "label3";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(31, 228);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 35);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "button1";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnElminar
            // 
            this.btnElminar.Location = new System.Drawing.Point(144, 228);
            this.btnElminar.Name = "btnElminar";
            this.btnElminar.Size = new System.Drawing.Size(104, 35);
            this.btnElminar.TabIndex = 7;
            this.btnElminar.Text = "button1";
            this.btnElminar.UseVisualStyleBackColor = true;
            this.btnElminar.Click += new System.EventHandler(this.btnElminar_Click);
            // 
            // FormModEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnElminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbEstadio);
            this.Controls.Add(this.txtNomEq);
            this.Controls.Add(this.lblNomEq);
            this.Controls.Add(this.dgvEquipos);
            this.Name = "FormModEq";
            this.Text = "FormModEq";
            this.Load += new System.EventHandler(this.FormModEq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.gbEstadio.ResumeLayout(false);
            this.gbEstadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Label lblNomEq;
        private System.Windows.Forms.Label lblNomEst;
        private System.Windows.Forms.TextBox txtNomEq;
        private System.Windows.Forms.TextBox txtNomEst;
        private System.Windows.Forms.GroupBox gbEstadio;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnElminar;
    }
}
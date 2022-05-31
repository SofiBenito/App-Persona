namespace WindowsFormsPersona
{
    partial class Form1
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
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminarFisico = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminarLogico = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersona
            // 
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersona.Location = new System.Drawing.Point(12, 12);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersona.Size = new System.Drawing.Size(776, 332);
            this.dgvPersona.TabIndex = 0;
            this.dgvPersona.SizeChanged += new System.EventHandler(this.dgvPersona_SizeChanged);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(44, 350);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(113, 51);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminarFisico
            // 
            this.BtnEliminarFisico.Location = new System.Drawing.Point(327, 350);
            this.BtnEliminarFisico.Name = "BtnEliminarFisico";
            this.BtnEliminarFisico.Size = new System.Drawing.Size(113, 51);
            this.BtnEliminarFisico.TabIndex = 2;
            this.BtnEliminarFisico.Text = "Eliminar Fisico";
            this.BtnEliminarFisico.UseVisualStyleBackColor = true;
            this.BtnEliminarFisico.Click += new System.EventHandler(this.BtnEliminarFisico_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(187, 350);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(113, 51);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminarLogico
            // 
            this.BtnEliminarLogico.Location = new System.Drawing.Point(456, 351);
            this.BtnEliminarLogico.Name = "BtnEliminarLogico";
            this.BtnEliminarLogico.Size = new System.Drawing.Size(106, 50);
            this.BtnEliminarLogico.TabIndex = 4;
            this.BtnEliminarLogico.Text = "Eliminar Logico";
            this.BtnEliminarLogico.UseVisualStyleBackColor = true;
            this.BtnEliminarLogico.Click += new System.EventHandler(this.BtnEliminarLogico_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(587, 350);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(106, 50);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir\r\n";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 427);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminarLogico);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminarFisico);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dgvPersona);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminarFisico;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminarLogico;
        private System.Windows.Forms.Button BtnSalir;
    }
}


namespace WindowsFormsPersona
{
    partial class FrmAltaPersona
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.chkFallecio = new System.Windows.Forms.CheckBox();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(242, 335);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 35);
            this.BtnCancelar.TabIndex = 46;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(94, 335);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(100, 35);
            this.BtnAceptar.TabIndex = 45;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // chkFallecio
            // 
            this.chkFallecio.AutoSize = true;
            this.chkFallecio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFallecio.Location = new System.Drawing.Point(120, 299);
            this.chkFallecio.Name = "chkFallecio";
            this.chkFallecio.Size = new System.Drawing.Size(98, 17);
            this.chkFallecio.TabIndex = 44;
            this.chkFallecio.Text = "Fallecido          ";
            this.chkFallecio.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(203, 254);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 43;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(203, 221);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 42;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(203, 184);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(177, 21);
            this.cboEstadoCivil.TabIndex = 41;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(203, 148);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(177, 20);
            this.txtDocumento.TabIndex = 40;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(203, 111);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(177, 21);
            this.cboTipoDocumento.TabIndex = 39;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(203, 75);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(177, 20);
            this.txtNombres.TabIndex = 38;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(203, 39);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(177, 20);
            this.txtApellido.TabIndex = 37;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(135, 228);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 36;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(104, 191);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(62, 13);
            this.lblEstadoCivil.TabIndex = 35;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(104, 154);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 34;
            this.lblDocumento.Text = "Documento";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(80, 117);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDocumento.TabIndex = 33;
            this.lblTipoDocumento.Text = "Tipo Documento";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(117, 80);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 32;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(122, 43);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 31;
            this.lblApellido.Text = "Apellido";
            // 
            // FrmAltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 409);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.chkFallecio);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.rbtFemenino);
            this.Controls.Add(this.cboEstadoCivil);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblApellido);
            this.Name = "FrmAltaPersona";
            this.Text = "FrmAltaPersona";
            this.Load += new System.EventHandler(this.FrmAltaPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.CheckBox chkFallecio;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellido;
    }
}
namespace ControlV2
{
    partial class FrmRegistrarUsuario
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
            this.pctrBxFotografía = new System.Windows.Forms.PictureBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtBxNombres = new System.Windows.Forms.TextBox();
            this.txtBxApellidos = new System.Windows.Forms.TextBox();
            this.txtBxNúmeroDeCédula = new System.Windows.Forms.TextBox();
            this.lblNúmeroDeCédula = new System.Windows.Forms.Label();
            this.lblGénero = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtBxEdad = new System.Windows.Forms.TextBox();
            this.cmbBxGénero = new System.Windows.Forms.ComboBox();
            this.lblTeléfono = new System.Windows.Forms.Label();
            this.txtBxPrefijoTeléfono = new System.Windows.Forms.TextBox();
            this.txtBxTeléfono = new System.Windows.Forms.TextBox();
            this.lblDirección = new System.Windows.Forms.Label();
            this.txtBxDirección = new System.Windows.Forms.TextBox();
            this.lblCorreoElectrónico = new System.Windows.Forms.Label();
            this.txtBxCorreoElectrónico = new System.Windows.Forms.TextBox();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.txtBxNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtBxContraseña = new System.Windows.Forms.TextBox();
            this.chckBxVerContraseña = new System.Windows.Forms.CheckBox();
            this.cmbBxRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxFotografía)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrBxFotografía
            // 
            this.pctrBxFotografía.Image = global::ControlV2.Properties.Resources.user_3;
            this.pctrBxFotografía.Location = new System.Drawing.Point(13, 13);
            this.pctrBxFotografía.Name = "pctrBxFotografía";
            this.pctrBxFotografía.Size = new System.Drawing.Size(174, 170);
            this.pctrBxFotografía.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBxFotografía.TabIndex = 0;
            this.pctrBxFotografía.TabStop = false;
            this.pctrBxFotografía.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(193, 18);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(75, 21);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(193, 47);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(74, 21);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtBxNombres
            // 
            this.txtBxNombres.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNombres.Location = new System.Drawing.Point(274, 16);
            this.txtBxNombres.MaxLength = 20;
            this.txtBxNombres.Name = "txtBxNombres";
            this.txtBxNombres.Size = new System.Drawing.Size(238, 23);
            this.txtBxNombres.TabIndex = 3;
            this.txtBxNombres.Enter += new System.EventHandler(this.txtBxNombres_Enter_1);
            // 
            // txtBxApellidos
            // 
            this.txtBxApellidos.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxApellidos.Location = new System.Drawing.Point(274, 45);
            this.txtBxApellidos.MaxLength = 20;
            this.txtBxApellidos.Name = "txtBxApellidos";
            this.txtBxApellidos.Size = new System.Drawing.Size(238, 23);
            this.txtBxApellidos.TabIndex = 4;
            this.txtBxApellidos.Enter += new System.EventHandler(this.txtBxNombres_Enter_1);
            // 
            // txtBxNúmeroDeCédula
            // 
            this.txtBxNúmeroDeCédula.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNúmeroDeCédula.Location = new System.Drawing.Point(338, 74);
            this.txtBxNúmeroDeCédula.MaxLength = 10;
            this.txtBxNúmeroDeCédula.Name = "txtBxNúmeroDeCédula";
            this.txtBxNúmeroDeCédula.Size = new System.Drawing.Size(174, 23);
            this.txtBxNúmeroDeCédula.TabIndex = 5;
            this.txtBxNúmeroDeCédula.TextChanged += new System.EventHandler(this.txtBxNúmeroDeCédula_TextChanged);
            this.txtBxNúmeroDeCédula.Enter += new System.EventHandler(this.txtBxNombres_Enter_1);
            this.txtBxNúmeroDeCédula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxNúmeroDeCédula_KeyPress);
            // 
            // lblNúmeroDeCédula
            // 
            this.lblNúmeroDeCédula.AutoSize = true;
            this.lblNúmeroDeCédula.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmeroDeCédula.Location = new System.Drawing.Point(194, 76);
            this.lblNúmeroDeCédula.Name = "lblNúmeroDeCédula";
            this.lblNúmeroDeCédula.Size = new System.Drawing.Size(138, 21);
            this.lblNúmeroDeCédula.TabIndex = 7;
            this.lblNúmeroDeCédula.Text = "Número de cédula";
            // 
            // lblGénero
            // 
            this.lblGénero.AutoSize = true;
            this.lblGénero.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGénero.Location = new System.Drawing.Point(194, 104);
            this.lblGénero.Name = "lblGénero";
            this.lblGénero.Size = new System.Drawing.Size(61, 21);
            this.lblGénero.TabIndex = 8;
            this.lblGénero.Text = "Género";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(402, 105);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(44, 21);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "Edad";
            // 
            // txtBxEdad
            // 
            this.txtBxEdad.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxEdad.Location = new System.Drawing.Point(452, 104);
            this.txtBxEdad.MaxLength = 2;
            this.txtBxEdad.Name = "txtBxEdad";
            this.txtBxEdad.Size = new System.Drawing.Size(60, 23);
            this.txtBxEdad.TabIndex = 10;
            this.txtBxEdad.Enter += new System.EventHandler(this.txtBxNombres_Enter_1);
            // 
            // cmbBxGénero
            // 
            this.cmbBxGénero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxGénero.FormattingEnabled = true;
            this.cmbBxGénero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbBxGénero.Location = new System.Drawing.Point(262, 104);
            this.cmbBxGénero.Name = "cmbBxGénero";
            this.cmbBxGénero.Size = new System.Drawing.Size(134, 21);
            this.cmbBxGénero.TabIndex = 11;
            // 
            // lblTeléfono
            // 
            this.lblTeléfono.AutoSize = true;
            this.lblTeléfono.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeléfono.Location = new System.Drawing.Point(194, 133);
            this.lblTeléfono.Name = "lblTeléfono";
            this.lblTeléfono.Size = new System.Drawing.Size(68, 21);
            this.lblTeléfono.TabIndex = 12;
            this.lblTeléfono.Text = "Teléfono";
            // 
            // txtBxPrefijoTeléfono
            // 
            this.txtBxPrefijoTeléfono.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPrefijoTeléfono.Location = new System.Drawing.Point(274, 131);
            this.txtBxPrefijoTeléfono.MaxLength = 3;
            this.txtBxPrefijoTeléfono.Name = "txtBxPrefijoTeléfono";
            this.txtBxPrefijoTeléfono.Size = new System.Drawing.Size(43, 23);
            this.txtBxPrefijoTeléfono.TabIndex = 13;
            this.txtBxPrefijoTeléfono.Enter += new System.EventHandler(this.txtBxNombres_Enter_1);
            // 
            // txtBxTeléfono
            // 
            this.txtBxTeléfono.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTeléfono.Location = new System.Drawing.Point(323, 131);
            this.txtBxTeléfono.MaxLength = 7;
            this.txtBxTeléfono.Name = "txtBxTeléfono";
            this.txtBxTeléfono.Size = new System.Drawing.Size(135, 23);
            this.txtBxTeléfono.TabIndex = 14;
            this.txtBxTeléfono.Enter += new System.EventHandler(this.txtBxNombres_Enter_1);
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirección.Location = new System.Drawing.Point(194, 162);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(75, 21);
            this.lblDirección.TabIndex = 15;
            this.lblDirección.Text = "Dirección";
            // 
            // txtBxDirección
            // 
            this.txtBxDirección.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDirección.Location = new System.Drawing.Point(274, 160);
            this.txtBxDirección.MaxLength = 40;
            this.txtBxDirección.Name = "txtBxDirección";
            this.txtBxDirección.Size = new System.Drawing.Size(238, 23);
            this.txtBxDirección.TabIndex = 16;
            this.txtBxDirección.Enter += new System.EventHandler(this.txtBxNombres_Enter_1);
            // 
            // lblCorreoElectrónico
            // 
            this.lblCorreoElectrónico.AutoSize = true;
            this.lblCorreoElectrónico.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectrónico.Location = new System.Drawing.Point(9, 191);
            this.lblCorreoElectrónico.Name = "lblCorreoElectrónico";
            this.lblCorreoElectrónico.Size = new System.Drawing.Size(138, 21);
            this.lblCorreoElectrónico.TabIndex = 17;
            this.lblCorreoElectrónico.Text = "Correo electrónico";
            // 
            // txtBxCorreoElectrónico
            // 
            this.txtBxCorreoElectrónico.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCorreoElectrónico.Location = new System.Drawing.Point(156, 189);
            this.txtBxCorreoElectrónico.MaxLength = 30;
            this.txtBxCorreoElectrónico.Name = "txtBxCorreoElectrónico";
            this.txtBxCorreoElectrónico.Size = new System.Drawing.Size(290, 23);
            this.txtBxCorreoElectrónico.TabIndex = 18;
            this.txtBxCorreoElectrónico.Enter += new System.EventHandler(this.txtBxNombres_Enter_1);
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.AutoSize = true;
            this.lblNombreDeUsuario.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(9, 220);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(145, 21);
            this.lblNombreDeUsuario.TabIndex = 19;
            this.lblNombreDeUsuario.Text = "Nombre de usuario";
            // 
            // txtBxNombreDeUsuario
            // 
            this.txtBxNombreDeUsuario.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxNombreDeUsuario.Location = new System.Drawing.Point(156, 218);
            this.txtBxNombreDeUsuario.MaxLength = 16;
            this.txtBxNombreDeUsuario.Name = "txtBxNombreDeUsuario";
            this.txtBxNombreDeUsuario.Size = new System.Drawing.Size(161, 23);
            this.txtBxNombreDeUsuario.TabIndex = 20;
            this.txtBxNombreDeUsuario.Enter += new System.EventHandler(this.txtBxNombres_Enter_1);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(9, 249);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(89, 21);
            this.lblContraseña.TabIndex = 21;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtBxContraseña
            // 
            this.txtBxContraseña.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxContraseña.Location = new System.Drawing.Point(156, 247);
            this.txtBxContraseña.MaxLength = 16;
            this.txtBxContraseña.Name = "txtBxContraseña";
            this.txtBxContraseña.PasswordChar = '*';
            this.txtBxContraseña.Size = new System.Drawing.Size(161, 23);
            this.txtBxContraseña.TabIndex = 22;
            this.txtBxContraseña.Enter += new System.EventHandler(this.txtBxNombres_Enter_1);
            // 
            // chckBxVerContraseña
            // 
            this.chckBxVerContraseña.AutoSize = true;
            this.chckBxVerContraseña.Location = new System.Drawing.Point(323, 250);
            this.chckBxVerContraseña.Name = "chckBxVerContraseña";
            this.chckBxVerContraseña.Size = new System.Drawing.Size(42, 17);
            this.chckBxVerContraseña.TabIndex = 23;
            this.chckBxVerContraseña.Text = "Ver";
            this.chckBxVerContraseña.UseVisualStyleBackColor = true;
            this.chckBxVerContraseña.CheckedChanged += new System.EventHandler(this.chckBxVerContraseña_CheckedChanged);
            // 
            // cmbBxRol
            // 
            this.cmbBxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxRol.FormattingEnabled = true;
            this.cmbBxRol.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.cmbBxRol.Location = new System.Drawing.Point(362, 218);
            this.cmbBxRol.Name = "cmbBxRol";
            this.cmbBxRol.Size = new System.Drawing.Size(121, 21);
            this.cmbBxRol.TabIndex = 24;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(323, 218);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 21);
            this.lblRol.TabIndex = 25;
            this.lblRol.Text = "Rol";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(437, 277);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(356, 277);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(274, 277);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(193, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnImagen
            // 
            this.btnImagen.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.Location = new System.Drawing.Point(120, 159);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(67, 23);
            this.btnImagen.TabIndex = 30;
            this.btnImagen.Text = "...";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 312);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.cmbBxRol);
            this.Controls.Add(this.chckBxVerContraseña);
            this.Controls.Add(this.txtBxContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtBxNombreDeUsuario);
            this.Controls.Add(this.lblNombreDeUsuario);
            this.Controls.Add(this.txtBxCorreoElectrónico);
            this.Controls.Add(this.lblCorreoElectrónico);
            this.Controls.Add(this.txtBxDirección);
            this.Controls.Add(this.lblDirección);
            this.Controls.Add(this.txtBxTeléfono);
            this.Controls.Add(this.txtBxPrefijoTeléfono);
            this.Controls.Add(this.lblTeléfono);
            this.Controls.Add(this.cmbBxGénero);
            this.Controls.Add(this.txtBxEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblGénero);
            this.Controls.Add(this.lblNúmeroDeCédula);
            this.Controls.Add(this.txtBxNúmeroDeCédula);
            this.Controls.Add(this.txtBxApellidos);
            this.Controls.Add(this.txtBxNombres);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.pctrBxFotografía);
            this.MaximizeBox = false;
            this.Name = "FrmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxFotografía)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrBxFotografía;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtBxNombres;
        private System.Windows.Forms.TextBox txtBxApellidos;
        private System.Windows.Forms.TextBox txtBxNúmeroDeCédula;
        private System.Windows.Forms.Label lblNúmeroDeCédula;
        private System.Windows.Forms.Label lblGénero;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtBxEdad;
        private System.Windows.Forms.ComboBox cmbBxGénero;
        private System.Windows.Forms.Label lblTeléfono;
        private System.Windows.Forms.TextBox txtBxPrefijoTeléfono;
        private System.Windows.Forms.TextBox txtBxTeléfono;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.TextBox txtBxDirección;
        private System.Windows.Forms.Label lblCorreoElectrónico;
        private System.Windows.Forms.TextBox txtBxCorreoElectrónico;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.TextBox txtBxNombreDeUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtBxContraseña;
        private System.Windows.Forms.CheckBox chckBxVerContraseña;
        private System.Windows.Forms.ComboBox cmbBxRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImagen;
    }
}
namespace RapidDesktop.Forms
{
    partial class FrmEditarCliente
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
            label1 = new Label();
            txtApellidoNombre = new TextBox();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            comboLocalidades = new ComboBox();
            label5 = new Label();
            btnAgregarLocalidad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(132, 59);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 0;
            label1.Text = "Apellido y Nombre:";
            // 
            // txtApellidoNombre
            // 
            txtApellidoNombre.Location = new Point(287, 52);
            txtApellidoNombre.Name = "txtApellidoNombre";
            txtApellidoNombre.Size = new Size(559, 27);
            txtApellidoNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(287, 183);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(559, 27);
            txtTelefono.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(132, 189);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 2;
            label2.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(287, 111);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(559, 27);
            txtDireccion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(132, 118);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 4;
            label3.Text = "Dirección:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(287, 258);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(559, 27);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(132, 265);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SkyBlue;
            btnGuardar.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(64, 414);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 62);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(833, 414);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(165, 62);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // comboLocalidades
            // 
            comboLocalidades.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLocalidades.FormattingEnabled = true;
            comboLocalidades.Location = new Point(287, 329);
            comboLocalidades.Name = "comboLocalidades";
            comboLocalidades.Size = new Size(559, 28);
            comboLocalidades.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(132, 331);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 11;
            label5.Text = "Localidad:";
            // 
            // btnAgregarLocalidad
            // 
            btnAgregarLocalidad.BackColor = Color.Lime;
            btnAgregarLocalidad.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarLocalidad.Location = new Point(867, 331);
            btnAgregarLocalidad.Name = "btnAgregarLocalidad";
            btnAgregarLocalidad.Size = new Size(53, 29);
            btnAgregarLocalidad.TabIndex = 15;
            btnAgregarLocalidad.Text = ".  .  .";
            btnAgregarLocalidad.UseVisualStyleBackColor = false;
            btnAgregarLocalidad.Click += btnAgregarLocalidad_Click;
            // 
            // FrmEditarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1047, 547);
            Controls.Add(btnAgregarLocalidad);
            Controls.Add(label5);
            Controls.Add(comboLocalidades);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtApellidoNombre);
            Controls.Add(label1);
            Name = "FrmEditarCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EDITAR CLIENTE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtApellidoNombre;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private ComboBox comboLocalidades;
        private Label label5;
        private Button btnAgregarLocalidad;
    }
}
namespace RapidDesktop.Forms.Localidades
{
    partial class FrmEditarLocalidad
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
            label5 = new Label();
            comboProvincias = new ComboBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            txtCodigoPostal = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            btnAgregarProvincia = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(116, 237);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 29;
            label5.Text = "Provincia:";
            // 
            // comboProvincias
            // 
            comboProvincias.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProvincias.FormattingEnabled = true;
            comboProvincias.Location = new Point(271, 235);
            comboProvincias.Name = "comboProvincias";
            comboProvincias.Size = new Size(559, 28);
            comboProvincias.TabIndex = 28;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SkyBlue;
            btnGuardar.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(46, 308);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 62);
            btnGuardar.TabIndex = 27;
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
            btnCancelar.Location = new Point(803, 308);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(165, 62);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(271, 167);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(559, 27);
            txtCodigoPostal.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(116, 174);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 24;
            label4.Text = "CodigoPostal:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(271, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(559, 27);
            txtNombre.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(116, 98);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 22;
            label2.Text = "Nombre:";
            // 
            // btnAgregarProvincia
            // 
            btnAgregarProvincia.BackColor = Color.Lime;
            btnAgregarProvincia.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProvincia.Location = new Point(849, 237);
            btnAgregarProvincia.Name = "btnAgregarProvincia";
            btnAgregarProvincia.Size = new Size(65, 29);
            btnAgregarProvincia.TabIndex = 30;
            btnAgregarProvincia.Text = ".  .  . ";
            btnAgregarProvincia.UseVisualStyleBackColor = false;
            btnAgregarProvincia.Click += btnAgregarProvincia_Click;
            // 
            // FrmEditarLocalidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1014, 462);
            Controls.Add(btnAgregarProvincia);
            Controls.Add(label5);
            Controls.Add(comboProvincias);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtCodigoPostal);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Name = "FrmEditarLocalidad";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EDITAR LOCALIDAD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox comboProvincias;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private TextBox txtCodigoPostal;
        private Label label4;
        private TextBox txtNombre;
        private Label label2;
        private Button btnAgregarProvincia;
    }
}
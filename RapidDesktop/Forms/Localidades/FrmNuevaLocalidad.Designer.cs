namespace RapidDesktop.Forms.Localidades
{
    partial class FrmNuevaLocalidad
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
            label5.Location = new Point(138, 254);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 21;
            label5.Text = "Provincia:";
            // 
            // comboProvincias
            // 
            comboProvincias.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProvincias.FormattingEnabled = true;
            comboProvincias.Location = new Point(293, 252);
            comboProvincias.Name = "comboProvincias";
            comboProvincias.Size = new Size(559, 28);
            comboProvincias.TabIndex = 20;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SkyBlue;
            btnGuardar.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(68, 325);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 62);
            btnGuardar.TabIndex = 19;
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
            btnCancelar.Location = new Point(825, 325);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(165, 62);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(293, 184);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(559, 27);
            txtCodigoPostal.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(138, 191);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 16;
            label4.Text = "CodigoPostal:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(293, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(559, 27);
            txtNombre.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(138, 115);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
            // 
            // btnAgregarProvincia
            // 
            btnAgregarProvincia.BackColor = Color.Lime;
            btnAgregarProvincia.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProvincia.Location = new Point(863, 254);
            btnAgregarProvincia.Name = "btnAgregarProvincia";
            btnAgregarProvincia.Size = new Size(60, 29);
            btnAgregarProvincia.TabIndex = 22;
            btnAgregarProvincia.Text = ".  .  .";
            btnAgregarProvincia.UseVisualStyleBackColor = false;
            btnAgregarProvincia.Click += btnAgregarProvincia_Click;
            // 
            // FrmNuevaLocalidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1058, 497);
            Controls.Add(btnAgregarProvincia);
            Controls.Add(label5);
            Controls.Add(comboProvincias);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtCodigoPostal);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Name = "FrmNuevaLocalidad";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NUEVA LOCALIDAD";
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
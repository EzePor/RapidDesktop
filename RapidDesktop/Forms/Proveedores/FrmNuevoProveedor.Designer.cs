namespace RapidDesktop.Forms.Proveedores
{
    partial class FrmNuevoProveedor
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
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            txtEmail = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SkyBlue;
            btnGuardar.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(72, 379);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 62);
            btnGuardar.TabIndex = 23;
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
            btnCancelar.Location = new Point(829, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(165, 62);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(294, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(559, 27);
            txtEmail.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(139, 172);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 18;
            label3.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(294, 274);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(559, 27);
            txtTelefono.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(139, 280);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 16;
            label2.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(294, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(559, 27);
            txtNombre.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(139, 56);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 14;
            label1.Text = " Nombre:";
            // 
            // FrmNuevoProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1067, 473);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmNuevoProveedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NUEVO PROVEEDOR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
    }
}
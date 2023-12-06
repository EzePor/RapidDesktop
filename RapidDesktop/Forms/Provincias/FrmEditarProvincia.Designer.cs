namespace RapidDesktop.Forms.Provincias
{
    partial class FrmEditarProvincia
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
            txtNombre = new TextBox();
            label2 = new Label();
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
            btnGuardar.Location = new Point(59, 324);
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
            btnCancelar.Location = new Point(816, 324);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(165, 62);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(284, 108);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(559, 27);
            txtNombre.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(129, 114);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 24;
            label2.Text = "Nombre:";
            // 
            // FrmEditarProvincia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1041, 494);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Name = "FrmEditarProvincia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EDITAR PROVINCIA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private TextBox txtNombre;
        private Label label2;
    }
}
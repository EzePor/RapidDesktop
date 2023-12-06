namespace RapidDesktop.Forms.Productos
{
    partial class FrmNuevoProducto
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
            comboProveedores = new ComboBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboRubros = new ComboBox();
            txtGarantiaFabricante = new TextBox();
            label4 = new Label();
            label6 = new Label();
            comboFabricantes = new ComboBox();
            btnAgregarRubro = new Button();
            btnAgregarProveedor = new Button();
            btnAgregarFabricante = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(161, 298);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 25;
            label5.Text = "Proveedor:";
            // 
            // comboProveedores
            // 
            comboProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProveedores.FormattingEnabled = true;
            comboProveedores.Location = new Point(316, 296);
            comboProveedores.Name = "comboProveedores";
            comboProveedores.Size = new Size(559, 28);
            comboProveedores.TabIndex = 24;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SkyBlue;
            btnGuardar.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(91, 409);
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
            btnCancelar.Location = new Point(848, 409);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(165, 62);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(316, 96);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(559, 27);
            txtPrecio.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(161, 103);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 18;
            label3.Text = "Precio:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(316, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(559, 27);
            txtNombre.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(161, 35);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 14;
            label1.Text = " Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(161, 233);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 27;
            label2.Text = "Rubro:";
            // 
            // comboRubros
            // 
            comboRubros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRubros.FormattingEnabled = true;
            comboRubros.Location = new Point(316, 231);
            comboRubros.Name = "comboRubros";
            comboRubros.Size = new Size(559, 28);
            comboRubros.TabIndex = 26;
            // 
            // txtGarantiaFabricante
            // 
            txtGarantiaFabricante.Location = new Point(316, 161);
            txtGarantiaFabricante.Name = "txtGarantiaFabricante";
            txtGarantiaFabricante.Size = new Size(559, 27);
            txtGarantiaFabricante.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(161, 161);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 28;
            label4.Text = "Garantía:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(161, 364);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 31;
            label6.Text = "Fabricante:";
            // 
            // comboFabricantes
            // 
            comboFabricantes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFabricantes.FormattingEnabled = true;
            comboFabricantes.Location = new Point(316, 362);
            comboFabricantes.Name = "comboFabricantes";
            comboFabricantes.Size = new Size(559, 28);
            comboFabricantes.TabIndex = 30;
            // 
            // btnAgregarRubro
            // 
            btnAgregarRubro.BackColor = Color.Lime;
            btnAgregarRubro.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarRubro.Location = new Point(892, 228);
            btnAgregarRubro.Name = "btnAgregarRubro";
            btnAgregarRubro.Size = new Size(81, 39);
            btnAgregarRubro.TabIndex = 32;
            btnAgregarRubro.Text = ".  .  .  ";
            btnAgregarRubro.UseVisualStyleBackColor = false;
            btnAgregarRubro.Click += btnAgregarRubro_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.BackColor = Color.Lime;
            btnAgregarProveedor.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProveedor.Location = new Point(892, 291);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(81, 37);
            btnAgregarProveedor.TabIndex = 33;
            btnAgregarProveedor.Text = ".  .  .  ";
            btnAgregarProveedor.UseVisualStyleBackColor = false;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // btnAgregarFabricante
            // 
            btnAgregarFabricante.BackColor = Color.Lime;
            btnAgregarFabricante.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarFabricante.Location = new Point(892, 354);
            btnAgregarFabricante.Name = "btnAgregarFabricante";
            btnAgregarFabricante.Size = new Size(81, 41);
            btnAgregarFabricante.TabIndex = 34;
            btnAgregarFabricante.Text = ".  .  .  ";
            btnAgregarFabricante.UseVisualStyleBackColor = false;
            btnAgregarFabricante.Click += btnAgregarFabricante_Click;
            // 
            // FrmNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1104, 533);
            Controls.Add(btnAgregarFabricante);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(btnAgregarRubro);
            Controls.Add(label6);
            Controls.Add(comboFabricantes);
            Controls.Add(txtGarantiaFabricante);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(comboRubros);
            Controls.Add(label5);
            Controls.Add(comboProveedores);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmNuevoProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NUEVO PRODUCTO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox comboProveedores;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private ComboBox comboRubros;
        private TextBox txtGarantiaFabricante;
        private Label label4;
        private Label label6;
        private ComboBox comboFabricantes;
        private Button btnAgregarRubro;
        private Button btnAgregarProveedor;
        private Button btnAgregarFabricante;
    }
}
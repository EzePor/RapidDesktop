namespace RapidDesktop.Forms.Productos
{
    partial class FrmEditarProducto
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
            label6 = new Label();
            comboFabricantes = new ComboBox();
            txtGarantiaFabricante = new TextBox();
            label4 = new Label();
            label2 = new Label();
            comboRubros = new ComboBox();
            label5 = new Label();
            comboProveedores = new ComboBox();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            btnAgregarFabricante = new Button();
            btnAgregarProveedor = new Button();
            btnAgregarRubro = new Button();
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
            btnGuardar.Location = new Point(59, 386);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 62);
            btnGuardar.TabIndex = 33;
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
            btnCancelar.Location = new Point(847, 386);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(165, 62);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(159, 347);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 45;
            label6.Text = "Fabricante:";
            // 
            // comboFabricantes
            // 
            comboFabricantes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFabricantes.FormattingEnabled = true;
            comboFabricantes.Location = new Point(314, 345);
            comboFabricantes.Name = "comboFabricantes";
            comboFabricantes.Size = new Size(559, 28);
            comboFabricantes.TabIndex = 44;
            // 
            // txtGarantiaFabricante
            // 
            txtGarantiaFabricante.Location = new Point(314, 144);
            txtGarantiaFabricante.Name = "txtGarantiaFabricante";
            txtGarantiaFabricante.Size = new Size(559, 27);
            txtGarantiaFabricante.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(159, 144);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 42;
            label4.Text = "Garantía:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(159, 216);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 41;
            label2.Text = "Rubro:";
            // 
            // comboRubros
            // 
            comboRubros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRubros.FormattingEnabled = true;
            comboRubros.Location = new Point(314, 214);
            comboRubros.Name = "comboRubros";
            comboRubros.Size = new Size(559, 28);
            comboRubros.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(159, 281);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 39;
            label5.Text = "Proveedor:";
            // 
            // comboProveedores
            // 
            comboProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProveedores.FormattingEnabled = true;
            comboProveedores.Location = new Point(314, 279);
            comboProveedores.Name = "comboProveedores";
            comboProveedores.Size = new Size(559, 28);
            comboProveedores.TabIndex = 38;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(314, 79);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(559, 27);
            txtPrecio.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(159, 86);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 36;
            label3.Text = "Precio:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(314, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(559, 27);
            txtNombre.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(159, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 34;
            label1.Text = " Nombre:";
            // 
            // btnAgregarFabricante
            // 
            btnAgregarFabricante.BackColor = Color.Lime;
            btnAgregarFabricante.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarFabricante.Location = new Point(896, 343);
            btnAgregarFabricante.Name = "btnAgregarFabricante";
            btnAgregarFabricante.Size = new Size(65, 33);
            btnAgregarFabricante.TabIndex = 48;
            btnAgregarFabricante.Text = ".  .  .  ";
            btnAgregarFabricante.UseVisualStyleBackColor = false;
            btnAgregarFabricante.Click += btnAgregarFabricante_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.BackColor = Color.Lime;
            btnAgregarProveedor.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProveedor.Location = new Point(896, 277);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(65, 37);
            btnAgregarProveedor.TabIndex = 47;
            btnAgregarProveedor.Text = ".  .  .  ";
            btnAgregarProveedor.UseVisualStyleBackColor = false;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // btnAgregarRubro
            // 
            btnAgregarRubro.BackColor = Color.Lime;
            btnAgregarRubro.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarRubro.Location = new Point(896, 209);
            btnAgregarRubro.Name = "btnAgregarRubro";
            btnAgregarRubro.Size = new Size(65, 34);
            btnAgregarRubro.TabIndex = 46;
            btnAgregarRubro.Text = ".  .  .  ";
            btnAgregarRubro.UseVisualStyleBackColor = false;
            btnAgregarRubro.Click += btnAgregarRubro_Click;
            // 
            // FrmEditarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1073, 460);
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
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Name = "FrmEditarProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EDITAR PRODUCTO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private Label label6;
        private ComboBox comboFabricantes;
        private TextBox txtGarantiaFabricante;
        private Label label4;
        private Label label2;
        private ComboBox comboRubros;
        private Label label5;
        private ComboBox comboProveedores;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtNombre;
        private Label label1;
        private Button btnAgregarFabricante;
        private Button btnAgregarProveedor;
        private Button btnAgregarRubro;
    }
}
namespace RapidDesktop.Forms.Fabricantes
{
    partial class FrmFabricantes
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
            txtBusqueda = new TextBox();
            label1 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            dataGridFabricantes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridFabricantes).BeginInit();
            SuspendLayout();
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(289, 79);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(758, 27);
            txtBusqueda.TabIndex = 20;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(216, 85);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 19;
            label1.Text = "BUSCAR:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Gold;
            btnEliminar.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(523, 531);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 50);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.YellowGreen;
            btnNuevo.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.File;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(198, 531);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(124, 50);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "NUEVO";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkTurquoise;
            btnEditar.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(352, 531);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(124, 50);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "EDITAR";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.OrangeRed;
            btnSalir.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingDashedLineArrowRight;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(955, 531);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(134, 50);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "SALIR";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dataGridFabricantes
            // 
            dataGridFabricantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridFabricantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFabricantes.Location = new Point(183, 152);
            dataGridFabricantes.Name = "dataGridFabricantes";
            dataGridFabricantes.RowHeadersWidth = 51;
            dataGridFabricantes.RowTemplate.Height = 29;
            dataGridFabricantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridFabricantes.Size = new Size(906, 322);
            dataGridFabricantes.TabIndex = 14;
            // 
            // FrmFabricantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1282, 653);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(btnEditar);
            Controls.Add(btnSalir);
            Controls.Add(dataGridFabricantes);
            Name = "FrmFabricantes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FABRICANTES";
            ((System.ComponentModel.ISupportInitialize)dataGridFabricantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusqueda;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private DataGridView dataGridFabricantes;
    }
}
namespace AcaBiblioteca
{
    partial class FrmUsuarios
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
            panel1 = new Panel();
            lblTituloUsu = new Label();
            dgvUsuarios = new DataGridView();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDocumento = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            txtNombre = new TextBox();
            panel2 = new Panel();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDocumento = new TextBox();
            txtApellido = new TextBox();
            panel3 = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(lblTituloUsu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 120);
            panel1.TabIndex = 0;
            // 
            // lblTituloUsu
            // 
            lblTituloUsu.AutoSize = true;
            lblTituloUsu.BackColor = Color.Transparent;
            lblTituloUsu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloUsu.ForeColor = Color.White;
            lblTituloUsu.Location = new Point(554, 44);
            lblTituloUsu.Name = "lblTituloUsu";
            lblTituloUsu.Size = new Size(279, 32);
            lblTituloUsu.TabIndex = 1;
            lblTituloUsu.Text = "GESTIÓN DE USUARIOS";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(184, 507);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(1000, 300);
            dgvUsuarios.TabIndex = 3;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(483, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(483, 82);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 19);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(462, 130);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(90, 19);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(479, 173);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(72, 19);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(490, 221);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(61, 19);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(656, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 23);
            txtNombre.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(txtDocumento);
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(lblCorreo);
            panel2.Controls.Add(lblTelefono);
            panel2.Controls.Add(lblDocumento);
            panel2.Controls.Add(lblApellido);
            panel2.Controls.Add(lblNombre);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 266);
            panel2.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(656, 217);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(177, 23);
            txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(656, 169);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(177, 23);
            txtTelefono.TabIndex = 8;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(656, 126);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(177, 23);
            txtDocumento.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(656, 78);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(177, 23);
            txtApellido.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(btnNuevo);
            panel3.Location = new Point(293, 406);
            panel3.Name = "panel3";
            panel3.Size = new Size(768, 70);
            panel3.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 30;
            btnCancelar.Location = new Point(620, 9);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 50);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 30;
            btnEliminar.Location = new Point(466, 9);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 50);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 30;
            btnEditar.Location = new Point(315, 9);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 50);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 30;
            btnGuardar.Location = new Point(167, 9);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 50);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 30;
            btnNuevo.Location = new Point(15, 9);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(125, 50);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1350, 819);
            Controls.Add(panel3);
            Controls.Add(dgvUsuarios);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTituloUsu;
        private DataGridView dgvUsuarios;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private Label lblTelefono;
        private Label lblCorreo;
        private TextBox txtNombre;
        private Panel panel2;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDocumento;
        private TextBox txtApellido;
        private TextBox textBox1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
    }
}
namespace AcaBiblioteca
{
    partial class FrmPrestamos
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
            lblTituloPre = new Label();
            panel2 = new Panel();
            dtpFechaDevolucion = new DateTimePicker();
            dtpFechaPrestamo = new DateTimePicker();
            lblDevolucion = new Label();
            lblPrestamo = new Label();
            lblLibro = new Label();
            lblUsuario = new Label();
            cmbLibro = new ComboBox();
            cmbUsuario = new ComboBox();
            panel3 = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvPrestamos = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(lblTituloPre);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 120);
            panel1.TabIndex = 0;
            // 
            // lblTituloPre
            // 
            lblTituloPre.AutoSize = true;
            lblTituloPre.BackColor = Color.Transparent;
            lblTituloPre.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPre.ForeColor = Color.White;
            lblTituloPre.Location = new Point(536, 44);
            lblTituloPre.Name = "lblTituloPre";
            lblTituloPre.Size = new Size(301, 32);
            lblTituloPre.TabIndex = 2;
            lblTituloPre.Text = "GESTIÓN DE PRÉSTAMOS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(dtpFechaDevolucion);
            panel2.Controls.Add(dtpFechaPrestamo);
            panel2.Controls.Add(lblDevolucion);
            panel2.Controls.Add(lblPrestamo);
            panel2.Controls.Add(lblLibro);
            panel2.Controls.Add(lblUsuario);
            panel2.Controls.Add(cmbLibro);
            panel2.Controls.Add(cmbUsuario);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 280);
            panel2.TabIndex = 1;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Location = new Point(694, 221);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(210, 23);
            dtpFechaDevolucion.TabIndex = 7;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(694, 158);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(210, 23);
            dtpFechaPrestamo.TabIndex = 6;
            // 
            // lblDevolucion
            // 
            lblDevolucion.AutoSize = true;
            lblDevolucion.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDevolucion.Location = new Point(501, 225);
            lblDevolucion.Name = "lblDevolucion";
            lblDevolucion.Size = new Size(137, 19);
            lblDevolucion.TabIndex = 5;
            lblDevolucion.Text = "Fecha Devolución: ";
            // 
            // lblPrestamo
            // 
            lblPrestamo.AutoSize = true;
            lblPrestamo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrestamo.Location = new Point(501, 162);
            lblPrestamo.Name = "lblPrestamo";
            lblPrestamo.Size = new Size(121, 19);
            lblPrestamo.TabIndex = 4;
            lblPrestamo.Text = "Fecha Préstamo:";
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibro.Location = new Point(501, 98);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(50, 19);
            lblLibro.TabIndex = 3;
            lblLibro.Text = "Libro:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(501, 34);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(66, 19);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // cmbLibro
            // 
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(694, 94);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(210, 23);
            cmbLibro.TabIndex = 1;
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(694, 30);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(210, 23);
            cmbUsuario.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(btnNuevo);
            panel3.Location = new Point(293, 416);
            panel3.Name = "panel3";
            panel3.Size = new Size(768, 70);
            panel3.TabIndex = 5;
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
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(192, 500);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.Size = new Size(1000, 300);
            dgvPrestamos.TabIndex = 6;
            dgvPrestamos.CellDoubleClick += dgvPrestamos_CellDoubleClick;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1350, 812);
            Controls.Add(dgvPrestamos);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmPrestamos";
            Text = "FrmPrestamos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTituloPre;
        private Label lblUsuario;
        private ComboBox cmbLibro;
        private ComboBox cmbUsuario;
        private Label lblLibro;
        private Label lblDevolucion;
        private Label lblPrestamo;
        private DateTimePicker dtpFechaPrestamo;
        private DateTimePicker dtpFechaDevolucion;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridView dgvPrestamos;
        
    }
}
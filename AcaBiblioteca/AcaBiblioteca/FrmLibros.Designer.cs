namespace AcaBiblioteca
{
    partial class FrmLibros
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            pnlDatos = new Panel();
            cmbAutor = new ComboBox();
            cmbEditorial = new ComboBox();
            txtExistencias = new TextBox();
            txtAnio = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblAno = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            lblAutor = new Label();
            lblTituloLib = new Label();
            lblSBN = new Label();
            pnlBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvLibros = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.LightSalmon;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1350, 60);
            pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(514, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(243, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE LIBROS";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.PeachPuff;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1350, 55);
            pnlBusqueda.TabIndex = 2;
            pnlBusqueda.Paint += pnlBusqueda_Paint;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(744, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 33);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(540, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(177, 23);
            txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(440, 24);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(47, 19);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "ISBN";
            lblBuscar.Click += lblBuscar_Click;
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.SeaShell;
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtAnio);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAno);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblTituloLib);
            pnlDatos.Controls.Add(lblSBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1350, 310);
            pnlDatos.TabIndex = 3;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(540, 110);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(177, 23);
            cmbAutor.TabIndex = 12;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(540, 156);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(177, 23);
            cmbEditorial.TabIndex = 11;
            cmbEditorial.SelectedIndexChanged += cmbEditorial_SelectedIndexChanged;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(540, 273);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(177, 23);
            txtExistencias.TabIndex = 10;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(540, 236);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(177, 23);
            txtAnio.TabIndex = 9;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(540, 199);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(177, 23);
            txtCategoria.TabIndex = 8;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(540, 67);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(177, 23);
            txtTitulo.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(540, 23);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(177, 23);
            txtISBN.TabIndex = 3;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(440, 277);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(90, 19);
            lblExistencias.TabIndex = 6;
            lblExistencias.Text = "Existencias:";
            lblExistencias.Click += lblExistencias_Click;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAno.Location = new Point(440, 240);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(41, 19);
            lblAno.TabIndex = 5;
            lblAno.Text = "Año:";
            lblAno.Click += lblAno_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(440, 203);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(84, 19);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria: ";
            lblCategoria.Click += lblCategoria_Click;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(440, 160);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(71, 19);
            lblEditorial.TabIndex = 3;
            lblEditorial.Text = "Editorial:";
            lblEditorial.Click += label1_Click;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(440, 114);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(52, 19);
            lblAutor.TabIndex = 2;
            lblAutor.Text = "Autor:";
            lblAutor.Click += lblAutor_Click;
            // 
            // lblTituloLib
            // 
            lblTituloLib.AutoSize = true;
            lblTituloLib.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLib.Location = new Point(440, 71);
            lblTituloLib.Name = "lblTituloLib";
            lblTituloLib.Size = new Size(53, 19);
            lblTituloLib.TabIndex = 1;
            lblTituloLib.Text = "Título:";
            lblTituloLib.Click += lblTituloLib_Click;
            // 
            // lblSBN
            // 
            lblSBN.AutoSize = true;
            lblSBN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSBN.Location = new Point(440, 27);
            lblSBN.Name = "lblSBN";
            lblSBN.Size = new Size(52, 19);
            lblSBN.TabIndex = 0;
            lblSBN.Text = "ISBN:";
            lblSBN.Click += lblSBN_Click;
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(246, 441);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(700, 67);
            pnlBotones.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 30;
            btnCancelar.Location = new Point(567, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 50);
            btnCancelar.TabIndex = 4;
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
            btnEliminar.Location = new Point(426, 6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 50);
            btnEliminar.TabIndex = 3;
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
            btnEditar.Location = new Point(285, 6);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 50);
            btnEditar.TabIndex = 2;
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
            btnGuardar.Location = new Point(144, 6);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 50);
            btnGuardar.TabIndex = 1;
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
            btnNuevo.Location = new Point(3, 6);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(125, 50);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(123, 528);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(1000, 300);
            dgvLibros.TabIndex = 5;
            dgvLibros.CellDoubleClick += dgvLibros_CellDoubleClick;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1350, 840);
            Controls.Add(dgvLibros);
            Controls.Add(pnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibros";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Button btnBuscar;
        private Panel pnlDatos;
        private Label label2;
        private Label lblSBN;
        private Label lblTituloLib;
        private Label lblEditorial;
        private Label lblAutor;
        private Label lblCategoria;
        private Label lblAno;
        private Label lblExistencias;
        private TextBox txtAnio;
        private TextBox txtCategoria;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private TextBox txtExistencias;
        private ComboBox cmbEditorial;
        private ComboBox comboBox1;
        private ComboBox cmbAutor;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private DataGridView dgvLibros;
    }
}
namespace AcaBiblioteca
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnlMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnPrestamos = new FontAwesome.Sharp.IconButton();
            btnEditoriales = new FontAwesome.Sharp.IconButton();
            btnAutores = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnLibros = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            label2 = new Label();
            pnlSuperior = new Panel();
            pnlEstado = new Panel();
            pnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.DarkTurquoise;
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnPrestamos);
            pnlMenu.Controls.Add(btnEditoriales);
            pnlMenu.Controls.Add(btnAutores);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnLibros);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(240, 556);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Azure;
            btnSalir.Dock = DockStyle.Top;
            btnSalir.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Firebrick;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnSalir.IconColor = Color.Firebrick;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 30;
            btnSalir.Location = new Point(0, 430);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(240, 50);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.Azure;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.BookAtlas;
            btnReportes.IconColor = Color.Black;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 30;
            btnReportes.Location = new Point(0, 380);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(240, 50);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleRight;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackColor = Color.Azure;
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamos.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btnPrestamos.IconColor = Color.Black;
            btnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrestamos.IconSize = 30;
            btnPrestamos.Location = new Point(0, 330);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(240, 50);
            btnPrestamos.TabIndex = 6;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.TextAlign = ContentAlignment.MiddleRight;
            btnPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnEditoriales
            // 
            btnEditoriales.BackColor = Color.Azure;
            btnEditoriales.Dock = DockStyle.Top;
            btnEditoriales.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditoriales.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnEditoriales.IconColor = Color.Black;
            btnEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditoriales.IconSize = 30;
            btnEditoriales.Location = new Point(0, 280);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.Size = new Size(240, 50);
            btnEditoriales.TabIndex = 5;
            btnEditoriales.Text = "Editoriales";
            btnEditoriales.TextAlign = ContentAlignment.MiddleRight;
            btnEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditoriales.UseVisualStyleBackColor = false;
            btnEditoriales.Click += btnEditoriales_Click;
            // 
            // btnAutores
            // 
            btnAutores.BackColor = Color.Azure;
            btnAutores.Dock = DockStyle.Top;
            btnAutores.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutores.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            btnAutores.IconColor = Color.Black;
            btnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAutores.IconSize = 30;
            btnAutores.Location = new Point(0, 230);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(240, 50);
            btnAutores.TabIndex = 4;
            btnAutores.Text = "Autores";
            btnAutores.TextAlign = ContentAlignment.MiddleRight;
            btnAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAutores.UseVisualStyleBackColor = false;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.Azure;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 30;
            btnUsuarios.Location = new Point(0, 180);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(240, 50);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios ";
            btnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnLibros
            // 
            btnLibros.BackColor = Color.Azure;
            btnLibros.Dock = DockStyle.Top;
            btnLibros.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnLibros.IconColor = Color.Black;
            btnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLibros.IconSize = 30;
            btnLibros.Location = new Point(0, 130);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(240, 50);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "Libros";
            btnLibros.TextAlign = ContentAlignment.MiddleRight;
            btnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLibros.UseVisualStyleBackColor = false;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Azure;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnInicio.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            btnInicio.IconColor = Color.Black;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.IconSize = 30;
            btnInicio.Location = new Point(0, 80);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(240, 50);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleRight;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.DarkTurquoise;
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Controls.Add(lblSubtitulo);
            pnlLogo.Controls.Add(lblTitulo);
            pnlLogo.Controls.Add(label2);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(240, 80);
            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(3, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(95, 50);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(104, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(102, 14);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Sistema de Gestion";
            lblSubtitulo.Click += lblSubtitulo_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Gill Sans MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(104, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(113, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Biblioteca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 31);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 0;
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.PaleTurquoise;
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(240, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(927, 80);
            pnlSuperior.TabIndex = 1;
            // 
            // pnlEstado
            // 
            pnlEstado.BackColor = Color.PaleTurquoise;
            pnlEstado.Dock = DockStyle.Bottom;
            pnlEstado.Location = new Point(240, 481);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(927, 75);
            pnlEstado.TabIndex = 2;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.Azure;
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(240, 80);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(927, 401);
            pnlContenido.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 556);
            Controls.Add(pnlContenido);
            Controls.Add(pnlEstado);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            Text = "Sistema Gestion de Biblioteca";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlSuperior;
        private Panel pnlEstado;
        private Panel pnlContenido;
        private Panel pnlLogo;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnPrestamos;
        private FontAwesome.Sharp.IconButton btnEditoriales;
        private FontAwesome.Sharp.IconButton btnAutores;
        private PictureBox picLogo;
    }
}

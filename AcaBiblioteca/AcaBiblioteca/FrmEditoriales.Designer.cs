namespace AcaBiblioteca
{
    partial class FrmEditoriales
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
            lblTituloEdi = new Label();
            dgvEditoriales = new DataGridView();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel3 = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(lblTituloEdi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 120);
            panel1.TabIndex = 0;
            // 
            // lblTituloEdi
            // 
            lblTituloEdi.AutoSize = true;
            lblTituloEdi.BackColor = Color.Transparent;
            lblTituloEdi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloEdi.ForeColor = Color.White;
            lblTituloEdi.Location = new Point(529, 46);
            lblTituloEdi.Name = "lblTituloEdi";
            lblTituloEdi.Size = new Size(310, 32);
            lblTituloEdi.TabIndex = 1;
            lblTituloEdi.Text = "GESTIÓN DE EDITORIALES";
            // 
            // dgvEditoriales
            // 
            dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditoriales.Location = new Point(192, 467);
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.Size = new Size(1000, 300);
            dgvEditoriales.TabIndex = 2;
            dgvEditoriales.CellDoubleClick += dgvEditoriales_CellDoubleClick;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(518, 125);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(695, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 30;
            btnNuevo.Location = new Point(15, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(125, 50);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(lblNombre);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 231);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(btnNuevo);
            panel3.Location = new Point(321, 372);
            panel3.Name = "panel3";
            panel3.Size = new Size(768, 70);
            panel3.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 30;
            btnCancelar.Location = new Point(620, 3);
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
            btnEliminar.Location = new Point(466, 3);
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
            btnEditar.Location = new Point(315, 3);
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
            btnGuardar.Location = new Point(167, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 50);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1350, 790);
            Controls.Add(panel3);
            Controls.Add(dgvEditoriales);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmEditoriales";
            Text = "FrmEditoriales";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTituloEdi;
        private DataGridView dgvEditoriales;
        private Label lblTituloUsu;
        private Label lblNombre;
        private TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private Panel panel2;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}
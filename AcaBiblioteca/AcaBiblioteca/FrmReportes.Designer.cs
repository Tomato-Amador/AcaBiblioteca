namespace AcaBiblioteca
{
    partial class FrmReportes
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
            lblTituloRep = new Label();
            panel2 = new Panel();
            cmbTipoReporte = new ComboBox();
            lblTipoReporte = new Label();
            btnGenerar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            dgvReportes = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(lblTituloRep);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 120);
            panel1.TabIndex = 0;
            // 
            // lblTituloRep
            // 
            lblTituloRep.AutoSize = true;
            lblTituloRep.BackColor = Color.Transparent;
            lblTituloRep.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRep.ForeColor = Color.White;
            lblTituloRep.Location = new Point(563, 45);
            lblTituloRep.Name = "lblTituloRep";
            lblTituloRep.Size = new Size(279, 32);
            lblTituloRep.TabIndex = 3;
            lblTituloRep.Text = "GESTIÓN DE REPORTES";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(cmbTipoReporte);
            panel2.Controls.Add(lblTipoReporte);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 199);
            panel2.TabIndex = 1;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(665, 102);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(177, 23);
            cmbTipoReporte.TabIndex = 1;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoReporte.Location = new Point(478, 106);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(123, 19);
            lblTipoReporte.TabIndex = 0;
            lblTipoReporte.Text = "Tipo de Reporte:";
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.IconChar = FontAwesome.Sharp.IconChar.TableList;
            btnGenerar.IconColor = Color.Black;
            btnGenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerar.IconSize = 30;
            btnGenerar.Location = new Point(17, 8);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(200, 50);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar reporte";
            btnGenerar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 30;
            btnLimpiar.Location = new Point(280, 8);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 50);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar reporte";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGenerar);
            panel3.Controls.Add(btnLimpiar);
            panel3.Location = new Point(468, 325);
            panel3.Name = "panel3";
            panel3.Size = new Size(505, 73);
            panel3.TabIndex = 4;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(198, 422);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.Size = new Size(1000, 332);
            dgvReportes.TabIndex = 5;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1350, 796);
            Controls.Add(dgvReportes);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmReportes";
            Text = "FrmReportes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTituloRep;
        private Label lblTipoReporte;
        private ComboBox cmbTipoReporte;
        private FontAwesome.Sharp.IconButton btnGenerar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private Panel panel3;
        private DataGridView dgvReportes;
    }
}
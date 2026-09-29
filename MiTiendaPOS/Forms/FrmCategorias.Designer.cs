namespace MiTiendaPOS.Forms
{
    partial class FrmCategorias
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
            lblFiltro = new Label();
            txtBuscar = new TextBox();
            dgvCategorias = new DataGridView();
            grpDatos = new GroupBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(15, 26);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(46, 15);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "BUscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(82, 23);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(246, 23);
            txtBuscar.TabIndex = 1;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(27, 72);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(301, 224);
            dgvCategorias.TabIndex = 2;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Location = new Point(356, 74);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(218, 93);
            grpDatos.TabIndex = 3;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de la Categoría";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(376, 173);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(168, 36);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(376, 215);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(168, 36);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(376, 257);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(168, 39);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 321);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(grpDatos);
            Controls.Add(dgvCategorias);
            Controls.Add(txtBuscar);
            Controls.Add(lblFiltro);
            Name = "FrmCategorias";
            Text = "Mantenimiento Categorías";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFiltro;
        private TextBox txtBuscar;
        private DataGridView dgvCategorias;
        private GroupBox grpDatos;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}
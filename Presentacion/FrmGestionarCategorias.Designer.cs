namespace Presentacion
{
    partial class FrmGestionarCategorias
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
            btnProbarCategoria = new Button();
            dgvListaCategorias = new DataGridView();
            gbDatosCategoria = new GroupBox();
            btnCrearCategoria = new Button();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaCategorias).BeginInit();
            gbDatosCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // btnProbarCategoria
            // 
            btnProbarCategoria.Location = new Point(686, 43);
            btnProbarCategoria.Name = "btnProbarCategoria";
            btnProbarCategoria.Size = new Size(145, 33);
            btnProbarCategoria.TabIndex = 0;
            btnProbarCategoria.Text = "&Probar categoria";
            btnProbarCategoria.UseVisualStyleBackColor = true;
            btnProbarCategoria.Click += btnProbarCategoria_Click;
            // 
            // dgvListaCategorias
            // 
            dgvListaCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCategorias.Location = new Point(63, 254);
            dgvListaCategorias.Name = "dgvListaCategorias";
            dgvListaCategorias.RowHeadersWidth = 51;
            dgvListaCategorias.Size = new Size(617, 190);
            dgvListaCategorias.TabIndex = 1;
            // 
            // gbDatosCategoria
            // 
            gbDatosCategoria.Controls.Add(btnLimpiar);
            gbDatosCategoria.Controls.Add(btnCrearCategoria);
            gbDatosCategoria.Controls.Add(txtDescripcion);
            gbDatosCategoria.Controls.Add(label2);
            gbDatosCategoria.Controls.Add(txtNombre);
            gbDatosCategoria.Controls.Add(label1);
            gbDatosCategoria.Location = new Point(57, 31);
            gbDatosCategoria.Name = "gbDatosCategoria";
            gbDatosCategoria.Size = new Size(623, 198);
            gbDatosCategoria.TabIndex = 2;
            gbDatosCategoria.TabStop = false;
            gbDatosCategoria.Text = "Datos de la categoría";
            // 
            // btnCrearCategoria
            // 
            btnCrearCategoria.BackColor = Color.GreenYellow;
            btnCrearCategoria.Location = new Point(111, 139);
            btnCrearCategoria.Name = "btnCrearCategoria";
            btnCrearCategoria.Size = new Size(143, 36);
            btnCrearCategoria.TabIndex = 4;
            btnCrearCategoria.Text = "&Crear categoría";
            btnCrearCategoria.UseVisualStyleBackColor = false;
            btnCrearCategoria.Click += btnCrearCategoria_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(111, 79);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(479, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 82);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(479, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 255, 255);
            btnLimpiar.Location = new Point(303, 143);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 32);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmGestionarCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 555);
            Controls.Add(gbDatosCategoria);
            Controls.Add(dgvListaCategorias);
            Controls.Add(btnProbarCategoria);
            Name = "FrmGestionarCategorias";
            Text = "Form1";
            Load += FrmGestionarCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaCategorias).EndInit();
            gbDatosCategoria.ResumeLayout(false);
            gbDatosCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProbarCategoria;
        private DataGridView dgvListaCategorias;
        private GroupBox gbDatosCategoria;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Button btnCrearCategoria;
        private Button btnLimpiar;
    }
}

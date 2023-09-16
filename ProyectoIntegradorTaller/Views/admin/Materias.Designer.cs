using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    partial class Materias
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LBienvenido = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BBuscar = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.TBBusqueda = new CustomControls.RJControls.RJTextBox();
            this.BCrearMateria = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemMateriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BVolver = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMateriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(344, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Materia";
            // 
            // LBienvenido
            // 
            this.LBienvenido.AutoSize = true;
            this.LBienvenido.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.LBienvenido.Location = new System.Drawing.Point(12, 51);
            this.LBienvenido.Name = "LBienvenido";
            this.LBienvenido.Size = new System.Drawing.Size(79, 18);
            this.LBienvenido.TabIndex = 3;
            this.LBienvenido.Text = "Materias";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel7.Controls.Add(this.BVolver);
            this.panel7.Controls.Add(this.BBuscar);
            this.panel7.Controls.Add(this.TBBusqueda);
            this.panel7.Controls.Add(this.BCrearMateria);
            this.panel7.Controls.Add(this.LBienvenido);
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Location = new System.Drawing.Point(0, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(686, 358);
            this.panel7.TabIndex = 11;
            // 
            // BBuscar
            // 
            this.BBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BBuscar.BorderRadius = 6;
            this.BBuscar.BorderSize = 0;
            this.BBuscar.FlatAppearance.BorderSize = 0;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Image = global::ProyectoIntegradorTaller.Properties.Resources.search_white;
            this.BBuscar.Location = new System.Drawing.Point(628, 34);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(46, 32);
            this.BBuscar.TabIndex = 11;
            this.BBuscar.TextColor = System.Drawing.Color.White;
            this.BBuscar.UseVisualStyleBackColor = false;
            // 
            // TBBusqueda
            // 
            this.TBBusqueda.BackColor = System.Drawing.SystemColors.Menu;
            this.TBBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TBBusqueda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBBusqueda.BorderRadius = 6;
            this.TBBusqueda.BorderSize = 2;
            this.TBBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBBusqueda.Location = new System.Drawing.Point(435, 35);
            this.TBBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TBBusqueda.Multiline = false;
            this.TBBusqueda.Name = "TBBusqueda";
            this.TBBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBBusqueda.PasswordChar = false;
            this.TBBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBBusqueda.PlaceholderText = "";
            this.TBBusqueda.Size = new System.Drawing.Size(186, 31);
            this.TBBusqueda.TabIndex = 10;
            this.TBBusqueda.Texts = "";
            this.TBBusqueda.UnderlinedStyle = true;
            // 
            // BCrearMateria
            // 
            this.BCrearMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BCrearMateria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BCrearMateria.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BCrearMateria.BorderRadius = 6;
            this.BCrearMateria.BorderSize = 0;
            this.BCrearMateria.FlatAppearance.BorderSize = 0;
            this.BCrearMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCrearMateria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCrearMateria.ForeColor = System.Drawing.Color.White;
            this.BCrearMateria.Image = global::ProyectoIntegradorTaller.Properties.Resources.add;
            this.BCrearMateria.Location = new System.Drawing.Point(524, 305);
            this.BCrearMateria.Name = "BCrearMateria";
            this.BCrearMateria.Size = new System.Drawing.Size(150, 40);
            this.BCrearMateria.TabIndex = 5;
            this.BCrearMateria.Text = "  Crear Materia";
            this.BCrearMateria.TextColor = System.Drawing.Color.White;
            this.BCrearMateria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCrearMateria.UseVisualStyleBackColor = false;
            this.BCrearMateria.Click += new System.EventHandler(this.BCrearMateria_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materiaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemMateriasBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(662, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materiaDataGridViewTextBoxColumn
            // 
            this.materiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materiaDataGridViewTextBoxColumn.DataPropertyName = "Materia";
            this.materiaDataGridViewTextBoxColumn.HeaderText = "Materia";
            this.materiaDataGridViewTextBoxColumn.Name = "materiaDataGridViewTextBoxColumn";
            // 
            // itemMateriasBindingSource
            // 
            this.itemMateriasBindingSource.DataSource = typeof(ProyectoIntegradorTaller.views.admin.ItemMaterias);
            // 
            // BVolver
            // 
            this.BVolver.BackColor = System.Drawing.Color.LimeGreen;
            this.BVolver.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.BVolver.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BVolver.BorderRadius = 6;
            this.BVolver.BorderSize = 0;
            this.BVolver.FlatAppearance.BorderSize = 0;
            this.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVolver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVolver.ForeColor = System.Drawing.Color.AliceBlue;
            this.BVolver.Image = global::ProyectoIntegradorTaller.Properties.Resources.path30;
            this.BVolver.Location = new System.Drawing.Point(15, 305);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(79, 40);
            this.BVolver.TabIndex = 52;
            this.BVolver.Text = "  Volver";
            this.BVolver.TextColor = System.Drawing.Color.AliceBlue;
            this.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BVolver.UseVisualStyleBackColor = false;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMateriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label LCerrar;
        private Label LBienvenido;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel7;
        private DataGridView dataGridView1;
        private Label label1;
        private views.components.BotonPersonalisado BCrearMateria;
        private CustomControls.RJControls.RJTextBox TBBusqueda;
        private views.components.BotonPersonalisado BBuscar;
        private BindingSource itemMateriasBindingSource;
        private DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private components.BotonPersonalisado BVolver;
    }

    #endregion

}
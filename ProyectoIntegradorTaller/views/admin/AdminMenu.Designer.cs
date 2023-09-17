using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    partial class AdminMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBienvenido = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BBuscar = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.TBBusqueda = new CustomControls.RJControls.RJTextBox();
            this.BProfesores = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BMaterias = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BUsuarios = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BCrearAula = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LBienvenido
            // 
            this.LBienvenido.AutoSize = true;
            this.LBienvenido.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.LBienvenido.Location = new System.Drawing.Point(12, 32);
            this.LBienvenido.Name = "LBienvenido";
            this.LBienvenido.Size = new System.Drawing.Size(53, 18);
            this.LBienvenido.TabIndex = 3;
            this.LBienvenido.Text = "Aulas";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel7.Controls.Add(this.BBuscar);
            this.panel7.Controls.Add(this.TBBusqueda);
            this.panel7.Controls.Add(this.BProfesores);
            this.panel7.Controls.Add(this.BMaterias);
            this.panel7.Controls.Add(this.BUsuarios);
            this.panel7.Controls.Add(this.BCrearAula);
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
            this.BBuscar.Location = new System.Drawing.Point(628, 18);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(46, 32);
            this.BBuscar.TabIndex = 10;
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
            this.TBBusqueda.Location = new System.Drawing.Point(435, 19);
            this.TBBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TBBusqueda.Multiline = false;
            this.TBBusqueda.Name = "TBBusqueda";
            this.TBBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBBusqueda.PasswordChar = false;
            this.TBBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBBusqueda.PlaceholderText = "";
            this.TBBusqueda.Size = new System.Drawing.Size(186, 31);
            this.TBBusqueda.TabIndex = 9;
            this.TBBusqueda.Texts = "";
            this.TBBusqueda.UnderlinedStyle = true;
            // 
            // BProfesores
            // 
            this.BProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BProfesores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BProfesores.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BProfesores.BorderRadius = 6;
            this.BProfesores.BorderSize = 0;
            this.BProfesores.FlatAppearance.BorderSize = 0;
            this.BProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProfesores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BProfesores.ForeColor = System.Drawing.Color.White;
            this.BProfesores.Image = global::ProyectoIntegradorTaller.Properties.Resources.badge;
            this.BProfesores.Location = new System.Drawing.Point(56, 306);
            this.BProfesores.Name = "BProfesores";
            this.BProfesores.Size = new System.Drawing.Size(150, 40);
            this.BProfesores.TabIndex = 8;
            this.BProfesores.Text = "  Profesores";
            this.BProfesores.TextColor = System.Drawing.Color.White;
            this.BProfesores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BProfesores.UseVisualStyleBackColor = false;
            this.BProfesores.Click += new System.EventHandler(this.BProfesores_Click);
            // 
            // BMaterias
            // 
            this.BMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BMaterias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BMaterias.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BMaterias.BorderRadius = 6;
            this.BMaterias.BorderSize = 0;
            this.BMaterias.FlatAppearance.BorderSize = 0;
            this.BMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMaterias.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMaterias.ForeColor = System.Drawing.Color.White;
            this.BMaterias.Image = global::ProyectoIntegradorTaller.Properties.Resources.book;
            this.BMaterias.Location = new System.Drawing.Point(212, 306);
            this.BMaterias.Name = "BMaterias";
            this.BMaterias.Size = new System.Drawing.Size(150, 40);
            this.BMaterias.TabIndex = 7;
            this.BMaterias.Text = "  Materias";
            this.BMaterias.TextColor = System.Drawing.Color.White;
            this.BMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BMaterias.UseVisualStyleBackColor = false;
            this.BMaterias.Click += new System.EventHandler(this.BMaterias_Click);
            // 
            // BUsuarios
            // 
            this.BUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BUsuarios.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BUsuarios.BorderRadius = 6;
            this.BUsuarios.BorderSize = 0;
            this.BUsuarios.FlatAppearance.BorderSize = 0;
            this.BUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUsuarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUsuarios.ForeColor = System.Drawing.Color.White;
            this.BUsuarios.Image = global::ProyectoIntegradorTaller.Properties.Resources.person_groups;
            this.BUsuarios.Location = new System.Drawing.Point(368, 306);
            this.BUsuarios.Name = "BUsuarios";
            this.BUsuarios.Size = new System.Drawing.Size(150, 40);
            this.BUsuarios.TabIndex = 6;
            this.BUsuarios.Text = "  Usuarios";
            this.BUsuarios.TextColor = System.Drawing.Color.White;
            this.BUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BUsuarios.UseVisualStyleBackColor = false;
            this.BUsuarios.Click += new System.EventHandler(this.BUsuarios_Click);
            // 
            // BCrearAula
            // 
            this.BCrearAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BCrearAula.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BCrearAula.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BCrearAula.BorderRadius = 6;
            this.BCrearAula.BorderSize = 0;
            this.BCrearAula.FlatAppearance.BorderSize = 0;
            this.BCrearAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCrearAula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCrearAula.ForeColor = System.Drawing.Color.White;
            this.BCrearAula.Image = global::ProyectoIntegradorTaller.Properties.Resources.room;
            this.BCrearAula.Location = new System.Drawing.Point(524, 306);
            this.BCrearAula.Name = "BCrearAula";
            this.BCrearAula.Size = new System.Drawing.Size(150, 40);
            this.BCrearAula.TabIndex = 5;
            this.BCrearAula.Text = "  Crear Aula";
            this.BCrearAula.TextColor = System.Drawing.Color.White;
            this.BCrearAula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCrearAula.UseVisualStyleBackColor = false;
            this.BCrearAula.Click += new System.EventHandler(this.BCrearAula_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lugarDataGridViewTextBoxColumn,
            this.capacidadMaxDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(662, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lugarDataGridViewTextBoxColumn
            // 
            this.lugarDataGridViewTextBoxColumn.DataPropertyName = "Lugar";
            this.lugarDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarDataGridViewTextBoxColumn.Name = "lugarDataGridViewTextBoxColumn";
            // 
            // capacidadMaxDataGridViewTextBoxColumn
            // 
            this.capacidadMaxDataGridViewTextBoxColumn.DataPropertyName = "CapacidadMax";
            this.capacidadMaxDataGridViewTextBoxColumn.HeaderText = "CapacidadMax";
            this.capacidadMaxDataGridViewTextBoxColumn.Name = "capacidadMaxDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(ProyectoIntegradorTaller.views.admin.Item);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(308, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Home";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
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
        private views.components.BotonPersonalisado BCrearAula;
        private views.components.BotonPersonalisado BProfesores;
        private views.components.BotonPersonalisado BMaterias;
        private views.components.BotonPersonalisado BUsuarios;
        private views.components.BotonPersonalisado BBuscar;
        private CustomControls.RJControls.RJTextBox TBBusqueda;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacidadMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private BindingSource itemBindingSource;
        private Label label1;
    }

    #endregion

}
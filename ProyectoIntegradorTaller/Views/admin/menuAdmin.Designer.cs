using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    partial class menuAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.botonPersonalisado1 = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BLugares = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BMaterias = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BCrearAula = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BUsuarios = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CBMateria = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.TBBusqueda = new CustomControls.RJControls.RJTextBox();
            this.BBuscar = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BDatabase = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBMaximizar_
            // 
            this.PBMaximizar_.Location = new System.Drawing.Point(796, 11);
            // 
            // PBMinimizar_
            // 
            this.PBMinimizar_.Location = new System.Drawing.Point(796, 11);
            // 
            // PBCerrar_
            // 
            this.PBCerrar_.Location = new System.Drawing.Point(817, 11);
            // 
            // PBEsconder_
            // 
            this.PBEsconder_.Location = new System.Drawing.Point(775, 12);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aulas";
            // 
            // botonPersonalisado1
            // 
            this.botonPersonalisado1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonPersonalisado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.botonPersonalisado1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.botonPersonalisado1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonPersonalisado1.BorderRadius = 6;
            this.botonPersonalisado1.BorderSize = 0;
            this.botonPersonalisado1.FlatAppearance.BorderSize = 0;
            this.botonPersonalisado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPersonalisado1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPersonalisado1.ForeColor = System.Drawing.Color.White;
            this.botonPersonalisado1.Image = global::ProyectoIntegradorTaller.Properties.Resources.cuenta;
            this.botonPersonalisado1.Location = new System.Drawing.Point(13, 416);
            this.botonPersonalisado1.Name = "botonPersonalisado1";
            this.botonPersonalisado1.Size = new System.Drawing.Size(118, 40);
            this.botonPersonalisado1.TabIndex = 16;
            this.botonPersonalisado1.Text = " Mi Cuenta";
            this.botonPersonalisado1.TextColor = System.Drawing.Color.White;
            this.botonPersonalisado1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonPersonalisado1.UseVisualStyleBackColor = false;
            this.botonPersonalisado1.Click += new System.EventHandler(this.botonPersonalisado1_Click);
            // 
            // BLugares
            // 
            this.BLugares.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BLugares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BLugares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BLugares.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BLugares.BorderRadius = 6;
            this.BLugares.BorderSize = 0;
            this.BLugares.FlatAppearance.BorderSize = 0;
            this.BLugares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLugares.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLugares.ForeColor = System.Drawing.Color.White;
            this.BLugares.Image = global::ProyectoIntegradorTaller.Properties.Resources.map;
            this.BLugares.Location = new System.Drawing.Point(326, 416);
            this.BLugares.Name = "BLugares";
            this.BLugares.Size = new System.Drawing.Size(120, 40);
            this.BLugares.TabIndex = 17;
            this.BLugares.Text = "  Lugares";
            this.BLugares.TextColor = System.Drawing.Color.White;
            this.BLugares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLugares.UseVisualStyleBackColor = false;
            this.BLugares.Click += new System.EventHandler(this.BLugares_Click);
            // 
            // BMaterias
            // 
            this.BMaterias.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.BMaterias.Location = new System.Drawing.Point(456, 416);
            this.BMaterias.Name = "BMaterias";
            this.BMaterias.Size = new System.Drawing.Size(120, 40);
            this.BMaterias.TabIndex = 18;
            this.BMaterias.Text = "  Materias";
            this.BMaterias.TextColor = System.Drawing.Color.White;
            this.BMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BMaterias.UseVisualStyleBackColor = false;
            this.BMaterias.Click += new System.EventHandler(this.BMaterias_Click);
            // 
            // BCrearAula
            // 
            this.BCrearAula.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.BCrearAula.Location = new System.Drawing.Point(714, 416);
            this.BCrearAula.Name = "BCrearAula";
            this.BCrearAula.Size = new System.Drawing.Size(120, 40);
            this.BCrearAula.TabIndex = 19;
            this.BCrearAula.Text = "  Crear Aula";
            this.BCrearAula.TextColor = System.Drawing.Color.White;
            this.BCrearAula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCrearAula.UseVisualStyleBackColor = false;
            this.BCrearAula.Click += new System.EventHandler(this.BCrearAula_Click);
            // 
            // BUsuarios
            // 
            this.BUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.BUsuarios.Location = new System.Drawing.Point(586, 416);
            this.BUsuarios.Name = "BUsuarios";
            this.BUsuarios.Size = new System.Drawing.Size(120, 40);
            this.BUsuarios.TabIndex = 20;
            this.BUsuarios.Text = "  Usuarios";
            this.BUsuarios.TextColor = System.Drawing.Color.White;
            this.BUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BUsuarios.UseVisualStyleBackColor = false;
            this.BUsuarios.Click += new System.EventHandler(this.BUsuarios_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(15, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(820, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CBMateria
            // 
            this.CBMateria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CBMateria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBMateria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBMateria.BorderSize = 2;
            this.CBMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBMateria.ForeColor = System.Drawing.Color.DimGray;
            this.CBMateria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBMateria.Items.AddRange(new object[] {
            "Nombre",
            "Capacidad",
            "Equipamiento"});
            this.CBMateria.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBMateria.ListTextColor = System.Drawing.Color.DimGray;
            this.CBMateria.Location = new System.Drawing.Point(377, 66);
            this.CBMateria.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBMateria.Name = "CBMateria";
            this.CBMateria.Padding = new System.Windows.Forms.Padding(2);
            this.CBMateria.Size = new System.Drawing.Size(200, 30);
            this.CBMateria.TabIndex = 38;
            this.CBMateria.Texts = "";
            // 
            // TBBusqueda
            // 
            this.TBBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TBBusqueda.BackColor = System.Drawing.SystemColors.Menu;
            this.TBBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TBBusqueda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBBusqueda.BorderRadius = 6;
            this.TBBusqueda.BorderSize = 2;
            this.TBBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBBusqueda.Location = new System.Drawing.Point(584, 65);
            this.TBBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TBBusqueda.Multiline = false;
            this.TBBusqueda.Name = "TBBusqueda";
            this.TBBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBBusqueda.PasswordChar = false;
            this.TBBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBBusqueda.PlaceholderText = "";
            this.TBBusqueda.Size = new System.Drawing.Size(186, 31);
            this.TBBusqueda.TabIndex = 39;
            this.TBBusqueda.Texts = "";
            this.TBBusqueda.UnderlinedStyle = true;
            this.TBBusqueda._TextChanged += new System.EventHandler(this.BBusqueda__TextChanged);
            // 
            // BBuscar
            // 
            this.BBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.BBuscar.Location = new System.Drawing.Point(777, 65);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(46, 32);
            this.BBuscar.TabIndex = 40;
            this.BBuscar.TextColor = System.Drawing.Color.White;
            this.BBuscar.UseVisualStyleBackColor = false;
            // 
            // BDatabase
            // 
            this.BDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BDatabase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BDatabase.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BDatabase.BorderRadius = 6;
            this.BDatabase.BorderSize = 0;
            this.BDatabase.FlatAppearance.BorderSize = 0;
            this.BDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDatabase.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDatabase.ForeColor = System.Drawing.Color.White;
            this.BDatabase.Image = global::ProyectoIntegradorTaller.Properties.Resources.database1;
            this.BDatabase.Location = new System.Drawing.Point(198, 416);
            this.BDatabase.Name = "BDatabase";
            this.BDatabase.Size = new System.Drawing.Size(122, 40);
            this.BDatabase.TabIndex = 41;
            this.BDatabase.Text = "  Database";
            this.BDatabase.TextColor = System.Drawing.Color.White;
            this.BDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BDatabase.UseVisualStyleBackColor = false;
            this.BDatabase.Click += new System.EventHandler(this.BDatabase_Click);
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 484);
            this.Controls.Add(this.BDatabase);
            this.Controls.Add(this.TBBusqueda);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.CBMateria);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BCrearAula);
            this.Controls.Add(this.BUsuarios);
            this.Controls.Add(this.BMaterias);
            this.Controls.Add(this.BLugares);
            this.Controls.Add(this.botonPersonalisado1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuAdmin";
            this.Text = "menuAdmin";
            this.Load += new System.EventHandler(this.menuAdmin_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.botonPersonalisado1, 0);
            this.Controls.SetChildIndex(this.BLugares, 0);
            this.Controls.SetChildIndex(this.BMaterias, 0);
            this.Controls.SetChildIndex(this.BUsuarios, 0);
            this.Controls.SetChildIndex(this.BCrearAula, 0);
            this.Controls.SetChildIndex(this.PBEsconder_, 0);
            this.Controls.SetChildIndex(this.PBMinimizar_, 0);
            this.Controls.SetChildIndex(this.PBMaximizar_, 0);
            this.Controls.SetChildIndex(this.PBCerrar_, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.CBMateria, 0);
            this.Controls.SetChildIndex(this.BBuscar, 0);
            this.Controls.SetChildIndex(this.TBBusqueda, 0);
            this.Controls.SetChildIndex(this.BDatabase, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private components.BotonPersonalisado botonPersonalisado1;
        private components.BotonPersonalisado BLugares;
        private components.BotonPersonalisado BMaterias;
        private components.BotonPersonalisado BCrearAula;
        private components.BotonPersonalisado BUsuarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private components.ComboBoxPersonalisado CBMateria;
        private CustomControls.RJControls.RJTextBox TBBusqueda;
        private components.BotonPersonalisado BBuscar;
        private components.BotonPersonalisado BDatabase;
    }
}
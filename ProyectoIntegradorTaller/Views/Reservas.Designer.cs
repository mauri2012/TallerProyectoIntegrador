using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    partial class Reservas
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.BVolver = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.CBDias = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.horaDesdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaHastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemReservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemReservasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel7.Controls.Add(this.BVolver);
            this.panel7.Controls.Add(this.CBDias);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Location = new System.Drawing.Point(0, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(686, 358);
            this.panel7.TabIndex = 11;
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
            this.BVolver.Location = new System.Drawing.Point(12, 306);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(100, 40);
            this.BVolver.TabIndex = 52;
            this.BVolver.Text = "  Volver";
            this.BVolver.TextColor = System.Drawing.Color.AliceBlue;
            this.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BVolver.UseVisualStyleBackColor = false;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // CBDias
            // 
            this.CBDias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBDias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBDias.BorderSize = 2;
            this.CBDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBDias.ForeColor = System.Drawing.Color.DimGray;
            this.CBDias.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBDias.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBDias.ListTextColor = System.Drawing.Color.DimGray;
            this.CBDias.Location = new System.Drawing.Point(474, 19);
            this.CBDias.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBDias.Name = "CBDias";
            this.CBDias.Padding = new System.Windows.Forms.Padding(2);
            this.CBDias.Size = new System.Drawing.Size(200, 30);
            this.CBDias.TabIndex = 41;
            this.CBDias.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "Dia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horaDesdeDataGridViewTextBoxColumn,
            this.horaHastaDataGridViewTextBoxColumn,
            this.desdeDataGridViewTextBoxColumn,
            this.hastaDataGridViewTextBoxColumn,
            this.materiasDataGridViewTextBoxColumn,
            this.profesorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemReservasBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(662, 245);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // horaDesdeDataGridViewTextBoxColumn
            // 
            this.horaDesdeDataGridViewTextBoxColumn.DataPropertyName = "HoraDesde";
            this.horaDesdeDataGridViewTextBoxColumn.HeaderText = "HoraDesde";
            this.horaDesdeDataGridViewTextBoxColumn.Name = "horaDesdeDataGridViewTextBoxColumn";
            // 
            // horaHastaDataGridViewTextBoxColumn
            // 
            this.horaHastaDataGridViewTextBoxColumn.DataPropertyName = "HoraHasta";
            this.horaHastaDataGridViewTextBoxColumn.HeaderText = "HoraHasta";
            this.horaHastaDataGridViewTextBoxColumn.Name = "horaHastaDataGridViewTextBoxColumn";
            // 
            // desdeDataGridViewTextBoxColumn
            // 
            this.desdeDataGridViewTextBoxColumn.DataPropertyName = "Desde";
            this.desdeDataGridViewTextBoxColumn.HeaderText = "Desde";
            this.desdeDataGridViewTextBoxColumn.Name = "desdeDataGridViewTextBoxColumn";
            // 
            // hastaDataGridViewTextBoxColumn
            // 
            this.hastaDataGridViewTextBoxColumn.DataPropertyName = "Hasta";
            this.hastaDataGridViewTextBoxColumn.HeaderText = "Hasta";
            this.hastaDataGridViewTextBoxColumn.Name = "hastaDataGridViewTextBoxColumn";
            // 
            // materiasDataGridViewTextBoxColumn
            // 
            this.materiasDataGridViewTextBoxColumn.DataPropertyName = "Materias";
            this.materiasDataGridViewTextBoxColumn.HeaderText = "Materias";
            this.materiasDataGridViewTextBoxColumn.Name = "materiasDataGridViewTextBoxColumn";
            // 
            // profesorDataGridViewTextBoxColumn
            // 
            this.profesorDataGridViewTextBoxColumn.DataPropertyName = "Profesor";
            this.profesorDataGridViewTextBoxColumn.HeaderText = "Profesor";
            this.profesorDataGridViewTextBoxColumn.Name = "profesorDataGridViewTextBoxColumn";
            // 
            // itemReservasBindingSource
            // 
            this.itemReservasBindingSource.DataSource = typeof(ProyectoIntegradorTaller.views.admin.ItemReservas);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(300, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reservas";
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservas";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Reservas_Load);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemReservasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label LCerrar;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel7;
        private DataGridView dataGridView1;
        private views.components.ComboBoxPersonalisado CBDias;
        private Label label5;
        private DataGridViewTextBoxColumn horaDesdeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaHastaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn desdeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hastaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materiasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profesorDataGridViewTextBoxColumn;
        private BindingSource itemReservasBindingSource;
        private Label label1;
        private components.BotonPersonalisado BVolver;
    }

    #endregion

}
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BMaximizar = new System.Windows.Forms.PictureBox();
            this.BEsconder = new System.Windows.Forms.PictureBox();
            this.BRestaurar = new System.Windows.Forms.PictureBox();
            this.BCerrar = new System.Windows.Forms.PictureBox();
            this.LBienvenido = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BCrearAula = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEsconder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCerrar)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.BMaximizar);
            this.panel3.Controls.Add(this.BEsconder);
            this.panel3.Controls.Add(this.BRestaurar);
            this.panel3.Controls.Add(this.BCerrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 32);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(309, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Home";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 0;
            // 
            // BMaximizar
            // 
            this.BMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BMaximizar.Image")));
            this.BMaximizar.Location = new System.Drawing.Point(646, 10);
            this.BMaximizar.Name = "BMaximizar";
            this.BMaximizar.Size = new System.Drawing.Size(13, 13);
            this.BMaximizar.TabIndex = 5;
            this.BMaximizar.TabStop = false;
            this.BMaximizar.Click += new System.EventHandler(this.BMaximizar_Click);
            // 
            // BEsconder
            // 
            this.BEsconder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BEsconder.Image = ((System.Drawing.Image)(resources.GetObject("BEsconder.Image")));
            this.BEsconder.Location = new System.Drawing.Point(628, 10);
            this.BEsconder.Name = "BEsconder";
            this.BEsconder.Size = new System.Drawing.Size(13, 13);
            this.BEsconder.TabIndex = 4;
            this.BEsconder.TabStop = false;
            this.BEsconder.Click += new System.EventHandler(this.BEsconder_Click);
            // 
            // BRestaurar
            // 
            this.BRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BRestaurar.Image")));
            this.BRestaurar.Location = new System.Drawing.Point(646, 10);
            this.BRestaurar.Name = "BRestaurar";
            this.BRestaurar.Size = new System.Drawing.Size(13, 13);
            this.BRestaurar.TabIndex = 6;
            this.BRestaurar.TabStop = false;
            this.BRestaurar.Click += new System.EventHandler(this.BRestaurar_Click);
            // 
            // BCerrar
            // 
            this.BCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BCerrar.Image")));
            this.BCerrar.Location = new System.Drawing.Point(664, 10);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(13, 13);
            this.BCerrar.TabIndex = 3;
            this.BCerrar.TabStop = false;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // LBienvenido
            // 
            this.LBienvenido.AutoSize = true;
            this.LBienvenido.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.LBienvenido.Location = new System.Drawing.Point(37, 27);
            this.LBienvenido.Name = "LBienvenido";
            this.LBienvenido.Size = new System.Drawing.Size(53, 18);
            this.LBienvenido.TabIndex = 3;
            this.LBienvenido.Text = "Aulas";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel7.Controls.Add(this.BCrearAula);
            this.panel7.Controls.Add(this.LBienvenido);
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Location = new System.Drawing.Point(0, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(686, 358);
            this.panel7.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(37, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(646, 156);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.BCrearAula.ForeColor = System.Drawing.Color.White;
            this.BCrearAula.Location = new System.Drawing.Point(524, 306);
            this.BCrearAula.Name = "BCrearAula";
            this.BCrearAula.Size = new System.Drawing.Size(150, 40);
            this.BCrearAula.TabIndex = 5;
            this.BCrearAula.Text = "Crear Aula";
            this.BCrearAula.TextColor = System.Drawing.Color.White;
            this.BCrearAula.UseVisualStyleBackColor = false;
            this.BCrearAula.Click += new System.EventHandler(this.BCrearAula_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEsconder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCerrar)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label LCerrar;
        private PictureBox BCerrar;
        private PictureBox BEsconder;
        private PictureBox BMaximizar;
        private PictureBox BRestaurar;
        private Label LBienvenido;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel7;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label1;
        private views.components.BotonPersonalisado BCrearAula;
    }

    #endregion

}
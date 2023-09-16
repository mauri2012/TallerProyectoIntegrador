using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    partial class Reporte
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPersonalisado4 = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.BGuardar = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.comboBoxPersonalisado3 = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BVolver = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.timePickerPersonalisado2 = new ProyectoIntegradorTaller.views.components.TimePickerPersonalisado();
            this.timePickerPersonalisado1 = new ProyectoIntegradorTaller.views.components.TimePickerPersonalisado();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BReservarAula = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(131, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dia includos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(110, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rango horario";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.BReservarAula);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 358);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.comboBoxPersonalisado4);
            this.panel4.Controls.Add(this.BGuardar);
            this.panel4.Controls.Add(this.comboBoxPersonalisado3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(329, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 358);
            this.panel4.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(-49, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Generar Reporte";
            // 
            // comboBoxPersonalisado4
            // 
            this.comboBoxPersonalisado4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxPersonalisado4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.comboBoxPersonalisado4.BorderSize = 2;
            this.comboBoxPersonalisado4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxPersonalisado4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxPersonalisado4.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxPersonalisado4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.comboBoxPersonalisado4.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxPersonalisado4.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxPersonalisado4.Location = new System.Drawing.Point(33, 105);
            this.comboBoxPersonalisado4.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxPersonalisado4.Name = "comboBoxPersonalisado4";
            this.comboBoxPersonalisado4.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxPersonalisado4.Size = new System.Drawing.Size(228, 30);
            this.comboBoxPersonalisado4.TabIndex = 48;
            this.comboBoxPersonalisado4.Texts = "";
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BGuardar.BorderRadius = 6;
            this.BGuardar.BorderSize = 0;
            this.BGuardar.FlatAppearance.BorderSize = 0;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.White;
            this.BGuardar.Image = global::ProyectoIntegradorTaller.Properties.Resources.save;
            this.BGuardar.Location = new System.Drawing.Point(195, 306);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(150, 40);
            this.BGuardar.TabIndex = 38;
            this.BGuardar.Text = "  Guardar";
            this.BGuardar.TextColor = System.Drawing.Color.White;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            // 
            // comboBoxPersonalisado3
            // 
            this.comboBoxPersonalisado3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxPersonalisado3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.comboBoxPersonalisado3.BorderSize = 2;
            this.comboBoxPersonalisado3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxPersonalisado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxPersonalisado3.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxPersonalisado3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.comboBoxPersonalisado3.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxPersonalisado3.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxPersonalisado3.Location = new System.Drawing.Point(33, 182);
            this.comboBoxPersonalisado3.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxPersonalisado3.Name = "comboBoxPersonalisado3";
            this.comboBoxPersonalisado3.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxPersonalisado3.Size = new System.Drawing.Size(228, 30);
            this.comboBoxPersonalisado3.TabIndex = 47;
            this.comboBoxPersonalisado3.Texts = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoIntegradorTaller.Properties.Resources.Time;
            this.pictureBox3.Location = new System.Drawing.Point(267, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoIntegradorTaller.Properties.Resources.Time;
            this.pictureBox4.Location = new System.Drawing.Point(267, 182);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyectoIntegradorTaller.Properties.Resources.Time;
            this.pictureBox5.Location = new System.Drawing.Point(450, 220);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProyectoIntegradorTaller.Properties.Resources.Time;
            this.pictureBox6.Location = new System.Drawing.Point(450, 161);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 44;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Hasta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(34, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Desde";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BVolver);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.timePickerPersonalisado2);
            this.panel1.Controls.Add(this.timePickerPersonalisado1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 358);
            this.panel1.TabIndex = 31;
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
            this.BVolver.ForeColor = System.Drawing.Color.White;
            this.BVolver.Image = global::ProyectoIntegradorTaller.Properties.Resources.path30;
            this.BVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BVolver.Location = new System.Drawing.Point(43, 306);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(79, 40);
            this.BVolver.TabIndex = 49;
            this.BVolver.Text = "  Volver";
            this.BVolver.TextColor = System.Drawing.Color.White;
            this.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BVolver.UseVisualStyleBackColor = false;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // timePickerPersonalisado2
            // 
            this.timePickerPersonalisado2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.timePickerPersonalisado2.BorderSize = 0;
            this.timePickerPersonalisado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.timePickerPersonalisado2.Location = new System.Drawing.Point(43, 106);
            this.timePickerPersonalisado2.MinimumSize = new System.Drawing.Size(4, 35);
            this.timePickerPersonalisado2.Name = "timePickerPersonalisado2";
            this.timePickerPersonalisado2.Size = new System.Drawing.Size(234, 35);
            this.timePickerPersonalisado2.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.timePickerPersonalisado2.TabIndex = 46;
            this.timePickerPersonalisado2.TextColor = System.Drawing.Color.White;
            // 
            // timePickerPersonalisado1
            // 
            this.timePickerPersonalisado1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.timePickerPersonalisado1.BorderSize = 0;
            this.timePickerPersonalisado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.timePickerPersonalisado1.Location = new System.Drawing.Point(43, 182);
            this.timePickerPersonalisado1.MinimumSize = new System.Drawing.Size(4, 35);
            this.timePickerPersonalisado1.Name = "timePickerPersonalisado1";
            this.timePickerPersonalisado1.Size = new System.Drawing.Size(234, 35);
            this.timePickerPersonalisado1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.timePickerPersonalisado1.TabIndex = 41;
            this.timePickerPersonalisado1.TextColor = System.Drawing.Color.White;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(40, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Fecha desde";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(40, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "Fecha hasta";
            // 
            // BReservarAula
            // 
            this.BReservarAula.Location = new System.Drawing.Point(0, 0);
            this.BReservarAula.Name = "BReservarAula";
            this.BReservarAula.Size = new System.Drawing.Size(64, 20);
            this.BReservarAula.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(270, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Generar Reporte";
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte";
            this.Text = "ReservarAula";
            this.Load += new System.EventHandler(this.Reporte_Load);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button BReservarAula;
        private Label label8;
        private Panel panel1;
        private Panel panel4;
        private views.components.BotonPersonalisado BGuardar;
        private views.components.ComboBoxPersonalisado comboBoxPersonalisado4;
        private views.components.ComboBoxPersonalisado comboBoxPersonalisado3;
        private views.components.TimePickerPersonalisado timePickerPersonalisado2;
        private views.components.TimePickerPersonalisado timePickerPersonalisado1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label12;
        private Label label11;
        private Label label2;
        private Label label10;
        private Label label6;
        private components.BotonPersonalisado BVolver;
    }
}
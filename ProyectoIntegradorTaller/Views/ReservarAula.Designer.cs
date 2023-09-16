using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    partial class ReservarAula
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBDias = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.CBHasta = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.CBDesde = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.CBPRofesor = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.CBMateria = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.timePickerPersonalisado2 = new ProyectoIntegradorTaller.views.components.TimePickerPersonalisado();
            this.botonPersonalisado1 = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.timePickerPersonalisado1 = new ProyectoIntegradorTaller.views.components.TimePickerPersonalisado();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.BVolver = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.BVolver);
            this.panel1.Controls.Add(this.CBDias);
            this.panel1.Controls.Add(this.CBHasta);
            this.panel1.Controls.Add(this.CBDesde);
            this.panel1.Controls.Add(this.CBPRofesor);
            this.panel1.Controls.Add(this.CBMateria);
            this.panel1.Controls.Add(this.timePickerPersonalisado2);
            this.panel1.Controls.Add(this.botonPersonalisado1);
            this.panel1.Controls.Add(this.timePickerPersonalisado1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 384);
            this.panel1.TabIndex = 0;
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
            this.CBDias.Location = new System.Drawing.Point(357, 76);
            this.CBDias.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBDias.Name = "CBDias";
            this.CBDias.Padding = new System.Windows.Forms.Padding(2);
            this.CBDias.Size = new System.Drawing.Size(228, 30);
            this.CBDias.TabIndex = 39;
            this.CBDias.Texts = "";
            // 
            // CBHasta
            // 
            this.CBHasta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBHasta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBHasta.BorderSize = 2;
            this.CBHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBHasta.ForeColor = System.Drawing.Color.DimGray;
            this.CBHasta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBHasta.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBHasta.ListTextColor = System.Drawing.Color.DimGray;
            this.CBHasta.Location = new System.Drawing.Point(357, 189);
            this.CBHasta.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBHasta.Name = "CBHasta";
            this.CBHasta.Padding = new System.Windows.Forms.Padding(2);
            this.CBHasta.Size = new System.Drawing.Size(228, 30);
            this.CBHasta.TabIndex = 38;
            this.CBHasta.Texts = "";
            // 
            // CBDesde
            // 
            this.CBDesde.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBDesde.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBDesde.BorderSize = 2;
            this.CBDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBDesde.ForeColor = System.Drawing.Color.DimGray;
            this.CBDesde.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBDesde.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBDesde.ListTextColor = System.Drawing.Color.DimGray;
            this.CBDesde.Location = new System.Drawing.Point(357, 130);
            this.CBDesde.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBDesde.Name = "CBDesde";
            this.CBDesde.Padding = new System.Windows.Forms.Padding(2);
            this.CBDesde.Size = new System.Drawing.Size(228, 30);
            this.CBDesde.TabIndex = 37;
            this.CBDesde.Texts = "";
            // 
            // CBPRofesor
            // 
            this.CBPRofesor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBPRofesor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBPRofesor.BorderSize = 2;
            this.CBPRofesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBPRofesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBPRofesor.ForeColor = System.Drawing.Color.DimGray;
            this.CBPRofesor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBPRofesor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBPRofesor.ListTextColor = System.Drawing.Color.DimGray;
            this.CBPRofesor.Location = new System.Drawing.Point(95, 78);
            this.CBPRofesor.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBPRofesor.Name = "CBPRofesor";
            this.CBPRofesor.Padding = new System.Windows.Forms.Padding(2);
            this.CBPRofesor.Size = new System.Drawing.Size(228, 30);
            this.CBPRofesor.TabIndex = 36;
            this.CBPRofesor.Texts = "";
            // 
            // CBMateria
            // 
            this.CBMateria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBMateria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBMateria.BorderSize = 2;
            this.CBMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBMateria.ForeColor = System.Drawing.Color.DimGray;
            this.CBMateria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBMateria.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBMateria.ListTextColor = System.Drawing.Color.DimGray;
            this.CBMateria.Location = new System.Drawing.Point(95, 130);
            this.CBMateria.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBMateria.Name = "CBMateria";
            this.CBMateria.Padding = new System.Windows.Forms.Padding(2);
            this.CBMateria.Size = new System.Drawing.Size(225, 30);
            this.CBMateria.TabIndex = 35;
            this.CBMateria.Texts = "";
            // 
            // timePickerPersonalisado2
            // 
            this.timePickerPersonalisado2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.timePickerPersonalisado2.BorderSize = 0;
            this.timePickerPersonalisado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.timePickerPersonalisado2.Location = new System.Drawing.Point(92, 184);
            this.timePickerPersonalisado2.MinimumSize = new System.Drawing.Size(4, 35);
            this.timePickerPersonalisado2.Name = "timePickerPersonalisado2";
            this.timePickerPersonalisado2.Size = new System.Drawing.Size(231, 35);
            this.timePickerPersonalisado2.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.timePickerPersonalisado2.TabIndex = 34;
            this.timePickerPersonalisado2.TextColor = System.Drawing.Color.White;
            // 
            // botonPersonalisado1
            // 
            this.botonPersonalisado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.botonPersonalisado1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.botonPersonalisado1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonPersonalisado1.BorderRadius = 6;
            this.botonPersonalisado1.BorderSize = 0;
            this.botonPersonalisado1.FlatAppearance.BorderSize = 0;
            this.botonPersonalisado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPersonalisado1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPersonalisado1.ForeColor = System.Drawing.Color.White;
            this.botonPersonalisado1.Location = new System.Drawing.Point(524, 309);
            this.botonPersonalisado1.Name = "botonPersonalisado1";
            this.botonPersonalisado1.Size = new System.Drawing.Size(150, 40);
            this.botonPersonalisado1.TabIndex = 8;
            this.botonPersonalisado1.Text = "Reservar Aula";
            this.botonPersonalisado1.TextColor = System.Drawing.Color.White;
            this.botonPersonalisado1.UseVisualStyleBackColor = false;
            // 
            // timePickerPersonalisado1
            // 
            this.timePickerPersonalisado1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.timePickerPersonalisado1.BorderSize = 0;
            this.timePickerPersonalisado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.timePickerPersonalisado1.Location = new System.Drawing.Point(92, 243);
            this.timePickerPersonalisado1.MinimumSize = new System.Drawing.Size(4, 35);
            this.timePickerPersonalisado1.Name = "timePickerPersonalisado1";
            this.timePickerPersonalisado1.Size = new System.Drawing.Size(231, 35);
            this.timePickerPersonalisado1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.timePickerPersonalisado1.TabIndex = 9;
            this.timePickerPersonalisado1.TextColor = System.Drawing.Color.White;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoIntegradorTaller.Properties.Resources.Time;
            this.pictureBox4.Location = new System.Drawing.Point(591, 189);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoIntegradorTaller.Properties.Resources.Time;
            this.pictureBox3.Location = new System.Drawing.Point(591, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(354, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(354, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(92, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Profesor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 358);
            this.panel2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(287, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Reservar Aula";
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
            this.BVolver.Location = new System.Drawing.Point(32, 309);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(79, 40);
            this.BVolver.TabIndex = 52;
            this.BVolver.Text = "  Volver";
            this.BVolver.TextColor = System.Drawing.Color.AliceBlue;
            this.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BVolver.UseVisualStyleBackColor = false;
            // 
            // ReservarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservarAula";
            this.Text = "ReservarAula";
            this.Load += new System.EventHandler(this.LoadReservarAula);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label label8;
        private views.components.BotonPersonalisado botonPersonalisado1;
        private views.components.TimePickerPersonalisado timePickerPersonalisado1;
        private views.components.ComboBoxPersonalisado CBMateria;
        private views.components.TimePickerPersonalisado timePickerPersonalisado2;
        private views.components.ComboBoxPersonalisado CBPRofesor;
        private views.components.ComboBoxPersonalisado CBDias;
        private views.components.ComboBoxPersonalisado CBHasta;
        private views.components.ComboBoxPersonalisado CBDesde;
        private components.BotonPersonalisado BVolver;
    }
}
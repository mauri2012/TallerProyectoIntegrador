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
            this.BEliminar = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.Periodo = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.BVolver = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.CBDia = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.CBHora = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.CBPRofesor = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.CBMateria = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.fecha_desde = new ProyectoIntegradorTaller.views.components.TimePickerPersonalisado();
            this.BReservarAula = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.fecha_hasta = new ProyectoIntegradorTaller.views.components.TimePickerPersonalisado();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.BImprimir = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBMaximizar_
            // 
            this.PBMaximizar_.Location = new System.Drawing.Point(646, 11);
            // 
            // PBCerrar_
            // 
            this.PBCerrar_.Location = new System.Drawing.Point(666, 11);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.BImprimir);
            this.panel1.Controls.Add(this.BEliminar);
            this.panel1.Controls.Add(this.Periodo);
            this.panel1.Controls.Add(this.BVolver);
            this.panel1.Controls.Add(this.CBDia);
            this.panel1.Controls.Add(this.CBHora);
            this.panel1.Controls.Add(this.CBPRofesor);
            this.panel1.Controls.Add(this.CBMateria);
            this.panel1.Controls.Add(this.fecha_desde);
            this.panel1.Controls.Add(this.BReservarAula);
            this.panel1.Controls.Add(this.fecha_hasta);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 388);
            this.panel1.TabIndex = 0;
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.Color.Red;
            this.BEliminar.BackgroundColor = System.Drawing.Color.Red;
            this.BEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BEliminar.BorderRadius = 6;
            this.BEliminar.BorderSize = 0;
            this.BEliminar.FlatAppearance.BorderSize = 0;
            this.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminar.ForeColor = System.Drawing.Color.White;
            this.BEliminar.Image = global::ProyectoIntegradorTaller.Properties.Resources.delete;
            this.BEliminar.Location = new System.Drawing.Point(368, 309);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(150, 40);
            this.BEliminar.TabIndex = 54;
            this.BEliminar.Text = "  Eliminar ";
            this.BEliminar.TextColor = System.Drawing.Color.White;
            this.BEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEliminar.UseVisualStyleBackColor = false;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // Periodo
            // 
            this.Periodo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Periodo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Periodo.BorderSize = 1;
            this.Periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.Periodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Periodo.ForeColor = System.Drawing.Color.DimGray;
            this.Periodo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.Periodo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.Periodo.ListTextColor = System.Drawing.Color.DimGray;
            this.Periodo.Location = new System.Drawing.Point(92, 189);
            this.Periodo.MinimumSize = new System.Drawing.Size(200, 30);
            this.Periodo.Name = "Periodo";
            this.Periodo.Padding = new System.Windows.Forms.Padding(1);
            this.Periodo.Size = new System.Drawing.Size(244, 30);
            this.Periodo.TabIndex = 53;
            this.Periodo.Texts = "";
            this.Periodo.OnSelectedIndexChanged += new System.EventHandler(this.Periodo_OnSelectedIndexChanged);
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
            this.BVolver.Location = new System.Drawing.Point(12, 303);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(100, 40);
            this.BVolver.TabIndex = 52;
            this.BVolver.Text = "  Volver";
            this.BVolver.TextColor = System.Drawing.Color.AliceBlue;
            this.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BVolver.UseVisualStyleBackColor = false;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click_1);
            // 
            // CBDia
            // 
            this.CBDia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBDia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBDia.BorderSize = 2;
            this.CBDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBDia.ForeColor = System.Drawing.Color.DimGray;
            this.CBDia.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBDia.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBDia.ListTextColor = System.Drawing.Color.DimGray;
            this.CBDia.Location = new System.Drawing.Point(386, 76);
            this.CBDia.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBDia.Name = "CBDia";
            this.CBDia.Padding = new System.Windows.Forms.Padding(2);
            this.CBDia.Size = new System.Drawing.Size(244, 30);
            this.CBDia.TabIndex = 39;
            this.CBDia.Texts = "";
            // 
            // CBHora
            // 
            this.CBHora.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBHora.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBHora.BorderSize = 2;
            this.CBHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBHora.ForeColor = System.Drawing.Color.DimGray;
            this.CBHora.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBHora.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBHora.ListTextColor = System.Drawing.Color.DimGray;
            this.CBHora.Location = new System.Drawing.Point(95, 76);
            this.CBHora.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBHora.Name = "CBHora";
            this.CBHora.Padding = new System.Windows.Forms.Padding(2);
            this.CBHora.Size = new System.Drawing.Size(241, 30);
            this.CBHora.TabIndex = 37;
            this.CBHora.Texts = "";
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
            this.CBPRofesor.Location = new System.Drawing.Point(386, 130);
            this.CBPRofesor.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBPRofesor.Name = "CBPRofesor";
            this.CBPRofesor.Padding = new System.Windows.Forms.Padding(2);
            this.CBPRofesor.Size = new System.Drawing.Size(244, 30);
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
            this.CBMateria.Location = new System.Drawing.Point(92, 130);
            this.CBMateria.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBMateria.Name = "CBMateria";
            this.CBMateria.Padding = new System.Windows.Forms.Padding(2);
            this.CBMateria.Size = new System.Drawing.Size(244, 30);
            this.CBMateria.TabIndex = 35;
            this.CBMateria.Texts = "";
            // 
            // fecha_desde
            // 
            this.fecha_desde.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fecha_desde.BorderSize = 0;
            this.fecha_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.fecha_desde.Location = new System.Drawing.Point(386, 189);
            this.fecha_desde.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.fecha_desde.MinDate = new System.DateTime(2023, 1, 18, 0, 0, 0, 0);
            this.fecha_desde.MinimumSize = new System.Drawing.Size(4, 35);
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.Size = new System.Drawing.Size(244, 35);
            this.fecha_desde.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.fecha_desde.TabIndex = 34;
            this.fecha_desde.TextColor = System.Drawing.Color.White;
            this.fecha_desde.ValueChanged += new System.EventHandler(this.fecha_desde_ValueChanged);
            // 
            // BReservarAula
            // 
            this.BReservarAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BReservarAula.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BReservarAula.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BReservarAula.BorderRadius = 6;
            this.BReservarAula.BorderSize = 0;
            this.BReservarAula.FlatAppearance.BorderSize = 0;
            this.BReservarAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReservarAula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BReservarAula.ForeColor = System.Drawing.Color.White;
            this.BReservarAula.Location = new System.Drawing.Point(524, 309);
            this.BReservarAula.Name = "BReservarAula";
            this.BReservarAula.Size = new System.Drawing.Size(150, 40);
            this.BReservarAula.TabIndex = 8;
            this.BReservarAula.Text = "Reservar Aula";
            this.BReservarAula.TextColor = System.Drawing.Color.White;
            this.BReservarAula.UseVisualStyleBackColor = false;
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fecha_hasta.BorderSize = 0;
            this.fecha_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.fecha_hasta.Location = new System.Drawing.Point(386, 246);
            this.fecha_hasta.MinimumSize = new System.Drawing.Size(4, 35);
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.Size = new System.Drawing.Size(244, 35);
            this.fecha_hasta.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.fecha_hasta.TabIndex = 9;
            this.fecha_hasta.TextColor = System.Drawing.Color.White;
            this.fecha_hasta.ValueChanged += new System.EventHandler(this.fecha_hasta_ValueChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoIntegradorTaller.Properties.Resources.Time;
            this.pictureBox4.Location = new System.Drawing.Point(342, 76);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(96, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dia";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(383, 163);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(51, 18);
            this.fecha.TabIndex = 8;
            this.fecha.Text = "Fecha";
            this.fecha.Click += new System.EventHandler(this.fecha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(92, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Periodo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 109);
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
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            // BImprimir
            // 
            this.BImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BImprimir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BImprimir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BImprimir.BorderRadius = 6;
            this.BImprimir.BorderSize = 0;
            this.BImprimir.FlatAppearance.BorderSize = 0;
            this.BImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BImprimir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BImprimir.ForeColor = System.Drawing.Color.White;
            this.BImprimir.Image = global::ProyectoIntegradorTaller.Properties.Resources.save;
            this.BImprimir.Location = new System.Drawing.Point(175, 309);
            this.BImprimir.Name = "BImprimir";
            this.BImprimir.Size = new System.Drawing.Size(187, 40);
            this.BImprimir.TabIndex = 55;
            this.BImprimir.Text = " Imprimir Comprobante";
            this.BImprimir.TextColor = System.Drawing.Color.White;
            this.BImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BImprimir.UseVisualStyleBackColor = false;
            this.BImprimir.Click += new System.EventHandler(this.BImprimir_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservarAula";
            this.Controls.SetChildIndex(this.PBEsconder_, 0);
            this.Controls.SetChildIndex(this.PBMinimizar_, 0);
            this.Controls.SetChildIndex(this.PBMaximizar_, 0);
            this.Controls.SetChildIndex(this.PBCerrar_, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label fecha;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Label label8;
        private views.components.BotonPersonalisado BReservarAula;
        private views.components.TimePickerPersonalisado fecha_hasta;
        private views.components.ComboBoxPersonalisado CBMateria;
        private views.components.TimePickerPersonalisado fecha_desde;
        private views.components.ComboBoxPersonalisado CBPRofesor;
        private views.components.ComboBoxPersonalisado CBDia;
        private views.components.ComboBoxPersonalisado CBHora;
        private components.BotonPersonalisado BVolver;
        private components.ComboBoxPersonalisado Periodo;
        private components.BotonPersonalisado BEliminar;
        private components.BotonPersonalisado BImprimir;
    }
}
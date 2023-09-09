using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.formularios
{
    partial class EditarAula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BMaximizar = new System.Windows.Forms.PictureBox();
            this.BEsconder = new System.Windows.Forms.PictureBox();
            this.BRestaurar = new System.Windows.Forms.PictureBox();
            this.BCerrar = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BEditarAula = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBTipo = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.CBUbicacion = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.TCapacidad = new CustomControls.RJControls.RJTextBox();
            this.TNombre = new CustomControls.RJControls.RJTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEsconder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCerrar)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Editar Aula";
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
            this.BMaximizar.Image = global::ProyectoIntegradorTaller.Properties.Resources.icons8_full_screen_24__1_;
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
            this.BEsconder.Image = global::ProyectoIntegradorTaller.Properties.Resources.icons8_minus_24;
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
            this.BRestaurar.Image = global::ProyectoIntegradorTaller.Properties.Resources.icons8_bursts_24__1_;
            this.BRestaurar.Location = new System.Drawing.Point(646, 10);
            this.BRestaurar.Name = "BRestaurar";
            this.BRestaurar.Size = new System.Drawing.Size(13, 13);
            this.BRestaurar.TabIndex = 6;
            this.BRestaurar.TabStop = false;
            // 
            // BCerrar
            // 
            this.BCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BCerrar.Image = global::ProyectoIntegradorTaller.Properties.Resources.transistor_black_letter_x_1__1_;
            this.BCerrar.Location = new System.Drawing.Point(664, 10);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(13, 13);
            this.BCerrar.TabIndex = 3;
            this.BCerrar.TabStop = false;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel7.Controls.Add(this.CBTipo);
            this.panel7.Controls.Add(this.CBUbicacion);
            this.panel7.Controls.Add(this.TCapacidad);
            this.panel7.Controls.Add(this.TNombre);
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.checkBox2);
            this.panel7.Controls.Add(this.checkBox1);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Location = new System.Drawing.Point(0, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(686, 358);
            this.panel7.TabIndex = 11;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(248, 296);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Proyector";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(248, 274);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Aire Acondicionado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BEditarAula);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(503, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 358);
            this.panel2.TabIndex = 13;
            // 
            // BEditarAula
            // 
            this.BEditarAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BEditarAula.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BEditarAula.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BEditarAula.BorderRadius = 6;
            this.BEditarAula.BorderSize = 0;
            this.BEditarAula.FlatAppearance.BorderSize = 0;
            this.BEditarAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditarAula.ForeColor = System.Drawing.Color.White;
            this.BEditarAula.Location = new System.Drawing.Point(21, 306);
            this.BEditarAula.Name = "BEditarAula";
            this.BEditarAula.Size = new System.Drawing.Size(150, 40);
            this.BEditarAula.TabIndex = 5;
            this.BEditarAula.Text = "Editar Aula";
            this.BEditarAula.TextColor = System.Drawing.Color.White;
            this.BEditarAula.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 358);
            this.panel1.TabIndex = 12;
            // 
            // CBTipo
            // 
            this.CBTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBTipo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CBTipo.BorderSize = 1;
            this.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBTipo.ForeColor = System.Drawing.Color.DimGray;
            this.CBTipo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CBTipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBTipo.ListTextColor = System.Drawing.Color.DimGray;
            this.CBTipo.Location = new System.Drawing.Point(248, 233);
            this.CBTipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Padding = new System.Windows.Forms.Padding(1);
            this.CBTipo.Size = new System.Drawing.Size(200, 30);
            this.CBTipo.TabIndex = 36;
            this.CBTipo.Texts = "";
            // 
            // CBUbicacion
            // 
            this.CBUbicacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBUbicacion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CBUbicacion.BorderSize = 1;
            this.CBUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBUbicacion.ForeColor = System.Drawing.Color.DimGray;
            this.CBUbicacion.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CBUbicacion.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBUbicacion.ListTextColor = System.Drawing.Color.DimGray;
            this.CBUbicacion.Location = new System.Drawing.Point(248, 131);
            this.CBUbicacion.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBUbicacion.Name = "CBUbicacion";
            this.CBUbicacion.Padding = new System.Windows.Forms.Padding(1);
            this.CBUbicacion.Size = new System.Drawing.Size(200, 30);
            this.CBUbicacion.TabIndex = 27;
            this.CBUbicacion.Texts = "";
            // 
            // TCapacidad
            // 
            this.TCapacidad.BackColor = System.Drawing.SystemColors.Menu;
            this.TCapacidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TCapacidad.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TCapacidad.BorderRadius = 6;
            this.TCapacidad.BorderSize = 2;
            this.TCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCapacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TCapacidad.Location = new System.Drawing.Point(245, 184);
            this.TCapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.TCapacidad.Multiline = false;
            this.TCapacidad.Name = "TCapacidad";
            this.TCapacidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TCapacidad.PasswordChar = false;
            this.TCapacidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TCapacidad.PlaceholderText = "";
            this.TCapacidad.Size = new System.Drawing.Size(203, 31);
            this.TCapacidad.TabIndex = 35;
            this.TCapacidad.Texts = "";
            this.TCapacidad.UnderlinedStyle = true;
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.TNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TNombre.BorderRadius = 6;
            this.TNombre.BorderSize = 2;
            this.TNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TNombre.Location = new System.Drawing.Point(245, 76);
            this.TNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TNombre.Multiline = false;
            this.TNombre.Name = "TNombre";
            this.TNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TNombre.PasswordChar = false;
            this.TNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TNombre.PlaceholderText = "";
            this.TNombre.Size = new System.Drawing.Size(203, 31);
            this.TNombre.TabIndex = 34;
            this.TNombre.Texts = "";
            this.TNombre.UnderlinedStyle = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoIntegradorTaller.Properties.Resources.Group;
            this.pictureBox4.Location = new System.Drawing.Point(455, 184);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoIntegradorTaller.Properties.Resources.Location;
            this.pictureBox3.Location = new System.Drawing.Point(455, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(249, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(245, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Capacidad";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(245, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ubicacion";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(245, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nombre";
            // 
            // EditarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarAula";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.LoadEditarAula);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEsconder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCerrar)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private Panel panel7;
        private Label label3;
        private Label label1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private views.components.BotonPersonalisado BEditarAula;
        private views.components.ComboBoxPersonalisado CBTipo;
        private views.components.ComboBoxPersonalisado CBUbicacion;
        private CustomControls.RJControls.RJTextBox TCapacidad;
        private CustomControls.RJControls.RJTextBox TNombre;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label4;
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>


    #endregion

}
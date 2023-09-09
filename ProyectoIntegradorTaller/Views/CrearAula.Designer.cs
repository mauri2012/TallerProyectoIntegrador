using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.formularios
{
    partial class CrearAula
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BCrearAula = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            this.comboBoxPersonalisado1 = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.comboBoxPersonalisado2 = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEsconder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCerrar)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Crear Aula";
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
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel7.Controls.Add(this.comboBoxPersonalisado2);
            this.panel7.Controls.Add(this.comboBoxPersonalisado1);
            this.panel7.Controls.Add(this.rjTextBox2);
            this.panel7.Controls.Add(this.rjTextBox1);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.checkBox2);
            this.panel7.Controls.Add(this.checkBox1);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(0, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(686, 358);
            this.panel7.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoIntegradorTaller.Properties.Resources.Group;
            this.pictureBox2.Location = new System.Drawing.Point(458, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoIntegradorTaller.Properties.Resources.Location;
            this.pictureBox1.Location = new System.Drawing.Point(458, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(254, 279);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Proyector";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(254, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Aire Acondicionado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(252, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(248, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Capacidad";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BCrearAula);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(503, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 358);
            this.panel2.TabIndex = 13;
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
            this.BCrearAula.Location = new System.Drawing.Point(21, 306);
            this.BCrearAula.Name = "BCrearAula";
            this.BCrearAula.Size = new System.Drawing.Size(150, 40);
            this.BCrearAula.TabIndex = 5;
            this.BCrearAula.Text = "Crear Aula";
            this.BCrearAula.TextColor = System.Drawing.Color.White;
            this.BCrearAula.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 358);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(248, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ubicacion";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(248, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 6;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(248, 61);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(203, 31);
            this.rjTextBox1.TabIndex = 24;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = true;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.rjTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 6;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(248, 163);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(203, 31);
            this.rjTextBox2.TabIndex = 25;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = true;
            // 
            // comboBoxPersonalisado1
            // 
            this.comboBoxPersonalisado1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxPersonalisado1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxPersonalisado1.BorderSize = 1;
            this.comboBoxPersonalisado1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxPersonalisado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxPersonalisado1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxPersonalisado1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxPersonalisado1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxPersonalisado1.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxPersonalisado1.Location = new System.Drawing.Point(251, 116);
            this.comboBoxPersonalisado1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxPersonalisado1.Name = "comboBoxPersonalisado1";
            this.comboBoxPersonalisado1.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxPersonalisado1.Size = new System.Drawing.Size(200, 30);
            this.comboBoxPersonalisado1.TabIndex = 0;
            this.comboBoxPersonalisado1.Texts = "";
            // 
            // comboBoxPersonalisado2
            // 
            this.comboBoxPersonalisado2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxPersonalisado2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxPersonalisado2.BorderSize = 1;
            this.comboBoxPersonalisado2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxPersonalisado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxPersonalisado2.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxPersonalisado2.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBoxPersonalisado2.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxPersonalisado2.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxPersonalisado2.Location = new System.Drawing.Point(251, 218);
            this.comboBoxPersonalisado2.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxPersonalisado2.Name = "comboBoxPersonalisado2";
            this.comboBoxPersonalisado2.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxPersonalisado2.Size = new System.Drawing.Size(200, 30);
            this.comboBoxPersonalisado2.TabIndex = 26;
            this.comboBoxPersonalisado2.Texts = "";
            // 
            // CrearAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearAula";
            this.Text = "Menu";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEsconder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCerrar)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private views.components.BotonPersonalisado BCrearAula;
        private views.components.ComboBoxPersonalisado comboBoxPersonalisado1;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private views.components.ComboBoxPersonalisado comboBoxPersonalisado2;
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>


    #endregion

}
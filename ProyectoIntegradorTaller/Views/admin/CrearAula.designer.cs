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
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.TTipo = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.CBUbicacion = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.TCapacidad = new CustomControls.RJControls.RJTextBox();
            this.TNombre = new CustomControls.RJControls.RJTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BEditarAula = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BCrearAula = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel7.Controls.Add(this.checkBox4);
            this.panel7.Controls.Add(this.checkBox3);
            this.panel7.Controls.Add(this.TTipo);
            this.panel7.Controls.Add(this.CBUbicacion);
            this.panel7.Controls.Add(this.TCapacidad);
            this.panel7.Controls.Add(this.TNombre);
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
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(391, 279);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(48, 20);
            this.checkBox4.TabIndex = 28;
            this.checkBox4.Text = "Wifi";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(391, 253);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(75, 20);
            this.checkBox3.TabIndex = 27;
            this.checkBox3.Text = "Televisor";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // TTipo
            // 
            this.TTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TTipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TTipo.BorderSize = 2;
            this.TTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.TTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TTipo.ForeColor = System.Drawing.Color.DimGray;
            this.TTipo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TTipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.TTipo.ListTextColor = System.Drawing.Color.DimGray;
            this.TTipo.Location = new System.Drawing.Point(248, 217);
            this.TTipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.TTipo.Name = "TTipo";
            this.TTipo.Padding = new System.Windows.Forms.Padding(2);
            this.TTipo.Size = new System.Drawing.Size(203, 30);
            this.TTipo.TabIndex = 26;
            this.TTipo.Texts = "";
            // 
            // CBUbicacion
            // 
            this.CBUbicacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBUbicacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBUbicacion.BorderSize = 2;
            this.CBUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBUbicacion.ForeColor = System.Drawing.Color.DimGray;
            this.CBUbicacion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBUbicacion.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBUbicacion.ListTextColor = System.Drawing.Color.DimGray;
            this.CBUbicacion.Location = new System.Drawing.Point(248, 113);
            this.CBUbicacion.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBUbicacion.Name = "CBUbicacion";
            this.CBUbicacion.Padding = new System.Windows.Forms.Padding(2);
            this.CBUbicacion.Size = new System.Drawing.Size(203, 30);
            this.CBUbicacion.TabIndex = 0;
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
            this.TCapacidad.Location = new System.Drawing.Point(248, 163);
            this.TCapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.TCapacidad.Multiline = false;
            this.TCapacidad.Name = "TCapacidad";
            this.TCapacidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TCapacidad.PasswordChar = false;
            this.TCapacidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TCapacidad.PlaceholderText = "";
            this.TCapacidad.Size = new System.Drawing.Size(203, 31);
            this.TCapacidad.TabIndex = 25;
            this.TCapacidad.Texts = "";
            this.TCapacidad.UnderlinedStyle = true;
            this.TCapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCapacidad_KeyPress);
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
            this.TNombre.Location = new System.Drawing.Point(248, 61);
            this.TNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TNombre.Multiline = false;
            this.TNombre.Name = "TNombre";
            this.TNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TNombre.PasswordChar = false;
            this.TNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TNombre.PlaceholderText = "";
            this.TNombre.Size = new System.Drawing.Size(200, 31);
            this.TNombre.TabIndex = 24;
            this.TNombre.Texts = "";
            this.TNombre.UnderlinedStyle = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoIntegradorTaller.Properties.Resources.Group;
            this.pictureBox2.Location = new System.Drawing.Point(457, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoIntegradorTaller.Properties.Resources.Location;
            this.pictureBox1.Location = new System.Drawing.Point(457, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(248, 279);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 20);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Proyector";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(248, 253);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 20);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Aire Acondicionado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(245, 198);
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
            this.panel2.Controls.Add(this.BEditarAula);
            this.panel2.Controls.Add(this.BCrearAula);
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
            this.BEditarAula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarAula.ForeColor = System.Drawing.Color.White;
            this.BEditarAula.Image = global::ProyectoIntegradorTaller.Properties.Resources.edit;
            this.BEditarAula.Location = new System.Drawing.Point(21, 306);
            this.BEditarAula.Name = "BEditarAula";
            this.BEditarAula.Size = new System.Drawing.Size(150, 40);
            this.BEditarAula.TabIndex = 6;
            this.BEditarAula.Text = "  Editar Aula";
            this.BEditarAula.TextColor = System.Drawing.Color.White;
            this.BEditarAula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEditarAula.UseVisualStyleBackColor = false;
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
            this.BCrearAula.Image = global::ProyectoIntegradorTaller.Properties.Resources.add1;
            this.BCrearAula.Location = new System.Drawing.Point(21, 306);
            this.BCrearAula.Name = "BCrearAula";
            this.BCrearAula.Size = new System.Drawing.Size(150, 40);
            this.BCrearAula.TabIndex = 5;
            this.BCrearAula.Text = "  Crear Aula";
            this.BCrearAula.TextColor = System.Drawing.Color.White;
            this.BCrearAula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCrearAula.UseVisualStyleBackColor = false;
            this.BCrearAula.Click += new System.EventHandler(this.BCrearAula_Click);
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
            this.label2.Location = new System.Drawing.Point(245, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ubicación";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(245, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(17, 97, 238);
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(330, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Aula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CrearAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearAula";
            this.Text = "Menu";
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label LCerrar;
        private Panel panel7;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private views.components.BotonPersonalisado BCrearAula;
        private views.components.ComboBoxPersonalisado CBUbicacion;
        private CustomControls.RJControls.RJTextBox TCapacidad;
        private CustomControls.RJControls.RJTextBox TNombre;
        private views.components.ComboBoxPersonalisado TTipo;
        private views.components.BotonPersonalisado BEditarAula;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label1;
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>


    #endregion

}
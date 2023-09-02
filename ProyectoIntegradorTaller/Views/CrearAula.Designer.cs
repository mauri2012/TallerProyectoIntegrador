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
            panel3 = new Panel();
            label1 = new Label();
            label3 = new Label();
            BMaximizar = new PictureBox();
            BEsconder = new PictureBox();
            BRestaurar = new PictureBox();
            BCerrar = new PictureBox();
            panel7 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            BCapacidad = new TextBox();
            panel2 = new Panel();
            BCrearAula = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            TUsuario = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BEsconder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BCerrar).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            // SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(17, 97, 238);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(BMaximizar);
            panel3.Controls.Add(BEsconder);
            panel3.Controls.Add(BRestaurar);
            panel3.Controls.Add(BCerrar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 37);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(361, 12);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 7;
            label1.Text = "Crear Aula";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // BMaximizar
            // 
            BMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMaximizar.Image = Properties.Resources.icons8_full_screen_24__1_;
            BMaximizar.Location = new Point(754, 12);
            BMaximizar.Name = "BMaximizar";
            BMaximizar.Size = new Size(15, 15);
            BMaximizar.TabIndex = 5;
            BMaximizar.TabStop = false;
            BMaximizar.Click += BMaximizar_Click;
            // 
            // BEsconder
            // 
            BEsconder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BEsconder.Image = Properties.Resources.icons8_minus_24;
            BEsconder.Location = new Point(733, 12);
            BEsconder.Name = "BEsconder";
            BEsconder.Size = new Size(15, 15);
            BEsconder.TabIndex = 4;
            BEsconder.TabStop = false;
            BEsconder.Click += BEsconder_Click;
            // 
            // BRestaurar
            // 
            BRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BRestaurar.Image = Properties.Resources.icons8_bursts_24__1_;
            BRestaurar.Location = new Point(754, 12);
            BRestaurar.Name = "BRestaurar";
            BRestaurar.Size = new Size(15, 15);
            BRestaurar.TabIndex = 6;
            BRestaurar.TabStop = false;
            BRestaurar.Click += BRestaurar_Click;
            // 
            // BCerrar
            // 
            BCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrar.Image = Properties.Resources.transistor_black_letter_x_1__1_;
            BCerrar.Location = new Point(775, 12);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(15, 15);
            BCerrar.TabIndex = 3;
            BCerrar.TabStop = false;
            BCerrar.Click += BCerrar_Click;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(pictureBox1);
            panel7.Controls.Add(checkBox2);
            panel7.Controls.Add(checkBox1);
            panel7.Controls.Add(comboBox2);
            panel7.Controls.Add(comboBox1);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(BCapacidad);
            panel7.Controls.Add(panel2);
            panel7.Controls.Add(panel1);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(TUsuario);
            panel7.Location = new Point(0, 37);
            panel7.Name = "panel7";
            panel7.Size = new Size(800, 413);
            panel7.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Group;
            pictureBox2.Location = new Point(493, 242);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Location;
            pictureBox1.Location = new Point(493, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(289, 341);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(77, 19);
            checkBox2.TabIndex = 21;
            checkBox2.Text = "Proyector";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(289, 316);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 19);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Aire Acondicionado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(289, 287);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(198, 23);
            comboBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(289, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 23);
            comboBox1.TabIndex = 18;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(289, 269);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 17;
            label5.Text = "Tipo";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(289, 216);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 16;
            label6.Text = "Capacidad";
            // 
            // BCapacidad
            // 
            BCapacidad.Anchor = AnchorStyles.Top;
            BCapacidad.BackColor = Color.Snow;
            BCapacidad.BorderStyle = BorderStyle.FixedSingle;
            BCapacidad.Location = new Point(289, 234);
            BCapacidad.Name = "BCapacidad";
            BCapacidad.Size = new Size(198, 23);
            BCapacidad.TabIndex = 14;
            BCapacidad.KeyPress += BCapacidad_KeyPress;
            // 
            // panel2
            // 
            panel2.Controls.Add(BCrearAula);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(586, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 413);
            panel2.TabIndex = 13;
            // 
            // BCrearAula
            // 
            BCrearAula.BackColor = Color.FromArgb(17, 97, 238);
            BCrearAula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BCrearAula.ForeColor = Color.White;
            BCrearAula.Location = new Point(18, 354);
            BCrearAula.Name = "BCrearAula";
            BCrearAula.Size = new Size(184, 31);
            BCrearAula.TabIndex = 4;
            BCrearAula.Text = "Crear Aula";
            BCrearAula.UseVisualStyleBackColor = false;
            BCrearAula.Click += BCrearAula_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 413);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(289, 163);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 11;
            label2.Text = "Ubicacion";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(289, 101);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 10;
            label4.Text = "Nombre";
            // 
            // TUsuario
            // 
            TUsuario.Anchor = AnchorStyles.Top;
            TUsuario.BackColor = Color.Snow;
            TUsuario.BorderStyle = BorderStyle.FixedSingle;
            TUsuario.Location = new Point(289, 119);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(198, 23);
            TUsuario.TabIndex = 8;
            // 
            // CrearAula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(panel7);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CrearAula";
            Text = "Menu";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BEsconder).EndInit();
            ((System.ComponentModel.ISupportInitialize)BRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BCerrar).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
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
        private TextBox BCapacidad;
        private Panel panel7;
        private Label label3;
        private Label label1;
        private Button BCrearAula;
        private Label label2;
        private Label label4;
        private TextBox TUsuario;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>


    #endregion

}
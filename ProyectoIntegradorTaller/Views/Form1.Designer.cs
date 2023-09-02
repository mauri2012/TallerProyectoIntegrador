using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel3 = new Panel();
            BMaximizar = new PictureBox();
            BEsconder = new PictureBox();
            BRestaurar = new PictureBox();
            BCerrar = new PictureBox();
            LBienvenido = new Label();
            TUsuario = new TextBox();
            TContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BInicioSesion = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BEsconder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BCerrar).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(17, 97, 238);
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
            // BMaximizar
            // 
            BMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMaximizar.Image = (Image)resources.GetObject("BMaximizar.Image");
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
            BEsconder.Image = (Image)resources.GetObject("BEsconder.Image");
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
            BRestaurar.Image = (Image)resources.GetObject("BRestaurar.Image");
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
            BCerrar.Image = (Image)resources.GetObject("BCerrar.Image");
            BCerrar.Location = new Point(775, 12);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(15, 15);
            BCerrar.TabIndex = 3;
            BCerrar.TabStop = false;
            BCerrar.Click += pictureBox1_Click;
            // 
            // LBienvenido
            // 
            LBienvenido.Anchor = AnchorStyles.Top;
            LBienvenido.AutoSize = true;
            LBienvenido.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBienvenido.Location = new Point(130, 81);
            LBienvenido.Name = "LBienvenido";
            LBienvenido.Size = new Size(97, 18);
            LBienvenido.TabIndex = 3;
            LBienvenido.Text = "Bienvenido";
            // 
            // TUsuario
            // 
            TUsuario.Anchor = AnchorStyles.Top;
            TUsuario.BackColor = Color.Snow;
            TUsuario.BorderStyle = BorderStyle.FixedSingle;
            TUsuario.Location = new Point(85, 132);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(198, 23);
            TUsuario.TabIndex = 4;
            // 
            // TContraseña
            // 
            TContraseña.Anchor = AnchorStyles.Top;
            TContraseña.BackColor = Color.Snow;
            TContraseña.BorderStyle = BorderStyle.FixedSingle;
            TContraseña.Location = new Point(85, 208);
            TContraseña.Name = "TContraseña";
            TContraseña.PasswordChar = '*';
            TContraseña.Size = new Size(198, 23);
            TContraseña.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(85, 114);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(85, 190);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // BInicioSesion
            // 
            BInicioSesion.Anchor = AnchorStyles.Top;
            BInicioSesion.BackColor = Color.FromArgb(17, 97, 238);
            BInicioSesion.ForeColor = SystemColors.ButtonHighlight;
            BInicioSesion.Location = new Point(85, 252);
            BInicioSesion.Name = "BInicioSesion";
            BInicioSesion.Size = new Size(198, 38);
            BInicioSesion.TabIndex = 8;
            BInicioSesion.Text = "Log In";
            BInicioSesion.UseVisualStyleBackColor = false;
            BInicioSesion.Click += BInicioSesion_Click;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 37);
            panel5.Name = "panel5";
            panel5.Size = new Size(209, 413);
            panel5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(600, 37);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 413);
            panel6.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel7.Controls.Add(BInicioSesion);
            panel7.Controls.Add(LBienvenido);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(TContraseña);
            panel7.Controls.Add(TUsuario);
            panel7.Location = new Point(209, 37);
            panel7.Name = "panel7";
            panel7.Size = new Size(391, 413);
            panel7.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BEsconder).EndInit();
            ((System.ComponentModel.ISupportInitialize)BRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BCerrar).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private Label label1;
        private Label label2;
        private Button BInicioSesion;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private TextBox TUsuario;
        private TextBox TContraseña;
    }
}
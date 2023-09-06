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
            this.panel3 = new System.Windows.Forms.Panel();
            this.BMaximizar = new System.Windows.Forms.PictureBox();
            this.BEsconder = new System.Windows.Forms.PictureBox();
            this.BRestaurar = new System.Windows.Forms.PictureBox();
            this.BCerrar = new System.Windows.Forms.PictureBox();
            this.LBienvenido = new System.Windows.Forms.Label();
            this.TUsuario = new System.Windows.Forms.TextBox();
            this.TContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BInicioSesion = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEsconder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCerrar)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
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
            // BMaximizar
            // 
            this.BMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BMaximizar.Image")));
            this.BMaximizar.Location = new System.Drawing.Point(646, 10);
            this.BMaximizar.Name = "BMaximizar";
            this.BMaximizar.Size = new System.Drawing.Size(13, 13);
            this.BMaximizar.TabIndex = 5;
            this.BMaximizar.TabStop = false;
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
            // 
            // LBienvenido
            // 
            this.LBienvenido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBienvenido.AutoSize = true;
            this.LBienvenido.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.LBienvenido.Location = new System.Drawing.Point(111, 70);
            this.LBienvenido.Name = "LBienvenido";
            this.LBienvenido.Size = new System.Drawing.Size(97, 18);
            this.LBienvenido.TabIndex = 3;
            this.LBienvenido.Text = "Bienvenido";
            // 
            // TUsuario
            // 
            this.TUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TUsuario.BackColor = System.Drawing.Color.Snow;
            this.TUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TUsuario.Location = new System.Drawing.Point(73, 127);
            this.TUsuario.Name = "TUsuario";
            this.TUsuario.Size = new System.Drawing.Size(170, 20);
            this.TUsuario.TabIndex = 4;
            // 
            // TContraseña
            // 
            this.TContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TContraseña.BackColor = System.Drawing.Color.Snow;
            this.TContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TContraseña.Location = new System.Drawing.Point(73, 180);
            this.TContraseña.Name = "TContraseña";
            this.TContraseña.PasswordChar = '*';
            this.TContraseña.Size = new System.Drawing.Size(170, 20);
            this.TContraseña.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 358);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(515, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(171, 358);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel7.Controls.Add(this.BInicioSesion);
            this.panel7.Controls.Add(this.LBienvenido);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.TContraseña);
            this.panel7.Controls.Add(this.TUsuario);
            this.panel7.Location = new System.Drawing.Point(179, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(335, 358);
            this.panel7.TabIndex = 11;
            // 
            // BInicioSesion
            // 
            this.BInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BInicioSesion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BInicioSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BInicioSesion.BorderRadius = 6;
            this.BInicioSesion.BorderSize = 0;
            this.BInicioSesion.FlatAppearance.BorderSize = 0;
            this.BInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInicioSesion.ForeColor = System.Drawing.Color.White;
            this.BInicioSesion.Location = new System.Drawing.Point(73, 215);
            this.BInicioSesion.Name = "BInicioSesion";
            this.BInicioSesion.Size = new System.Drawing.Size(170, 40);
            this.BInicioSesion.TabIndex = 0;
            this.BInicioSesion.Text = "Log In";
            this.BInicioSesion.TextColor = System.Drawing.Color.White;
            this.BInicioSesion.UseVisualStyleBackColor = false;
            this.BInicioSesion.Click += new System.EventHandler(this.BInicioSesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEsconder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCerrar)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

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
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private TextBox TUsuario;
        private TextBox TContraseña;
        private views.components.BotonPersonalisado BInicioSesion;
    }
}
namespace ProyectoIntegradorTaller.views.admin
{
    partial class AdministracionDatabase
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BVolver = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.TBRutaExport = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BBuscarRuta = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BExportarDB = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNombreArchivo = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBMaximizar_
            // 
            this.PBMaximizar_.Location = new System.Drawing.Point(752, 11);
            // 
            // PBCerrar_
            // 
            this.PBCerrar_.Location = new System.Drawing.Point(773, 11);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Database";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BVolver);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 18;
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
            this.BVolver.Location = new System.Drawing.Point(12, 14);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(100, 40);
            this.BVolver.TabIndex = 53;
            this.BVolver.Text = "  Volver";
            this.BVolver.TextColor = System.Drawing.Color.AliceBlue;
            this.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BVolver.UseVisualStyleBackColor = false;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // TBRutaExport
            // 
            this.TBRutaExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBRutaExport.BackColor = System.Drawing.SystemColors.Menu;
            this.TBRutaExport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TBRutaExport.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBRutaExport.BorderRadius = 6;
            this.TBRutaExport.BorderSize = 2;
            this.TBRutaExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRutaExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBRutaExport.Location = new System.Drawing.Point(103, 121);
            this.TBRutaExport.Margin = new System.Windows.Forms.Padding(4);
            this.TBRutaExport.Multiline = false;
            this.TBRutaExport.Name = "TBRutaExport";
            this.TBRutaExport.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBRutaExport.PasswordChar = false;
            this.TBRutaExport.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBRutaExport.PlaceholderText = "";
            this.TBRutaExport.Size = new System.Drawing.Size(277, 31);
            this.TBRutaExport.TabIndex = 19;
            this.TBRutaExport.Texts = "";
            this.TBRutaExport.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Carpeta";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hacer un copia de seguridad:";
            // 
            // BBuscarRuta
            // 
            this.BBuscarRuta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BBuscarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BBuscarRuta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BBuscarRuta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BBuscarRuta.BorderRadius = 6;
            this.BBuscarRuta.BorderSize = 0;
            this.BBuscarRuta.FlatAppearance.BorderSize = 0;
            this.BBuscarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarRuta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarRuta.ForeColor = System.Drawing.Color.White;
            this.BBuscarRuta.Image = global::ProyectoIntegradorTaller.Properties.Resources.folder;
            this.BBuscarRuta.Location = new System.Drawing.Point(396, 121);
            this.BBuscarRuta.Name = "BBuscarRuta";
            this.BBuscarRuta.Size = new System.Drawing.Size(89, 31);
            this.BBuscarRuta.TabIndex = 53;
            this.BBuscarRuta.Text = "  Buscar";
            this.BBuscarRuta.TextColor = System.Drawing.Color.White;
            this.BBuscarRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BBuscarRuta.UseVisualStyleBackColor = false;
            this.BBuscarRuta.Click += new System.EventHandler(this.BBuscarRuta_Click);
            // 
            // BExportarDB
            // 
            this.BExportarDB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BExportarDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BExportarDB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BExportarDB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BExportarDB.BorderRadius = 6;
            this.BExportarDB.BorderSize = 0;
            this.BExportarDB.FlatAppearance.BorderSize = 0;
            this.BExportarDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BExportarDB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BExportarDB.ForeColor = System.Drawing.Color.White;
            this.BExportarDB.Image = global::ProyectoIntegradorTaller.Properties.Resources.export;
            this.BExportarDB.Location = new System.Drawing.Point(491, 121);
            this.BExportarDB.Name = "BExportarDB";
            this.BExportarDB.Size = new System.Drawing.Size(99, 31);
            this.BExportarDB.TabIndex = 54;
            this.BExportarDB.Text = "  Exportar";
            this.BExportarDB.TextColor = System.Drawing.Color.White;
            this.BExportarDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BExportarDB.UseVisualStyleBackColor = false;
            this.BExportarDB.Click += new System.EventHandler(this.BExportarDB_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Nombre";
            // 
            // TBNombreArchivo
            // 
            this.TBNombreArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBNombreArchivo.BackColor = System.Drawing.SystemColors.Menu;
            this.TBNombreArchivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TBNombreArchivo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBNombreArchivo.BorderRadius = 6;
            this.TBNombreArchivo.BorderSize = 2;
            this.TBNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreArchivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBNombreArchivo.Location = new System.Drawing.Point(103, 86);
            this.TBNombreArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.TBNombreArchivo.Multiline = false;
            this.TBNombreArchivo.Name = "TBNombreArchivo";
            this.TBNombreArchivo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBNombreArchivo.PasswordChar = false;
            this.TBNombreArchivo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBNombreArchivo.PlaceholderText = "";
            this.TBNombreArchivo.Size = new System.Drawing.Size(277, 31);
            this.TBNombreArchivo.TabIndex = 56;
            this.TBNombreArchivo.Texts = "";
            this.TBNombreArchivo.UnderlinedStyle = true;
            // 
            // AdministracionDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBNombreArchivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BExportarDB);
            this.Controls.Add(this.BBuscarRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBRutaExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministracionDatabase";
            this.Text = "AdministracionDatabase";
            this.Controls.SetChildIndex(this.PBEsconder_, 0);
            this.Controls.SetChildIndex(this.PBMinimizar_, 0);
            this.Controls.SetChildIndex(this.PBMaximizar_, 0);
            this.Controls.SetChildIndex(this.PBCerrar_, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.TBRutaExport, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.BBuscarRuta, 0);
            this.Controls.SetChildIndex(this.BExportarDB, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TBNombreArchivo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private components.BotonPersonalisado BVolver;
        private CustomControls.RJControls.RJTextBox TBRutaExport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private components.BotonPersonalisado BBuscarRuta;
        private components.BotonPersonalisado BExportarDB;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox TBNombreArchivo;
    }
}
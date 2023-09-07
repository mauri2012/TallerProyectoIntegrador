namespace ProyectoIntegradorTaller.views.admin
{
    partial class Profesores
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxPersonalisado1 = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.timePickerPersonalisado1 = new ProyectoIntegradorTaller.views.components.TimePickerPersonalisado();
            this.botonPersonalisado1 = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 213);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoIntegradorTaller.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(755, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxPersonalisado1
            // 
            this.comboBoxPersonalisado1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxPersonalisado1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.comboBoxPersonalisado1.BorderSize = 2;
            this.comboBoxPersonalisado1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxPersonalisado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxPersonalisado1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxPersonalisado1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.comboBoxPersonalisado1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBoxPersonalisado1.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBoxPersonalisado1.Location = new System.Drawing.Point(261, 379);
            this.comboBoxPersonalisado1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxPersonalisado1.Name = "comboBoxPersonalisado1";
            this.comboBoxPersonalisado1.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxPersonalisado1.Size = new System.Drawing.Size(200, 30);
            this.comboBoxPersonalisado1.TabIndex = 7;
            this.comboBoxPersonalisado1.Texts = "";
            // 
            // timePickerPersonalisado1
            // 
            this.timePickerPersonalisado1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.timePickerPersonalisado1.BorderSize = 0;
            this.timePickerPersonalisado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.timePickerPersonalisado1.Location = new System.Drawing.Point(12, 374);
            this.timePickerPersonalisado1.MinimumSize = new System.Drawing.Size(4, 35);
            this.timePickerPersonalisado1.Name = "timePickerPersonalisado1";
            this.timePickerPersonalisado1.Size = new System.Drawing.Size(243, 35);
            this.timePickerPersonalisado1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.timePickerPersonalisado1.TabIndex = 5;
            this.timePickerPersonalisado1.TextColor = System.Drawing.Color.White;
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
            this.botonPersonalisado1.Image = global::ProyectoIntegradorTaller.Properties.Resources.add_person;
            this.botonPersonalisado1.Location = new System.Drawing.Point(639, 398);
            this.botonPersonalisado1.Name = "botonPersonalisado1";
            this.botonPersonalisado1.Size = new System.Drawing.Size(149, 40);
            this.botonPersonalisado1.TabIndex = 0;
            this.botonPersonalisado1.Text = "Crear Profesor";
            this.botonPersonalisado1.TextColor = System.Drawing.Color.White;
            this.botonPersonalisado1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonPersonalisado1.UseVisualStyleBackColor = false;
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
            this.rjTextBox1.Location = new System.Drawing.Point(562, 52);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(186, 31);
            this.rjTextBox1.TabIndex = 8;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = true;
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.comboBoxPersonalisado1);
            this.Controls.Add(this.timePickerPersonalisado1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonPersonalisado1);
            this.Name = "Profesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private components.BotonPersonalisado botonPersonalisado1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        
        private components.TimePickerPersonalisado timePickerPersonalisado1;
        private components.ComboBoxPersonalisado comboBoxPersonalisado1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
    }
}
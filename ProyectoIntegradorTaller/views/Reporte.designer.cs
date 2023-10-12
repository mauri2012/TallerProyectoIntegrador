using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    partial class Reporte
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Periodo = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.fecha_desde = new ProyectoIntegradorTaller.views.components.TimePickerPersonalisado();
            this.fecha_hasta = new ProyectoIntegradorTaller.views.components.TimePickerPersonalisado();
            this.fecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BVolver = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.CBFiltro = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.label2 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BGuardar = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BReservarAula = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
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
            // PBEsconder_
            // 
            this.PBEsconder_.Location = new System.Drawing.Point(775, 12);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.BReservarAula);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 556);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Periodo);
            this.panel4.Controls.Add(this.fecha_desde);
            this.panel4.Controls.Add(this.fecha_hasta);
            this.panel4.Controls.Add(this.fecha);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.BVolver);
            this.panel4.Controls.Add(this.CBFiltro);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.chart2);
            this.panel4.Controls.Add(this.BGuardar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 556);
            this.panel4.TabIndex = 32;
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
            this.Periodo.Location = new System.Drawing.Point(37, 46);
            this.Periodo.MinimumSize = new System.Drawing.Size(200, 30);
            this.Periodo.Name = "Periodo";
            this.Periodo.Padding = new System.Windows.Forms.Padding(1);
            this.Periodo.Size = new System.Drawing.Size(244, 30);
            this.Periodo.TabIndex = 68;
            this.Periodo.Texts = "";
            this.Periodo.OnSelectedIndexChanged += new System.EventHandler(this.Periodo_OnSelectedIndexChanged);
            // 
            // fecha_desde
            // 
            this.fecha_desde.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fecha_desde.BorderSize = 0;
            this.fecha_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_desde.Location = new System.Drawing.Point(331, 46);
            this.fecha_desde.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.fecha_desde.MinDate = new System.DateTime(2023, 1, 18, 0, 0, 0, 0);
            this.fecha_desde.MinimumSize = new System.Drawing.Size(4, 35);
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.Size = new System.Drawing.Size(202, 35);
            this.fecha_desde.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.fecha_desde.TabIndex = 67;
            this.fecha_desde.TextColor = System.Drawing.Color.White;
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fecha_hasta.BorderSize = 0;
            this.fecha_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_hasta.Location = new System.Drawing.Point(544, 46);
            this.fecha_hasta.MinimumSize = new System.Drawing.Size(4, 35);
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.Size = new System.Drawing.Size(202, 35);
            this.fecha_hasta.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.fecha_hasta.TabIndex = 66;
            this.fecha_hasta.TextColor = System.Drawing.Color.White;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(328, 20);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(51, 18);
            this.fecha.TabIndex = 65;
            this.fecha.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "Periodo";
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
            this.BVolver.ForeColor = System.Drawing.Color.White;
            this.BVolver.Image = global::ProyectoIntegradorTaller.Properties.Resources.path30;
            this.BVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BVolver.Location = new System.Drawing.Point(22, 486);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(100, 40);
            this.BVolver.TabIndex = 49;
            this.BVolver.Text = "  Volver";
            this.BVolver.TextColor = System.Drawing.Color.White;
            this.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BVolver.UseVisualStyleBackColor = false;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // CBFiltro
            // 
            this.CBFiltro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBFiltro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CBFiltro.BorderSize = 1;
            this.CBFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBFiltro.ForeColor = System.Drawing.Color.DimGray;
            this.CBFiltro.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CBFiltro.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBFiltro.ListTextColor = System.Drawing.Color.DimGray;
            this.CBFiltro.Location = new System.Drawing.Point(546, 108);
            this.CBFiltro.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBFiltro.Name = "CBFiltro";
            this.CBFiltro.Padding = new System.Windows.Forms.Padding(1);
            this.CBFiltro.Size = new System.Drawing.Size(200, 30);
            this.CBFiltro.TabIndex = 63;
            this.CBFiltro.Texts = "";
            this.CBFiltro.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxPersonalisado1_OnSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Uso por materia";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(22, 160);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(724, 279);
            this.chart2.TabIndex = 46;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BGuardar.BorderRadius = 6;
            this.BGuardar.BorderSize = 0;
            this.BGuardar.FlatAppearance.BorderSize = 0;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.White;
            this.BGuardar.Image = global::ProyectoIntegradorTaller.Properties.Resources.save;
            this.BGuardar.Location = new System.Drawing.Point(617, 486);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(150, 40);
            this.BGuardar.TabIndex = 38;
            this.BGuardar.Text = "  Exportar";
            this.BGuardar.TextColor = System.Drawing.Color.White;
            this.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BReservarAula
            // 
            this.BReservarAula.Location = new System.Drawing.Point(0, 0);
            this.BReservarAula.Name = "BReservarAula";
            this.BReservarAula.Size = new System.Drawing.Size(64, 20);
            this.BReservarAula.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(370, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Reporte";
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservarAula";
            this.Load += new System.EventHandler(this.Reporte_Load);
            this.Controls.SetChildIndex(this.PBEsconder_, 0);
            this.Controls.SetChildIndex(this.PBMinimizar_, 0);
            this.Controls.SetChildIndex(this.PBMaximizar_, 0);
            this.Controls.SetChildIndex(this.PBCerrar_, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private Button BReservarAula;
        private Panel panel4;
        private views.components.BotonPersonalisado BGuardar;
        private Label label6;
        private components.BotonPersonalisado BVolver;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label label2;
        private components.ComboBoxPersonalisado CBFiltro;
        private components.ComboBoxPersonalisado Periodo;
        private components.TimePickerPersonalisado fecha_desde;
        private components.TimePickerPersonalisado fecha_hasta;
        private Label fecha;
        private Label label3;
    }
}
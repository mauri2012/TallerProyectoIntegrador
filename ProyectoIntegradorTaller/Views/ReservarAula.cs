﻿using DraggingControl;
using ProyectoIntegradorTaller.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class ReservarAula : DraggablePanelUserControl
    {
        
       
        public ReservarAula(string hora, string dia)
        {
            InitializeComponent();
            CBHora.Texts = hora;
            CBDia.Texts = dia;

        }

        public ReservarAula()
        {
            InitializeComponent();
        }



        private void BCrearAula_Click(object sender, EventArgs e)
        {

        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadReservarAula1(object sender,EventArgs e)
        {
            dias_semana dias = new dias_semana();
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                CBDia.DataSource = db.tipoUsuario.ToList();
                CBDia.DisplayMember = "dias"; // Specify the property to display in the ComboBox
                CBDia.ValueMember = "id_dias";
            }
 
        }

       

        private void BVolver_Click_1(object sender, EventArgs e)
        {
            //discriminar a usuarios con if cuando se pueda
            this.Hide();
             VerReservas reservas = new VerReservas();
            reservas.Show();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonPersonalisado1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.CBHora.Texts) || string.IsNullOrEmpty(this.CBMateria.Texts) ||       string.IsNullOrEmpty(CBPRofesor.Texts) || string.IsNullOrEmpty(this.CBDia.Texts))
            {
                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }


}

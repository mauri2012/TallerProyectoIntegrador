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
using ProyectoIntegradorTaller.logica;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class editarPeriodo : DraggablePanelUserControl
    {

        private int id_periodo;
        
        

        public editarPeriodo(int idPeriodo,DateTime desde,DateTime hasta)
        {
            InitializeComponent();
        
            id_periodo = idPeriodo;
            fecha_desde.Value = desde;
            fecha_hasta.Value = hasta;
       
        }

        private void BVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Periodos unPeriodo = new Periodos();
            unPeriodo.Show();
           
        }

        

        private void botonPersonalisado1_Click(object sender, EventArgs e)
        {            
            LogicaPeriodo.InsertarPeriodo(id_periodo,this.fecha_desde.Value,this.fecha_hasta.Value);
         
            MessageBox.Show("Insercion echa exitosamente!", "insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Periodo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
    
        }

        
        // Editar Aula
        private void editar_Click(object sender, EventArgs e)
        {
          

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fecha_Click(object sender, EventArgs e)
        {

        }

        private void fecha_desde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fecha_hasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BImprimir_Click(object sender, EventArgs e)
        {
    //        LogicaReserva.ImprimirComprobante(res.id_reserva);
        }
    }


}

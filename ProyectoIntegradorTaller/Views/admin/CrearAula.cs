using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ProyectoIntegradorTaller.views.admin
{
    public partial class CrearAula : DraggablePanelUserControl 
    {
        private int id_;
        public CrearAula(int Id, string Name, String Lugar ,int CapacidadMax, String Tipo)
        {
            InitializeComponent();
            id_ = Id;
            TNombre.Texts = Name;
            CBUbicacion.Texts = Lugar;
            TCapacidad.Texts = CapacidadMax.ToString();
            TTipo.Texts = Tipo;
            BEditarAula.Visible = true;
            BCrearAula.Visible = false;
        }
        public CrearAula()
        {
            InitializeComponent();
            BEditarAula.Visible = false;
            BCrearAula.Visible = true;
            
        }
  




        private void BCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número (0-9), retroceso o una tecla de control.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprime la pulsación de tecla.
                e.Handled = true;
            }
        }

        private void BCrearAula_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.TNombre.Texts) || string.IsNullOrEmpty(CBUbicacion.Texts) || string.IsNullOrEmpty(TTipo.Texts) || string.IsNullOrEmpty(TCapacidad.Texts))
            {
                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (LogicaClase.valNomAula(TNombre.Texts))
                {
                    LogicaClase.addClassroom(this.TTipo.Texts, this.CBUbicacion.Texts, this.TNombre.Texts, this.TCapacidad.Texts, this.CAireAcondicionado.Checked, this.CWifi.Checked, this.CProyector.Checked, this.CTelevisor.Checked);
                    this.TCapacidad.Texts = this.TNombre.Texts = " ";
                    MessageBox.Show("se inserto el aula correctamente!", "Insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("el" + this.TNombre.Texts + "ya existe", "Insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void TCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El campo Capacidad solo acepta valores numericos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void BVolver_Click(object sender, EventArgs e)
        {

            AdminMenu admin = new AdminMenu();
            admin.Show();
            this.Hide();
        }

        private void CBUbicacion_Load(object sender, EventArgs e)
        {
            ubicacion tuser = new ubicacion();
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                CBUbicacion.DataSource = db.ubicacion.ToList();
                CBUbicacion.DisplayMember = "lugar"; // Specify the property to display in the ComboBox
                CBUbicacion.ValueMember = "id_ubicacion";
            }
        }

        private void TTipo_Load(object sender, EventArgs e)
        {
           
            using (classroom_managerEntities db = new classroom_managerEntities())
            {
                TTipo.DataSource = db.tipoSala.ToList();
                TTipo.DisplayMember = "tipo"; // Specify the property to display in the ComboBox
                TTipo.ValueMember = "id_sala";
            }
        }

        private void BEditarAula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TNombre.Texts) || string.IsNullOrEmpty(CBUbicacion.Texts) || string.IsNullOrEmpty(TTipo.Texts) || string.IsNullOrEmpty(TCapacidad.Texts))
            {
                MessageBox.Show("Existen campos incompletos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (LogicaClase.valNomAula(TNombre.Texts))
                {
                    LogicaClase.updateClassroom(id_, this.TTipo.Texts, this.CBUbicacion.Texts, this.TNombre.Texts, this.TCapacidad.Texts, this.CAireAcondicionado, this.CWifi, this.CProyector, this.CTelevisor);
                    this.TCapacidad.Texts = this.TNombre.Texts = " ";
                    MessageBox.Show("se edito la clase correctamente correctamente!", "editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("el" + this.TNombre.Texts + "ya existe", "editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
using DraggingControl;
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
        public CrearAula(int Id, string Name, String Lugar, int CapacidadMax, String Tipo)
        {
            InitializeComponent();
           // id.Text = Id;
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
                //try
                //{
                int tipo = 1;
                if (this.TTipo.Texts == "laboratorio")
                {
                    tipo = 2;
                }
                int tipoU = 1;
                if (this.CBUbicacion.Texts == "segundo piso")
                {
                    tipoU = 2;
                }else if (this.CBUbicacion.Texts == "tercer piso")
                {
                    tipoU = 3;
                }
                aula aula1 = new aula()
                    {
                        nombre = this.TNombre.Texts,
                        capacidad = int.Parse(this.TCapacidad.Texts),
                        id_ubicacion = tipoU,
                        id_tipo = tipo,
                    };



                    string disponibleCA = CAireAcondicionado.Checked ? "SI" : "NO";
                    string disponibleWIFI = CWifi.Checked ? "SI" : "NO";
                    string disponibleProyector = CProyector.Checked ? "SI" : "NO";
                    string disponibleTelevisor = CTelevisor.Checked ? "SI" : "NO";

                    aula_equipamiento relacion1 = new aula_equipamiento()
                    {
                        id_aula = aula1.id_aula,
                        id_equipamiento = 1,
                        disponible = disponibleTelevisor,
                    };
                    aula_equipamiento relacion2 = new aula_equipamiento()
                    {
                        id_aula = aula1.id_aula,
                        id_equipamiento = 2,
                        disponible = disponibleCA,
                     };

                    aula_equipamiento relacion3 = new aula_equipamiento()
                    {
                        id_aula = aula1.id_aula,
                        id_equipamiento = 3,
                        disponible = disponibleProyector,
                    };
                    aula_equipamiento relacion4 = new aula_equipamiento()
                    {
                        id_aula = aula1.id_aula,
                        id_equipamiento = 4,
                        disponible = disponibleWIFI,
                    };
                    using (classroom_managerEntities db = new classroom_managerEntities())
                    {
                    db.aula.Add(aula1);
                    db.aula_equipamiento.Add(relacion1);
                        db.aula_equipamiento.Add(relacion2);
                        db.aula_equipamiento.Add(relacion3);
                        db.aula_equipamiento.Add(relacion4);
                       
                        db.SaveChanges();
                        MessageBox.Show("se inserto el aula correctamente!", "Insersion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          this.TCapacidad.Texts = this.TNombre.Texts = " ";

                    }
                //}
                /*catch (DataException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/
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
            // cuando podamos discriminar usuarios aca va un if
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
    }
}
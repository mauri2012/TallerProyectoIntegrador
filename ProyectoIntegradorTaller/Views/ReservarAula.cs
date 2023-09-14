using DraggingControl;
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

namespace ProyectoIntegradorTaller.formularios
{
    public partial class ReservarAula : DraggablePanelUserControl
    {
        
        public ReservarAula(string HDesde,string Hhasta,string Materia,string profesor)
        {
            InitializeComponent();
            CBDesde.Texts=HDesde;
            CBHasta.Texts = Hhasta;
            CBMateria.Texts = Materia;
            CBPRofesor.Texts= profesor;

          
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
        private void LoadReservarAula(object sender,EventArgs e)
        {
            List<diasSemana> items = new List<diasSemana>();
            items.Add(new diasSemana() { value = "lunes", text = "Lunes" });
            items.Add(new diasSemana() { value = "martes", text = "Martes" });
            items.Add(new diasSemana() { value = "miercoles", text = "Miercoles" });
            items.Add(new diasSemana() { value = "jueves", text = "Jueves" });
            items.Add(new diasSemana() { value = "viernes", text = "Viernes" });
            items.Add(new diasSemana() { value = "sabado", text = "Sabado" });
            items.Add(new diasSemana() { value = "domingo", text = "Domingo" });
            CBDias.DataSource = items;
            CBDias.DisplayMember = "text";
            CBDias.ValueMember = "value";
        }
    }

    class diasSemana
        {
            public diasSemana() { }
            public string value { set; get; }
            public string text { set; get; }

        }
    
}

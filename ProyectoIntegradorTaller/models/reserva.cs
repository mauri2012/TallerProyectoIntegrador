//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoIntegradorTaller.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class reserva
    {
        public int id_reserva { get; set; }
        public int id_hora { get; set; }
        public int id_usuario { get; set; }
        public int id_aula { get; set; }
        public int id_dia { get; set; }
        public Nullable<int> id_materia { get; set; }
    
        public virtual aula aula { get; set; }
        public virtual horas horas { get; set; }
        public virtual usuario usuario { get; set; }
        public virtual dias_semana dias_semana { get; set; }
        public virtual materias materias { get; set; }
    }
}

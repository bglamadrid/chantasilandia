//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Juegos.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class JuegosCasuales
    {
        public int juegoID { get; set; }
        public bool juegoCasualPoseeCinturon { get; set; }
        public bool juegoCasualReqSupervision { get; set; }
    
        public virtual Juegos Juegos { get; set; }
    }
}

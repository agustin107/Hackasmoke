//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EscuelasWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Establecimientos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Establecimientos()
        {
            this.Puntajes = new HashSet<Puntajes>();
        }
    
        public string CueAnexo { get; set; }
        public string Nombre { get; set; }
        public string Regimen { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Localidad { get; set; }
        public string Departamento { get; set; }
        public string Jurisdiccion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Puntajes> Puntajes { get; set; }
    }
}

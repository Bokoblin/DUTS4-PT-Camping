//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PT_Camping.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facture()
        {
            this.Reservation1 = new HashSet<Reservation>();
        }
    
        public int Code_Facture { get; set; }
        public double Montant { get; set; }
        public Nullable<System.DateTime> Date_Emission { get; set; }
        public int Code_Reservation { get; set; }
    
        public virtual Reservation Reservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservation1 { get; set; }
    }
}

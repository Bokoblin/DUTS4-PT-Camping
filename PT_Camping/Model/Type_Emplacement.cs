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
    
    public partial class Type_Emplacement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Type_Emplacement()
        {
            this.Emplacement = new HashSet<Emplacement>();
        }
    
        public int Code_Type { get; set; }
        public string Libelle_Type { get; set; }
        public Nullable<int> Couleur { get; set; }
        public byte[] Icone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emplacement> Emplacement { get; set; }
    }
}

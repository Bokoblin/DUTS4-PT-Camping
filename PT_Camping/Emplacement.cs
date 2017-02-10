//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PT_Camping
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emplacement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Emplacement()
        {
            this.Incident = new HashSet<Incident>();
            this.Loge = new HashSet<Loge>();
            this.Caracteristique_Emplacement = new HashSet<Caracteristique_Emplacement>();
        }
    
        public int Code_Emplacement { get; set; }
        public double Cordonnee_X { get; set; }
        public double Coordonnee_Y { get; set; }
        public string Nom_Emplacement { get; set; }
        public double Rotation { get; set; }
        public double Taille_X { get; set; }
        public double Taille_Y { get; set; }
        public int Code_Type { get; set; }
    
        public virtual Type_Emplacement Type_Emplacement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incident> Incident { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loge> Loge { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caracteristique_Emplacement> Caracteristique_Emplacement { get; set; }
    }
}

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
    
    public partial class A_vendu
    {
        public System.DateTime Date_Vente { get; set; }
        public int Code_Personne { get; set; }
        public int Code_Produit { get; set; }
    
        public virtual Personne Personne { get; set; }
        public virtual Produit Produit { get; set; }
    }
}

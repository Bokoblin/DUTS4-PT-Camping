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
    
    public partial class Client
    {
        public System.DateTime Date_Inscription { get; set; }
        public int Code_Personne { get; set; }
    
        public virtual Personne Personne { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Midias.BTSCs.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicule()
        {
            this.Livraison = new HashSet<Livraison>();
        }
        public Vehicule(int id, string cartegris, string immatr, string mod, string marq)
        {
            Id = id;
            CarteGrise = cartegris;
            Immatriculation = immatr;
            Modele = mod;
            Marque = marq;
            this.Livraison = new HashSet<Livraison>();
        }

        public int Id { get; set; }
        public string CarteGrise { get; set; }
        public string Immatriculation { get; set; }
        public string Modele { get; set; }
        public string Marque { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livraison> Livraison { get; set; }
    }
}

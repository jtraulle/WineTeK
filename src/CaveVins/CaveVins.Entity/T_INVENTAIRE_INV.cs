//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaveVins.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_INVENTAIRE_INV
    {
        public long BTL_I_ID { get; set; }
        public int INV_I_NB { get; set; }
    
        public virtual T_BOUTEILLE_BTL T_BOUTEILLE_BTL { get; set; }
    }
}

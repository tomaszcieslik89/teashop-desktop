//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Firma.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SklepElementKoszyka
    {
        public int IdElementuKoszyka { get; set; }
        public string IdSesjiKoszyka { get; set; }
        public int IdTowaru { get; set; }
        public int SklepTowarIdTowaru { get; set; }
        public int Ilosc { get; set; }
        public System.DateTime DataUtworzenia { get; set; }
    
        public virtual SklepTowar SklepTowar { get; set; }
    }
}

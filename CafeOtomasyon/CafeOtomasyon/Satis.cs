//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CafeOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Satis
    {
        public int satisID { get; set; }
        public Nullable<int> urunID { get; set; }
        public Nullable<decimal> ciro { get; set; }
        public Nullable<System.DateTime> gunluk { get; set; }
    
        public virtual Urunler Urunler { get; set; }
    }
}

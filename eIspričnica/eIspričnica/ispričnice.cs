//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eIspričnica
{
    using System;
    using System.Collections.Generic;
    
    public partial class ispričnice
    {
        public System.Guid idIspričnica { get; set; }
        public Nullable<System.DateTime> Datum_odobrenja { get; set; }
        public long Zahtjevi_idZahtjevi { get; set; }
    
        public virtual zahtjevi zahtjevi { get; set; }
    }
}

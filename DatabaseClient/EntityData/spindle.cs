//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseClient.EntityData
{
    using System;
    using System.Collections.Generic;
    
    public partial class spindle
    {
        public spindle()
        {
            this.document_spindle = new HashSet<document_spindle>();
        }
    
        public int id { get; set; }
        public string model { get; set; }
        public string serial_number { get; set; }
        public Nullable<System.DateTime> scrapping_date { get; set; }
    
        public virtual ICollection<document_spindle> document_spindle { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhotoExtraProperty : BaseEntity
    {
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
    
        public virtual Photo Photo { get; set; }
    }
}

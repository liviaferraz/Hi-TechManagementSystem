//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderLineSoftware
    {
        public int OlSoftwareId { get; set; }
        public int OrderId { get; set; }
        public int SoftwareId { get; set; }
        public int OlQuantity { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Software Software { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FPSD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonAssignment
    {
        public int PersonID { get; set; }
        public int AssignmentID { get; set; }
        public Nullable<int> Grade { get; set; }
    
        public virtual Assignment Assignment { get; set; }
        public virtual Person Person { get; set; }
    }
}

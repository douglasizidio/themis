//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sisjuri.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class foto
    {
        public int id_foto { get; set; }
        public string path { get; set; }
        public int fk_id_juri { get; set; }
    
        public virtual juri juri { get; set; }
    }
}
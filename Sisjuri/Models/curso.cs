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
    
    public partial class curso
    {
        public curso()
        {
            this.usuario = new HashSet<usuario>();
        }
    
        public int id_curso { get; set; }
        public string nome_curso { get; set; }
        public string descricao_curso { get; set; }
        public int fk_id_faculdade { get; set; }
    
        public virtual faculdade faculdade { get; set; }
        public virtual ICollection<usuario> usuario { get; set; }
    }
}

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
    
    public partial class funcao
    {
        public funcao()
        {
            this.inscricao = new HashSet<inscricao>();
        }
    
        public int id_funcao { get; set; }
        public string nome_funcao { get; set; }
        public string descricao_funcao { get; set; }
    
        public virtual ICollection<inscricao> inscricao { get; set; }
    }
}

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
    
    public partial class inscricao
    {
        public inscricao()
        {
            this.presenca = new HashSet<presenca>();
        }
    
        public int id_inscricao { get; set; }
        public int pfk_id_usuario { get; set; }
        public string status_inscricao { get; set; }
        public bool inscricao_sorteada { get; set; }
        public int fk_id_funcao { get; set; }
        public int fk_id_juri { get; set; }
    
        public virtual funcao funcao { get; set; }
        public virtual juri juri { get; set; }
        public virtual usuario usuario { get; set; }
        public virtual ICollection<presenca> presenca { get; set; }
    }
}

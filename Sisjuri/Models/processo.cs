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
    
    public partial class processo
    {
        public processo()
        {
            this.ques_absolvicao = new HashSet<ques_absolvicao>();
            this.ques_agravante = new HashSet<ques_agravante>();
            this.ques_atenuante = new HashSet<ques_atenuante>();
            this.ques_autoria = new HashSet<ques_autoria>();
            this.ques_materialidade = new HashSet<ques_materialidade>();
            this.ques_tentativa = new HashSet<ques_tentativa>();
            this.reu = new HashSet<reu>();
            this.sentenca = new HashSet<sentenca>();
            this.vitima = new HashSet<vitima>();
        }
    
        public int id_processo { get; set; }
        public string num_processo { get; set; }
        public string descricao_processo { get; set; }
        public int fk_id_juri { get; set; }
    
        public virtual juri juri { get; set; }
        public virtual ICollection<ques_absolvicao> ques_absolvicao { get; set; }
        public virtual ICollection<ques_agravante> ques_agravante { get; set; }
        public virtual ICollection<ques_atenuante> ques_atenuante { get; set; }
        public virtual ICollection<ques_autoria> ques_autoria { get; set; }
        public virtual ICollection<ques_materialidade> ques_materialidade { get; set; }
        public virtual ICollection<ques_tentativa> ques_tentativa { get; set; }
        public virtual ICollection<reu> reu { get; set; }
        public virtual ICollection<sentenca> sentenca { get; set; }
        public virtual ICollection<vitima> vitima { get; set; }
    }
}
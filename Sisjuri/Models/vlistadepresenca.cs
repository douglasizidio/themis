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
    
    public partial class vlistadepresenca
    {
        public int id_juri { get; set; }
        public string nome_juri { get; set; }
        public string nome_aluno { get; set; }
        public string nome_curso { get; set; }
        public Nullable<int> periodo_aluno { get; set; }
        public string nome_funcao { get; set; }
        public bool conselho_sentenca { get; set; }
        public bool pres_entrada { get; set; }
        public bool pres_saida_total { get; set; }
        public bool pres_saida_parcial { get; set; }
        public Nullable<System.TimeSpan> hora_saida_parcial { get; set; }
    }
}

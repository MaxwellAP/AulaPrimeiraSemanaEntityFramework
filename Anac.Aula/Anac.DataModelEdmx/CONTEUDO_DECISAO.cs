//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Anac.DataModelEdmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTEUDO_DECISAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTEUDO_DECISAO()
        {
            this.DECISAO_JUDICIAL = new HashSet<DECISAO_JUDICIAL>();
            this.JULGAMENTOes = new HashSet<JULGAMENTO>();
            this.RELATORIO_FINAL = new HashSet<RELATORIO_FINAL>();
        }
    
        public int ID_CONTEUDO_DECISAO { get; set; }
        public int ID_TIPO_CONTEUDO_DECISAO { get; set; }
        public string DS_CONTEUDO_DECISAO { get; set; }
    
        public virtual TIPO_CONTEUDO_DECISAO TIPO_CONTEUDO_DECISAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DECISAO_JUDICIAL> DECISAO_JUDICIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JULGAMENTO> JULGAMENTOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RELATORIO_FINAL> RELATORIO_FINAL { get; set; }
    }
}

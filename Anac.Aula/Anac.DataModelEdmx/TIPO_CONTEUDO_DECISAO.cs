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
    
    public partial class TIPO_CONTEUDO_DECISAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_CONTEUDO_DECISAO()
        {
            this.CONTEUDO_DECISAO = new HashSet<CONTEUDO_DECISAO>();
        }
    
        public int ID_TIPO_CONTEUDO_DECISAO { get; set; }
        public string DS_TIPO_CONTEUDO_DECISAO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTEUDO_DECISAO> CONTEUDO_DECISAO { get; set; }
    }
}

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
    
    public partial class FASE_ATO_PROCESSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FASE_ATO_PROCESSO()
        {
            this.ANDAMENTO_PROCESSO = new HashSet<ANDAMENTO_PROCESSO>();
        }
    
        public int ID_FASE_ATO_PROCESSO { get; set; }
        public int ID_FASE_PROCESSO { get; set; }
        public Nullable<int> ID_ATO_PROCESSO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANDAMENTO_PROCESSO> ANDAMENTO_PROCESSO { get; set; }
        public virtual ATO_PROCESSO ATO_PROCESSO { get; set; }
        public virtual FASE_PROCESSO FASE_PROCESSO { get; set; }
    }
}

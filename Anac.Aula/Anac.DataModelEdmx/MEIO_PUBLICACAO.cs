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
    
    public partial class MEIO_PUBLICACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEIO_PUBLICACAO()
        {
            this.JULGAMENTOes = new HashSet<JULGAMENTO>();
        }
    
        public int ID_MEIO_PUBLICACAO { get; set; }
        public string DS_MEIO_PUBLICACAO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JULGAMENTO> JULGAMENTOes { get; set; }
    }
}
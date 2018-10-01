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
    
    public partial class JULGAMENTO
    {
        public int ID_JULGAMENTO { get; set; }
        public int ID_PROCESSO { get; set; }
        public int ID_TIPO_JULGAMENTO { get; set; }
        public Nullable<int> ID_AUTORIDADE { get; set; }
        public int ID_MEIO_PUBLICACAO { get; set; }
        public int ID_CONTEUDO_DECISAO { get; set; }
        public Nullable<int> NR_SECAO { get; set; }
        public Nullable<int> NR_PAGINA { get; set; }
        public Nullable<int> NR_VOLUME { get; set; }
        public Nullable<int> NR_NUMERO { get; set; }
        public string DS_DETALHAMENTO { get; set; }
        public System.DateTime DT_PUBLICACAO { get; set; }
        public Nullable<int> ID_USUARIO_EXCLUSAO { get; set; }
        public Nullable<System.DateTime> DT_EXCLUSAO_REGISTRO { get; set; }
    
        public virtual AUTORIDADE AUTORIDADE { get; set; }
        public virtual CONTEUDO_DECISAO CONTEUDO_DECISAO { get; set; }
        public virtual MEIO_PUBLICACAO MEIO_PUBLICACAO { get; set; }
        public virtual PROCESSO PROCESSO { get; set; }
        public virtual TIPO_JULGAMENTO TIPO_JULGAMENTO { get; set; }
    }
}

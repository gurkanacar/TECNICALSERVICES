//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TECNICALSERVICES
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_PERSON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_PERSON()
        {
            this.TBL_BILLINFORMATION = new HashSet<TBL_BILLINFORMATION>();
            this.TBL_PRODUCTACCEPTENCE = new HashSet<TBL_PRODUCTACCEPTENCE>();
            this.TBL_PRODUCTMOVEMENT = new HashSet<TBL_PRODUCTMOVEMENT>();
        }
    
        public short ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public Nullable<byte> DEPARTMENT { get; set; }
        public string PHOTO { get; set; }
        public string MAIL { get; set; }
        public string PHONE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_BILLINFORMATION> TBL_BILLINFORMATION { get; set; }
        public virtual TBL_DEPARTMAN TBL_DEPARTMAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_PRODUCTACCEPTENCE> TBL_PRODUCTACCEPTENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_PRODUCTMOVEMENT> TBL_PRODUCTMOVEMENT { get; set; }
    }
}

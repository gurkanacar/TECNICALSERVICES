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
    
    public partial class TBL_BILLDETAIL
    {
        public int BILLDETAILID { get; set; }
        public string PRODUCT { get; set; }
        public Nullable<short> NUMBER { get; set; }
        public Nullable<decimal> PRICE { get; set; }
        public Nullable<decimal> TOTALPRICE { get; set; }
        public Nullable<int> BILLID { get; set; }
    
        public virtual TBL_BILLINFORMATION TBL_BILLINFORMATION { get; set; }
    }
}
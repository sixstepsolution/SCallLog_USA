//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCallLog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SCL_CompanyRegistration
    {
        public int CID { get; set; }
        public string company_name { get; set; }
        public string company_uniqueID { get; set; }
        public string company_email { get; set; }
        public string company_password { get; set; }
        public string company_mobile { get; set; }
        public string company_address { get; set; }
        public string company_status { get; set; }
        public System.DateTime cdate { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public Nullable<System.DateTime> SubscriptionEndDate { get; set; }
        public string Flag { get; set; }
        public string ProfilePicture { get; set; }
    }
}

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
    
    public partial class SCL_Mobile_Complaints_Audit
    {
        public int ID { get; set; }
        public string Complaint_ReferenceNo { get; set; }
        public Nullable<int> Complaint_ID { get; set; }
        public string Complaint_Date { get; set; }
        public string Category_Id { get; set; }
        public string Category_Desc { get; set; }
        public string SubCategory_Id { get; set; }
        public string SubCategory_Desc { get; set; }
        public string Dept_Id { get; set; }
        public string Dept_Desc { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ComplaintStatus { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }
        public string img_data { get; set; }
        public string automatic_complaint { get; set; }
        public Nullable<int> userID { get; set; }
        public string Comments { get; set; }
    }
}

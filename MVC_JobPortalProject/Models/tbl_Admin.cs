//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_JobPortalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Admin
    {
        public int AdminID { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Nullable<long> MobileNo { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string VeriicationCode { get; set; }
    }
}

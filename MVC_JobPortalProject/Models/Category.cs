using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_JobPortalProject.Models
{
    public class Category
    {
        public int CID { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }



        public bool Save()
        {

            return true;
        }

    }



  
}
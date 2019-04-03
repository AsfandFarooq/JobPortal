using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_JobPortalProject.Models
{
    public class NewsPaper
    {
        public int NewspaperID { get; set; }
        [Required(ErrorMessage = "Enter Name of Newspaper")]
        public string NewsPaperName { get; set; }
        public Boolean IsActive { get; set; }

    }
}
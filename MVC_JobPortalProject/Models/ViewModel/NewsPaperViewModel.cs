using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_JobPortalProject.Models.ViewModel
{
    public class NewsPaperViewModel
    {
        public List<tbl_NewsPaper> ListofNewsPapers{ get; set; }
        public NewsPaper newspaper { get; set; }
    }
}
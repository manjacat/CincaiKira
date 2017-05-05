using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVC2.DataContext
{
    public class YugimotoDataContext : SQLHelper
    {
        public YugimotoDataContext()
        {
            HttpContext currentContext = HttpContext.Current;
            string basePath = currentContext.Server.MapPath("~");
            string dbLocation = "\\App_Data\\Yugimoto.mdf";
            Connectionstring = string.Format("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={0}{1};Integrated Security=True", basePath,dbLocation);
        }
    }
}
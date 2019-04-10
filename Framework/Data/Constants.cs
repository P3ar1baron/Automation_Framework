using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Data
{
    public class Constants
    {
        public string Path => ConfigurationManager.AppSettings["PathToScreenshotFolder"];
    }
}

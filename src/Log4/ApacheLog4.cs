using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log4
{
    public class ApacheLog4 : Log4.Ilog4
    {
        private log4net.ILog _log = log4net.LogManager.GetLogger("PassWordBooks");
        public ApacheLog4()
        {
        }
    }
}

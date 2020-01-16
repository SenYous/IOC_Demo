using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class NLoger
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public static void Info(string msgs)
        {
            logger.Info("#" + msgs);
        }

        public static void Debug(string msgs)
        {
            logger.Debug("#" + msgs);
        }

        public static void Error(string msgs)
        {
            logger.Error("#" + msgs);
        }
    }
}

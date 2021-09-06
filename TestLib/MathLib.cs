using System;
using Serilog;

namespace TestLib
{
    public class MathLib
    {
        private static ILogger log = Log.ForContext(typeof(MathLib));

        public int Add(int a, int b)
        {
            log.Debug("Adding Number :" + a + ", " + b);
            return a + b + 10;
        }
    }
}

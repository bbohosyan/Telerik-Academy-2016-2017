using Dealership.Engine;
using System.Globalization;
using System.Threading;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            DealershipEngine.Instance.Start();
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Threading;

namespace Math.Tests
{
    [TestClass]
    public class AssemblyInit
    {
        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
        }
    }
}

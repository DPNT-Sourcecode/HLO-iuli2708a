using BeFaster.App.Solutions.HLO;
using BeFaster.App.Solutions.SUM;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class HelloSolutionTest
    {
        [TestCase("x", ExpectedResult = "Hello, World!")]
        public string ComputeHello(string x)
        {
            return HelloSolution.Hello(x);
        }
    }
}

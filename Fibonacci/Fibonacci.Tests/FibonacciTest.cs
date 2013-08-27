using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fibonacci.Tests
{
    [TestFixture]
    public class FibonacciTest
    {
        [Test]
        public void CreateTheFibonacciNumbers()
        {
            Assert.That(Fib.CreateNumbers().Take(6), Is.EqualTo(new []{ 1, 1, 2, 3, 5, 8 }));
        }
    }
}

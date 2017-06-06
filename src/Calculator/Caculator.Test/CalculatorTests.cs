using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator.Test
{
    using Calculator;

    using NUnit;
    using NUnit.Framework;

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void ShouldDoAdd()
        {
            var p = new Program();
            var result = p.Add(10, 10);
            Assert.That(result, Is.EqualTo(20));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.Test
{
    [TestFixture]
    public class CalculatorTests
    {
     [Test]
        public void Calculator_Addition()
        {
            double res = Calculator.add(2, 3);
            Assert.That(res, Is.EqualTo(2));
        }


    }
}

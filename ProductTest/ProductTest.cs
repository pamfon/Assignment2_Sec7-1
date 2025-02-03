using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2_Sec7_1;

namespace ProductTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SampleTest_ShouldPass_WhenValuesAreEqual()
        {
            // Arrange
            int number = 10;

            // Act
            int numberExpected = 10;

            // Assert
            Assert.That(number, Is.EqualTo(numberExpected));
        }
    }
}


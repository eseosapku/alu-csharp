using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        /// <summary>
        /// Tests the addition of two integers.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <returns>The sum of the two integers.</returns>
        [Test]
        public void Add_WhenCalled_ReturnsSumOfTwoNumbers()
        {
            // Arrange
            int a = 5;
            int b = 7;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(12, result);
        }
    }
}

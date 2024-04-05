using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
	/// <summary>
        /// Returns addition of two integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
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

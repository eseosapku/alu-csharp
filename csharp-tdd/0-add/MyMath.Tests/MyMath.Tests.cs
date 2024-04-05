using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// Contains unit tests for the <see cref="Operations"/> class.
    /// </summary>
    [TestFixture]
    public class OperationsTests
    {
        /// <summary>
        /// Verifies that the Add method returns the correct sum of two integers.
        /// </summary>
        [Test]
        public void Add_WhenCalled_ReturnsSumOfTwoNumbers()
        {
            // Arrange
            int a = 5;
            int b = 7;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(12)); // Using the constraint model
        }
    }
}

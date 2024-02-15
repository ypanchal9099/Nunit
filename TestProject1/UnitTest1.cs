using NUnit.Framework;
namespace NUnitDemonstration.Tests
{
    // This is class annotation
    [TestFixture]
    public class TriangleTests
    {
        // This is method annotation
        // Triangle sides are equal
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange - set up the initial conditions or inputs for the test.
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            // Act - perform the action or invoke the method being tested.
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        // There are the three sides are not equal so this is not a triangle
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange - set up the initial conditions or inputs for the test.
            int firstAngle = 90;
            int secondAngle = 45;
            int thirdAngle = 45;

            // Act - perform the action or invoke the method being tested.
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert - verify that the actual result matches the expected result
            Assert.AreEqual("The triangle is not valid.", result);
        }

        // Triangle sides are not equal
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage1()
        {
            // Add another test
            // Arrange - We set up the initial conditions or inputs for the test.
            int firstAngle = 25;
            int secondAngle = 36;
            int thirdAngle = 22;

            // Act - perform the action or invoke the method being tested.
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert - verify that the actual result matches the expected result
            Assert.AreEqual("The triangle is not valid.", result);  
        }

        // Add more test methods as needed to cover different scenarios
        // Two sides are equal 
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage2()
        {
            // Add another test
            // Arrange - set up the initial conditions or inputs for the test.
            int firstAngle = 20;
            int secondAngle = 20;
            int thirdAngle = 30;

            // Act - perform the action or invoke the method being tested.
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert - verify that the actual result matches the expected result
            Assert.AreEqual("The triangle is not valid.", result);
        }

        // One side is negative and other is positive
        [Test]
        public void ValisTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            // Add another test
            // Arrange - set up the initial conditions or inputs for the test.
            int firstAngle = -20;
            int secondAngle = 20;
            int thirdAngle = 30;

            // Act - perform the action or invoke the method being tested.
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert - verify that the actual result matches the expected result
            Assert.AreEqual("The triangle is Not valid.", result);
        }

        // Two sides are negative and other is positive
        [Test]
        public void ValisTriangle_InvalidInput_ReturnsInvalidMessage2()
        {
            // Add another test
            // Arrange - set up the initial conditions or inputs for the test.
            int firstAngle = 90;
            int secondAngle = -60;
            int thirdAngle = -30;

            // Act - perform the action or invoke the method being tested.
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert - verify that the actual result matches the expected result
            Assert.AreEqual("The triangle is Not valid.", result);
        }
    }
}


using NET22_WebApp;

namespace NET22_WebAppTest
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void VariableTest()
        {
            // Arrange
            Numbers num = new Numbers();
            var actual = num.Add(10, 12);
            var expected = 22;

            // Act

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VariableTest2()
        {
            // Arrange
            Numbers num = new Numbers();
            var actual = num.Add(11, 12);
            var expected = 22;

            // Act

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
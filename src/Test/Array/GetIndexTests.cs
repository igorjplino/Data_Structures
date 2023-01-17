using Array;

namespace Test.Array
{
    public class GetIndexTests
    {
        [Theory]
        [InlineData(50, 4)]
        [InlineData(20, 1)]
        public void WhenInformedExistingValue_ShouldReturnIndex(int value, long expectedIndex)
        {
            // Arrange
            var initialArray = new int[] { 10, 20, 30, 40, 50 };

            var array = new Array<int>();

            for (int i = 0; i < initialArray.Length; i++)
            {
                array.Append(initialArray[i]);
            }

            // Act

            var indexResult = array.GetIndex(value);

            // Assert
            Assert.Equal(expectedIndex, indexResult);
        }

        [Fact]
        public void WhenInformedNonExistingValue_ShouldReturnInvalidIndex()
        {
            // Arrange
            var initialArray = new int[] { 10, 20, 30, 40, 50 };

            var array = new Array<int>();

            for (int i = 0; i < initialArray.Length; i++)
            {
                array.Append(initialArray[i]);
            }

            // Act

            var indexResult = array.GetIndex(99);

            // Assert
            Assert.True(indexResult < 0);
        }
    }
}

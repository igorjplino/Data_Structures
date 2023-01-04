namespace Test.LinkedListTests
{
    public class GetValueByIndexTests
    {
        private readonly LinkedList.LinkedList<int> _linkedList;

        public GetValueByIndexTests()
        {
            _linkedList = new LinkedList.LinkedList<int>();
        }

        [Fact]
        public void GivenList_WhenGetValue_ShouldReturnExpectedValue()
        {
            // Arrange

            foreach (var item in Enumerable.Range(0, 10))
            {
                _linkedList.Append(item);
            }

            var expectedValue = 3;
            var index = 3;

            // Act
            var result = _linkedList.GetValueByIndex(index);

            // Assert
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void GivenList_WhenInformedIndexOutOfRange_ShouldThrowIndexOutOfRangeException()
        {
            // Arrange

            foreach (var item in Enumerable.Range(0, 10))
            {
                _linkedList.Append(item);
            }

            var index = 99;

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => _linkedList.GetValueByIndex(index));
        }
    }
}

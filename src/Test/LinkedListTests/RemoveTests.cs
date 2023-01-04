namespace Test.LinkedListTests
{
    public class RemoveTests
    {
        private readonly LinkedList.LinkedList<int> _linkedList;

        public RemoveTests()
        {
            _linkedList = new LinkedList.LinkedList<int>();
        }

        [Fact]
        public void GivenList_WhenRemoveValue_ShouldReturnInvalidIndexWhendInformedNonexistentValue()
        {
            // Arrange

            foreach (var item in Enumerable.Range(0, 10))
            {
                _linkedList.Append(item);
            }

            var valueToRemove = 9;

            // Act

            _linkedList.Remove(valueToRemove);

            // Assert

            var index = _linkedList.GetIndex(valueToRemove);
            Assert.True(index < 0);
        }

        [Fact]
        public void GivenEmptyList_WhenTryRemoveValue_ShouldThrowException()
        {
            // Arrange
            var valueToRemove = 9;

            // Act & Assert

            Assert.Throws<Exception>(() => _linkedList.Remove(valueToRemove));
        }

        [Fact]
        public void GivenList_WhenValueToRemoveDoesNotExist_ShouldThrowException()
        {
            // Arrange

            foreach (var item in Enumerable.Range(0, 10))
            {
                _linkedList.Append(item);
            }

            var valueToRemove = 99;

            // Assert
            Assert.Throws<Exception>(() => _linkedList.Remove(valueToRemove));
        }
    }
}

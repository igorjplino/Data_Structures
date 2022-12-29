namespace Test.LinkedListTests
{
    public class GetIndexTest
    {
        private readonly LinkedList.LinkedList<int> _linkedList;

        public GetIndexTest()
        {
            _linkedList = new LinkedList.LinkedList<int>();
        }

        [Fact]
        public void GivenList_ShouldReturnTheCorrectIndexOfInformedValue()
        {
            foreach (var item in Enumerable.Range(0, 10))
            {
                _linkedList.Append(item);
            }

            var expectedIndex = 7;
            
            var resultIndex = _linkedList.GetIndex(expectedIndex);

            Assert.Equal(expectedIndex, resultIndex);
        }

        [Fact]
        public void GivenList_ShouldReturnInvalidIndexWhendInformedNonexistentValue()
        {
            foreach (var item in Enumerable.Range(0, 10))
            {
                _linkedList.Append(item);
            }

            var resultIndex = _linkedList.GetIndex(99);

            Assert.True(resultIndex < 0);
        }
    }
}

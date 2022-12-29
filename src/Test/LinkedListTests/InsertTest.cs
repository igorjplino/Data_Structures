namespace Test.LinkedListTests
{
    public class InsertTest
    {
        private readonly LinkedList.LinkedList<int> _linkedList;

        public InsertTest()
        {
            _linkedList = new LinkedList.LinkedList<int>();
        }

        [Fact]
        public void InsertedNewValue_ShouldBeInSpecificIndex()
        {
            foreach (var item in Enumerable.Range(0, 10))
            {
                _linkedList.Append(item);
            }

            var newValue = 32;
            var index = 3;

            _linkedList.Insert(index, newValue);

            var resultValue = _linkedList[index];

            Assert.Equal(newValue, resultValue);
        }
    }
}

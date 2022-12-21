namespace Test.LinkedListTests
{
    public class AppendTests
    {
        private readonly LinkedList.LinkedList<int> _linkedList;

        public AppendTests()
        {
            _linkedList = new LinkedList.LinkedList<int>();
        }

        [Theory]
        [MemberData(nameof(SplitCountData))]
        public void WhenAddNewValues_ShouldHaveSameAmount(IEnumerable<int> values)
        {
            foreach (var value in values)
            {
                _linkedList.Append(value);
            }

            Assert.True(_linkedList.Length == values.Count());
        }

        public static IEnumerable<object[]> SplitCountData =>
            new List<object[]>
            {
                new object[] { Enumerable.Range(1, 5) },
                new object[] { Enumerable.Range(1, 10) },
                new object[] { Enumerable.Range(1, 15) },
                new object[] { Enumerable.Range(1, 20) },
            };
    }
}

namespace Test.StackTests
{
    public class PopTests
    {
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(50)]
        public void WhenPopValue_ShouldReturnLastValuePushed(int count)
        {
            // Arrange
            var stack = new Stack.Stack<int>();

            foreach (var item in Enumerable.Range(1, count))
            {
                stack.Push(item);
            }

            // Act

            var value = stack.Pop();

            // Assert
            Assert.Equal(count, value);
        }

        [Fact]
        public void WhenPopValues_ShouldReturnLastValuePushed()
        {
            // Arrange
            var items = new List<int> { 1, 2, 3, 4, 5 };

            var stack = new Stack.Stack<int>();

            foreach (var item in items)
            {
                stack.Push(item);
            }

            // Act & Asset

            foreach (var item in items.OrderByDescending(o => o))
            {
                var value = stack.Pop();

                Assert.Equal(item, value);

            }
        }

        [Fact]
        public void WhenPopEmptyStack_ShouldThrowException()
        {
            // Arrange
            var stack = new Stack.Stack<int>();

            // Act & Assert

            Assert.Throws<Exception>(() => stack.Pop());
        }
    }
}

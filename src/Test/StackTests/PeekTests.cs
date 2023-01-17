namespace Test.StackTests
{
    public class PeekTests
    {
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(50)]
        public void WhenPeekValue_ShouldReturnLastValuePushedAndKeepSameSize(int count)
        {
            // Arrange
            var stack = new Stack.Stack<int>();

            foreach (var item in Enumerable.Range(1, count))
            {
                stack.Push(item);
            }

            // Act

            var value = stack.Peek();

            // Assert
            Assert.Equal(count, value);
            Assert.Equal(count, stack.Length);
        }
    }
}

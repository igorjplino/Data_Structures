namespace Test.StackTests
{
    public class PushTests
    {
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(50)]
        public void WhenPushNewValue_ShouldIncreaseLength(int count)
        {
            // Arrange
            var stack = new Stack.Stack<int>();

            // Act

            foreach (var item in Enumerable.Range(0, count))
            {
                stack.Push(item);
            }

            // Assert

            Assert.Equal(count, stack.Length);
        }
    }
}

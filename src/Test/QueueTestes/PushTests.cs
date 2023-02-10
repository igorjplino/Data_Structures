namespace Test.QueueTests;

public class PushTests
{
    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(50)]
    public void WhenPushNewValue_ShouldIncreaseLength(int count)
    {
        // Arrange
        var queue = new Queue.Queue<int>();

        // Act

        foreach (var item in Enumerable.Range(0, count))
        {
            queue.Push(item);
        }

        // Assert
        Assert.Equal(count, queue.Length);
    }

    [Fact]
    public void WhenClearAllExistingItems_ShouldPushNewValues()
    {
        // Arrange
        var queue = new Queue.Queue<int>();

        var enumerable = Enumerable.Range(0, 10);

        foreach (var item in enumerable)
            queue.Push(item);
        
        foreach (var _ in enumerable)
            queue.Pop();

        var expectedValue = 99;

        // Act
        queue.Push(99);

        // Assert
        Assert.Equal(queue.Peek(), expectedValue);
    }
}

using BinaryTree;

namespace Test.BinaryTree.BinarySearchTreeTests;

public class MinAndMaxTests
{
    [Fact]
    public void WhenGivenValues_ShouldReturnMinValue()
    {
        // Arrange
        var bst = BinarySearchTreeMocks.GetExamples();

        // Act
        var result = bst.Min();

        // Assert
        var expectedValue = 11;
        Assert.Equal(expectedValue, result);
    }

    [Fact]
    public void WhenGivenValues_ShouldReturnMaxValue()
    {
        // Arrange
        var bst = BinarySearchTreeMocks.GetExamples();

        // Act
        var result = bst.Max();

        // Assert
        var expectedValue = 89;
        Assert.Equal(expectedValue, result);
    }
}

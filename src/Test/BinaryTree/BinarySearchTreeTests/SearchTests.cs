namespace Test.BinaryTree.BinarySearchTreeTests;

public class SearchTests
{
    [Fact]
    public void SearchValue_ShouldContainInTree()
    {
        // Arrange
        var bst = BinarySearchTreeMocks.GetExamples();

        // Act
        var expected = BinarySearchTreeMocks.ExampleValues.First();
        var result = bst.Search(expected);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SearchNonExistingValue_ShouldReturnNull()
    {
        // Arrange
        var bst = BinarySearchTreeMocks.GetExamples();

        // Act
        var nonExistingValue = BinarySearchTreeMocks.ExampleValues.Max() + 1;
        var result = bst.Search(nonExistingValue);

        // Assert
        Assert.Null(result);
    }
}

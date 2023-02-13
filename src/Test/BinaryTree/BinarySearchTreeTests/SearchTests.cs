using BinaryTree;

namespace Test.BinaryTree.BinarySearchTreeTests;

public class SearchTests
{
    [Fact]
    public void SearchValue_ShouldContainInTree()
    {
        // Arrange
        var random = new Random();
        var values = Enumerable.Range(0, 100).OrderBy(_ => random.Next()).ToList();

        var bst = new BinarySearchTree();

        // Act
        foreach (var value in values)
            bst.Insert(value);

        // Assert
        var expected = values.First();
        var result = bst.Search(expected);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void SearchNonExistingValue_ShouldReturnNull()
    {
        // Arrange
        var random = new Random(77);
        var values = Enumerable.Range(0, 100).OrderBy(_ => random.Next()).ToList();

        var bst = new BinarySearchTree();

        // Act
        foreach (var value in values)
            bst.Insert(value);

        // Assert
        var nonExistingValue = values.Max() + 1;
        var result = bst.Search(nonExistingValue);

        Assert.Null(result);
    }
}

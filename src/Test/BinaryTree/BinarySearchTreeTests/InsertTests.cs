using BinaryTree;

namespace Test.BinaryTree.BinarySearchTreeTests;

public class InsertTests
{
    [Fact]
    public void InsertedValues_ShouldContainInOrderTraversal()
    {
        // Arrange
        var random = new Random(77);
        var values = Enumerable.Range(0, 100).OrderBy(_ => random.Next()).ToList();

        var bst = new BinarySearchTree();

        // Act
        foreach (var value in values)
            bst.Insert(value);

        // Assert

        var result = bst.InOrderTraversal();

        result.Should()
            .Contain(values);
    }
}

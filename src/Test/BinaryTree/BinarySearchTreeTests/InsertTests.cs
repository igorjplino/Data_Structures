namespace Test.BinaryTree.BinarySearchTreeTests;

public class InsertTests
{
    [Fact]
    public void InsertedValues_ShouldContainInOrderTraversal()
    {
        // Arrange
        var bst = BinarySearchTreeMocks.GetExamples();

        // Act
        var result = bst.InOrderTraversal();

        // Assert
        result.Should()
            .Contain(BinarySearchTreeMocks.ExampleValues);
    }
}

using BinaryTree;

namespace Test.BinaryTree;

public class LevelOrderTraversalTests
{
    [Fact]
    public void GivenValues_ShouldBeDisplayedInLevelOrder()
    {
        // Arrange
        var items = new int[] { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };

        var bst = new BinarySearchTree();

        foreach (var item in items)
            bst.Insert(item);

        // Act
        var result = bst.LevelOrderTraversal();

        // Assert
        var expectedResult = new int[] { 61, 43, 89, 16, 51, 66, 11, 32, 55, 79, 77, 82 };

        result.Should()
            .NotBeNull()
            .And.HaveCount(expectedResult.Length)
            .And.Equal(expectedResult);
    }
}

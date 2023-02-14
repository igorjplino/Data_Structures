using BinaryTree;
using Test.BinaryTree.BinarySearchTreeTests;

namespace Test.BinaryTree;

public class LevelOrderTraversalTests
{
    [Fact]
    public void GivenValues_ShouldBeDisplayedInLevelOrder()
    {
        // Arrange
        var bst = BinarySearchTreeMocks.GetExamples();

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

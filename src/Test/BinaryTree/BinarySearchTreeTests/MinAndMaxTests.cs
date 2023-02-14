using BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Test.BinaryTree.BinarySearchTreeTests;

public class MinAndMaxTests
{
    [Fact]
    public void WhenGivenValues_ShouldReturnMinValue()
    {
        // Arrange
        var items = new int[] { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };

        var bst = new BinarySearchTree();

        foreach (var item in items)
            bst.Insert(item);

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
        var items = new int[] { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };

        var bst = new BinarySearchTree();

        foreach (var item in items)
            bst.Insert(item);

        // Act
        var result = bst.Max();

        // Assert
        var expectedValue = 89;
        Assert.Equal(expectedValue, result);
    }
}

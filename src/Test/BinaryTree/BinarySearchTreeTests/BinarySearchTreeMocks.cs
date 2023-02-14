using BinaryTree;
using System.Collections.ObjectModel;

namespace Test.BinaryTree.BinarySearchTreeTests;

public static class BinarySearchTreeMocks
{
    private static IEnumerable<int> _exampleValues = new int[] { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
    public static IEnumerable<int> ExampleValues => _exampleValues;

    public static BinarySearchTree GetExamples(IEnumerable<int>? values = null)
    {
        _exampleValues = values ?? _exampleValues;

        var bst = new BinarySearchTree();

        foreach (var value in _exampleValues)
            bst.Insert(value);

        return bst;
    }

    public static BinarySearchTree GetRandomExamples()
    {
        var random = new Random();
        _exampleValues = Enumerable.Range(0, 100).OrderBy(_ => random.Next());

        return GetExamples(_exampleValues);
    }
}
